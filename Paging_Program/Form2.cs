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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            
            Random rnd = new Random();
            

            for (int i = 0; i < 12; i++)
            {
                int num = rnd.Next(1000);
                listBox1.Items.Add("1" + "/t" + frm.tlb[i] + num );
               
            }

        }
    }
}
