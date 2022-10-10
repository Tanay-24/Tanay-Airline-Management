namespace My_AirLine_2
{
    partial class View_Pilot
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
            this.Gendcb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.natcb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PilotID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PpassTb = new System.Windows.Forms.TextBox();
            this.PilotAddTb = new System.Windows.Forms.TextBox();
            this.PilotNameTb = new System.Windows.Forms.TextBox();
            this.PphoneTb = new System.Windows.Forms.TextBox();
            this.PilotDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PilotDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(310, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "View Pilot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(287, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tanay AirLine";
            // 
            // Gendcb
            // 
            this.Gendcb.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gendcb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Gendcb.FormattingEnabled = true;
            this.Gendcb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHER"});
            this.Gendcb.Location = new System.Drawing.Point(519, 262);
            this.Gendcb.Name = "Gendcb";
            this.Gendcb.Size = new System.Drawing.Size(201, 30);
            this.Gendcb.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(394, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 26);
            this.label8.TabIndex = 55;
            this.label8.Text = "Gender";
            // 
            // natcb
            // 
            this.natcb.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natcb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.natcb.FormattingEnabled = true;
            this.natcb.Items.AddRange(new object[] {
            "Afghan\t",
            "Albanian\t",
            "Algerian\t",
            "American",
            "Andorran\t",
            "Angolan\t",
            "Anguillan\t",
            "Citizen of Antigua and Barbuda",
            "Argentine\t",
            "Armenian\t",
            "Australian\t",
            "Austrian",
            "Azerbaijani",
            "Bahamian\t",
            "Bahraini\t",
            "Bangladeshi\t",
            "Barbadian",
            "Belarusian\t",
            "Belgian\t",
            "Belizean\t",
            "Beninese",
            "Bermudian\t",
            "Bhutanese\t",
            "Bolivian\t",
            "Citizen of Bosnia and Herzegovina",
            "Botswanan\t",
            "Brazilian\t",
            "British\t",
            "British Virgin Islander",
            "Bruneian\t",
            "Bulgarian\t",
            "Burkinan\t",
            "Burmese",
            "Burundian",
            "Cambodian\t",
            "Cameroonian\t",
            "Canadian\t",
            "Cape Verdean",
            "Cayman Islander\t",
            "Central African\t",
            "Chadian\t",
            "Chilean",
            "Chinese\t",
            "Colombian\t",
            "Comoran\tCongolese (Congo)",
            "Congolese (DRC)\t",
            "Cook Islander\t",
            "Costa Rican\t",
            "Croatian",
            "Cuban\t",
            "Cymraes\t",
            "Cymro\t",
            "Cypriot",
            "Czech",
            "Danish\t",
            "Djiboutian\tDominican\t",
            "Citizen of the Dominican Republic",
            "Dutch",
            "East Timorese\t",
            "Ecuadorean\t",
            "Egyptian\t",
            "Emirati",
            "English\t",
            "Equatorial Guinean\t",
            "Eritrean\t",
            "Estonian",
            "Ethiopian",
            "Faroese\t",
            "Fijian\t",
            "Filipino\t",
            "Finnish",
            "French",
            "Gabonese\tGambian\t",
            "Georgian\tGerman",
            "Ghanaian\tGibraltarian\t",
            "Greek\t",
            "Greenlandic",
            "Grenadian\tGuamanian\t",
            "Guatemalan\t",
            "Citizen of Guinea-Bissau",
            "Guinean\t",
            "Guyanese",
            "Haitian\t",
            "Honduran\tHong Konger\t",
            "Hungarian",
            "Icelandic\tIndian\t",
            "Indonesian\t",
            "Iranian",
            "Iraqi\t",
            "Irish\t",
            "Israeli\t",
            "Italian",
            "Ivorian",
            "Jamaican\t",
            "Japanese\t",
            "Jordanian",
            "Kazakh\t",
            "Kenyan\t",
            "Kittitian\t",
            "Citizen of Kiribati",
            "Kosovan\t",
            "Kuwaiti\t",
            "Kyrgyz",
            "Lao\t",
            "Latvian\t",
            "Lebanese\t",
            "Liberian",
            "Libyan\t",
            "Liechtenstein citizen\t",
            "Lithuanian\t",
            "Luxembourger",
            "Macanese\t",
            "Macedonian\t",
            "Malagasy\t",
            "Malawian",
            "Malaysian\t",
            "Maldivian\t",
            "Malian\t",
            "Maltese",
            "Marshallese\t",
            "Martiniquais\t",
            "Mauritanian\t",
            "Mauritian",
            "Mexican\t",
            "Micronesian\t",
            "Moldovan",
            "Monegasque",
            "Mongolian\t",
            "Montenegrin\t",
            "Montserratian\t",
            "Moroccan",
            "Mosotho\t",
            "Mozambican",
            "Namibian\t",
            "Nauruan\t",
            "Nepalese\t",
            "New Zealander",
            "Nicaraguan",
            "Nigerian\t",
            "Niuean",
            "North Korean\t\t",
            "Northern Irish\t",
            "Norwegian",
            "Omani",
            "Pakistani\t",
            "Palauan\t",
            "Palestinian\t",
            "Panamanian",
            "Papua New Guinean\t",
            "Paraguayan\t",
            "Peruvian\t",
            "Pitcairn Islander",
            "Polish\t",
            "Portuguese\t",
            "Prydeinig\t",
            "Puerto Rican",
            "Qatari",
            "Romanian\t",
            "Russian\t",
            "Rwandan",
            "Salvadorean\t",
            "Sammarinese\t",
            "Samoan\t",
            "Sao Tomean",
            "Saudi Arabian\t",
            "Scottish\t",
            "Senegalese\t",
            "Serbian",
            "Citizen of Seychelles\t",
            "Sierra Leonean\t",
            "Singaporean\t",
            "Slovak",
            "Slovenian\t",
            "Solomon Islander\t",
            "Somali\t",
            "South African",
            "South Korean\t",
            "South Sudanese\t",
            "Spanish\t",
            "Sri Lankan",
            "St Helenian\t",
            "St Lucian\tStateless\t",
            "Sudanese",
            "Surinamese\t",
            "Swazi\t",
            "Swedish\t",
            "Swiss",
            "Syrian",
            "Taiwanese\t",
            "Tajik\t",
            "Tanzanian\t",
            "Thai",
            "Togolese\t",
            "Tongan\t",
            "Trinidadian\t",
            "Tristanian",
            "Tunisian\t",
            "Turkish\t",
            "Turkmen\t",
            "Turks and Caicos Islander",
            "Tuvaluan",
            "Ugandan\t",
            "Ukrainian\t",
            "Uruguayan\t",
            "Uzbek",
            "Vatican citizen\t",
            "Citizen of Vanuatu\t",
            "Venezuelan\t",
            "Vietnamese",
            "Vincentian",
            "Wallisian\t",
            "Welsh",
            "Yemeni",
            "Zambian\t",
            "Zimbabwean"});
            this.natcb.Location = new System.Drawing.Point(156, 258);
            this.natcb.Name = "natcb";
            this.natcb.Size = new System.Drawing.Size(197, 30);
            this.natcb.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(13, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 26);
            this.label7.TabIndex = 53;
            this.label7.Text = "Nationality";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(393, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 32);
            this.label6.TabIndex = 51;
            this.label6.Text = "Address";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 32);
            this.label4.TabIndex = 49;
            this.label4.Text = "Passport";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(393, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 32);
            this.label5.TabIndex = 47;
            this.label5.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 46;
            this.label3.Text = "Pilot ID";
            // 
            // PilotID
            // 
            this.PilotID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.PilotID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PilotID.Location = new System.Drawing.Point(152, 131);
            this.PilotID.Multiline = true;
            this.PilotID.Name = "PilotID";
            this.PilotID.Size = new System.Drawing.Size(201, 32);
            this.PilotID.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(227, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 26);
            this.label9.TabIndex = 58;
            this.label9.Text = "Phone";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkOrange;
            this.button4.Location = new System.Drawing.Point(572, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 48);
            this.button4.TabIndex = 62;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(253, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 48);
            this.button3.TabIndex = 61;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(411, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 48);
            this.button2.TabIndex = 60;
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
            this.button1.Location = new System.Drawing.Point(96, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 48);
            this.button1.TabIndex = 59;
            this.button1.Text = "Update ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PpassTb
            // 
            this.PpassTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.PpassTb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PpassTb.Location = new System.Drawing.Point(156, 197);
            this.PpassTb.Multiline = true;
            this.PpassTb.Name = "PpassTb";
            this.PpassTb.Size = new System.Drawing.Size(197, 32);
            this.PpassTb.TabIndex = 63;
            // 
            // PilotAddTb
            // 
            this.PilotAddTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.PilotAddTb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PilotAddTb.Location = new System.Drawing.Point(519, 197);
            this.PilotAddTb.Multiline = true;
            this.PilotAddTb.Name = "PilotAddTb";
            this.PilotAddTb.Size = new System.Drawing.Size(201, 32);
            this.PilotAddTb.TabIndex = 64;
            // 
            // PilotNameTb
            // 
            this.PilotNameTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.PilotNameTb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PilotNameTb.Location = new System.Drawing.Point(519, 131);
            this.PilotNameTb.Multiline = true;
            this.PilotNameTb.Name = "PilotNameTb";
            this.PilotNameTb.Size = new System.Drawing.Size(201, 32);
            this.PilotNameTb.TabIndex = 65;
            // 
            // PphoneTb
            // 
            this.PphoneTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.PphoneTb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PphoneTb.Location = new System.Drawing.Point(316, 314);
            this.PphoneTb.Multiline = true;
            this.PphoneTb.Name = "PphoneTb";
            this.PphoneTb.Size = new System.Drawing.Size(197, 32);
            this.PphoneTb.TabIndex = 66;
            // 
            // PilotDGV
            // 
            this.PilotDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PilotDGV.Location = new System.Drawing.Point(12, 422);
            this.PilotDGV.Name = "PilotDGV";
            this.PilotDGV.Size = new System.Drawing.Size(800, 221);
            this.PilotDGV.TabIndex = 67;
            this.PilotDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PilotDGV_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 662);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 19);
            this.panel1.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 19);
            this.panel2.TabIndex = 69;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(824, 19);
            this.panel3.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(776, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 35);
            this.label10.TabIndex = 101;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // View_Pilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 681);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PilotDGV);
            this.Controls.Add(this.PphoneTb);
            this.Controls.Add(this.PilotNameTb);
            this.Controls.Add(this.PilotAddTb);
            this.Controls.Add(this.PpassTb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Gendcb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.natcb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PilotID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_Pilot";
            this.Text = "View_Pilot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_Pilot_FormClosing);
            this.Load += new System.EventHandler(this.View_Pilot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PilotDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Gendcb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox natcb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PilotID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PpassTb;
        private System.Windows.Forms.TextBox PilotAddTb;
        private System.Windows.Forms.TextBox PilotNameTb;
        private System.Windows.Forms.TextBox PphoneTb;
        private System.Windows.Forms.DataGridView PilotDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
    }
}