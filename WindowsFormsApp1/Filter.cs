using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    public static class Filter
    {
        // Check staffID is exist or not, true = exist, false = not
        public static bool CheckID(int id)
        {
            int counter = 0;
            List<Staff> staffs = FileManager.GetStaffs();
            foreach (Staff s in staffs)
            {
                if (s.StaffId == id)
                {
                    counter ++;
                }
            }

            if (counter == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static List<Staff> SortAZ(List<Staff> staffs)
        {
            staffs = staffs.OrderBy(x => x.Name).ToList();

            return staffs;
        }

        public static List<Staff> SortZA(List<Staff> staffs)
        {
            staffs = (from x in staffs
                      orderby x.Name descending
                      select x).ToList();

            return staffs;
        }

        public static bool DeleteStaff(List<Staff> staffs, int id)
        {
            // Create a new file when save data after deleted some items.
            if (staffs.RemoveAll(x => x.StaffId == id) > 0)
            {
                FileManager.SaveStaffs(staffs, 1);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static List<Staff> Search(List<Staff> staffs, string term)
        {
            List<Staff> results = new List<Staff>();

            results = (from staff in staffs
                       where staff.Name.ToLower().Contains(term.ToLower())
                       select staff).ToList();

            return results;
        }

    }
}
