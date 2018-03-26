using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DARES1
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Front fr = new Front();
            fr.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Event_Click(object sender, EventArgs e)
        {
            Form2 even = new Form2();
            even.Show();
            this.Hide();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void reserve_Click(object sender, EventArgs e)
        {
            Form1 even = new Form1();
            even.Show();
            this.Hide();
        }



    }
}
