using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using StudentUiApp.Models.Models;
using StudentUiApp.Repository.Repository;

namespace StudentUiApp.BLL.BLL
{
    public class StudentManager
    {
        Student student = new Student();
        StudentRepository _studentRepository = new StudentRepository();
        

        public int InsertStudent(Student student)
        {
            return _studentRepository.InsertStudent(student);
        }

        public DataTable ShowStudents()
        {
            return _studentRepository.ShowStudents();
        }

        public bool IsExistName(string Name)
        {
            bool isExist = _studentRepository.IsExistName(Name);
            return isExist;
        }

        public bool IsExistRollNo(int RollNo)
        {
            bool isExist = _studentRepository.IsExistRollNo(RollNo);
            return isExist;
        }

        public bool IsExistContact(int Contact)
        {
            bool isExist = _studentRepository.IsExistContact(Contact);
            return isExist;
        }

        public bool IsExistEmail(string Email)
        {
            bool isExist = _studentRepository.IsExistEmail(Email);
            return isExist;
        }

        public int UpdateStudent(Student student)
        {
            return _studentRepository.UpdateStudent(student);
        }

        public int DeleteStudent(Student student)
        {
            return _studentRepository.DeleteStudent(student);
        }

        public DataTable SearchStudent(Student student)
        {
            return _studentRepository.SearchStudent(student);
        }


    }
}
