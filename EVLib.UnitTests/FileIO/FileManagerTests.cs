﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EVLlib.FileIO.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        private string buildFolder = Directory.GetCurrentDirectory();
        private const string folderName = "PleaseDelete";
        private const string fileName = "PleaseDelete.txt";
        private const string sampleString = "Hello, I have nothing important inside (:";
        private byte[] sampleBytes = { 72, 101, 108, 108, 111, 44, 32, 73, 32, 104, 97, 118, 101,
            32, 110, 111, 116, 104, 105, 110, 103, 32, 105, 109, 112, 111, 114, 116, 97, 110,
            116, 32, 105, 110, 115, 105, 100, 101, 32, 40, 58 };

        static string[] fullDirectoryPath = new string[] { Directory.GetCurrentDirectory(), folderName };
        static string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), folderName, fileName };
        string testDirectory = Path.Combine(fullDirectoryPath);
        string testFile = Path.Combine(fullFilePath);

        public void CleanupDirectories()
        {
            File.Delete(testFile);
            Directory.Delete(testDirectory);
        }

        [TestMethod]
        public void FolderCreatedTests()
        {
            FileManager fileManager = new FileManager();

            bool expected = Directory.Exists(testDirectory);
            bool actual = fileManager.IsFolderCreated(testDirectory);

            Assert.AreEqual(expected, actual);

            if (!expected)
            {
                Directory.CreateDirectory(testDirectory);

                bool expected2 = Directory.Exists(testDirectory);
                bool actual2 = fileManager.IsFolderCreated(testDirectory);

                Assert.AreEqual(expected2, actual2);
            }

            CleanupDirectories();
        }

        [TestMethod]
        public void FilecreatedTest()
        {
            FileManager fileManager = new FileManager();

            bool expected = File.Exists(testFile);
            bool actual = fileManager.IsFileCreated(testFile);

            Assert.AreEqual(expected, actual);

            if (!expected)
            {
                Directory.CreateDirectory(testDirectory);
                File.Create(testFile).Close();

                bool expected2 = File.Exists(testFile);
                bool actual2 = fileManager.IsFileCreated(testFile);

                Assert.AreEqual(expected2, actual2);
            }

            CleanupDirectories();
        }

        [TestMethod]
        public void CreateFolderTest()
        {
            FileManager fileManager = new FileManager();
            fileManager.CreateFolder(testDirectory);

            string expected = testDirectory;

            Assert.IsTrue(Directory.Exists(expected));

            CleanupDirectories();
        }

        [TestMethod]
        public void CreateFileTest()
        {
            Directory.CreateDirectory(testDirectory);

            FileManager fileManager = new FileManager();
            fileManager.CreateFile(testFile);

            string expected = testFile;

            Assert.IsTrue(File.Exists(expected));

            CleanupDirectories();
        }

        [TestMethod]
        public void ClearFileTest()
        {
            Directory.CreateDirectory(testDirectory);
            File.WriteAllText(testFile, sampleString);

            Assert.AreEqual(File.ReadAllText(testFile), sampleString);

            FileManager fileManager = new FileManager();
            fileManager.ClearFile(testFile);

            string actual = File.ReadAllText(testFile);
            string expected = string.Empty;

            Assert.AreEqual(actual, expected);

            CleanupDirectories();
        }

        [TestMethod]
        public void DeleteFolderTest()
        {
            FileManager fileManager = new FileManager();

            bool isDirectoryCreated = Directory.Exists(testDirectory);

            if (!isDirectoryCreated)
            {
                Directory.CreateDirectory(testDirectory);
            }

            fileManager.DeleteFolder(testDirectory);

            isDirectoryCreated = Directory.Exists(testDirectory);

            Assert.IsFalse(isDirectoryCreated);

            if (isDirectoryCreated)
            {
                CleanupDirectories();
            }
        }

        [TestMethod]
        public void DeleteFileTest()
        {
            Directory.CreateDirectory(testDirectory);

            using (var stream = File.Create(testFile))
            {
                stream.Close();
            }

            FileManager fileManager = new FileManager();
            fileManager.DeleteFile(testFile);

            string expected = testFile;

            Assert.IsFalse(File.Exists(expected));

            CleanupDirectories();
        }

        [TestMethod]
        public void SaveStringToFileTest()
        {
            Directory.CreateDirectory(testDirectory);

            FileManager fileManager = new FileManager();
            fileManager.SaveToFile(testFile, sampleString);

            string expected = sampleString;
            string actual = File.ReadAllText(testFile);

            Assert.AreEqual(expected, actual);

            CleanupDirectories();
        }

        [TestMethod]
        public void SaveBytesToFileTest()
        {
            Directory.CreateDirectory(testDirectory);

            FileManager fileManager = new FileManager();
            fileManager.SaveToFile(testFile, sampleBytes);

            byte[] actual = File.ReadAllBytes(testFile);
            byte[] expected = sampleBytes;

            CollectionAssert.AreEqual(expected, actual);

            CleanupDirectories();
        }

        [TestMethod]
        public void ReadStringFromFileTest()
        {
            Directory.CreateDirectory(testDirectory);
            File.WriteAllText(testFile, sampleString);

            FileManager fileManager = new FileManager();

            string actual = fileManager.ReadStringFromFile(testFile);
            string expected = sampleString;

            Assert.AreEqual(expected, actual);

            CleanupDirectories();
        }

        [TestMethod]
        public void ReadBytesFromFileTest()
        {
            Directory.CreateDirectory(testDirectory);
            File.WriteAllBytes(testFile, sampleBytes);

            FileManager fileManager = new FileManager();

            byte[] byteArray = fileManager.ReadBytesFromFile(testFile);

            string actual = Encoding.UTF8.GetString(byteArray);
            string expected = sampleString;

            Assert.AreEqual(expected, actual);

            CleanupDirectories();
        }

        [TestMethod]
        public void ReadLineFromFileTest()
        {
            StringBuilder multilineString = new StringBuilder();
            Random random = new Random();

            int linesToWrite = random.Next(1, 100);

            for (int i = 1; i <= linesToWrite; i++)
            {
                multilineString.AppendLine(i.ToString());
            }

            Directory.CreateDirectory(testDirectory);
            File.WriteAllText(testFile, multilineString.ToString());

            int lineToRead = random.Next(1, linesToWrite);

            FileManager fileManager = new FileManager();

            string actual = fileManager.ReadLineFromFile(testFile, lineToRead);
            string expected = lineToRead.ToString();

            Assert.AreEqual(expected, actual);

            CleanupDirectories();
        }
    }
}
