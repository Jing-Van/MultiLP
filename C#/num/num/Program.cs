using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;

namespace num
{
  class Program
  {
    static void Main()
    {
          StreamReader sr = new StreamReader(@"E:\project\num\ck1.txt",Encoding.Default);
          StreamReader tr = new StreamReader(@"E:\project\num\ck2.txt",Encoding.Default);
        while (!sr.EndOfStream)
        {
            string str = sr.ReadLine();
            while (!tr.EndOfStream)
            {
                string tsr = tr.ReadLine();
                if (str != tsr)
                {
                    string path = @"E:\project\num\ck3.txt";
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine("{0}", str);
                            sw.Close();
                        }
                    }
                
                   else
                   {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine("{0}", str);
                        sw.Close();
                    }
                   }
                }
            }
            string str = sr.ReadNextLine();
         }  
       
        sr.Close();
       }
    }
}

   
            /* string fn = "num.txt";
                StreamReader sr = new StreamReader(fn);
                string c = sr.ReadToEnd();
                string[] cs = c.Split(new char[] { '\n', '\r' });
                sr.Close();
                string lastLine = cs[cs.Length - 1];
                string path1 = @"E:\project\num\num2.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path1))
                    {
                        sw.WriteLine("{0}", lastLine);
                        //Console.WriteLine(fs);
                    }


                }*/