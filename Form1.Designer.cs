
namespace SnakeGame
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
            this.grid = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.title = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.stats = new System.Windows.Forms.Label();
            this.boxLabel = new System.Windows.Forms.Label();
            this.itemNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grid.Location = new System.Drawing.Point(12, 141);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(600, 600);
            this.grid.TabIndex = 0;
            this.grid.TabStop = false;
            this.grid.Paint += new System.Windows.Forms.PaintEventHandler(this.grid_Paint);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(797, 684);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(117, 57);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score: ";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(920, 684);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(150, 57);
            this.score.TabIndex = 3;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.score.Paint += new System.Windows.Forms.PaintEventHandler(this.score_Paint);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1058, 84);
            this.title.TabIndex = 4;
            this.title.Text = "Snake Game";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.White;
            this.gameOverLabel.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(49, 154);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(108, 47);
            this.gameOverLabel.TabIndex = 5;
            this.gameOverLabel.Text = "label1";
            this.gameOverLabel.Visible = false;
            // 
            // stats
            // 
            this.stats.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats.Location = new System.Drawing.Point(814, 141);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(100, 28);
            this.stats.TabIndex = 6;
            this.stats.Text = "Stats";
            this.stats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxLabel
            // 
            this.boxLabel.BackColor = System.Drawing.Color.Red;
            this.boxLabel.Location = new System.Drawing.Point(816, 215);
            this.boxLabel.Name = "boxLabel";
            this.boxLabel.Size = new System.Drawing.Size(20, 20);
            this.boxLabel.TabIndex = 7;
            // 
            // itemNum
            // 
            this.itemNum.Location = new System.Drawing.Point(791, 215);
            this.itemNum.Name = "itemNum";
            this.itemNum.Size = new System.Drawing.Size(19, 23);
            this.itemNum.TabIndex = 8;
            this.itemNum.Text = "0";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.itemNum);
            this.Controls.Add(this.boxLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.title);
            this.Controls.Add(this.score);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.Text = "C# Group 1 - Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox grid;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label stats;
        private System.Windows.Forms.Label boxLabel;
        private System.Windows.Forms.Label itemNum;
    }
}

