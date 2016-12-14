namespace UI
{
    partial class EmployeesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.dateDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.listEmployees = new System.Windows.Forms.ListView();
            this.txtPositionFilter = new System.Windows.Forms.TextBox();
            this.lblPositionFilter = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.grpDetails.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.dateDateOfBirth);
            this.grpDetails.Controls.Add(this.txtSalary);
            this.grpDetails.Controls.Add(this.lblSalary);
            this.grpDetails.Controls.Add(this.btnDelete);
            this.grpDetails.Controls.Add(this.lblDateOfBirth);
            this.grpDetails.Controls.Add(this.btnInsert);
            this.grpDetails.Controls.Add(this.txtPosition);
            this.grpDetails.Controls.Add(this.lblPosition);
            this.grpDetails.Controls.Add(this.txtLastName);
            this.grpDetails.Controls.Add(this.lblLastName);
            this.grpDetails.Controls.Add(this.lblFirstName);
            this.grpDetails.Controls.Add(this.txtFirstName);
            this.grpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpDetails.Location = new System.Drawing.Point(530, 26);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(280, 440);
            this.grpDetails.TabIndex = 0;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Регистрация сотрудника";
            // 
            // dateDateOfBirth
            // 
            this.dateDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDateOfBirth.Location = new System.Drawing.Point(9, 268);
            this.dateDateOfBirth.Name = "dateDateOfBirth";
            this.dateDateOfBirth.Size = new System.Drawing.Size(265, 22);
            this.dateDateOfBirth.TabIndex = 3;
            // 
            // txtSalary
            // 
            this.txtSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalary.Location = new System.Drawing.Point(9, 348);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(265, 22);
            this.txtSalary.TabIndex = 4;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(9, 310);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(132, 16);
            this.lblSalary.TabIndex = 13;
            this.lblSalary.Text = "Заработная плата:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(9, 398);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(9, 240);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(110, 16);
            this.lblDateOfBirth.TabIndex = 11;
            this.lblDateOfBirth.Text = "Дата рождения:";
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.Location = new System.Drawing.Point(164, 398);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(110, 32);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Сохранить";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // txtPosition
            // 
            this.txtPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPosition.Location = new System.Drawing.Point(9, 198);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(265, 22);
            this.txtPosition.TabIndex = 2;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPosition.Location = new System.Drawing.Point(9, 170);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(82, 16);
            this.lblPosition.TabIndex = 9;
            this.lblPosition.Text = "Должность:";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.Location = new System.Drawing.Point(9, 128);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(265, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.Location = new System.Drawing.Point(9, 100);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(70, 16);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Фамилия:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(37, 16);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "Имя:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstName.Location = new System.Drawing.Point(9, 58);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(265, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReport.Location = new System.Drawing.Point(530, 480);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(280, 32);
            this.btnReport.TabIndex = 7;
            this.btnReport.TabStop = false;
            this.btnReport.Text = "Отчет";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // listEmployees
            // 
            this.listEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listEmployees.FullRowSelect = true;
            this.listEmployees.GridLines = true;
            this.listEmployees.Location = new System.Drawing.Point(12, 112);
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(500, 400);
            this.listEmployees.TabIndex = 4;
            this.listEmployees.TabStop = false;
            this.listEmployees.UseCompatibleStateImageBehavior = false;
            this.listEmployees.View = System.Windows.Forms.View.Details;
            // 
            // txtPositionFilter
            // 
            this.txtPositionFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPositionFilter.Location = new System.Drawing.Point(115, 31);
            this.txtPositionFilter.Name = "txtPositionFilter";
            this.txtPositionFilter.Size = new System.Drawing.Size(182, 22);
            this.txtPositionFilter.TabIndex = 8;
            this.txtPositionFilter.TabStop = false;
            // 
            // lblPositionFilter
            // 
            this.lblPositionFilter.AutoSize = true;
            this.lblPositionFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPositionFilter.Location = new System.Drawing.Point(6, 34);
            this.lblPositionFilter.Name = "lblPositionFilter";
            this.lblPositionFilter.Size = new System.Drawing.Size(82, 16);
            this.lblPositionFilter.TabIndex = 6;
            this.lblPositionFilter.Text = "Должность:";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.lblPositionFilter);
            this.grpFilter.Controls.Add(this.txtPositionFilter);
            this.grpFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpFilter.Location = new System.Drawing.Point(12, 26);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(500, 70);
            this.grpFilter.TabIndex = 7;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Фильтр";
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 529);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.listEmployees);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.grpDetails);
            this.MaximizeBox = false;
            this.Name = "EmployeesForm";
            this.Text = "Staff Manager";
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ListView listEmployees;
        private System.Windows.Forms.TextBox txtPositionFilter;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.DateTimePicker dateDateOfBirth;
        private System.Windows.Forms.Label lblPositionFilter;
        private System.Windows.Forms.GroupBox grpFilter;
    }
}

