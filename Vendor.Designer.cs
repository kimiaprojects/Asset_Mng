namespace Asset_Mng
{
    partial class Vendor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendor));
            this.asset_MngDataSet = new Asset_Mng.Asset_MngDataSet();
            this.فروشندهBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.فروشندهTableAdapter = new Asset_Mng.Asset_MngDataSetTableAdapters.فروشندهTableAdapter();
            this.فروشندهBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.فروشندهBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.فروشندهDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.asset_MngDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشندهBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشندهBindingNavigator)).BeginInit();
            this.فروشندهBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.فروشندهDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // asset_MngDataSet
            // 
            this.asset_MngDataSet.DataSetName = "Asset_MngDataSet";
            this.asset_MngDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // فروشندهBindingSource
            // 
            this.فروشندهBindingSource.DataMember = "فروشنده";
            this.فروشندهBindingSource.DataSource = this.asset_MngDataSet;
            // 
            // فروشندهTableAdapter
            // 
            this.فروشندهTableAdapter.ClearBeforeFill = true;
            // 
            // فروشندهBindingNavigator
            // 
            this.فروشندهBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.فروشندهBindingNavigator.BindingSource = this.فروشندهBindingSource;
            this.فروشندهBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.فروشندهBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.فروشندهBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.فروشندهBindingNavigatorSaveItem});
            this.فروشندهBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.فروشندهBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.فروشندهBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.فروشندهBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.فروشندهBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.فروشندهBindingNavigator.Name = "فروشندهBindingNavigator";
            this.فروشندهBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.فروشندهBindingNavigator.Size = new System.Drawing.Size(690, 25);
            this.فروشندهBindingNavigator.TabIndex = 0;
            this.فروشندهBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // فروشندهBindingNavigatorSaveItem
            // 
            this.فروشندهBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.فروشندهBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("فروشندهBindingNavigatorSaveItem.Image")));
            this.فروشندهBindingNavigatorSaveItem.Name = "فروشندهBindingNavigatorSaveItem";
            this.فروشندهBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.فروشندهBindingNavigatorSaveItem.Text = "Save Data";
            this.فروشندهBindingNavigatorSaveItem.Click += new System.EventHandler(this.فروشندهBindingNavigatorSaveItem_Click);
            // 
            // فروشندهDataGridView
            // 
            this.فروشندهDataGridView.AutoGenerateColumns = false;
            this.فروشندهDataGridView.ColumnHeadersHeight = 27;
            this.فروشندهDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.فروشندهDataGridView.DataSource = this.فروشندهBindingSource;
            this.فروشندهDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.فروشندهDataGridView.Location = new System.Drawing.Point(0, 25);
            this.فروشندهDataGridView.Name = "فروشندهDataGridView";
            this.فروشندهDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.فروشندهDataGridView.Size = new System.Drawing.Size(690, 409);
            this.فروشندهDataGridView.TabIndex = 1;
            this.فروشندهDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.فروشندهDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "نام_شرکت";
            this.dataGridViewTextBoxColumn1.HeaderText = "نام_شرکت\\Company";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "رابط";
            this.dataGridViewTextBoxColumn2.HeaderText = "رابط\\ Dealer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "تلفن";
            this.dataGridViewTextBoxColumn3.HeaderText = "تلفن\\ Tel";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "وب_سایت";
            this.dataGridViewTextBoxColumn4.HeaderText = "وب_سایت\\Website";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "آدرس";
            this.dataGridViewTextBoxColumn5.HeaderText = "آدرس\\ Addresse";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 434);
            this.Controls.Add(this.فروشندهDataGridView);
            this.Controls.Add(this.فروشندهBindingNavigator);
            this.Name = "Vendor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Vendor";
            this.Load += new System.EventHandler(this.Vendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asset_MngDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشندهBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشندهBindingNavigator)).EndInit();
            this.فروشندهBindingNavigator.ResumeLayout(false);
            this.فروشندهBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.فروشندهDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Asset_MngDataSet asset_MngDataSet;
        private System.Windows.Forms.BindingSource فروشندهBindingSource;
        private Asset_Mng.Asset_MngDataSetTableAdapters.فروشندهTableAdapter فروشندهTableAdapter;
        private System.Windows.Forms.BindingNavigator فروشندهBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton فروشندهBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView فروشندهDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}