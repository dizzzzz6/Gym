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
    public partial class TrainerProfileQuery : Form
    {
        public TrainerProfileQuery()
        {
            InitializeComponent();
        }

        private void TrainerProfileQuery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.TrainerProfile' table. You can move, or remove it, as needed.
            this.trainerProfileTableAdapter.Fill(this.gymDataSet.TrainerProfile);

        }

        private void trainerNameSearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.trainerProfileTableAdapter.TrainerNameSearch(this.gymDataSet.TrainerProfile, trainerNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void addressSearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.trainerProfileTableAdapter.AddressSearch(this.gymDataSet.TrainerProfile, addressToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-RJ7CEM4L\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from TrainerProfile", con);
            da.Fill(gymDataSet.TrainerProfile);
            dataGridView1.DataSource = gymDataSet.TrainerProfile;
        }
    }
}
