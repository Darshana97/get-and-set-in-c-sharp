using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_and_set
{
    class Students
    {
        private int _Id;
        private string _Name;
        private int _PassMark = 35;

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id cannot be negative");
                }
                this._Id = value;
            }
            get
            {
                return this._Id;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._Name = value;

            }
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No name" : this._Name;
            }
        }

        public int PassMark
        {
            get
            {
                return this._PassMark;
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Students S1 = new Students();
            S1.Name = "Darshana";
            S1.Id = 1;
            

            Console.WriteLine("My name is {0}",S1.Name);
            Console.WriteLine("My id is {0}",S1.Id);
            Console.WriteLine("My pass mark is {0}",S1.PassMark);
            Console.ReadLine();


        }
    }
}
