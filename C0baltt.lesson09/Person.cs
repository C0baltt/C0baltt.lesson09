using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace C0baltt.lesson09
{
    public class Person//объявляем класс Person
    {
        public string LastName { get; set; } //задаем функции get и set для LastName (вся необходимая=>
                                             //=>настройка будет сделана средой автоматически)
        public string FirstName { get; set; }//задаем функции get и set для FirstName (вся необходимая=>
                                             //=>настройка будет сделана средой автоматически)

        public string FullName//полное имя=>
        {
            get
            {
                return LastName + " " + FirstName;//=>возвращает строку вида "фамилия пробел имя"
            }
        }
        public string ShortName//=>возвращает строку вида "фамилия пробел и."
        {
            get
            {
                return $"{LastName} {FirstName.Substring(0, 1)}.";//Name.Substring(0,1) извлекает подстроку данного=>
                                                               //=> экземпляра, подстрока начинается с данного знака, и длится указанное количество символов=>
                                                               //=>(0, 1) 0 - означает первый символ, 1 - длина =>
                                                               //=>строки, - один символ;=>
                                                               //=>$ - включает интерполяцию строк - она итерпретирует=>
                                                               //=> содержимое внутри "{}", как переменную, а не как текст
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