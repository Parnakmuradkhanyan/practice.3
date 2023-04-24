/*Мурадханян Парнак ФІТ 1-5 ІПЗ*/
/*Практичне завдання №6*/
/*Перерахування*/
/*Варіант 4*/
/*Створити перерахування з прапорцем, у якому зберігаються назви 9 товарів, які
  відносяться до товарних груп: побутова техніка, оргтехніка, комп’ютери і 
  комплектуючі. Вивести перелік товарів, застосовуючи константи (номер – назва).
  Дати можливість користувачеві ввести номери товарів, які він хотів би придбати, у
  вигляді списку, відокремлюючи номери комами. Вивести прізвище автора програми, переліки товарів окремо по
  кожній групі.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductGroups
{
    class Program
    {
        enum ProductGroup
        {
            HomeAppliances,
            OfficeEquipment,
            ComputersAndParts
        }

        enum Products
        {
            No,
            Fridge,
            WashingMachine,
            Microwave,
            Printer,
            Scanner,
            FaxMachine,
            DesktopPC,
            Laptop,
            GraphicsCard,
        }

        static void Variant_14()
        {
            const string homeAppliances1 = "Холодильник";
            const string homeAppliances2 = "Пральна машина";
            const string homeAppliances3 = "Мікрохвильова піч";

            const string officeEquipment1 = "Принтер";
            const string officeEquipment2 = "Сканер";
            const string officeEquipment3 = "Факс";

            const string computersAndParts1 = "Стаціонарний комп'ютер";
            const string computersAndParts2 = "Ноутбук";
            const string computersAndParts3 = "Відеокарта";

            Console.WriteLine();
            Console.Beep();
            Console.WriteLine("Продкути: ");
            Console.WriteLine();
            Console.WriteLine($"{(int)Products.Fridge} - Холодильник");
            Console.WriteLine($"{(int)Products.WashingMachine} - Пральна машина");
            Console.WriteLine($"{(int)Products.Microwave} - Мікрохвильова піч");

            Console.WriteLine($"{(int)Products.Printer} - Принтер");
            Console.WriteLine($"{(int)Products.Scanner} - Сканер");
            Console.WriteLine($"{(int)Products.FaxMachine} - Факс");

            Console.WriteLine($"{(int)Products.DesktopPC} - Стаціонарний комп'ютер");
            Console.WriteLine($"{(int)Products.Laptop} - Ноутбук");
            Console.WriteLine($"{(int)Products.GraphicsCard} - Відеокарта");

            Console.WriteLine();

            Console.WriteLine("Оберіть номери продуктів які бажаєте прдбати, (розділіть комами якщо більше одного продукту):");
            Console.WriteLine();
            string input = Console.ReadLine();
            string[] productNumbers = input.Split(',');
            Console.WriteLine();
            Console.WriteLine("Обрані продукти:");
            Console.WriteLine();
            foreach (string productNumber in productNumbers)
            {
                if (int.TryParse(productNumber, out int number))
                {
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine($"- {homeAppliances1}");
                            break;
                        case 2:
                            Console.WriteLine($"- {homeAppliances2}");
                            break;
                        case 3:
                            Console.WriteLine($"- {homeAppliances3}");
                            break;
                        case 4:
                            Console.WriteLine($"- {officeEquipment1}");
                            break;
                        case 5:
                            Console.WriteLine($"- {officeEquipment2}");
                            break;
                        case 6:
                            Console.WriteLine($"- {officeEquipment3}");
                            break;
                        case 7:
                            Console.WriteLine($"- {computersAndParts1}");
                            break;
                        case 8:
                            Console.WriteLine($"- {computersAndParts2}");
                            break;
                        case 9:
                            Console.WriteLine($"- {computersAndParts3}");
                            break;
                        default:
                            Console.WriteLine($"- Не дійсний номер продукту: {number}");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"- Не правильне введення: {productNumber}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Товарні групи:");
            Console.WriteLine();
            Console.WriteLine("Побутова техніка:");
            Console.WriteLine();
            Console.WriteLine($"- {homeAppliances1}");
            Console.WriteLine($"- {homeAppliances2}");
            Console.WriteLine($"- {homeAppliances3}");
            Console.WriteLine();
            Console.WriteLine("Оргтехніка:");
            Console.WriteLine();
            Console.WriteLine($"- {officeEquipment1}");
            Console.WriteLine($"- {officeEquipment2}");
            Console.WriteLine($"- {officeEquipment3}");
            Console.WriteLine();
            Console.WriteLine("Комп'ютери та комплектуючі:");
            Console.WriteLine();
            Console.WriteLine($"- {computersAndParts1}");
            Console.WriteLine($"- {computersAndParts2}");
            Console.WriteLine($"- {computersAndParts3}");

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Beep();
            Console.WriteLine("Практична робота № 6 Мурадханян Парнак ФІТ 1-5 ІПЗ");
            Console.WriteLine("Перерахування");
            Console.WriteLine("Варіант 4");
            bool loopContinue = true;

            while (loopContinue == true)
            {
                Console.Beep();
                Console.WriteLine();
                Console.WriteLine("Чи бажаєте ви подивитсиь вправу, скажіть 'Yes' - Так або 'No' - Ні: ");
                Console.WriteLine();
                string userResponse = Console.ReadLine();

                switch (userResponse)
                {
                    case "Yes":
                        Console.Beep();
                        Variant_14();
                        break;

                    case "No":
                        Console.WriteLine();
                        Console.WriteLine("Допобачення");
                        Console.Beep();
                        System.Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Не зрозуміла відповідь");
                        Console.Beep();
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}