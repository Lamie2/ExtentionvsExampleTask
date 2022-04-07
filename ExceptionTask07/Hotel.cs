using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask07
{
    class Hotel
    {
        public string Name { get; set; }
        private Room[] _rooms= new Room[0];
        public Room[] rooms { get => _rooms;  }

        public Exception NullReferanceException { get; private set; }

        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            _rooms[_rooms.Length - 1] = room;
        }
        public void MakeReservation(int? roomId)
        {
            if (roomId==null)
            {
                throw NullReferanceException;
            }
            else
            {
                foreach (var item in _rooms)
                {
                    if (item.Id==roomId)
                    {
                        if (item.IsAvailable == false)
                        {
                            throw new NotAvailableException();
                        }
                        item.IsAvailable = true;
                       
                    }
                   
                }
            }
        }

    }
}
