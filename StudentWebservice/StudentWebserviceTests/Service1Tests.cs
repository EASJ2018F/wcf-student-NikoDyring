using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentWebservice;

namespace StudentWebserviceTests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void AddStudentTest()
        {
            // Arrange
            Service1 sClient = new Service1();
            // Act
            var s1 = sClient.AddStudent("Lasse", "J105", "3F", "240994-XXXX");
            // Assert
            Assert.AreEqual("Lasse", s1.StudentName);
        }

        [TestMethod()]
        public void FindStudentTest()
        {
            // Arrange
            Service1 sClient = new Service1();
            // Act
            var s1 = sClient.AddStudent("Lasse", "J105", "3F", "240995-XXXX");
            var foundStudent = sClient.FindStudent("240995-XXXX");
            // Assert
            Assert.AreEqual("Lasse", foundStudent.StudentName);
        }

        [TestMethod()]
        public void GetAllStudentsTest()
        {
            // Arrange
            Service1 sClient = new Service1();
            // Act
            sClient.GetAllStudents();

            // Assert
            Assert.AreEqual(2, sClient.GetAllStudents().Count);
        }

        [TestMethod()]
        public void RemoveStudentTest()
        {
            // Arrange
            Service1 sClient = new Service1();
            // Act
            sClient.RemoveStudent("240995-XXXX");
            // Assert
            Assert.AreEqual(1, sClient.GetAllStudents().Count);
        }

        [TestMethod()]
        public void EditStudentTest()
        {
            // Arrange
            Service1 sClient = new Service1();
            // Act
            sClient.EditStudent("240994-XXXX", "Peter", "3A", "J105");
            // Assert
            Assert.AreEqual("Peter", sClient.FindStudent("240994-XXXX").StudentName);
        }
    }
}