using System;
using System.ComponentModel;

namespace EnumDesc
{
    static class Program
    {
        static void Main(string[] args)
        {
            var item = UserType.Staff.GetDescription();
            Console.WriteLine(item);
        }
    }

    public enum UserType
    {
        [Description("Student info")]
        Student,
        [Description("Staff info")]
        Staff
    }
}
