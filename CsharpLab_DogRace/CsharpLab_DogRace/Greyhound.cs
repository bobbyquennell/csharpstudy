using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CsharpLab_DogRace
{
    class Greyhound
    {
        public int StartinPositon;// where my picturebox starts
        public int RacetrackLength;// how long the racetrack is 
        public PictureBox MyPictureBox = null;// My picturebox object
        public int Location = 0;// my location on the racetrack
        public Random Randomizer;// an instance of Random
        // Only need one instance of  Random-- each Greyhound's Randomizer reference should
        //point to the same Random object.
        public bool Run()
        {
            //move forward either 1,2,3 or 4 spaces at random
            Location += Randomizer.Next(1, 4);
            //Update the position of my PictureBox on the form
            // Return true if I won the race
        }
        public void TakeStartingPosition()
        {
            // Reset my location to the start line
            Location = 0;
        }

    }
}
