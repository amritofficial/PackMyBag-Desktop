/// <summary>
/// Author: Anu Mahay
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class ShowDeals : Form
	{
		public ShowDeals()
		{
			InitializeComponent();
		}

		private void ShowDeals_Load(object sender, EventArgs e)
		{
			dataGridView1.AllowUserToAddRows = false;
			// TODO: This line of code loads data into the 'tripDataSet2.Trip' table. You can move, or remove it, as needed.
			this.tripTableAdapter.Fill(this.tripDataSet2.Trip);

		}

		
		SqlConnection conn = new SqlConnection();
		/// <summary>
		/// The method that will run when a user clicks a button
		/// in a data grid view. The method attempts to connect to the connected model
		/// and grabs information and sets the value to the static variables
		/// </summary>
		public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string column = dataGridView1.Columns[e.ColumnIndex].Name.ToString();
			System.Diagnostics.Debug.WriteLine("Column: " + column);
			conn.ConnectionString = "Server=(local); Database=PackMyBag; User=singh12345; Password=12345";
			SqlCommand cmd = conn.CreateCommand();


			if (dataGridView1.Columns[e.ColumnIndex].Name == "btnChoose")
			{
				int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
				string bookingDate = Convert.ToString(dataGridView1.Rows[selectedRow].Cells["bookingDate"].Value);

				if (bookingDate == "")
				{
					int tripId = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["TripID"].Value);
					string tripStartDate = Convert.ToString(dataGridView1.Rows[selectedRow].Cells["tripStartDate"].Value);
					string tripEndDate = Convert.ToString(dataGridView1.Rows[selectedRow].Cells["tripEndDate"].Value);
					decimal price = Convert.ToDecimal(dataGridView1.Rows[selectedRow].Cells["TotalPrice"].Value);
					string insurance = Convert.ToString(dataGridView1.Rows[selectedRow].Cells["TripInsurance"].Value);
					string origin = Convert.ToString(dataGridView1.Rows[selectedRow].Cells["Origin"].Value);
					string destination = Convert.ToString(dataGridView1.Rows[selectedRow].Cells["Destination"].Value);

					
					ShowDeals.tripID = tripId;
					ShowDeals.ted = tripEndDate;
					ShowDeals.tsd = tripStartDate;
					ShowDeals.price = price;
					ShowDeals.insurance = insurance;
					ShowDeals.tOrigin = origin;
					ShowDeals.destination = destination;

					
					
					DealBook db = new DealBook();
					this.Hide();
					db.Show();
					

				}
				else
				{
					MessageBox.Show("The trip has already been booked!!!!");
				}
			}

		}

		/// <summary>
		/// Static variables to assign them values of the variables 
		/// </summary> 
		public static int tripID { get; set; }

		public static string tsd { get; set; }

		public static string ted { get; set; }

		public static decimal price { get; set; }

		public static string insurance { get; set; }

		public static string tOrigin { get; set; }

		public static string destination { get; set; }

		/// <summary>
		/// Method to go back to the dashboard
		/// </summary> 
		private void btnHome_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 form2 = new Form2();
			form2.Show();
		}
	}
}
