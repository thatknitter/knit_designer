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

        [ClassCleanup]
        public static void TearDown()
        {
            window.Close();
            application.Close();
        }
    }
}
