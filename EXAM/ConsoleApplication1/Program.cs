using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0317001
{
    class Program
    {
        static void Main0(string[] args)
        {//List Step2:
            var line = "this is string";
            Console.WriteLine(line);

        }
        static void Main1(string[] args)
        {//List Step3 (1): string to string
            String type001 = "this is string";
            String type002 = type001;
            Console.WriteLine(type001);
            Console.WriteLine(type002);

            type001 = "this is ing";
            Console.WriteLine(type001);
            Console.WriteLine(type002 + "(Original)");
        }
        static void Main2(string[] args)
        {//ListStep3 (2): string replace
            /*
            reference:msdn.microsoft.com/zh-tw/library/fk49wtc1(v=vs.110).aspx
            */
            string in3021 = "this is string.";
            Console.WriteLine("Original:{0}'{1}'{0}", Environment.NewLine, in3021);
            string in3022 = in3021.Replace("string", "ing");
            Console.WriteLine("Answer Type:{0}'{1}'", Environment.NewLine, in3022);
        }
        static void Main3(string[] args)
        {//ListStep4 (1):string replace
            string here401 = "this is string";
            Console.WriteLine("Basic Type:{0}'{1}'{0}", Environment.NewLine, here401);
            string here402 = here401.Replace("string", "STRing");
            Console.WriteLine("New Type Now : {0}'{1}'", Environment.NewLine, here402);
        }


        static void Main4(string[] args)
        {//ListStep4(2):string.ToUpper()/string.ToLower() C#testbook P.10-30
            string hereptHead = "This is ";
            var hereptchange = "str";
            string hereptend = "ing.";
            Console.WriteLine(hereptHead + hereptchange + hereptend);
            var final = hereptHead + hereptchange.ToUpper() + hereptend;
            Console.WriteLine(final);
                    }

        static void Main5(string[] args)
        {//ListStep5
            string part1 = "this ";
            string part2 = "is ";
            string part3 = "string.";
            string finalFantasy = part1 + part2 + part3;

            Console.WriteLine(finalFantasy);
                    }


        static void Main6(string[] args)
        {//ListStep6 By web
         /*reference:msdn.microsoft.com/zh-tw/library/system.string.format(v=vs.110).aspx*/
            var QQ = string.Format("This {0} string", "is");

            Console.WriteLine(QQ);
        }


        static void Main7(string[] args)
        {//ListStep7 int 轉換 string
         /*reference Web:takamai.pixnet.net/blog/post/34831317-c%23%EF%BC%8Cint%E8%BD%89%E6%88%90string%EF%BC%8Cstring%E8%BD%89%E6%88%90int*/
            {
                var i = 10;
                Console.WriteLine("right now the i is " + i);
                string transi = Convert.ToString(i);
                string show = i + "月" + i + "日" + "   天氣黑   " + "那一天 我看到空中的煙火哇哈哈!";
                Console.WriteLine(show);
            }
        }

        static void Main8(string[] args)
        {//List step8 定義商 功能:假設某數值可以被3整除
         //reference : www.itjsxx.com/csharp/csharp_exact_division.html
         //USE result%3==0
            int number;
            number = 3;//IF
            if (number % 3 == 0) Console.WriteLine(true);
            else Console.WriteLine(false);            
        }
        static void Main(string[] args)
        {//List step9: loop, all can%3==0
                int result = 0;
                for (int i = 0; i < 100; i++)
                {
                    if ((i % 3) == 0)
                    {
                        //result = result+ i;
                        result += i;
                    }
                }
                Console.WriteLine("All the numbers which can%3 ==0 is tatol " + result);
                Console.ReadKey();

            }

    }
}

  