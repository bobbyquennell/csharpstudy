﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7LetsBuildAHouseAndHideAndFind
{
    public partial class Form1 : Form
    {
        //Outside garden;
        OutsideWithDoor FrontYard, BackYard;
        RoomWithDoor LivingRoom, Kitchen;
        RoomWithHidingPlace Upstairs_hallway, Master_bedroom, Second_bedroom, Bathroom, DiningRoom;
        OutsideWithHidingPlace Driveway, Garden;
        Room Stairs;
        Location currentLocation;
        Opponent MyOpponent;
        int MoveCount, CheckCount;

        public Form1()
        {
            InitializeComponent();

            CreateObjects();

           // MoveToANewLocation(FrontYard);
            MyOpponent = new Opponent(FrontYard);

        }


        private void CreateObjects()
        {
            DiningRoom = new RoomWithHidingPlace("Dining Room", "a crystal chandelier and flowers", "an armoire");
            LivingRoom = new RoomWithDoor("Living room", "an antique carpet", "a desk", "an oak door with a brass knob");
            Kitchen = new RoomWithDoor("Kitchen", "Big Kitchen", "microwave oven", "a screen door");
            FrontYard = new OutsideWithDoor("FrontYard", false, "an oak door with a brass knob");
            BackYard = new OutsideWithDoor("BackYard", true, "a screen door");

            Garden = new OutsideWithHidingPlace("Garden", false, "the Shed in the Garden");
            Stairs = new Room("Stairs", "a wooden bannister");
            Upstairs_hallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog and a closet", "a closet");
            Master_bedroom = new RoomWithHidingPlace("Master Bedroom", "a larg bed", "a larg bed");
            Second_bedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "a small bed");
            Bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet", "the shower");
            Driveway = new OutsideWithHidingPlace("Driveway", false, "a garage");

            //Initialize Exits
            Garden.Exits = new Location[] { FrontYard, BackYard };
            DiningRoom.Exits = new Location[] { Kitchen, LivingRoom };
            LivingRoom.Exits = new Location[] { DiningRoom, Stairs};
            Stairs.Exits = new Location[] { Upstairs_hallway, LivingRoom };
            Upstairs_hallway.Exits = new Location[] { Stairs, Master_bedroom, Second_bedroom, Bathroom};
            Bathroom.Exits = new Location[] { Upstairs_hallway };
            Master_bedroom.Exits = new Location[] { Upstairs_hallway};
            Second_bedroom.Exits = new Location[] { Upstairs_hallway };
            Driveway.Exits = new Location[] { FrontYard, BackYard };
            Kitchen.Exits = new Location[] { DiningRoom };
            FrontYard.Exits = new Location[] { BackYard, Garden, Driveway };
            BackYard.Exits = new Location[] { FrontYard, Garden, Driveway };

            //Initialize Doors
            FrontYard.DoorLocation = LivingRoom;
            LivingRoom.DoorLocation = FrontYard;
            Kitchen.DoorLocation = BackYard;
            BackYard.DoorLocation = Kitchen;
            MoveCount = 0;
            CheckCount = 0;

            
        }
        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            ////clear the olde items with 
            //ExitsComboBox.Items.Clear();

            ////initialize the ComboBox list with newlocation's exits.
            //for (int i = 0; i < newLocation.Exits.Length; i++)
            //{
            //    ExitsComboBox.Items.Add(newLocation.Exits[i].Name);
            //}
            ////reset the Combo box so it displays the first item in the list.
            //ExitsComboBox.SelectedIndex = 0;
            RedrawForm();
            ////update current location's description to the text box.
            //textBox1.Text = currentLocation.Description;

            ////check if the current location has a door
            //if (currentLocation is IHasExteriorDoor)
            //{
            //    GoThroughTheDoorButton.Visible = true;
            //}
            //else
            //{
            //    GoThroughTheDoorButton.Visible = false;
            //}
            //if (newLocation is IHidingPlace)
            //{
            //    check_button.Visible = true;
            //    IHidingPlace myHidingPlace = newLocation as IHidingPlace;
            //    check_button.Text = "Check " + myHidingPlace.HidingPlaceName.ToString() + "\r\n";
            //}
            //else
            //    check_button.Visible = false;

        }

        private void Gohere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[ExitsComboBox.SelectedIndex]);
            MoveCount++;
        }

        private void GoThroughTheDoorButton_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor Door;
            if (currentLocation is IHasExteriorDoor)
            {
                Door = currentLocation as IHasExteriorDoor;
                MoveToANewLocation(Door.DoorLocation);
                MoveCount++;
            }
        }

        private void Hide_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            for (int n = 1; n <= 20; n++)
            {

                textBox1.Text = n.ToString() + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
                MyOpponent.move();

            }
            textBox1.Text = "Ready or not, here I come! ";
            Application.DoEvents();
            System.Threading.Thread.Sleep(2000);

            Hide_button.Visible = false;
            MoveToANewLocation(FrontYard);
            //Gohere.Visible = true;
            //ExitsComboBox.Visible = true;
            //redraw the form
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            if (MyOpponent.Check(currentLocation))
            {
                MessageBox.Show("You found me in " + this.MoveCount + " Moves !");
                //reset the game
                ResetGame(this.MoveCount);
                this.CheckCount = 0; ;
            }
            else{ 
                this.CheckCount++;
            }
        }
        private void RedrawForm() {

            //clear the olde items with 
            ExitsComboBox.Items.Clear();

            //initialize the ComboBox list with newlocation's exits.
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                ExitsComboBox.Items.Add(currentLocation.Exits[i].Name);
            }
            //reset the Combo box so it displays the first item in the list.
            ExitsComboBox.SelectedIndex = 0;

            //make the buttons visible or unvisible
            if (Hide_button.Visible)
            {
                Gohere.Visible = false;
                ExitsComboBox.Visible = false;
                check_button.Visible = false;
                GoThroughTheDoorButton.Visible = false;
                textBox1.Text = null;
            }
            else {
                Gohere.Visible = true;
                ExitsComboBox.Visible = true;
                //check if the current location has a door
                if (currentLocation is IHasExteriorDoor)
                {
                    GoThroughTheDoorButton.Visible = true;
                }
                else
                {
                    GoThroughTheDoorButton.Visible = false;
                }
                if (currentLocation is IHidingPlace)
                {
                    check_button.Visible = true;
                    //put the correct text label on the middle button
                    IHidingPlace myHidingPlace = currentLocation as IHidingPlace;
                    check_button.Text = "Check " + myHidingPlace.HidingPlaceName.ToString() + "\r\n";
                }
                else
                {
                    check_button.Visible = false;
                }
                //update current location's description to the text box.
                //if(currentLocation is RoomWithDoor){
                //    RoomWithDoor myRoomWithADoor = currentLocation as RoomWithDoor;
                //    textBox1.Text = myRoomWithADoor.Description;
                //}
                //else if (currentLocation is OutsideWithDoor)
                //{
                //    OutsideWithDoor myOutsideWithADoor = currentLocation as OutsideWithDoor;
                //    textBox1.Text = myOutsideWithADoor.Description;
                //}
                textBox1.Text = currentLocation.Description;
            }
            

            
        }
        private void ResetGame(int MoveCount) {

            MyOpponent.ResetOpponent(FrontYard);
            Hide_button.Visible = true;
            RedrawForm();
            textBox1.Text = "You found me in " + currentLocation.Name + " with " + MoveCount.ToString() + " move(s). " + "\r\n";
            textBox1.Text += "You have checked for " + this.CheckCount + " times." + "\r\n";
            this.MoveCount = 0;
            this.CheckCount = 0;

        }

    }
}
