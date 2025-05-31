namespace УП_PR8.Forms
{
    partial class ApplicantEditForm
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
            this.dataGridApplicants = new System.Windows.Forms.DataGridView();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxEducation = new System.Windows.Forms.TextBox();
            this.textBoxQualification = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.dateTimePickerFillDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFio = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelEducation = new System.Windows.Forms.Label();
            this.labelQualification = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelFillDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplicants)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridApplicants
            // 
            this.dataGridApplicants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridApplicants.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.dataGridApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridApplicants.Location = new System.Drawing.Point(12, 12);
            this.dataGridApplicants.Name = "dataGridApplicants";
            this.dataGridApplicants.RowHeadersWidth = 51;
            this.dataGridApplicants.Size = new System.Drawing.Size(1260, 300);
            this.dataGridApplicants.TabIndex = 0;
            this.dataGridApplicants.SelectionChanged += new System.EventHandler(this.dataGridApplicants_SelectionChanged);
            // 
            // textBoxFio
            // 
            this.textBoxFio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.textBoxFio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFio.Location = new System.Drawing.Point(63, 90);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(265, 35);
            this.textBoxFio.TabIndex = 2;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(63, 158);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerBirthDate.TabIndex = 4;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.comboBoxGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(63, 234);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(265, 35);
            this.comboBoxGender.TabIndex = 6;
            // 
            // textBoxEducation
            // 
            this.textBoxEducation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.textBoxEducation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEducation.Location = new System.Drawing.Point(371, 90);
            this.textBoxEducation.Name = "textBoxEducation";
            this.textBoxEducation.Size = new System.Drawing.Size(265, 35);
            this.textBoxEducation.TabIndex = 10;
            // 
            // textBoxQualification
            // 
            this.textBoxQualification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.textBoxQualification.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQualification.Location = new System.Drawing.Point(371, 158);
            this.textBoxQualification.Name = "textBoxQualification";
            this.textBoxQualification.Size = new System.Drawing.Size(265, 35);
            this.textBoxQualification.TabIndex = 12;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.textBoxSalary.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSalary.Location = new System.Drawing.Point(371, 234);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(265, 35);
            this.textBoxSalary.TabIndex = 14;
            this.textBoxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalary_KeyPress);
            // 
            // dateTimePickerFillDate
            // 
            this.dateTimePickerFillDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.dateTimePickerFillDate.Location = new System.Drawing.Point(371, 310);
            this.dateTimePickerFillDate.Name = "dateTimePickerFillDate";
            this.dateTimePickerFillDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerFillDate.TabIndex = 20;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(53)))));
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(63, 497);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(575, 57);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(53)))));
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(63, 561);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(575, 54);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFio.Location = new System.Drawing.Point(57, 60);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(64, 27);
            this.labelFio.TabIndex = 1;
            this.labelFio.Text = "ФИО";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthDate.Location = new System.Drawing.Point(57, 129);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(165, 27);
            this.labelBirthDate.TabIndex = 3;
            this.labelBirthDate.Text = "Дата рождения";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(57, 204);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(53, 27);
            this.labelGender.TabIndex = 5;
            this.labelGender.Text = "Пол";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.Location = new System.Drawing.Point(57, 281);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(127, 27);
            this.labelPosition.TabIndex = 7;
            this.labelPosition.Text = "Должность";
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEducation.Location = new System.Drawing.Point(365, 60);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(144, 27);
            this.labelEducation.TabIndex = 9;
            this.labelEducation.Text = "Образование";
            // 
            // labelQualification
            // 
            this.labelQualification.AutoSize = true;
            this.labelQualification.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQualification.Location = new System.Drawing.Point(365, 129);
            this.labelQualification.Name = "labelQualification";
            this.labelQualification.Size = new System.Drawing.Size(164, 27);
            this.labelQualification.TabIndex = 11;
            this.labelQualification.Text = "Квалификация";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSalary.Location = new System.Drawing.Point(365, 204);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(216, 27);
            this.labelSalary.TabIndex = 13;
            this.labelSalary.Text = "Предполагаемая з/п";
            // 
            // labelFillDate
            // 
            this.labelFillDate.AutoSize = true;
            this.labelFillDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFillDate.Location = new System.Drawing.Point(365, 281);
            this.labelFillDate.Name = "labelFillDate";
            this.labelFillDate.Size = new System.Drawing.Size(183, 27);
            this.labelFillDate.TabIndex = 19;
            this.labelFillDate.Text = "Дата заполнения";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.textBoxPosition);
            this.groupBox1.Controls.Add(this.textBoxFio);
            this.groupBox1.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBox1.Controls.Add(this.comboBoxGender);
            this.groupBox1.Controls.Add(this.textBoxEducation);
            this.groupBox1.Controls.Add(this.textBoxQualification);
            this.groupBox1.Controls.Add(this.textBoxSalary);
            this.groupBox1.Controls.Add(this.dateTimePickerFillDate);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.labelFio);
            this.groupBox1.Controls.Add(this.labelBirthDate);
            this.groupBox1.Controls.Add(this.labelGender);
            this.groupBox1.Controls.Add(this.labelPosition);
            this.groupBox1.Controls.Add(this.labelEducation);
            this.groupBox1.Controls.Add(this.labelQualification);
            this.groupBox1.Controls.Add(this.labelSalary);
            this.groupBox1.Controls.Add(this.labelFillDate);
            this.groupBox1.Location = new System.Drawing.Point(600, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 650);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.textBoxPosition.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPosition.Location = new System.Drawing.Point(63, 311);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(265, 35);
            this.textBoxPosition.TabIndex = 26;
            // 
            // ApplicantEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 1000);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridApplicants);
            this.Name = "ApplicantEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApplicantEditForm_FormClosed);
            this.Load += new System.EventHandler(this.ApplicantEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplicants)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridApplicants;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxEducation;
        private System.Windows.Forms.TextBox textBoxQualification;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.DateTimePicker dateTimePickerFillDate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.Label labelQualification;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelFillDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBoxPosition;
    }
}