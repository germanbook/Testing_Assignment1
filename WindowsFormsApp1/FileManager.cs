using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class FileManager
    {
        public static List<Staff> GetStaffs()
        {

            try
            {
                List<Staff> staffs = new List<Staff>();
                StreamReader sr = new StreamReader("../../Info.txt");
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Replace(", ", ",").Split(',');
                    Staff staff = new Staff(Convert.ToInt32(s[0]), s[1],Convert.ToInt32(s[2]),Convert.ToDateTime(s[3]), s[4], Convert.ToSingle(s[5]));
                    staffs.Add(staff);
                }

                sr.Close();
                return staffs;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool SaveStaffs(Staff staff)
        {
            Console.WriteLine(staff.ToString());
            try
            {
                StreamWriter sw = new StreamWriter("../../Info.txt",true);
                sw.WriteLine(staff.StaffId + ","
                           + staff.Name + ","
                           + staff.Gender+ ","
                           + staff.DateOfBirth + "," 
                           + staff.Email + ","
                           + staff.AnnualSalary);

                sw.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
