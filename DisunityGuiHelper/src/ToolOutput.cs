using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


// TODO: UseScrollToEnd does not hold position

namespace DisunityGuiHelper
{

    /// <summary>
    /// A RichTextBox that behaves similar to a console output window.
    /// </summary>
	public partial class ToolWindow
	{

		public int CurrentColumn
		{
			get { return this.OutputBox.SelectionStart - this.OutputBox.GetFirstCharIndexOfCurrentLine() + 1; }
		}

		public int CurrentLine
		{
			get { return this.OutputBox.GetLineFromCharIndex(this.OutputBox.SelectionStart) + 1; }
		}


		// Output
		///-----------------------------------------------------------------------------------
		
		private void SetupOutput()
		{
			this.OutputBox.HideSelection = false;
			this.OutputBox.ShowSelectionMargin = true;
		}




		public void WriteOutput(string text)
		{
			string output = text + Environment.NewLine + Environment.NewLine;
			if (UseScrollToEnd)
			{
				this.OutputBox.AppendText(output);
			}
			else
			{
				this.OutputBox.Text += output;
			}
		}



		private void ClearOutput()
		{
			this.OutputBox.Lines = new string[] { "" };
		}



		private void HightlightText()
		{
			if (UseHighlightLine)
			{
				this.OutputBox.Select(this.OutputBox.SelectionStart, this.OutputBox.SelectionLength);
				this.OutputBox.SelectionBackColor = Color.Khaki;			
			}
		}



		private void ClearHightlights()
		{
			string s = this.OutputBox.Text;
			this.OutputBox.Clear();
			this.OutputBox.Text = s;
		}






		// Events
		///-----------------------------------------------------------------------------------
		///
		private void ToggleUseLineHightlight_CheckedChanged(object sender, EventArgs e)
		{
			UseHighlightLine = this.ToggleUseLineHightlight.Checked;

			if (!UseHighlightLine)
			{
				ClearHightlights();
			}
		}


		private void OutputBox_OnClick(object sender, EventArgs e)
		{
			Trace.WriteLine("Line:" + CurrentLine + ", Column:" + CurrentColumn);
		}


		private void OutputBox_SelectionChanged(object sender, EventArgs e)
		{
		}
		

		private void OutputBox_TextChanged(object sender, EventArgs e)
		{
		}


		private void OutputBox_MouseUp(object sender, MouseEventArgs e)
		{
			HightlightText();
		}


		private void OutputBox_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			Process.Start(e.LinkText);
		}


		private void SaveLogOutputButton_OnClick(object sender, EventArgs e)
		{
			ShowSaveFileBrowser(this.OutputBox.Text, typefilter_TEXT);
		}


		private void ClearLogOutputButton_OnClick(object sender, EventArgs e)
		{
			ClearOutput();
		}



		// Message
		///-----------------------------------------------------------------------------------
		private void WriteWelcome()
		{
			this.WriteOutput("To get started, choose a file or directory with the browse button or drag and drop one onto the drop zone.\n" +
				"Configure the file process by selecting a command from the drop down menu. Click execute when ready.\n" +
				"You may also save to file or clear this output windows content at any time.");
		}



		public void WriteInfo()
		{
			Trace.WriteLine("Writing tool window values..\n" +
				"\nDisunityHelper: " + DisunityHelper.ToString() +
				"\nUseExpert: " + UseExpert +
				"\nUseVerbose: " + UseVerbose +
				"\nUseTarget: " + UseTarget +
				"\nUseScrollToEnd: " + UseScrollToEnd +
				"\nUserCommandPresetInput: " + RunPresetInput +
				"\nUserCommandManualInput: " + RunExpertInput +
				"\nProcessTarget: " + ProcessTarget +
				"\nProcessFilter: " + ProcessFilter);
		}



	}
}
