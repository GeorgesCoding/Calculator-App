/* Calculator app with basic mathemtical functions
 * with an interactive interface and features included
 * to prevent unaccepted user input from crashing the app
 * George C.
 * Start Date: 01/12/2023
 * Finish Date: 01/13/2023, 
 */

using System;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        //variable declaration
        float number, answer;
        int operation;

        //Loads the calculator app window
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Changes the Display text
        private void Display_TextChanged(object sender, EventArgs e)
        {
        }

        //buttons that adds the number to the display
        private void one_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 2;
        }

        private void three_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 3;
        }

        private void four_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 9;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 0;
        }

        private void doublezero_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 0 + 0;
        }

        //button to display a decimal
        private void dot_Click(object sender, EventArgs e)
        {
            if (Display.Text == "")
            {
                Display.Text = Display.Text + ".";
            }

            else if (int.TryParse(Display.Text, out int j))
            {
                Display.Text = Display.Text + ".";

            }
        }

        //addition operation
        private void plus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Display.Text, out int j))
            {
                number = float.Parse(Display.Text);
                Display.Clear();
                Display.Focus();
                operation = 1;
            }

            else if (float.TryParse(Display.Text, out float k))
            {
                number = float.Parse(Display.Text);
                Display.Clear();
                Display.Focus();
                operation = 1;
            }
        }

        //subtraction operation
        private void minus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Display.Text, out int j))
            {
                number = float.Parse(Display.Text);
                Display.Clear();
                Display.Focus();
                operation = 2;
            }

            else if (float.TryParse(Display.Text, out float k))
            {
                number = float.Parse(Display.Text);
                Display.Clear();
                Display.Focus();
                operation = 2;
            }

            else if (Display.Text == "")
            {
                Display.Text = Display.Text + "-";
            }
        }

        //multiplication operation
        private void multiply_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Display.Text, out int j))
            {
                number = float.Parse(Display.Text);
                Display.Clear();
                Display.Focus();
                operation = 3;
            }

            else if (float.TryParse(Display.Text, out float k))
            {
                number = float.Parse(Display.Text);
                Display.Clear();
                Display.Focus();
                operation = 3;
            }
        }

        //division operation
        private void divide_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Display.Text, out int j))
            {
                number = float.Parse(Display.Text);
                Display.Clear();
                Display.Focus();
                operation = 4;
            }

            else if (float.TryParse(Display.Text, out float k))
            {
                number = float.Parse(Display.Text);
                Display.Clear();
                Display.Focus();
                operation = 4;
            }
        }

        //computing the answer (equal sign button)
        private void equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case 1:
                    answer = number + float.Parse(Display.Text);
                    Display.Text = answer.ToString();
                    break;

                case 2:
                    answer = number - float.Parse(Display.Text);
                    Display.Text = answer.ToString();
                    break;

                case 3:

                    answer = number * float.Parse(Display.Text);
                    Display.Text = answer.ToString();
                    break;

                case 4:
                    answer = number / float.Parse(Display.Text);
                    Display.Text = answer.ToString();
                    break;

                default:
                    break;
            }
        }

        //clear entires (C button)
        private void clear_Click(object sender, EventArgs e)
        {
            Display.Clear();
            operation = 0;
        }
    }
}