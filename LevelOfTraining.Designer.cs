namespace Project
{
    partial class LevelOfTraining
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
            this.levelOfTrainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.levelOfTrainingTableAdapter = new Project.GymDataSetTableAdapters.LevelOfTrainingTableAdapter();
            this.levelCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerciseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelOfTrainingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.levelCodeDataGridViewTextBoxColumn,
            this.exerciseNameDataGridViewTextBoxColumn,
            this.levelDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.levelOfTrainingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(111, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // levelOfTrainingBindingSource
            // 
            this.levelOfTrainingBindingSource.DataMember = "LevelOfTraining";
            this.levelOfTrainingBindingSource.DataSource = this.gymDataSet;
            // 
            // levelOfTrainingTableAdapter
            // 
            this.levelOfTrainingTableAdapter.ClearBeforeFill = true;
            // 
            // levelCodeDataGridViewTextBoxColumn
            // 
            this.levelCodeDataGridViewTextBoxColumn.DataPropertyName = "LevelCode";
            this.levelCodeDataGridViewTextBoxColumn.HeaderText = "LevelCode";
            this.levelCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.levelCodeDataGridViewTextBoxColumn.Name = "levelCodeDataGridViewTextBoxColumn";
            this.levelCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // exerciseNameDataGridViewTextBoxColumn
            // 
            this.exerciseNameDataGridViewTextBoxColumn.DataPropertyName = "ExerciseName";
            this.exerciseNameDataGridViewTextBoxColumn.HeaderText = "ExerciseName";
            this.exerciseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exerciseNameDataGridViewTextBoxColumn.Name = "exerciseNameDataGridViewTextBoxColumn";
            this.exerciseNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // levelDescriptionDataGridViewTextBoxColumn
            // 
            this.levelDescriptionDataGridViewTextBoxColumn.DataPropertyName = "LevelDescription";
            this.levelDescriptionDataGridViewTextBoxColumn.HeaderText = "LevelDescription";
            this.levelDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.levelDescriptionDataGridViewTextBoxColumn.Name = "levelDescriptionDataGridViewTextBoxColumn";
            this.levelDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 88);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LevelOfTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LevelOfTraining";
            this.Text = "LevelOfTraining";
            this.Load += new System.EventHandler(this.LevelOfTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelOfTrainingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource levelOfTrainingBindingSource;
        private GymDataSetTableAdapters.LevelOfTrainingTableAdapter levelOfTrainingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerciseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}