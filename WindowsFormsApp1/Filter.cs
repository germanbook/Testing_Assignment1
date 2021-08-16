using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Filter Class
    /// Provides search, sort, delete and checkID functions
    /// </summary>
    public static class Filter
    {
        /// <summary>
        /// Check staffID is exist or not, true = exist, false = not
        /// </summary>
        /// <param name="id">staff ID</param>
        /// <returns>bool, true = exist, false = not</returns>
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

        /// <summary>
        /// Sort all the staffs'object data in ascending order
        /// </summary>
        /// <param name="staffs">a list of staffs' object</param>
        /// <returns>a list of staffs' object in ascending order</returns>
        public static List<Staff> SortAZ(List<Staff> staffs)
        {
            staffs = staffs.OrderBy(x => x.Name).ToList();

            return staffs;
        }

        /// <summary>
        /// Sort all the staffs'object data in descending order
        /// </summary>
        /// <param name="staffs">a list of staffs' object</param>
        /// <returns>a list of staffs' object in descending order</returns>
        public static List<Staff> SortZA(List<Staff> staffs)
        {
            staffs = (from x in staffs
                      orderby x.Name descending
                      select x).ToList();

            return staffs;
        }

        /// <summary>
        /// Delete staff object from a list by given ID
        /// </summary>
        /// <param name="staffs">a list of staffs' object</param>
        /// <param name="id">staff ID</param>
        /// <returns>bool, true: delete successful, false: faild</returns>
        public static bool DeleteStaff(List<Staff> staffs, int id)
        {

            if (staffs.RemoveAll(x => x.StaffId == id) > 0)
            {
                // Marker is 1, create a new file when save data after deleted some items.
                FileManager.SaveStaffs(staffs, 1);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// Search for staff object based key word
        /// </summary>
        /// <param name="staffs">a list of staffs' object</param>
        /// <param name="term">the key word</param>
        /// <returns>search results in a list</returns>
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
