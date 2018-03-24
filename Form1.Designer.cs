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
    partial class Form1
    {
        //public Form1()
        
        //{
        //    InitializeComponent();
           
        //}
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Button4 = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.Button();
            this.reserve = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.home_panel = new System.Windows.Forms.Panel();
            this.number = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Addressbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.text_note = new System.Windows.Forms.TextBox();
            this.text_event = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.home_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Button4);
            this.splitContainer1.Panel1.Controls.Add(this.Event);
            this.splitContainer1.Panel1.Controls.Add(this.reserve);
            this.splitContainer1.Panel1.Controls.Add(this.Home);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.home_panel);
            this.splitContainer1.Size = new System.Drawing.Size(1043, 533);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.RosyBrown;
            this.Button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button4.BackgroundImage")));
            this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.Location = new System.Drawing.Point(0, 376);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(184, 157);
            this.Button4.TabIndex = 6;
            this.Button4.Text = "ABOUT US";
            this.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Event
            // 
            this.Event.BackColor = System.Drawing.Color.RosyBrown;
            this.Event.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Event.BackgroundImage")));
            this.Event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Event.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event.Location = new System.Drawing.Point(0, 233);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(184, 144);
            this.Event.TabIndex = 5;
            this.Event.Text = "EVENTS";
            this.Event.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Event.UseVisualStyleBackColor = false;
            this.Event.Click += new System.EventHandler(this.Event_Click);
            // 
            // reserve
            // 
            this.reserve.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.reserve.BackColor = System.Drawing.Color.RosyBrown;
            this.reserve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reserve.BackgroundImage")));
            this.reserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserve.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserve.Location = new System.Drawing.Point(0, 104);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(184, 128);
            this.reserve.TabIndex = 4;
            this.reserve.Text = "RESERVATION";
            this.reserve.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reserve.UseVisualStyleBackColor = false;
            this.reserve.Click += new System.EventHandler(this.reserve_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.RosyBrown;
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(184, 106);
            this.Home.TabIndex = 3;
            this.Home.Text = "HOME";
            this.Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // home_panel
            // 
            this.home_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.home_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_panel.BackgroundImage")));
            this.home_panel.Controls.Add(this.number);
            this.home_panel.Controls.Add(this.label7);
            this.home_panel.Controls.Add(this.Addressbox);
            this.home_panel.Controls.Add(this.label8);
            this.home_panel.Controls.Add(this.datepick);
            this.home_panel.Controls.Add(this.label9);
            this.home_panel.Controls.Add(this.text_note);
            this.home_panel.Controls.Add(this.text_event);
            this.home_panel.Controls.Add(this.text_name);
            this.home_panel.Controls.Add(this.label10);
            this.home_panel.Controls.Add(this.label11);
            this.home_panel.Controls.Add(this.label12);
            this.home_panel.Controls.Add(this.Button2);
            this.home_panel.Location = new System.Drawing.Point(-1, 1);
            this.home_panel.Name = "home_panel";
            this.home_panel.Size = new System.Drawing.Size(854, 530);
            this.home_panel.TabIndex = 1;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(321, 307);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(253, 20);
            this.number.TabIndex = 61;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Contact Number";
            // 
            // Addressbox
            // 
            this.Addressbox.Location = new System.Drawing.Point(321, 274);
            this.Addressbox.Name = "Addressbox";
            this.Addressbox.Size = new System.Drawing.Size(253, 20);
            this.Addressbox.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(193, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "Address";
            // 
            // datepick
            // 
            this.datepick.CustomFormat = "dd-MM-yyyy";
            this.datepick.Location = new System.Drawing.Point(321, 172);
            this.datepick.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.datepick.MinDate = new System.DateTime(2018, 3, 24, 0, 0, 0, 0);
            this.datepick.Name = "datepick";
            this.datepick.Size = new System.Drawing.Size(192, 20);
            this.datepick.TabIndex = 57;
            this.datepick.Value = new System.DateTime(2018, 3, 24, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(196, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Date";
            // 
            // text_note
            // 
            this.text_note.Location = new System.Drawing.Point(318, 345);
            this.text_note.Multiline = true;
            this.text_note.Name = "text_note";
            this.text_note.Size = new System.Drawing.Size(256, 140);
            this.text_note.TabIndex = 55;
            // 
            // text_event
            // 
            this.text_event.Location = new System.Drawing.Point(321, 244);
            this.text_event.Name = "text_event";
            this.text_event.Size = new System.Drawing.Size(253, 20);
            this.text_event.TabIndex = 54;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(321, 207);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(253, 20);
            this.text_name.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(196, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(193, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "Name of Event:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(193, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "Name";
            // 
            // Button2
            // 
            this.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.Button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button2.BackgroundImage")));
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(386, 34);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(158, 106);
            this.Button2.TabIndex = 32;
            this.Button2.Text = "Reserve";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 533);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.home_panel.ResumeLayout(false);
            this.home_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        internal Button Button4;
        internal Button Event;
        internal Button reserve;
        internal Button Home;
        private Panel home_panel;
        internal Button Button2;
        internal TextBox number;
        internal Label label7;
        internal TextBox Addressbox;
        internal Label label8;
        private DateTimePicker datepick;
        internal Label label9;
        internal TextBox text_note;
        internal TextBox text_event;
        internal TextBox text_name;
        internal Label label10;
        internal Label label11;
        internal Label label12;

    }
}

