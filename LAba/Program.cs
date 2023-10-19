using labatymproj7;
using System;

namespace labatymproj7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tasksEnd = false;
            string taskNumber;

            do
            {
                Console.WriteLine("{0, 81}", "ТУМАКОВ - ЛАБОРАТОРНАЯ РАБОТА №7. МЕНЮ ЗАДАНИЙ\n");
                Console.WriteLine("Подсказка:\n" +
                                  "Упражнение 7.1. Программа создает класс счета в банке, его экземпляр и выводит информацию на экран          -   цифра 1\n" +
                                  "Упражнение 7.2. Программа из Упражнения 7.1, но добавлена программная генерация номера счета                -   цифра 2\n" +
                                  "Упражнение 7.3. Программа из Упражнения 7.2, но добавлены методы пополнения/снятия                          -   цифра 3\n" +
                                  "Домашнее задание 7.1. Программа создает класс описания здания, его экземпляр и выводит информацию на экран  -   цифра 4\n" +
                                  "Закончить выполнение заданий и выйти из программы                                                           -   цифра 0\n");

                Console.Write("Введите номер задания: ");
                taskNumber = Console.ReadLine();

                switch (taskNumber)
                {
                    case "1":
                        // Упражнение 7.1. Программа создает класс счета в банке, его экземпляр и выводит информацию на экран.
                        Console.Clear();
                        Console.WriteLine("{0, 110}", "УПРАЖНЕНИЕ 7.1. ПРОГРАММА СОЗДАЕТ КЛАСС СЧЕТА В БАНКЕ, ЕГО ЭКЗЕМПЛЯР И ВЫВОДИТ ИНФОРМАЦИЮ НА ЭКРАН\n");

                        BankAccount1 firstBankAccount = new BankAccount1(523, 1000000, BankAccount1.AccountType.Текущий_счет);

                        firstBankAccount.AccountNumber = 678;
                        firstBankAccount.AccountBalance = 900000;
                        firstBankAccount.BankAccountType = BankAccount1.AccountType.Сберегательный_счет;

                        Console.WriteLine($"{firstBankAccount.BankAccountType} под номером {firstBankAccount.AccountNumber:D5} содержит {firstBankAccount.AccountBalance:F2} рублей");

                        Console.Write("\nЧтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        // Упражнение 7.2. Программа из Упражнения 7.1, но добавлена программная генерация номера счета.
                        Console.Clear();
                        Console.WriteLine("{0, 102}", "УПРАЖНЕНИЕ 7.2. ПРОГРАММА ИЗ УПРАЖНЕНИЯ 7.1, НО ДОБАВЛЕНА ПРОГРАММНАЯ ГЕНЕРАЦИЯ НОМЕРА СЧЕТА\n");

                        BankAccount2 secondBankAccount = new BankAccount2(1000000, BankAccount2.AccountType.Текущий_счет);
                        BankAccount2 thirdBankAccount = new BankAccount2(1000, BankAccount2.AccountType.Сберегательный_счет);

                        Console.WriteLine($"{secondBankAccount.BankAccountType} под номером {secondBankAccount.AccountNumber:D5} содержит {secondBankAccount.AccountBalance:F2} рублей");
                        Console.WriteLine($"{thirdBankAccount.BankAccountType} под номером {thirdBankAccount.AccountNumber:D5} содержит {thirdBankAccount.AccountBalance:F2} рублей");

                        Console.Write("\nЧтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        // Упражнение 7.3. Программа из Упражнения 7.2, но добавлены методы пополнения/снятия.
                        Console.Clear();
                        Console.WriteLine("{0, 100}", "УПРАЖНЕНИЕ 7.3. ПРОГРАММА ИЗ УПРАЖНЕНИЯ 7.2, НО ДОБАВЛЕНЫ МЕТОДЫ ПОПОЛНЕНИЯ/СНЯТИЯ\n");

                        bool withdrawResult;
                        BankAccount3 fourthBankAccount = new BankAccount3(BankAccount3.AccountType.Сберегательный_счет);

                        Console.WriteLine($"{fourthBankAccount.BankAccountType} под номером {fourthBankAccount.AccountNumber:D5} содержит {fourthBankAccount.AccountBalance:F2} рублей");

                        Console.WriteLine("\nБанковский счет после пополнения:");
                        fourthBankAccount.PutMoneyIntoAccount(10000000);
                        Console.WriteLine($"{fourthBankAccount.BankAccountType} под номером {fourthBankAccount.AccountNumber:D5} содержит {fourthBankAccount.AccountBalance:F2} рублей");

                        Console.WriteLine("\nБанковский счет после снятия:");
                        withdrawResult = fourthBankAccount.WithdrawMoneyFromAccount(5000000);

                        if (!withdrawResult)
                        {
                            Console.WriteLine("Сумма, которую вы хотите снять больше, чем сумма, которая находится на счете!");
                        }

                        Console.WriteLine($"{fourthBankAccount.BankAccountType} под номером {fourthBankAccount.AccountNumber:D5} содержит {fourthBankAccount.AccountBalance:F2} рублей");

                        Console.Write("\nЧтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        // Домашнее задание 7.1. Программа создает класс описания здания, его экземпляр и выводит информацию на экран.
                        Console.Clear();
                        Console.WriteLine("{0, 114}", "ДОМАШНЕЕ ЗАДАНИЕ 7.1. ПРОГРАММА СОЗДАЕТ КЛАСС ОПИСАНИЯ ЗДАНИЯ, ЕГО ЭКЗЕМПЛЯР И ВЫВОДИТ ИНФОРМАЦИЮ НА ЭКРАН\n");

                        Building building = new Building(50, 10, 20, 2);

                        Console.WriteLine($"Здание номер {building.BuildingNumber:D3} высотой {building.BuildingHeight} м имеет {building.NumberOfFloors} этажей, " +
                                          $"{building.NumberOfEntrances} подъезов и {building.NumberOfApartments} квартир\n");

                        Console.WriteLine($"Колличество квартир в одном подъезде равно {building.CalculationNumberOfApartmentsInEntrance()}");
                        Console.WriteLine($"Колличество квартир на одном этаже равно {building.CalculationNumberOfApartmentsOnFloor()}");
                        Console.WriteLine($"Высота одного этажа равна {building.CalculationFloorHeight()}");

                        Console.Write("\nЧтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("{0, 69}", "ВЫ ВЫШЛИ ИЗ ПРОГРАММЫ");
                        tasksEnd = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("{0, 98}", "ТАКОГО ЗАДАНИЯ НЕТ! ДОСТУПНЫЕ ЗАДАНИЯ УКАЗАНЫ В ПОДСКАЗКЕ. ПОВТОРИТЕ ПОПЫТКУ\n");
                        break;
                }
            } while (!tasksEnd);
        }
    }
}