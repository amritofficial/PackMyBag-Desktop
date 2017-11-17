/// <summary>
///Author: Amrit Pal Singh
///</summary>
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
	public partial class CreateTrip : Form
	{
		/// <summary>
		/// The class initializes the dateTime and inserts it into a label
		/// </summary>
		public CreateTrip()
		{
			InitializeComponent();
			var dateAndTime = DateTime.Now.ToString("yyyy-MM-dd");
			dateLabel.Text = dateAndTime.ToString();
		}

		private void CreateTrip_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'hotel._Hotel' table. You can move, or remove it, as needed.
			this.hotelTableAdapter.Fill(this.hotel._Hotel);

		}

		Form2 form2 = new Form2();

		/// <summary>
		/// The method will validate name field
		/// If they are filled it will show an alert box
		/// to discard changes
		/// </summary> 
		private void btnHome_Click(object sender, EventArgs e)
		{
			if (!(string.IsNullOrWhiteSpace(tbName.Text)))
			{
				DialogResult dialogResult = MessageBox.Show("All changes will be discarded, Continue?", "Changes Made!!!", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					tbName.Clear();
					tbDestination.Clear();
					tbOrigin.Clear();
					tbPrice.Clear();
					tbDiscount.Clear();

					this.Hide();
					
					form2.Show();
				}
				else if (dialogResult == DialogResult.No)
				{
					
				}
			}
			else
			{
				this.Hide();
				form2.Show();
			}
			
		}
		/// <summary>
		///Grab all the information into dataset rows and fill it in the requisite tables 
		/// to be fetched later by the trip request form.
		/// </summary> 
		private void btnSubmit_Click(object sender, EventArgs e)
		{
			TripDataset td = new TripDataset();
			TripDatasetTableAdapters.CustomerTableAdapter tdCustomer 
				= new TripDatasetTableAdapters.CustomerTableAdapter();

			TripDatasetTableAdapters.TripTableAdapter tdTrip
				= new TripDatasetTableAdapters.TripTableAdapter();

			TripDatasetTableAdapters.TripBookedTableAdapter tdBooked
				= new TripDatasetTableAdapters.TripBookedTableAdapter();

			tdCustomer.Fill(td.Customer);
			tdTrip.Fill(td.Trip);

			TripDataset.CustomerRow rowCust = td.Customer.NewCustomerRow();
			TripDataset.TripRow rowTrip = td.Trip.NewTripRow();
			TripDataset.TripBookedRow rowBooked = td.TripBooked.NewTripBookedRow();

			rowCust.CName = tbName.Text;
			rowCust.CEmail = tbEmail.Text;
			rowCust.CPhone = Convert.ToDecimal(tbPhone.Text);

			rowTrip.Origin = tbOrigin.Text;
			rowTrip.Destination = tbDestination.Text;
			var dateAndTime = DateTime.Now.ToString("yyyy-MM-dd");
			rowTrip.BookingDate = DateTime.Now.Date.ToString("yyyy-MM-dd");
			rowTrip.TripStartDate = tripSD.Value.ToString();
			rowTrip.TripEndDate = tripED.Value.ToString();
			rowTrip.TotalPrice = Convert.ToDecimal(tbPrice.Text);

			

			//System.Diagnostics.Debug.WriteLine("Hotel: " + rowBooked.HotelID);

			if (cbInsurance.Text.Equals("YES"))
			{
				rowTrip.TripInsurance = "Y";
			}
			else
			{
				rowTrip.TripInsurance = "N";
			}
			
			td.Customer.Rows.Add(rowCust);
			td.Trip.Rows.Add(rowTrip);

			tdCustomer.Update(td.Customer);
			tdTrip.Update(td.Trip);

			rowBooked.HotelID = cbHotel.SelectedIndex;

			DataRow[] dr = td.Tables[2].Select("CName=" + "'" + tbName.Text + "'");
			int customerId = Convert.ToInt32(dr[0]["CustomerId"]);
			DataRow[] dr2 = td.Tables[0].Select("BookingDate='" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' AND Origin='" + tbOrigin.Text + "' AND Destination='"+tbDestination.Text+"'");

			System.Diagnostics.Debug.WriteLine(dr2[0]);
			
			int tripId = Convert.ToInt32(dr2[0]["TripID"]);


			rowBooked.RoomsBooked = 1;
			rowBooked.CheckInDate = tripSD.Value.ToString();
			rowBooked.CheckOutDate = tripED.Value.ToString();
			
			rowBooked.TripID = tripId;
			rowBooked.Status = "Approved";
			rowBooked.CustomerID = customerId;

			td.TripBooked.Rows.Add(rowBooked);
			tdBooked.Update(td.TripBooked);

			DialogResult dialogSuccess = MessageBox.Show("Trip has been booked successfully!!!", "Request Submitted!!!", MessageBoxButtons.OK);

			this.Hide();
			form2.Show();
			System.Diagnostics.Debug.WriteLine("Cname: " + tbName.Text + " " + tbEmail.Text
				+ tbOrigin.Text + rowTrip.Destination + DateTime.Now.Date + tripSD.Value + tbPhone.Text + " CustomerID: " + customerId + " Trip ID: " + tripId + " Origin: " + tbOrigin.Text + " Destination: " + tbDestination.Text);
			//regRow.CEmail = 
		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			

		}
	}
}
