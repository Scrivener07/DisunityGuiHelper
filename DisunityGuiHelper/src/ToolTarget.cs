using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing;


// TODO: Add batching support.

namespace DisunityGuiHelper
{
	public partial class ToolWindow
	{


		// Browse Target
		///-----------------------------------------------------------------------------------
		private void TargetBrowseButton_OnClick(object sender, EventArgs e)
		{
			ShowFileBrowser(typefilter_UNITY);
			SetTargetPath(BrowseFileDialog.FileName);
		}



		private void DropZonePanel_OnDragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		

		private void DropZonePanel_OnDragDrop(object sender, DragEventArgs e)
		{
			string[] dzPath = (string[])e.Data.GetData(DataFormats.FileDrop, false);

			if (dzPath.Length > 1) //multi-target
			{
				this.WriteOutput(WarnNoBatch);
			}
			SetTargetPath(dzPath[0]);

			//for (int i = 0; i < dzPath.Length; i++)
			//{
			//	SetTargetPath(dzPath[i]);
			//}
		}



		private void SetTargetPath(string evalPath)
		{
			if (File.Exists(evalPath))
			{
				ProcessTarget = evalPath;
				TargetTextBox.Text = evalPath;
				WriteOutput("Pending File: " + evalPath);
			}
			else
			{
				ProcessTarget = null;
				TargetTextBox.Text = "Select a unity file to process.";
				WriteOutput("No file selected");
			}
		}



	}
}
