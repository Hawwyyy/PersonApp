namespace PersonApp
{
    partial class MenuPage
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
            panel1 = new Panel();
            lblHeader = new Label();
            panelPerson = new Panel();
            btnCreatePerson = new Button();
            txtAddress = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelStudent = new Panel();
            btnCreateStudent = new Button();
            txtStudentID = new TextBox();
            label4 = new Label();
            panelResults = new Panel();
            lblResults = new Label();
            lstDetails = new ListBox();
            panel1.SuspendLayout();
            panelPerson.SuspendLayout();
            panelStudent.SuspendLayout();
            panelResults.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 52, 154);
            panel1.Controls.Add(lblHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 60);
            panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(20, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(190, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Person Management";
            // 
            // panelPerson
            // 
            panelPerson.BackColor = Color.White;
            panelPerson.BorderStyle = BorderStyle.FixedSingle;
            panelPerson.Controls.Add(btnCreatePerson);
            panelPerson.Controls.Add(txtAddress);
            panelPerson.Controls.Add(txtAge);
            panelPerson.Controls.Add(txtName);
            panelPerson.Controls.Add(label3);
            panelPerson.Controls.Add(label2);
            panelPerson.Controls.Add(label1);
            panelPerson.Location = new Point(20, 80);
            panelPerson.Name = "panelPerson";
            panelPerson.Size = new Size(320, 180);
            panelPerson.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(80, 80, 80);
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(80, 80, 80);
            label2.Location = new Point(15, 60);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 1;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(80, 80, 80);
            label3.Location = new Point(15, 100);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(95, 18);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 25);
            txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(95, 58);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(200, 25);
            txtAge.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(95, 98);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 25);
            txtAddress.TabIndex = 5;
            // 
            // btnCreatePerson
            // 
            btnCreatePerson.BackColor = Color.FromArgb(45, 52, 154);
            btnCreatePerson.FlatAppearance.BorderSize = 0;
            btnCreatePerson.FlatStyle = FlatStyle.Flat;
            btnCreatePerson.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreatePerson.ForeColor = Color.White;
            btnCreatePerson.Location = new Point(95, 135);
            btnCreatePerson.Name = "btnCreatePerson";
            btnCreatePerson.Size = new Size(200, 30);
            btnCreatePerson.TabIndex = 6;
            btnCreatePerson.Text = "Create Person";
            btnCreatePerson.UseVisualStyleBackColor = false;
            btnCreatePerson.Click += btnCreatePerson_Click;
            // 
            // panelStudent
            // 
            panelStudent.BackColor = Color.White;
            panelStudent.BorderStyle = BorderStyle.FixedSingle;
            panelStudent.Controls.Add(btnCreateStudent);
            panelStudent.Controls.Add(txtStudentID);
            panelStudent.Controls.Add(label4);
            panelStudent.Location = new Point(360, 80);
            panelStudent.Name = "panelStudent";
            panelStudent.Size = new Size(320, 180);
            panelStudent.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(80, 80, 80);
            label4.Location = new Point(15, 20);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 8;
            label4.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            txtStudentID.BorderStyle = BorderStyle.FixedSingle;
            txtStudentID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentID.Location = new Point(95, 18);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(200, 25);
            txtStudentID.TabIndex = 9;
            // 
            // btnCreateStudent
            // 
            btnCreateStudent.BackColor = Color.FromArgb(45, 52, 154);
            btnCreateStudent.FlatAppearance.BorderSize = 0;
            btnCreateStudent.FlatStyle = FlatStyle.Flat;
            btnCreateStudent.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateStudent.ForeColor = Color.White;
            btnCreateStudent.Location = new Point(95, 58);
            btnCreateStudent.Name = "btnCreateStudent";
            btnCreateStudent.Size = new Size(200, 30);
            btnCreateStudent.TabIndex = 10;
            btnCreateStudent.Text = "Create Student";
            btnCreateStudent.UseVisualStyleBackColor = false;
            btnCreateStudent.Click += btnCreateStudent_Click_1;
            // 
            // panelResults
            // 
            panelResults.BackColor = Color.White;
            panelResults.BorderStyle = BorderStyle.FixedSingle;
            panelResults.Controls.Add(lblResults);
            panelResults.Controls.Add(lstDetails);
            panelResults.Location = new Point(20, 280);
            panelResults.Name = "panelResults";
            panelResults.Size = new Size(660, 200);
            panelResults.TabIndex = 3;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblResults.ForeColor = Color.FromArgb(45, 52, 154);
            lblResults.Location = new Point(15, 10);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(59, 20);
            lblResults.TabIndex = 0;
            lblResults.Text = "Results";
            // 
            // lstDetails
            // 
            lstDetails.BackColor = Color.FromArgb(245, 245, 250);
            lstDetails.BorderStyle = BorderStyle.FixedSingle;
            lstDetails.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstDetails.FormattingEnabled = true;
            lstDetails.ItemHeight = 17;
            lstDetails.Location = new Point(15, 38);
            lstDetails.Name = "lstDetails";
            lstDetails.Size = new Size(628, 140);
            lstDetails.TabIndex = 7;
            // 
            // MenuPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(700, 500);
            Controls.Add(panelResults);
            Controls.Add(panelStudent);
            Controls.Add(panelPerson);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MenuPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person Application";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelPerson.ResumeLayout(false);
            panelPerson.PerformLayout();
            panelStudent.ResumeLayout(false);
            panelStudent.PerformLayout();
            panelResults.ResumeLayout(false);
            panelResults.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblHeader;
        private Panel panelPerson;
        private Button btnCreatePerson;
        private TextBox txtAddress;
        private TextBox txtAge;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panelStudent;
        private Button btnCreateStudent;
        private TextBox txtStudentID;
        private Label label4;
        private Panel panelResults;
        private Label lblResults;
        private ListBox lstDetails;
    }
}