/// <summary>
/// Author: Amrit Pal Singh
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
	public partial class TripRequest : Form
	{
		public TripRequest()
		{
			InitializeComponent();
		
		}
		SqlConnection conn = new SqlConnection();

		/// <summary>
		/// This method will load when the form opens and it will use connected model
		/// to grab all the information into a data gridview with a status depending on the
		/// platform from where the trip is booked
		/// </summary> 
		private void TripRequest_Load(object sender, EventArgs e)
		{
			gvTripRequest.AllowUserToAddRows = false;
			conn.ConnectionString = "Server=(local); Database=PackMyBag; User=singh12345; Password=12345";
			SqlCommand cmd = conn.CreateCommand();

			try
			{
				string query = "SELECT t.TripID, t.CustomerID, c.CName, HotelID, Status, RoomsBooked, p.TripInsurance, Origin, Destination, t.CheckInDate, t.CheckOutDate FROM TripBooked t INNER JOIN Trip p ON t.TripID = p.TripID INNER JOIN Customer c ON t.CustomerID = c.CustomerID; ";
				cmd.CommandText = query;
				conn.Open();

				SqlDataReader reader = cmd.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(reader);

				gvTripRequest.DataSource = dt;
				reader.Close();
			}
			catch (Exception ex)
			{

			}
			finally
			{
				cmd.Dispose();
				conn.Close();
			}
		}

		/// <summary>
		/// This method runs when the user clicks the approve button in each row of gridview
		/// to change the status of the trip table from pending to approve depending upon
		/// the platform from where the trip is booked.
		/// It will update the table and run the query again in the finally block
		/// to bind it to the data gridview again
		/// </summary> 
		private void gvTripRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string column = gvTripRequest.Columns[e.ColumnIndex].Name.ToString();
			System.Diagnostics.Debug.WriteLine("Column: " + column);
			conn.ConnectionString = "Server=(local); Database=PackMyBag; User=singh12345; Password=12345";
			SqlCommand cmd = conn.CreateCommand();

			if (gvTripRequest.Columns[e.ColumnIndex].Name == "btnApprove")
			{
				int selectedRow = gvTripRequest.SelectedCells[0].RowIndex;
				string status = Convert.ToString(gvTripRequest.Rows[selectedRow].Cells["Status"].Value);

				if (status.Equals("Approved"))
				{
					MessageBox.Show("The Trip is already approved!!!");
				}
				else
				{
					int value = Convert.ToInt32(gvTripRequest.Rows[selectedRow].Cells["CustomerId"].Value);
					int tripID = Convert.ToInt32(gvTripRequest.Rows[selectedRow].Cells["TripID"].Value);
					try
					{
						
						string query = "UPDATE TripBooked SET Status='Approved' WHERE CustomerID=" + value + ";";

						cmd.CommandText = query;
						conn.Open();

						cmd.ExecuteScalar();

						System.Diagnostics.Debug.WriteLine("The index of the selected row is: " + selectedRow + " TripID: " + tripID);

						string bookingDate = DateTime.Now.ToString("yyyyMMddHHmmss");
						string query2 = "UPDATE Trip SET BookingDate=" + bookingDate +" WHERE TripID=" + tripID + ";";
						cmd.CommandText = query2;
						cmd.ExecuteScalar();
					}
					catch (Exception ex)
					{

					}
					finally
					{
						string query = "SELECT t.TripID, t.CustomerID, c.CName, HotelID, Status, RoomsBooked, p.TripInsurance, Origin, Destination, t.CheckInDate, t.CheckOutDate FROM TripBooked t INNER JOIN Trip p ON t.TripID = p.TripID INNER JOIN Customer c ON t.CustomerID = c.CustomerID;";
						cmd.CommandText = query;
						SqlDataReader reader = cmd.ExecuteReader();
						DataTable dt = new DataTable();
						dt.Load(reader);

						gvTripRequest.DataSource = dt;
						reader.Close();

						cmd.Dispose();
						conn.Close();
					}
				}

			}
		}

		/// <summary>
		/// This button brings you back to the dashboard
		/// </summary> 
		private void btnHome_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 form2 = new Form2();
			form2.Show();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void bunifuImageButton4_Click(object sender, EventArgs e)
		{

		}

		private void bunifuImageButton5_Click(object sender, EventArgs e)
		{

		}
	}
}
