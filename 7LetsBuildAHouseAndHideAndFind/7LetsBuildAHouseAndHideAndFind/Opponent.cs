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
            //RoomWithDoor myRoomWithADoor;
            if(myLocation is IHasExteriorDoor)
            {
                IHasExteriorDoor myPlaceWithADoor = myLocation as IHasExteriorDoor; 
                if (random.Next(2) == 1)
                {
                    //go through the door
                    myLocation = myPlaceWithADoor.DoorLocation;

                }
            }

            do
            {
                myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)];
            } while (!(myLocation is IHidingPlace));

            //bool hidden = false;
            //while (!hidden)
            //{
            //    int rand = random.Next(myLocation.Exits.Length);
            //    myLocation = myLocation.Exits[rand];
            //    if (myLocation is IHidingPlace)
            //        hidden = true;
            //}
        }
        //check
        public bool Check(Location tryLocation){
            if (this.myLocation == tryLocation)
                return true; // found you!
            else
                return false; // Opponent is not there.
        }
        public void ResetOpponent(Location resetLocation) {

            myLocation = resetLocation;
            random = new Random();
        }
    }
}
