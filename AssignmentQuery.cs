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
    public partial class AssignmentQuery : Form
    {
        public AssignmentQuery()
        {
            InitializeComponent();
        }

        private void AssignmentQuery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Assignment' table. You can move, or remove it, as needed.
            this.assignmentTableAdapter.Fill(this.gymDataSet.Assignment);

        }

        private void goalsSearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.assignmentTableAdapter.GoalsSearch(this.gymDataSet.Assignment, goalsToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-RJ7CEM4L\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Assignment", con);
            da.Fill(gymDataSet.Assignment);
            dataGridView1.DataSource = gymDataSet.Assignment;
        }
    }
}
