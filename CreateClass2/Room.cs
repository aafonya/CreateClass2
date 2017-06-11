using System;

namespace CreateClass2
{
    class Room
    {
        public int RoomNumber { get; private set; }

        private static int roomCounter;

        public Room()
        {
            RoomNumber = roomCounter++;
        }

        public override string ToString()
        {
            return string.Format("This instance of my object has the following:" +
                " RoomNumber = {0} ", RoomNumber);
        }
    }
}
