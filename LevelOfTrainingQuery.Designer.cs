namespace Project
{
    partial class LevelOfTrainingQuery
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
            this.levelCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerciseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelOfTrainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new Project.GymDataSet();
            this.levelOfTrainingTableAdapter = new Project.GymDataSetTableAdapters.LevelOfTrainingTableAdapter();
            this.levelDescriptionSearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.levelDescriptionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.levelDescriptionToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.levelDescriptionSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exerciseNameSearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.exerciseNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.exerciseNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.exerciseNameSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelOfTrainingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            this.levelDescriptionSearchToolStrip.SuspendLayout();
            this.exerciseNameSearchToolStrip.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(505, 233);
            this.dataGridView1.TabIndex = 0;
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
            // levelOfTrainingBindingSource
            // 
            this.levelOfTrainingBindingSource.DataMember = "LevelOfTraining";
            this.levelOfTrainingBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // levelOfTrainingTableAdapter
            // 
            this.levelOfTrainingTableAdapter.ClearBeforeFill = true;
            // 
            // levelDescriptionSearchToolStrip
            // 
            this.levelDescriptionSearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.levelDescriptionSearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelDescriptionToolStripLabel,
            this.levelDescriptionToolStripTextBox,
            this.levelDescriptionSearchToolStripButton});
            this.levelDescriptionSearchToolStrip.Location = new System.Drawing.Point(0, 0);
            this.levelDescriptionSearchToolStrip.Name = "levelDescriptionSearchToolStrip";
            this.levelDescriptionSearchToolStrip.Size = new System.Drawing.Size(800, 27);
            this.levelDescriptionSearchToolStrip.TabIndex = 1;
            this.levelDescriptionSearchToolStrip.Text = "levelDescriptionSearchToolStrip";
            // 
            // levelDescriptionToolStripLabel
            // 
            this.levelDescriptionToolStripLabel.Name = "levelDescriptionToolStripLabel";
            this.levelDescriptionToolStripLabel.Size = new System.Drawing.Size(122, 24);
            this.levelDescriptionToolStripLabel.Text = "LevelDescription:";
            // 
            // levelDescriptionToolStripTextBox
            // 
            this.levelDescriptionToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.levelDescriptionToolStripTextBox.Name = "levelDescriptionToolStripTextBox";
            this.levelDescriptionToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // levelDescriptionSearchToolStripButton
            // 
            this.levelDescriptionSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.levelDescriptionSearchToolStripButton.Name = "levelDescriptionSearchToolStripButton";
            this.levelDescriptionSearchToolStripButton.Size = new System.Drawing.Size(167, 24);
            this.levelDescriptionSearchToolStripButton.Text = "LevelDescriptionSearch";
            this.levelDescriptionSearchToolStripButton.Click += new System.EventHandler(this.levelDescriptionSearchToolStripButton_Click);
            // 
            // exerciseNameSearchToolStrip
            // 
            this.exerciseNameSearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.exerciseNameSearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciseNameToolStripLabel,
            this.exerciseNameToolStripTextBox,
            this.exerciseNameSearchToolStripButton});
            this.exerciseNameSearchToolStrip.Location = new System.Drawing.Point(0, 27);
            this.exerciseNameSearchToolStrip.Name = "exerciseNameSearchToolStrip";
            this.exerciseNameSearchToolStrip.Size = new System.Drawing.Size(800, 27);
            this.exerciseNameSearchToolStrip.TabIndex = 2;
            this.exerciseNameSearchToolStrip.Text = "exerciseNameSearchToolStrip";
            // 
            // exerciseNameToolStripLabel
            // 
            this.exerciseNameToolStripLabel.Name = "exerciseNameToolStripLabel";
            this.exerciseNameToolStripLabel.Size = new System.Drawing.Size(105, 24);
            this.exerciseNameToolStripLabel.Text = "ExerciseName:";
            // 
            // exerciseNameToolStripTextBox
            // 
            this.exerciseNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exerciseNameToolStripTextBox.Name = "exerciseNameToolStripTextBox";
            this.exerciseNameToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // exerciseNameSearchToolStripButton
            // 
            this.exerciseNameSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exerciseNameSearchToolStripButton.Name = "exerciseNameSearchToolStripButton";
            this.exerciseNameSearchToolStripButton.Size = new System.Drawing.Size(150, 24);
            this.exerciseNameSearchToolStripButton.Text = "ExerciseNameSearch";
            this.exerciseNameSearchToolStripButton.Click += new System.EventHandler(this.exerciseNameSearchToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LevelOfTrainingQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exerciseNameSearchToolStrip);
            this.Controls.Add(this.levelDescriptionSearchToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LevelOfTrainingQuery";
            this.Text = "LevelOfTrainingQuery";
            this.Load += new System.EventHandler(this.LevelOfTrainingQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelOfTrainingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            this.levelDescriptionSearchToolStrip.ResumeLayout(false);
            this.levelDescriptionSearchToolStrip.PerformLayout();
            this.exerciseNameSearchToolStrip.ResumeLayout(false);
            this.exerciseNameSearchToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource levelOfTrainingBindingSource;
        private GymDataSetTableAdapters.LevelOfTrainingTableAdapter levelOfTrainingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerciseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip levelDescriptionSearchToolStrip;
        private System.Windows.Forms.ToolStripLabel levelDescriptionToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox levelDescriptionToolStripTextBox;
        private System.Windows.Forms.ToolStripButton levelDescriptionSearchToolStripButton;
        private System.Windows.Forms.ToolStrip exerciseNameSearchToolStrip;
        private System.Windows.Forms.ToolStripLabel exerciseNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox exerciseNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton exerciseNameSearchToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}