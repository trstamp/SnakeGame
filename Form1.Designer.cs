
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
            this.rottenNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.superNum = new System.Windows.Forms.Label();
            this.itemDesc = new System.Windows.Forms.Label();
            this.rottenDesc = new System.Windows.Forms.Label();
            this.superDesc = new System.Windows.Forms.Label();
            this.cbButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            // rottenNum
            // 
            this.rottenNum.Location = new System.Drawing.Point(51, 37);
            this.rottenNum.Name = "rottenNum";
            this.rottenNum.Size = new System.Drawing.Size(55, 37);
            this.rottenNum.TabIndex = 10;
            this.rottenNum.Text = "0";
            this.rottenNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 11;
            // 
            // itemNum
            // 
            this.itemNum.Location = new System.Drawing.Point(51, 0);
            this.itemNum.Name = "itemNum";
            this.itemNum.Size = new System.Drawing.Size(55, 37);
            this.itemNum.TabIndex = 8;
            this.itemNum.Text = "0";
            this.itemNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 10;
            // 
            // boxLabel
            // 
            this.boxLabel.BackColor = System.Drawing.Color.Red;
            this.boxLabel.Location = new System.Drawing.Point(3, 0);
            this.boxLabel.Name = "boxLabel";
            this.boxLabel.Size = new System.Drawing.Size(20, 20);
            this.boxLabel.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.18605F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.81395F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.Controls.Add(this.superDesc, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.superNum, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rottenDesc, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.boxLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.itemDesc, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rottenNum, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.itemNum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(760, 206);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.38272F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.61728F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 108);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // superNum
            // 
            this.superNum.Location = new System.Drawing.Point(51, 74);
            this.superNum.Name = "superNum";
            this.superNum.Size = new System.Drawing.Size(55, 34);
            this.superNum.TabIndex = 11;
            this.superNum.Text = "0";
            this.superNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemDesc
            // 
            this.itemDesc.Location = new System.Drawing.Point(112, 0);
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.Size = new System.Drawing.Size(167, 37);
            this.itemDesc.TabIndex = 10;
            this.itemDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rottenDesc
            // 
            this.rottenDesc.Location = new System.Drawing.Point(112, 37);
            this.rottenDesc.Name = "rottenDesc";
            this.rottenDesc.Size = new System.Drawing.Size(167, 37);
            this.rottenDesc.TabIndex = 11;
            this.rottenDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // superDesc
            // 
            this.superDesc.AutoSize = true;
            this.superDesc.Location = new System.Drawing.Point(112, 74);
            this.superDesc.Name = "superDesc";
            this.superDesc.Size = new System.Drawing.Size(0, 17);
            this.superDesc.TabIndex = 12;
            // 
            // cbButton
            // 
            this.cbButton.BackColor = System.Drawing.Color.Gray;
            this.cbButton.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbButton.ForeColor = System.Drawing.Color.Black;
            this.cbButton.Location = new System.Drawing.Point(755, 417);
            this.cbButton.Name = "cbButton";
            this.cbButton.Size = new System.Drawing.Size(244, 67);
            this.cbButton.TabIndex = 10;
            this.cbButton.Text = "Toggle colorblind mode!";
            this.cbButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ToggleColorBlind);
            this.cbButton.MouseHover += new System.EventHandler(this.cbBackgroundChange);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.cbButton);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.title);
            this.Controls.Add(this.score);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "C# Group 1 - Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label rottenNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label itemNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label boxLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label superNum;
        private System.Windows.Forms.Label superDesc;
        private System.Windows.Forms.Label rottenDesc;
        private System.Windows.Forms.Label itemDesc;
        private System.Windows.Forms.Label cbButton;
    }
}

