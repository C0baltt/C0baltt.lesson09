using System;
using System.Runtime.InteropServices;

namespace C0baltt.lesson09
{
    public class Person
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть пустым");
            }
            _name = name;
        }
    }
}
