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
    public partial class Form1 : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Krizza Mae\\Documents\\Visual Studio 2010\\Projects\\DARES1\\DARES1\\dares1.accdb;
                                        Persist Security Info=False;";

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                command.CommandText = "insert into client (Name,Address,number,Event,notes,Sched) values ('" + text_name.Text + "'," + Addressbox.Text + "','" + text_event.Text + "','" + text_note.Text + "','" + datepick.Text + "')";
                
                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Front menu = new Front();
            menu.Show();
            Hide();
        }

        private void reserve_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

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

        private void Home_Click(object sender, EventArgs e)
        {
            Front front = new Front();
            front.Show();
            this.Hide();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                command.CommandText = "insert into client (Name,Address,Contact_num,Eventtype,notes,Sched,Reserved) values ('" + text_name.Text + "','" + Addressbox.Text + "','" + number.Text + "','" + text_event.Text + "','" + text_note.Text + "','" + datepick.Text + "','Yes ')";

                command.ExecuteNonQuery();
                Save save = new Save();
                save.Show();
                text_name.Clear();
                text_event.Clear();
                text_note.Clear();
                Addressbox.Clear();
                number.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch !=8 && ch !=46)
            {
                e.Handled = true;
            }
        }

 

      

       


    }
}
