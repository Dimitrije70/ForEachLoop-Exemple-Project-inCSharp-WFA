using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Each_Loop_inside_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            runLoop();
        }

        public void runLoop()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button)
                {
                    x.BackColor = Color.Black;
                    x.ForeColor = Color.White;
                }

                if (x is Label)
                {
                    x.ForeColor = Color.DarkBlue;
                }

                if (x is PictureBox && (string)x.Tag == "group1")
                {
                    x.BackColor = Color.PaleVioletRed;
                }

                if (x is PictureBox && (string)x.Tag == "group2")
                {
                    x.BackColor = Color.LightBlue;
                }
            }
        }
    }
}
