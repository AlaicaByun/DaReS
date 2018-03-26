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
    public partial class Form2 : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public Form2()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Krizza Mae\\Documents\\Visual Studio 2010\\Projects\\DARES1\\DARES1\\dares1.accdb;
                                        Persist Security Info=False;";
        }

        private void Updatebut_Click(object sender, EventArgs e)
        {

        }

        private void view_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Event_Click(object sender, EventArgs e)
        {
            Form2 even = new Form2();
            even.Show();
            this.Hide();
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            Form1 reserve = new Form1();
            reserve.Show();
            this.Hide();

        }

        private void load_tb_Click(object sender, EventArgs e)
        {
            try
            {

                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                string query = "select ID,Name,Address,Contact_num,Eventtype,notes,Sched from client where reserved='Yes'";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void Updatebut_Click_1(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                string query = "update client set Name='" + text_name.Text + "' ,Address= '" + addressbox.Text + "' ,Contact_num= '" + number.Text + "' ,Eventtype= '" + text_event.Text + "' ,notes= '" + text_note.Text + "' ,Sched= '" + datepick.Text + "' where ID=" + id_box.Text + "";
                command.CommandText = query;
               // MessageBox.Show(query);
                command.ExecuteNonQuery();
                EditSave save = new EditSave();
                save.Show();
                text_name.Clear();
                text_event.Clear();
                addressbox.Clear();
                number.Clear();
                text_note.Clear();
                id_box.Clear();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                string query = "update client set reserved='No' where ID=" + delete_id.Text + "";
                command.CommandText = query;
               // MessageBox.Show(query);
                command.ExecuteNonQuery();
                delete save = new delete();
                save.Show();

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }



        private void Button4_Click(object sender, EventArgs e)
        {
            Calendar even = new Calendar();
            even.Show();
            this.Hide();
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void id_box_KeyPress(object sender, KeyPressEventArgs ep)
        {
            char hu = ep.KeyChar;
            if (!Char.IsDigit(hu) && hu != 8 && hu != 46)
            {
                ep.Handled = true;
            }
        }

        private void delete_id_KeyPress(object sender, KeyPressEventArgs el)
        {
            char hu = el.KeyChar;
            if (!Char.IsDigit(hu) && hu != 8 && hu != 46)
            {
                el.Handled = true;
            }
        }


    }
}
