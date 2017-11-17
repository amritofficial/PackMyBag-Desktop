namespace WindowsFormsApplication1
{
	partial class UpdateInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateInfo));
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tripDataset = new WindowsFormsApplication1.TripDataset();
			this.customerTableAdapter = new WindowsFormsApplication1.TripDatasetTableAdapters.CustomerTableAdapter();
			this.panel9 = new System.Windows.Forms.Panel();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbName = new System.Windows.Forms.TextBox();
			this.UserName = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.cbBookingid = new System.Windows.Forms.ComboBox();
			this.tripBookedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.tripDataSet2 = new WindowsFormsApplication1.TripDataSet2();
			this.tripBookedBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tripBookedTableAdapter = new WindowsFormsApplication1.TripDatasetTableAdapters.TripBookedTableAdapter();
			this.tripBookedTableAdapter1 = new WindowsFormsApplication1.TripDataSet2TableAdapters.TripBookedTableAdapter();
			this.panel4 = new System.Windows.Forms.Panel();
			this.tbRooms = new System.Windows.Forms.TextBox();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tripDataset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tripBookedBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tripDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tripBookedBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(82, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "P a c k  M y  B a g";
			// 
			// bunifuImageButton4
			// 
			this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
			this.bunifuImageButton4.ImageActive = null;
			this.bunifuImageButton4.Location = new System.Drawing.Point(1, -3);
			this.bunifuImageButton4.Name = "bunifuImageButton4";
			this.bunifuImageButton4.Size = new System.Drawing.Size(95, 67);
			this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton4.TabIndex = 0;
			this.bunifuImageButton4.TabStop = false;
			this.bunifuImageButton4.Zoom = 10;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(137)))));
			this.panel2.Controls.Add(this.bunifuImageButton5);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.bunifuImageButton4);
			this.panel2.Location = new System.Drawing.Point(-2, -1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(300, 67);
			this.panel2.TabIndex = 2;
			// 
			// bunifuImageButton5
			// 
			this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
			this.bunifuImageButton5.ImageActive = null;
			this.bunifuImageButton5.Location = new System.Drawing.Point(256, 11);
			this.bunifuImageButton5.Name = "bunifuImageButton5";
			this.bunifuImageButton5.Size = new System.Drawing.Size(18, 18);
			this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton5.TabIndex = 2;
			this.bunifuImageButton5.TabStop = false;
			this.bunifuImageButton5.Zoom = 10;
			// 
			// btnHome
			// 
			this.btnHome.BackColor = System.Drawing.Color.Transparent;
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.ImageActive = null;
			this.btnHome.Location = new System.Drawing.Point(9, 14);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(52, 41);
			this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnHome.TabIndex = 0;
			this.btnHome.TabStop = false;
			this.btnHome.Zoom = 10;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.btnHome);
			this.panel3.Location = new System.Drawing.Point(298, -1);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(560, 67);
			this.panel3.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(174, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(234, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "U P D A T E   I N F O";
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.DataMember = "Customer";
			this.customerBindingSource.DataSource = this.tripDataset;
			// 
			// tripDataset
			// 
			this.tripDataset.DataSetName = "TripDataset";
			this.tripDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// customerTableAdapter
			// 
			this.customerTableAdapter.ClearBeforeFill = true;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.LightGray;
			this.panel9.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.panel9.Location = new System.Drawing.Point(31, 440);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(341, 2);
			this.panel9.TabIndex = 47;
			// 
			// tbPhone
			// 
			this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPhone.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbPhone.Location = new System.Drawing.Point(31, 409);
			this.tbPhone.MaximumSize = new System.Drawing.Size(400, 40);
			this.tbPhone.Multiline = true;
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(341, 33);
			this.tbPhone.TabIndex = 46;
			this.tbPhone.UseSystemPasswordChar = true;
			// 
			// bunifuCustomLabel9
			// 
			this.bunifuCustomLabel9.AutoSize = true;
			this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.bunifuCustomLabel9.Location = new System.Drawing.Point(28, 368);
			this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
			this.bunifuCustomLabel9.Size = new System.Drawing.Size(96, 17);
			this.bunifuCustomLabel9.TabIndex = 45;
			this.bunifuCustomLabel9.Text = "P H O N E #";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.LightGray;
			this.panel8.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.panel8.Location = new System.Drawing.Point(31, 308);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(341, 2);
			this.panel8.TabIndex = 44;
			// 
			// tbEmail
			// 
			this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbEmail.Location = new System.Drawing.Point(31, 277);
			this.tbEmail.MaximumSize = new System.Drawing.Size(400, 40);
			this.tbEmail.Multiline = true;
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(341, 33);
			this.tbEmail.TabIndex = 43;
			this.tbEmail.UseSystemPasswordChar = true;
			// 
			// bunifuCustomLabel8
			// 
			this.bunifuCustomLabel8.AutoSize = true;
			this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.bunifuCustomLabel8.Location = new System.Drawing.Point(28, 236);
			this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
			this.bunifuCustomLabel8.Size = new System.Drawing.Size(78, 17);
			this.bunifuCustomLabel8.TabIndex = 42;
			this.bunifuCustomLabel8.Text = "E M A  I L";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGray;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Location = new System.Drawing.Point(31, 180);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(341, 2);
			this.panel1.TabIndex = 41;
			// 
			// tbName
			// 
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbName.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbName.Location = new System.Drawing.Point(31, 149);
			this.tbName.MaximumSize = new System.Drawing.Size(400, 40);
			this.tbName.Multiline = true;
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(341, 33);
			this.tbName.TabIndex = 40;
			this.tbName.UseSystemPasswordChar = true;
			// 
			// UserName
			// 
			this.UserName.AutoSize = true;
			this.UserName.BackColor = System.Drawing.Color.Transparent;
			this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserName.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.UserName.Location = new System.Drawing.Point(28, 108);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(66, 17);
			this.UserName.TabIndex = 39;
			this.UserName.Text = "N A M E";
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(461, 108);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(149, 17);
			this.bunifuCustomLabel1.TabIndex = 49;
			this.bunifuCustomLabel1.Text = "B O O K I N G   I D ";
			// 
			// cbBookingid
			// 
			this.cbBookingid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(137)))));
			this.cbBookingid.DataSource = this.tripBookedBindingSource1;
			this.cbBookingid.DisplayMember = "BookingID";
			this.cbBookingid.ForeColor = System.Drawing.Color.White;
			this.cbBookingid.FormattingEnabled = true;
			this.cbBookingid.Location = new System.Drawing.Point(464, 156);
			this.cbBookingid.Name = "cbBookingid";
			this.cbBookingid.Size = new System.Drawing.Size(135, 24);
			this.cbBookingid.TabIndex = 50;
			this.cbBookingid.ValueMember = "BookingID";
			this.cbBookingid.SelectedIndexChanged += new System.EventHandler(this.cbBookingid_SelectedIndexChanged);
			// 
			// tripBookedBindingSource1
			// 
			this.tripBookedBindingSource1.DataMember = "TripBooked";
			this.tripBookedBindingSource1.DataSource = this.tripDataSet2;
			// 
			// tripDataSet2
			// 
			this.tripDataSet2.DataSetName = "TripDataSet2";
			this.tripDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tripBookedBindingSource
			// 
			this.tripBookedBindingSource.DataMember = "TripBooked";
			this.tripBookedBindingSource.DataSource = this.tripDataset;
			// 
			// tripBookedTableAdapter
			// 
			this.tripBookedTableAdapter.ClearBeforeFill = true;
			// 
			// tripBookedTableAdapter1
			// 
			this.tripBookedTableAdapter1.ClearBeforeFill = true;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.LightGray;
			this.panel4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.panel4.Location = new System.Drawing.Point(464, 308);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(82, 2);
			this.panel4.TabIndex = 54;
			// 
			// tbRooms
			// 
			this.tbRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRooms.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbRooms.Location = new System.Drawing.Point(464, 277);
			this.tbRooms.MaximumSize = new System.Drawing.Size(400, 40);
			this.tbRooms.Name = "tbRooms";
			this.tbRooms.Size = new System.Drawing.Size(82, 23);
			this.tbRooms.TabIndex = 53;
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(461, 236);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(85, 17);
			this.bunifuCustomLabel2.TabIndex = 52;
			this.bunifuCustomLabel2.Text = "R O O M S";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(142)))));
			this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnUpdate.BorderRadius = 0;
			this.btnUpdate.ButtonText = "UPDATE CHANGES";
			this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
			this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
			this.btnUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
			this.btnUpdate.Iconimage_right = null;
			this.btnUpdate.Iconimage_right_Selected = null;
			this.btnUpdate.Iconimage_Selected = null;
			this.btnUpdate.IconMarginLeft = 0;
			this.btnUpdate.IconMarginRight = 0;
			this.btnUpdate.IconRightVisible = true;
			this.btnUpdate.IconRightZoom = 0D;
			this.btnUpdate.IconVisible = true;
			this.btnUpdate.IconZoom = 90D;
			this.btnUpdate.IsTab = false;
			this.btnUpdate.Location = new System.Drawing.Point(464, 405);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(142)))));
			this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(3)))), ((int)(((byte)(106)))));
			this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
			this.btnUpdate.selected = false;
			this.btnUpdate.Size = new System.Drawing.Size(339, 37);
			this.btnUpdate.TabIndex = 55;
			this.btnUpdate.Text = "UPDATE CHANGES";
			this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnUpdate.Textcolor = System.Drawing.Color.White;
			this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// UpdateInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(852, 485);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.tbRooms);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Controls.Add(this.cbBookingid);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.panel9);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.bunifuCustomLabel9);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.tbEmail);
			this.Controls.Add(this.bunifuCustomLabel8);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.UserName);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Name = "UpdateInfo";
			this.Text = "UpdateInfo";
			this.Load += new System.EventHandler(this.UpdateInfo_Load);
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tripDataset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tripBookedBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tripDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tripBookedBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
		private System.Windows.Forms.Panel panel2;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
		private Bunifu.Framework.UI.BunifuImageButton btnHome;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private TripDataset tripDataset;
		private System.Windows.Forms.BindingSource customerBindingSource;
		private TripDatasetTableAdapters.CustomerTableAdapter customerTableAdapter;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.TextBox tbPhone;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox tbEmail;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbName;
		private Bunifu.Framework.UI.BunifuCustomLabel UserName;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private System.Windows.Forms.ComboBox cbBookingid;
		private System.Windows.Forms.BindingSource tripBookedBindingSource;
		private TripDatasetTableAdapters.TripBookedTableAdapter tripBookedTableAdapter;
		private TripDataSet2 tripDataSet2;
		private System.Windows.Forms.BindingSource tripBookedBindingSource1;
		private TripDataSet2TableAdapters.TripBookedTableAdapter tripBookedTableAdapter1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox tbRooms;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
		private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
	}
}