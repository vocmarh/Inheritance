using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Ленина,29",100,30,50);
            building.Print();

            MultiBuilding multiBuilding = new MultiBuilding("Ленина,29", 100, 30, 50, 20);
            multiBuilding.Print();

            Console.ReadKey();
        }
    }

    class Building
    {
        public string Address { get; set; }
        public double L { get; set; }
        public double W { get; set; }
        public double H { get; set; }
        public Building()
        {

        }
        public Building(string address, double l, double w, double h)
        {
            Address = address;
            L = l;
            W = w;
            H = h;
        }
        public void Print()
        {
            Console.WriteLine($"Адрес здания: {Address}, длина здания {L} м, высота здания {H} м, ширина здания {W} м");
        }        
    }
    sealed class MultiBuilding: Building
    {
        public double Level { get; set; }
        public MultiBuilding(string address, double l, double w, double h, double level)
       
        {
            Address = address;
            L = l;
            W = w;
            H = h;
            Level = level;
        }
        public void Print()
        {
            Console.WriteLine($"Адрес здания: {Address}, длина здания {L} м, высота здания {H} м, ширина здания {W} м, количество этажей: {Level}");
        }

    }
}
