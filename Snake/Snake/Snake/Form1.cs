using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {

        PictureBox[] snakeParts;
        int snakeSize = 5;
        Point location = new Point(120, 120);
        string direction = "Right";
        bool changingDirection = false;

        PictureBox food = new PictureBox();
        Point foodLocation = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            PanelGame.Controls.Clear();
            snakeParts = null;
            snakeSize = 5;
            direction = "Right";
            location = new Point(120,120);

            drawSnake();
           

         
        }

        private void drawSnake()
        {
            snakeParts = new PictureBox[snakeSize];

                for(int i = 0; i < snakeParts.Length; i++)
                {
                    snakeParts[i] = new PictureBox();
                    snakeParts[i].Size = new Size(15, 15);
                    snakeParts[i].BackColor = Color.Red;
                    snakeParts[i].BorderStyle = BorderStyle.FixedSingle;
                    snakeParts[i].Location = new Point(location.X - (15 * i), location.Y);
                     PanelGame.Controls.Add(snakeParts[i]);
                }


            }

                


        
    }
}
