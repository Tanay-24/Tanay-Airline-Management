using System;

namespace My_AirLine_2
{
    partial class Ticktes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PNameTb = new System.Windows.Forms.TextBox();
            this.FcodeCb = new System.Windows.Forms.ComboBox();
            this.PIdCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PpassTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PNatTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PAmtTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TicketDGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(293, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 34);
            this.label2.TabIndex = 48;
            this.label2.Text = "Pilot Duty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(276, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 35);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tanay AirLine";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(333, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 26);
            this.label9.TabIndex = 79;
            this.label9.Text = "Flight Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 81;
            this.label3.Text = "Duty ID";
            // 
            // TId
            // 
            this.TId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.TId.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TId.Location = new System.Drawing.Point(130, 140);
            this.TId.Multiline = true;
            this.TId.Name = "TId";
            this.TId.Size = new System.Drawing.Size(163, 31);
            this.TId.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 83;
            this.label4.Text = "Pilot ID";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(374, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 85;
            this.label5.Text = "Name";
            // 
            // PNameTb
            // 
            this.PNameTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.PNameTb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PNameTb.Location = new System.Drawing.Point(481, 193);
            this.PNameTb.Multiline = true;
            this.PNameTb.Name = "PNameTb";
            this.PNameTb.Size = new System.Drawing.Size(231, 31);
            this.PNameTb.TabIndex = 84;
            this.PNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FcodeCb
            // 
            this.FcodeCb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FcodeCb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FcodeCb.FormattingEnabled = true;
            this.FcodeCb.Location = new System.Drawing.Point(481, 139);
            this.FcodeCb.Name = "FcodeCb";
            this.FcodeCb.Size = new System.Drawing.Size(231, 31);
            this.FcodeCb.TabIndex = 86;
            // 
            // PIdCb
            // 
            this.PIdCb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIdCb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PIdCb.FormattingEnabled = true;
            this.PIdCb.Location = new System.Drawing.Point(130, 198);
            this.PIdCb.Name = "PIdCb";
            this.PIdCb.Size = new System.Drawing.Size(208, 31);
            this.PIdCb.TabIndex = 87;
            this.PIdCb.SelectionChangeCommitted += new System.EventHandler(this.PIdCb_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(12, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 26);
            this.label6.TabIndex = 89;
            this.label6.Text = "Passport";
            // 
            // PpassTb
            // 
            this.PpassTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.PpassTb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PpassTb.Location = new System.Drawing.Point(130, 247);
            this.PpassTb.Multiline = true;
            this.PpassTb.Name = "PpassTb";
            this.PpassTb.Size = new System.Drawing.Size(208, 31);
            this.PpassTb.TabIndex = 88;
            this.PpassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(365, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 26);
            this.label7.TabIndex = 91;
            this.label7.Text = "Nationality";
            // 
            // PNatTb
            // 
            this.PNatTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.PNatTb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PNatTb.Location = new System.Drawing.Point(508, 242);
            this.PNatTb.Multiline = true;
            this.PNatTb.Name = "PNatTb";
            this.PNatTb.Size = new System.Drawing.Size(214, 31);
            this.PNatTb.TabIndex = 90;
            this.PNatTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkOrange;
            this.label11.Location = new System.Drawing.Point(92, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 26);
            this.label11.TabIndex = 95;
            this.label11.Text = "Trip Pay Amount";
            // 
            // PAmtTb
            // 
            this.PAmtTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.PAmtTb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PAmtTb.Location = new System.Drawing.Point(299, 301);
            this.PAmtTb.Multiline = true;
            this.PAmtTb.Name = "PAmtTb";
            this.PAmtTb.Size = new System.Drawing.Size(214, 31);
            this.PAmtTb.TabIndex = 94;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label12.Location = new System.Drawing.Point(332, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 32);
            this.label12.TabIndex = 96;
            this.label12.Text = "Bookings";
            // 
            // TicketDGV
            // 
            this.TicketDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDGV.Location = new System.Drawing.Point(12, 464);
            this.TicketDGV.Name = "TicketDGV";
            this.TicketDGV.Size = new System.Drawing.Size(788, 195);
            this.TicketDGV.TabIndex = 97;
            this.TicketDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkOrange;
            this.button4.Location = new System.Drawing.Point(481, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 48);
            this.button4.TabIndex = 100;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(330, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 48);
            this.button2.TabIndex = 99;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(178, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 48);
            this.button1.TabIndex = 98;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 19);
            this.panel3.TabIndex = 101;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 665);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 19);
            this.panel2.TabIndex = 102;
            // 
            // Ticktes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TicketDGV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PAmtTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PNatTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PpassTb);
            this.Controls.Add(this.PIdCb);
            this.Controls.Add(this.FcodeCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PNameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ticktes";
            this.Text = "Ticktes";
            this.Load += new System.EventHandler(this.Ticktes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PNameTb;
        private System.Windows.Forms.ComboBox FcodeCb;
        private System.Windows.Forms.ComboBox PIdCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PpassTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PNatTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PAmtTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView TicketDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}