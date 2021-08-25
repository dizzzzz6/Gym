namespace Project
{
    partial class DietItemsQuery
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
            this.dietItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new Project.GymDataSet();
            this.dietItemsTableAdapter = new Project.GymDataSetTableAdapters.DietItemsTableAdapter();
            this.dietItemNameSearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.dietItemNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dietItemNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dietItemNameSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            this.dietItemNameSearchToolStrip.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(505, 208);
            this.dataGridView1.TabIndex = 0;
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
            // dietItemsBindingSource
            // 
            this.dietItemsBindingSource.DataMember = "DietItems";
            this.dietItemsBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietItemsTableAdapter
            // 
            this.dietItemsTableAdapter.ClearBeforeFill = true;
            // 
            // dietItemNameSearchToolStrip
            // 
            this.dietItemNameSearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dietItemNameSearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dietItemNameToolStripLabel,
            this.dietItemNameToolStripTextBox,
            this.dietItemNameSearchToolStripButton});
            this.dietItemNameSearchToolStrip.Location = new System.Drawing.Point(0, 0);
            this.dietItemNameSearchToolStrip.Name = "dietItemNameSearchToolStrip";
            this.dietItemNameSearchToolStrip.Size = new System.Drawing.Size(800, 27);
            this.dietItemNameSearchToolStrip.TabIndex = 1;
            this.dietItemNameSearchToolStrip.Text = "dietItemNameSearchToolStrip";
            // 
            // dietItemNameToolStripLabel
            // 
            this.dietItemNameToolStripLabel.Name = "dietItemNameToolStripLabel";
            this.dietItemNameToolStripLabel.Size = new System.Drawing.Size(110, 24);
            this.dietItemNameToolStripLabel.Text = "DietItemName:";
            // 
            // dietItemNameToolStripTextBox
            // 
            this.dietItemNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dietItemNameToolStripTextBox.Name = "dietItemNameToolStripTextBox";
            this.dietItemNameToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // dietItemNameSearchToolStripButton
            // 
            this.dietItemNameSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dietItemNameSearchToolStripButton.Name = "dietItemNameSearchToolStripButton";
            this.dietItemNameSearchToolStripButton.Size = new System.Drawing.Size(155, 24);
            this.dietItemNameSearchToolStripButton.Text = "DietItemNameSearch";
            this.dietItemNameSearchToolStripButton.Click += new System.EventHandler(this.dietItemNameSearchToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DietItemsQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dietItemNameSearchToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DietItemsQuery";
            this.Text = "DietItemsQuery";
            this.Load += new System.EventHandler(this.DietItemsQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            this.dietItemNameSearchToolStrip.ResumeLayout(false);
            this.dietItemNameSearchToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource dietItemsBindingSource;
        private GymDataSetTableAdapters.DietItemsTableAdapter dietItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip dietItemNameSearchToolStrip;
        private System.Windows.Forms.ToolStripLabel dietItemNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dietItemNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton dietItemNameSearchToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}