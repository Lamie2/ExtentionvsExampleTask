using System;

namespace ExceptionTask07
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("Single", 300, 1);
            room1.IsAvailable = true;

            Room room2 = new Room("Double", 700, 2);
            room2.IsAvailable = false;

            Hotel hotel = new Hotel();

            hotel.AddRoom(room1);
            hotel.AddRoom(room2);

            hotel.MakeReservation(1);
            

            
        }
    }
}
