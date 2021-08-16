using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Staff Class
    /// Store staff data about objects
    /// </summary>
    public class Staff
    {
        private int staffId;
        private string name;
        private int gender;                 // 1:m 0:f
        private DateTime dateOfBirth;
        private string email;
        private float annualSalary;

        public int StaffId { get => staffId; set => staffId = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Email { get => email; set => email = value; }
        public float AnnualSalary { get => annualSalary; set => annualSalary = value; }
        public int Gender { get => gender; set => gender = value; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Staff()
        {
            StaffId = 000000;
            Name = "unknow";
            Gender = 0;
            DateOfBirth = new DateTime(1990, 01, 01);
            Email = "unknow";
            AnnualSalary = 0.0f;

        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="staffId">id</param>
        /// <param name="name">name</param>
        /// <param name="gender">gender, 0 or 1</param>
        /// <param name="dateOfBirth">date of birth</param>
        /// <param name="email">email address</param>
        /// <param name="annualSalary">salary</param>
        public Staff(int staffId, string name, int gender, DateTime dateOfBirth, string email, float annualSalary)
        {
            StaffId = staffId;
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Email = email;
            AnnualSalary = annualSalary;
        }

        /// <summary>
        /// Override ToString
        /// </summary>
        /// <returns>string, staff's information</returns>
        public override string ToString()
        {
            return StaffId+"  "+Name+" "+Gender+" "+DateOfBirth+" "+Email+" "+ AnnualSalary;
        }

        /// <summary>
        /// Override Equals
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>bool</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Staff staff = obj as Staff;
            
            if (staff == null)
            {
                return false;
            }
            else
            {
                return Equals(staff);
            }
        }

        /// <summary>
        /// Recall Equals
        /// </summary>
        /// <param name="staff">Staff object</param>
        /// <returns>bool</returns>
        public bool Equals(Staff staff)
        {
            if (staff == null)
            {
                return false;
            }
            return ( this.StaffId == staff.StaffId );
        }

        /// <summary>
        /// Override GetHashCode
        /// </summary>
        /// <returns>int, staffId's hashcode</returns>
        public override int GetHashCode()
        {
            return staffId.GetHashCode();
        }
    }
}
