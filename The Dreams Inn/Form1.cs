using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Dreams_Inn
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        // random number generator

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            outputLabel.Text = "Press any button to start";          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene

            if (e.KeyCode == Keys.N) //yellow button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
            }
            else if (e.KeyCode == Keys.M) //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 3;
                }

            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
            }
            else if (e.KeyCode == Keys.Space) //green button press 
            {

            }


            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:
                    outputLabel.Text = "";
                    yellowLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 1:
                    outputLabel.Text = "For what purpose will you be staying at the\n" +
                        "Dreams Inn today?";

                    yellowLabel.Text = "To have fun";                        
                    redLabel.Text = "I want an exciting experience!";
                    blueLabel.Text = "I'm just curious...";
                    greenLabel.Text = "I won't be.";
                    break;
                case 2:
                    outputLabel.Text = "Ded";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                default:
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //OOPS :(
        }
    }
}
