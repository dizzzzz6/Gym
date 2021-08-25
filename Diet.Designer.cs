namespace Project
{
    partial class Diet
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
            this.gymDataSet = new Project.GymDataSet();
            this.exerciseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exerciseTableAdapter = new Project.GymDataSetTableAdapters.ExerciseTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dietTableAdapter = new Project.GymDataSetTableAdapters.DietTableAdapter();
            this.dietIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietItemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exerciseBindingSource
            // 
            this.exerciseBindingSource.DataMember = "Exercise";
            this.exerciseBindingSource.DataSource = this.gymDataSet;
            // 
            // exerciseTableAdapter
            // 
            this.exerciseTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dietIDDataGridViewTextBoxColumn,
            this.dietItemIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.dietDateDataGridViewTextBoxColumn,
            this.dietItemQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dietBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 299);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dietBindingSource
            // 
            this.dietBindingSource.DataMember = "Diet";
            this.dietBindingSource.DataSource = this.gymDataSet;
            // 
            // dietTableAdapter
            // 
            this.dietTableAdapter.ClearBeforeFill = true;
            // 
            // dietIDDataGridViewTextBoxColumn
            // 
            this.dietIDDataGridViewTextBoxColumn.DataPropertyName = "DietID";
            this.dietIDDataGridViewTextBoxColumn.HeaderText = "DietID";
            this.dietIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dietIDDataGridViewTextBoxColumn.Name = "dietIDDataGridViewTextBoxColumn";
            this.dietIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dietItemIDDataGridViewTextBoxColumn
            // 
            this.dietItemIDDataGridViewTextBoxColumn.DataPropertyName = "DietItemID";
            this.dietItemIDDataGridViewTextBoxColumn.HeaderText = "DietItemID";
            this.dietItemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dietItemIDDataGridViewTextBoxColumn.Name = "dietItemIDDataGridViewTextBoxColumn";
            this.dietItemIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dietDateDataGridViewTextBoxColumn
            // 
            this.dietDateDataGridViewTextBoxColumn.DataPropertyName = "DietDate";
            this.dietDateDataGridViewTextBoxColumn.HeaderText = "DietDate";
            this.dietDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dietDateDataGridViewTextBoxColumn.Name = "dietDateDataGridViewTextBoxColumn";
            this.dietDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // dietItemQuantityDataGridViewTextBoxColumn
            // 
            this.dietItemQuantityDataGridViewTextBoxColumn.DataPropertyName = "DietItemQuantity";
            this.dietItemQuantityDataGridViewTextBoxColumn.HeaderText = "DietItemQuantity";
            this.dietItemQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dietItemQuantityDataGridViewTextBoxColumn.Name = "dietItemQuantityDataGridViewTextBoxColumn";
            this.dietItemQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Diet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Diet";
            this.Text = "Diet";
            this.Load += new System.EventHandler(this.Diet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource exerciseBindingSource;
        private GymDataSetTableAdapters.ExerciseTableAdapter exerciseTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dietBindingSource;
        private GymDataSetTableAdapters.DietTableAdapter dietTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietItemQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}