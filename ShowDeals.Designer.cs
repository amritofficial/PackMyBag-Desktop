namespace WindowsFormsApplication1
{
	partial class ShowDeals
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDeals));
			this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnChoose = new System.Windows.Forms.DataGridViewButtonColumn();
			this.TripID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tripStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tripEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TripInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tripBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tripDataSet2 = new WindowsFormsApplication1.TripDataSet2();
			this.tripTableAdapter = new WindowsFormsApplication1.TripDataSet2TableAdapters.TripTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tripDataSet2)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuImageButton4
			// 
			this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
			this.bunifuImageButton4.ImageActive = null;
			this.bunifuImageButton4.Location = new System.Drawing.Point(6, -2);
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
			this.label1.Location = new System.Drawing.Point(91, 21);
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
			this.panel2.Location = new System.Drawing.Point(-1, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(291, 67);
			this.panel2.TabIndex = 11;
			// 
			// bunifuImageButton5
			// 
			this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
			this.bunifuImageButton5.ImageActive = null;
			this.bunifuImageButton5.Location = new System.Drawing.Point(255, 6);
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
			this.btnHome.Location = new System.Drawing.Point(6, 12);
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
			this.panel1.Location = new System.Drawing.Point(290, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(696, 68);
			this.panel1.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(220, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(243, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "S H O W   D E A L S";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TripID,
            this.btnChoose,
            this.bookingDate,
            this.tripStartDate,
            this.tripEndDate,
            this.TotalPrice,
            this.TripInsurance,
            this.origin,
            this.Destination});
			this.dataGridView1.DataSource = this.tripBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 86);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(959, 442);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// btnChoose
			// 
			this.btnChoose.HeaderText = "Choose";
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Text = "Choose";
			this.btnChoose.UseColumnTextForButtonValue = true;
			// 
			// TripID
			// 
			this.TripID.DataPropertyName = "TripID";
			this.TripID.HeaderText = "TripID";
			this.TripID.Name = "TripID";
			this.TripID.ReadOnly = true;
			// 
			// bookingDate
			// 
			this.bookingDate.DataPropertyName = "BookingDate";
			this.bookingDate.HeaderText = "BookingDate";
			this.bookingDate.Name = "bookingDate";
			// 
			// tripStartDate
			// 
			this.tripStartDate.DataPropertyName = "TripStartDate";
			this.tripStartDate.HeaderText = "TripStartDate";
			this.tripStartDate.Name = "tripStartDate";
			// 
			// tripEndDate
			// 
			this.tripEndDate.DataPropertyName = "TripEndDate";
			this.tripEndDate.HeaderText = "TripEndDate";
			this.tripEndDate.Name = "tripEndDate";
			// 
			// TotalPrice
			// 
			this.TotalPrice.DataPropertyName = "TotalPrice";
			this.TotalPrice.HeaderText = "TotalPrice";
			this.TotalPrice.Name = "TotalPrice";
			// 
			// TripInsurance
			// 
			this.TripInsurance.DataPropertyName = "TripInsurance";
			this.TripInsurance.HeaderText = "TripInsurance";
			this.TripInsurance.Name = "TripInsurance";
			// 
			// origin
			// 
			this.origin.DataPropertyName = "Origin";
			this.origin.HeaderText = "Origin";
			this.origin.Name = "origin";
			// 
			// Destination
			// 
			this.Destination.DataPropertyName = "Destination";
			this.Destination.HeaderText = "Destination";
			this.Destination.Name = "Destination";
			// 
			// tripBindingSource
			// 
			this.tripBindingSource.DataMember = "Trip";
			this.tripBindingSource.DataSource = this.tripDataSet2;
			// 
			// tripDataSet2
			// 
			this.tripDataSet2.DataSetName = "TripDataSet2";
			this.tripDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tripTableAdapter
			// 
			this.tripTableAdapter.ClearBeforeFill = true;
			// 
			// ShowDeals
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(984, 540);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "ShowDeals";
			this.Text = "ShowDeals";
			this.Load += new System.EventHandler(this.ShowDeals_Load);
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tripDataSet2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
		private Bunifu.Framework.UI.BunifuImageButton btnHome;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private TripDataSet2 tripDataSet2;
		private System.Windows.Forms.BindingSource tripBindingSource;
		private TripDataSet2TableAdapters.TripTableAdapter tripTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn TripID;
		private System.Windows.Forms.DataGridViewButtonColumn btnChoose;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookingDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn tripStartDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn tripEndDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn TripInsurance;
		private System.Windows.Forms.DataGridViewTextBoxColumn origin;
		private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
	}
}