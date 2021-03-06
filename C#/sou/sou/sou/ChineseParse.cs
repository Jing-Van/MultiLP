/*using System;
using System.Collections.Generic;
using System.Text;

namespace sou
{
    class ChinesePars
    {
        //ChineseParse.cs //分词器

    /// <summary>
     /// 中文分词器。
     /// </summary>
        public class ChineseParse
        {
            private static ChineseWordsHashCountSet _countTable;

            static ChineseParse()
            {
                _countTable = new ChineseWordsHashCountSet();
                InitFromFile("ChineseDictionary.txt");
            }

           
            /// <summary>
            /// 从指定的文件中初始化中文词语字典和字符串次数字典。
            /// </summary>
            /// <param name="fileName">文件名</param>
            private static void InitFromFile(string fileName)
            {
                string path = Directory.GetCurrentDirectory() + @"\" + fileName;
                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {

                            ChineseWordUnit _tempUnit = InitUnit(s);
                            _countTable.InsertWord(_tempUnit.Word);
                        }
                    }
                }
            }

           
            /// <summary>
            /// 将一个字符串解析为ChineseWordUnit。
            /// </summary>
            /// <param name="s">字符串</param>
            /// <returns>解析得到的ChineseWordUnit</returns>
            private static ChineseWordUnit InitUnit(string s)
            {
                Regex reg = new Regex(@"\s+");
                string[] temp = reg.Split(s);
                if (temp.Length != 2)
                {
                    throw new Exception("字符串解析错误：" + s);
                }
                return new ChineseWordUnit(temp[0], Int32.Parse(temp[1]));
            }

            
            /// <summary>
            /// 分析输入的字符串，将其切割成一个个的词语。
            /// </summary>
            /// <param name="s">待切割的字符串</param>
            /// <returns>所切割得到的中文词语数组</returns>
            public static string[] ParseChinese(string s)
            {
                int _length = s.Length;
                string _temp = String.Empty;
                ArrayList _words = new ArrayList();

                for (int i = 0; i < s.Length; )
                {
                    _temp = s.Substring(i, 1);
                    if (_countTable.GetCount(_temp) > 1)
                    {
                        int j = 2;

                        for (; i + j < s.Length + 1 && _countTable.GetCount(s.Substring(i, j)) > 0; j++)
                        {
                        }
                        _temp = s.Substring(i, j - 1);
                        i = i + j - 2;
                    }
                    i++;
                    _words.Add(_temp);
                }

                string[] _tempStringArray = new string[_words.Count];
                _words.CopyTo(_tempStringArray);


                return _tempStringArray;
            }

        }

    }
}*/


