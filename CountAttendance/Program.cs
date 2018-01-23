using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace CountAttendance
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeplaces = 0;
            
            List<string> Blocks = new List<string>();
            List<string> Blocks2 = new List<string>();
            List<int> Numbers = new List<int>();
            FileStream file1 = new FileStream("D:\\Attendance.txt", FileMode.OpenOrCreate);
            StreamReader reader1 = new StreamReader(file1, Encoding.Default);
            string data = reader1.ReadToEnd();
            //Regex template = new Regex("[0-9]{0,3}");
            Regex template = new Regex(@"[0-9]{1,4} шт|[0-9] [0-9]{1,4} шт");
            Regex template2 = new Regex(@"Мест: [0-9]{1,4}");
            MatchCollection matches = template.Matches(data);
            MatchCollection matches2 = template2.Matches(data);
            foreach(Match k in matches2)
            {
                Blocks2.Add(k.Value);
            }
            foreach(string l in Blocks2)
            {
                freeplaces += Convert.ToInt32(l.Substring(6));
            }
            //foreach (Match m in matches)
            //{
                
            //    Blocks.Add(m.Value);
            //}
            
            //foreach(string s in Blocks)
            //{
            //    int i = 0;
            //    while (s[i] != ' ')
            //    {
            //        i++;
            //    }
            //    if (Char.IsDigit(s[i+1]))
            //    {
            //        i++;
            //        while (s[i] != ' ')
            //        {
            //            i++;
            //        }
            //        string temp = s.Remove(i);
            //        string temp2 = temp.Replace(" ", "");
            //        Numbers.Add(Convert.ToInt32(temp2));
            //    }
            //    else
            //    {
            //        Numbers.Add(Convert.ToInt32(s.Remove(i)));
            //    }
                
                
            //}
            //foreach(int n in Numbers)
            //{
            //    freeplaces += n;
            //}
            Console.WriteLine("Осталось свободных мест: " + freeplaces);
            Console.ReadKey();
        }
    }
}
