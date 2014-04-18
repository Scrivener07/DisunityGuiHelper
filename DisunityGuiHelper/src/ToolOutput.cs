using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;



namespace DisunityGuiHelper
{

    /// <summary>
    /// A RichTextBox that behaves similar to a console output window.
    /// </summary>
	public partial class ToolWindow
	{

		public void WriteOutput(string text)
		{
			string output = "[GUI]\n" + text + "\n";
			this.OutputBox.AppendText(output);
			this.OutputBox.ScrollToCaret();
			Debug.WriteLine(output);
		}


		private void ClearOutput()
		{
			this.OutputBox.Lines = new string[] { "" };
		}


		private void SaveLogOutputButton_OnClick(object sender, EventArgs e)
		{
			ShowSaveFileBrowser(this.OutputBox.Text, typefilter_TEXT);
		}


		private void ClearLogOutputButton_OnClick(object sender, EventArgs e)
		{
			ClearOutput();
		}


	}
}
