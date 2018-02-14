using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;

class Program
{
    static void Main()
    {
          StreamReader sr = new StreamReader(@"E:\project\lastline\string2.txt", Encoding.UTF8);
        //StreamReader sr = new StreamReader(@"E:\project\lastline\string.txt",Encoding.Default);
        while (!sr.EndOfStream)
        {
            string str = sr.ReadLine();
            //string subline = "";
            //string AAA = str.Trim();   //去掉前后空格   

            //string AAA = myReader.GetString(0).TrimEnd();   //去掉后空格   

            //string AAA = myReader.GetString(0).TrimStart();   //去掉前空格   
            //subline = str.Substring(0, str.IndexOf(','));
            string AAA = str.Replace("   ", "");
            //str = str.Replace("   ", "");
            string path = @"E:\project\lastline\string4.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    //sw.WriteLine("{0}", str);
                    sw.WriteLine("{0}", AAA);
                    //sw.WriteLine("{0}", subline);
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    //sw.WriteLine("{0}", str);
                    sw.WriteLine("{0}", AAA);
                    sw.Close();
                }
            }
             
        }
        
        
        sr.Close();
        /*
        string s = " 东莞市金业盈辉电控设备有限公司,2";
        foreach (Match m in Regex.Matches(s, @"(?<=：，).*?(?=\s|$)"))
        {
            Console.WriteLine(m);
        }
        Console.Read();*/
    }
}

