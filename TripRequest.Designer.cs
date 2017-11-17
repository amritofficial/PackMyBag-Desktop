namespace WindowsFormsApplication1
{
	partial class TripRequest
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripRequest));
			this.gvTripRequest = new System.Windows.Forms.DataGridView();
			this.btnApprove = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tripBookedDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gvTripRequest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tripBookedDataTableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			this.SuspendLayout();
			// 
			// gvTripRequest
			// 
			this.gvTripRequest.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.gvTripRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvTripRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnApprove});
			this.gvTripRequest.Location = new System.Drawing.Point(12, 82);
			this.gvTripRequest.Name = "gvTripRequest";
			this.gvTripRequest.ReadOnly = true;
			this.gvTripRequest.RowTemplate.Height = 24;
			this.gvTripRequest.Size = new System.Drawing.Size(953, 365);
			this.gvTripRequest.TabIndex = 0;
			this.gvTripRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTripRequest_CellContentClick);
			// 
			// btnApprove
			// 
			this.btnApprove.HeaderText = "Approve";
			this.btnApprove.Name = "btnApprove";
			this.btnApprove.ReadOnly = true;
			this.btnApprove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnApprove.Text = "Approve";
			this.btnApprove.UseColumnTextForButtonValue = true;
			// 
			// tripBookedDataTableBindingSource
			// 
			this.tripBookedDataTableBindingSource.DataSource = typeof(WindowsFormsApplication1.TripDataset.TripBookedDataTable);
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
			this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
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
			this.panel2.Location = new System.Drawing.Point(-1, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(297, 67);
			this.panel2.TabIndex = 7;
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
			this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.btnHome);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(290, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(687, 68);
			this.panel1.TabIndex = 8;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(220, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(272, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "T R I P   A P P R O V A L";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// TripRequest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(977, 463);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gvTripRequest);
			this.Name = "TripRequest";
			this.Text = "TripRequest";
			this.Load += new System.EventHandler(this.TripRequest_Load);
			((System.ComponentModel.ISupportInitialize)(this.gvTripRequest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tripBookedDataTableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gvTripRequest;
		private System.Windows.Forms.BindingSource tripBookedDataTableBindingSource;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuImageButton btnHome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewButtonColumn btnApprove;
	}
}