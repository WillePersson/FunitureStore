using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace FunitureStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> furnitures = new List<Furniture>();
            TableLamp tablelamp1 = new TableLamp("Table lamp Vera", 29.5, 60, "e27", 1130005, "watt & veke", 2199.00, "Nature", "Ash/Linne");
            furnitures.Add(tablelamp1); 
            TableLamp tablelamp2 = new TableLamp("Table lamp Klara", 75.0, 60, "e14", 1130006, "byRyden", 1699.00, "White", "Cotton");
            furnitures.Add(tablelamp2);

            CoffeeTable coffeetable1 = new CoffeeTable("Coffee table Rune", 3,"Round", 2250002, "Rowico", 4149.90, "Brown", "Oak");
            furnitures.Add(coffeetable1);
            CoffeeTable coffeetable2 = new CoffeeTable("Coffee table Sten", 4, "Square", 2250003, "Pastill", 5799.99, "Grey/Black", "Stone/Steel");
            furnitures.Add(coffeetable2);

            foreach (Furniture furniture in furnitures)
            {
                furniture.PrintInfo();
                Console.WriteLine();
            }
        }
    }
    abstract class Furniture
    {
        public string _productName;
        public string _material;
        public string _color;
        public double _price;
        public string _brand;
        public int _itemNumber;

        public Furniture( string productName, int itemNumber, string brand, double price, string color, string material)
        {
            _productName = productName;
            _material = material;
            _color = color;
            _price = price;
            _brand = brand;
            _itemNumber = itemNumber;
        }
        public abstract void PrintInfo();
            
    }
    class Lamps : Furniture
    {
        public string _lightSource;
        public int _maxWatt;

        public Lamps(string productName, int maxWatt, string lightSource, int itemNumber, string brand, double price, string color, string material)
            : base(productName, itemNumber, brand, price, color, material)
        {
            _lightSource = lightSource;
            _maxWatt = maxWatt;
        }
        public override void PrintInfo()
        {
            
        }
    }
    class TableLamp : Lamps
    {
        public double _hight;

        public TableLamp(string productName, double hight, int maxWatt, string lightSource, int itemNumber, string brand, double price, string color, string material) 
            :base(productName, maxWatt, lightSource, itemNumber, brand, price, color, material)
        {
            _hight = hight;
        }
        public override void PrintInfo()
        {
            Console.WriteLine(_productName + 
                $"\n{_price} sek");
            Console.WriteLine($"Hight: {_hight}" +
                $"\nMaxwatt: {_maxWatt}" +
                $"\nLightsource: {_lightSource}" +
                $"\nItemnumber: {_itemNumber}" +
                $"\nBrand: {_brand}" +
                $"\nColor: {_color}" +
                $"\nMaterial: {_material}");

        }
    }
    class Table : Furniture
    {
        public int _numbersOfLegs;

        public Table(string productName, int numbersOfLegs, int itemNumber, string brand, double price, string color, string material)
            : base( productName ,itemNumber, brand, price, color, material)
        {
            _numbersOfLegs = numbersOfLegs;
        }
        public override void PrintInfo()
        {

        }
    }
    class CoffeeTable : Table
    {
        public string _shape;

        public CoffeeTable(string productName, int numbersOfLegs, string shape, int itemNumber, string brand, double price, string color, string material)
            : base(productName, numbersOfLegs, itemNumber, brand, price, color, material)
        {
            _shape = shape;
        }
        public override void PrintInfo()
        {
            Console.WriteLine(_productName +
               $"\n{_price} sek");
            Console.WriteLine($"Number of legs: {_numbersOfLegs}" +
                $"\nShape: {_shape}" +
                $"\nItemnumber: {_itemNumber}" +
                $"\nBrand: {_brand}" +
                $"\nColor: {_color}" +
                $"\nMaterial: {_material}");
        }
    }
}