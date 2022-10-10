namespace My_AirLine_2
{
    partial class FlightTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightTable));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FcodeTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SeatNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Fsrc = new System.Windows.Forms.ComboBox();
            this.FDest = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(206, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tanay AirLine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(163, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Record New Flights";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FcodeTb
            // 
            this.FcodeTb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FcodeTb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FcodeTb.Location = new System.Drawing.Point(257, 188);
            this.FcodeTb.Multiline = true;
            this.FcodeTb.Name = "FcodeTb";
            this.FcodeTb.Size = new System.Drawing.Size(188, 35);
            this.FcodeTb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Flight Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(12, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 34);
            this.label4.TabIndex = 12;
            this.label4.Text = "Num. of seats";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // SeatNum
            // 
            this.SeatNum.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.SeatNum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SeatNum.Location = new System.Drawing.Point(257, 463);
            this.SeatNum.Multiline = true;
            this.SeatNum.Name = "SeatNum";
            this.SeatNum.Size = new System.Drawing.Size(188, 29);
            this.SeatNum.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 34);
            this.label5.TabIndex = 14;
            this.label5.Text = "Source ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(12, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "Destination";
            // 
            // Fsrc
            // 
            this.Fsrc.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.Fsrc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Fsrc.FormattingEnabled = true;
            this.Fsrc.Items.AddRange(new object[] {
            "Veer Savarkar International Airport,Port Blair,Andaman and Nicobar Islands",
            "Visakhapatnam Airport,Visakhapatnam,Andhra Pradesh",
            "Rajiv Gandhi International Airport,Hyderabad,Telangana",
            "Lokpriya Gopinath Bordoloi International Airport,Guwahati,Assam",
            "Indira Gandhi International Airport,New Delhi,Delhi",
            "Dabolim Airport (Goa International Airport),Dabolim (Village)he,Goa",
            "Sardar Vallabhbhai Patel International Airport,Ahmedabad,Gujarat",
            "Kempegowda International Airport,Bengaluru,Karnataka",
            "Mangalore International Airport,Mangalore,Karnataka",
            "Cochin International Airport,Kochi,Kerala",
            "Calicut International Airport,Kozhikode,Kerala",
            "Trivandrum International Airport,Thiruvananthapuram,Kerala",
            "Chhatrapati Shivaji International Airport,Mumbai,Maharashtra",
            "Dr. Babasaheb Ambedkar International Airport,Nagpur,Maharashtra",
            "Tulihal Airport,Imphal,Manipur",
            "Biju Patnaik International Airport,Bhubaneswar,Odisha",
            "Sri Guru Ram Dass Jee International Airport,Amritsar,Punjab",
            "Jaipur International Airport,Jaipur,Rajasthan",
            "Chennai International Airport,Chennai,Tamil Nadu",
            "Coimbatore International Airport,Coimbatore,Tamil Nadu",
            "Tiruchirapalli International Airport,Tiruchirapalli,Tamil Nadu",
            "Chaudhary Charan Singh Airport,Lucknow,Uttar Pradesh",
            "Lal Bahadur Shastri Airport,Varanasi,Uttar Pradesh",
            "Netaji Subhash Chandra Bose International Airport,Kolkata,West Bengal",
            "Gaya Airport,Gaya,Bihar",
            "Surat International Airport,Surat\t,Gujarat",
            "Vadodara International Airport,Vadodara,Gujarat",
            "Sheikh ul-Alam International Airport,Srinagar,Jammu & Kashmir",
            "Kannur International Airport,Kannur,Kerala",
            "Pune International Airport,Pune\t,Maharashtra",
            "Birsa Munda Airport,Ranchi,Jharkhand",
            "Bagdogra Airport,Siliguri,West Bengal",
            "Gelephu,VQGP,Gelephu Airport",
            "Jakar,VQBT,Bathpalathang Airport",
            "Paro,VQPR,Paro International Airport",
            "Trashigang,VQTY,Yongphulla Airport (Yonphula Airport)",
            "Tribhuvan International Airport, Kathmandu",
            " Lukla Airport (Tenzing Hillary Airport)",
            " Pokhara Airport,Nepal",
            "Simara Airport,Nepal",
            "Bharatpur Airport,Nepal",
            "Biratnagar Airport,Nepal",
            "Surkhet Airport,Nepal",
            "Nepalgunj Airport,Nepal",
            "Jomsom Airport,Nepal ",
            "Bajura Airport,Nepal",
            "Bandaranaike International Airport, CMB,Sri Lanka",
            "Ratmalana Airport,RML,Sri Lanka",
            "Mattala Rajapaksa International Airport,HRI,Sri Lanka",
            "Anuradhapura Airport,ACJ,Sri Lanka",
            " Sigiriya Airport (Dambulla),GIU,Sri Lanka",
            "Koggala Airport (Galle),KCT,Sri Lanka",
            "Kansai International Airport (Osaka)",
            "Narita International Airport (Chiba, nearby Tokyo)",
            "Chūbu Centrair International Airport (Aichi)",
            "Tokyo International Airport (Tokyo)",
            "Osaka International Airport (Osaka/Hyōgo)",
            "Akita Airport (Akita)",
            "Asahikawa Airport (Hokkaidō)",
            "New Chitose Airport (Hokkaidō)",
            "Fukuoka Airport (Fukuoka )",
            "Hakodate Airport (Hokkaidō)",
            "Yamagata Airport (Yamagata)",
            "Kagoshima Airport (Kagoshima)",
            "Kitakyūshū Airport (Fukuoka)",
            "Oita Airport (Ōita)",
            "Kushiro Airport (Hokkaidō)",
            "Kumamoto Airport (Kumamoto )",
            "Matsuyama Airport (Ehime)",
            "Hiroshima Airport (Hiroshima)",
            "Miyazaki Airport (Miyazaki)",
            "Naha Airport / Naha Air Base (Okinawa)",
            "Kōchi Airport (Kōchi)",
            "Sendai Airport (Miyagi)",
            "Niigata Airport (Niigata)",
            "Tokachi-Obihiro Airport (Hokkaidō)",
            "Nagasaki Airport (Nagasaki)",
            "Takamatsu Airport (Kagawa)",
            "Yamaguchi Ube Airport (Yamaguchi)",
            "Wakkanai Airport (Hokkaidō)",
            "Yao Airport (Osaka)",
            "Kansai International Airport (Osaka)",
            "Narita International Airport (Chiba, nearby Tokyo)",
            "Chūbu Centrair International Airport (Aichi)",
            "Tokyo International Airport (Tokyo)",
            "Osaka International Airport (Osaka/Hyōgo)",
            "SGI,Mushaf Air Force Base,Sargodha\t",
            "WNS,OPNH,Nawabshah Airport,Nawabshah\t",
            "PJG,OPPG\t,Panjgur Airport,Panjgur\t",
            "UET,OPQT,Quetta Airport,Quetta\t",
            "RYK,OPRK\t,Rahim Yar Khan Airport,Rahim Yar Khan\t",
            "RZS,OPSW,Sawan Airport,Sawan\t",
            "SKT,Sialkot Airport,Sialkot\t",
            "KDU,OPSD,Skardu Airport,Skardu\t",
            "SUL,OPSU,Sui Airport,Sui\t",
            "SKZ,OPSK,Sukkur Airport,Sukkur\t",
            "TUK,OPTU,Turbat Airport,Turbat\t",
            "ZIZ,Zamzama Heliport,Dadu\t",
            "PZH,OPZB,Zhob Airport,Zhob\t",
            "AAW,Abbottabad Airport,Abbottabad\t",
            "ATG,Attock Airport,Attock\t",
            "WGB,Bahawalnagar Airport,Bahawalnagar\t",
            "BNP,OPBN,Bannu Airport,Bannu\t",
            "BHW,Bhagatanwala Airport,Sargodha\t",
            "BHC,Bhurban Heliport,Bhurban\t",
            "CWP,Campbellpore Airport,Campbellpore\t",
            "CHB,Chilas Airport,Chilas\t",
            "GRT,Gujrat Airport,Gujrat\t",
            "JAG,OPJA,Jacobabad Airport,Jacobabad\t",
            "JIW,OPJI,Jiwani Airport,Jiwani\t",
            "KDD,OPKH,Khuzdar Airport,Khuzdar\t",
            "OHT,Kohat Airport,Kohat\t",
            "LRG,Lora Lai Airport,Lora Lai\t",
            "HRA,Mansehra Airport,Mansehra\t",
            "MWD,Mianwali Airport,Mianwali\t",
            "MPD,Mirpur Khas Airport,Mirpur Khas\t",
            "MFG,OPMF,Muzaffarabad Airport,Muzaffarabad\t",
            "NHS,Nushki Airport,Nushki\t",
            "ORW,OPOR,Ormara Airport,Ormara"});
            this.Fsrc.Location = new System.Drawing.Point(212, 266);
            this.Fsrc.Name = "Fsrc";
            this.Fsrc.Size = new System.Drawing.Size(233, 31);
            this.Fsrc.TabIndex = 16;
            // 
            // FDest
            // 
            this.FDest.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FDest.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FDest.FormattingEnabled = true;
            this.FDest.Items.AddRange(new object[] {
            "Veer Savarkar International Airport,Port Blair,Andaman and Nicobar Islands",
            "Visakhapatnam Airport,Visakhapatnam,Andhra Pradesh",
            "Rajiv Gandhi International Airport,Hyderabad,Telangana",
            "Lokpriya Gopinath Bordoloi International Airport,Guwahati,Assam",
            "Indira Gandhi International Airport,New Delhi,Delhi",
            "Dabolim Airport (Goa International Airport),Dabolim (Village)he,Goa",
            "Sardar Vallabhbhai Patel International Airport,Ahmedabad,Gujarat",
            "Kempegowda International Airport,Bengaluru,Karnataka",
            "Mangalore International Airport,Mangalore,Karnataka",
            "Cochin International Airport,Kochi,Kerala",
            "Calicut International Airport,Kozhikode,Kerala",
            "Trivandrum International Airport,Thiruvananthapuram,Kerala",
            "Chhatrapati Shivaji International Airport,Mumbai,Maharashtra",
            "Dr. Babasaheb Ambedkar International Airport,Nagpur,Maharashtra",
            "Tulihal Airport,Imphal,Manipur",
            "Biju Patnaik International Airport,Bhubaneswar,Odisha",
            "Sri Guru Ram Dass Jee International Airport,Amritsar,Punjab",
            "Jaipur International Airport,Jaipur,Rajasthan",
            "Chennai International Airport,Chennai,Tamil Nadu",
            "Coimbatore International Airport,Coimbatore,Tamil Nadu",
            "Tiruchirapalli International Airport,Tiruchirapalli,Tamil Nadu",
            "Chaudhary Charan Singh Airport,Lucknow,Uttar Pradesh",
            "Lal Bahadur Shastri Airport,Varanasi,Uttar Pradesh",
            "Netaji Subhash Chandra Bose International Airport,Kolkata,West Bengal",
            "Gaya Airport,Gaya,Bihar",
            "Surat International Airport,Surat\t,Gujarat",
            "Vadodara International Airport,Vadodara,Gujarat",
            "Sheikh ul-Alam International Airport,Srinagar,Jammu & Kashmir",
            "Kannur International Airport,Kannur,Kerala",
            "Pune International Airport,Pune\t,Maharashtra",
            "Birsa Munda Airport,Ranchi,Jharkhand",
            "Bagdogra Airport,Siliguri,West Bengal",
            "Gelephu,VQGP,Gelephu Airport",
            "Jakar,VQBT,Bathpalathang Airport",
            "Paro,VQPR,Paro International Airport",
            "Trashigang,VQTY,Yongphulla Airport (Yonphula Airport)",
            "Tribhuvan International Airport, Kathmandu",
            " Lukla Airport (Tenzing Hillary Airport)",
            " Pokhara Airport,Nepal",
            "Simara Airport,Nepal",
            "Bharatpur Airport,Nepal",
            "Biratnagar Airport,Nepal",
            "Surkhet Airport,Nepal",
            "Nepalgunj Airport,Nepal",
            "Jomsom Airport,Nepal ",
            "Bajura Airport,Nepal",
            "Bandaranaike International Airport, CMB,Sri Lanka",
            "Ratmalana Airport,RML,Sri Lanka",
            "Mattala Rajapaksa International Airport,HRI,Sri Lanka",
            "Anuradhapura Airport,ACJ,Sri Lanka",
            " Sigiriya Airport (Dambulla),GIU,Sri Lanka",
            "Koggala Airport (Galle),KCT,Sri Lanka",
            "Kansai International Airport (Osaka)",
            "Narita International Airport (Chiba, nearby Tokyo)",
            "Chūbu Centrair International Airport (Aichi)",
            "Tokyo International Airport (Tokyo)",
            "Osaka International Airport (Osaka/Hyōgo)",
            "Akita Airport (Akita)",
            "Asahikawa Airport (Hokkaidō)",
            "New Chitose Airport (Hokkaidō)",
            "Fukuoka Airport (Fukuoka )",
            "Hakodate Airport (Hokkaidō)",
            "Yamagata Airport (Yamagata)",
            "Kagoshima Airport (Kagoshima)",
            "Kitakyūshū Airport (Fukuoka)",
            "Oita Airport (Ōita)",
            "Kushiro Airport (Hokkaidō)",
            "Kumamoto Airport (Kumamoto )",
            "Matsuyama Airport (Ehime)",
            "Hiroshima Airport (Hiroshima)",
            "Miyazaki Airport (Miyazaki)",
            "Naha Airport / Naha Air Base (Okinawa)",
            "Kōchi Airport (Kōchi)",
            "Sendai Airport (Miyagi)",
            "Niigata Airport (Niigata)",
            "Tokachi-Obihiro Airport (Hokkaidō)",
            "Nagasaki Airport (Nagasaki)",
            "Takamatsu Airport (Kagawa)",
            "Yamaguchi Ube Airport (Yamaguchi)",
            "Wakkanai Airport (Hokkaidō)",
            "Yao Airport (Osaka)",
            "Kansai International Airport (Osaka)",
            "Narita International Airport (Chiba, nearby Tokyo)",
            "Chūbu Centrair International Airport (Aichi)",
            "Tokyo International Airport (Tokyo)",
            "Osaka International Airport (Osaka/Hyōgo)",
            "SGI,Mushaf Air Force Base,Sargodha\t",
            "WNS,OPNH,Nawabshah Airport,Nawabshah\t",
            "PJG,OPPG\t,Panjgur Airport,Panjgur\t",
            "UET,OPQT,Quetta Airport,Quetta\t",
            "RYK,OPRK\t,Rahim Yar Khan Airport,Rahim Yar Khan\t",
            "RZS,OPSW,Sawan Airport,Sawan\t",
            "SKT,Sialkot Airport,Sialkot\t",
            "KDU,OPSD,Skardu Airport,Skardu\t",
            "SUL,OPSU,Sui Airport,Sui\t",
            "SKZ,OPSK,Sukkur Airport,Sukkur\t",
            "TUK,OPTU,Turbat Airport,Turbat\t",
            "ZIZ,Zamzama Heliport,Dadu\t",
            "PZH,OPZB,Zhob Airport,Zhob\t",
            "AAW,Abbottabad Airport,Abbottabad\t",
            "ATG,Attock Airport,Attock\t",
            "WGB,Bahawalnagar Airport,Bahawalnagar\t",
            "BNP,OPBN,Bannu Airport,Bannu\t",
            "BHW,Bhagatanwala Airport,Sargodha\t",
            "BHC,Bhurban Heliport,Bhurban\t",
            "CWP,Campbellpore Airport,Campbellpore\t",
            "CHB,Chilas Airport,Chilas\t",
            "GRT,Gujrat Airport,Gujrat\t",
            "JAG,OPJA,Jacobabad Airport,Jacobabad\t",
            "JIW,OPJI,Jiwani Airport,Jiwani\t",
            "KDD,OPKH,Khuzdar Airport,Khuzdar\t",
            "OHT,Kohat Airport,Kohat\t",
            "LRG,Lora Lai Airport,Lora Lai\t",
            "HRA,Mansehra Airport,Mansehra\t",
            "MWD,Mianwali Airport,Mianwali\t",
            "MPD,Mirpur Khas Airport,Mirpur Khas\t",
            "MFG,OPMF,Muzaffarabad Airport,Muzaffarabad\t",
            "NHS,Nushki Airport,Nushki\t",
            "ORW,OPOR,Ormara Airport,Ormara"});
            this.FDest.Location = new System.Drawing.Point(212, 325);
            this.FDest.Name = "FDest";
            this.FDest.Size = new System.Drawing.Size(233, 31);
            this.FDest.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(277, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 54);
            this.button2.TabIndex = 19;
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
            this.button1.Location = new System.Drawing.Point(139, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 54);
            this.button1.TabIndex = 18;
            this.button1.Text = "Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(479, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(12, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 34);
            this.label7.TabIndex = 21;
            this.label7.Text = "TakeOff Date";
            // 
            // FDate
            // 
            this.FDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FDate.Location = new System.Drawing.Point(257, 400);
            this.FDate.Name = "FDate";
            this.FDate.Size = new System.Drawing.Size(188, 27);
            this.FDate.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(824, 19);
            this.panel3.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 19);
            this.panel2.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 662);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 19);
            this.panel1.TabIndex = 71;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(417, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 54);
            this.button3.TabIndex = 72;
            this.button3.Text = "View Flights";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkOrange;
            this.button4.Location = new System.Drawing.Point(593, 536);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 54);
            this.button4.TabIndex = 73;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // FlightTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 681);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.FDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FDest);
            this.Controls.Add(this.Fsrc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SeatNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FcodeTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightTable";
            this.Text = "FlightTable";
            this.Load += new System.EventHandler(this.FlightTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FcodeTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SeatNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Fsrc;
        private System.Windows.Forms.ComboBox FDest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}