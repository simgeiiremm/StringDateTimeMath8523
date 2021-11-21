using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDateTimeMath8523
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] isimKarakterler = new char[3]
            {
                'C', 'A', 'N'
            };
            foreach (char c in isimKarakterler)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            string isimString = "CAN";
            Console.WriteLine(isimString);

            string city1 = "Ankara";
            Console.WriteLine(city1[0]); // A
            
            foreach (char c in city1)
            {
                Console.WriteLine(c);
            }

            string city2 = "İstanbul";
            string result1 = city1 + city2; // concetenate: Ankaraİstanbul
            string result2 = city1 + " " + city2; // Ankara İstanbul
            string result3 = string.Format("{0} {1}", city1, city2); // Ankara İstanbul

            string sentence = "My name is Çağıl Alsaç";
            int length = sentence.Length; //22 karakter
            sentence = sentence.Replace("Çağıl", "Leo"); // My name is Leo Alsaç (büyük küçük harf duyarlı)

            if (sentence.EndsWith("ç"))
                Console.WriteLine("Sentence ends with ç");
            else
                Console.WriteLine("Sentence doesn't end with ç");

            if (sentence.StartsWith("Your name"))
                Console.WriteLine("Sentence starts with \"Your name\""); // "Your name"
            else
                Console.WriteLine("Sentence doesn't start with Your name");

            //My name is Leo Alsaç
            int indexOfIs = sentence.IndexOf("is"); //8
            Console.WriteLine(indexOfIs);
            int indexOfCagil = sentence.IndexOf("çağıl"); // -1 döner bulamadıgı icin
            Console.WriteLine(indexOfCagil);

            int indexOfSpace = sentence.IndexOf(" "); //2
            Console.WriteLine(indexOfSpace);

            int lastIndexOfSpace = sentence.LastIndexOf(" "); // 14 aramaya bastan baslar son boslugu alır
            Console.WriteLine(indexOfSpace + "-" + lastIndexOfSpace);

            // Hello! My name is Leo Alsaç
            //sentence = "Hello" + sentence;
            sentence = sentence.Insert(0, "Hello! ");

            string subSentence = sentence.Substring(0,6); //Hello!
            Console.WriteLine(subSentence);
            subSentence = sentence.Substring(18); //Leo Alsaç
            subSentence = sentence.Substring(7, 14); //My name is Leo

            //Hello! My name is Leo Alsaç
            Console.WriteLine("Lower: " + sentence.ToLower());
            Console.WriteLine("Upper: " + sentence.ToUpper());
            Console.WriteLine(sentence.Replace("","_"));

            sentence = sentence.Remove(0, 7); //My name is Leo Alsaç
            string {  }



            //A123456-7 -> A: Abone Tipi (A: Bireysel, B: Kurumsal), 123456: Bina Numarası, 7: Daire Numarası
            string aboneNo = "A123456-7";

            //1. Yöntem: 
            if (aboneNo.StartsWith("A"))
                Console.WriteLine("Bireysel Abone");
            else
                Console.WriteLine("Kurumsal Abone");

            //2. Yöntem:
            if (aboneNo.Substring(0, 1) == "A")
                Console.WriteLine("Bireysel Abone");
            else
                Console.WriteLine("Kurumsal Abone");

            //3. Yöntem
            if (aboneNo[0] == 'A')
                Console.WriteLine("Bireysel Abone");
            else
                Console.WriteLine("Kurumsal Abone");

            string aboneTipi = aboneNo.Substring(0,1); //A
            string bina = aboneNo.Substring(1, 6); //123456
            string daire = aboneNo.Substring(8); // 7 -> daha dogru kullanım
            //string daire = aboneNo.Substring(8, aboneNo.Length - 8); // 7

            Console.WriteLine("Abone Numarası: " + aboneNo + "\nAbone Tipi: " + aboneTipi + "\nBina Numarası: " 
                + bina + "\nDaire Numarası: " + daire);
            


            Console.ReadLine();
        }
    }
}
