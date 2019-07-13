using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentUiApp.Models.Models;
using StudentUiApp.BLL.BLL;


namespace StudentUiApp
{
    public partial class StudentUi : Form
    {
        StudentManager _studentManager = new StudentManager();
        private Student student;

        public StudentUi()
        {
            InitializeComponent();
            student = new Student();
        }

        private void StudentUi_Load(object sender, EventArgs e)
        {
            displayStudents.DataSource = _studentManager.ShowStudents();

            deleteLink.LinkColor = Color.Black;
            deleteLink.Text = "Delete";
            deleteLink.TrackVisitedState = true;
            deleteLink.UseColumnTextForLinkValue = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {              

                if (String.IsNullOrEmpty(nameTextBox.Text))
                {
                    nameLabel.Text = "Name Field is Empty!";
                    return;
                }

                nameLabel.Text = " ";

                if (_studentManager.IsExistName(nameTextBox.Text))
                {
                    nameLabel.Text = "Student's Name Already Exists";
                    nameTextBox.Clear();
                    return;
                }
                nameLabel.Text = " ";

                student.Name = nameTextBox.Text;

                
                if (String.IsNullOrEmpty(rollNoTextBox.Text))
                {
                    rollNoLabel.Text = "Roll No. Field is Empty!";
                    return;
                }

                rollNoLabel.Text = " ";

                if (System.Text.RegularExpressions.Regex.IsMatch(rollNoTextBox.Text, "[^0-9]"))
                {
                    rollNoLabel.Text = "Enter Only Digits";
                    rollNoTextBox.Clear();
                    return;
                }
                rollNoLabel.Text = "";

                if (_studentManager.IsExistRollNo(Convert.ToInt32(rollNoTextBox.Text)))
                {
                    rollNoLabel.Text = "Roll No. Already Exists";
                    rollNoTextBox.Clear();
                    return;
                }
                rollNoLabel.Text = " ";                

                student.RollNo = Convert.ToInt32(rollNoTextBox.Text);

                
                if (String.IsNullOrEmpty(contactTextBox.Text))
                {
                    contactLabel.Text = "Contact Field is Empty!";
                    return;
                }

                contactLabel.Text = " ";

                if (System.Text.RegularExpressions.Regex.IsMatch(contactTextBox.Text, "[^0-9]"))
                {
                    contactLabel.Text = "Enter Only Digits";
                    contactTextBox.Clear();
                    return;
                }
                contactLabel.Text = "";
                
                if (_studentManager.IsExistContact(Convert.ToInt32(contactTextBox.Text)))
                {
                    contactLabel.Text = "Contact Already Exists";
                    contactTextBox.Clear();
                    return;
                }
                contactLabel.Text = " ";               

                student.Contact = Convert.ToInt32(contactTextBox.Text);

               
                if (String.IsNullOrEmpty(emailTextBox.Text))
                {
                    emailLabel.Text = "Email Field is Empty!";
                    return;
                }

                emailLabel.Text = " ";

                if (_studentManager.IsExistEmail(emailTextBox.Text))
                {
                    emailLabel.Text = "Email Already Exists";
                    emailTextBox.Clear();
                    return;
                }
                emailLabel.Text = " ";

                student.Email = emailTextBox.Text;

                int isExecuted;
                isExecuted = _studentManager.InsertStudent(student);

                if (isExecuted > 0)
                {
                    MessageBox.Show("Student Added Successfully");
                }
                else
                {
                    MessageBox.Show("Not Added");
                }

                displayStudents.DataSource = _studentManager.ShowStudents();

                nameTextBox.Clear();
                rollNoTextBox.Clear();
                contactTextBox.Clear();
                emailTextBox.Clear();

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = displayStudents.SelectedCells[0].RowIndex;
                student.oldName = displayStudents.Rows[i].Cells[1].Value.ToString();

                if (String.IsNullOrEmpty(nameTextBox.Text))
                {
                    nameLabel.Text = "Name Field is Empty!";
                    return;
                }

                nameLabel.Text = " ";                

                student.Name = nameTextBox.Text;


                if (String.IsNullOrEmpty(rollNoTextBox.Text))
                {
                    rollNoLabel.Text = "Roll No. Field is Empty!";
                    return;
                }

                rollNoLabel.Text = " ";

                if (System.Text.RegularExpressions.Regex.IsMatch(rollNoTextBox.Text, "[^0-9]"))
                {
                    rollNoLabel.Text = "Enter Only Digits";
                    rollNoTextBox.Clear();
                    return;
                }
                rollNoLabel.Text = "";               

                student.RollNo = Convert.ToInt32(rollNoTextBox.Text);


                if (String.IsNullOrEmpty(contactTextBox.Text))
                {
                    contactLabel.Text = "Contact Field is Empty!";
                    return;
                }

                contactLabel.Text = " ";

                if (System.Text.RegularExpressions.Regex.IsMatch(contactTextBox.Text, "[^0-9]"))
                {
                    contactLabel.Text = "Enter Only Digits";
                    contactTextBox.Clear();
                    return;
                }
                contactLabel.Text = "";

                student.Contact = Convert.ToInt32(contactTextBox.Text);


                if (String.IsNullOrEmpty(emailTextBox.Text))
                {
                    emailLabel.Text = "Email Field is Empty!";
                    return;
                }

                emailLabel.Text = " ";

                student.Email = emailTextBox.Text;

                int isExecuted;
                isExecuted = _studentManager.UpdateStudent(student);

                if (isExecuted > 0)
                {
                    MessageBox.Show("Student Update Successfully");
                }
                else
                {
                    MessageBox.Show("Not Updated");
                }

                displayStudents.DataSource = _studentManager.ShowStudents();

                nameTextBox.Clear();
                rollNoTextBox.Clear();
                contactTextBox.Clear();
                emailTextBox.Clear();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
       

        private void SearchButton_Click(object sender, EventArgs e)
        {

            student.Name = nameTextBox.Text;

            if(String.IsNullOrEmpty(rollNoTextBox.Text))
            {
                student.RollNo = 0;
            }
            else
            {
                student.RollNo = Convert.ToInt32(rollNoTextBox.Text);

            }
            
            if(displayStudents.DataSource == null)
            {
                MessageBox.Show("No Data Found!");
            }

            displayStudents.DataSource = _studentManager.SearchStudent(student);

            nameTextBox.Clear();
            rollNoTextBox.Clear();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            rollNoTextBox.Clear();
            contactTextBox.Clear();
            emailTextBox.Clear();
        }

        private void displayStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (displayStudents.SelectedCells.Count > 0)
            {
                int i;
                i = displayStudents.SelectedCells[0].RowIndex;
                nameTextBox.Text = displayStudents.Rows[i].Cells[1].Value.ToString();
                rollNoTextBox.Text = displayStudents.Rows[i].Cells[2].Value.ToString();
                contactTextBox.Text = displayStudents.Rows[i].Cells[3].Value.ToString();
                emailTextBox.Text = displayStudents.Rows[i].Cells[4].Value.ToString();

            }

        }

        private void displayStudents_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            displayStudents.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void displayStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                try
                {
                    student.Name = displayStudents.Rows[e.RowIndex].Cells[1].Value.ToString();

                    int isExecuted;
                    isExecuted = _studentManager.DeleteStudent(student);

                    if (isExecuted > 0)
                    {
                        MessageBox.Show("Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Not Deleted");
                    }

                    displayStudents.DataSource = _studentManager.ShowStudents();                    

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }              
                
            }

        }
    }
}
