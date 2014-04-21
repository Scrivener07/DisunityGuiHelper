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
		private bool UseExpert = false;
		private bool UseVerbose = false;
		private bool UseTarget = true;
		private bool UseScrollToEnd = true;
		private bool UseHighlightLine = false;
		private int RunPresetInput = 0;
		private string RunExpertInput = null;
		private string ProcessTarget = null;
		private string ProcessFilter = null;


		public ToolWindow()
		{
			InitializeComponent();
			DisunityHelper = new ATA4();
			Setup();
			WriteWelcome();
		}


		private void Setup()
		{
			SetupOutput();
			SetupOptions();
			SetupPresetSelection();
			SetCommandMode(UseExpert);
		}


		private void SetupOptions()
		{
			this.TargetTextBox.Text = "Select a file or directory to process.";
			this.ToggleUseExpert.Checked = UseExpert;
			this.ToggleUseTarget.Checked = UseTarget;
			this.ToggleUseVerbose.Checked = UseVerbose;
			this.ToggleUseScrollToEnd.Checked = UseScrollToEnd;
			this.ToggleUseLineHightlight.Checked = UseHighlightLine;
		}



		private void SetCommandMode(bool isExpert)
		{
			if (isExpert)
			{
				this.ToggleUseTarget.Enabled = true;
				this.ToggleUseVerbose.Enabled = false;
				this.RunExpertSelection.Enabled = true;
				this.RunExpertSelection.Visible = true;
				this.RunPresetSelection.Enabled = false;
				this.RunPresetSelection.Visible = false;
				this.RunExpertSelection.Dock = DockStyle.Fill;
				this.FilterTextBox.Enabled = false;
				this.FilterTextBox.Visible = false;
				this.WriteOutput("Expert Mode: Visit https://github.com/ata4/disunity for additional command usage information.");
				EnableSupport(false);
			}
			else
			{
				UseTarget = true; 
				this.ToggleUseTarget.Enabled = false; 
				this.ToggleUseTarget.Checked = UseTarget;
				this.ToggleUseVerbose.Enabled = true;
				this.RunExpertSelection.Enabled = false;
				this.RunExpertSelection.Visible = false;
				this.RunExpertSelection.Dock = DockStyle.None;
				this.RunPresetSelection.Enabled = true;
				this.RunPresetSelection.Visible = true;
				UpdateFilter();
			}

			UpdateHint();
			this.WriteInfo();
		}




		// Toggles and Options
		///-----------------------------------------------------------------------------------
		private void ToggleUseExpert_OnCheckedChanged(object sender, EventArgs e)
		{
			UseExpert = this.ToggleUseExpert.Checked;
			SetCommandMode(UseExpert);
		}


		private void ToggleUseVerbose_OnCheckedChanged(object sender, EventArgs e)
		{
			UseVerbose = this.ToggleUseVerbose.Checked;
		}


		private void ToggleUseTarget_OnCheckedChanged(object sender, EventArgs e)
		{
			UseTarget = this.ToggleUseTarget.Checked;
			if (!UseTarget)
			{
				SetTargetPath(null);
			}
		}


		private void ToggleUseScrollToEnd_OnCheckedChanged(object sender, EventArgs e)
		{
			UseScrollToEnd = this.ToggleUseScrollToEnd.Checked;
		}



		// Selection
		///-----------------------------------------------------------------------------------
		private void RunExpertSelection_OnTextChanged(object sender, EventArgs e)
		{
			RunExpertInput = this.RunExpertSelection.Text;
		}



		// Execute
		///-----------------------------------------------------------------------------------
		private void ExecuteButton_OnClick(object sender, EventArgs e)
		{
			Execute();
		}


		private void RunExpertSelection_OnKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				Execute();
			}
		}


		private void FilterTextBox_OnKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				Execute();
			}
		}



		private void Execute()
		{
			if (IsBusy) //TODO: isBusy/return does not block multiple execution. Must fix before batching.
			{
				return;
			}
			else
			{
				SetBusyLight();
				string result;
				if (UseExpert)
				{
					if (UseTarget)
					{
						result = DisunityHelper.RequestCommand(RunExpertInput, ProcessTarget);
					}
					else
					{
						result = DisunityHelper.RequestCommand(RunExpertInput, null);
					}
				}
				else
				{
					result = DisunityHelper.RequestPreset(UseVerbose, RunPresetInput, ProcessTarget, ProcessFilter);
				}
				this.WriteOutput(result);
				SetReadyLight();
			}
		}







	}
}
