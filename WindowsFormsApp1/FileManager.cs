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
        const string FILEPATH = "Info.txt";
        public static List<Staff> GetStaffs()
        {

            try
            {
                List<Staff> staffs = new List<Staff>();
                StreamReader sr = new StreamReader(FILEPATH);
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Replace(", ", ",").Split(',');
                    Staff staff = new Staff(Convert.ToInt32(s[0]), s[1],Convert.ToInt32(s[2]), Convert.ToDateTime(s[3]), s[4], Convert.ToSingle(s[5]));
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

        // 0: add
        // 1: overwrite all records
        public static bool SaveStaffs(List<Staff> staffs, int marker)
        {
            try
            {
                if (marker == 1)
                {
                    FileStream stream = new FileStream(FILEPATH, System.IO.FileMode.Create);
                    stream.Close();
                }
                StreamWriter sw = new StreamWriter(FILEPATH, true); // filepath
                for (int i = 0; i < staffs.Count; i++)
                {
                    sw.WriteLine(staffs[i].StaffId + ","
                           + staffs[i].Name + ","
                           + staffs[i].Gender + ","
                           + staffs[i].DateOfBirth + ","
                           + staffs[i].Email + ","
                           + staffs[i].AnnualSalary);
                }
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
