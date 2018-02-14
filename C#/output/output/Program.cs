using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace output
{
    class Program
    {
        static void Main()
        {
            string txt = "";
            StreamReader sr = new StreamReader(@"E:\project\output\lastline.txt");

            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                //str = str.Substring(9, 6);
                
               txt += str + "\n";
            }


            sr.Close();
            string path = @"E:\project\output\output.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("{0}", txt);
                    //Console.WriteLine(fs);
                }


            }

            Console.Write(txt); 
        }
    }
}
