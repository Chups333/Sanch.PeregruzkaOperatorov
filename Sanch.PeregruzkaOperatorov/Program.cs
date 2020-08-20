using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.PeregruzkaOperatorov
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Красное яблоко",100,100);// можно делать!!! указали параметры как в конструкторе
            Apple apple2 = new Apple("Зеленое яблоко", 90, 110);

            //var sumApple = Apple.Add(apple, apple2);
            var sumApple2 = apple + apple2; //так проще и симпатичней

            var sumApple3 = apple + 100; //так проще и симпатичней

            var sumApple4 = apple != apple2; //так проще и симпатичней вернет True

            Console.WriteLine(apple);
            Console.WriteLine(apple2);
            //Console.WriteLine(sumApple);
            Console.WriteLine(sumApple2);
            Console.WriteLine(sumApple3);
            Console.WriteLine(sumApple4);
            Console.ReadKey();
        }
    }
}
