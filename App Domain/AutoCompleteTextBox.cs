using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace App_Domain {

	/// <summary>
	/// Extension of Textbox that stores a list of strings to do autocomplete matching
	/// </summary>
	public class AutoCompleteTextbox : TextBox {

		/// <summary>
		/// Entire list of possibilities to check
		/// </summary>
		public List<string> entireList;
		/// <summary>
		/// index selected in the listbox
		/// </summary>
		public int selectedIndex {
			get { return lboxSuggestions.SelectedIndex; }
			set { if (lboxSuggestions.Items.Count != 0) { lboxSuggestions.SelectedIndex = value; } }// can't be null
		}

		/// <summary>
		/// the ListBox used for suggestions
		/// </summary>
		private ListBox lboxSuggestions;
		/// <summary>
		/// Panel to display listbox
		/// </summary>
		private Panel panel;
		/// <summary>
		/// Reference to parent form
		/// </summary>
		private Form ParentForm { get { return this.Parent.FindForm(); } }
		/// <summary>
		/// Matching strings
		/// </summary>
		private List<string> matchingList;

		/// <summary>
		/// Constructor
		/// </summary>
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

		/// <summary>
		/// When it gains focus, show listbox
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// Process key events
		/// </summary>
		/// <param name="args"></param>
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

		/// <summary>
		/// Hide panel when the textbox loses focus
		/// </summary>
		/// <param name="e"></param>
		protected override void OnLostFocus(System.EventArgs e) {
			if (!panel.ContainsFocus) {//Make sure the focus isn't in the panel
				base.OnLostFocus(e);// call the baseclass event
				HideSuggestionListBox();//Hide panel
			}
		}

		/// <summary>
		/// if the input changes, call ShowSuggests()
		/// </summary>
		/// <param name="args"></param>
		protected override void OnTextChanged(EventArgs args) {
			if (!this.DesignMode) {
				panel.SuspendLayout();// while loading data there is nothing to draw, so suspend layout

				matchingList.Clear();//Refill AutoComplete list

				
				string[] words = this.Text.Trim().Split(' ');

				foreach(string Str in entireList){
					int count = 0;
					foreach (string each in words) {
						if (Str.ToLower().IndexOf(each.ToLower()) > -1){
							count++;
						}
					}
					if (count == words.Length) {
						matchingList.Add(Str);
					}
				}

				//Add items to listbox
				if ((ParentForm != null)) {
					panel.Width = this.Width;
					panel.Height = this.ParentForm.ClientSize.Height - this.Height - this.Location.Y;
					panel.Location = this.Location + new Size(0, this.Height);

					// Panel and ListBox have to be added to ParentForm.Controls before calling BindingContext
					if (!this.ParentForm.Controls.Contains(panel)) {this.ParentForm.Controls.Add(panel); }

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

		/// <summary>
		/// event for any key pressed in the ListBox
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
 		private void listBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				SelectItem();
				e.Handled = true;
			} else {
				base.OnKeyDown(e);
			}
		}

		/// <summary>
		/// Select item when it is clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
 		private void listBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e) {
			SelectItem();
		}

		/// <summary>
		/// Move selection to new index
		/// </summary>
		/// <param name="Index"></param>
		private void MoveSelectionInListBox(int Index) {
			if (Index <= -1) {// Move to beginning of list
				selectedIndex = 0;
			} else if (Index > (lboxSuggestions.Items.Count - 1)) {// Move to end of list
				selectedIndex = (lboxSuggestions.Items.Count - 1);
			} else {// Move to specified index
				selectedIndex = Index;
			}
		}

		/// <summary>
		/// Selects current item (moves text to textbox) and hides panel
		/// </summary>
		private void SelectItem() {
			if (this.lboxSuggestions.Items.Count > 0 && this.selectedIndex > -1) {
				this.Text = this.lboxSuggestions.SelectedItem.ToString();
				HideSuggestionListBox();
			}
		}

	}//end class
}//end namespace