using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Player
    {
        // create the hashtable that holds all keyboard values
        private static Hashtable keyboardButtons = new Hashtable();

        // checking which key is pressed
        /*public static Keys KeyPress(Keys key, Keys key2)
        {

            switch (key)
            {
                case Keys.A: 
                case Keys.Left:
                    break;
                case Keys.D:
                case Keys.Right:
                    break;
                case Keys.W:
                case Keys.Up:
                    break;
                case Keys.S:
                case Keys.Down:
                    break;
            }
            if(key == Keys.A || key == Keys.Left)
            {
                
            }
            else if (key == Keys.D || key == Keys.Right)
            {

            }
            else if (key == Keys.W || key == Keys.Up)
            {

            }
            else if (key == Keys.S || key == Keys.Down)
            {

            }
            else if(key == Keys.Space || key == Keys.Enter)
            {
                return key;
            }
            
        }*/

        //check if button is pressed or not
        public static bool KeyPressed(Keys key)
        {
            // if the state of the key is null, change it to false
            // (it is not being pressed)
            if(keyboardButtons[key] == null)
            {
                System.Diagnostics.Debug.WriteLine("False");
                return false;
            }

            // otherwise, return the state
            System.Diagnostics.Debug.WriteLine((bool)keyboardButtons[key]);
            return (bool)keyboardButtons[key];
        }

        public static void ChangeState(Keys key, bool state)
        {
            keyboardButtons[key] = state;
        }
    }
}
