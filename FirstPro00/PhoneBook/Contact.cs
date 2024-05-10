using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPro00.PhoneBook
{
    internal class Contact
    {
        public string Name { get; }
        public string Number { get; }  
        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }

        // получение строкового представления контакта
        public override string ToString() => 
            $"\nИмя абонента: {Name},\nНомер абонента: {Number}\n";

    }
}
