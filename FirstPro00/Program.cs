using FirstPro00.PhoneBook;
using System.Text;

namespace FirstPro00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            double x1 = 2.7, x2 = 15.8;
            double y1 = x1 + x2;
            Console.WriteLine($"Hello, {y1}");

            // Проверка даты и времени
            Console.WriteLine(DateTimeDemo.DateTimeNow());

            // проверка стека
            Console.WriteLine(NumberTranslation.TransNumber((int)y1, 2));

            // проверка очереди
            int[] ms = { 11, 3, 41, 52, 63, 71, 89, 10 };
            ReorderingQueue.Reordering(ms);

            // проверка телефонной книгн на списке
            TestPhoneBookList();

            // проверка телефонной книги на словаре
            PhoneBook.PhoneBook phoneBook = new PhoneBook.PhoneBook();
            string phone;
            string str;
            PhoneBook.Contact i;
            while (true)
            {
                switch (Menu())
                {
                    case 1: // вставка новой записи об абоненте
                        Console.WriteLine("--- Добавление абонента ---");
                        Console.Write("Введите имя:");
                        str = Console.ReadLine();
                        if (phoneBook.HasAbonent(str) == true)
                        {
                            Console.WriteLine("Такой абонент уже есть");
                            break;
                        }
                        Console.Write("Введите номер телефона:");
                        phone = Console.ReadLine();
                        phoneBook.PushAbonent(str, phone);
                        break;
                    case 2: // удаление записи по имени абонента
                        Console.WriteLine("--- Удаление абонента -----");
                        Console.Write("Введите имя:");
                        str = Console.ReadLine();
                        phoneBook.DeleteAbonent(str);
                        break;
                    case 3: // поиск телефона заданного абонента
                        Console.WriteLine("---- Поиск абонента -------");
                        Console.Write("Введите имя:");
                        str = Console.ReadLine();
                        if (phoneBook.FindAbonent(str, out i) == false)
                            Console.WriteLine("Абонента не существует");
                        else
                            Console.WriteLine(i);
                        break;
                    case 4: // проверка существования абонента
                        // с заданным именем
                        Console.WriteLine("- Существование абонента -");
                        Console.Write("Введите имя:");
                        str = Console.ReadLine();
                        if (phoneBook.HasAbonent(str) == false)
                            Console.WriteLine("Абонента не существует");
                        else
                            Console.WriteLine("Абонент существует");
                        break;
                    case 5: // печать телефонной книги
                        Console.WriteLine(phoneBook);
                        break;
                    case 6: // выход из приложения
                        return;
                }
            }
        }

        static int Menu()
        {
            int k = 0;
            while (k <= 0 || k > 6)
            {
                Console.WriteLine("----------- Меню ------------");
                Console.WriteLine("Добавить абонента - 1,\n" +
                    "Удалить абонента - 2,\n" +
                    "Найти абонента - 3,\n" +
                    "Проверка существования абонента - 4,\n" +
                    "Печать телефонной книжки - 5,\n" +
                    "Выход - 6");
                Console.WriteLine("Введите команду:");
                k = int.Parse(Console.ReadLine());
            }
            return k;
        }


        static void TestPhoneBookList()
        {
            Console.WriteLine("Hello from the Console PhoneBook app");
            Console.WriteLine("Select operation");
            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 View all contacts");
            Console.WriteLine("4 Search for contacts for a given name");
            Console.WriteLine("Press 'x' to exit");
            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook.PhoneBookList();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact name:");
                        var name = Console.ReadLine();

                        Console.WriteLine("Contact number:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine("Contact number to search");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                        break;
                    case "3":
                        phoneBook.DisplayAllContact();
                        break;
                    case "4":
                        Console.WriteLine("Name search phrase");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;
                }

                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
        
    }
}
}
