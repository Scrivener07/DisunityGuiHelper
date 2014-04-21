using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing;



namespace DisunityGuiHelper
{

	public partial class ToolWindow
	{


		// Guided Command
		///-----------------------------------------------------------------------------------
		private void SetupPresetSelection()
		{
			this.RunPresetSelection.Items.Clear();
			foreach (string item in DisunityHelper.CommandList)
			{
				this.RunPresetSelection.Items.Add(item);
			}
			this.RunPresetSelection.SelectedIndex = 0;
			RunPresetInput = this.RunPresetSelection.SelectedIndex;
		}



		private void RunPresetSelection_OnChangeCommitted(object sender, EventArgs e)
		{
			RunPresetInput = this.RunPresetSelection.SelectedIndex;
			WriteOutput("Pending Command: " + DisunityHelper.CommandList.ElementAt(RunPresetInput));
			UpdateHint();
			UpdateFilter();
		}



		// Filter
		///-----------------------------------------------------------------------------------
		private void FilterTextBox_OnTextChanged(object sender, EventArgs e)
		{
			ProcessFilter = this.FilterTextBox.Text.ToLower();
		}



		private void UpdateFilter()
		{
			Trace.WriteLine("Updating class filter controls..");

			if (UseExpert)
			{
				this.FilterLabel.Enabled = false;
				this.FilterLabel.Visible = false;
				this.FilterTextBox.Enabled = false;
				this.FilterTextBox.Visible = false;
			}
			else
			{
				bool CanUseFilter = (RunPresetInput == ATA4.IDExtract || RunPresetInput == ATA4.IDExtractRaw || RunPresetInput == ATA4.IDDump || RunPresetInput == ATA4.IDDumpStruct || RunPresetInput == ATA4.IDBundleExtract);

				if (CanUseFilter)
				{
					this.FilterLabel.Enabled = true;
					this.FilterLabel.Visible = true;
					this.FilterTextBox.Enabled = true;
					this.FilterTextBox.Visible = true;
					EnableSupport();
					this.WriteHint(ATA4.ClassFilterMessage);
				}
				else
				{
					this.FilterLabel.Enabled = false;
					this.FilterLabel.Visible = false;
					this.FilterTextBox.Enabled = false;
					this.FilterTextBox.Visible = false;
					EnableSupport(false);
				}
			}

		}











	}
}
