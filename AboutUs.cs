/*
 * Author: Anu Mahay
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class AboutUs : Form
	{
		/// <summary>
		///This method will change the square image into a circular frame
		/// </summary>
		public AboutUs()
		{
			InitializeComponent();
			//pbAnu.Image = Image.FromFile("/images/anu.jpg");
			GraphicsPath gp = new GraphicsPath();
			gp.AddEllipse(pbAnu.DisplayRectangle);
			pbAnu.Region = new Region(gp);
			pbVannie.Region = new Region(gp);
			pbJas.Region = new Region(gp);
			pbKim.Region = new Region(gp);
		}

		Form2 form2 = new Form2();

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void bunifuGradientPanel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// Method to redirect user to home windows form
		/// </summary>
		private void btnHome_Click(object sender, EventArgs e)
		{
			this.Hide();
			form2.Show();
		}
	}
}
