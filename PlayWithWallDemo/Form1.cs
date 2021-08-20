using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayWithWallDemo
{

    public partial class Form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;
        private Wall wall;
        private Ball Ball;
        private Foot Foot;
        private Scene Scene;
        private int slow_down = 15;
        public Form1()
        {
            Ball = new Ball();
            Scene = new Scene();
            Foot = new Foot();
            InitializeComponent();
            timer1.Enabled = false;
            ball.Image = Ball.getImage();
            foot.Image = Foot.getRightSide();

            //remove any border
            this.FormBorderStyle = FormBorderStyle.None;
            //Bring the form to the front
            this.TopMost = true;

            foot.Top = playground.Bottom - (playground.Bottom / 10);
            wall = new Wall();
            DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Set the center of the foot to the position of the cursor
            foot.Left = Cursor.Position.X - (Foot.Image.Width / 2);
            ball.Left += Scene.speed_left;
            ball.Top += Scene.speed_top;

            if (Scene.isTouching(ball, foot))
            {
                point += 1;
                lbPoints.Text = "Points: " + point;
            }

            if (point == slow_down)
            {
                Scene.speed_left = 4 + (slow_down / 2) - 6;
                Scene.speed_top = 4 + (slow_down / 2) - 6;
                slow_down *= 2;

            }

            Scene.moveBall(ball);

            if (Scene.ballIsOut(ball.Bottom, playground.Bottom))
            {
                //Ball is out -> Stop the game
                timer1.Enabled = false;
                gameOver.Visible = true;
                lbAfterGameOver.Visible = true;
            }
            Invalidate(true);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                label2.Visible = false;
                information.Visible = false;
                label3.Visible = false;
                foot.Image = Foot.getLeftSide();
                Cursor.Hide();
                timer1.Enabled = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                label2.Visible = false;
                information.Visible = false;
                label3.Visible = false;
                foot.Image = Foot.getRightSide();

                Cursor.Hide();
                timer1.Enabled = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Space)
            {
                timer1.Enabled = false;
                lbPaused.Visible = true;
                lbContinueInfo.Visible = true;
                playground.BackColor = Color.DarkGray;
                Cursor.Show();
            }
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = true;
                lbPaused.Visible = false;
                lbContinueInfo.Visible = false;
                playground.BackColor = Color.DimGray;
                Cursor.Hide();

            }

            if (e.KeyCode == Keys.F5)
            {
                point = 0;
                Scene.speed_left = 4;
                Scene.speed_top = 4;
                gameOver.Visible = false;
                lbAfterGameOver.Visible = false;
                ball.Left = 50;
                ball.Top = 50;
                lbPoints.Text = "Points: 0";
                label2.Visible = true;
                information.Visible = true;
                label3.Visible = true;
                slow_down = 15;
            }
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //wall.draw(e.Graphics);
        }

        private void playground_Paint(object sender, PaintEventArgs e)
        {
            wall.drawTopWall(e.Graphics);
            wall.drawLeftWall(e.Graphics);
            wall.drawRightWall(e.Graphics);
            //Invalidate(true);
        }
    }
}
