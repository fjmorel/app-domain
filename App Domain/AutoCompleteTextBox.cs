using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace App_Domain {
	public class AutoCompleteTextbox : TextBox {

		public List<string> entireList;// list of possibilities
		public int selectedIndex {// index selected in the listbox
			get { return lboxSuggestions.SelectedIndex; }
			set { if (lboxSuggestions.Items.Count != 0) { lboxSuggestions.SelectedIndex = value; } }// can't be null
		}

		private ListBox lboxSuggestions;// the ListBox used for suggestions
		private Panel panel;// a Panel for displaying
		private Form ParentForm { get { return this.Parent.FindForm(); } }// the parent Form of this control
		private List<string> matchingList;// list of matching strings from entireList

		//Constructor
		public AutoCompleteTextbox()
			: base() {

			entireList = new List<string>();
			matchingList = new List<string>();

			lboxSuggestions = new ListBox();
			lboxSuggestions.Name = "SuggestionListBox";
			lboxSuggestions.Font = this.Font;
			lboxSuggestions.Visible = true;
			lboxSuggestions.Dock = DockStyle.Fill;// make the listbox fill the panel
			lboxSuggestions.SelectionMode = SelectionMode.One;
			lboxSuggestions.KeyDown += new KeyEventHandler(listBox_KeyDown);
			lboxSuggestions.MouseClick += new MouseEventHandler(listBox_MouseClick);
			lboxSuggestions.DataSource = matchingList;// Bind matchingList as DataSource to the listbox
			
			this.GotFocus += new EventHandler(AutoCompleteTextbox_GotFocus);
			
			//Will hold listbox
			panel = new Panel();
			panel.Visible = false;
			panel.Font = this.Font;
			panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			panel.ClientSize = new System.Drawing.Size(1, 1);
			panel.Name = "SuggestionPanel";
			panel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
			panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
			panel.Text = "";
			panel.PerformLayout();
			if (!panel.Controls.Contains(lboxSuggestions)) { this.panel.Controls.Add(lboxSuggestions); }

		}

		void AutoCompleteTextbox_GotFocus(object sender, EventArgs e) {
			OnTextChanged(e);
		}

		/// <summary>
		/// Hide panel, which hides the listbox
		/// </summary>
		public void HideSuggestionListBox() {
			if (ParentForm != null) {
				panel.Hide();//Also hides listbox

				if (ParentForm.Controls.Contains(panel)) {
					ParentForm.Controls.Remove(panel);// now remove it from the ParentForm
				}
			}
		}

		protected override void OnKeyDown(KeyEventArgs args) {
			if (args.KeyCode == Keys.Up) {
				MoveSelectionInListBox((selectedIndex - 1));// move the selection in listbox one up
				args.Handled = true;
			} else if (args.KeyCode == Keys.Down) {
				MoveSelectionInListBox((selectedIndex + 1));// move the selection in listbox one down
				args.Handled = true;
			} else if (args.KeyCode == Keys.PageUp) {
				MoveSelectionInListBox((selectedIndex - 10));// move the selection in listbox ten up
				args.Handled = true;
			} else if (args.KeyCode == Keys.PageDown) {
				MoveSelectionInListBox((selectedIndex + 10));// move the selection in listbox ten down
				args.Handled = true;
			} else if (args.KeyCode == Keys.Enter) {
				SelectItem();// select the item in the ListBox
				args.Handled = true;
				args.SuppressKeyPress = true;
			} else if (args.KeyCode == Keys.Tab) {
				SelectItem();// select the item in the ListBox
				args.Handled = true;
			} else if (args.KeyCode == Keys.Escape) {
				HideSuggestionListBox();
				args.Handled = true;
				args.SuppressKeyPress = true;
			} else {
				base.OnKeyDown(args);// Base class might process the event
			}
		}

		//Hide panel when the textbox loses focus
		protected override void OnLostFocus(System.EventArgs e) {
			if (!panel.ContainsFocus) {//Make sure the focus isn't in the panel
				base.OnLostFocus(e);// call the baseclass event
				HideSuggestionListBox();//Hide panel
			}
		}

		// if the input changes, call ShowSuggests()
		protected override void OnTextChanged(EventArgs args) {
			if (!this.DesignMode) {
				panel.SuspendLayout();// while loading data there is nothing to draw, so suspend layout

				matchingList.Clear();//Refill AutoComplete list

				/*Trying to allow writing 2nd word before 1st word in account name
				List<int> spaceIndexes = new List<int>();
				spaceIndexes.Add(-1);
				while (spaceIndexes[spaceIndexes.Count - 1] > -1) {
					spaceIndexes.Add(this.Text.IndexOf(" "));
				}
				List<string> desiredStrings = new List<string>();
				if (spaceIndexes.Count > 1) {
					for (int i = 1; i == spaceIndexes.Count -1; i++) {
						desiredStrings.Add(this.Text.Substring(spaceIndexes[i], spaceIndexes[i + 1] - spaceIndexes[1]));
					}
				} else {
					desiredStrings.Add(this.Text);
				}
				foreach (string Str in entireList) {
					foreach (string each in desiredStrings) {
						if (Str.ToLower().IndexOf(each) > -1) {
							matchingList.Add(Str);//put everything in lowercase and add matching strings to list
						}
					}
				}
				*/
				
				foreach (string Str in entireList) {
					if (Str.ToLower().IndexOf(this.Text.ToLower()) > -1) {
						matchingList.Add(Str);//put everything in lowercase and add matching strings to list
					}
				}
				
				//Add items to listbox
				if ((ParentForm != null)) {
					panel.Width = this.Width;
					panel.Height = this.ParentForm.ClientSize.Height - this.Height - this.Location.Y;
					panel.Location = this.Location + new Size(0, this.Height);

					// Panel and ListBox have to be added to ParentForm.Controls before calling BindingContext
					if (!this.ParentForm.Controls.Contains(panel)) { this.ParentForm.Controls.Add(panel); }

					// Update the lboxSuggestions manually - List<string> dosn't support change events
					((CurrencyManager)lboxSuggestions.BindingContext[matchingList]).Refresh();
				}

				//Show suggestions
				if (((matchingList != null) && matchingList.Count > 0)) {
					panel.Show();
					panel.BringToFront();
					Focus();//Put focus back in textbox
				} else {
					HideSuggestionListBox();// or hide if no results
				}
				panel.ResumeLayout(true);// prevent overlapping problems with other controls
			}
			base.OnTextChanged(args);
		}

		// event for any key pressed in the ListBox
		private void listBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				SelectItem();
				e.Handled = true;
			} else {
				base.OnKeyDown(e);
			}
		}

		// Select item when it is clicked
		private void listBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e) {
			SelectItem();
		}

		private void MoveSelectionInListBox(int Index) {
			if (Index <= -1) {// Move to beginning of list
				selectedIndex = 0;
			} else if (Index > (lboxSuggestions.Items.Count - 1)) {// Move to end of list
				selectedIndex = (lboxSuggestions.Items.Count - 1);
			} else {// Move to specified index
				selectedIndex = Index;
			}
		}

		// Selects current item (moves text to textbox) and hides panel
		private void SelectItem() {
			if (this.lboxSuggestions.Items.Count > 0 && this.selectedIndex > -1) {
				this.Text = this.lboxSuggestions.SelectedItem.ToString();
				HideSuggestionListBox();
			}
		}

	}//end class
}//end namespace