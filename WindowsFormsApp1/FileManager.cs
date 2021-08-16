using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// FileManager Class
    /// Provides app with two functions to read and write
    /// staff object from and to Info.txt file
    /// </summary>
    public static class FileManager
    {
        static string FILEPATH = Environment.CurrentDirectory+"/Info.txt";
        
        /// <summary>
        /// GetStaffs
        /// Read all staffs' object from Info.txt file
        /// </summary>
        /// <returns>List<Staff></returns>
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

        /// <summary>
        /// SaveStaffs
        /// Save staffs' object to Info.txt file
        /// </summary>
        /// <param name="staffs">A list of staffs' object</param>
        /// <param name="marker">1: delete record, overwrite all exist records by create a new file</param>
        /// <returns>true: sucessful, false: failed</returns>
        public static bool SaveStaffs(List<Staff> staffs, int marker)
        {
            try
            {
                // Marker is 1 means that this function called
                // after delete operation, so function will going to create
                // a new Info.txt file and save all staffs' object in list
                if (marker == 1)
                {
                    // Create new Info.txt file in overwrite mode
                    FileStream stream = new FileStream(FILEPATH, System.IO.FileMode.Create);
                    stream.Close();
                }

                // Strart Writing
                StreamWriter sw = new StreamWriter(FILEPATH, true); 
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
