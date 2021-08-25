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
    public partial class DietItemsQuery : Form
    {
        public DietItemsQuery()
        {
            InitializeComponent();
        }

        private void DietItemsQuery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.DietItems' table. You can move, or remove it, as needed.
            this.dietItemsTableAdapter.Fill(this.gymDataSet.DietItems);

        }

        private void dietItemNameSearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dietItemsTableAdapter.DietItemNameSearch(this.gymDataSet.DietItems, dietItemNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-RJ7CEM4L\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from DietItems", con);
            da.Fill(gymDataSet.DietItems);
            dataGridView1.DataSource = gymDataSet.DietItems;
        }
    }
}
