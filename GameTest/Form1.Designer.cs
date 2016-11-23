namespace GameTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screen = new System.Windows.Forms.Panel();
            this.anotherCar2 = new System.Windows.Forms.PictureBox();
            this.anotherCar = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreboard = new System.Windows.Forms.Label();
            this.livesboard = new System.Windows.Forms.Label();
            this.currentLevel = new System.Windows.Forms.Label();
            this.levelboard = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anotherCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anotherCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.screen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("screen.BackgroundImage")));
            this.screen.Controls.Add(this.gameover);
            this.screen.Controls.Add(this.anotherCar2);
            this.screen.Controls.Add(this.anotherCar);
            this.screen.Controls.Add(this.player);
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(267, 458);
            this.screen.TabIndex = 0;
            // 
            // anotherCar2
            // 
            this.anotherCar2.BackColor = System.Drawing.Color.Transparent;
            this.anotherCar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anotherCar2.BackgroundImage")));
            this.anotherCar2.Location = new System.Drawing.Point(50, 138);
            this.anotherCar2.Name = "anotherCar2";
            this.anotherCar2.Size = new System.Drawing.Size(53, 95);
            this.anotherCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.anotherCar2.TabIndex = 4;
            this.anotherCar2.TabStop = false;
            // 
            // anotherCar
            // 
            this.anotherCar.BackColor = System.Drawing.Color.Transparent;
            this.anotherCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anotherCar.BackgroundImage")));
            this.anotherCar.Location = new System.Drawing.Point(110, 50);
            this.anotherCar.Name = "anotherCar";
            this.anotherCar.Size = new System.Drawing.Size(51, 97);
            this.anotherCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.anotherCar.TabIndex = 1;
            this.anotherCar.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.Location = new System.Drawing.Point(50, 350);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(53, 93);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(273, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "3";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score.Location = new System.Drawing.Point(273, 53);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(30, 31);
            this.score.TabIndex = 2;
            this.score.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreboard
            // 
            this.scoreboard.AutoSize = true;
            this.scoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreboard.Location = new System.Drawing.Point(273, 22);
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.Size = new System.Drawing.Size(125, 31);
            this.scoreboard.TabIndex = 4;
            this.scoreboard.Text = "SCORE:";
            // 
            // livesboard
            // 
            this.livesboard.AutoSize = true;
            this.livesboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.livesboard.Location = new System.Drawing.Point(271, 168);
            this.livesboard.Name = "livesboard";
            this.livesboard.Size = new System.Drawing.Size(110, 33);
            this.livesboard.TabIndex = 5;
            this.livesboard.Text = "LIVES:";
            // 
            // currentLevel
            // 
            this.currentLevel.AutoSize = true;
            this.currentLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentLevel.Location = new System.Drawing.Point(273, 350);
            this.currentLevel.Name = "currentLevel";
            this.currentLevel.Size = new System.Drawing.Size(86, 31);
            this.currentLevel.TabIndex = 6;
            this.currentLevel.Text = " dddd";
            // 
            // levelboard
            // 
            this.levelboard.AutoSize = true;
            this.levelboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelboard.Location = new System.Drawing.Point(271, 319);
            this.levelboard.Name = "levelboard";
            this.levelboard.Size = new System.Drawing.Size(112, 31);
            this.levelboard.TabIndex = 7;
            this.levelboard.Text = "LEVEL:";
            this.levelboard.Click += new System.EventHandler(this.label2_Click);
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameover.Location = new System.Drawing.Point(54, 213);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(0, 31);
            this.gameover.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 458);
            this.Controls.Add(this.levelboard);
            this.Controls.Add(this.currentLevel);
            this.Controls.Add(this.livesboard);
            this.Controls.Add(this.scoreboard);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score);
            this.Location = new System.Drawing.Point(55, 55);
            this.Name = "Form1";
            this.Text = "GameTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anotherCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anotherCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox anotherCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox anotherCar2;
        private System.Windows.Forms.Label scoreboard;
        private System.Windows.Forms.Label livesboard;
        private System.Windows.Forms.Label currentLevel;
        private System.Windows.Forms.Label levelboard;
        private System.Windows.Forms.Label gameover;
    }
}

