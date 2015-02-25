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
    public class OpeningTest


        //As a user
        //In order to get started
        //I want to open an existing file

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
        public void TestShowSavedFiles()
        {

        }
    }
}
