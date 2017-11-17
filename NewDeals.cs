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
	public partial class NewDeals : Form
	{
		public NewDeals()
		{
			InitializeComponent();
		}

		private void NewDeals_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'tripDataset.Trip' table. You can move, or remove it, as needed.
			

		}

		private void tbDestination_TextChanged(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Redirects the user to the home page 
		/// </summary>
		private void btnHome_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 form2 = new Form2();
			form2.Show();
		}

		/// <summary>
		/// Method will use a dataset to insert all the values into a dataset
		/// and then grab them later for use in data grid view
		/// </summary> 
		private void btnCreate_Click(object sender, EventArgs e)
		{
			TripDataSet2 td = new TripDataSet2();
			TripDataSet2TableAdapters.TripTableAdapter tdTrip
				= new TripDataSet2TableAdapters.TripTableAdapter();

			TripDataSet2.TripRow rowTrip = td.Trip.NewTripRow();
			string insurance = "N";
			if (cbInsurance.Text.Equals("YES"))
			{
				insurance = "Y";
			}
			else
			{
				insurance = "N";
			}

			rowTrip.BookingDate = null;
			rowTrip.TripStartDate = tripSD.Value.ToString();
			rowTrip.TripEndDate = tripED.Value.ToString();
			rowTrip.TotalPrice = Convert.ToDecimal(tbPrice.Text);
			rowTrip.Origin = tbOrigin.Text;
			rowTrip.Destination = tbDestination.Text;
			rowTrip.TripInsurance = insurance;

			td.Trip.Rows.Add(rowTrip);
			tdTrip.Update(td.Trip);

			MessageBox.Show("Query Successful!!!");
		}

		/// <summary>
		/// Redirects user to the show deals form page
		/// </summary> 
		private void btnShowdeals_Click(object sender, EventArgs e)
		{
			this.Hide();
			ShowDeals sd = new ShowDeals();
			sd.Show();
		}
	}
}
