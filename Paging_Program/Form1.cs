﻿using System;
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
        public string[] tlb { get;set; }
        public static string newLine = "";

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
        Boolean changed = false;
        public string[] page = new string[12];
        public int[] r = new int[12];
        Boolean full = false;



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
                    
                    listBox1.Items.Add("searching for val");
                    pos = Array.IndexOf(page, AccessSequanceListBox.Items[counter].ToString());
                    listBox1.Items.Add(tick.ToString() + "===" + pos.ToString());
                    if (tick == pos)
                    {
                        listBox1.Items.Add("pos of value is : " + pos + "mod val :" + tick%12);
                        
                        r[pos] = 1;
                        if (pos == 0)
                        {
                            lblF0.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                            changed = true;

                        }
                        else if (pos == 1)
                        {
                            lblF1.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                            changed = true;
                        }
                        else if (pos == 2)
                        {
                            lblF2.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                            changed = true;
                        }
                        else if (pos == 3)
                        {
                            lblF3.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                            changed = true;
                        }
                        else if (pos == 4)
                        {
                            lblF4.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                            changed = true;
                        }
                        else if (pos == 5)
                        {
                            lblF5.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                            changed = true;
                        }
                        else if (pos == 6)
                        {
                            lblF6.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                            changed = true;

                        }
                        else if (pos == 7)
                        {
                            lblF7.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                            changed = true;
                        }
                        else if (pos == 8)
                        {
                            lblF8.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                            changed = true;
                        }
                        else if (pos == 9)
                        {
                            lblF9.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                            changed = true;
                        }
                        else if (pos == 10)
                        {
                            lblF10.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                            changed = true;
                        }
                        else if (pos == 11)
                        {
                            lblF11.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[pos];
                            changed = true;
                        }
                    }
                    if ((tick == counter-1) && (changed == true))
                    {
                        counter++;
                        pos = 1000;
                        changed = false;
                    }

                }
                else if (page.Contains(AccessSequanceListBox.Items[counter].ToString()) != true)
                {
                    page[tick] = AccessSequanceListBox.Items[counter].ToString();
                    r[tick%12] = 0;
                    if (tick%12 == 0)
                    {
                        lblF0.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick % 12];
                       // tlb[tick % 1200] = AccessSequanceListBox.Items[counter].ToString();
                       newLine += AccessSequanceListBox.Items[counter].ToString() + "/n";
                    }
                    else if (tick%12 == 1)
                    {
                        lblF1.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick % 12];
                        // tlb[tick % 1200] = AccessSequanceListBox.Items[counter].ToString();
                        newLine += AccessSequanceListBox.Items[counter].ToString() + "/n";
                    }
                    else if (tick % 12 == 2)
                    {
                        lblF2.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick % 12];
                        //tlb[tick % 1200] = AccessSequanceListBox.Items[counter].ToString();
                        newLine += AccessSequanceListBox.Items[counter].ToString() + "/n";
                    }
                    else if (tick % 12 == 3)
                    {
                        lblF3.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick % 12];
                        //tlb[tick % 1200] = AccessSequanceListBox.Items[counter].ToString();
                        newLine += AccessSequanceListBox.Items[counter].ToString() + "/n";
                    }
                    else if (tick % 12 == 4)
                    {
                        lblF4.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick % 12];
                        //tlb[tick % 1200] = AccessSequanceListBox.Items[counter].ToString();
                        newLine += AccessSequanceListBox.Items[counter].ToString() + "/n";
                    }
                    else if (tick % 12 == 5)
                    {
                        lblF5.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick % 12];
                        //tlb[tick % 1200] = AccessSequanceListBox.Items[counter].ToString();
                        newLine += AccessSequanceListBox.Items[counter].ToString() + "/n";
                    }
                    else if (tick % 12 == 6)
                    {
                        lblF6.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick % 12];
                        // tlb[tick % 1200] = AccessSequanceListBox.Items[counter].ToString();
                        newLine += AccessSequanceListBox.Items[counter].ToString() + "/n";
                    }
                    else if (tick % 12 == 7)
                    {
                        lblF7.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick % 12];
                        //tlb[tick % 1200] = AccessSequanceListBox.Items[counter].ToString();
                        newLine += AccessSequanceListBox.Items[counter].ToString() + "/n";
                    }
                    else if (tick % 12 == 8)
                    {
                        lblF8.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick % 12];
                        //tlb[tick % 1200] = AccessSequanceListBox.Items[counter].ToString();
                        newLine += AccessSequanceListBox.Items[counter].ToString() + "/n";
                    }
                    else if (tick % 12 == 9)
                    {
                        lblF9.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick % 12];
                        //tlb[tick % 1200] = AccessSequanceListBox.Items[counter].ToString();
                        newLine += AccessSequanceListBox.Items[counter].ToString() + "/n";
                    }
                    else if (tick % 12 == 10)
                    {
                        lblF10.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick % 12];
                        //tlb[tick % 1200] = AccessSequanceListBox.Items[counter].ToString();
                        newLine += AccessSequanceListBox.Items[counter].ToString() + "/n";
                    }
                    else if (tick % 12 == 11)
                    {
                        lblF11.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick % 12];
                        //tlb[tick % 1200] = AccessSequanceListBox.Items[counter].ToString();
                        newLine += AccessSequanceListBox.Items[counter].ToString() + "/n";
                        full = true;

                    }
                    counter++;

                    if (Array.IndexOf(r,null)>-1)
                    {
                        int test = Array.IndexOf(r, 0);
                        if (test > -1)
                        {
                            AccessSequanceListBox.Items[test] = AccessSequanceListBox.Items[counter];
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error no option selected");
                }

                if (full == true)
                {
                    if (page.Contains(AccessSequanceListBox.Items[tick % 12].ToString()) != true)
                    {
                        if (r[tick % 12] == 0)
                        {
                            if(tick%12 == 0)
                            lblF0.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                            if (tick % 12 == 1)
                                lblF1.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                            if (tick % 12 == 2)
                                lblF2.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                            if (tick % 12 == 3)
                                lblF3.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                            if (tick % 12 == 4)
                                lblF4.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                            if (tick % 12 == 5)
                                lblF5.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                            if (tick % 12 == 6)
                                lblF6.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                            if (tick % 12 == 7)
                                lblF7.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                            if (tick % 12 == 8)
                                lblF8.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                            if (tick % 12 == 9)
                                lblF9.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                            if (tick % 12 == 10)
                                lblF10.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                            if (tick % 12 == 11)
                                lblF11.Text = AccessSequanceListBox.Items[counter].ToString() + " || " + r[tick];
                        }
                        else 
                        {
                            r[tick] = 0;
                        }
                    }
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
            //test comment to see if i can commit
        }

        private void Pb_clock_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();

            
        }
    }
}
