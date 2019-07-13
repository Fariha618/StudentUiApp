using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentUiApp.Models.Models;

namespace StudentUiApp.Repository.Repository
{
    public class StudentRepository
    {
        string connectionString = @"Server=FARIHA; Database=StudentUiDB; Integrated Security=True";
        SqlConnection sqlConnection;

        private string commandString;
        private SqlCommand sqlCommand;

        SqlDataReader reader;

        public int InsertStudent(Student student)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"INSERT INTO Students (Name, RollNo, Contact, Email) VALUES ('" + student.Name + "', " + student.RollNo + ", " + student.Contact + ", '" + student.Email + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public DataTable ShowStudents()
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Students";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);        
            
            sqlConnection.Close();
            return dataTable;
        }

        public bool IsExistName(string Name)
        {
            bool isExist = false;

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Students WHERE Name = '"+ Name +"' ";
           
            try
            {
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    isExist = true;
                }
            }
            catch (Exception)
            {
                isExist = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return isExist;
        }

        public bool IsExistRollNo(int RollNo)
        {
            bool isExist = false;

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Students WHERE RollNo = '" + RollNo + "' ";

            try
            {
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    isExist = true;
                }
            }
            catch (Exception)
            {
                isExist = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return isExist;
        }

        public bool IsExistContact(int Contact)
        {
            bool isExist = false;

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Students WHERE Contact = '" + Contact + "' ";

            try
            {
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    isExist = true;
                }
            }
            catch (Exception)
            {
                isExist = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return isExist;
        }

        public bool IsExistEmail(string Email)
        {
            bool isExist = false;

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Students WHERE Email = '" + Email + "' ";

            try
            {
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    isExist = true;
                }
            }
            catch (Exception)
            {
                isExist = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return isExist;
        }

        public int UpdateStudent(Student student)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"UPDATE Students SET Name = '" +student.Name + "', RollNo = "+ student.RollNo +", Contact = " + student.Contact +", Email = '" + student.Email +"' WHERE Name= '" + student.oldName +"' ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public int DeleteStudent(Student student)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"DELETE FROM Students WHERE Name = '" + student.Name + "' ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public DataTable SearchStudent(Student student)
        {

            if (student.RollNo != 0)
                commandString = @"SELECT * FROM Students WHERE RollNo = "+ student.RollNo +" ";

            if (!String.IsNullOrEmpty(student.Name))
                commandString = @"SELECT * FROM Students WHERE Name LIKE'%" + student.Name + "%'";

            if (!String.IsNullOrEmpty(student.Name) && student.RollNo != 0)
                commandString = @"SELECT * FROM Students WHERE Name LIKE'%" + student.Name + "%' AND RollNo = "+ student.RollNo +" ";
            
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }
    }
}
