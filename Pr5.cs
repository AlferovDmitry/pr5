using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fullNames = new List<string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("nВведите ФИО (или 'exit' для выхода):");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit") break;

            fullNames.Add(input);

            Console.WriteLine("nВыберите операцию:");
            Console.WriteLine("1) Вытащить фамилию, имя или отчество отдельно.");
            Console.WriteLine("2) Отсортировать ФИО по возрастанию или убыванию.");
            Console.WriteLine("3) Изменить ФИО.");
            Console.WriteLine("4) Очистить список.");
            Console.WriteLine("5) Показать все ФИО.");
            Console.WriteLine("0) Выход.");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ExtractNamePart(fullNames);
                    break;
                case 2:
                    SortFullNames(fullNames);
                    break;
                case 3:
                    ModifyFullName(fullNames);
                    break;
                case 4:
                    ClearFullNames(fullNames);
                    break;
                case 5:
                    DisplayAllNames(fullNames);
                    break;
                case 0:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                    break;
            }
        }
    }

    static void ExtractNamePart(List<string> fullNames)
    {
        Console.WriteLine("Введите индекс ФИО для извлечения (0 - {0}):", fullNames.Count - 1);
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < fullNames.Count)
        {
            string[] parts = fullNames[index].Split(' ');
            Console.WriteLine("Выберите часть: 1) Фамилия 2) Имя 3) Отчество");
            int partChoice = int.Parse(Console.ReadLine());

            if (partChoice == 1)
                Console.WriteLine("Фамилия: " + parts[0]);
            else if (partChoice == 2)
                Console.WriteLine("Имя: " + parts[1]);
            else if (partChoice == 3)
                Console.WriteLine("Отчество: " + parts[2]);
            else
                Console.WriteLine("Неверный выбор.");
        }
        else
        {
            Console.WriteLine("Неверный индекс.");
        }
    }

    static void SortFullNames(List<string> fullNames)
    {
        Console.WriteLine("Выберите сортировку: 1) По возрастанию 2) По убыванию");
        int sortChoice = int.Parse(Console.ReadLine());

        if (sortChoice == 1)
        {
            fullNames.Sort();
            Console.WriteLine("Список отсортирован по возрастанию.");
        }
        else if (sortChoice == 2)
        {
            fullNames.Sort();
            fullNames.Reverse();
            Console.WriteLine("Список отсортирован по убыванию.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    static void ModifyFullName(List<string> fullNames)
    {
        Console.WriteLine("Введите индекс ФИО для изменения (0 - {0}):", fullNames.Count - 1);
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < fullNames.Count)
        {
            Console.WriteLine("Введите новое ФИО:");
            string newFullName = Console.ReadLine();
            fullNames[index] = newFullName;
            Console.WriteLine("ФИО изменено.");
        }
        else
        {
            Console.WriteLine("Неверный индекс.");
        }
    }
    static void ClearFullNames(List<string> fullNames)
    {
        fullNames.Clear();
        Console.WriteLine("Список очищен.");
    }

    static void DisplayAllNames(List<string> fullNames)
    {
        Console.WriteLine("nСписок всех ФИО:");
        for (int i = 0; i < fullNames.Count; i++)
        {
            Console.WriteLine($"{i}: {fullNames[i]}");
        }
    }
}
