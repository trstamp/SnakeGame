using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };
    class Settings
    {
        // all variables are static since we only need one instance of
        // the Settings class

        // width and height of the grid
        public static int width
        {
            get;
            set;
        }

        public static int height
        {
            get;
            set;
        }

        // current score while playing
        public static int score
        {
            get;
            set;
        }

        // amount of points received from  a block
        public static int points
        {
            get;
            set;
        }

        // speed of snake
        public static int speed
        {
            get;
            set;
        }

        // whether or not game is over
        // 0 = Start Screen, 1 = Game, 2 = Game Over
        public static bool isGameOver
        {
            get;
            set;
        }

        // current direction
        public static Direction direction
        {
            get;
            set;
        }

        public static int itemCount
        {
            get;
            set;
        }

        public Settings()
        {
            itemCount = 0;
            score = 0;
            width = 20;
            height = 20;
            speed = 10;
            points = 10;
            isGameOver = false;
            direction = Direction.Down;
        }

    }
}
