using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
                else if (scene == 1)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 6)
                {
                    scene = 4;
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
                    scene = 2;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 6)
                {
                    scene = 4;
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
                    scene = 2;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 4)
                {
                    scene = 1;
                }
                else if (scene == 6)
                {
                    scene = 4;
                }
            }
            else if (e.KeyCode == Keys.Space) //green button press 
            {
                if (scene == 0)
                {
                    scene = 1; //GREEN STORY IS DONE
                }
                else if (scene == 1)
                {
                    scene = 5;
                }             
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
                    outputLabel.Text = "For what purpose will you be staying at the Dreams Inn today?";

                    yellowLabel.Text = "To have fun";                        
                    redLabel.Text = "I want an exciting experience!";
                    blueLabel.Text = "I'm just curious...";
                    greenLabel.Text = "I won't be.";
                    break;
                case 2:
                    outputLabel.Text = "You go to to front desk and check in\n" +
                        "(When there are no options, press any button to advance)";                    
                    break;
                case 3:
                    outputLabel.Text = "Alright, you're checked in. Your room is to the left, up two floors. \n" +
                        "Have a nice stay!";
                    yellowLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "Restart?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";                  
                    break;
                case 5:
                    outputLabel.Text = "I see";
                    yellowLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    Thread.Sleep(2000);
                    //this.Close;
                    break;
                case 6:
                    outputLabel.Text = "And so your stay at the Dreams Inn was completely normal.";
                    yellowLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
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

        private void redLabel_Click(object sender, EventArgs e)
        {
            //NOOOO
        }

        private void yButton_Click(object sender, EventArgs e)
        {
            //NOOooooooooOoOoOO
        }
    }
}
