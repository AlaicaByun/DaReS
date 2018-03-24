namespace DARES1
{
    partial class Front
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Front));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Button4 = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.Button();
            this.reserve = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.home_panel = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
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
            this.splitContainer1.TabIndex = 0;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.RosyBrown;
            this.Button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button4.BackgroundImage")));
            this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.Location = new System.Drawing.Point(0, 402);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(184, 131);
            this.Button4.TabIndex = 6;
            this.Button4.Text = "ABOUT US";
            this.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button4.UseVisualStyleBackColor = false;
            // 
            // Event
            // 
            this.Event.BackColor = System.Drawing.Color.RosyBrown;
            this.Event.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Event.BackgroundImage")));
            this.Event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Event.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event.Location = new System.Drawing.Point(0, 261);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(184, 141);
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
            this.reserve.Location = new System.Drawing.Point(0, 118);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(184, 142);
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
            this.Home.Size = new System.Drawing.Size(184, 120);
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
            this.home_panel.Controls.Add(this.label2);
            this.home_panel.Controls.Add(this.Label1);
            this.home_panel.Location = new System.Drawing.Point(-1, 1);
            this.home_panel.Name = "home_panel";
            this.home_panel.Size = new System.Drawing.Size(854, 530);
            this.home_panel.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Buxton Sketch", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(301, 178);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(290, 119);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "DaReS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y o u r  p e r s o n a l   d a t e   r e s e r v a t i o n   s y s t e m . ";
            // 
            // Front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 533);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Front";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Front";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.home_panel.ResumeLayout(false);
            this.home_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.Button Home;
        internal System.Windows.Forms.Button reserve;
        internal System.Windows.Forms.Button Event;
        internal System.Windows.Forms.Button Button4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel home_panel;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
    }
}