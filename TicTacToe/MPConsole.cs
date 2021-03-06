﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MPConsole : Form
    {
        private String Player1;     //player1
        private String Player2;     //player 2
        int counter=0;              //counter will differetiate the players
        int [,] grid = new int [3,3];   /*2d array to map the game
                                         * array elements will store 0 if no clicks yet
                                         * array elements will hold 1 if player 1 clicks
                                         * array elements will hold 2 f player 2 clicks
                                         */
                                         
        
        public void ifWin()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("["+grid[i,j]+"]");
                }
                Console.WriteLine("}");
            }
            Console.WriteLine("");


        }
        
        /*Button click job method will follow up the click events of the grid buttons*/
        public int clickJob(Button btn, Panel pnl)
        {
            btn.Dispose();
            int retVal = 0;
          
            if (counter % 2 == 0)
            {

                lblPlayer1.ForeColor = Color.Gray;
                lblPlayer2.ForeColor = Color.Red;
                retVal = 1;
                pnl.Visible = true;
                pnl.BackgroundImage = TicTacToe.Properties.Resources.X;
            }

            else
            {
                lblPlayer2.ForeColor = Color.Gray;
                retVal= 2;
                pnl.Visible = true;
                pnl.BackgroundImage = TicTacToe.Properties.Resources.O;
            }
            counter++;
            return retVal;

        }
        /*clickJob method finished*/

        
        public MPConsole(String P1, String P2)
        {
            /*constructed with two strings which were collected from previous form*/
            InitializeComponent();
            Player1 = "Player 1\n" + P1;
            Player2 = "Player 2\n" + P2;
        }

        private void MultiPlayerConsole_Load(object sender, EventArgs e)
        {
            /*initialize the panel, initially player 1 will take the chance*/
            lblPlayer1.Text = Player1;
            lblPlayer2.Text = Player2;
            lblPlayer1.ForeColor = Color.Red;
            lblPlayer2.ForeColor = Color.Gray;

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grid[0, 1] = clickJob(btn2, panel2);
            ifWin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            grid[2, 0] = clickJob(btn7, panel7);
            ifWin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            grid[2,1]=clickJob(btn8,panel8);
            ifWin();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           grid [0,0]=clickJob(btn1,panel1);
           ifWin();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
           grid [0,2] = clickJob(btn3,panel3);
           ifWin();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            grid[1, 0] = clickJob(btn4, panel4);
            ifWin();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            grid[1, 1] = clickJob(btn5, panel5);
           ifWin();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            grid[1, 2] = clickJob(btn6, panel6);
            ifWin();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            grid[2, 2] = clickJob(btn9, panel9);
            ifWin();
        }

    }
}