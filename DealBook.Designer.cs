namespace WindowsFormsApplication1
{
	partial class DealBook
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DealBook));
			this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tbName = new System.Windows.Forms.TextBox();
			this.UserName = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.dateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnBookdeal = new Bunifu.Framework.UI.BunifuFlatButton();
			this.cbRooms = new System.Windows.Forms.ComboBox();
			this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.cbHotel = new System.Windows.Forms.ComboBox();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.hotelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.hotel = new WindowsFormsApplication1.Hotel();
			this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hotelTableAdapter = new WindowsFormsApplication1.HotelTableAdapters.HotelTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
			this.SuspendLayout();
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
			this.panel1.Location = new System.Drawing.Point(270, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(332, 68);
			this.panel1.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(96, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(198, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "B O O K   D E A L";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.panel2.Location = new System.Drawing.Point(-5, -1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(285, 67);
			this.panel2.TabIndex = 9;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.LightGray;
			this.panel3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.panel3.Location = new System.Drawing.Point(59, 184);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(341, 2);
			this.panel3.TabIndex = 13;
			// 
			// tbName
			// 
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbName.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbName.Location = new System.Drawing.Point(59, 153);
			this.tbName.MaximumSize = new System.Drawing.Size(400, 40);
			this.tbName.Multiline = true;
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(341, 33);
			this.tbName.TabIndex = 12;
			this.tbName.UseSystemPasswordChar = true;
			// 
			// UserName
			// 
			this.UserName.AutoSize = true;
			this.UserName.BackColor = System.Drawing.Color.Transparent;
			this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserName.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.UserName.Location = new System.Drawing.Point(56, 112);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(66, 17);
			this.UserName.TabIndex = 11;
			this.UserName.Text = "N A M E";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.LightGray;
			this.panel8.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.panel8.Location = new System.Drawing.Point(59, 312);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(341, 2);
			this.panel8.TabIndex = 35;
			// 
			// tbEmail
			// 
			this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbEmail.Location = new System.Drawing.Point(59, 281);
			this.tbEmail.MaximumSize = new System.Drawing.Size(400, 40);
			this.tbEmail.Multiline = true;
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(341, 33);
			this.tbEmail.TabIndex = 34;
			this.tbEmail.UseSystemPasswordChar = true;
			// 
			// bunifuCustomLabel8
			// 
			this.bunifuCustomLabel8.AutoSize = true;
			this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.bunifuCustomLabel8.Location = new System.Drawing.Point(56, 240);
			this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
			this.bunifuCustomLabel8.Size = new System.Drawing.Size(78, 17);
			this.bunifuCustomLabel8.TabIndex = 33;
			this.bunifuCustomLabel8.Text = "E M A  I L";
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.LightGray;
			this.panel9.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.panel9.Location = new System.Drawing.Point(59, 444);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(341, 2);
			this.panel9.TabIndex = 38;
			// 
			// tbPhone
			// 
			this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPhone.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbPhone.Location = new System.Drawing.Point(59, 413);
			this.tbPhone.MaximumSize = new System.Drawing.Size(400, 40);
			this.tbPhone.Multiline = true;
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(341, 33);
			this.tbPhone.TabIndex = 37;
			this.tbPhone.UseSystemPasswordChar = true;
			// 
			// bunifuCustomLabel9
			// 
			this.bunifuCustomLabel9.AutoSize = true;
			this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.bunifuCustomLabel9.Location = new System.Drawing.Point(56, 372);
			this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
			this.bunifuCustomLabel9.Size = new System.Drawing.Size(96, 17);
			this.bunifuCustomLabel9.TabIndex = 36;
			this.bunifuCustomLabel9.Text = "P H O N E #";
			// 
			// dateLabel
			// 
			this.dateLabel.AutoSize = true;
			this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.dateLabel.Location = new System.Drawing.Point(431, 109);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(79, 20);
			this.dateLabel.TabIndex = 39;
			this.dateLabel.Text = "N A M E";
			// 
			// btnBookdeal
			// 
			this.btnBookdeal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnBookdeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(142)))));
			this.btnBookdeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnBookdeal.BorderRadius = 0;
			this.btnBookdeal.ButtonText = "B O O K   D E A L";
			this.btnBookdeal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBookdeal.DisabledColor = System.Drawing.Color.Gray;
			this.btnBookdeal.Iconcolor = System.Drawing.Color.Transparent;
			this.btnBookdeal.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBookdeal.Iconimage")));
			this.btnBookdeal.Iconimage_right = null;
			this.btnBookdeal.Iconimage_right_Selected = null;
			this.btnBookdeal.Iconimage_Selected = null;
			this.btnBookdeal.IconMarginLeft = 0;
			this.btnBookdeal.IconMarginRight = 0;
			this.btnBookdeal.IconRightVisible = true;
			this.btnBookdeal.IconRightZoom = 0D;
			this.btnBookdeal.IconVisible = true;
			this.btnBookdeal.IconZoom = 90D;
			this.btnBookdeal.IsTab = false;
			this.btnBookdeal.Location = new System.Drawing.Point(59, 520);
			this.btnBookdeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBookdeal.Name = "btnBookdeal";
			this.btnBookdeal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(142)))));
			this.btnBookdeal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(3)))), ((int)(((byte)(106)))));
			this.btnBookdeal.OnHoverTextColor = System.Drawing.Color.White;
			this.btnBookdeal.selected = false;
			this.btnBookdeal.Size = new System.Drawing.Size(341, 37);
			this.btnBookdeal.TabIndex = 41;
			this.btnBookdeal.Text = "B O O K   D E A L";
			this.btnBookdeal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnBookdeal.Textcolor = System.Drawing.Color.White;
			this.btnBookdeal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBookdeal.Click += new System.EventHandler(this.btnBookdeal_Click);
			// 
			// cbRooms
			// 
			this.cbRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(142)))));
			this.cbRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRooms.ForeColor = System.Drawing.Color.White;
			this.cbRooms.FormattingEnabled = true;
			this.cbRooms.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.cbRooms.Location = new System.Drawing.Point(435, 422);
			this.cbRooms.Name = "cbRooms";
			this.cbRooms.Size = new System.Drawing.Size(104, 24);
			this.cbRooms.TabIndex = 43;
			// 
			// bunifuCustomLabel5
			// 
			this.bunifuCustomLabel5.AutoSize = true;
			this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.bunifuCustomLabel5.Location = new System.Drawing.Point(432, 372);
			this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
			this.bunifuCustomLabel5.Size = new System.Drawing.Size(85, 17);
			this.bunifuCustomLabel5.TabIndex = 42;
			this.bunifuCustomLabel5.Text = "R O O M S";
			// 
			// cbHotel
			// 
			this.cbHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(142)))));
			this.cbHotel.DataSource = this.hotelBindingSource;
			this.cbHotel.DisplayMember = "HotelName";
			this.cbHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbHotel.ForeColor = System.Drawing.Color.White;
			this.cbHotel.FormattingEnabled = true;
			this.cbHotel.Location = new System.Drawing.Point(429, 290);
			this.cbHotel.Name = "cbHotel";
			this.cbHotel.Size = new System.Drawing.Size(156, 24);
			this.cbHotel.TabIndex = 44;
			this.cbHotel.ValueMember = "HotelID";
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(432, 240);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(95, 17);
			this.bunifuCustomLabel1.TabIndex = 45;
			this.bunifuCustomLabel1.Text = "H O T E L S";
			// 
			// hotelBindingSource1
			// 
			this.hotelBindingSource1.DataMember = "Hotel";
			// 
			// hotel
			// 
			this.hotel.DataSetName = "Hotel";
			this.hotel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// hotelBindingSource
			// 
			this.hotelBindingSource.DataMember = "Hotel";
			this.hotelBindingSource.DataSource = this.hotel;
			// 
			// hotelTableAdapter
			// 
			this.hotelTableAdapter.ClearBeforeFill = true;
			// 
			// DealBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(602, 589);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.cbHotel);
			this.Controls.Add(this.cbRooms);
			this.Controls.Add(this.bunifuCustomLabel5);
			this.Controls.Add(this.btnBookdeal);
			this.Controls.Add(this.dateLabel);
			this.Controls.Add(this.panel9);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.bunifuCustomLabel9);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.tbEmail);
			this.Controls.Add(this.bunifuCustomLabel8);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.UserName);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "DealBook";
			this.Text = "DealBook";
			this.Load += new System.EventHandler(this.DealBook_Load);
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuImageButton btnHome;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox tbName;
		private Bunifu.Framework.UI.BunifuCustomLabel UserName;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox tbEmail;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.TextBox tbPhone;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
		private Bunifu.Framework.UI.BunifuCustomLabel dateLabel;
		private Bunifu.Framework.UI.BunifuFlatButton btnBookdeal;
		private System.Windows.Forms.ComboBox cbRooms;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
		private System.Windows.Forms.ComboBox cbHotel;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private System.Windows.Forms.BindingSource hotelBindingSource1;
		private Hotel hotel;
		private System.Windows.Forms.BindingSource hotelBindingSource;
		private HotelTableAdapters.HotelTableAdapter hotelTableAdapter;
	}
}