using static Complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework3
{


    class ComplexClass
    {
        private double re; //дейвительное число

        private double im; //мнимое число

        public override string ToString()
        {
            return $"{re} + {im}i";
        }

        public static ComplexClass Plus(ComplexClass a, ComplexClass b)
        {
            ComplexClass result = new ComplexClass(0, 0);

            result.re = a.re + b.re;
            result.im = a.im + b.im;

            return result;
        }

        public static ComplexClass Minus(ComplexClass a, ComplexClass b)
        {
            ComplexClass result = new ComplexClass(0, 0); 

            result.re = a.re - b.re;
            result.im = a.im - b.im;

            return result;
        }

        public static ComplexClass Multi(ComplexClass a, ComplexClass b)
        {
            ComplexClass result = new ComplexClass(1, 1);

            result.re = a.re * b.re;
            result.im = a.im * b.im;

            return result;
        }

        public ComplexClass(double re, double im) //конструктор
        {
            this.re = re; //this.re это переменная в структуре
            this.im = im;
        }


    }

    class Progran
    {
        static void Main()
        {

            static void Task(int taskNum = 0)
            {
                Console.WriteLine("Мои задачи c числами (2 + 7i) и (1 + 6i)");
                Console.Write("\n=====================================================================================================\n");
                Console.WriteLine($"1 --> Сложение комлексных чисел с помощью струкрутры.");
                Console.WriteLine($"2 --> Вычитание комлексных чисел с помощью струкрутры.");
                Console.WriteLine($"3 --> Сложение комлексных чисел с помощью класса.");
                Console.WriteLine($"4 --> Вычитание комлексных чисел с помощью класса.");
                Console.WriteLine($"5 --> Умножение комлексных чисел с помощью класса.");
                Console.WriteLine($"6 --> С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). " +
                    $"\nТребуется подсчитать сумму всех нечётных положительных чисел. " +
                    $"\nСами числа и сумму вывести на экран, используя tryParse.");

                
                Console.WriteLine("=====================================================================================================\n");

                bool task = true;
                while (task)
                {
                    Console.Write("\nВведите номер задачи, которую хотите просмотреть: ");
                    taskNum = int.Parse(Console.ReadLine());



                    switch (taskNum)
                    {
                        case 1:
                            Complex plusA = new Complex(2, 7); //вызов класса
                            Complex plusB = new Complex(1, 6);
                            Complex plusC = Complex.Plus(plusA, plusB);

                            Console.WriteLine($"Сумма комплексных чисел через использованием структуры равна: {plusC}");
                            break;

                        case 2:
                            Complex minusA = new Complex(2, 7); //вызов класса
                            Complex minusB = new Complex(1, 6);
                            Complex minusC = Complex.Minus(minusA, minusB);

                            Console.WriteLine($"Разность комплексных чисел через использованием структуры равна: {minusC}");

                            break;

                        case 3:
                            ComplexClass plusAClass = new ComplexClass(2, 7);
                            ComplexClass plusBClass = new ComplexClass(1, 6);
                            ComplexClass plusCClass = ComplexClass.Plus(plusAClass, plusBClass); 

                            Console.WriteLine(plusCClass);

                            break;

                        case 4:
                            ComplexClass minusAClass = new ComplexClass(2, 7);
                            ComplexClass minusBClass = new ComplexClass(1, 6);
                            ComplexClass minusCClass = ComplexClass.Minus(minusAClass, minusBClass);

                            Console.WriteLine($"Сумма комплексных чисел через использованием класса равна: {minusCClass}");

                            break;

                        case 5:
                            ComplexClass multiAClass = new ComplexClass(2, 7);
                            ComplexClass multiBClass = new ComplexClass(1, 6);
                            ComplexClass multiCClass = ComplexClass.Multi(multiAClass, multiBClass);

                            Console.WriteLine($"Произведение комплексных чисел через использование класса равна: {multiCClass}");

                            break;

                        case 6:

                            SumOfNums();
                            break;


                        case 0:
                            task = false;
                            Console.WriteLine("Конец работы программы");
                            break;

                        default:
                            Console.WriteLine("Такой задачи нет. Введите корректный номер от 1 до 6");
                            break;
                    }
                }
            }

            Task();

            static void SumOfNums(int num = 2)
            {
                int resultNum = 0;
                
                while (num != 0)
                {
                    bool result = int.TryParse(Console.ReadLine(), out num);
                    if (result)
                    {

                        if (num % 2 == 1 && num > 0)
                        {
                            resultNum += num;
                        }

                    }



                    
                    
                }
                Console.WriteLine($"Сумма цифр равна: {resultNum}");
            }
        
        }

    }

}







    
    
