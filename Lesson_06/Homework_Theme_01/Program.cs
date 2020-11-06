﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

            string fullname;   // Имя
            ushort age;        // Возраст
            uint height;       // Рост
            double hP;           // Оценка по истории
            double mP;           // Оценка по математике
            double rP;           // Оценка по русскому языку
            double averagePoint; // Средний балл по всем предметам

            string pattern = "Ваше имя: {0}, Ваш возраст: {1}, Ваш рост: {2}, Ваша оценка по истории: {3}, Ваша оценка по математике: {4}, Ваша оценка по русскому языку: {5}, Ваш средний балл: {6:0.0}"; // создаем шаблон для форматированного вывода

            Console.WriteLine("Введите ваше имя:");
            fullname = Console.ReadLine(); // записываем имя

            Console.WriteLine("Введите ваш возраст:");
            age = ushort.Parse(Console.ReadLine()); // преобразуем в ushort и записываем возраст

            Console.WriteLine("Введите ваш рост:");
            height = uint.Parse(Console.ReadLine()); // преобразуем в uint и записываем рост

            Console.WriteLine("Введите вашу оценку по истории:");
            hP = double.Parse(Console.ReadLine()); // преобразуем в double и записываем оценку по истории

            Console.WriteLine("Введите вашу оценку по математике:");
            mP = double.Parse(Console.ReadLine()); // преобразуем в double и записываем оценку по математике

            Console.WriteLine("Введите вашу оценку по русскому языку:");
            rP = double.Parse(Console.ReadLine()); // преобразуем в double и записываем оценку по русскому языку

            /// <summary>
            /// Нахождение среднего балла по всем предметам
            /// </summary>
            averagePoint = (hP + mP + rP) / 3;

            Console.SetCursorPosition(50, 50);
            Console.WriteLine("---Обычный вывод---"); // выводим в консоль обычный вывод
            Console.SetCursorPosition(50, 51);
            Console.WriteLine(fullname + age + height + hP + mP + rP + averagePoint);
            Console.SetCursorPosition(50, 53);
            Console.WriteLine("---Форматированный вывод---"); // выводим в консоль форматированный вывод  
            Console.SetCursorPosition(50, 54);
            Console.WriteLine (pattern,
                                fullname, 
                                age, 
                                height, 
                                hP, 
                                mP, 
                                rP, 
                                averagePoint);
            Console.SetCursorPosition(50, 57);
            Console.WriteLine("---Интерполяция строк---"); // выводим в консоль вывод с интерполяцией строк
            Console.SetCursorPosition(50, 58);
            Console.WriteLine($"Ваше имя: {fullname}, Ваш возраст: {age}, Ваш рост: {height}, Ваша оценка по истории: {hP}, Ваша оценка по математике: {mP}, Ваша оценка по русскому языку: {rP}, Ваш средний балл: {averagePoint:0.0}");

            Console.ReadKey();



        }
    }
}
