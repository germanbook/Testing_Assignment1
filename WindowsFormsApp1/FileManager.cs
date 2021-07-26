using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    public static class FileManager
    {
        public static List<Staff> GetStaffs()
        {
            List<Staff> staffs = new List<Staff>();
            StreamReader sr = new StreamReader("Info.txt");

            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Replace(", ", ",").Split(',');
                Staff staff = new Staff(Convert.ToInt32(s[0]), s[1], Convert.ToDateTime(s[2]), s[3], Convert.ToSingle(s[4]));
                staffs.Add(staff);
            }

            sr.Close();
            return staffs;
        }
    }
}
