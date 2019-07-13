namespace StudentUiApp
{
    partial class StudentUi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.rollNoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.rollNoLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.displayStudents = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EditButton = new System.Windows.Forms.Button();
            this.SI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteLink = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.displayStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roll No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(77, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(213, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // rollNoTextBox
            // 
            this.rollNoTextBox.Location = new System.Drawing.Point(373, 43);
            this.rollNoTextBox.Name = "rollNoTextBox";
            this.rollNoTextBox.Size = new System.Drawing.Size(110, 20);
            this.rollNoTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(77, 103);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(213, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(557, 43);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(194, 20);
            this.contactTextBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(325, 101);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(509, 101);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Red;
            this.nameLabel.Location = new System.Drawing.Point(77, 70);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 15);
            this.nameLabel.TabIndex = 11;
            // 
            // rollNoLabel
            // 
            this.rollNoLabel.AutoSize = true;
            this.rollNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollNoLabel.ForeColor = System.Drawing.Color.Red;
            this.rollNoLabel.Location = new System.Drawing.Point(325, 71);
            this.rollNoLabel.Name = "rollNoLabel";
            this.rollNoLabel.Size = new System.Drawing.Size(0, 15);
            this.rollNoLabel.TabIndex = 12;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.ForeColor = System.Drawing.Color.Red;
            this.contactLabel.Location = new System.Drawing.Point(509, 71);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(0, 15);
            this.contactLabel.TabIndex = 13;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Red;
            this.emailLabel.Location = new System.Drawing.Point(77, 142);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(0, 15);
            this.emailLabel.TabIndex = 14;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(600, 101);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // displayStudents
            // 
            this.displayStudents.AutoGenerateColumns = false;
            this.displayStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SI,
            this.Name,
            this.RollNo,
            this.Contact,
            this.Email,
            this.deleteLink});
            this.displayStudents.DataSource = this.studentBindingSource;
            this.displayStudents.Location = new System.Drawing.Point(80, 166);
            this.displayStudents.Name = "displayStudents";
            this.displayStudents.Size = new System.Drawing.Size(692, 295);
            this.displayStudents.TabIndex = 16;
            this.displayStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayStudents_CellContentClick);
            this.displayStudents.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.displayStudents_RowPostPaint);
            this.displayStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.displayStudents_MouseDoubleClick);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(StudentUiApp.Models.Models.Student);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(417, 101);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 18;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SI
            // 
            this.SI.HeaderText = "SI";
            this.SI.Name = "SI";
            this.SI.Width = 50;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 150;
            // 
            // RollNo
            // 
            this.RollNo.DataPropertyName = "RollNo";
            this.RollNo.HeaderText = "Roll No";
            this.RollNo.Name = "RollNo";
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // deleteLink
            // 
            this.deleteLink.DataPropertyName = "ID";
            this.deleteLink.HeaderText = "Action";
            this.deleteLink.Name = "deleteLink";
            // 
            // StudentUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.displayStudents);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.rollNoLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.rollNoTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
          
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.StudentUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox rollNoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label rollNoLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label emailLabel;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridView displayStudents;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SI;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewLinkColumn deleteLink;
    }
}

