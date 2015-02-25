﻿using System;
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
    public class TestZeroStateFileOpening
    {
        private static TestContext test_context;
        private static Window window;
        private static Application application;

        [ClassInitialize]
        public static void Setup(TestContext _context)
        {
            test_context = _context;
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\knit_designer\\bin\\Debug\\FilesWindow");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
        }

        [TestMethod]
        public void TestZeroState()
        {
            Button start = window.Get < Button >("Start");
            ListBox files = window.Get<ListBox>("Exist");
            Button open = window.Get<Button>("Open");

            Assert.IsTrue(start.Enabled);
            Assert.IsTrue(files.Enabled);
            Assert.IsTrue(open.Enabled);
        }

        [ClassCleanup]
        public static void TearDown()
        {
            window.Close();
            application.Close();
        }
    }
}
