using Chips.Installer.Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chips.Installer.WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private IChipManager _chipManager;
        public MainForm(IChipManager chipManager)
        {
            _chipManager = chipManager;
            InitializeComponent();
            PopulateDataSourceComboBox();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string filePath = txtFilePath.Text;
                int chipId = Convert.ToInt32(txtAppliationId.Text);
                string dataSource = "CSV";

                //Pass parameters as a generic collection so that any number of parameters can be passed 
                Dictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("FilePath", filePath);
                parameters.Add("ChipId", chipId.ToString());
                parameters.Add("DataSource", dataSource);

                var chipsCount = _chipManager.GetMinimumChipsRequired(parameters);

                txtCopiesRequired.Text = chipsCount.ToString();                
            }
        }

        private void txtFilePath_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                e.Cancel = true;
                txtFilePath.Focus();
                errorProvider2.SetError(txtFilePath, "File Path can not be empty");
                errorProvider1.SetError(txtFilePath, "");
            }
            else if (!File.Exists(txtFilePath.Text))
            {
                e.Cancel = true;
                txtFilePath.Focus();
                errorProvider2.SetError(txtFilePath, "Datafile Not Found In The Given Location");
                errorProvider1.SetError(txtFilePath, "");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtFilePath, "");
                errorProvider1.SetError(txtFilePath, "Correct");
            }
        }

        private void txtAppliationId_Validating(object sender, CancelEventArgs e)
        {
            int n;
            if (string.IsNullOrEmpty(txtAppliationId.Text))
            {
                e.Cancel = true;
                txtAppliationId.Focus();
                errorProvider2.SetError(txtAppliationId, "Application Id can not be empty");
                errorProvider1.SetError(txtAppliationId, "");
            }
            else if (!int.TryParse(txtAppliationId.Text, out n))
            {
                e.Cancel = true;
                txtAppliationId.Focus();
                errorProvider2.SetError(txtAppliationId, "Application Id must be a numeric representation");
                errorProvider1.SetError(txtAppliationId, "");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtAppliationId, "");
                errorProvider1.SetError(txtAppliationId, "Correct");

            }
        }

        private void txtFilePath_MouseClick(object sender, MouseEventArgs e)
        {
            txtCopiesRequired.Text = "";
        }

        private void txtAppliationId_MouseClick(object sender, MouseEventArgs e)
        {
            txtCopiesRequired.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PopulateDataSourceComboBox()
        {
            cmbDataSource.Items.Add("CSV");
            cmbDataSource.Items.Add("EXCEL");
            cmbDataSource.SelectedIndex = cmbDataSource.FindStringExact("CSV");
        }
        
    }
}
