
namespace PlayWithWallDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground = new System.Windows.Forms.Panel();
            this.lbAfterGameOver = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.Label();
            this.lbContinueInfo = new System.Windows.Forms.Label();
            this.lbPaused = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wallBottom = new System.Windows.Forms.PictureBox();
            this.wallRight = new System.Windows.Forms.PictureBox();
            this.lbPoints = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.foot = new System.Windows.Forms.PictureBox();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wallBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foot)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.DimGray;
            this.playground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playground.Controls.Add(this.lbAfterGameOver);
            this.playground.Controls.Add(this.gameOver);
            this.playground.Controls.Add(this.lbContinueInfo);
            this.playground.Controls.Add(this.lbPaused);
            this.playground.Controls.Add(this.label3);
            this.playground.Controls.Add(this.information);
            this.playground.Controls.Add(this.label2);
            this.playground.Controls.Add(this.wallBottom);
            this.playground.Controls.Add(this.wallRight);
            this.playground.Controls.Add(this.lbPoints);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.foot);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1060, 620);
            this.playground.TabIndex = 0;
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.playground_Paint);
            // 
            // lbAfterGameOver
            // 
            this.lbAfterGameOver.AutoSize = true;
            this.lbAfterGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAfterGameOver.Location = new System.Drawing.Point(432, 276);
            this.lbAfterGameOver.Name = "lbAfterGameOver";
            this.lbAfterGameOver.Size = new System.Drawing.Size(169, 66);
            this.lbAfterGameOver.TabIndex = 13;
            this.lbAfterGameOver.Text = "F5 - Restart\r\nESC - Quit";
            this.lbAfterGameOver.Visible = false;
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.Location = new System.Drawing.Point(311, 195);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(420, 73);
            this.gameOver.TabIndex = 12;
            this.gameOver.Text = "GAME OVER";
            this.gameOver.Visible = false;
            // 
            // lbContinueInfo
            // 
            this.lbContinueInfo.AutoSize = true;
            this.lbContinueInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContinueInfo.Location = new System.Drawing.Point(317, 379);
            this.lbContinueInfo.Name = "lbContinueInfo";
            this.lbContinueInfo.Size = new System.Drawing.Size(406, 42);
            this.lbContinueInfo.TabIndex = 11;
            this.lbContinueInfo.Text = "Press Enter to continue";
            this.lbContinueInfo.Visible = false;
            // 
            // lbPaused
            // 
            this.lbPaused.AutoSize = true;
            this.lbPaused.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaused.Location = new System.Drawing.Point(306, 261);
            this.lbPaused.Name = "lbPaused";
            this.lbPaused.Size = new System.Drawing.Size(439, 108);
            this.lbPaused.TabIndex = 10;
            this.lbPaused.Text = "PAUSED";
            this.lbPaused.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Commands of game";
            // 
            // information
            // 
            this.information.AutoSize = true;
            this.information.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information.Location = new System.Drawing.Point(407, 276);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(226, 132);
            this.information.TabIndex = 8;
            this.information.Text = "Esc - Quit\r\nSpace - Pause\r\nEnter - Continue\r\nF5 - Restart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1021, 62);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose the side of the foot you want to play(left arrow-left foot,right arrow-rig" +
    "ht foot)\r\n                     You can change side of the foot during game by pr" +
    "essing arrow";
            // 
            // wallBottom
            // 
            this.wallBottom.Location = new System.Drawing.Point(3, 604);
            this.wallBottom.Name = "wallBottom";
            this.wallBottom.Size = new System.Drawing.Size(1060, 15);
            this.wallBottom.TabIndex = 6;
            this.wallBottom.TabStop = false;
            this.wallBottom.Visible = false;
            // 
            // wallRight
            // 
            this.wallRight.Image = global::PlayWithWallDemo.Properties.Resources.wallSide;
            this.wallRight.Location = new System.Drawing.Point(1044, 4);
            this.wallRight.Name = "wallRight";
            this.wallRight.Size = new System.Drawing.Size(15, 620);
            this.wallRight.TabIndex = 5;
            this.wallRight.TabStop = false;
            // 
            // lbPoints
            // 
            this.lbPoints.AutoSize = true;
            this.lbPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoints.Location = new System.Drawing.Point(13, 23);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(96, 25);
            this.lbPoints.TabIndex = 2;
            this.lbPoints.Text = "Points: 0";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = global::PlayWithWallDemo.Properties.Resources.ball;
            this.ball.Location = new System.Drawing.Point(495, 24);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // foot
            // 
            this.foot.BackColor = System.Drawing.Color.Transparent;
            this.foot.Image = global::PlayWithWallDemo.Properties.Resources.rightfooots;
            this.foot.Location = new System.Drawing.Point(413, 539);
            this.foot.Name = "foot";
            this.foot.Size = new System.Drawing.Size(164, 36);
            this.foot.TabIndex = 0;
            this.foot.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 620);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wallBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox foot;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.PictureBox wallRight;
        private System.Windows.Forms.PictureBox wallBottom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.Label lbPaused;
        private System.Windows.Forms.Label lbContinueInfo;
        private System.Windows.Forms.Label lbAfterGameOver;
        private System.Windows.Forms.Label gameOver;
    }
}

