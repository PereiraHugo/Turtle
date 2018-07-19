using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turtle
{
    public partial class MainWindow : Form
    {
        Pen myPen = new Pen(Color.Black);

        Graphics g = null;

        static int branch_start_x, branch_start_y;
        static int start_x, start_y, chosenAngle, chosenLength, previousAngle;
        static int end_x, end_y;
        
        static int my_increment = 0;
        static int num_lines = 0;

        CharacterList pattern = new CharacterList();

        public MainWindow()
        {
            InitializeComponent();
            startButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (repBraPanel.BackColor == Color.Red)
            {
                System.Windows.Forms.MessageBox.Show("Check the pattern given !!\nInvalid character given (character allowed : a-zA-Z and parenthesis) or parenthesis not open/closed");
                return;
            }
            DetectStartPosition();
            DetectLength();
            pattern.SetCharList(patternBox.Text);
            centerPanel.Refresh();
            g = centerPanel.CreateGraphics();
            Draw(pattern.GetCharList(), chosenAngle, (int)repeatNumericUpDown.Value, chosenLength);
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            pattern.SetRandomCharList();
            patternBox.Text = pattern.GetCharList();
            ReponseCheckBrackets();
        }

        private void patternBox_TextChanged(object sender, EventArgs e)
        {
            pattern.SetCharList(patternBox.Text);
            ReponseCheckBrackets();
        }

        private void positionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectStartPosition();
            if (repBraPanel.BackColor == Color.Green)
            {
                startButton.Enabled = true;
            }
        }

        private void ReponseCheckBrackets()
        {
            var respBrackets = pattern.CheckParentheses();
            var respFormat = pattern.CheckFormat();

            if (respBrackets == true && respFormat == true)
            {
                repBraPanel.BackColor = Color.Green;
            }
            else
            {
                repBraPanel.BackColor = Color.Red;
            }
        }

        private void centerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Draw(string partern, int angle, int repeats, int length)
        {
            foreach (char action in pattern.GetCharList())
            {
                if (action.Equals('R'))
                {
                    angle = angle + (int)angleNumericUpDown.Value;
                }
                else if (action.Equals('L'))
                {
                    angle = angle + 360 - (int)angleNumericUpDown.Value;
                }
                else if (action.Equals('('))
                {
                    branch_start_x = start_x;
                    branch_start_y = start_y;
                }
                else if (action.Equals(')'))
                {
                    start_x = branch_start_x;
                    start_y = branch_start_y;
                }
                
                if (action.Equals('R') || action.Equals('L') || action.Equals('S'))
                {
                    // Modifiy Cos and Sin for each start
                    end_x = (int)(start_x + Math.Cos(angle * .017453292519) * length);
                    end_y = (int)(start_y + Math.Sin(angle * .017453292519) * length);

                    Point[] points = {
                        new Point(start_x, start_y),
                        new Point(end_x, end_y),
                    };
                    start_x = end_x;
                    start_y = end_y;
                    g.DrawLines(myPen, points);
                }
            }
            return;
        }


        private void DetectLength()
        {
            chosenLength = (int)lengthNumericUpDown.Value;
        }

        private void DetectStartPosition()
        {
            string positionSelected = positionList.SelectedItem.ToString();
            if (positionSelected == "Bottom")
            {
                start_x = centerPanel.Width / 2;
                start_y = centerPanel.Height;
                chosenAngle = 270;
            }
            else if (positionSelected == "Center")
            {
                start_x = centerPanel.Width / 2;
                start_y = centerPanel.Height / 2;
            }
            else if (positionSelected == "Left")
            {
                start_x = 0;
                start_y = centerPanel.Height / 2;
                chosenAngle = 0;
            }
            else if (positionSelected == "Right")
            {
                start_x = centerPanel.Width;
                start_y = centerPanel.Height / 2;
                chosenAngle = 180;
            }
            else if (positionSelected == "Top")
            {
                start_x = centerPanel.Width / 2;
                start_y = 0;
                chosenAngle = 90;
            }
        }
    }
}
