namespace Prog2
{
    partial class Program2
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.singleRadioBtn = new System.Windows.Forms.RadioButton();
            this.radioButtonGroup = new System.Windows.Forms.GroupBox();
            this.headHouseRadioBtn = new System.Windows.Forms.RadioButton();
            this.marriedSepRadioBtn = new System.Windows.Forms.RadioButton();
            this.marriedJointRadioBtn = new System.Windows.Forms.RadioButton();
            this.taxIncomeLbl = new System.Windows.Forms.Label();
            this.taxIncomeTxt = new System.Windows.Forms.TextBox();
            this.marginalRateLbl = new System.Windows.Forms.Label();
            this.outMarginalTaxLbl = new System.Windows.Forms.Label();
            this.incomeTaxLbl = new System.Windows.Forms.Label();
            this.outIncomeTaxLbl = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.radioButtonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(240, 397);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(183, 51);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate Tax";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // singleRadioBtn
            // 
            this.singleRadioBtn.AutoSize = true;
            this.singleRadioBtn.Checked = true;
            this.singleRadioBtn.Location = new System.Drawing.Point(29, 30);
            this.singleRadioBtn.Name = "singleRadioBtn";
            this.singleRadioBtn.Size = new System.Drawing.Size(103, 29);
            this.singleRadioBtn.TabIndex = 1;
            this.singleRadioBtn.TabStop = true;
            this.singleRadioBtn.Text = "Single";
            this.singleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroup
            // 
            this.radioButtonGroup.Controls.Add(this.headHouseRadioBtn);
            this.radioButtonGroup.Controls.Add(this.marriedSepRadioBtn);
            this.radioButtonGroup.Controls.Add(this.marriedJointRadioBtn);
            this.radioButtonGroup.Controls.Add(this.singleRadioBtn);
            this.radioButtonGroup.Location = new System.Drawing.Point(167, 148);
            this.radioButtonGroup.Name = "radioButtonGroup";
            this.radioButtonGroup.Size = new System.Drawing.Size(318, 197);
            this.radioButtonGroup.TabIndex = 2;
            this.radioButtonGroup.TabStop = false;
            this.radioButtonGroup.Text = "Fliling Status";
            // 
            // headHouseRadioBtn
            // 
            this.headHouseRadioBtn.AutoSize = true;
            this.headHouseRadioBtn.Location = new System.Drawing.Point(29, 101);
            this.headHouseRadioBtn.Name = "headHouseRadioBtn";
            this.headHouseRadioBtn.Size = new System.Drawing.Size(227, 29);
            this.headHouseRadioBtn.TabIndex = 4;
            this.headHouseRadioBtn.TabStop = true;
            this.headHouseRadioBtn.Text = "Head of Household";
            this.headHouseRadioBtn.UseVisualStyleBackColor = true;
            // 
            // marriedSepRadioBtn
            // 
            this.marriedSepRadioBtn.AutoSize = true;
            this.marriedSepRadioBtn.Location = new System.Drawing.Point(29, 136);
            this.marriedSepRadioBtn.Name = "marriedSepRadioBtn";
            this.marriedSepRadioBtn.Size = new System.Drawing.Size(289, 29);
            this.marriedSepRadioBtn.TabIndex = 3;
            this.marriedSepRadioBtn.Text = "Married Filing Separately ";
            this.marriedSepRadioBtn.UseVisualStyleBackColor = true;
            // 
            // marriedJointRadioBtn
            // 
            this.marriedJointRadioBtn.AutoSize = true;
            this.marriedJointRadioBtn.Location = new System.Drawing.Point(29, 66);
            this.marriedJointRadioBtn.Name = "marriedJointRadioBtn";
            this.marriedJointRadioBtn.Size = new System.Drawing.Size(242, 29);
            this.marriedJointRadioBtn.TabIndex = 2;
            this.marriedJointRadioBtn.Text = "Married Filing Jointly";
            this.marriedJointRadioBtn.UseVisualStyleBackColor = true;
            // 
            // taxIncomeLbl
            // 
            this.taxIncomeLbl.AutoSize = true;
            this.taxIncomeLbl.Location = new System.Drawing.Point(120, 75);
            this.taxIncomeLbl.Name = "taxIncomeLbl";
            this.taxIncomeLbl.Size = new System.Drawing.Size(170, 25);
            this.taxIncomeLbl.TabIndex = 3;
            this.taxIncomeLbl.Text = "Taxable Income:";
            // 
            // taxIncomeTxt
            // 
            this.taxIncomeTxt.Location = new System.Drawing.Point(311, 72);
            this.taxIncomeTxt.Name = "taxIncomeTxt";
            this.taxIncomeTxt.Size = new System.Drawing.Size(207, 31);
            this.taxIncomeTxt.TabIndex = 4;
            // 
            // marginalRateLbl
            // 
            this.marginalRateLbl.AutoSize = true;
            this.marginalRateLbl.Location = new System.Drawing.Point(120, 488);
            this.marginalRateLbl.Name = "marginalRateLbl";
            this.marginalRateLbl.Size = new System.Drawing.Size(194, 25);
            this.marginalRateLbl.TabIndex = 5;
            this.marginalRateLbl.Text = "Marginal Tax Rate:";
            // 
            // outMarginalTaxLbl
            // 
            this.outMarginalTaxLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outMarginalTaxLbl.Location = new System.Drawing.Point(386, 487);
            this.outMarginalTaxLbl.Name = "outMarginalTaxLbl";
            this.outMarginalTaxLbl.Size = new System.Drawing.Size(132, 25);
            this.outMarginalTaxLbl.TabIndex = 6;
            // 
            // incomeTaxLbl
            // 
            this.incomeTaxLbl.AutoSize = true;
            this.incomeTaxLbl.Location = new System.Drawing.Point(185, 525);
            this.incomeTaxLbl.Name = "incomeTaxLbl";
            this.incomeTaxLbl.Size = new System.Drawing.Size(129, 25);
            this.incomeTaxLbl.TabIndex = 7;
            this.incomeTaxLbl.Text = "Income Tax:";
            // 
            // outIncomeTaxLbl
            // 
            this.outIncomeTaxLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outIncomeTaxLbl.Location = new System.Drawing.Point(386, 524);
            this.outIncomeTaxLbl.Name = "outIncomeTaxLbl";
            this.outIncomeTaxLbl.Size = new System.Drawing.Size(132, 25);
            this.outIncomeTaxLbl.TabIndex = 8;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(191, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(256, 25);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "2019 Tax Rate Calculator";
            // 
            // Program2
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 632);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.outIncomeTaxLbl);
            this.Controls.Add(this.incomeTaxLbl);
            this.Controls.Add(this.outMarginalTaxLbl);
            this.Controls.Add(this.marginalRateLbl);
            this.Controls.Add(this.taxIncomeTxt);
            this.Controls.Add(this.taxIncomeLbl);
            this.Controls.Add(this.radioButtonGroup);
            this.Controls.Add(this.calculateBtn);
            this.Name = "Program2";
            this.Text = "Program 2";
            this.radioButtonGroup.ResumeLayout(false);
            this.radioButtonGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.RadioButton singleRadioBtn;
        private System.Windows.Forms.GroupBox radioButtonGroup;
        private System.Windows.Forms.RadioButton headHouseRadioBtn;
        private System.Windows.Forms.RadioButton marriedSepRadioBtn;
        private System.Windows.Forms.RadioButton marriedJointRadioBtn;
        private System.Windows.Forms.Label taxIncomeLbl;
        private System.Windows.Forms.TextBox taxIncomeTxt;
        private System.Windows.Forms.Label marginalRateLbl;
        private System.Windows.Forms.Label outMarginalTaxLbl;
        private System.Windows.Forms.Label incomeTaxLbl;
        private System.Windows.Forms.Label outIncomeTaxLbl;
        private System.Windows.Forms.Label titleLabel;
    }
}

