using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private Snake snake = new Snake();
        private Box item = new Box();
        private Box superItem = new Box();
        private Box rotten = new Box();
        Random rd = new Random();

        private int maxX;
        private int maxY;

        Brush snakeColor;
        Brush itemColor;
        Brush rottenColor;
        Brush superItemColor;


        public Form1()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("Start Game");

            new Settings();
            
            gameTimer.Interval = 1000 / Settings.speed;
            gameTimer.Tick += UpdateGrid;
            gameTimer.Start();

            // Begin game
            reset();
        }

        void label1click()
        {

        }

        // Every time we start the game, we need to reset everything
        private void reset()
        {
            System.Diagnostics.Debug.WriteLine("Entered Reset");
            // set game over message to false so it doesn't show while running
            gameOverLabel.Visible = false;
            // create new Settings instance every reset
            new Settings();
            
            // clear the list before every game
            snake.snake.Clear();


            Box head = new Box();
            
            head.x = 10;
            head.y = 10;
            // add head to snake at the beginning of the game
            snake.snake.Add(head);

            // score will change on screen when it is updated
            score.Text = Settings.score.ToString();

            // item counts need to update
            itemNum.Text = Settings.itemCount.ToString() + "x";

            SpawnBox();
        }

        private void UpdateGrid(object sender, EventArgs e)
        {
            // check
            System.Diagnostics.Debug.WriteLine("Entered UpdateGrid ");
            if (Settings.isGameOver == true)
            {
                System.Diagnostics.Debug.WriteLine("Entered UpdateGrid if ");
                // if player presses Space or Enter, the game starts
                if (Player.KeyPressed(Keys.Space) == true || Player.KeyPressed(Keys.Enter) == true)
                {
                    reset();
                }
                else if(Player.KeyPressed(Keys.Back) == true)
                {
                    Application.Exit();
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Entered UpdateGrid else ");
                // cannot go directly from right to left or from up to down
                if ((Player.KeyPressed(Keys.Right) || Player.KeyPressed(Keys.D)) && Settings.direction != Direction.Left)
                {
                    Settings.direction = Direction.Right;
                    System.Diagnostics.Debug.WriteLine("Right");
                }
                else if((Player.KeyPressed(Keys.Left) || Player.KeyPressed(Keys.A)) && Settings.direction != Direction.Right)
                {
                    Settings.direction = Direction.Left;
                    System.Diagnostics.Debug.WriteLine("Left");
                }
                else if ((Player.KeyPressed(Keys.Up) || Player.KeyPressed(Keys.W)) && Settings.direction != Direction.Down)
                {
                    Settings.direction = Direction.Up;
                    System.Diagnostics.Debug.WriteLine("Up");
                }
                else if ((Player.KeyPressed(Keys.Down) || Player.KeyPressed(Keys.S)) && Settings.direction != Direction.Up)
                {
                    Settings.direction = Direction.Down;
                    System.Diagnostics.Debug.WriteLine("Down");
                }

                MoveHead();
            }

            System.Diagnostics.Debug.WriteLine("Invalidate Grid");
            grid.Invalidate();
        }

        // spawns a box randomly on the grid
        // chance to randomly spawn different kinds of boxes on the grid
        private void SpawnBox()
        {
            maxX = grid.Size.Width / Settings.width;
            maxY = grid.Size.Height / Settings.height;

            int newX = rd.Next(0, maxX);
            int newY = rd.Next(0, maxY);

            // check if new box position is on the snake
            for(int i = 0; i <= snake.snake.Count - 1; i++)
            {
                // if box spawns on snake, randomize new position
                if(snake.snake[i].x == newX && snake.snake[i].y == newY)
                {
                    newX = rd.Next(0, maxX);
                    newY = rd.Next(0, maxY);
                    i = -1;
                }
            }

            item = new Box();
            item.x = newX;
            item.y = newY;
        }

        private void score_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void grid_Paint(object sender, PaintEventArgs e)
        {
            // since we used a picturebox for the grid, we can use the graphics library's drawimage class to update the grid
            Graphics gridGr = e.Graphics;

            // create brushes for coloring different objects
            snakeColor = Brushes.Azure;
            itemColor = Brushes.Red;
            rottenColor = Brushes.Brown;
            superItemColor = Brushes.Gold;

            //check
            if (!Settings.isGameOver)
            {
                System.Diagnostics.Debug.WriteLine("Entered grid paint if");
                // create snake
                for (int i = 0; i < snake.snake.Count; i++)
                {
                    
                    // snake
                    gridGr.FillRectangle(snakeColor, new Rectangle(snake.snake[i].x * Settings.width, snake.snake[i].y * Settings.height, Settings.width, Settings.height));

                    // create item
                    gridGr.FillRectangle(itemColor, new Rectangle(item.x * Settings.width, item.y * Settings.height, Settings.width, Settings.height));

                    // create rotten item
                    gridGr.FillRectangle(rottenColor, new Rectangle(rotten.x * Settings.width, rotten.y * Settings.height, Settings.width, Settings.height));

                    // create superItem
                    gridGr.FillRectangle(superItemColor, new Rectangle(superItem.x * Settings.width, superItem.y * Settings.height, Settings.width, Settings.height));

                }


            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Entered grid paint else");
                String gameEndPrompt = "Final Score: " + Settings.score + "\nPress Space or Enter to continue.\nPress Backspace to exit.";
                gameOverLabel.Text = gameEndPrompt;
                gameOverLabel.Visible = true;
            }
        }

        private void MoveHead()
        {
            System.Diagnostics.Debug.WriteLine("Entered MoveHead");
            // we move the head and everything else follows
            for (int i = snake.snake.Count - 1; i >= 0; i--)
            {
                // head is first, or "index 0"
                if(i == 0)
                {
                    if(Settings.direction == Direction.Right)
                    {
                        snake.snake[i].x++; // start moving towards positive x (right)
                    }
                    else if(Settings.direction == Direction.Left)
                    {
                        snake.snake[i].x--; // start moving towards negative x (left)
                    }
                    else if(Settings.direction == Direction.Up)
                    {
                        snake.snake[i].y--; // start moving towards postive y (up)
                    }
                    else if(Settings.direction == Direction.Down)
                    {
                        snake.snake[i].y++; // start moving towards negative y (down)
                    }

                    maxX = grid.Size.Width / Settings.width;
                    maxY = grid.Size.Height / Settings.width;

                    // detect game over

                    // out of bounds
                    if(snake.snake[i].x < 0 || snake.snake[i].x >= maxX || snake.snake[i].y < 0 || snake.snake[i].y >= maxY)
                    {
                        System.Diagnostics.Debug.WriteLine("Entered MoveHead OutOfBounds");
                        GameOver();
                    }

                    // collide with self
                    for(int j = 1; j < snake.snake.Count; j++)
                    {
                        if(snake.snake[i].x == snake.snake[j].x && snake.snake[i].y == snake.snake[j].y)
                        {
                            System.Diagnostics.Debug.WriteLine("Entered MoveHead CollideWithSelf");
                            GameOver();
                        }
                    }

                    // collect boxes
                    // new else-if for the different boxes

                    if (snake.snake[0].x == item.x && snake.snake[0].y == item.y)
                    {
                        Settings.itemCount++;
                        Collect();
                    }
                    else if (snake.snake[0].x == rotten.x && snake.snake[0].y == rotten.y)
                    {

                    }
                    else if (snake.snake[0].x == superItem.x && snake.snake[0].y == superItem.y)
                    {

                    }

                }
                // have the rest of the snake follow
                else
                {
                    snake.snake[i].x = snake.snake[i - 1].x;
                    snake.snake[i].y = snake.snake[i - 1].y;
                }
            }
        }

        // setting isGameOver to game over
        private void GameOver()
        {
            System.Diagnostics.Debug.WriteLine("Entered GameOver");
            Settings.isGameOver = true;
            gameOverLabel.Visible = true;
        }

        // collecting an item
        private void Collect()
        {
            System.Diagnostics.Debug.WriteLine("Entered Collect");
            Box newBox = new Box();
            newBox.x = snake.snake[snake.snake.Count - 1].x;
            newBox.y = snake.snake[snake.snake.Count - 1].y;

            snake.snake.Add(newBox);
            System.Diagnostics.Debug.WriteLine("Collected Box");
            // Update score
            Settings.score += (Settings.points * Settings.speed);
            score.Text = Settings.score.ToString();

            // Update Stats
            itemNum.Text = Settings.itemCount.ToString() + "x";

            Settings.speed += 2;
            SpawnBox();
            System.Diagnostics.Debug.WriteLine("New Box Spawned");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Player.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Player.ChangeState(e.KeyCode, false);
        }

        
    }
}
