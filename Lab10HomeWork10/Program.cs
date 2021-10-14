using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Программа для перевода угла из градусов в радианы
                Console.Write("Введите градусы =");
                double gradusStart = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите минуты =");
                double minStart = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите секунды =");
                double secStart = Convert.ToDouble(Console.ReadLine());
                // Созданный объект на основеclass AngleConvert 
                AngleConvert angleConvert = new AngleConvert(gradusStart, minStart, secStart);
                angleConvert.ToRadian();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message);}

            Console.ReadKey();
        }
    }
    class AngleConvert
    {//Поля
        double gradus;
        double min;
        double sec;
        #region  Свойство Gradus
        public double Gradus
        {
            set 
            {
                if (value>=0 && value<360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Угол должен быть в пределах от 0 до 359 градусов");
                }
            }
            get 
            {
                return gradus;
            }
        }
        #endregion
        #region  Свойство Min
        public double Min
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Угол должен быть в пределах от 0 до 59 минут");
                }
            }
            get
            {
                return min;
            }
        }
        #endregion
        #region  Свойство Sec
        public double Sec
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Угол должен быть в пределах от 0 до 59 секунд");
                }
            }
            get
            {
                return sec;
            }
        }
        #endregion
        // Конструктор открытый
        public AngleConvert(double gradus, double min, double sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        //Метод ToRadian 
        public void ToRadian()
        {
                double Radian = ((gradus + (min/60) + (sec/3600)) / 180) * Math.PI;
                Console.WriteLine("Угол в радианах = {0:f5}", Radian);  
        }

    }

}
