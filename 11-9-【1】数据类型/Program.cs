using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_9__1_数据类型
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 笔记
            /*基本数据类型
           string          字符串
           object          基类
           -------------
           引用类型
           class           类
           delegate        委托
           interface       接口  
           -------------
           /值类型
           /int
           /long
           /short
           /uint
           /char
           /sbyte
           /byte
           /float
           /double
            */
            #endregion
            Person hekai = new Person();
            double x = 1;
            double y = 10;
            double z = 100;
            double result = hekai.Suanshu(out x, y,z);
            Console.WriteLine(x+" "+result+" "+ z);
            //有效的申明的一个修饰符组合
            //变量：以变量名所对应的内存地址为起点，以其数据类型所要求的存储空间为长度的一块内存区域
            //两种数据类型的变量在内存中的存储形式不同
            //比如类 和 结构体

            //p7/40
        }
    }
    public class Person
    {
        public double Suanshu(out double x,double y,double z )
        {
            z += y;
            x = z;
            
            return z;
        }
    }
}
