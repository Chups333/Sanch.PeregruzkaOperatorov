using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.PeregruzkaOperatorov
{
    public abstract class Product // наследоваться можно
    {
        //stastic класс один единственный общий для всего приложения!!! Нельзя наследоваться !!!!
        // abstract - запрещает делать экзепляры Product p = new Product() - нельзя сделать в Main и хоть где 
        // abstract - группировка
        public string Name { get;  }
        public int Calorie { get; }

        public int Volume { get; set; }
        
        public double Energy
        {
            get
            {
                return Volume * Calorie / 100.0;
            }
        }

        public Product(string name, int calorie, int volume) // конструктор нужен и указывать его везде и задавать его с теми же параметрами
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (calorie<0)
            {
                throw new ArgumentNullException(nameof(calorie));
            }
            if (volume<=0)
            {
                throw new ArgumentNullException(nameof(volume));
            }
            Name = name;
            Calorie = calorie;
            Volume = volume;
        }
        public override string ToString()
        {
            return $"{Name}. Калорийность: {Calorie}, Объем: {Volume} !";
        }
    }
}
