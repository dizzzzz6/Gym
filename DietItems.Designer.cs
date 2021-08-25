namespace Project
{
    partial class DietItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gymDataSet = new Project.GymDataSet();
            this.dietItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dietItemsTableAdapter = new Project.GymDataSetTableAdapters.DietItemsTableAdapter();
            this.dietItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dietItemIDDataGridViewTextBoxColumn,
            this.dietItemNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dietItemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(211, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(369, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietItemsBindingSource
            // 
            this.dietItemsBindingSource.DataMember = "DietItems";
            this.dietItemsBindingSource.DataSource = this.gymDataSet;
            // 
            // dietItemsTableAdapter
            // 
            this.dietItemsTableAdapter.ClearBeforeFill = true;
            // 
            // dietItemIDDataGridViewTextBoxColumn
            // 
            this.dietItemIDDataGridViewTextBoxColumn.DataPropertyName = "DietItemID";
            this.dietItemIDDataGridViewTextBoxColumn.HeaderText = "DietItemID";
            this.dietItemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dietItemIDDataGridViewTextBoxColumn.Name = "dietItemIDDataGridViewTextBoxColumn";
            this.dietItemIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dietItemNameDataGridViewTextBoxColumn
            // 
            this.dietItemNameDataGridViewTextBoxColumn.DataPropertyName = "DietItemName";
            this.dietItemNameDataGridViewTextBoxColumn.HeaderText = "DietItemName";
            this.dietItemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dietItemNameDataGridViewTextBoxColumn.Name = "dietItemNameDataGridViewTextBoxColumn";
            this.dietItemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DietItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DietItems";
            this.Text = "DietItems";
            this.Load += new System.EventHandler(this.DietItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource dietItemsBindingSource;
        private GymDataSetTableAdapters.DietItemsTableAdapter dietItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}