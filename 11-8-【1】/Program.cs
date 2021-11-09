using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_8__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*////事件Event
            //Person hekai = new Person();
            ////属性，方法，事件*/
            ///
            /// 属性方法 事件重要
            ///
            Person hekai = new Person();
            /*hekai.Shuanshu(1, 100);*/
            
            hekai.diguisuanshu(1, 100, 0);
        }
    }
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void Sayhello()
        {
            Console.WriteLine("my name is {0},i'm {1} years old.",Name,Age);
        }
        /*public void Shuanshu(int x, int y)
        {
            int result = 0;
            for (int i = x; i < y; i++)
            {
                result += i;
            }
            result += y;
            Console.WriteLine(result);
        }*/

        public void diguisuanshu(int x,int y,int result)
        {
            int Result=result;          
            if(x<y)
            {
                Result += x;
                x++;
                diguisuanshu(x, y,Result);
            }
            else
            {
                Result += y;
                Console.WriteLine(Result);
            }
        }
    }
}
