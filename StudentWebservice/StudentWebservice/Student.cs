using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StudentWebservice
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public string ClassRoom { get; set; }
        [DataMember]
        public string ClassName { get; set; }
        [DataMember]
        public string SSN { get; set; }

        public Student(string name, string classRoom, string className, string ssn)
        {
            StudentName = name;
            ClassRoom = classRoom;
            ClassName = className;
            SSN = ssn;
        }
    }
}