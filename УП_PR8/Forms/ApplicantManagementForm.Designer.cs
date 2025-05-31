namespace УП_PR8
{
    partial class ApplicantManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicantManagementForm));
            this.panelVacancyDetails = new System.Windows.Forms.Panel();
            this.labelConditions = new System.Windows.Forms.Label();
            this.labelDuties = new System.Windows.Forms.Label();
            this.labelOtherInfo = new System.Windows.Forms.Label();
            this.labelLanguages = new System.Windows.Forms.Label();
            this.labelDriving = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.labelCompany = new System.Windows.Forms.Label();
            this.flowLayoutPanelApplicants = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonViewApplicants = new System.Windows.Forms.Button();
            this.panelVacancyDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVacancyDetails
            // 
            this.panelVacancyDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVacancyDetails.Controls.Add(this.buttonViewApplicants);
            this.panelVacancyDetails.Controls.Add(this.labelConditions);
            this.panelVacancyDetails.Controls.Add(this.labelDuties);
            this.panelVacancyDetails.Controls.Add(this.labelOtherInfo);
            this.panelVacancyDetails.Controls.Add(this.labelLanguages);
            this.panelVacancyDetails.Controls.Add(this.labelDriving);
            this.panelVacancyDetails.Controls.Add(this.comboBoxPosition);
            this.panelVacancyDetails.Controls.Add(this.labelPosition);
            this.panelVacancyDetails.Controls.Add(this.comboBoxCompany);
            this.panelVacancyDetails.Controls.Add(this.labelCompany);
            this.panelVacancyDetails.Location = new System.Drawing.Point(33, 15);
            this.panelVacancyDetails.Margin = new System.Windows.Forms.Padding(4);
            this.panelVacancyDetails.Name = "panelVacancyDetails";
            this.panelVacancyDetails.Size = new System.Drawing.Size(958, 250);
            this.panelVacancyDetails.TabIndex = 0;
            // 
            // labelConditions
            // 
            this.labelConditions.AutoSize = true;
            this.labelConditions.Location = new System.Drawing.Point(13, 160);
            this.labelConditions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConditions.Name = "labelConditions";
            this.labelConditions.Size = new System.Drawing.Size(107, 16);
            this.labelConditions.TabIndex = 11;
            this.labelConditions.Text = "Условия труда:";
            // 
            // labelDuties
            // 
            this.labelDuties.AutoSize = true;
            this.labelDuties.Location = new System.Drawing.Point(13, 135);
            this.labelDuties.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDuties.Name = "labelDuties";
            this.labelDuties.Size = new System.Drawing.Size(187, 16);
            this.labelDuties.TabIndex = 10;
            this.labelDuties.Text = "Должностные обязанности:";
            // 
            // labelOtherInfo
            // 
            this.labelOtherInfo.AutoSize = true;
            this.labelOtherInfo.Location = new System.Drawing.Point(13, 111);
            this.labelOtherInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOtherInfo.Name = "labelOtherInfo";
            this.labelOtherInfo.Size = new System.Drawing.Size(113, 16);
            this.labelOtherInfo.TabIndex = 9;
            this.labelOtherInfo.Text = "Др.информация:";
            // 
            // labelLanguages
            // 
            this.labelLanguages.AutoSize = true;
            this.labelLanguages.Location = new System.Drawing.Point(13, 86);
            this.labelLanguages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLanguages.Name = "labelLanguages";
            this.labelLanguages.Size = new System.Drawing.Size(141, 16);
            this.labelLanguages.TabIndex = 8;
            this.labelLanguages.Text = "Иностранные языки:";
            // 
            // labelDriving
            // 
            this.labelDriving.AutoSize = true;
            this.labelDriving.Location = new System.Drawing.Point(13, 62);
            this.labelDriving.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDriving.Name = "labelDriving";
            this.labelDriving.Size = new System.Drawing.Size(78, 16);
            this.labelDriving.TabIndex = 7;
            this.labelDriving.Text = "Вод.права:";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(133, 37);
            this.comboBoxPosition.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(265, 24);
            this.comboBoxPosition.TabIndex = 3;
            this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosition_SelectedIndexChanged);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(13, 37);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(81, 16);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "Должность:";
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(133, 12);
            this.comboBoxCompany.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(265, 24);
            this.comboBoxCompany.TabIndex = 1;
            this.comboBoxCompany.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompany_SelectedIndexChanged);
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(13, 12);
            this.labelCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(98, 16);
            this.labelCompany.TabIndex = 0;
            this.labelCompany.Text = "Предприятие:";
            // 
            // flowLayoutPanelApplicants
            // 
            this.flowLayoutPanelApplicants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelApplicants.AutoScroll = true;
            this.flowLayoutPanelApplicants.Location = new System.Drawing.Point(23, 269);
            this.flowLayoutPanelApplicants.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelApplicants.Name = "flowLayoutPanelApplicants";
            this.flowLayoutPanelApplicants.Size = new System.Drawing.Size(983, 400);
            this.flowLayoutPanelApplicants.TabIndex = 2;
            // 
            // buttonViewApplicants
            // 
            this.buttonViewApplicants.Location = new System.Drawing.Point(4, 209);
            this.buttonViewApplicants.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewApplicants.Name = "buttonViewApplicants";
            this.buttonViewApplicants.Size = new System.Drawing.Size(125, 37);
            this.buttonViewApplicants.TabIndex = 3;
            this.buttonViewApplicants.Text = "Просмотр";
            this.buttonViewApplicants.UseVisualStyleBackColor = true;
            this.buttonViewApplicants.Click += new System.EventHandler(this.buttonViewApplicants_Click);
            // 
            // ApplicantManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 677);
            this.Controls.Add(this.flowLayoutPanelApplicants);
            this.Controls.Add(this.panelVacancyDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ApplicantManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Центр занятости";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApplicantManagementForm_FormClosed);
            this.panelVacancyDetails.ResumeLayout(false);
            this.panelVacancyDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVacancyDetails;
        private System.Windows.Forms.Label labelConditions;
        private System.Windows.Forms.Label labelDuties;
        private System.Windows.Forms.Label labelOtherInfo;
        private System.Windows.Forms.Label labelLanguages;
        private System.Windows.Forms.Label labelDriving;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelApplicants;
        private System.Windows.Forms.Button buttonViewApplicants;
    }
}
