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
    public partial class Diet : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVOK79UL\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public Diet()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select * from Diet", con);
            this.dietTableAdapter.Fill(this.gymDataSet.Diet);
        }

        private void Diet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Diet' table. You can move, or remove it, as needed.
            this.dietTableAdapter.Fill(this.gymDataSet.Diet);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sda;
            sda = new SqlCommandBuilder(da);
            da.Update(gymDataSet.Diet);
            MessageBox.Show("Passed Succesfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
