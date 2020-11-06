using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

            Console.WriteLine("Введите имя:");
            fullname = Console.ReadLine(); // записываем имя

            Console.WriteLine("Введите возраст:");
            age = ushort.Parse(Console.ReadLine()); // преобразуем в ushort и записываем возраст

            Console.WriteLine("Введите рост:");
            height = uint.Parse(Console.ReadLine()); // преобразуем в uint и записываем рост

            Console.WriteLine("Введите балл по истории:");
            hP = double.Parse(Console.ReadLine()); // преобразуем в double и записываем оценку по истории

            Console.WriteLine("Введите балл по математике:");
            mP = double.Parse(Console.ReadLine()); // преобразуем в double и записываем оценку по математике

            Console.WriteLine("Введите балл по русскому языку:");
            rP = double.Parse(Console.ReadLine()); // преобразуем в double и записываем оценку по русскому языку


            /// <summary>
            /// Нахождение среднего балла по всем предметам
            /// </summary>
            averagePoint = (hP + mP + rP) / 3;

            string output = "---Обычный вывод---"; 
            string pattern = fullname + age + height + hP + mP + rP + averagePoint; // создаем шаблон для обычного вывода

            string formatOutput = "---Форматированный вывод---";
            string formatPattern = String.Format("Имя: {0}, Возраст: {1}, Рост: {2}, Балл по истории: {3}, Балл по математике: {4}, Балл по русскому языку: {5}, Средний балл: {6:0.0}", fullname, age, height, hP, mP, rP, averagePoint); // создаем шаблон для форматированного вывода

            string interpolOutput = "---Интерполяция строк---";
            string interpolPattern = ($"Имя: {fullname}, Возраст: {age}, Рост: {height}, Балл по истории: {hP}, Балл по математике: {mP}, Балл по русскому языку: {rP}, Средний балл: {averagePoint:0.0}"); // создаем шаблон для вывода с интерполяцией

            Console.SetCursorPosition((Console.WindowWidth / 2) - (output.Length / 2), Console.WindowHeight / 2 - 3); // расположение курсора по центру экрана
            Console.WriteLine(output); // выводим в консоль обычный вывод
            Console.SetCursorPosition((Console.WindowWidth / 2) - (pattern.Length / 2), Console.WindowHeight / 2 - 2); // расположение курсора по центру экрана
            Console.WriteLine(pattern);
            Console.SetCursorPosition((Console.WindowWidth / 2) - (formatOutput.Length / 2), Console.WindowHeight / 2); // расположение курсора по центру экрана
            Console.WriteLine(formatOutput); // выводим в консоль форматированный вывод  
            Console.SetCursorPosition((Console.WindowWidth / 2) - (formatPattern.Length / 2), Console.WindowHeight / 2 + 1); // расположение курсора по центру экрана
            Console.WriteLine(formatPattern);
            Console.SetCursorPosition((Console.WindowWidth / 2) - (interpolOutput.Length / 2), Console.WindowHeight / 2 + 4); // расположение курсора по центру экрана
            Console.WriteLine(interpolOutput); // выводим в консоль вывод с интерполяцией строк
            Console.SetCursorPosition((Console.WindowWidth / 2) - (interpolPattern.Length / 2), Console.WindowHeight / 2 + 5); // расположение курсора по центру экрана
            Console.WriteLine(interpolPattern);
            Console.ReadKey();



        }
    }
}
