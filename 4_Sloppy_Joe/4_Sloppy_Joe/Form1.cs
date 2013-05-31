using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_Sloppy_Joe
{
    public partial class Form1 : Form
    {
        MenuMaker myMenu = new MenuMaker() { Randomrizer = new Random()};
        public Form1()
        {
            InitializeComponent();
            label1.Text = myMenu.GetMenumItem();
            label2.Text = myMenu.GetMenumItem();
            label3.Text = myMenu.GetMenumItem();
            label4.Text = myMenu.GetMenumItem();
            label5.Text = myMenu.GetMenumItem();
            label6.Text = myMenu.GetMenumItem();

        }
        
    }
}
