namespace Project
{
    partial class DietQuery
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
            this.dietIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietItemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new Project.GymDataSet();
            this.dietTableAdapter = new Project.GymDataSetTableAdapters.DietTableAdapter();
            this.dietItemQuantitysearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.dietItemQuantityToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dietItemQuantityToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dietItemQuantitysearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            this.dietItemQuantitysearchToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(87, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(502, 252);
            this.dataGridView1.TabIndex = 0;
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
            // dietBindingSource
            // 
            this.dietBindingSource.DataMember = "Diet";
            this.dietBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietTableAdapter
            // 
            this.dietTableAdapter.ClearBeforeFill = true;
            // 
            // dietItemQuantitysearchToolStrip
            // 
            this.dietItemQuantitysearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dietItemQuantitysearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dietItemQuantityToolStripLabel,
            this.dietItemQuantityToolStripTextBox,
            this.dietItemQuantitysearchToolStripButton});
            this.dietItemQuantitysearchToolStrip.Location = new System.Drawing.Point(0, 0);
            this.dietItemQuantitysearchToolStrip.Name = "dietItemQuantitysearchToolStrip";
            this.dietItemQuantitysearchToolStrip.Size = new System.Drawing.Size(800, 27);
            this.dietItemQuantitysearchToolStrip.TabIndex = 1;
            this.dietItemQuantitysearchToolStrip.Text = "dietItemQuantitysearchToolStrip";
            // 
            // dietItemQuantityToolStripLabel
            // 
            this.dietItemQuantityToolStripLabel.Name = "dietItemQuantityToolStripLabel";
            this.dietItemQuantityToolStripLabel.Size = new System.Drawing.Size(126, 24);
            this.dietItemQuantityToolStripLabel.Text = "DietItemQuantity:";
            // 
            // dietItemQuantityToolStripTextBox
            // 
            this.dietItemQuantityToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dietItemQuantityToolStripTextBox.Name = "dietItemQuantityToolStripTextBox";
            this.dietItemQuantityToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // dietItemQuantitysearchToolStripButton
            // 
            this.dietItemQuantitysearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dietItemQuantitysearchToolStripButton.Name = "dietItemQuantitysearchToolStripButton";
            this.dietItemQuantitysearchToolStripButton.Size = new System.Drawing.Size(169, 24);
            this.dietItemQuantitysearchToolStripButton.Text = "DietItemQuantitysearch";
            this.dietItemQuantitysearchToolStripButton.Click += new System.EventHandler(this.dietItemQuantitysearchToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DietQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dietItemQuantitysearchToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DietQuery";
            this.Text = "DietQuery";
            this.Load += new System.EventHandler(this.DietQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            this.dietItemQuantitysearchToolStrip.ResumeLayout(false);
            this.dietItemQuantitysearchToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource dietBindingSource;
        private GymDataSetTableAdapters.DietTableAdapter dietTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietItemQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip dietItemQuantitysearchToolStrip;
        private System.Windows.Forms.ToolStripLabel dietItemQuantityToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dietItemQuantityToolStripTextBox;
        private System.Windows.Forms.ToolStripButton dietItemQuantitysearchToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}