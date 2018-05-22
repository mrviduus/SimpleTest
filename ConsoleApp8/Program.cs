using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
  abstract class Pet//Объявляем абстракный класс от которого наследуется Cat, Dog
  {
    public string Name { get; set; }//Обязательное поле для всех наследуемых классов
    public string Breed { get; set; }//Обязательное поле для всех наследуемых классов

    public void Introduce()//Метод, представления
    {
      Console.WriteLine("I'm {0} of {1}.I'm a {2}", Name, Breed, GetType().Name);//Выводим имя, породу, и класс к которому относиться объект
    }
  }
  class PetShop
  {
    List<Pet> pets = new List<Pet>();//Создаем список данных класса Pet

    public void Add(Pet animal )//метод добавления абстрактноого класса, объявление animal так как Pet невозможно использовать 
    {
      pets.Add(animal);// Добавляем в коллекцию Pet animal
    }

    public void IntroduceAll()// Объявляем метод представления всех существующих объектов в List
    {
      foreach (var p in pets)// проходимся в цикле по списку и записываем все в p
        p.Introduce(); //выводим данные
    }
  }
  class Dog : Pet //Объявляем новый класс Dog наследуемый от Pet
  {
    public Dog(string n, string b) : base()// Создаем конструктор принимающий параметры из наследуемого класса
    {
      Name = n;
      Breed = b;
    }

  }
  class Cat : Pet
  {
    public Cat(string n, string b) : base()
    {
      Name = n;
      Breed = b;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {

      PetShop petshop = new PetShop();
      petshop.Add(new Dog("Rex", "Rex"));
      petshop.Add(new Cat("Mura", "Lucy"));
      petshop.Add(new Dog("Dick", "Jef"));
      petshop.IntroduceAll();
      Console.ReadLine();
    }
  }
}
