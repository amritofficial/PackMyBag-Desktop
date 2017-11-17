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
using MetroFramework.Forms;
using Bunifu.Framework;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
		/// <summary>
		/// The class initializes a dataTime variable and inserts it into a label
		/// </summary>
        public Form1()
        {
            InitializeComponent();
			tbPassword.MaxLength = 10;
			var dateAndTime = DateTime.Now.ToString("yyyy-MM-dd");
			//var date = dateAndTime.Date;
			System.Diagnostics.Debug.WriteLine("Date is : " + dateAndTime);
		}

		//private SqlConnection conn = new SqlConnection();
		//private string connString = "Server=(local); Database=PackMyBag; User=singh12345; Password=12345";
		//private SqlCommand cmd;
		private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

		}

		/// <summary>
		/// Custom button method to minimize the window
		/// </summary> 
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
		}

		/// <summary>
		/// Custom button method to close the window
		/// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		public static string userName = "";

		/// <summary>
		/// Connects to the database using the connected model approach
		/// and signs in 
		/// </summary> 
		private void btnSignin_Click(object sender, EventArgs e)
        {
			string user = tbUser.Text;
			userName = user;
			string password = tbPassword.Text;
			System.Diagnostics.Debug.WriteLine("The name and password " + user + password);
			SqlConnection conn = new SqlConnection();
			string connString = "Server=(local); Database=PackMyBag; User=" + user + "; Password=" + password + ";";

			Form2 frm = new Form2();

			try
			{
				conn = new SqlConnection(connString);
				conn.Open();

				if (!(conn.State == ConnectionState.Closed))
				{
					System.Diagnostics.Debug.WriteLine("the user from form 1 is " + user);
					User.setUser(user);

					this.Hide();
					frm.Show();
				}
				else
				{
					MessageBox.Show("Connection Failed", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error in connection : " + ex.Message);
			}
			//this.Hide();
			//Form2 frm = new Form2();
			//frm.Show();

		}
    }
}
