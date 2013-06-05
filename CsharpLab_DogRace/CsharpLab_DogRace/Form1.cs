using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CsharpLab_DogRace
{
    public partial class Form1 : Form
    {
        Guy[] bettors = new Guy[3];
        Guy CurrentBettor;
        Greyhound[] dogs = new Greyhound[4];
        public Random my_Randomizer = new Random();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                bettors[i] = new Guy();
            }
            for (int i = 0; i < 4; i++)
            {
                dogs[i] = new Greyhound();
            }
            bettors[0].Name = "Joe";
            bettors[0].MyRadioButton = JoeRadioButton;
            bettors[0].MyLabel = JoeBetLabel;
            bettors[0].Cash = 50;

            bettors[1].Name = "Bob";
            bettors[1].MyRadioButton = BobRadioButton;
            bettors[1].MyLabel = BobBetLabel;
            bettors[1].Cash = 75;

            bettors[2].Name = "Al";
            bettors[2].MyRadioButton = AlRadioButton;
            bettors[2].MyLabel = AlBetLabel;
            bettors[2].Cash = 45;

            dogs[0].MyPictureBox = PicBxDog1;
            dogs[0].RacetrackLength = PicBxRacetrack.Width;
            dogs[0].StartingPositon = dogs[0].MyPictureBox.Location.X;
            dogs[0].Location = dogs[0].StartingPositon;
            dogs[0].Randomizer = my_Randomizer;

            dogs[1].MyPictureBox = PicBxDog2;
            dogs[1].RacetrackLength = PicBxRacetrack.Width;
            dogs[1].StartingPositon = dogs[1].MyPictureBox.Location.X;
            dogs[1].Location = dogs[1].StartingPositon;
            dogs[1].Randomizer = my_Randomizer;

            dogs[2].MyPictureBox = PicBxDog3;
            dogs[2].RacetrackLength = PicBxRacetrack.Width;
            dogs[2].StartingPositon = dogs[2].MyPictureBox.Location.X;
            dogs[2].Location = dogs[2].StartingPositon;
            dogs[2].Randomizer = my_Randomizer;

            dogs[3].MyPictureBox = PicBxDog4;
            dogs[3].RacetrackLength = PicBxRacetrack.Width;
            dogs[3].StartingPositon = dogs[3].MyPictureBox.Location.X;
            dogs[3].Location = dogs[3].StartingPositon;
            dogs[3].Randomizer = my_Randomizer;

            MinBetLabel.Text += ": " + BetAmountNumericUpDown1.Minimum + " bucks";
            for (int i = 0; i < 3; i++)
            {
                bettors[i].MyRadioButton.Text = bettors[i].Name + " has " + bettors[i].Cash + " bucks";
            }
            

        }

        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BettorLabel.Text = bettors[0].Name;
            CurrentBettor = bettors[0];
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BettorLabel.Text = bettors[1].Name;
            CurrentBettor = bettors[1];
        }

        private void AlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BettorLabel.Text = bettors[2].Name;
            CurrentBettor = bettors[2];
        }

        private void Betbutton_Click(object sender, EventArgs e)
        {
            int Amount = (int)BetAmountNumericUpDown1.Value;
            int Dog = (int)DogNumNumericUpDown.Value;
            CurrentBettor.PlaceBet(Amount, Dog);
            CurrentBettor.UpdateLabels();
            for (int i = 0; i < 4; i++)
            {
                dogs[i].TakeStartingPosition();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isWin = false;
            string msg = "";
            int dogWinner = 0;
            while (!isWin)
            {
                for (int i = 0; i < 4 && !isWin; i++)
                {
                    isWin = dogs[i].Run();
                    if (isWin)
                    {
                        dogWinner = i + 1;
                        msg = "We have a winner -dog #" + dogWinner;
                        MessageBox.Show(msg);
                    }
                }
            }
            //for (int i = 0; i < 4; i++)
			//{
            //    dogs[i].TakeStartingPosition();
			//}

            for (int i = 0; i < 3; i++)
            {
                bettors[i].Collect(dogWinner);
                bettors[i].MyRadioButton.Text = bettors[i].Name + " has " + bettors[i].Cash + " bucks";
            }

        }


    }
}