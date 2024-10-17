using System;

namespace AK7
{
    public class clsahmed
    {
        private string _name, _address;
        private double _mark;

        public clsahmed()
        {

        }

        public clsahmed (string name,string address,double mark)
        {
            _name = name;
            _address = address;
            _mark = mark;
        }


        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        public double Mark
        {
            set { _mark = value; }
            get { return _mark; }
        }


        public void print()
        {
            Console.WriteLine("Name    : " + _name);
            Console.WriteLine("Address : " + _address);
            Console.WriteLine("Mark    : " + _mark);
        }

    }

    internal class Program
    {


        static void Main(string[] args)
        {

            clsahmed ahmed1 = new clsahmed("Ahmed", "Baghdad", 50);
            ahmed1.print();

            Console.WriteLine("================================");

            clsahmed ahmed2 = new clsahmed();
            ahmed2.Name = "Ahmed";
            ahmed2.Address = "Baghdad";
            ahmed2.Mark = 69;
            ahmed2.print();

            Console.WriteLine("================================");

            Console.WriteLine("Enter the name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the address : ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter the mark : ");
            double mark = double.Parse(Console.ReadLine());

            clsahmed ahmed3 = new clsahmed(name, address, mark);

            Console.WriteLine("================================");

            ahmed3.print();





            Console.ReadKey();

        }
    }
}



