using System;
using System.Collections.Generic;

namespace Question06
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHouse = new Building()
                    .AddKitchen()
                    .AddBedroom(" master ")
                    .AddBedroom(" guest ")
                    .AddBalcony();
            myHouse.Build();

           
            //kitchen, master room, guest room, balcony
            Console.WriteLine(myHouse.Describe());
            myHouse.AddKitchen().AddBedroom(" another ");
            //before build the house description still is as before
            //kitchen, master room, guest room, balcony
            Console.WriteLine(myHouse.Describe());
            myHouse.Build();
            //it only shows the kitchen after build
            //kitchen, master room, guest room, balcony, kitchen, another room
            Console.WriteLine(myHouse.Describe());
            Console.ReadLine();
        }
    }

    public class Building
    {
        private List<string> _parts;
        private List<Action> _operations;
        public Building()
        {
            _parts = new List<string>();
            _operations = new List<Action>();
        }

        public Building AddKitchen()
        {
            _operations.Add(() => ActionAddKitchen());
            return this;
        }

        public Building AddBalcony()
        {
            _operations.Add(() => ActionAddBalcony());
            return this;
        }

        public Building AddBedroom(string name)
        {
            _operations.Add(() => ActionAddBedroom(name));
            return this;
        }
        public Building Build()
        {
            if(_operations.Count > 0)
            {
                
                foreach (var operation in _operations)
                    operation();
                _operations.Clear();
            }
            return this;
        }
       
        public string Describe()
        {
           
            return String.Join(',',_parts);
        }
        private void ActionAddKitchen() { _parts.Add("kitchen"); }
        private void ActionAddBalcony() { _parts.Add("balcony"); }
        private void ActionAddBedroom(string name) { _parts.Add($"{name} room"); }
    }
}
