using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.ListBoxItems;
using KnitDesigner;

namespace TestKnitDesigner
{
    [TestClass]
    public class UITest
    {
        private static TestContext test_context;
        private static Window window;
        private static Application application;

        [ClassInitialize]
        public static void Setup(TestContext _context)
        {
            test_context = _context;
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\knit_designer\\bin\\Debug\\MainWindow");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
        }

        [TestMethod]
        public void TestZeroState()
        {
            TextBox gauge = window.Get<TextBox>("Gauge");
            ComboBox pattern_type = window.Get<ComboBox>("Pattern_Type");
            ComboBox age = window.Get<ComboBox>("Age");
            TextBox yarn_amount = window.Get<TextBox>("Yarn_Amount");
            CheckBox yards = window.Get<CheckBox>("Yards");
            CheckBox meters = window.Get<CheckBox>("Meters");
            TextBox balls = window.Get<TextBox>("Balls");
            TextBox ease = window.Get<TextBox>("Ease");
            ComboBox publisher = window.Get<ComboBox>("Publisher");
            Button start = window.Get<Button>("Start");

            Assert.AreEqual(gauge.Text, "0");
            Assert.IsTrue(pattern_type.Enabled);
            Assert.IsTrue(age.Enabled);
            Assert.AreEqual(yarn_amount.Text, "Amount of yarn per ball");
            Assert.IsTrue(yards.Enabled);
            Assert.IsTrue(meters.Enabled);
            Assert.AreEqual(balls.Text, "0");
            Assert.AreEqual(ease.Text, "0");
            Assert.IsTrue(publisher.Enabled);
            Assert.IsTrue(start.Enabled);
        }

        [TestMethod]
        public void TestOpenFileWindow()
        {
            //as a user, when I start the program the files window should open
        }

        [TestMethod]
        public void TestCreateNewFile()
        {
            //as a user, when I press the "create new pattern" button on the files window, the main window should open and a new file should start

        }

        [TestMethod]
        public void TestOpenPreviousFile()
        {
            //as a user, when I start the program a list of existing files should be visible and I should be able to click on one and open it

        }

        [TestMethod]
        public void TestRequireGauge()
        {
            //as a user, I should not be able to click the start button until I have specified a gauge
        }

        [TestMethod]
        public void TestRequireType()
        {
            //as a user, I should not be able to click the start button until I have specified a type of pattern
        }

        [TestMethod]
        public void TestDetectAge()
        {
            //as a user, I should be able to detect an age range and have it input to the db
        }

        [TestMethod]
        public void TestDetectYardage()
        {
            //as a user, I should be able to detect the value input in the yarn yardage box and submit it to the db

        }

        [TestMethod]
        public void TestDetectUnits()
        {
            //as a user, I should be able to detect which checkbox was chosen and input it to the db
        }

        [TestMethod]
        public void TestDetectBalls()
        {
            //as a user, I should be able to input the number of yarn balls I used and the program will submit it to the db

        }

        [TestMethod]
        public void TestDetectEase()
        {
            //as a user, I should be able to input the ease and have the system submit it to the db
        }

        [TestMethod]
        public void TestDetectPublisher()
        {
            //as a user, I should be able to select a publisher and have the system submit that to the db
        }

        [TestMethod]
        public void TestOpenSweaterWindow()
        {
            //as a user, if "sweater" is selected and the requisite information is detected and the start button is pressed, then the sweater information window is opened

        }

        [ClassCleanup]
        public static void TearDown()
        {
            window.Close();
            application.Close();
        }
    }
}
