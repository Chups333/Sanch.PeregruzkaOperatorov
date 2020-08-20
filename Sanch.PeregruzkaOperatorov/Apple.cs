using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.PeregruzkaOperatorov
{
    public class Apple : Product // main можно определять теперь
    {
        public Apple(string name, int calorie, int volume) : base(name, calorie, volume)// конструктор из Product ( проверку уже делать не надо)
        {
        }
        /*public static Apple Add(Apple apple1, Apple apple2)
        {
            var calories = (int)Math.Round(((apple1.Calorie + apple2.Calorie) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calories, volume);

            return apple;
        }*/
        public static Apple operator +(Apple apple1, Apple apple2) //перегрузка оператора - * / % == != < > >= <= ++ -- 
        {
            //оператор = и ? не может быть 
            var calories = (int)Math.Round(((apple1.Calorie + apple2.Calorie) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calories, volume);

            return apple;
        }

        public static Apple operator+ (Apple apple1, int volume) 
        {
           
            var apple = new Apple(apple1.Name, apple1.Calorie, apple1.Volume + volume);

            return apple;
        }

        public static bool operator == (Apple apple1, Apple apple2) //обязательно и неравно
        {


            return apple1.Name == apple2.Name; 
            

            
        }

        public static bool operator !=(Apple apple1, Apple apple2)
        {

            

            return apple1.Name != apple2.Name; 
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }




        /*public static Apple operator/= (Apple apple1, Apple apple2) 
             var calories = (int)Math.Round(((apple1.Calorie + apple2.Calorie) / 2.0));
             var volume = apple1.Volume + apple2.Volume;
             var apple = new Apple("Яблоко", calories, volume);

             int i = 0;
             i += 5;

             return apple;
         }*/
    }
}
