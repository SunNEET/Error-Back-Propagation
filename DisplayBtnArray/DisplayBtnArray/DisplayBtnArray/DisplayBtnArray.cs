using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayBtnArray
{
    public partial class DisplayBtnArray_page : Form
    {
        static public Point Orig = new Point(30, 30); // Offset from button_refresh (14,90)+(0,40)+(0,14)

        static public int x_amount;
        static public int y_amount;
        public int BTN_SIZE = 18; 
        static public int idx;
        static public int[][] BtnColorRecord;
        public string ret_Str="";
        public int DisplayCount = 1;

        public ArrayButtons[] MyButtons;

        public DisplayBtnArray_page(int X, int Y,string input = "")
        {
            InitializeComponent();
            x_amount = X;
            y_amount = Y;
            BtnColorRecord = new int[1][];
            Refresh();
            //parse(input);

        }
        public void parse(string input)
        {            
            string[] TestInput  = input.Split(new char[] { ' ', ',', '\n' });          
            int InCnt = 0;
            try
            {
                for (int i = 0; i < y_amount; i++)
                {
                    for (int j = 0; j < x_amount; j++)
                    {
                        while (TestInput[InCnt] == "")
                            InCnt++;

                        BtnColorRecord[i][j] = Convert.ToInt32(TestInput[InCnt]);                        
                        InCnt++;
                    }
                }        
            }
            catch
            {
                for (int i = 0; i < y_amount; i++)
                    for (int j = 0; j < x_amount; j++)
                        BtnColorRecord[i][j] = 0;
            }                  
        }
        public void Refresh()
        {
            try
            {
                //If not fisrt display, Clear the button array.
                if (DisplayCount == 1)
                {
                    DisplayCount = 2;
                }
                else
                {
                    for (int y = 0; y < y_amount; ++y)
                    {
                        for (int x = 0; x < x_amount; ++x)
                        {
                            idx = x + y * x_amount;
                            this.Controls.Remove(MyButtons[idx]);
                        }
                    }
                }

                //Get parameters
                //x_amount = Math.Abs(Convert.ToInt32(textBox_Xamount.Text));
                //y_amount = Math.Abs(Convert.ToInt32(textBox_Yamount.Text));

                BtnColorRecord = new int[y_amount][];

                //Create New Buttons
                MyButtons = new ArrayButtons[x_amount * y_amount];

                for (int y = 0; y < y_amount; ++y)
                {
                    BtnColorRecord[y] = new int[x_amount];
                    for (int x = 0; x < x_amount; ++x)
                    {
                        idx = x + y * x_amount;

                        BtnColorRecord[y][x] = 0;

                        MyButtons[idx] = new ArrayButtons(x, y, idx, BTN_SIZE);

                        MyButtons[idx].BackColor = Color.Black;

                        //MyButtons[idx].Location = new Point(Orig.X + x * BTN_SIZE, Orig.Y + y * BTN_SIZE);
                        //MyButtons[idx].Location = new Point(200 + x * BTN_SIZE, 200 + y * BTN_SIZE);

                        MyButtons[idx].Left = 10 + x * MyButtons[0].Width + (x / 5 * 2);
                        MyButtons[idx].Top = 10 + y * MyButtons[0].Height + (y / 5 * 2);
                    }
                }
                this.Controls.AddRange(MyButtons);

                //Location change is valid after Controls.AddRange
                int interval = 4;
                for (int y = 0; y < y_amount; ++y)
                {
                    for (int x = 0; x < x_amount; ++x)
                    {
                        idx = x + y * x_amount;
                        MyButtons[idx].Location = new Point(Orig.X + x * (BTN_SIZE + interval), Orig.Y + y * (BTN_SIZE + interval));
                    }
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString(), "Error");
            }
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }


        public class ArrayButtons : Button
        {
            public int x, y, idx;
            public bool isOne;
            public ArrayButtons(int x, int y, int idx, int BTN_SIZE)
            {
                isOne = false;

                this.x = x;
                this.y = y;
                this.idx = idx;
                //this.Location = new Point(Orig.X + x * BTN_SIZE, Orig.Y + y * BTN_SIZE);
                //this.Location = new Point(200 + x * BTN_SIZE, 200 + y * BTN_SIZE);
                this.Size = new Size(BTN_SIZE, BTN_SIZE);
                this.FlatStyle = FlatStyle.Flat;
                this.FlatAppearance.BorderColor = Color.Silver;
                this.FlatAppearance.BorderSize = 1;
                this.BackColor = Color.Black;
                this.Enabled = true;

                this.Click += ArrayBtn_Click;
            }

            private void ArrayBtn_Click(object sender, EventArgs e)
            {
                if(isOne == false)
                {
                    this.BackColor = Color.Yellow;
                    isOne = true;
                    BtnColorRecord[idx / x_amount][idx % x_amount] = 1;
                }
                else if (isOne == true)
                {
                    this.BackColor = Color.Black;
                    isOne = false;
                    BtnColorRecord[idx / x_amount][idx % x_amount] = 0;
                }
                else
                {
                    this.BackColor = Color.Black;
                }
            }

        }

        public string get_ArrayStr()
        {
            string str="";
            for (int i = 0; i < y_amount; i++)
            {
                for (int j = 0; j < x_amount; j++)                
                    str += BtnColorRecord[i][j] + " ";                
                str += "\n";
            }
            return str;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();           
            richTextBox1.Text = get_ArrayStr();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            ret_Str = get_ArrayStr();
            this.Close();
        }
    }
}
