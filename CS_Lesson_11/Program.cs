using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.InteropServices;

namespace CS_Lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lesson();
            Task_1();
            

        }

        public static void Task_2()
        {
            /*
             Требуется написать C#-код, используя LINQ и XML, для выполнения следующих задач:
            Вывести все названия книг, отсортированные по названию в алфавитном порядке.
            Посчитать количество книг каждого жанра.
            Получить список авторов, у которых есть книги с годом издания до 1900
            Получить список авторов у которых не менее 2х книг в списке
            Посчитать количество книг в названиях которых больше одного слова и получить данные об этих книгах
            Получить имена авторов и книг, которые были написаны между 1940 и 2000 годами.
             файл в  папке Компьютер DESKTOP-VGCIKT7 на ysndex disk
             */




        }

        public static void Task_1() // задача про поезда
        {
            /*
             Создайте структуру «Поезд» с полями: номер поезда, пункт отправления, 
            пункт назначения, время отправления и время прибытия. Добавьте свойство 
            Info, выводящее информацию о поезде. Добавьте метод, получающий в качестве 
            параметра фактическое время прибытия поезда и сравнивающий его с временем, 
            указанным в экземпляре структуры. Из метода верните сообщение: «Поезд опоздал 
            на (указать время) минут» или «Поезд пришел вовремя».
            Создайте список (List) для хранения объектов структуры «Поезд». Заполните 
            данный список пятью экземплярами. Реализуйте добавление нового экземпляра 
            структуры (введенного с клавиатуры) в список. 
            Отсортируйте список по пункту отправления (в порядке возрастания). 
            Реализуйте поиск и удаление экземпляра структуры из списка по введённому 
            номеру поезда.
             */
            List<Train> trains = new List<Train>()
            {
                new Train(1, "Москва", new Time(12, 30), "27 октября 2023"),
                new Train(2, "Екатеринбург", new Time(12, 35), "27 октября 2023"),
                new Train(3, "Казань", new Time(12, 57), "27 октября 2023"),
                new Train(4, "Новосибирск", new Time(12, 20), "27 октября 2023"),
                new Train(5, "Пермь", new Time(12, 00), "27 октября 2023"),
                new Train(6, "Улан-Уде", new Time(11, 23), "27 октября 2023"),
                new Train(7, "Владивосток", new Time(10, 30), "27 октября 2023")
            };
            int choice = 0;
            do
            {
                do
                {
                    Console.WriteLine("Выберите пункт меню:");
                    Console.WriteLine("1. Добавление поезда.");
                    Console.WriteLine("2. Поиск поезда по номеру.");
                    Console.WriteLine("3. Удаление поезда.");
                    Console.WriteLine("4. Сортировка списка поездов.");
                    Console.WriteLine("5. Выход.");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                } while (choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5);

                if (choice == 5)
                {
                    break;
                }
                else if (choice == 1)
                {
                    int number = 0;
                    int hour = 0;
                    int minute = 0;
                    string date;
                    string departurePoint;
                    try
                    {
                        Console.WriteLine("Введите номер поезда: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите пункт прибытия: ");
                        departurePoint = Console.ReadLine();
                        Console.WriteLine("Введите час прибытия: ");
                        hour = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите минуту прибытия: ");
                        minute = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите дату прибытия: ");
                        date = Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        String errorMessage = ex.Message;
                        Console.WriteLine(errorMessage);
                        continue;
                    }
                    Train train = new Train(number, departurePoint, new Time(hour, minute), date);
                    trains.Add(train);
                    train.Info();
                    Console.WriteLine("Поезд добавлен");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == 2)
                {
                    int number = 0;
                    try
                    {
                        Console.WriteLine("Введите номер поезда: ");
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        String errorMessage = ex.Message;
                        Console.WriteLine(errorMessage);
                        continue;
                    }
                    var selectedTrains = trains.FirstOrDefault(t => t.Number == number);
                    if (selectedTrains.Equals(null))
                    {
                        Console.WriteLine("Поезд не найден");
                    }
                    else
                    {
                        selectedTrains.Info();
                    }

                }
                else if (choice == 3)
                {
                    int number = 0;
                    try
                    {
                        foreach (var t in trains)
                        {
                            t.Info();
                        }
                        Console.WriteLine("Введите номер поезда: ");
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        String errorMessage = ex.Message;
                        Console.WriteLine(errorMessage);
                        continue;
                    }
                    var selectedTrains = trains.FirstOrDefault(t => t.Number == number);
                    if (selectedTrains.DeparturePoint == null)
                    {
                        Console.WriteLine("Поезд не найден");
                    }
                    else
                    {
                        trains.Remove(selectedTrains);
                        Console.WriteLine("Поезд удалён");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == 4)
                {
                    var selectedTrains = trains.OrderBy(t => t.DeparturePoint);
                    foreach (var t in selectedTrains)
                    {
                        t.Info();
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else { continue; }

            } while (true);
        }

        public static void Lesson()
        {
            List<Student> students = new List<Student>()
            {
                new Student{Name = "Jonn", Age = 20, GPA = 4.6 },
                new Student{Name = "Chendler", Age = 21, GPA = 4.0 },
                new Student{Name = "Joe", Age = 22, GPA = 3.9 },
                new Student{Name = "Fibi", Age = 22, GPA = 4.5 },
                new Student{Name = "Rachel", Age = 20, GPA = 4.3 },
                new Student{Name = "Ganter", Age = 19, GPA = 4.2 },
                new Student{Name = "Ross", Age = 18, GPA = 4.1 },
            };

            var selectedStudent = students.Where(s => s.GPA > 4.2 && s.Age < 25).Select(s => s.Name);

            foreach(var studentName in selectedStudent)
            {
                Console.WriteLine(studentName);
            }



        }
    }
}
