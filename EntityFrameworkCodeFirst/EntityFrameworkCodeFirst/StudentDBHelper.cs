using System;

namespace EntityFrameworkCodeFirst
{
    public static class StudentDBHelper
    {
        public static void AddStudent(Student stu)
        {
            StudentDB db = new StudentDB();
            db.Students.Add(stu); //I want to add this student
            db.SaveChanges(); // execute Above statement
        }
    }
}