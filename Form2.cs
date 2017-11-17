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
    public partial class Form2 : Form
    {
		Form1 form1 = new Form1();
		
		/// <summary>
		/// The class initialize a variable and gets its value and inserts it in label
		/// </summary>
        public Form2()
        {
			User userInfo = new User();
            InitializeComponent();
			
			string username = User.getUser();
			userText.Text = "WELCOME " + Form1.userName.ToUpper();
		}


		/// <summary>
		/// The following method will send the user to the Trip Request
		/// Form page 
		/// </summary>
		private void btnGenerateStats_Click(object sender, EventArgs e)
        {
			TripRequest tr = new TripRequest();
            tr.Show();
            this.Hide();
		}

		/// <summary>
		/// The following method will direct the user to the 
		/// create Trip form
		/// </summary>
		private void btnTrip_Click(object sender, EventArgs e)
		{
			this.Hide();
			CreateTrip ct = new CreateTrip();
			ct.Show();
		}
		/// <summary>
		/// Redirects the user to the Form1
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bunifuFlatButton3_Click(object sender, EventArgs e)
		{
			this.Hide();
			form1.Show();
		}

		/// <summary>
		/// The method will direct users to the About Us form page
		/// </summary>
		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
			this.Hide();
			AboutUs about = new AboutUs();
			about.Show();
		}

		/// <summary>
		/// The method will direct users to the New Deals form page
		/// </summary>
		private void btnNewDeals_Click(object sender, EventArgs e)
		{
			NewDeals nd = new NewDeals();
			this.Hide();
			nd.Show();
		}

		/// <summary>
		/// The method which executes the code and opens a connection on 
		/// Form2 load, it will run a query and grab the numbers of customers
		/// that made a deal and will insert it in a label
		/// </summary> 
		private void Form2_Load(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = "Server=(local); Database=PackMyBag; User=singh12345; Password=12345";
			SqlCommand cmd = conn.CreateCommand();

			try
			{
				string query = "Select Count(*) FROM customer";
				cmd.CommandText = query;
				conn.Open();
				
				int count = (int)cmd.ExecuteScalar();
				//SqlDataReader reader = cmd.ExecuteReader();
				customerCount.Text = count.ToString();
				//System.Diagnostics.Debug.WriteLine("The value of the query is: " + count);

			}
			catch (Exception ex)
			{

			}
			finally{
				cmd.Dispose();
				conn.Close();
			}
		}

		/// <summary>
		/// The form redirects the user to the Update Info form page
		/// </summary>
		private void btnUpdateInfo_Click(object sender, EventArgs e)
		{
			UpdateInfo ui = new UpdateInfo();
			this.Hide();

			ui.Show();
		}
	}
}
