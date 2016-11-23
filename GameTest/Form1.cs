using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTest
{
    public partial class Form1 : Form
    {
        #region Fields

        //позицията на първата кола
        private int carX;
        private int carY;

        private int anotherCarX;
        private int anotherCarY;
        private int anotherCar2X;
        private int anotherCar2Y;
        private int anotherCar2Ypossition;

        private Random random; // кара черната кола да пада хаотично,т.е. не само в левия край на таблото


        //животи и точки
        private int lives = 3;
        private int points = 0;
        private int speed = 5;
        private int level = 50;
        private int levelValue;
        #endregion


        bool right;
        bool left;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame() //въвежда размерите на колните,редовете и т.н.
        {
            carX = 50;     // стартова позицияX на колата
            carY = 350;    // стартова позицияY на колата
            anotherCar2X = 110;
            anotherCar2Ypossition = 150;
            anotherCar2Y = anotherCar2Ypossition;
            anotherCarX = 110;
            anotherCarY = 50;

            random = new Random(31);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (left == true) { player.Location = new Point(carX, carY); }  //задава конкретна позиция на колата
            if (right == true) { player.Location = new Point(carX, carY); }

            // увеличава скоростта според точките
            if (points == level)
            {
                level += 50;
                speed += 1;
            }
            //задава пътва кола на позиция...
            anotherCar.Location = new Point(anotherCarX, anotherCarY);
            anotherCarY += speed;
            //задава втора кола на позиция...
            anotherCar2.Location = new Point(anotherCar2X, anotherCar2Y);
            anotherCar2Y += speed;

            //при контакт с първата кола спира играта
            if (anotherCarY + 70 >= carY && anotherCarX == carX)
            {
                timer1.Enabled = false;
                lives--;
                label1.Text = lives.ToString();
                if (lives > 0)
                {
                    gameover.Text = "Press space\n to continue.";
                }
            }

            anotherCar2Ypossition = random.Next(0, 30); //избира рандом позиция

            if (anotherCar2Ypossition >= 0 && anotherCar2Ypossition <= 10)
            {
                anotherCar2Ypossition = 50;
            }
            else if (anotherCar2Ypossition >= 11 && anotherCar2Ypossition <= 20)
            {
                anotherCar2Ypossition = 130;
            }
            else
            {
                anotherCar2Ypossition = -30;
            }

            //при контакт с втората кола спира играта
            if (anotherCar2Y + 70 >= carY && anotherCar2X == carX)
            {
                timer1.Enabled = false;
                lives--;
                label1.Text = lives.ToString();
                if (lives > 0)
                {
                    gameover.Text = "Press space\n to continue.";
                }
            }

          
            if (anotherCar2Ypossition == -30)
            {
                if (anotherCar2Y - 20 >= carY && anotherCar2X == carX)
                {
                    timer1.Enabled = false;
                    lives--;
                    label1.Text = lives.ToString();
                }
            }

            if (anotherCarY >= 390)    // когато врората кола стигне/подмине дъното( 350 )
            {                           // я пуска отново на първа линия и random позиция
                anotherCar2Y = anotherCar2Ypossition;
                anotherCarY = 50;

                anotherCarX = random.Next(0, 30);
                {
                    if (anotherCarX < 10)
                    {
                        anotherCarX = 50;
                    }
                    else if (anotherCarX >= 10 && anotherCarX < 20)
                    {
                        anotherCarX = 110;
                    }
                    else
                    {
                        anotherCarX = 170;
                    }


                    anotherCar2X = random.Next(0, 40);
                    if (anotherCarX == 50)
                    {
                        if (anotherCar2X >= 10 && anotherCar2X < 20)
                        {
                            anotherCar2X = 110;
                        }
                        else
                        {
                            anotherCar2X = 170;
                        }
                    }
                    if (anotherCarX == 110)
                    {
                        if (anotherCar2X < 10)
                        {
                            anotherCar2X = 50;
                        }
                        else
                        {
                            anotherCar2X = 170;
                        }
                    }
                    if (anotherCarX == 170)
                    {
                        if (anotherCar2X < 10)
                        {
                            anotherCar2X = 50;
                        }
                        else
                        {
                            anotherCar2X = 110;
                        }
                    }
                    if (anotherCar2X > 30 && anotherCar2X <= 40)
                    {
                        anotherCar2X = 5000;
                    }
                }
                points += 10;
                score.Text = points.ToString();
            }
            levelValue = level / 50;
            currentLevel.Text = levelValue.ToString();
            if(lives==0)
            {
                gameover.Text = "Game Over!";
            }
        }
         
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)// проверка за натиснат бутон
            {                           // и променя стойността на координатите 
                right = true; carX += 60;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true; carX -= 60;
            }
            if (carX < 50) { carX = 50; }             //проверка да не излиза за от матрицата
            if (carX > 170) { carX = 170; }

            //проверка на животите и пускане на играта отново със спейс
            if (lives > 0)
            {
                if (e.KeyCode == Keys.Space)
                {
                    timer1.Enabled = true;
                    anotherCarY = 50;
                    anotherCar2Y = anotherCar2Ypossition; if (lives > 0)
                    gameover.Text = "";
                }
            }
            else
            {
                if (e.KeyCode == Keys.Space)
                {
                    timer1.Enabled = false;
                }
            }
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
