using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPro00.PhoneBook
{
    /// <summary>
    /// Класс содержит словарь, в котором буквам соответствуют списки записей об абонентах, 
    /// чьи имена начинаются с этой буквы
    /// </summary>
    internal class PhoneBook
    {
        // хэш-таблица записей об абонентах
        Dictionary<char, List<Contact>> book;
        // конструктор хэш-таблицы
        public PhoneBook()
        {
            book = new Dictionary<char, List<Contact>>();
            // создание списка (группы абонентов) для каждой буквы
            for (char c = 'А'; c <= 'Я'; c++)
                book.Add(c, new List<Contact>());
        }
        // метод добавления новой записи об абоненте
        public void PushAbonent(string abonent, string phone)
        {
            // ключ группы соответствует первой букве в имени абонента
            // буква задана в верхнем регистре
            char key = Char.ToUpper(abonent[0]);
            // добавление записи c информацией об абоненте (объект Contact)
            // в группу с ключом key
            book[key].Add(new Contact(abonent.ToUpper(), phone));
        }
        // метод поиска записи по имени абонента
        // информация об абоненте возвращается через out-параметр info
        public bool FindAbonent(string abonent, out Contact info)
        {
            // ключ группы соответствует первой букве в имени абонента
            char key = Char.ToUpper(abonent[0]);
            // возвращаем true, если абонент найден в группе key,
            // false – в противном случае
            abonent = abonent.ToUpper();
            for (int i = 0; i < book[key].Count; i++)
                if (book[key][i].Name == abonent)
                {
                    info = book[key][i];
                    return true;
                }
            info = null;
            return false;
        }

        // метод удаления из списка записи по имени абонента
        public void DeleteAbonent(string abonent)
        {
            // ключ группы соответствует первой букве в имени абонента
            char key = Char.ToUpper(abonent[0]);
            // поиск записи c информацией об абоненте
            // и удаление его из списка с ключом key
            Contact info;
            if (FindAbonent(abonent, out info))
                book[key].Remove(info);
        }

        // метод проверки наличия в хэш-таблице заданного имени абонента
        public bool HasAbonent(string abonent)
        {
            Contact info;
            return FindAbonent(abonent, out info);
        }

        // Печать телефонной книги выполняетсмя с помощью операции получения
        // строкового представления списка записей книги:
        static public implicit operator string(PhoneBook ob)
        {
            string res = "Телефонная книга\n\n";
            // перебор всех ключей телефонной книги
            foreach (char c in ob.book.Keys)
                // если в группе, соответствующей ключу, есть записи,
                // выводим их в строку-результат
            if (ob.book[c].Count != 0)
            {
                // печать буквы-ключа
                res = res + c + ":\n";
                // печать всех записей из списка группы
                for (int i = 0; i < ob.book[c].Count; i++)
                    res = res + "\t" + ob.book[c][i] + "\n";
                res = res + "\n";
            }
            return res;
        }
    }
}
