/// <summary>
/// Author: Anu Mahay
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class DealBook : Form
	{
		/// <summary>
		/// The class initialize a dataTime variable and inserts the value in a label
		/// </summary>
		public DealBook()
		{
			InitializeComponent();
			var dateAndTime = DateTime.Now.ToString("yyyy-MM-dd");
			dateLabel.Text = dateAndTime.ToString();

			System.Diagnostics.Debug.WriteLine("The information from class: " + ShowDeals.tripID + ShowDeals.destination + ShowDeals.tOrigin + ShowDeals.ted);
		}

		private void DealBook_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'hotel._Hotel' table.
			// You can move, or remove it, as needed.
			this.hotelTableAdapter.Fill(this.hotel._Hotel);

		}

		/// <summary>
		/// btnBookdeal method executes the code which will grab values 
		/// from the prebooked deals and grabs the new information
		/// and sends it to the trip table
		/// </summary>

		private void btnBookdeal_Click(object sender, EventArgs e)
		{
			var dateAndTime = DateTime.Now.ToString("yyyy-MM-dd");
			
			int tripId = ShowDeals.tripID;
			string tsd = ShowDeals.tsd;
			string ted = ShowDeals.ted;
			string origin = ShowDeals.tOrigin;
			string destination = ShowDeals.destination;
			decimal price = ShowDeals.price;
			string bookingDate = dateAndTime;

			System.Diagnostics.Debug.WriteLine("Trip ID: " + tripId);

			TripDataset td = new TripDataset();
			TripDataSet2 td2 = new TripDataSet2();

			TripDatasetTableAdapters.CustomerTableAdapter tdCustomer
				= new TripDatasetTableAdapters.CustomerTableAdapter();

			TripDatasetTableAdapters.TripBookedTableAdapter tdBooked
				= new TripDatasetTableAdapters.TripBookedTableAdapter();

			TripDatasetTableAdapters.TripTableAdapter tdTrip
				= new TripDatasetTableAdapters.TripTableAdapter();

			
			TripDataset.TripBookedRow rowBook = td.TripBooked.NewTripBookedRow();
			TripDataset.CustomerRow rowCust = td.Customer.NewCustomerRow();


			//row[0]["BookingDate"] = bookingDate.ToString();
			tdTrip.Update(td.Trip);

			rowCust.CName = tbName.Text;
			rowCust.CEmail = tbEmail.Text;
			rowCust.CPhone = Convert.ToDecimal(tbPhone.Text);

			td.Customer.Rows.Add(rowCust);
			tdCustomer.Update(td.Customer);

			DataRow[] dr = td.Tables[2].Select("CEmail=" + "'" + tbEmail.Text + "'");
			int customerId = Convert.ToInt32(dr[0]["CustomerId"]);

			/// <summary>
			/// After inserting all the data into the dataset rows of different table
			/// we grab the ids from those tables and insdert into a
			/// new table
			/// The status which is pending is changed to approve and the gridview
			/// is updates in the finally block
			/// </summary> 

			rowBook.TripID = tripId;
			rowBook.CustomerID = customerId;
			rowBook.HotelID = cbHotel.SelectedIndex;
			if (Convert.ToInt32(cbRooms.SelectedValue) == 0)
			{
				rowBook.RoomsBooked = 1;
			}
			else
			{
				rowBook.RoomsBooked = Convert.ToInt32(cbRooms.SelectedValue);
			}
			rowBook.Status = "Pending";
			rowBook.CheckInDate = tsd;
			rowBook.CheckOutDate = ted;

			td.TripBooked.Rows.Add(rowBook);
			tdBooked.Update(td.TripBooked);

			System.Diagnostics.Debug.WriteLine("Rooms: " + cbRooms.SelectedValue);
			MessageBox.Show("Deal Made!!!");
			this.Hide();
			Form2 form2 = new Form2();
			form2.Show();
		}

		/// <summary>
		///Takes user back to the dashboard
		/// </summary> 

		private void btnHome_Click(object sender, EventArgs e)
		{
			
			Form2 form2 = new Form2();
			this.Hide();
			form2.Show();
		}
	}
}
