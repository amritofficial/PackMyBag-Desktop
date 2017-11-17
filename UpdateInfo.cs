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
	public partial class UpdateInfo : Form
	{
		public UpdateInfo()
		{
			InitializeComponent();
		}

		private void UpdateInfo_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'tripDataSet2.TripBooked' table. You can move, or remove it, as needed.
			this.tripBookedTableAdapter1.Fill(this.tripDataSet2.TripBooked);
			// TODO: This line of code loads data into the 'tripDataset.TripBooked' table. You can move, or remove it, as needed.
			this.tripBookedTableAdapter.Fill(this.tripDataset.TripBooked);
			// TODO: This line of code loads data into the 'tripDataset.Customer' table. You can move, or remove it, as needed.
			this.customerTableAdapter.Fill(this.tripDataset.Customer);

		}

		/// <summary>
		/// Takes user back to the home page
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnHome_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.Show();
			this.Hide();
		}

		private static int CustomerID;
		private static int bookingID;

		/// <summary>
		/// It is a combobox function which will be executed when a selection is made
		/// it will connect to a connected model and grab all the information 
		/// and insert it into requisite text boxes to be edited
		/// </summary> 
		private void cbBookingid_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection();
			
			//System.Diagnostics.Debug.WriteLine("Value: " + value);

			conn.ConnectionString = "Server=(local); Database=PackMyBag; User=singh12345; Password=12345";

			SqlCommand cmd = conn.CreateCommand();

			try
			{
				string value = cbBookingid.SelectedValue.ToString();
				string query = "SELECT c.CustomerID, RoomsBooked, HotelID, c.CEmail, c.CName, c.CPhone FROM TripBooked t INNER JOIN Customer c ON t.CustomerID = c.CustomerID WHERE t.BookingId=" + Convert.ToInt32(value) + ";";
				cmd.CommandText = query;
				conn.Open();

				SqlDataReader reader = cmd.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(reader);

				UpdateInfo.bookingID = Convert.ToInt32(value);

				int customerId = dt.Rows[0].Field<int>("CustomerID");
				string name = dt.Rows[0].Field<string>("CName");
				string email = dt.Rows[0].Field<string>("CEmail");
				int rooms = dt.Rows[0].Field<int>("RoomsBooked");
				string phone = dt.Rows[0].Field<string>("CPhone");
				System.Diagnostics.Debug.WriteLine("The name is " + name + " " + email + " " + rooms + " " + phone);

				UpdateInfo.CustomerID = customerId;

				tbName.Text = name;
				tbEmail.Text = email;
				tbRooms.Text = rooms.ToString();
				tbPhone.Text = phone;
				
			}
			catch (Exception ex)
			{

			}
			finally
			{
				conn.Close();
				cmd.Dispose();
			}

		}

		Form2 form2 = new Form2();
		/// <summary>
		/// This button will update all the changed information by connecting to
		/// a connected model depending upon their ids 
		/// </summary> 
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = "Server=(local); Database=PackMyBag; User=singh12345; Password=12345";
			SqlCommand cmd = conn.CreateCommand();

			string name = tbName.Text;
			string email = tbEmail.Text;
			int rooms = Convert.ToInt32(tbRooms.Text);
			decimal phone = Convert.ToDecimal(tbPhone.Text);

			System.Diagnostics.Debug.WriteLine("CustomerID: " + CustomerID);

			try
			{
				string query = "UPDATE Customer SET CName='" + name + "', CEmail='" + email + "', CPhone=" + phone + " WHERE CustomerID=" + CustomerID + ";";
				string query2 = "UPDATE TripBooked SET RoomsBooked=" + rooms + " WHERE BookingID=" + bookingID + ";";

				conn.Open();
				cmd.CommandText = query;
				cmd.ExecuteScalar();

				cmd.CommandText = query2;
				cmd.ExecuteScalar();

				MessageBox.Show("Information Updated!!!");
			}
			catch(Exception ex)
			{

			}
			finally
			{
				cmd.Dispose();
				conn.Close();	
			}
		}


	}
}
