using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace DisunityGuiHelper
{
	public partial class ToolWindow : Form
	{

		private ATA4 DisunityHelper;
		private string TargetFilePath = null;
		private string SearchClassFilter = null;
		private int ExecuteCommandIndex = 0;



		public ToolWindow()
		{
			InitializeComponent();
			DisunityHelper = new ATA4();
			SetupCommandSelection();
			SetupBrowseTarget();
			this.WriteOutput("To get started, choose a file with the target button or drag and drop a file onto the drop zone.\n" +
				"Configure the file process by selecting a command from the drop down menu. Click execute when ready.\n" + 
				"You may also save to file or clear this output windows content at any time."
				);
		}



		// Browse Target
		///-----------------------------------------------------------------------------------
		private void SetupBrowseTarget()
		{
			BrowseTargetTextBox.Text = "Select a unity file to process.";
		}



		private void BrowseTargetButton_OnClick(object sender, EventArgs e)
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

			for (int i = 0; i < dzPath.Length; i++)
			{
				SetTargetPath(dzPath[i]);
			}
		}


		private void SetTargetPath(string evalPath)
		{
			if (File.Exists(evalPath))
			{
				TargetFilePath = evalPath;
				BrowseTargetTextBox.Text = evalPath;
				WriteOutput("Pending File: " + evalPath);
			}
			else
			{
				TargetFilePath = null;
				BrowseTargetTextBox.Text = "Select a unity file to process.";
				WriteOutput("File" + evalPath + " does not exist.");
			}
		}



		// Command Selection
		///-----------------------------------------------------------------------------------

		private void SetupCommandSelection()
		{
			foreach (string item in DisunityHelper.CommandList)
			{
				CommandSelectionCombo.Items.Add(item);
			}
			CommandSelectionCombo.SelectedIndex = 0;

			UpdateCommandHint();
		}


		private void CommandSelectionCombo_OnSelectionChangeCommitted(object sender, EventArgs e)
		{
			ExecuteCommandIndex = CommandSelectionCombo.SelectedIndex;
			WriteOutput("Pending Command: " + ExecuteCommandIndex);

			if (ExecuteCommandIndex == ATA4.IDExtract)
			{
				ClassFilterTextBox.Enabled = true;
				ClassFilterTextBox.Text = "";
			}
			else
			{
				ClassFilterTextBox.Enabled = false;
				ClassFilterTextBox.Text = null;
			}
			UpdateCommandHint();
		}


		private void UpdateCommandHint()
		{
			CommandSelectionHintText.Text = DisunityHelper.CommandHintList[CommandSelectionCombo.SelectedIndex];
		}





		// Class Filter
		///-----------------------------------------------------------------------------------
		private void ClassFilterTextBox_OnTextChanged(object sender, EventArgs e)
		{
			SearchClassFilter = ClassFilterTextBox.Text;
			this.WriteOutput(SearchClassFilter);
		}



		// Execute
		///-----------------------------------------------------------------------------------

		private void ExecuteButton_OnClick(object sender, EventArgs e)
		{
			SetBusyLight();

			if (!String.IsNullOrEmpty(SearchClassFilter))
			{
				this.WriteOutput(DisunityHelper.RequestCommand(TargetFilePath, ExecuteCommandIndex, SearchClassFilter));
			}
			else
			{
				this.WriteOutput(DisunityHelper.RequestCommand(TargetFilePath, ExecuteCommandIndex));
			}
			SetReadyLight();
		}



		// Application Status
		///-----------------------------------------------------------------------------------

		public void SetBusyLight()
		{
			this.BusyIndicator.BackColor = Color.IndianRed;
			this.BusyStatusLabel.Text = "Busy";
			this.CommandSelectionHintText.Text = "The application is busy processing your command..\nPlease dont try to interact with or exit this application until it is ready.".Replace("\n", Environment.NewLine);
			this.BusyIndicator.Refresh();
			this.BusyStatusLabel.Refresh();
			this.CommandSelectionHintText.Refresh();
		}



		public void SetReadyLight()
		{
			this.BusyIndicator.BackColor = Color.MediumSeaGreen;
			this.BusyStatusLabel.Text = "Ready";
			this.BusyIndicator.Refresh();
			this.BusyStatusLabel.Refresh();
			UpdateCommandHint();
		}
















	}
}
