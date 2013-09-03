using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7LetsBuildAHouse
{
    public partial class Form1 : Form
    {
        Outside garden;
        OutsideWithDoor FrontYard, BackYard;
        RoomWithDoor LivingRoom, Kitchen;
        Room DiningRoom;
        private void CreateObjects()
        {
             DiningRoom = new Room("Dining Room", "flowers");
             LivingRoom = new RoomWithDoor("Living room", "an antique carpet", "an oak door with a brass knob");
             Kitchen = new RoomWithDoor("Kitchen", "Big Kitchen", "a screen door");
             FrontYard = new OutsideWithDoor("FrontYard", false, "an oak door with a brass knob");
             BackYard = new OutsideWithDoor("BackYard", true, "a screen door");
             garden = new Outside("name", false);

             garden.Exits = new Location[] { FrontYard, BackYard };
             DiningRoom.Exits = new Location[] { Kitchen, LivingRoom };
             LivingRoom.Exits = new Location[] { DiningRoom };
             Kitchen.Exits = new Location[] { DiningRoom };

        }
        public Form1()
        {
            InitializeComponent();

            CreateObjects();

        }

        private void Gohere_Click(object sender, EventArgs e)
        {

        }

        private void GoThroughTheDoor_Click(object sender, EventArgs e)
        {

        }
    }
}
