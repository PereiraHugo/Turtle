﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Turtle
{
    public partial class MainWindow : Form
    {
        Pen myPen = new Pen(Color.Black);

        Graphics g = null;

        static int start_x, start_y, chosenAngle, previousAngle;
        static Int16 chosenLength;
        static int end_x, end_y;

        UserString pattern = new UserString();

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
            else if (repBraPanel.BackColor == Color.Green)
            {
                DetectStartPosition();
                DetectLength();
                pattern.Userstr = patternBox.Text;
                centerPanel.Refresh();
                g = centerPanel.CreateGraphics();

                L_System system = new L_System();
                //  Creation String seed, add pattern textbox
                system.Seed = pattern.Userstr;
                //  Creation Dictionnaty Rules, all Textbox rules into Store rules 
                system.Rules = system.Store_Rules(ruleKey1, ruleKey2, ruleValue1, ruleValue2);
                // Creation Dictionnary Symbols, Stack All textbox and combobox for the symbols and related symbols
                TextBox[] textboxes = { symbol1, symbol2, symbol3, symbol4, symbol5, symbol6 };
                Stack<TextBox> symbols = new Stack<TextBox>(textboxes);
                ComboBox[] comboboxes = { relatedSymbol1, relatedSymbol2, relatedSymbol3, relatedSymbol4, relatedSymbol5, relatedSymbol6 };
                Stack<ComboBox> relatedSymbols = new Stack<ComboBox>(comboboxes);
                system.Symbols = system.Store_Symbols(symbols, relatedSymbols);
                //  Creation Levels, get value from form
                system.Level = (short)repeatNumericUpDown.Value;
                BuildPath buildpath = new BuildPath();
                buildpath.Buildingpath(system);
                Draw(buildpath, chosenAngle, chosenLength);
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            pattern.SetRandomCharList();
            patternBox.Text = pattern.Userstr;
            ReponseCheckBrackets();
        }

        private void patternBox_TextChanged(object sender, EventArgs e)
        {
            pattern.Userstr = patternBox.Text;
            ReponseCheckBrackets();
        }

        private void examplesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //XmlDocument examplesData = new XmlDocument();
            //examplesData.Load("ExamplesData.xml");
            XElement examplesData = XElement.Parse(Properties.Resources.ExamplesData);
            switch (examplesComboBox.Text)
            {
                case "Plante":
                    ExamplesDataToMainWindows("Plante", examplesData);
                    break;
                case "Koch curve":
                    ExamplesDataToMainWindows("Koch", examplesData);
                    break;
                case "Dragon curve":
                    ExamplesDataToMainWindows("Dragon", examplesData);
                    break;
                case "Sierpinski triangle":
                    ExamplesDataToMainWindows("Sierpinski", examplesData);
                    break;
                case "Fractal":
                    ExamplesDataToMainWindows("Fractal", examplesData);
                    break;
                default:
                    patternBox.Text = "";
                    ruleKey1.Text = "";
                    ruleKey2.Text = "";
                    ruleValue1.Text = "";
                    ruleValue2.Text = "";
                    angleNumericUpDown.Value = 1;
                    break;
            }
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
            Console.WriteLine(respFormat);
            Console.WriteLine(respBrackets);
            if (respBrackets == true && respFormat == true)
            {
                repBraPanel.BackColor = Color.Green;
            }
            else
            {
                repBraPanel.BackColor = Color.Red;
            }
        }

        private void Draw(BuildPath allpath, int angle, int length)
        {
            string path = allpath.Path;
            Stack<int> stack_x = new Stack<int>();
            Stack<int> stack_y = new Stack<int>();
            Stack<int> stack_angle = new Stack<int>();

            foreach (char action in path)
            {
                if (action.Equals('+'))
                {
                    angle = angle + (int)angleNumericUpDown.Value;
                }
                else if (action.Equals('-'))
                {
                    angle = angle + 360 - (int)angleNumericUpDown.Value;
                }
                else if (action.Equals('['))
                {
                    stack_x.Push(start_x);
                    stack_y.Push(start_y);
                    stack_angle.Push(angle);
                    continue;
                }
                else if (action.Equals(']'))
                {
                    start_x = stack_x.Pop();
                    start_y = stack_y.Pop();
                    angle = stack_angle.Pop();
                    continue;
                }
                Console.WriteLine(angle);
                if (action.Equals('+') || action.Equals('-') || action.Equals('F'))
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
                else if (action.Equals('f'))
                {
                    continue;
                }
            }
            return;
        }
        
        private void DetectLength()
        {
            chosenLength = (short)lengthNumericUpDown.Value;
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

        private void ExamplesDataToMainWindows(string exampleName, XElement fullExamplesXml)
        {
            patternBox.Text = fullExamplesXml.Element(exampleName).Element("seed").Value;
            angleNumericUpDown.Value = new decimal(new int[] {
            Int32.Parse(fullExamplesXml.Element(exampleName).Element("angle").Value),
            0,
            0,
            0}); 
            var rules = fullExamplesXml.Element(exampleName).Element("rules").Elements();
            var flag = 1;
            foreach (XElement el in rules)
            {
                if (flag == 1)
                {
                    ruleKey1.Text = el.Name.ToString();
                    ruleValue1.Text = el.Value;
                    flag += 1;
                }
                else if (flag == 2)
                {
                    ruleKey2.Text = el.Name.ToString();
                    ruleValue2.Text = el.Value;
                }
            }
        }
    }
}
