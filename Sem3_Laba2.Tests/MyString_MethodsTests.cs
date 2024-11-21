using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Laba2.Tests
{
    [TestClass]
    public class MyString_MethodsTests
    {
        private MyString _myString;
        public MyString_MethodsTests()
        {
            _myString = new MyString(MyString.Empty);
        }

        //Tests for MyString.Contains()
        [TestMethod]
        [DataRow("qeqoqeq", 'e')]
        [DataRow("Hello World", 'W')]
        public void Contains_OK_1(string str, char testValue)
        {
            _myString = str;
            Assert.IsTrue(_myString.Contains(testValue));
        }
        [TestMethod]
        [DataRow("qeqoqeq", "qoq")]
        [DataRow("qeqoqeq", "q")]
        [DataRow("Hello World", "Hello")]
        [DataRow("String", "String")]
        public void Contains_OK_2(string str, string testValue)
        {
            _myString = str;
            MyString testString = testValue;
            Assert.IsTrue(_myString.Contains(testString));
        }

        [TestMethod]
        [DataRow("qeqoqeq", 'd')]
        [DataRow("qeqoqeq", 'Q')]
        [DataRow("Hello World", 'w')]
        public void Contains_Wrong_1(string str, char testValue)
        {
            _myString = str;
            Assert.IsFalse(_myString.Contains(testValue));
        }
        [TestMethod]
        [DataRow("qeqoqeq", "qeo")]
        [DataRow("qeqoqeq", "Q")]
        [DataRow("Hello World", "Worlde")]
        public void Contains_Wrong_2(string str, string testValue)
        {
            _myString = str;
            MyString testString = testValue;
            Assert.IsFalse(_myString.Contains(testString));
        }


        //Tests for MyString.IndexOf()
        [TestMethod]
        [DataRow("qeqoqeq", 'e')]
        [DataRow("Hello World", 'W')]
        public void IndexOf_OK_1(string str, char testValue)
        {
            _myString = str;
            Assert.IsTrue(_myString.IndexOf(testValue) >= 0);
        }
        [TestMethod]
        [DataRow("qeqoqeq", "qoq")]
        [DataRow("qeqoqeq", "q")]
        [DataRow("Hello World", "Hello")]
        [DataRow("String", "String")]
        public void IndexOf_OK_2(string str, string testValue)
        {
            _myString = str;
            MyString testString = testValue;
            Assert.IsTrue(_myString.IndexOf(testString) >= 0);
        }
        [TestMethod]
        [DataRow("qesqoqeq", 's')]
        [DataRow("Hello World", 'l')]
        public void IndexOf_OK_3(string str, char testValue)
        {
            _myString = str;
            Assert.IsTrue(_myString.IndexOf(testValue) == 2);
        }
        [TestMethod]
        [DataRow("qeqoqeq1", '1')]
        [DataRow("Hello World", 'd')]
        public void IndexOf_OK_4(string str, char testValue)
        {
            _myString = str;
            Assert.IsTrue(_myString.IndexOf(testValue) == _myString.Length-1);
        }
        [TestMethod]
        [DataRow("qeqoqeq", "q")]
        [DataRow("Hello World", "Hello")]
        [DataRow("String", "String")]
        public void IndexOf_OK_5(string str, string testValue)
        {
            _myString = str;
            MyString testString = testValue;
            Assert.IsTrue(_myString.IndexOf(testString) == 0);
        }
        [TestMethod]
        [DataRow("qeqoqeq", "qoq")]
        [DataRow("Hello World", "llo")]
        [DataRow("String", "ring")]
        public void IndexOf_OK_6(string str, string testValue)
        {
            _myString = str;
            MyString testString = testValue;
            Assert.IsTrue(_myString.IndexOf(testString) == 2);
        }

        [TestMethod]
        [DataRow("qeqoqeq", 'd')]
        [DataRow("qeqoqeq", 'Q')]
        [DataRow("Hello World", 'w')]
        public void IndexOf_Wrong_1(string str, char testValue)
        {
            _myString = str;
            Assert.IsFalse(_myString.IndexOf(testValue) >= 0);
        }
        [TestMethod]
        [DataRow("qeqoqeq", "qeo")]
        [DataRow("qeqoqeq", "Q")]
        [DataRow("Hello World", "Worlde")]
        public void IndexOf_Wrong_2(string str, string testValue)
        {
            _myString = str;
            MyString testString = testValue;
            Assert.IsFalse(_myString.IndexOf(testString) >= 0);
        }

        //Tests for MyString.Substring()
        [TestMethod]
        [DataRow("Hello World", 2, 8)]
        [DataRow("qeqoqeq", 0)]
        [DataRow("qeqoqeq", 6, 1)]
        [DataRow("",0)]
        public void Substring_OK_1(string str, int testValue1, int testValue2 = -2121354) 
        {
            _myString = str;
            if (testValue2 == -2121354)
                testValue2 = _myString.Length;
            Assert.AreEqual(str.Substring(testValue1, testValue2), _myString.Substring(testValue1, testValue2).ToString());
        }
        [TestMethod]
        [DataRow("Hello World", -5)]
        [DataRow("qeqoqeq", 8)]
        [DataRow("qeqoqeq", 1, 9)]
        public void Substring_Wrong_1(string str, int testValue1, int testValue2 = -2121354)
        {
            _myString = str;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _myString.Substring(testValue1));
        }
    }
}
