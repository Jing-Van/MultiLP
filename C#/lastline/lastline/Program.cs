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
            //string AAA = str.Trim();   //ȥ��ǰ��ո�   

            //string AAA = myReader.GetString(0).TrimEnd();   //ȥ����ո�   

            //string AAA = myReader.GetString(0).TrimStart();   //ȥ��ǰ�ո�   
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
        string s = " ��ݸ�н�ҵӯ�Ե���豸���޹�˾,2";
        foreach (Match m in Regex.Matches(s, @"(?<=����).*?(?=\s|$)"))
        {
            Console.WriteLine(m);
        }
        Console.Read();*/
    }
}

