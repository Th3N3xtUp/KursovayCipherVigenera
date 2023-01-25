using System;
using MyLib;
namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void Test_shif_odnoslovo()

        {
            string kluch = "key";
            string mainalf = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string slovo = "computer";
            string expected = "msKzyRov";
            VisinerClass shif = new VisinerClass(kluch, slovo, mainalf);
            int[] a = new int[kluch.Length];
            a = shif.funckluch(kluch, mainalf, a);
            string[] slov = new string[slovo.Length];
            slov = shif.funcshifr(slovo, mainalf, a, slov);
            string result = "";
            for (int i = 0; i < slov.Length; i++)
            {
                result = result + slov[i];
            }
            Assert.AreEqual(expected, result);
        }
        [Test]

        public void Test_unshif_odnoslovo()

        {
            string kluch = "key";
            string mainalf = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string slovo = "msKzyRov";
            string expected = "computer";
            VisinerClass shif = new VisinerClass(kluch, slovo, mainalf);
            int[] a = new int[kluch.Length];
            a = shif.funckluch(kluch, mainalf, a);
            string[] slov = new string[slovo.Length];
            slov = shif.funcunshifr(slovo, mainalf, a, slov);
            string result = "";
            for (int i = 0; i < slov.Length; i++)
            {
                result = result + slov[i];
            }
            Assert.AreEqual(expected, result);
        }
        [Test]

        public void Test_shif_predlozh()

        {
            string kluch = "key";
            string znakalf = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890,.!?;'':<>/(){}[] ";
            string slovo = "Vigenere cipher wotking is correctly!";
            string expected = "6mEorCBixmmNriPjAMDoGxkxswxmsPBiADpW)";
            VisinerClass shif = new VisinerClass(kluch, slovo, znakalf);
            int[] a = new int[kluch.Length];
            a = shif.funckluch(kluch, znakalf, a);
            string[] slov = new string[slovo.Length];
            slov = shif.funcshifr(slovo, znakalf, a, slov);
            string result = "";
            for (int i = 0; i < slov.Length; i++)
            {
                result = result + slov[i];
            }
            Assert.AreEqual(expected, result);
        }
        [Test]

        public void Test_unshif_predlozh()

        {
            string kluch = "key";
            string znakalf = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890,.!?;'':<>/(){}[] ";
            string slovo = "6mEorCBixmmNriPjAMDoGxkxswxmsPBiADpW)";
            string expected = "Vigenere cipher wotking is correctly!";
            VisinerClass shif = new VisinerClass(kluch, slovo, znakalf);
            int[] a = new int[kluch.Length];
            a = shif.funckluch(kluch, znakalf, a);
            string[] slov = new string[slovo.Length];
            slov = shif.funcunshifr(slovo, znakalf, a, slov);
            string result = "";
            for (int i = 0; i < slov.Length; i++)
            {
                result = result + slov[i];
            }
            Assert.AreEqual(expected, result);
        }
        [Test]

        public void Test_shif_predlozh_new()

        {
            string kluch = "{hack}";
            string znakalf = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890,.!?;'':<>/(){}[] "; 
            string slovo = "cryptography is broken";
            string expected = "[yyrDkbyarru)psblnjrep";
            VisinerClass shif = new VisinerClass(kluch, slovo, znakalf);
            int[] a = new int[kluch.Length];
            a = shif.funckluch(kluch, znakalf, a);
            string[] slov = new string[slovo.Length];
            slov = shif.funcshifr(slovo, znakalf, a, slov);
            string result = "";
            for (int i = 0; i < slov.Length; i++)
            {
                result = result + slov[i];
            }
            Assert.AreEqual(expected, result);
        }

        [Test]

        public void Test_unshif_odnoslovo_new()

        {
            string kluch = "hacker";
            string mainalf = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string slovo = "UoYkCavDcI";
            string expected = "NoWayToDay";
            VisinerClass shif = new VisinerClass(kluch, slovo, mainalf);
            int[] a = new int[kluch.Length];
            a = shif.funckluch(kluch, mainalf, a);
            string[] slov = new string[slovo.Length];
            slov = shif.funcunshifr(slovo, mainalf, a, slov);
            string result = "";
            for (int i = 0; i < slov.Length; i++)
            {
                result = result + slov[i];
            }
            Assert.AreEqual(expected, result);
        }
    }
}

     
 

        