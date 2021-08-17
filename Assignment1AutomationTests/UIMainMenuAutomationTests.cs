using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Diagnostics;

namespace Assignment1AutomationTests
{
    [TestClass]
    public class UIMainMenuAutomationTests
    {

        static WindowsDriver<WindowsElement> sessions;

        [ClassInitialize]
        public static void PrepareForTestingMainMenu(TestContext testContext)
        {
            // Path( Automation testing project's Debug folder)
            string path = Environment.CurrentDirectory;

            AppiumOptions option = new AppiumOptions();

            // This App is running in WinAppDriver's folder!
            // 'Info.txt' file needs copy to WinAppDriver's folder manually
            option.AddAdditionalCapability("app", path + "/WindowsFormsApp1.exe");

            Uri uri = new Uri("http://127.0.0.1:4723/");

            sessions = new WindowsDriver<WindowsElement>(uri, option);

            if (sessions == null)
            {
                Console.WriteLine("Please check App file path!");
            }

        }
        
        [TestMethod]
        public void TestUICheckLoadButton()
        {

            // Find the load button and check it exists or not
            Assert.IsTrue(sessions.FindElementByName("Load").Displayed);
        }

        [TestMethod]
        public void TestUICheckSortAZButton()
        {
            // Find the SortAZ button and check it exists or not
            Assert.IsTrue(sessions.FindElementByName("AZ").Displayed);
        }

        [TestMethod]
        public void TestUICheckSortZAButton()
        {
            // Find the SortZA button and check it exists or not
            Assert.IsTrue(sessions.FindElementByName("ZA").Displayed);
        }

        [TestMethod]
        public void TestUICheckSearchLabelAndTextBox()
        {
            // Find the Search label and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("lblSearch").Displayed);

            // Find the Search textbox and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("tbxSearch").Displayed);
        }

        [TestMethod]
        public void TestUICheckListView()
        {
            // Find the ListView and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("listView1").Displayed);

        }

        [TestMethod]
        public void TestUICheckDeleteButton()
        {
            // Find the Delete button and check it exists or not
            Assert.IsTrue(sessions.FindElementByName("Delete").Displayed);

        }

        [TestMethod]
        public void TestUICheckAddStaffButon()
        {
            // Find the Add Staff button and check it exists or not
            Assert.IsTrue(sessions.FindElementByName("Add Staff").Displayed);

        }
    }

    [TestClass]
    public class UIAddingFormAutomationTests
    {
        static WindowsDriver<WindowsElement> sessions;

        [ClassInitialize]
        public static void PrepareForTestingAddingForm(TestContext testContext)
        {

            // Current path(Debug folder)
            string path = Environment.CurrentDirectory;

            AppiumOptions option = new AppiumOptions();

            // This App is running in WinAppDriver's folder!
            option.AddAdditionalCapability("app", path + "/WindowsFormsApp1.exe");

            Uri uri = new Uri("http://127.0.0.1:4723/");

            sessions = new WindowsDriver<WindowsElement>(uri, option);

            if (sessions == null)
            {
                Console.WriteLine("Please check App file path!");
            }
            sessions.FindElementByAccessibilityId("btnAdd").Click();

            // Switch sessions from Main Menu to Adding Form
            sessions.SwitchTo().Window(sessions.WindowHandles[0]);

            Console.WriteLine(sessions.Title);

            

        }

        [TestMethod]
        public void TestUICheckStaffIDLabelAndTextBoxAndFieldHints()
        {

            // Find the Staff ID label and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("lbl_ID").Displayed);

            // Find the Staff ID textbox and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("tbxID").Displayed);

            // Find the ID format hint and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("lblIDHint").Displayed);

        }

        [TestMethod]
        public void TestUICheckNameLabelAndTextBoxAndFieldHints()
        {

            // Find the Name label and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("lblName").Displayed);

            // Find the Name textbox and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("tbxName").Displayed);

            // Find the Name format hint and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("lblNameHint").Displayed);
        }

        [TestMethod]
        public void TestUICheckGenderLabelAndRadioButtonsAndFieldHints()
        {

            // Find the Gender label and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("lblGender").Displayed);

            // Find the Gender Male radio button and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("rbtnMale").Displayed);

            // Find the Gender Female radio button and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("rbtnFemale").Displayed);

            // Find the radio button hint and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("lblGenderHint").Displayed);
        }

        [TestMethod]
        public void TestUICheckDateOfBirthLabelAndDateTimePicker()
        {

            // Find the Date of Birth label and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("lblDateBirth").Displayed);

            // Find the Date of Birth datetimepicker and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("dtpDateOfBirth").Displayed);

        }

        [TestMethod]
        public void TestUICheckEmailLabelAndTextBoxAndFieldHints()
        {

            // Find the E-mail label and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("lblEmail").Displayed);

            // Find the E-mail textbox and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("tbxEmail").Displayed);

            // Find the E-mail hint and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("lblEmailHint").Displayed);

        }

        [TestMethod]
        public void TestUICheckAnnualSalaryLabelAndTextBoxAndFieldHints()
        {

            // Find the Annual Salary label and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("lblAnnualSalary").Displayed);

            // Find the Annual Salary textbox and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("tbxSalary").Displayed);

            // Find the Annual Salary hint and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("lblSalaryHint").Displayed);

        }

        [TestMethod]
        public void TestUICheckAllFieldsRequiredHint()
        {
            // Find the All Fields Required label and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("lblRequiredFields").Displayed);
        }
        
        [TestMethod]
        public void TestUICheckOKButton()
        {

            // Find the OK button and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("btnOk").Displayed);

        }

        [TestMethod]
        public void TestUICheckBackButton()
        {

            // Find the Back button and check it exists or not
            Assert.IsTrue(sessions.FindElementByAccessibilityId("btnBack").Displayed);

        }
    }
}
