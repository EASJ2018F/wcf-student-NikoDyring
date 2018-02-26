using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentWebservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Student AddStudent(string name, string classRoom, string className, string ssn);
        [OperationContract]
        Student FindStudent(string ssn);
        [OperationContract]
        List<Student> GetAllStudents();
        [OperationContract]
        void RemoveStudent(string ssn);
        [OperationContract]
        Student EditStudent(string ssn, string name, string className, string classRoom);

    }
}
