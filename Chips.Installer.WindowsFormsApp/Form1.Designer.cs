namespace Chips.Installer.WindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtAppliationId = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblAppId = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCopiesRequired = new System.Windows.Forms.TextBox();
            this.lblCopiesRequired = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(42, 503);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 15;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 102);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(131, 23);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtAppliationId
            // 
            this.txtAppliationId.Location = new System.Drawing.Point(205, 66);
            this.txtAppliationId.Name = "txtAppliationId";
            this.txtAppliationId.Size = new System.Drawing.Size(121, 20);
            this.txtAppliationId.TabIndex = 13;
            this.txtAppliationId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAppliationId_MouseClick);
            this.txtAppliationId.Validating += new System.ComponentModel.CancelEventHandler(this.txtAppliationId_Validating);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(205, 31);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(715, 20);
            this.txtFilePath.TabIndex = 11;
            this.txtFilePath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFilePath_MouseClick);
            this.txtFilePath.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilePath_Validating);
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.Location = new System.Drawing.Point(13, 66);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(71, 13);
            this.lblAppId.TabIndex = 12;
            this.lblAppId.Text = "Application Id";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(16, 31);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(48, 13);
            this.lblFilePath.TabIndex = 10;
            this.lblFilePath.Text = "File Path";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(167, 102);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCopiesRequired
            // 
            this.txtCopiesRequired.BackColor = System.Drawing.SystemColors.Info;
            this.txtCopiesRequired.Enabled = false;
            this.txtCopiesRequired.Location = new System.Drawing.Point(186, 45);
            this.txtCopiesRequired.Name = "txtCopiesRequired";
            this.txtCopiesRequired.Size = new System.Drawing.Size(124, 20);
            this.txtCopiesRequired.TabIndex = 8;
            // 
            // lblCopiesRequired
            // 
            this.lblCopiesRequired.AutoSize = true;
            this.lblCopiesRequired.Location = new System.Drawing.Point(20, 45);
            this.lblCopiesRequired.Name = "lblCopiesRequired";
            this.lblCopiesRequired.Size = new System.Drawing.Size(123, 13);
            this.lblCopiesRequired.TabIndex = 7;
            this.lblCopiesRequired.Text = "Minimum Chips Required";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCopiesRequired);
            this.groupBox1.Controls.Add(this.lblCopiesRequired);
            this.groupBox1.Location = new System.Drawing.Point(26, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 84);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFilePath);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Controls.Add(this.lblAppId);
            this.groupBox2.Controls.Add(this.txtAppliationId);
            this.groupBox2.Controls.Add(this.txtFilePath);
            this.groupBox2.Location = new System.Drawing.Point(26, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 166);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Chips Installer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtAppliationId;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCopiesRequired;
        private System.Windows.Forms.Label lblCopiesRequired;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

