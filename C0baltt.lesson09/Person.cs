using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace C0baltt.lesson09
{
    public class Person
    {
        public string SecondName { get; private set; }
        private string Name { get; set; }

        public string FullName
        {
            get
            {
                return SecondName + " " + Name;
            }
        }
        public string ShortName
        {
            get
            {
                return $"{SecondName} {Name.Substring(0, 1)}.";//Name.Substring(0,1) извлекает подстроку данного=>
                                                               //=> экземпляра, подстрока начинается с данного знака, и длится указанное количество символов=>
                                                               //=>(0, 1) 0 - означает первый символ, 1 - длина =>
                                                               //=>строки, - один символ;=>
                                                               //=>$ - включает интерполяцию строк - она итерпретирует=>
                                                               //=> содержимое внутри {}, как переменную, а не как текст
            }
        }
    }
}
/* 
  public class Person
    {
        public string SecondName { get; private set; }// равнозначно всему, что написано ниже

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

           
              public string GetName() это выражение равнозначно верхнему, но верхнее применять правльнее
        {
            return _name;
        }

            

set
{
    _name = value;
}
            /*
             public void SetName(string name) это выражение равнозначно верхнему, но верхнее применять правльнее
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть пустым");
            }
            _name = name;
        }
             
        }



    }
 */