using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace lab_7_tests;

[TestClass]
public class UnitTest1_Student
{
    private readonly StudentClass _studentClass;
    private readonly Student _student;
    public UnitTest1_Student()
    {
        _student = new Student("1234", "John", Gender.Male);
        _studentClass = new StudentClass("tud123", "Jackie");
    }

    [TestMethod]
    public void TestMethod1_StudentName()
    {
        Assert.AreEqual("John", _student.Name);
    }

    [TestMethod]
    public void TestMethod2_StudentID()
    {
        Assert.AreEqual("1234", _student.ID);
    }

    [TestMethod]
    public void TestMethod3_StudentClass()
    {
        Assert.AreEqual("tud123", _studentClass.CRN);
    }

    [TestMethod]
    public void TestMethod4_StudentClass_AddStudent_IndexerInt()
    {
        _studentClass.AddStudent(_student);
        Assert.AreEqual("John", _studentClass[0].Name);
    }

    [TestMethod]
    public void TestMethod5_StudentClass_AddStudent_IndexerString()
    {
        _studentClass.AddStudent(_student);
        Assert.AreEqual("John", _studentClass["1234"].Name);
    }
}