using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7LetsBuildAHouseAndHideAndFind
{
    class Opponent
    {
        private Location myLocation;
        private Random random;
        public Opponent(Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }
        public void move()
        {
            RoomWithDoor myRoomWithADoor;
            if(myLocation is RoomWithDoor)
            {
                myRoomWithADoor = myLocation as RoomWithDoor; 
                if (random.Next(2) == 1)
                {
                    //go through the door
                    myLocation = myRoomWithADoor.DoorLocation;

                }
            }

            do{
                myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)];
            }while(!(myLocation is IHidingPlace));
        }
        //check
        public bool Check(Location tryLocation){
            if (this.myLocation == tryLocation)
                return true; // found you!
            else
                return false; // Opponent is not there.
        }
    }
}
