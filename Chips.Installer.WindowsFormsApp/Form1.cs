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
        //private readonly IDataProcessor _dataProcessor;
        public MainForm() //(IDataProcessor dataProcessor)
        {
            //_dataProcessor = dataProcessor;
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string filePath = txtFilePath.Text;
                int appId = Convert.ToInt32(txtAppliationId.Text);
                //DataHandlerSource dataSource = DataHandlerSource.ExcelHandler; //Default Value

                //var minCopies = _dataProcessor.GetMinimumCopiesForApplication(filePath, appId, dataSource);

                //txtCopiesRequired.Text = minCopies.ToString();

                txtCopiesRequired.Text = "Not Yet Implemented";
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
        
    }
}
