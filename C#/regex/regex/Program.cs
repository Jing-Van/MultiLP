using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;



namespace mergetxt
{
    class merge
    {
        public static void Main()
        {
            
            /*string a = System.IO.File.ReadAllText("E:\\project\\regex\\regex1.txt");
            string b = System.IO.File.ReadAllText("E:\\project\\regex\\regex2.txt");

            System.IO.File.WriteAllText("E:\\project\\regex\\regex.txt", a + b);
            //string[] c = new String[5];
            //string c = System.IO.File.ReadAllText("E:\\project\\regex\\regex.txt");
            //string path = @"E:\project\regex\regex.txt";
            string myString = System.IO.File.ReadAllText("E:\\project\\regex\\regex.txt");*/

            string fs = "";
            string txt = "";
            StreamReader sr = new StreamReader(@"E:\project\regex\regex.txt");

            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                //str = str.Substring(9, 6);
                  txt += str;
                //txt += str + "\n";
            }


            sr.Close();

            Console.Write(txt); 

            /*
            if (!File.Exists(path))
            {
                using (StreamReader sw = File.CreateText(path))
                {
                    string myString=sw.ReadLine("{0}", fs);
                    //Console.WriteLine(fs);
                }


            }*/
            /*
            Regex.IsMatch("ÖÐÎÄ", "^[\u4e00-\u9fa5]+$");

            Regex rx = new Regex("^[\u4e00-\u9fa5]+$");
     
             // Define some test strings.
              string[] tests = myString;


             // Check each test string against the regular expression.
             foreach (string test in txt)
             {
                 if (rx.IsMatch(test))
                 {
                     Console.WriteLine("{0}", test);
                 }
                 else
                 {
                     //Console.WriteLine("{0}", test);
                     return;
                 }
             } */

                for (int i = 0; i < txt.Length; i++)
                {
                    string emtpy =txt.Substring(i, 1).ToString();
                    if (fs.Length == 0)
                    {
                        fs = emtpy;
                    }
                    if (fs.IndexOf(emtpy, 0) < 0)
                    {
                        fs += emtpy;
                    }
                    string path = @"E:\project\regex\regex5.txt";
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine("{0}", fs);
                            //Console.WriteLine(fs);
                        }


                    }
               
                    else
                    {
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine("{0}", fs);
                            //Console.WriteLine(fs);
                        }
                    }
                }
                
                
           
                /*
                string[] stest = myString;
                ArrayList list = new ArrayList();
                for (int i = 0; i < stest.Length; i++)
                {
                    bool IsExist = true;
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j].ToString() == stest[i])
                        {
                            IsExist = false;
                            break;
                        }
                    }
                    if (IsExist)
                        list.Add(stest[i]);
                }
                if (!list.Contains(stest[i]))

                    list.Add(stest[i]);
                for (int i = 0; i < stest.Length; i++)
                {
                    string path = @"E:\project\regex\regex5.txt";
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine("{0}", stest[i]);
                            //Console.WriteLine(fs);
                        }


                    }
               }*/

        }
    } 
}
           