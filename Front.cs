using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DARES1
{
    public partial class Front : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public Front()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Krizza Mae\\Documents\\Visual Studio 2010\\Projects\\DARES1\\DARES1\\dares1.accdb;
                                        Persist Security Info=False;";

        }

        private void Home_Click(object sender, EventArgs e)
        {
            
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            Form1 reserve = new Form1();
            reserve.Show();
            this.Hide();

        }

        private void Event_Click(object sender, EventArgs e)
        {
            Form2 even = new Form2();
            even.Show();
            this.Hide();
        }
   



      
    }
}
