using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace alistirma_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // 1. Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.

            //Topla(10, 10);

            //---------------------------------------------------------------------------------------------------------------//

            // 2. Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.

            //Console.Write("Bir sayı giriniz :");
            //int sayi = int.Parse(Console.ReadLine());

            //Aralik(sayi, 51);

            //---------------------------------------------------------------------------------------------------------------//

            // 3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.

            //Console.Write("Birinci sayıyı giriniz : ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz : ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Thirty(sayi1 , sayi2);

            //---------------------------------------------------------------------------------------------------------------//

            // 4. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.

            //Console.Write("Bir sayı giriniz :");
            //int sayi = int.Parse(Console.ReadLine());

            //Fark(sayi);

            //---------------------------------------------------------------------------------------------------------------//

            // 5. Write a C# Sharp program to create a string where 'if' is added to the front of a given string.
            // If the string already begins with 'if', return it unchanged.

            //Console.Write("Bir metin giriniz :");
            //string text = Console.ReadLine();

            //Test(text);

            //---------------------------------------------------------------------------------------------------------------//

            // 6. Write a C# Sharp program to remove the character at a given position in the string.
            // The given position will be in the range 0..(string length -1) inclusive.

            //Console.WriteLine("Bir kelime giriniz : ");
            //string text = Console.ReadLine();
            //Console.WriteLine("Bir indeks numarası giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //Character(text, sayi);

            //---------------------------------------------------------------------------------------------------------------//

            // 7. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.

            //Console.Write("Bir metin giriniz : ");
            //string deneme = Console.ReadLine();
            //Change(deneme);

            //---------------------------------------------------------------------------------------------------------------//

            // 8. Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string.
            // If the given string length is less than 2 return the original string.

            //Console.Write("Bir metin giriniz : ");
            //string text = Console.ReadLine();

            //Kopya(text);

            //---------------------------------------------------------------------------------------------------------------//

            // 9. Write a C# Sharp program to create a string with the last char added at the front and back of a given string of length 1 or more.

            //Console.Write("Bir metin giriniz : ");
            //string text = Console.ReadLine();

            //Ekleme(text);

            //---------------------------------------------------------------------------------------------------------------//

            // 10.  Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.

            //Console.Write("Kontrol sağlanacak sayıyı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //Say(sayi);

            //---------------------------------------------------------------------------------------------------------------//

            // 11. Write a C# Sharp program to create a string taking the first 3 characters of a given string.
            // Return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there.

            //Console.Write("Bir metin giriniz :");
            //string text2 = Console.ReadLine();

            //Char(text2);

            //---------------------------------------------------------------------------------------------------------------//

            // 12. Write a C# Sharp program to check if a given string starts with 'C#' or not.

            //Console.Write("Bir metin giriniz :");
            //string text = Console.ReadLine();

            //Control(text);

            //---------------------------------------------------------------------------------------------------------------//

            // 13. Write a C# Sharp program that checks whether one temperature is less than 0 and another is greater than 100.

            //Console.Write("1. sıcaklık değerini giriniz : ");
            //int deger1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sıcaklık değerini giriniz : ");
            //int deger2 = int.Parse(Console.ReadLine());

            //Temp(deger1, deger2);

            //---------------------------------------------------------------------------------------------------------------//

            // 14. Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.

            //Console.Write("1. sayıyı giriniz : ");
            //int say1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz : ");
            //int say2 = int.Parse(Console.ReadLine());

            //Ctrl(say1, say2);

            //---------------------------------------------------------------------------------------------------------------//

            // 15. Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive.
            // Return true if 1 or more of them are in the said range otherwise false.

            //Console.Write("1. sayıyı giriniz : ");
            //int say1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz : ");
            //int say2 = int.Parse(Console.ReadLine());
            //Console.Write("3. sayıyı giriniz : ");
            //int say3 = int.Parse(Console.ReadLine());

            //Control(say1, say2, say3);

            //---------------------------------------------------------------------------------------------------------------//

            // 16. Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive.
            // Return true if 1 or other is in the range, otherwise false.

            //Console.Write("1. sayıyı giriniz :");
            //int say1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz :");
            //int say2 = int.Parse(Console.ReadLine());


            //Ctrl(say1, say2);

            //---------------------------------------------------------------------------------------------------------------//

            // 17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string.
            // If it appears return a string without 'yt' otherwise return the original string.

            //Console.Write("Bir metin giriniz : ");
            //string text = Console.ReadLine();

            //bool sonuc = FindYT(text);

            //if(sonuc)
            //{
            //    Console.WriteLine($"Düzenlenmiş metin : {RemoveYT(text)}");
            //}
            //else
            //{
            //    Console.WriteLine($"Metin : {text}");
            //}

            //---------------------------------------------------------------------------------------------------------------//

            // 18. Write a C# Sharp program to check the largest number among three given integers.

            //Console.Write("1. sayıyı giriniz : ");
            //int say1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz : ");
            //int say2 = int.Parse(Console.ReadLine());
            //Console.Write("3. sayıyı giriniz : ");
            //int say3 = int.Parse(Console.ReadLine());

            //Biggest(say1, say2, say3);

            //---------------------------------------------------------------------------------------------------------------//

            // 19. Write a C# Sharp program to check which number is closest to 100 among two given integers. Return 0 if the two numbers are equal

            //Console.Write("1. sayıyı giirniz :");
            //int say1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giirniz :");
            //int say2 = int.Parse(Console.ReadLine());

            //Hundred(say1, say2);

            //---------------------------------------------------------------------------------------------------------------//

            // 20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.

            //Console.Write("1. sayıyı giriniz :");
            //int say1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz :");
            //int say2 = int.Parse(Console.ReadLine());

            //Control(say1, say2);

            //---------------------------------------------------------------------------------------------------------------//

            // 21. Write a C# Sharp program to find the largest value from two positive integer values in the range 20..30 inclusive.
            // Return 0 if neither is in that range.

            //Console.Write("1. sayıyı giriniz :");
            //int say1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz :");
            //int say2 = int.Parse(Console.ReadLine());

            //Ctrl(say1, say2);

            //---------------------------------------------------------------------------------------------------------------//

            // 22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.

            //Console.Write("Bir metin giriniz : ");
            //string text = Console.ReadLine();

            //Text(text);

            //---------------------------------------------------------------------------------------------------------------//

            // 23. Write a C# Sharp program to check if two given non-negative integers have the same last digit.

            //Console.Write("1. sayıyı giriniz :");
            //int say1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz :");
            //int say2 = int.Parse(Console.ReadLine());

            //Digit(say1, say2);

            //---------------------------------------------------------------------------------------------------------------//

            // 24. Write a C# Sharp program to convert the last 3 characters of a given string to uppercase.
            // If the length of the string is less than 3, then uppercase all the characters.

            //Console.Write("Bir metin giriniz : ");
            //string text = Console.ReadLine();

            //Upper(text);

            //---------------------------------------------------------------------------------------------------------------//

            // 25. Write a C# Sharp program to create a string which is n (non-negative integer) copies of a given string.

            //Console.Write("Bir metin giriniz : ");
            //string text = Console.ReadLine();
            //Console.Write("Tekrar sayısı giriniz : ");
            //int n = int.Parse(Console.ReadLine());

            //Repeat(text, n);

            //---------------------------------------------------------------------------------------------------------------//

            // 26. 







        }


        //---------------------------------------------------------------------------------------------------------------//
        //https://www.w3resource.com/csharp-exercises/basic-algo/index.php                                               //
        //---------------------------------------------------------------------------------------------------------------//

        #region 0-20 arası soruların metodları;


        #region 1. soru metod;
        //public static void Topla(double s1, double s2)
        //{
        //    double toplam = 0;
        //    if(s1 == s2)
        //    {
        //        toplam = (s1 + s2) * 3;
        //    }
        //    else if(s2 != s1)
        //    {
        //        toplam = s1 + s2;
        //    }

        //    Console.WriteLine(toplam);

        //}
        #endregion


        #region 2. soru metod;

        // public static void Aralik(int s1, int s2)
        // {
        //     int fark = 0;
        //     if(s1 < s2)
        //     {
        //         fark = s2 - s1;
        //     }
        //     else if(s1 >= s2)
        //     {
        //         fark = 0;
        //     }
        //     Console.WriteLine(fark);
        // }

        #endregion


        #region 3. soru metod;

        // public static Boolean Thirty(int s1, int s2)
        // {
        //     return s1 == 30 || s2 == 30 || s1 + s2 == 30;
        // }

        #endregion


        #region 4. soru metod;

        //public static void Fark(int s1)
        //{
        //    if ((s1 >= 90 && s1 <= 110 ) || ( s1 >= 190 && s1 <= 210))
        //    {
        //        Console.WriteLine("True");
        //    }
        //    else
        //    {
        //        Console.WriteLine("False");
        //    }
        //}

        #endregion


        #region 5. soru metod;

        //public static void Test(string text)
        //{
        //    if (text.Length > 2 && text.Substring(0, 2).Equals("if"))
        //    {
        //        Console.Write(text);
        //    }
        //    else
        //    {
        //        Console.Write($"if {text}\n");
        //    }
        //}


        #endregion


        #region 6. soru metod;

        //public static void Character(string a, int x)
        //{
        //    if (a.Length >= x)
        //    {
        //        string newa = a.Remove(x,1);
        //        Console.WriteLine(newa);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Girilen sayı değeri metin karakter sayısından fazla.");
        //    }
        //}


        #endregion


        #region 7. soru metod;

        //public static void Change(string a)
        //{
        //    if (a.Length >=2)
        //    {
        //        char b;
        //        char[] chars = a.ToCharArray();
        //        b = chars[0];
        //        chars[0] = chars[chars.Length - 1];
        //        chars[chars.Length - 1] = b;
        //        Console.WriteLine(chars);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Girilen metin en az 2 karakterde olmalı.");
        //    }
        //}

        #endregion


        #region 8. soru metod;

        //public static void Kopya(string a)
        //{
        //    if (a.Length >= 2)
        //    {
        //        string b = a.Substring(0, 2);
        //        Console.WriteLine(b+b+b+b);
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Girilen {a} metni çok kısa.");
        //    }
        //}


        #endregion


        #region 9. soru metod;

        //public static void Ekleme(string a)
        //{
        //    if (a.Length >= 1)
        //    {
        //        string s = a.Substring(0,1);
        //        string newA = s + a + s;
        //        Console.WriteLine(newA);
        //    }
        //}

        #endregion


        #region 10. soru metod;

        //public static void Say(int a)
        //{
        //    if(a > 0)
        //    {
        //        if(a % 3 == 0 || a % 7 == 0)
        //        {
        //            Console.WriteLine("True");
        //        }
        //        else
        //        {
        //            Console.WriteLine("False");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Girilen değer pozitif olmalı. ");
        //    }
        //}

        #endregion


        #region 11. soru metod;

        //public static void Char(string text)
        //{
        //    string newtext = "";
        //    for (int j = 0; j < 3; j++)
        //    {
        //        if (text.Length == 3)
        //        {
        //            for (int i = 0; i < 3; i++)
        //            {
        //                newtext += text[i];
        //            }
        //        }
        //        else if (text.Length == 2)
        //        {
        //            for (int i = 0; i < 2; i++)
        //            {
        //                newtext += text[i];
        //            }
        //        }

        //    }
        //    Console.WriteLine(newtext);
        //}

        #endregion


        #region 12. soru metod;

        //public static void Control(string a)
        //{
        //    string control = "C#";
        //    if (a.StartsWith(control))
        //    {
        //        Console.Write("True");
        //    }
        //    else
        //    {
        //        Console.Write("False");
        //    }
        //}
        #endregion


        #region 13. soru metod;

        //public static void Temp(int a, int b)
        //{
        //    if(a > b)
        //    {
        //        if(a > 100 && b < 0)
        //        {
        //            Console.Write("True");
        //        }
        //        else
        //        {
        //            Console.Write("False");
        //        }
        //    }
        //    else if(b > a)
        //    {
        //        if (b > 100 && a < 0)
        //        {
        //            Console.Write("True");
        //        }
        //        else
        //        {
        //            Console.Write("False");
        //        }
        //    }
        //    else
        //    {
        //        Console.Write("False");
        //    }
        //}

        #endregion


        #region 14. soru metod;

        //public static void Ctrl(int a,int b)
        //{
        //    if((a < 200 && a > 100) && (b < 200 && b > 100)) 
        //    {
        //        Console.Write("True");
        //    }
        //    else
        //    {
        //        Console.Write("False");
        //    }
        //}

        #endregion


        #region 15. soru metod;

        //public static void Control(int a, int b,int c)
        //{
        //    if((a > 20 && a < 50) || (b > 20 && b < 50) || (c > 20 && c < 50))
        //    {
        //        Console.Write("True");
        //    }
        //    else
        //    {
        //        Console.Write("False");
        //    }
        //}

        #endregion


        #region 16. soru metod;

        //public static void Ctrl(int a, int b)
        //{
        //    if((a >= 20 && a <=50) ^ (b <= 50 && b >= 20))
        //    {
        //        Console.Write("True");
        //    }
        //    else
        //    {
        //        Console.Write("False");
        //    }
        //}

        #endregion


        #region 17. soru metod;

        //public static bool FindYT(string a)
        //{
        //    if (a.Length > 1 && a.Substring(1, 2) == "yt")
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public static string RemoveYT(string b)
        //{
        //    if(FindYT(b))
        //    {
        //        return b.Remove(1,2);
        //    }
        //    else
        //    {
        //        return b;
        //    }
        //}


        #endregion


        #region 18. soru metod;

        //public static void Biggest(int a,int b, int c)
        //{
        //    if (a > b && a > c)
        //    {
        //        Console.Write(a);
        //    }
        //    else if(b > a && b > c)
        //    {
        //        Console.Write(b);
        //    }
        //    else
        //    {
        //        Console.Write(c);
        //    }
        //}

        #endregion


        #region 19. soru metod;

        //public static void Hundred(int a, int b)
        //{
        //    int fark1 = 100 - a;
        //    int fark2 = 100 - b;

        //    if(fark1 < fark2)
        //    {
        //        Console.Write(a);
        //    }
        //    else if(fark2 < fark1)
        //    {
        //        Console.Write(b);
        //    }
        //    else
        //    {
        //        Console.Write("0");
        //    }
        //}

        #endregion


        #region 20. soru metod;

        //public static void Control(int a,int b)
        //{
        //    if((a >= 40 && a <= 50) && (b >= 40 && b <= 50))
        //    {
        //        Console.Write("True");
        //    }
        //    else if((a >= 50 && a <= 60) && (b >= 50 && b <= 60))
        //    {
        //        Console.Write("True");
        //    }
        //    else
        //    {
        //        Console.Write("False");
        //    }
        //}

        #endregion

        #endregion


        #region 21. soru metod;

        //public static void Ctrl(int a,int b)
        //{
        //    if((a >= 20 && a <= 30) && (b >= 20 && b <= 30))
        //    {
        //        if(a > b)
        //        {
        //            Console.Write(a);
        //        }
        //        else
        //        {
        //            Console.Write(b);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("0");
        //    }
        //}

        #endregion


        #region 22. soru metod;

        //public static void Text(string a)
        //{
        //    int sayac = 0;

        //    for(int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] == 'z')
        //        {
        //            sayac += 1;
        //        }
        //    }
        //    if(sayac >= 2 && sayac <= 4)
        //    {
        //        Console.Write("True");
        //    }
        //    else
        //    {
        //        Console.Write("False");
        //    }
        //}

        #endregion


        #region 23. soru metod;

        //public static void Digit(int a,int b)
        //{
        //    int basamak1 = a % 10;
        //    int basamak2 = b % 10;

        //    if(basamak1 == basamak2)
        //    {
        //        Console.Write("Son basamakları eşittir.");
        //    }
        //    else
        //    {
        //        Console.Write("Son basamakları eşit değildir.");
        //    }
        //}

        #endregion


        #region 24. soru metod;

        //public static void Upper(string a)
        //{
        //    if(a.Length <= 3)
        //    {
        //        string b = a.ToUpper();
        //        Console.Write(b + "\n");
        //    }
        //    else
        //    {
        //        string b = a.Remove(a.Length - 3) + a.Substring(a.Length - 3).ToUpper();
        //        Console.Write(b + "\n");
        //    }
        //}

        #endregion


        #region 25. soru metod;

        //public static void Repeat(string a, int b)
        //{
        //    if(b > 0)
        //    {
        //        for (int i = 0; i < b; i++)
        //        {
        //            Console.Write(a);
        //        }
        //    }
        //    else
        //    {
        //        Console.Write(a);
        //    }
            
        //}

        #endregion



    }
}
