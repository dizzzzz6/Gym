namespace Project
{
    partial class AssignmentQuery
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
            this.assignmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new Project.GymDataSet();
            this.assignmentTableAdapter = new Project.GymDataSetTableAdapters.AssignmentTableAdapter();
            this.goalsSearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.goalsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.goalsToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.goalsSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            this.goalsSearchToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignmentIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.goalsDataGridViewTextBoxColumn,
            this.assignmentDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assignmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(536, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // assignmentIDDataGridViewTextBoxColumn
            // 
            this.assignmentIDDataGridViewTextBoxColumn.DataPropertyName = "AssignmentID";
            this.assignmentIDDataGridViewTextBoxColumn.HeaderText = "AssignmentID";
            this.assignmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assignmentIDDataGridViewTextBoxColumn.Name = "assignmentIDDataGridViewTextBoxColumn";
            this.assignmentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // goalsDataGridViewTextBoxColumn
            // 
            this.goalsDataGridViewTextBoxColumn.DataPropertyName = "Goals";
            this.goalsDataGridViewTextBoxColumn.HeaderText = "Goals";
            this.goalsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goalsDataGridViewTextBoxColumn.Name = "goalsDataGridViewTextBoxColumn";
            this.goalsDataGridViewTextBoxColumn.Width = 125;
            // 
            // assignmentDateDataGridViewTextBoxColumn
            // 
            this.assignmentDateDataGridViewTextBoxColumn.DataPropertyName = "AssignmentDate";
            this.assignmentDateDataGridViewTextBoxColumn.HeaderText = "AssignmentDate";
            this.assignmentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assignmentDateDataGridViewTextBoxColumn.Name = "assignmentDateDataGridViewTextBoxColumn";
            this.assignmentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // assignmentBindingSource
            // 
            this.assignmentBindingSource.DataMember = "Assignment";
            this.assignmentBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignmentTableAdapter
            // 
            this.assignmentTableAdapter.ClearBeforeFill = true;
            // 
            // goalsSearchToolStrip
            // 
            this.goalsSearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.goalsSearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goalsToolStripLabel,
            this.goalsToolStripTextBox,
            this.goalsSearchToolStripButton});
            this.goalsSearchToolStrip.Location = new System.Drawing.Point(0, 0);
            this.goalsSearchToolStrip.Name = "goalsSearchToolStrip";
            this.goalsSearchToolStrip.Size = new System.Drawing.Size(800, 27);
            this.goalsSearchToolStrip.TabIndex = 1;
            this.goalsSearchToolStrip.Text = "goalsSearchToolStrip";
            // 
            // goalsToolStripLabel
            // 
            this.goalsToolStripLabel.Name = "goalsToolStripLabel";
            this.goalsToolStripLabel.Size = new System.Drawing.Size(49, 24);
            this.goalsToolStripLabel.Text = "Goals:";
            // 
            // goalsToolStripTextBox
            // 
            this.goalsToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.goalsToolStripTextBox.Name = "goalsToolStripTextBox";
            this.goalsToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // goalsSearchToolStripButton
            // 
            this.goalsSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.goalsSearchToolStripButton.Name = "goalsSearchToolStripButton";
            this.goalsSearchToolStripButton.Size = new System.Drawing.Size(94, 24);
            this.goalsSearchToolStripButton.Text = "GoalsSearch";
            this.goalsSearchToolStripButton.Click += new System.EventHandler(this.goalsSearchToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssignmentQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goalsSearchToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AssignmentQuery";
            this.Text = "AssignmentQuery";
            this.Load += new System.EventHandler(this.AssignmentQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            this.goalsSearchToolStrip.ResumeLayout(false);
            this.goalsSearchToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource assignmentBindingSource;
        private GymDataSetTableAdapters.AssignmentTableAdapter assignmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip goalsSearchToolStrip;
        private System.Windows.Forms.ToolStripLabel goalsToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox goalsToolStripTextBox;
        private System.Windows.Forms.ToolStripButton goalsSearchToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}