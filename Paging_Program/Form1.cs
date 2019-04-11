using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paging_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public int setsize = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            AccessSequanceListBox.Items.Clear();
        }

        private void btnGetPages_Click(object sender, EventArgs e)
        {
            lsbPages.Items.Clear();
            int amount = int.Parse(numHDD.Text);

            for (int i = 1; i <= amount; i++)
            {
                lsbPages.Items.Add(Convert.ToChar(i + 64));
                ASCB.Items.Add(Convert.ToChar(i + 64));

            }
        }

        private void SetSizeButton_Click(object sender, EventArgs e)
        {
            setsize = int.Parse(ASUD.Text);
        }

        private void SetValButton_Click(object sender, EventArgs e)
        {
            if (setsize > 0)
            {
                setsize = setsize - 1;
                AccessSequanceListBox.Items.Add(ASCB.Text);
            }
            else
            {
                MessageBox.Show("sorry no space left");
            }


        }

        private void AccessSequanceButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < setsize; i++)
            {
                int temp = rnd.Next(setsize);
                AccessSequanceListBox.Items.Add(Convert.ToChar(temp + 65));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessSequanceListBox.Items.Clear();
        }

        private void clock(int tick)
        {

            Random rnd = new Random();
            Graphics papier = Pb_clock.CreateGraphics();
            SolidBrush bloukwas = new SolidBrush(Color.BlueViolet);
            SolidBrush geelkwas = new SolidBrush(Color.LightYellow);
            SolidBrush bruinkwas = new SolidBrush(Color.SaddleBrown);
            // papier.FillEllipse(geelkwas, 40, 40, 40, 40);
            Pen bloupen = new Pen(Color.Blue, 5);
            papier.FillEllipse(geelkwas, 0, 0, 200, 200);
            switch (tick)
            {
                case 0:
                    {
                        papier.DrawLine(bloupen, 100, 100, 100, 0);
                        break;
                    }
                case 1:
                    {
                        papier.DrawLine(bloupen, 100, 100, 150, 0);
                        break;
                    }
                case 2:
                    {
                        papier.DrawLine(bloupen, 100, 100, 200, 50);
                        break;
                    }
                case 3:
                    {
                        papier.DrawLine(bloupen, 100, 100, 200, 100);
                        break;
                    }
                case 4:
                    {
                        papier.DrawLine(bloupen, 100, 100, 200, 150);
                        break;
                    }
                case 5:
                    {
                        papier.DrawLine(bloupen, 100, 100, 150, 200);
                        break;
                    }
                case 6:
                    {
                        papier.DrawLine(bloupen, 100, 100, 100, 200);
                        break;
                    }
                case 7:
                    {
                        papier.DrawLine(bloupen, 100, 100, 50, 200);
                        break;
                    }
                case 8:
                    {
                        papier.DrawLine(bloupen, 100, 100, 0, 150);
                        break;
                    }
                case 9:
                    {
                        papier.DrawLine(bloupen, 100, 100, 0, 100);
                        break;
                    }
                case 10:
                    {
                        papier.DrawLine(bloupen, 100, 100, 0, 50);
                        break;
                    }
                case 11:
                    {
                        papier.DrawLine(bloupen, 100, 100, 50, 0);
                        break;
                    }

                default: break;
            }

        }
        int tick = 0;
        int counter = 0;
        int pos = 1000;
        public string[] page = new string[12];
        public int[] r = new int[12];
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (tick >= 12)
                {
                    tick = 0;
                }
                clock(tick);
                if (page.Contains(AccessSequanceListBox.Items[counter].ToString()))
                {

                    pos = Array.IndexOf(page, AccessSequanceListBox.Items[counter].ToString());

                    if (tick == pos)
                    {
                        r[pos] = 1;
                        if (pos == 0)
                        {
                            lblF0.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                        }
                        else if (pos == 1)
                        {
                            lblF1.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                        }
                        else if (pos == 2)
                        {
                            lblF2.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                        }
                        else if (pos == 3)
                        {
                            lblF3.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                        }
                        else if (pos == 4)
                        {
                            lblF4.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                        }
                        else if (pos == 5)
                        {
                            lblF5.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                        }
                        else if (pos == 6)
                        {
                            lblF6.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];

                        }
                        else if (pos == 7)
                        {
                            lblF7.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                        }
                        else if (pos == 8)
                        {
                            lblF8.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                        }
                        else if (pos == 9)
                        {
                            lblF9.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                        }
                        else if (pos == 10)
                        {
                            lblF10.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                        }
                        else if (pos == 11)
                        {
                            lblF11.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                        }
                    }
                    if (tick == counter - 1)
                    {
                        counter++;

                        /*if (counter >= setsize)
                        {
                            counter = 0;
                            MessageBox.Show("Done");
                            timer1.Stop();
                        }*/
                    }

                }
                else
                {
                    page[tick] = AccessSequanceListBox.Items[counter].ToString();
                    r[tick] = 0;
                    if (tick == 0)
                    {
                        lblF0.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                    }
                    else if (tick == 1)
                    {
                        lblF1.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                    }
                    else if (tick == 2)
                    {
                        lblF2.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                    }
                    else if (tick == 3)
                    {
                        lblF3.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                    }
                    else if (tick == 4)
                    {
                        lblF4.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                    }
                    else if (tick == 5)
                    {
                        lblF5.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                    }
                    else if (tick == 6)
                    {
                        lblF6.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                    }
                    else if (tick == 7)
                    {
                        lblF7.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                    }
                    else if (tick == 8)
                    {
                        lblF8.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                    }
                    else if (tick == 9)
                    {
                        lblF9.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                    }
                    else if (tick == 10)
                    {
                        lblF10.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                    }
                    else if (tick == 11)
                    {
                        lblF11.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                    }
                    counter++;

                    /*if (counter >= setsize)
                    {
                        counter = 0;
                        MessageBox.Show("Done");
                        timer1.Stop();
                    }*/
                }

                tick++;
            }
            catch
            {
                timer1.Stop();
                MessageBox.Show("Done");
                
            }
        

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
