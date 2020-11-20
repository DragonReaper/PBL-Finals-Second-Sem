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
    public partial class SearchButton : Form
    {
        public DataTable countryData { get; set; }
        public SearchButton()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuTextbox1.Text = string.Empty;
        }

        private void SearchButton_Load(object sender, EventArgs e)
        {
            bunifuTextbox1.Focus();
            gunaDataGridView1.DataSource = countryData;
        
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchButton_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
