using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentWebservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static List<Student> _list = new List<Student>();

        public Student AddStudent(string name, string classRoom, string className, string ssn)
        {
            Student s1 = new Student(name, classRoom, className, ssn);
            _list.Add(s1);
            return s1;
        }

        public Student FindStudent(string ssn)
        {
            return _list.Single(s => s.SSN == ssn);
        }

        public List<Student> GetAllStudents()
        {
            return _list;
        }

        public void RemoveStudent(string ssn)
        {
            _list.Remove(this.FindStudent(ssn));
        }

        public Student EditStudent(string ssn, string name, string className, string classRoom)
        {
            Student student = FindStudent(ssn);
            student.StudentName = name;
            student.ClassName = className;
            student.ClassRoom = classRoom;

            return student;
        }
    }
}
