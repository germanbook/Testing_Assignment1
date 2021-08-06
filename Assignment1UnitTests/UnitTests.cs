using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;
using System.Collections.Generic;

namespace Assignment1UnitTests
{
    [TestClass]
    public class FilterUnitTest
    {
        [TestMethod]
        public void TestFilterCheckID()
        {
            List<Staff> staffRecords = FileManager.GetStaffs(); // Get staffs from text file records              

            int staffExistID = staffRecords[0].StaffId;         // Get first staff's ID from text file

            Assert.IsTrue(Filter.CheckID(staffExistID));        // Should return true if ID exists in records

            int staffNotExistID = 000001;                       // 000001 is not exist in records

            for (int i = 0; i < staffRecords.Count; i++)
            {
                Assert.AreNotEqual(staffNotExistID, staffRecords[i].StaffId);   // Make sure ID does not exist
            }

            Assert.IsFalse(Filter.CheckID(staffNotExistID));    // Should return false if ID does not exists in records 

        }

        [TestMethod]
        public void TestFilterSortAZ()
        {
            Staff s1 = new Staff();
            Staff s2 = new Staff();
            Staff s3 = new Staff();
            Staff s4 = new Staff();

            s1.Name = "a";
            s2.Name = "b";
            s3.Name = "c";
            s4.Name = "d";

            List<Staff> staffListExpected = new List<Staff>();

            staffListExpected.Add(s1);
            staffListExpected.Add(s2);
            staffListExpected.Add(s3);
            staffListExpected.Add(s4);

            List<Staff> staffList = new List<Staff>();

            staffList.Add(s3);
            staffList.Add(s2);
            staffList.Add(s4);
            staffList.Add(s1);

            CollectionAssert.AreEqual(staffListExpected,Filter.SortAZ(staffList));
        }

        [TestMethod]
        public void TestFilterSortZA()
        {
            Staff s1 = new Staff();
            Staff s2 = new Staff();
            Staff s3 = new Staff();
            Staff s4 = new Staff();

            s1.Name = "a";
            s2.Name = "b";
            s3.Name = "c";
            s4.Name = "d";

            List<Staff> staffListExpected = new List<Staff>();

            staffListExpected.Add(s4);
            staffListExpected.Add(s3);
            staffListExpected.Add(s2);
            staffListExpected.Add(s1);

            List<Staff> staffList = new List<Staff>();

            staffList.Add(s3);
            staffList.Add(s2);
            staffList.Add(s4);
            staffList.Add(s1);

            CollectionAssert.AreEqual(staffListExpected, Filter.SortZA(staffList));
        }

        [TestMethod]
        public void TestFilterDeleteStaff()
        {
            List<Staff> staffsBeforeDelete = new List<Staff>();

            Staff s1 = new Staff();
            Staff s2 = new Staff();
            Staff s3 = new Staff();
            Staff s4 = new Staff();

            s1.StaffId = 202101;
            s2.StaffId = 202102;
            s3.StaffId = 202103;
            s4.StaffId = 202104;

            staffsBeforeDelete.Add(s1);
            staffsBeforeDelete.Add(s2);
            staffsBeforeDelete.Add(s3);
            staffsBeforeDelete.Add(s4);

            Filter.DeleteStaff(staffsBeforeDelete, 202104);

            List<Staff> staffsAfterDelete = FileManager.GetStaffs();
            staffsBeforeDelete = FileManager.GetStaffs();

            CollectionAssert.Contains(staffsBeforeDelete, s1);
            CollectionAssert.Contains(staffsBeforeDelete, s2);
            CollectionAssert.Contains(staffsBeforeDelete, s3);
            CollectionAssert.DoesNotContain(staffsBeforeDelete, s4);

        }

        [TestMethod]
        public void TestFilterSearch()
        {
            List<Staff> staffs = new List<Staff>();

            Staff s1 = new Staff();
            Staff s2 = new Staff();
            Staff s3 = new Staff();
            Staff s4 = new Staff();

            s1.Name = "Fluffy";
            s1.StaffId = 888881;

            s2.Name = "Butch";
            s2.StaffId = 888882;

            s3.Name = "Buggs";
            s3.StaffId = 888883;

            s4.Name = "Frankie";
            s4.StaffId = 888884;

            staffs.Add(s1);
            staffs.Add(s2);
            staffs.Add(s3);
            staffs.Add(s4);

            List<Staff> searchResults = Filter.Search(staffs, "u");

            CollectionAssert.Contains(searchResults, s1);
            CollectionAssert.Contains(searchResults, s2);
            CollectionAssert.Contains(searchResults, s3);
            CollectionAssert.DoesNotContain(searchResults, s4);

        }
    }

    [TestClass]
    public class FileManagerTest
    {
        [TestMethod]
        public void TestFileManagerGetStaffs()
        {
            List<Staff> staffs = FileManager.GetStaffs();

            CollectionAssert.AllItemsAreNotNull(staffs);
        }

        [TestMethod]
        public void TestFileManagerSaveStaffs_AddNewStaff()
        {
            // marker = 0: add new record
            int marker = 0;

            // Create a new staff
            Staff staff = new Staff();
            staff.StaffId = 888879;

            // Put new staff in a List
            List<Staff> staffList = new List<Staff>();
            staffList.Add(staff);

            // Add new staff to exist records
            FileManager.SaveStaffs(staffList, marker); 
            
            // Load all staffs from text file, check if new staff exists in records 
            CollectionAssert.Contains(FileManager.GetStaffs(), staff);
        }

        [TestMethod]
        public void TestFileManagerSaveStaffs_DeleteStaff()
        {
            // marker = 1: delete record, overwrite all exist records
            int marker = 1;

            List<Staff> staffs = new List<Staff>();

            Staff s1 = new Staff();
            Staff s2 = new Staff();
            Staff s3 = new Staff();

            s1.StaffId = 202101;
            s2.StaffId = 202102;
            s3.StaffId = 202103;

            staffs.Add(s1);
            staffs.Add(s2);
            staffs.Add(s3);

            FileManager.SaveStaffs(staffs, marker);

            List<Staff> staffsFromFile = FileManager.GetStaffs();

            CollectionAssert.Contains(staffsFromFile, s1);
            CollectionAssert.Contains(staffsFromFile, s2);
            CollectionAssert.Contains(staffsFromFile, s3);

        }
    }

    [TestClass]
    public class StaffTest
    {
        [TestMethod]
        public void TestStaffStaffId()
        {
            Staff staff = new Staff();
            staff.StaffId = 202001;
            Assert.AreEqual(202001, staff.StaffId);
        }

        [TestMethod]
        public void TestStaffName()
        {
            Staff staff = new Staff();
            staff.Name = "Lady Gaga";
            Assert.AreEqual("Lady Gaga", staff.Name);
        }

        [TestMethod]
        public void TestStaffStaffDateOfBirth()
        {
            Staff staff = new Staff();
            staff.DateOfBirth = Convert.ToDateTime("09-09-2021");
            Assert.AreEqual(Convert.ToDateTime("09-09-2021"), staff.DateOfBirth);
        }

        [TestMethod]
        public void TestStaffEmail()
        {
            Staff staff = new Staff();
            staff.Email = "abc@abc.com";
            Assert.AreEqual("abc@abc.com", staff.Email);
        }

        [TestMethod]
        public void TestStaffAnnualSalary()
        {
            Staff staff = new Staff();
            staff.AnnualSalary = 58000;
            Assert.AreEqual(58000, staff.AnnualSalary);
        }

        [TestMethod]
        public void TestStaffGender()
        {
            Staff staff = new Staff();

            staff.Gender = 0;
            Assert.AreEqual(0, staff.Gender);

            staff.Gender = 1;
            Assert.AreEqual(1, staff.Gender);
        }

        [TestMethod]
        public void TestStaffDefaultConstructor()
        {
            Staff staff = new Staff();

            Assert.AreEqual(000000, staff.StaffId);
            Assert.AreEqual("unknow", staff.Name);
            Assert.AreEqual(0, staff.Gender);
            Assert.AreEqual(Convert.ToDateTime("01-01-1990"), staff.DateOfBirth);
            Assert.AreEqual("unknow", staff.Email);
            Assert.AreEqual(0.0f, staff.AnnualSalary);
        }

        [TestMethod]
        public void TestStaffParameterizedConstructor()
        {
            Staff staff = new Staff(
                                        000000,
                                        "Stephen",
                                        1,
                                        Convert.ToDateTime("08-01-1942"),
                                        "blackholes@universe.com",
                                        200000.00f
                                    );

            Assert.AreEqual(000000, staff.StaffId);
            Assert.AreEqual("Stephen", staff.Name);
            Assert.AreEqual(1, staff.Gender);
            Assert.AreEqual(Convert.ToDateTime("08-01-1942"), staff.DateOfBirth);
            Assert.AreEqual("blackholes@universe.com", staff.Email);
            Assert.AreEqual(200000.00f, staff.AnnualSalary);
        }
    }
}
