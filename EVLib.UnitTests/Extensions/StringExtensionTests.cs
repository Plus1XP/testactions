﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using EVLlib.Extensions;

using System;
using System.Collections.Generic;
using System.Text;

namespace EVLlib.Extensions.Tests
{
    [TestClass()]
    public class StringExtensionTests
    {
        string normalTestString = "Hello! i am a simple string for testing purposes. " +
                                    "Please be gentle!";

        string multipleSpacedTestString = "   Hello! i     am a simple string     with far too many  " +
                "spaces...  Please    Help!   ";

        [TestMethod()]
        public void BetweenTest()
        {
            string expected = "for testing purposes. ";

            string results = normalTestString.Between("string ", "Please");

            Assert.AreEqual(expected, results);
        }

        [TestMethod()]
        public void BeforeTest()
        {
            string expected = "Hello! i am a simple string";

            string results = normalTestString.Before(" for");

            Assert.AreEqual(expected, results);
        }

        [TestMethod()]
        public void AfterTest()
        {
            string expected = "Please be gentle!";

            string results = normalTestString.After("purposes. ");

            Assert.AreEqual(expected, results);
        }

        [TestMethod()]
        public void RemoveWordsTest()
        {
            string expected = "! i am a string for testing purposes. be gentle!";

            string results = normalTestString.RemoveWords(new string[] { "Hello", "simple", "Please" });

            Assert.AreEqual(expected, results);
        }

        [TestMethod()]
        public void ReplaceLettersTest()
        {
            char find = Convert.ToChar("e");
            char replace = Convert.ToChar("3");

            string expected = "H3llo! i am a simpl3 string for t3sting purpos3s. " +
                                "Pl3as3 b3 g3ntl3!";

            string results = normalTestString.ReplaceLetters(find, replace);

            Assert.AreEqual(expected, results);
        }

        [TestMethod()]
        public void ReduceWhiteSpacesTest()
        {
            string expected = " Hello! i am a simple string with far too many " +
                "spaces... Please Help! ";

            string results = multipleSpacedTestString.ReduceWhitespaces();

            Assert.AreEqual(expected, results);
        }
    }
}