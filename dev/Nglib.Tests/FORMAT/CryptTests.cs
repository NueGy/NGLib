﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nglib.MANIPULATE.FORMAT
{
    [TestClass]
    public class CryptTests
    {
        [TestMethod]
        public void TestMethod1()
        {

            //string cr1 = Nglib.FORMAT.STRING.CryptHash.Encrypt("test1", "azertyuiopqsdfghjklmwxcvbn");
            //string cr2 = Nglib.FORMAT.STRING.CryptHash.Encrypt("test2", "azertyuiopqsdfghjklmwxcvbn");

            string res = null;

            string encr = "axxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx oop";
            string key = "azertyuiopqsdfghjklmwxcvbn";
            for (int i = 0; i < 1000; i++)
            {
                string ert = Nglib.FORMAT.CryptHashTools.Encrypt(encr, key);
                string ert2 = Nglib.FORMAT.CryptHashTools.Decrypt(ert, key);
                //Console.WriteLine(string.Format("{0} --> {1}", ert,ert2));
            }


            /// string recr = Nglib.FORMAT.STRING.CryptHash.Decrypt(cr.ToString(), "azertyuiopqsdfghjklmwxcvbn");


        }



        [TestMethod]
        public void TestMethod2()
        {
            string encr = "12kfkfkfkfk7778";
            encr = "fyki1565!";

            string ert = Nglib.FORMAT.CryptHashTools.Encrypt(encr, "AEjfekNFk5rgk444jrk7oznnazeryunP");
            string ert2 = Nglib.FORMAT.CryptHashTools.Decrypt(ert, "AEjfekNFk5rgk444jrk7oznnazeryunP");
            Assert.AreEqual(encr, ert2);

            string erta = Nglib.FORMAT.CryptHashTools.Encrypt(encr, "AEjfekNFk5rgk444jrk7oznnazeryunP");
            string erta2 = Nglib.FORMAT.CryptHashTools.Decrypt(ert, "AEjfekNFk5rgk444jrk7oznnazeryunP");
            Assert.AreEqual(erta, erta2);


        }




        }
    }
