namespace CourseManagementSytem
{
    partial class InstructorForm
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
            this.pnlEnterInstructor = new System.Windows.Forms.Panel();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dataGridInstructor = new System.Windows.Forms.DataGridView();
            this.pnlTitleInstructor = new System.Windows.Forms.Panel();
            this.lblTitleInstructor = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlEnterInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInstructor)).BeginInit();
            this.pnlTitleInstructor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEnterInstructor
            // 
            this.pnlEnterInstructor.Controls.Add(this.btnDelete);
            this.pnlEnterInstructor.Controls.Add(this.btnSave);
            this.pnlEnterInstructor.Controls.Add(this.txtDepartment);
            this.pnlEnterInstructor.Controls.Add(this.lblDepartment);
            this.pnlEnterInstructor.Controls.Add(this.txtMail);
            this.pnlEnterInstructor.Controls.Add(this.lblMail);
            this.pnlEnterInstructor.Controls.Add(this.txtSurname);
            this.pnlEnterInstructor.Controls.Add(this.txtName);
            this.pnlEnterInstructor.Controls.Add(this.lblSurname);
            this.pnlEnterInstructor.Controls.Add(this.lblName);
            this.pnlEnterInstructor.Location = new System.Drawing.Point(12, 381);
            this.pnlEnterInstructor.Name = "pnlEnterInstructor";
            this.pnlEnterInstructor.Size = new System.Drawing.Size(359, 181);
            this.pnlEnterInstructor.TabIndex = 10;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(245, 26);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtDepartment.TabIndex = 10;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(174, 26);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "Department:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(232, 69);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 6;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(197, 69);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "Mail:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(66, 62);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(52, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(8, 62);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // dataGridInstructor
            // 
            this.dataGridInstructor.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInstructor.Location = new System.Drawing.Point(12, 52);
            this.dataGridInstructor.Name = "dataGridInstructor";
            this.dataGridInstructor.Size = new System.Drawing.Size(894, 323);
            this.dataGridInstructor.TabIndex = 11;
            // 
            // pnlTitleInstructor
            // 
            this.pnlTitleInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(217)))));
            this.pnlTitleInstructor.Controls.Add(this.lblTitleInstructor);
            this.pnlTitleInstructor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleInstructor.ForeColor = System.Drawing.Color.White;
            this.pnlTitleInstructor.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleInstructor.Name = "pnlTitleInstructor";
            this.pnlTitleInstructor.Size = new System.Drawing.Size(918, 46);
            this.pnlTitleInstructor.TabIndex = 17;
            // 
            // lblTitleInstructor
            // 
            this.lblTitleInstructor.AutoSize = true;
            this.lblTitleInstructor.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleInstructor.Location = new System.Drawing.Point(409, 10);
            this.lblTitleInstructor.Name = "lblTitleInstructor";
            this.lblTitleInstructor.Size = new System.Drawing.Size(111, 23);
            this.lblTitleInstructor.TabIndex = 0;
            this.lblTitleInstructor.Text = "Instructor";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(217)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(280, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(217)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(3, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 574);
            this.Controls.Add(this.pnlTitleInstructor);
            this.Controls.Add(this.dataGridInstructor);
            this.Controls.Add(this.pnlEnterInstructor);
            this.Name = "InstructorForm";
            this.Text = "InstructorForm";
            this.pnlEnterInstructor.ResumeLayout(false);
            this.pnlEnterInstructor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInstructor)).EndInit();
            this.pnlTitleInstructor.ResumeLayout(false);
            this.pnlTitleInstructor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEnterInstructor;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataGridInstructor;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Panel pnlTitleInstructor;
        private System.Windows.Forms.Label lblTitleInstructor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}