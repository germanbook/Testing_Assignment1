using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Staff
    {
        private int staffId;
        private string name;
        private int gender; // 1:m 0:f
        private DateTime dateOfBirth;
        private string email;
        private float annualSalary;

        public int StaffId { get => staffId; set => staffId = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Email { get => email; set => email = value; }
        public float AnnualSalary { get => annualSalary; set => annualSalary = value; }
        public int Gender { get => gender; set => gender = value; }

        public Staff()
        {
            StaffId = 000;
            Name = "unknow";
            Gender = 0;
            DateOfBirth = new DateTime(1990, 01, 01);
            Email = "unknow";
            AnnualSalary = 0.0f;

        }

        public Staff(int staffId, string name, int gender, DateTime dateOfBirth, string email, float annualSalary)
        {
            StaffId = staffId;
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Email = email;
            AnnualSalary = annualSalary;
        }

        public override string ToString()
        {
            return StaffId+"  "+Name+" "+Gender+" "+DateOfBirth+" "+Email+" "+ AnnualSalary;
        }
    }
}
