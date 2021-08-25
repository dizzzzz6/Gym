using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class DietQuery : Form
    {
        public DietQuery()
        {
            InitializeComponent();
        }

        private void DietQuery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Diet' table. You can move, or remove it, as needed.
            this.dietTableAdapter.Fill(this.gymDataSet.Diet);

        }

        private void dietItemQuantitysearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dietTableAdapter.DietItemQuantitysearch(this.gymDataSet.Diet, dietItemQuantityToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-RJ7CEM4L\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Diet", con);
            da.Fill(gymDataSet.Diet);
            dataGridView1.DataSource = gymDataSet.Diet;
        }
    }
}
