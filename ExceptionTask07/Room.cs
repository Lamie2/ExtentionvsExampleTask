using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask07
{
    class Room
    {
        static int _totalCount;
        public Room(string name, double price, int personCapacity)
        {
            this.Name = name;
            this.Price = price;
            this.PersonCapacity = personCapacity;
            _totalCount++;
            _id = _totalCount;

        }

        private int _id;
        public int Id { get => _id; }

        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable = true;
        public string ShowInfo()
        {
            return $"ID: {_id} | Name: {Name} | Price: {Price}  |  PersonCapacity: {PersonCapacity} | " +
                $"IsAvailable: {IsAvailable} ";
        }
        

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
