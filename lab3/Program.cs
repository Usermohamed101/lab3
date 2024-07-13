using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    #region class1
    //class student
    //{
    //    int id;
    //    int age;
    //    string name;

    //    public void setData(int Id,int Age,string Name)
    //    {
    //        id = Id;
    //        age = Age;
    //        name = Name;
    //    }
    //    public void getData()
    //    {
    //        Console.WriteLine($"name: {name} \nage: {age} \nid: {id} ");
    //    }

    //    public string graduated()
    //    {
    //        if (age >23)
    //            return "graduated";
    //        return "not graduated yet";
    //    }


    //}
    #endregion

    #region class2
    class student
    {
        int id;
        int age;
        string name;

        public student() { }
        public student(int Id, int Age, string Name) {

            id = Id;
            age = Age;
            name = Name;
        }
        static student()
        {
            Console.WriteLine("instanse is done successfully");
        }
        public void getData()
        {
            Console.WriteLine($"name: {name} \nage: {age} \nid: {id} ");
        }

        public string graduated()
        {
            if (age > 23)
                return "graduated";
            return "not graduated yet";
        }


    }
    #endregion

    #region book
    class book
    {
        static int count = 0;
        int    id;
        string name;
        string createdOn;
        string price;
        string type;
        bool  isDeleted;
        public book(int id, string name, string createdOn, string price, string type, bool isDeleted) {
            this.id = id;
            this.name = name;
            this.createdOn = createdOn;
            this.price = price;
            this.type = type;
            this.isDeleted = isDeleted;

            count++;
        }
        public book(int id, string name, string createdOn, string price, string type)
        {
            this.id = id;
            this.name = name;
            this.createdOn = createdOn;
            this.price = price;
            this.type = type;
            

            count++;
        }
        public book(int id, string name)
        {
            this.id = id;
            this.name = name;
          

            count++;
        }
        static book()
        {
            Console.WriteLine("this is books section");
        }
        public string deleted()
        {
            if (isDeleted)
            {
                return "deleted";
            }
            return "not deleted";
        }

        public void getData()
        {
            Console.WriteLine($" id:{id}-- name:{name}-- createdOn:{createdOn}-- price:{price}" +
                $" type:{type}-- isDeleted:{isDeleted}");

        }
        public static void booksBought()
        {
            Console.WriteLine($"the count of boks bought is {count}");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {

            #region student
            //student std1 = new student(1,25,"mohamed");
            //student std2 = new student(2,35,"ahmed");
            //student std3 = new student(3,45,"ibrahim");

            //std1.getData();
            //std2.getData();
            //std3.getData();
            //Console.WriteLine(std1.graduated());
            #endregion

            #region book
            book b1 = new book(1, "dark matter", "7th october 2024 ", "200$", "mystery", false);
            book b2 = new book(1, "atomic habbits", "10th june 2024 ", "250$", "self-development", false);
            book b3 = new book(1, "master c#", "7th junaury 2024 ", "150$", "mystery", true);
            book b4 = new book(1, "master js", "18th march 2024 ", "280$", "mystery", true);

            Console.WriteLine(b1.deleted());
            b2.getData();

           
            book.booksBought();
            #endregion

            Console.ReadKey();
        }
    }
}
