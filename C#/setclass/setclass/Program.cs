using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace chaji
{
    class setclass
    {
        static void Main()
        {
            string a = System.IO.File.ReadAllText("E:\\project\\setclass\\ck1.txt");
            string b = System.IO.File.ReadAllText("E:\\project\\setclass\\ck2.txt");

            foreach (string s in a.CompareTo(b))
            {   
             
             string path = @"E:\project\setclass\regex5.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("{0}", s);
                        //Console.WriteLine(fs);
                    }


                }

                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine("{0}", s);
                        //Console.WriteLine(fs);
                    }
                }
                Console.WriteLine(s);
            }   
            
           
        }
    }
}
/*
namespace chaji
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ShipDate { get; set; }
        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Price: {2}, ShipDate: {3}", ID, Name, Price, ShipDate.ToShortDateString());
        }
        public override bool Equals(object obj)
        {
            if (obj is Product)
            {
                Product p = (Product)obj;
                return (p.ID == ID && p.Name == Name && p.Price == Price && p.ShipDate == ShipDate);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }

}*/
//foreach (var product in pList1.Union(pList2))
//foreach (var product in pList1.Except(pList2))
// foreach (var product in pList1.Except(pList2).Union(pList2.Except(pList1)))
/**  
 * 两个文件a.txt和b.txt, 去掉相同的行, 即交集  
 *   
 * @author zhanjia  
 *  
 */  
/*public class TestSet {   
  
    /**  
     * @param args  
     */  /*
    public static void main(String[] args) {   
        String file1 = "D:/a.txt";   
        String file2 = "D:/b.txt";   
        Set set1 = new HashSet();   
        Set set11 = new HashSet();   
        Set set2 = new HashSet();   
           
        BufferedReader br1 = null;   
        BufferedReader br2 = null;   
           
        try {   
            br1 = new BufferedReader(new InputStreamReader(new FileInputStream(file1)));   
            br2 = new BufferedReader(new InputStreamReader(new FileInputStream(file2)));   
            String line1 = null;   
            String line2 = null;   
            while ((line1 = br1.readLine()) != null) {   
                set1.add(line1);   
                set11.add(line1);   
            }   
            while ((line2 = br2.readLine()) != null) {   
                set2.add(line2);   
            }   
               
            set11.retainAll(set2);   
            System.out.println("交集: " + set11);   
               
            set1.removeAll(set11);   
            System.out.println("set1去掉交集: " + set1);   
            set2.removeAll(set11);   
            System.out.println("set2去掉交集: " + set2);   
        } catch (Exception e) {   
            try {   
                br1.close();   
                br2.close();   
            } catch (Exception ce) {   
            }   
        }   
           
    }   
  
} */
/*using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(100);//单个添加
            foreach (int number in new int[6] { 9, 3, 7, 2, 4, 8 })
            {
                al.Add(number);//集体添加方法一
            }
            int[] number2 = new int[2] { 11, 12 };
            al.AddRange(number2);//集体添加方法二
            al.Remove(3);//移除值为3的
            al.RemoveAt(3);//移除第3个
            ArrayList al2 = new ArrayList(al.GetRange(1, 3));//新ArrayList只取旧ArrayList一部份


            Console.WriteLine("遍历方法一:");
            foreach (int i in al)//不要强制转换
            {
                Console.WriteLine(i);//遍历方法一
            }

            Console.WriteLine("遍历方法二:");
            for (int i = 0; i < al2.Count; i++)//数组是length
            {
                int number = (int)al2[i];//一定要强制转换
                Console.WriteLine(number);//遍历方法二

            }
        }
    }
}*/
/*
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Iesi.Collections.Generic;


namespace chaji
{
 public partial class _Default : System.Web.UI.Page 
 {
    protected void Page_Load(object sender, EventArgs e)
    {
        ISet<string> Girls = new HashedSet<string>();   
         Girls.Add("Christine");   
         Girls.Add("Eva");   
         Girls.Add("Jean");   
         Girls.Add("Novia");   
        Girls.Add("Winnie");   
   
         ISet<string> PMs = new HashedSet<string>();   
         PMs.Add("Eva");   
         PMs.Add("Novia");   
         PMs.Add("Vincent");   
         PMs.Add("Williams");   
         PMs.Add("Winnie");   
   
         /*ISet<string> GirlPMsLOR;#000000">= Girls.Intersect(PMs);#         
         Response.Write("是女生且是PM: <br />");   
         foreach (string s in GirlPMs) 
            {   
             Response.Write(s + "<br />");   
             }   
   
         Response.Write("<br />");   
         ISet<string> GirlNotPMs = Girls.Minus(PMs);   
         Response.Write("是女生且不是PM: <br />");   
         foreach (string s in GirlNotPMs) 
         {   
             Response.Write(s + "<br />");   
         }   
   
         Response.Write("<br />");   
         ISet<string> GirlOrPMs = Girls.Union(PMs);   
         Response.Write("是女生或是PM: <br />");   
         foreach (string s in GirlOrPMs) 
         {   
             Response.Write(s + "<br />");   
         }   
   
         Response.Write("<br />");   
         ISet<string> NotMatch = Girls.ExclusiveOr(PMs);   
         Response.Write("是女生但不是PM，或是PM但不是女生: <br />");   
         foreach (string s in NotMatch) {&nbsp;  
             Response.Write(s + "<br />");   
         }   

    }
  }
}*/


/*using System;
using System.Collections;

using Extensions;

namespace Extensions.Test
{
    // Unit test for Sets class.
    class Test
    {
        static void DisplayItems(String name, Set theSet)
        {
            Console.WriteLine(name);
            SortedList sortedItems = new SortedList(CaseInsensitiveComparer.Default);
            foreach (object key in theSet.Keys)
            {
                sortedItems.Add(key, null);
            }
            Console.Write('\t');
            int count = 1;
            foreach (object key in sortedItems.Keys)
            {
                Console.Write(key);
                if (count++ < sortedItems.Keys.Count)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        [STAThread]
        static void Main()
        {
            Set setA = new Set(CaseInsensitiveHashCodeProvider.Default, CaseInsensitiveComparer.Default);
            setA.Add("Green");
            setA.Add("purple");
            setA.Add("Red");
            setA.Add("blue");
            DisplayItems("set A:", setA);

            Set setB = new Set(CaseInsensitiveHashCodeProvider.Default, CaseInsensitiveComparer.Default);
            setB.Add("black");
            setB.Add("Blue");
            setB.Add("green");
            setB.Add("red");
            setB.Add("orange");
            DisplayItems("set B:", setB);

            Set setC = new Set(CaseInsensitiveHashCodeProvider.Default, CaseInsensitiveComparer.Default);
            setC.Add("pink");
            setC.Add("yellow");
            setC.Add("Black");
            setC.Add("turqoise");
            setC.Add("red");
            DisplayItems("set C:", setC);

            Console.WriteLine("-------------------------------------------------------------");

            DisplayItems("A union B:", setA.Union(setB));
            DisplayItems("B union C:", setB.Union(setC));
            DisplayItems("A intersect B", setA.Intersection(setB));
            DisplayItems("A xor B:", setA.ExclusiveOr(setB));
            DisplayItems("A xor C:", setA.ExclusiveOr(setC));
            DisplayItems("B xor C:", setB.ExclusiveOr(setC));
            DisplayItems("A - B:", setA.Difference(setB));
            DisplayItems("B - A:", setB.Difference(setA));

            DisplayItems("A union B union C:", setA | setB | setC);
            DisplayItems("B union C union A:", setB | setC | setA);
            DisplayItems("C union B union A:", setC | setB | setA);

            DisplayItems("A intersect B intersect C:", setA & setB & setC);
            DisplayItems("B intersect A intersect C:", setB & setA & setC);

            DisplayItems("(A xor B) xor C:", (setA ^ setB) ^ setC);
            DisplayItems("A xor (B xor C):", setA ^ (setB ^ setC));
            DisplayItems("(C xor A) xor B:", (setC ^ setA) ^ setB);
            DisplayItems("C xor (A xor B):", setC ^ (setA ^ setB));

            DisplayItems("(A - B) - C:", (setA - setB) - setC);
            DisplayItems("A - (B - C):", setA - (setB - setC));
            DisplayItems("(C - B) - A:", (setC - setB) - setA);
            DisplayItems("C - (B - A):", setC - (setB - setA));
        }
    }
}*/

