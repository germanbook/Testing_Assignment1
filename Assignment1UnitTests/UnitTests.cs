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
            // Get staffs from text file records
            List<Staff> staffRecords = FileManager.GetStaffs();

            // Get first staff's ID from text file
            int staffExistID = staffRecords[0].StaffId;

            // Should return true if ID exists in records
            Assert.IsTrue(Filter.CheckID(staffExistID));

            // 000001 is not exist in records
            int staffNotExistID = 000001;

            // Make sure ID does not exist
            for (int i = 0; i < staffRecords.Count; i++)
            {
                Assert.AreNotEqual(staffNotExistID, staffRecords[i].StaffId);   
            }

            // Should return false if ID does not exists in records 
            Assert.IsFalse(Filter.CheckID(staffNotExistID));    

        }

        [TestMethod]
        public void TestFilterSortAZ()
        {
            // Create 4 Staff objects
            Staff s1 = new Staff();
            Staff s2 = new Staff();
            Staff s3 = new Staff();
            Staff s4 = new Staff();

            // Set objects name to a, b, d, d
            s1.Name = "a";
            s2.Name = "b";
            s3.Name = "c";
            s4.Name = "d";

            List<Staff> staffListExpected = new List<Staff>();
            // Add objects to list in ascending order
            staffListExpected.Add(s1);
            staffListExpected.Add(s2);
            staffListExpected.Add(s3);
            staffListExpected.Add(s4);

            List<Staff> staffList = new List<Staff>();
            // Add objects to list out of order 
            staffList.Add(s3);
            staffList.Add(s2);
            staffList.Add(s4);
            staffList.Add(s1);

            // Check whether the objects sorted in ascending order as expected
            CollectionAssert.AreEqual(staffListExpected,Filter.SortAZ(staffList));
        }

        [TestMethod]
        public void TestFilterSortZA()
        {
            // Create 4 Staff objects
            Staff s1 = new Staff();
            Staff s2 = new Staff();
            Staff s3 = new Staff();
            Staff s4 = new Staff();

            // Set objects name to a, b, d, d
            s1.Name = "a";
            s2.Name = "b";
            s3.Name = "c";
            s4.Name = "d";

            List<Staff> staffListExpected = new List<Staff>();

            // Add objects to list in descending order
            staffListExpected.Add(s4);
            staffListExpected.Add(s3);
            staffListExpected.Add(s2);
            staffListExpected.Add(s1);

            List<Staff> staffList = new List<Staff>();
            
            // Add objects to list out of order
            staffList.Add(s3);
            staffList.Add(s2);
            staffList.Add(s4);
            staffList.Add(s1);

            // Check whether the objects sorted in descending order as expected
            CollectionAssert.AreEqual(staffListExpected, Filter.SortZA(staffList));
        }

        [TestMethod]
        public void TestFilterDeleteStaff()
        {
            List<Staff> staffsBeforeDelete = new List<Staff>();

            // Create 4 Staff objects
            Staff s1 = new Staff();
            Staff s2 = new Staff();
            Staff s3 = new Staff();
            Staff s4 = new Staff();

            // Set staffID 
            s1.StaffId = 202101;
            s2.StaffId = 202102;
            s3.StaffId = 202103;
            s4.StaffId = 202104;

            // Add objects to list
            staffsBeforeDelete.Add(s1);
            staffsBeforeDelete.Add(s2);
            staffsBeforeDelete.Add(s3);
            staffsBeforeDelete.Add(s4);

            // Delete a object of staff from list by staffID '202104'
            Filter.DeleteStaff(staffsBeforeDelete, 202104);

            // Get staffs from text file after delete operation
            List<Staff> staffsAfterDelete = FileManager.GetStaffs();
            staffsBeforeDelete = FileManager.GetStaffs();

            // Check that object of staff has been deleted 
            CollectionAssert.Contains(staffsBeforeDelete, s1);
            CollectionAssert.Contains(staffsBeforeDelete, s2);
            CollectionAssert.Contains(staffsBeforeDelete, s3);
            CollectionAssert.DoesNotContain(staffsBeforeDelete, s4);

        }

        [TestMethod]
        public void TestFilterSearch()
        {
            List<Staff> staffs = new List<Staff>();

            // Create 4 Staff objects
            Staff s1 = new Staff();
            Staff s2 = new Staff();
            Staff s3 = new Staff();
            Staff s4 = new Staff();

            // Set name and ID
            s1.Name = "Fluffy";
            s1.StaffId = 888881;

            s2.Name = "Butch";
            s2.StaffId = 888882;

            s3.Name = "Buggs";
            s3.StaffId = 888883;

            s4.Name = "Frankie";
            s4.StaffId = 888884;

            // Add objects to list
            staffs.Add(s1);
            staffs.Add(s2);
            staffs.Add(s3);
            staffs.Add(s4);

            List<Staff> searchResults = Filter.Search(staffs, "u");

            // Check that we got correct search results
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
            // Get all records of staffs from text file
            List<Staff> staffs = FileManager.GetStaffs();

            // Check whether got objects of staffs or not
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

            // Create 3 staffs
            Staff s1 = new Staff();
            Staff s2 = new Staff();
            Staff s3 = new Staff();

            // Set staffs' ID
            s1.StaffId = 202101;
            s2.StaffId = 202102;
            s3.StaffId = 202103;

            // Add them to a list
            staffs.Add(s1);
            staffs.Add(s2);
            staffs.Add(s3);

            // In the App, after delete operation we call SaveStaffs()
            // by Set the marker to 1, the SaveStaffs() will save all
            // staffs in the list to a text file overwrite the exist file.
            FileManager.SaveStaffs(staffs, marker);

            // Get staffs from text file
            List<Staff> staffsFromFile = FileManager.GetStaffs();

            // Check the 3 staffs' objcet saved and exists in file.
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
            // Create a object of staff
            Staff staff = new Staff();

            // Set staff's ID
            staff.StaffId = 202001;

            // Check whether the return ID equal to the previously set
            Assert.AreEqual(202001, staff.StaffId);
        }

        [TestMethod]
        public void TestStaffName()
        {
            // Create a object of staff
            Staff staff = new Staff();

            // Set staff's name
            staff.Name = "Lady Gaga";

            // Check whether the return name equal to the previously set
            Assert.AreEqual("Lady Gaga", staff.Name);
        }

        [TestMethod]
        public void TestStaffStaffDateOfBirth()
        {
            // Create a object of staff
            Staff staff = new Staff();

            // Set staff's birth day
            staff.DateOfBirth = Convert.ToDateTime("09-09-2021");

            // Check whether the return birth day equal to the previously set
            Assert.AreEqual(Convert.ToDateTime("09-09-2021"), staff.DateOfBirth);
        }

        [TestMethod]
        public void TestStaffEmail()
        {
            // Create a object of staff
            Staff staff = new Staff();

            // Set staff's email
            staff.Email = "abc@abc.com";

            // Check whether the return email equal to the previously set
            Assert.AreEqual("abc@abc.com", staff.Email);
        }

        [TestMethod]
        public void TestStaffAnnualSalary()
        {
            // Create a object of staff
            Staff staff = new Staff();

            // Set staff's salary
            staff.AnnualSalary = 58000;

            // Check whether the return salary equal to the previously set
            Assert.AreEqual(58000, staff.AnnualSalary);
        }

        [TestMethod]
        public void TestStaffGender()
        {
            // Create a object of staff
            Staff staff = new Staff();

            // Set staff's gender to "0"
            staff.Gender = 0;
            // Check whether the return gender equal to the previously set
            Assert.AreEqual(0, staff.Gender);

            // Set staff's gender to "1"
            staff.Gender = 1;
            // Check whether the return gender equal to the previously set
            Assert.AreEqual(1, staff.Gender);
        }

        [TestMethod]
        public void TestStaffDefaultConstructor()
        {
            // Create a object of staff
            Staff staff = new Staff();

            // Check whether the return ID equal to the value set in default constructor 
            Assert.AreEqual(000000, staff.StaffId);
            // Check whether the return name equal to the value set in default constructor 
            Assert.AreEqual("unknow", staff.Name);
            // Check whether the return gender equal to the value set in default constructor 
            Assert.AreEqual(0, staff.Gender);
            // Check whether the return birth day equal to the value set in default constructor 
            Assert.AreEqual(Convert.ToDateTime("01-01-1990"), staff.DateOfBirth);
            // Check whether the return email equal to the value set in default constructor 
            Assert.AreEqual("unknow", staff.Email);
            // Check whether the return salary equal to the value set in default constructor 
            Assert.AreEqual(0.0f, staff.AnnualSalary);
        }

        [TestMethod]
        public void TestStaffParameterizedConstructor()
        {
            // Create a object of staff using parameterized constructor with values below
            Staff staff = new Staff(
                                        000000,
                                        "Stephen",
                                        1,
                                        Convert.ToDateTime("08-01-1942"),
                                        "blackholes@universe.com",
                                        200000.00f
                                    );


            // Check whether the return ID equal to the previously set in parameterized constructor
            Assert.AreEqual(000000, staff.StaffId);
            // Check whether the return name equal to the previously set in parameterized constructor
            Assert.AreEqual("Stephen", staff.Name);
            // Check whether the return gender equal to the previously set in parameterized constructor
            Assert.AreEqual(1, staff.Gender);
            // Check whether the return birth day equal to the previously set in parameterized constructor
            Assert.AreEqual(Convert.ToDateTime("08-01-1942"), staff.DateOfBirth);
            // Check whether the return email equal to the previously set in parameterized constructor
            Assert.AreEqual("blackholes@universe.com", staff.Email);
            // Check whether the return salary equal to the previously set in parameterized constructor
            Assert.AreEqual(200000.00f, staff.AnnualSalary);
        }
    }
}
