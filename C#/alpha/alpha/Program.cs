using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

 class Test
  {
    public static void Main()
    {
        string path = @"E:\project\alpha\alpha.txt";
         if (!File.Exists(path))
         {
             using (StreamWriter sw = File.CreateText(path))
             {
                 int i, j;
                 for (i = 97; i <= 122; i++)
                 {
                     sw.WriteLine("{0}", (char)i);
                 }
                 for (i = 97; i <= 122; i++)
                 {
                     for (j = 97; j <= 122; j++)
                     {
                         sw.WriteLine("{0}{1}", (char)i, (char)j);
                     }
                 }
             }
         }
        
    }
  }