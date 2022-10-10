namespace My_AirLine_2
{
    partial class ViewFlight
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
            this.FDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.DstCb = new System.Windows.Forms.ComboBox();
            this.SrcCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SeatNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FcodeTb = new System.Windows.Forms.TextBox();
            this.FlightDGV = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(266, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "View Scheduled Flights";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(309, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tanay AirLine";
            // 
            // FDate
            // 
            this.FDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FDate.Location = new System.Drawing.Point(355, 311);
            this.FDate.Name = "FDate";
            this.FDate.Size = new System.Drawing.Size(203, 27);
            this.FDate.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(186, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 26);
            this.label7.TabIndex = 31;
            this.label7.Text = "TakeOff Date";
            // 
            // DstCb
            // 
            this.DstCb.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DstCb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DstCb.FormattingEnabled = true;
            this.DstCb.Items.AddRange(new object[] {
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
            this.DstCb.Location = new System.Drawing.Point(563, 245);
            this.DstCb.Name = "DstCb";
            this.DstCb.Size = new System.Drawing.Size(236, 33);
            this.DstCb.TabIndex = 30;
            // 
            // SrcCb
            // 
            this.SrcCb.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrcCb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SrcCb.FormattingEnabled = true;
            this.SrcCb.Items.AddRange(new object[] {
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
            this.SrcCb.Location = new System.Drawing.Point(563, 178);
            this.SrcCb.Name = "SrcCb";
            this.SrcCb.Size = new System.Drawing.Size(236, 33);
            this.SrcCb.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(414, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 26);
            this.label6.TabIndex = 28;
            this.label6.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(436, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 26);
            this.label5.TabIndex = 27;
            this.label5.Text = "Source ";
            // 
            // SeatNum
            // 
            this.SeatNum.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.SeatNum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SeatNum.Location = new System.Drawing.Point(192, 245);
            this.SeatNum.Multiline = true;
            this.SeatNum.Name = "SeatNum";
            this.SeatNum.Size = new System.Drawing.Size(163, 29);
            this.SeatNum.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(14, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Num. of seats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(14, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Flight Code";
            // 
            // FcodeTb
            // 
            this.FcodeTb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.FcodeTb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FcodeTb.Location = new System.Drawing.Point(192, 174);
            this.FcodeTb.Multiline = true;
            this.FcodeTb.Name = "FcodeTb";
            this.FcodeTb.Size = new System.Drawing.Size(163, 31);
            this.FcodeTb.TabIndex = 23;
            // 
            // FlightDGV
            // 
            this.FlightDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightDGV.Location = new System.Drawing.Point(18, 447);
            this.FlightDGV.Name = "FlightDGV";
            this.FlightDGV.Size = new System.Drawing.Size(794, 222);
            this.FlightDGV.TabIndex = 33;
            this.FlightDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightDGV_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(429, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 48);
            this.button2.TabIndex = 35;
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
            this.button1.Location = new System.Drawing.Point(114, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 48);
            this.button1.TabIndex = 34;
            this.button1.Text = "Update ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(271, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 48);
            this.button3.TabIndex = 36;
            this.button3.Text = "Delete";
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
            this.button4.Location = new System.Drawing.Point(590, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 48);
            this.button4.TabIndex = 37;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(824, 19);
            this.panel3.TabIndex = 70;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 19);
            this.panel2.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(776, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 35);
            this.label10.TabIndex = 102;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // ViewFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 694);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FlightDGV);
            this.Controls.Add(this.FDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DstCb);
            this.Controls.Add(this.SrcCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SeatNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FcodeTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewFlight";
            this.Text = "ViewFlight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewFlight_FormClosing);
            this.Load += new System.EventHandler(this.ViewFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DstCb;
        private System.Windows.Forms.ComboBox SrcCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SeatNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FcodeTb;
        private System.Windows.Forms.DataGridView FlightDGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
    }
}