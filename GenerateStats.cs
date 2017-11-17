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
    public partial class GenerateStats : Form
    {
        public GenerateStats()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

		private void GenerateStats_Load(object sender, EventArgs e)
		{
			profit.Series["Profits"].Points.AddXY("10", 8000);
			profit.Series["Profits"].Points.AddXY("20", 6000);
			profit.Series["Profits"].Points.AddXY("30", 4000);
			profit.Series["Profits"].Points.AddXY("40", 9000);
			profit.Series["Profits"].Points.AddXY("50", 2000);
		}
	}
}
