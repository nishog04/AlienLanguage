using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlienLanguage;
using System.Collections.Generic;

namespace AlienLanguageTest
{
    [TestClass]
    public class TranslatorTest
    {
        [TestMethod]
        public void CreateLdnTest()
        {
            //Arrange
            int[] ldn = new int[3];
            bool flag = false;
            string[] temp = new string[3] { "1", "2", "3" };

            //Act
            if (temp.Length > 0)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    ldn[i] = int.Parse(temp[i]);
                }
            }
            if (ldn.Length == 3)
            {
                flag = true;
            }

            //Assert
            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void SetLDNTest()
        {
            //Arrange
            int inputInt;
            string inputString = "3";
            
            //Act
            inputInt = int.Parse(inputString);
            
            //Assert
            Assert.AreEqual(3, inputInt);
        }

        [TestMethod]
        public void CreateDictionaryTest()
        {
            //Arrange
            bool flag = false;
            int[] ldn = new int[3] { 3, 2, 2 };
            List<string> dictionary = new List<string>();
            string[] temp = new string[2] { "abc", "aac" };

            //Act
            for (int i = 0; i < ldn[1]; i++)
            {
                dictionary.Add(temp[i]);
            }

            if (dictionary.Count == ldn[1])
            {
                flag = true;
            }

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
