namespace WindowsFormsApplication1
{
	partial class NewDeals
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDeals));
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.tripDataset = new WindowsFormsApplication1.TripDataset();
			this.tripBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tripTableAdapter = new WindowsFormsApplication1.TripDatasetTableAdapters.TripTableAdapter();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.tripED = new Bunifu.Framework.UI.BunifuDatepicker();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.tripSD = new Bunifu.Framework.UI.BunifuDatepicker();
			this.panel7 = new System.Windows.Forms.Panel();
			this.tbDestination = new System.Windows.Forms.TextBox();
			this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.tbOrigin = new System.Windows.Forms.TextBox();
			this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.cbInsurance = new System.Windows.Forms.ComboBox();
			this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnCreate = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnShowdeals = new Bunifu.Framework.UI.BunifuFlatButton();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tripDataset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(87, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "P a c k  M y  B a g";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(137)))));
			this.panel2.Controls.Add(this.bunifuImageButton5);
			this.panel2.Controls.Add(this.bunifuImageButton4);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(-1, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(297, 67);
			this.panel2.TabIndex = 9;
			// 
			// bunifuImageButton5
			// 
			this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
			this.bunifuImageButton5.ImageActive = null;
			this.bunifuImageButton5.Location = new System.Drawing.Point(251, 6);
			this.bunifuImageButton5.Name = "bunifuImageButton5";
			this.bunifuImageButton5.Size = new System.Drawing.Size(18, 18);
			this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton5.TabIndex = 2;
			this.bunifuImageButton5.TabStop = false;
			this.bunifuImageButton5.Zoom = 10;
			// 
			// bunifuImageButton4
			// 
			this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
			this.bunifuImageButton4.ImageActive = null;
			this.bunifuImageButton4.Location = new System.Drawing.Point(2, -3);
			this.bunifuImageButton4.Name = "bunifuImageButton4";
			this.bunifuImageButton4.Size = new System.Drawing.Size(81, 67);
			this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton4.TabIndex = 0;
			this.bunifuImageButton4.TabStop = false;
			this.bunifuImageButton4.Zoom = 10;
			// 
			// btnHome
			// 
			this.btnHome.BackColor = System.Drawing.Color.Transparent;
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.ImageActive = null;
			this.btnHome.Location = new System.Drawing.Point(12, 12);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(52, 41);
			this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnHome.TabIndex = 3;
			this.btnHome.TabStop = false;
			this.btnHome.Zoom = 10;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.btnHome);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(290, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(594, 68);
			this.panel1.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(154, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(217, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "N E W   D E A L S";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tripDataset
			// 
			this.tripDataset.DataSetName = "TripDataset";
			this.tripDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tripBindingSource
			// 
			this.tripBindingSource.DataMember = "Trip";
			this.tripBindingSource.DataSource = this.tripDataset;
			// 
			// tripTableAdapter
			// 
			this.tripTableAdapter.ClearBeforeFill = true;
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(21, 223);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(116, 17);
			this.bunifuCustomLabel2.TabIndex = 17;
			this.bunifuCustomLabel2.Text = "E N D  D A T E";
			this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tripED
			// 
			this.tripED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(142)))));
			this.tripED.BorderRadius = 0;
			this.tripED.ForeColor = System.Drawing.Color.White;
			this.tripED.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.tripED.FormatCustom = null;
			this.tripED.Location = new System.Drawing.Point(24, 260);
			this.tripED.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tripED.Name = "tripED";
			this.tripED.Size = new System.Drawing.Size(341, 44);
			this.tripED.TabIndex = 16;
			this.tripED.Value = new System.DateTime(2017, 8, 7, 15, 23, 7, 719);
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(21, 109);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(124, 17);
			this.bunifuCustomLabel1.TabIndex = 15;
			this.bunifuCustomLabel1.Text = "T R I P  D A T E";
			this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tripSD
			// 
			this.tripSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(142)))));
			this.tripSD.BorderRadius = 0;
			this.tripSD.ForeColor = System.Drawing.Color.White;
			this.tripSD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.tripSD.FormatCustom = null;
			this.tripSD.Location = new System.Drawing.Point(24, 146);
			this.tripSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tripSD.Name = "tripSD";
			this.tripSD.Size = new System.Drawing.Size(341, 44);
			this.tripSD.TabIndex = 14;
			this.tripSD.Value = new System.DateTime(2017, 8, 7, 15, 23, 7, 719);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.LightGray;
			this.panel7.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.panel7.Location = new System.Drawing.Point(486, 298);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(341, 2);
			this.panel7.TabIndex = 33;
			// 
			// tbDestination
			// 
			this.tbDestination.AutoCompleteCustomSource.AddRange(new string[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua & Deps",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Central African Rep",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo {Democratic Rep}",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland {Republic}",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea North",
            "Korea South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar, {Burma}",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "St Kitts & Nevis",
            "St Lucia",
            "Saint Vincent & the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
			this.tbDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbDestination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDestination.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbDestination.Location = new System.Drawing.Point(486, 260);
			this.tbDestination.MaximumSize = new System.Drawing.Size(400, 40);
			this.tbDestination.Name = "tbDestination";
			this.tbDestination.Size = new System.Drawing.Size(341, 23);
			this.tbDestination.TabIndex = 32;
			this.tbDestination.TextChanged += new System.EventHandler(this.tbDestination_TextChanged);
			// 
			// bunifuCustomLabel7
			// 
			this.bunifuCustomLabel7.AutoSize = true;
			this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.bunifuCustomLabel7.Location = new System.Drawing.Point(483, 223);
			this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
			this.bunifuCustomLabel7.Size = new System.Drawing.Size(161, 17);
			this.bunifuCustomLabel7.TabIndex = 31;
			this.bunifuCustomLabel7.Text = "D E S T I N A T I O N";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.LightGray;
			this.panel6.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.panel6.Location = new System.Drawing.Point(486, 186);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(341, 2);
			this.panel6.TabIndex = 30;
			// 
			// tbOrigin
			// 
			this.tbOrigin.AutoCompleteCustomSource.AddRange(new string[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua & Deps",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Central African Rep",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo {Democratic Rep}",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland {Republic}",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea North",
            "Korea South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar, {Burma}",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "St Kitts & Nevis",
            "St Lucia",
            "Saint Vincent & the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
			this.tbOrigin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbOrigin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbOrigin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbOrigin.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbOrigin.Location = new System.Drawing.Point(486, 146);
			this.tbOrigin.MaximumSize = new System.Drawing.Size(400, 40);
			this.tbOrigin.Name = "tbOrigin";
			this.tbOrigin.Size = new System.Drawing.Size(341, 23);
			this.tbOrigin.TabIndex = 29;
			// 
			// bunifuCustomLabel6
			// 
			this.bunifuCustomLabel6.AutoSize = true;
			this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.bunifuCustomLabel6.Location = new System.Drawing.Point(483, 109);
			this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
			this.bunifuCustomLabel6.Size = new System.Drawing.Size(87, 17);
			this.bunifuCustomLabel6.TabIndex = 28;
			this.bunifuCustomLabel6.Text = "O R I G I N";
			// 
			// cbInsurance
			// 
			this.cbInsurance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(142)))));
			this.cbInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbInsurance.ForeColor = System.Drawing.Color.White;
			this.cbInsurance.FormattingEnabled = true;
			this.cbInsurance.Items.AddRange(new object[] {
            "YES",
            "NO"});
			this.cbInsurance.Location = new System.Drawing.Point(486, 371);
			this.cbInsurance.Name = "cbInsurance";
			this.cbInsurance.Size = new System.Drawing.Size(133, 24);
			this.cbInsurance.TabIndex = 38;
			// 
			// bunifuCustomLabel5
			// 
			this.bunifuCustomLabel5.AutoSize = true;
			this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.bunifuCustomLabel5.Location = new System.Drawing.Point(483, 328);
			this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
			this.bunifuCustomLabel5.Size = new System.Drawing.Size(136, 17);
			this.bunifuCustomLabel5.TabIndex = 37;
			this.bunifuCustomLabel5.Text = "I N S U R A N C E";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.LightGray;
			this.panel4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.panel4.Location = new System.Drawing.Point(24, 393);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(341, 2);
			this.panel4.TabIndex = 36;
			// 
			// tbPrice
			// 
			this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbPrice.Location = new System.Drawing.Point(24, 362);
			this.tbPrice.MaximumSize = new System.Drawing.Size(400, 40);
			this.tbPrice.Multiline = true;
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(341, 33);
			this.tbPrice.TabIndex = 35;
			this.tbPrice.UseSystemPasswordChar = true;
			// 
			// bunifuCustomLabel3
			// 
			this.bunifuCustomLabel3.AutoSize = true;
			this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.bunifuCustomLabel3.Location = new System.Drawing.Point(21, 328);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new System.Drawing.Size(73, 17);
			this.bunifuCustomLabel3.TabIndex = 34;
			this.bunifuCustomLabel3.Text = "P R I C E";
			// 
			// btnCreate
			// 
			this.btnCreate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(142)))));
			this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCreate.BorderRadius = 0;
			this.btnCreate.ButtonText = "C R E A T E   D E A L";
			this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCreate.DisabledColor = System.Drawing.Color.Gray;
			this.btnCreate.Iconcolor = System.Drawing.Color.Transparent;
			this.btnCreate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCreate.Iconimage")));
			this.btnCreate.Iconimage_right = null;
			this.btnCreate.Iconimage_right_Selected = null;
			this.btnCreate.Iconimage_Selected = null;
			this.btnCreate.IconMarginLeft = 0;
			this.btnCreate.IconMarginRight = 0;
			this.btnCreate.IconRightVisible = true;
			this.btnCreate.IconRightZoom = 0D;
			this.btnCreate.IconVisible = true;
			this.btnCreate.IconZoom = 90D;
			this.btnCreate.IsTab = false;
			this.btnCreate.Location = new System.Drawing.Point(24, 453);
			this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(142)))));
			this.btnCreate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(3)))), ((int)(((byte)(106)))));
			this.btnCreate.OnHoverTextColor = System.Drawing.Color.White;
			this.btnCreate.selected = false;
			this.btnCreate.Size = new System.Drawing.Size(341, 37);
			this.btnCreate.TabIndex = 39;
			this.btnCreate.Text = "C R E A T E   D E A L";
			this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCreate.Textcolor = System.Drawing.Color.White;
			this.btnCreate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnShowdeals
			// 
			this.btnShowdeals.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnShowdeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(142)))));
			this.btnShowdeals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnShowdeals.BorderRadius = 0;
			this.btnShowdeals.ButtonText = "S H O W   D E A L S";
			this.btnShowdeals.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShowdeals.DisabledColor = System.Drawing.Color.Gray;
			this.btnShowdeals.Iconcolor = System.Drawing.Color.Transparent;
			this.btnShowdeals.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShowdeals.Iconimage")));
			this.btnShowdeals.Iconimage_right = null;
			this.btnShowdeals.Iconimage_right_Selected = null;
			this.btnShowdeals.Iconimage_Selected = null;
			this.btnShowdeals.IconMarginLeft = 0;
			this.btnShowdeals.IconMarginRight = 0;
			this.btnShowdeals.IconRightVisible = true;
			this.btnShowdeals.IconRightZoom = 0D;
			this.btnShowdeals.IconVisible = true;
			this.btnShowdeals.IconZoom = 90D;
			this.btnShowdeals.IsTab = false;
			this.btnShowdeals.Location = new System.Drawing.Point(486, 453);
			this.btnShowdeals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnShowdeals.Name = "btnShowdeals";
			this.btnShowdeals.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(142)))));
			this.btnShowdeals.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(3)))), ((int)(((byte)(106)))));
			this.btnShowdeals.OnHoverTextColor = System.Drawing.Color.White;
			this.btnShowdeals.selected = false;
			this.btnShowdeals.Size = new System.Drawing.Size(341, 37);
			this.btnShowdeals.TabIndex = 40;
			this.btnShowdeals.Text = "S H O W   D E A L S";
			this.btnShowdeals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnShowdeals.Textcolor = System.Drawing.Color.White;
			this.btnShowdeals.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowdeals.Click += new System.EventHandler(this.btnShowdeals_Click);
			// 
			// NewDeals
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(881, 514);
			this.Controls.Add(this.btnShowdeals);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.cbInsurance);
			this.Controls.Add(this.bunifuCustomLabel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.bunifuCustomLabel3);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.tbDestination);
			this.Controls.Add(this.bunifuCustomLabel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.tbOrigin);
			this.Controls.Add(this.bunifuCustomLabel6);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Controls.Add(this.tripED);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.tripSD);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "NewDeals";
			this.Text = "NewDeals";
			this.Load += new System.EventHandler(this.NewDeals_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tripDataset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
		private Bunifu.Framework.UI.BunifuImageButton btnHome;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private TripDataset tripDataset;
		private System.Windows.Forms.BindingSource tripBindingSource;
		private TripDatasetTableAdapters.TripTableAdapter tripTableAdapter;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
		private Bunifu.Framework.UI.BunifuDatepicker tripED;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private Bunifu.Framework.UI.BunifuDatepicker tripSD;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TextBox tbDestination;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox tbOrigin;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
		private System.Windows.Forms.ComboBox cbInsurance;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox tbPrice;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
		private Bunifu.Framework.UI.BunifuFlatButton btnCreate;
		private Bunifu.Framework.UI.BunifuFlatButton btnShowdeals;
	}
}