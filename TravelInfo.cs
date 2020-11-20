using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVIDDashboard
{
    public partial class TravelInfo : Form
    {
        public TravelInfo()
        {
            InitializeComponent();
        }

        private void TravelInfo_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(0, bunifuImageButton1.Location.Y);
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(0, bunifuImageButton3.Location.Y);
            this.Hide();
            InsertEmployee insertEmployee = new InsertEmployee();
            insertEmployee.Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(0, bunifuImageButton4.Location.Y);
            this.Hide();

        }
    }
}
