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
    public partial class ExerciseQuery : Form
    {
        public ExerciseQuery()
        {
            InitializeComponent();
        }

        private void ExerciseQuery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Exercise' table. You can move, or remove it, as needed.
            this.exerciseTableAdapter.Fill(this.gymDataSet.Exercise);

        }

        private void descriptionSearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.exerciseTableAdapter.DescriptionSearch(this.gymDataSet.Exercise, exerciseDescriptionToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-RJ7CEM4L\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Exercise", con);
            da.Fill(gymDataSet.Exercise);
            dataGridView1.DataSource = gymDataSet.Exercise;
        }
    }
}
