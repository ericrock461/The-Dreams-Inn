﻿using System;
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
        Random randGen = new Random();
        bool slots = false;

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            outputLabel.Text = "Press the Green Button to Start";
            outputImageLabel.Text = "My stay at the Dreams Inn";

            yellowLabel.Visible = false;
            redLabel.Visible = false;
            blueLabel.Visible = false;
            greenLabel.Visible = false;

            reel1.Visible = false;
            reel2.Visible = false;
            reel3.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            
            /* Remember,
             * Yellow = Fun
             * Red = Excite
             * Blue = Curious
             */

            if (e.KeyCode == Keys.N) //yellow button press
            {
                if (scene == 1)
                {
                    scene = 3;
                }           
            }
            else if (e.KeyCode == Keys.M) //red button press
            {
                if (scene == 1)
                {
                    scene = 7;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 0;
                }
                else if (scene == 11)
                {
                    scene = 8;
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 14)
                {
                    scene = 15;
                }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 1)
                {
                    scene = 2;
                }
                else if (scene == 4)
                {
                    scene = 0;
                }
                else if (scene == 11)
                {
                    scene = 9;
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 14)
                {
                    scene = 17;
                }
            }
            else if (e.KeyCode == Keys.Space) //green button press 
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 5;
                }
                else if (scene == 2)
                {
                    scene = 6;
                }
                else if (scene == 3)
                {
                    scene = 4;
                }
                else if (scene == 6)
                {
                    scene = 4;
                }
                else if (scene == 7)
                {
                    scene = 11;
                }
                else if (scene == 8)
                {
                    scene = 16;
                }
                else if (scene == 9)
                {
                    scene = 10;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 13)
                {
                    scene = 14;
                }
                else if (scene == 15)
                {
                    scene = 16;
                }
                else if (scene == 16)
                {
                    scene = 4;
                }
                else if (scene == 17 && slots == true)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 4;
                }
                else if (scene == 17 && slots == false)
                {
                    scene = 19;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 21)
                {
                    scene = 22;
                }
                else if (scene == 22)
                {
                    scene = 16;
                }
                else if (scene == 23)
                {
                    scene = 16;
                }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    greenLabel.Visible = false;
                    slots = false;

                    outputLabel.Text = "Press the Green Button to Start";
                    outputImageLabel.Text = "My stay at the Dreams Inn";
                    yellowLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 1:
                    outputLabel.Text = "For what purpose will you be staying at the Dreams Inn today?";
                    outputImageLabel.Text = "";

                    yellowLabel.Visible = true;
                    redLabel.Visible = true;
                    blueLabel.Visible = true;
                    greenLabel.Visible = true;

                    yellowLabel.Text = "To have fun";                        
                    redLabel.Text = "I want an exciting experience!";
                    blueLabel.Text = "I'm just curious...";
                    greenLabel.Text = "I won't be.";
                    break;
                case 2:
                    outputLabel.Text = "*You go to to front desk and check in*\n\n" +
                        "'Alright, you're checked in. Your room is to the left, up two floors. \n" +
                        "Have a nice stay!'";
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";
                    break;
                case 3:
                    outputLabel.Text = "*You go to to front desk and check in*\n\n" +
                        "'Alright, you're set! By the way, there's a list of activities we're doing tonight\n" +
                        "on the board over there. Have a fun stay!'";
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";
                    break;
                case 4:
                    outputLabel.Text = "Restart?";

                    redLabel.Visible = true;
                    blueLabel.Visible = true;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = false;

                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";                  
                    break;
                case 5:
                    outputLabel.Text = "I see";
                    yellowLabel.Visible = false;
                    redLabel.Text = "Title Screen";
                    blueLabel.Visible = false;
                    greenLabel.Visible = false;
                    Refresh();
                    Thread.Sleep(2000);
                    //this.Close();
                    break;
                case 6:
                    outputLabel.Text = "And so your stay at the Dreams Inn was completely normal.";
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";
                    break;
                case 7:
                    outputLabel.Text = " *You go to to front desk and check in*\n\n" +
                        "'Aaand done! Your room is up two floors.\n" +
                        "By the way, please don't look at the News. Thanks'";
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";
                    break;
                case 8:
                    outputLabel.Text = "*You are feeling so self-righteous that you didn't realize the floors had\n" +
                        "just been mopped, and you slip down the stairs and die.*";
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";
                    break;
                case 9:
                    outputImageLabel.Text = "Crazy gang reported to be attacking hotels all across the province!\n" +
                        "Until they are caught it is advised to avoid staying at any hotel.";
                    outputLabel.Text = "";
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";
                    break;
                case 10:
                    outputLabel.Text = "Uh oh, that sounds pretty bad, what should I do?";
                    outputImageLabel.Text = "";                 
                    yellowLabel.Visible = false;
                    redLabel.Visible = true;
                    blueLabel.Visible = true;
                    greenLabel.Visible = false;

                    redLabel.Text = "Leave";                  
                    blueLabel.Text = "Go to room";
                    break;
                case 11:
                    outputLabel.Text = "";
                    outputImageLabel.Text = "";

                    yellowLabel.Visible = false;
                    greenLabel.Visible = false;
                    redLabel.Visible = true;
                    blueLabel.Visible = true;
                    
                    //sound to indicate there's a choice?
                    redLabel.Text = "Don't look at the News";
                    blueLabel.Text = "Look at the News";
                    break;
                case 12:
                    outputLabel.Text = "*You hear a voice from behind you*\n" +
                        "'Where do ya fink you're goin'? Cuz ya comin' wif us!!'";
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";
                    break;
                case 13:
                    outputLabel.Text = "";
                    outputImageLabel.BackColor = Color.Black;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = false;
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    Refresh();
                    Thread.Sleep(3100);
                    
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";
                    break;
                case 14:
                    outputImageLabel.BackColor = Color.White;
                    //outputImageLabelLabel.Image = 
                    outputLabel.Text = "'Ok, so what we're gonna do, is you play this here \n" +
                        "slot machine, okay? If you win, I'll let you go. \n" +
                         "Got it? Great.'";             
                    outputImageLabel.Text = "";
                    redLabel.Visible = true;
                    blueLabel.Visible = true;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = false;

                    redLabel.Text = "Hecc No!";
                    blueLabel.Text = "...Ok...";

                    reel1.Visible = true;
                    reel2.Visible = true;
                    reel3.Visible = true;                 
                    break;
                case 15:
                    outputLabel.Text = "'Alright, fair enuff then.'";
                    outputImageLabel.Text = "";
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";
                    break;
                case 16:
                    outputLabel.Text = "";
                    outputImageLabel.Text = "Game Over";
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";
                    break;
                case 17:
                    outputLabel.Text = "";
                    outputImageLabel.Text = "";
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = false;


                    reel1.Visible = true;
                    reel2.Visible = true;
                    reel3.Visible = true;
                  
                    int reel1Value = randGen.Next(1, 4);                 
                    int reel2Value = randGen.Next(1, 4);                  
                    int reel3Value = randGen.Next(1, 4);

                    switch (reel1Value)
                    {
                        case 1:
                            Thread.Sleep(1000);
                            reel1.Refresh();
                            reel1.Text = "seven"; //Image = Properties.Resources._7_100x125;
                            break;
                        default:
                            Thread.Sleep(1000);
                            reel1.Refresh();
                            reel1.Text = "cherry"; //Image = Properties.Resources.diamond_100x125;
                            break;
                    }
                    switch (reel2Value)
                    {
                        case 1:
                            Thread.Sleep(2000);
                            reel2.Refresh();
                            reel2.Text = "seven"; //Image = Properties.Resources._7_100x125;
                            break;
                        default:
                            Thread.Sleep(2000);
                            reel2.Refresh();
                            reel2.Text = "cherry"; //Image = Properties.Resources.diamond_100x125;
                            break;
                    }
                    switch (reel3Value)
                    {
                        case 1:
                            Thread.Sleep(4000);
                            reel3.Refresh();
                            reel3.Text = "seven";//Image = Properties.Resources._7_100x125;
                            break;
                        default:
                            Thread.Sleep(4000);
                            reel3.Refresh();
                            reel3.Text = "cherry"; //Image = Properties.Resources.diamond_100x125;
                            break;
                    }

                    if (reel1Value == reel2Value && reel2Value == reel3Value)
                    {
                        outputLabel.Text = "Huh. Well, I guess you're free, then. Hallway's to the left.\n" +
                            "UNFINISHED";
                        slots = true;
                        greenLabel.Visible = true;
                        greenLabel.Text = "Continue";
                    }
                    else
                    {
                        outputLabel.Text = "So, you didn't win. Boss said if you didn't win\n" +
                            "I should escort you to your room.";
                        greenLabel.Visible = true;
                        greenLabel.Text = "Continue";
                    }
                    break;
                case 18:
                    outputLabel.Text = "You Won 'The Lucky Way'";
                    outputImageLabel.Text = "";
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";

                    reel1.Visible = false;
                    reel2.Visible = false;
                    reel3.Visible = false;
                    break;
                case 19:
                    outputLabel.Text = "Now I've got you...";                     
                        //"I don't really know what I should do here...";
                    outputImageLabel.Text = "Hallway Scene";
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";

                    reel1.Visible = false;
                    reel2.Visible = false;
                    reel3.Visible = false;
                    break;
                case 20:
                    outputLabel.Text = "Mob Boss would like to battle!\n\n" +
                        "What will you do?";
                    outputImageLabel.Text = "";
                    redLabel.Visible = true;
                    blueLabel.Visible = true;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = false;

                    yellowLabel.Text = "Fight";
                    blueLabel.Text = "Flee";
                    redLabel.Text = "Key Card";
                    break;
                case 21:
                    outputLabel.Text = "*You throw your hotel key card at Mob Boss!\n" +
                        "*You hit him right in the eye!*\n\n" +
                        "Mob Boss: 'ARRRGGGGGG!!!!'";
                    outputImageLabel.Text = "";
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";
                    break;
                case 22:
                    outputLabel.Text = "Mob Boss: HERE I COOOOOMEEEE!!!!!";
                    outputImageLabel.Text = "Can't flee this fight!";
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Continue";
                    break;
                case 23:
                    outputLabel.Text = "";
                    outputImageLabel.Text = "";
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = false;
                    break;
                case 24:
                    outputLabel.Text = "";
                    outputImageLabel.Text = "";
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = false;
                    break;
                case 25:
                    outputLabel.Text = "";
                    outputImageLabel.Text = "";
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = false;
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
