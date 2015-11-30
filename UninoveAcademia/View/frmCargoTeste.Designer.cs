namespace UninoveAcademia.View
{
    partial class frmCargoTeste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargoTeste));
            this.academiaUninoveDataSet = new UninoveAcademia.AcademiaUninoveDataSet();
            this.cARGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARGOTableAdapter = new UninoveAcademia.AcademiaUninoveDataSetTableAdapters.CARGOTableAdapter();
            this.tableAdapterManager = new UninoveAcademia.AcademiaUninoveDataSetTableAdapters.TableAdapterManager();
            this.cARGOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cARGOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cARGODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.academiaUninoveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOBindingNavigator)).BeginInit();
            this.cARGOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cARGODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // academiaUninoveDataSet
            // 
            this.academiaUninoveDataSet.DataSetName = "AcademiaUninoveDataSet";
            this.academiaUninoveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cARGOBindingSource
            // 
            this.cARGOBindingSource.DataMember = "CARGO";
            this.cARGOBindingSource.DataSource = this.academiaUninoveDataSet;
            // 
            // cARGOTableAdapter
            // 
            this.cARGOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALUNOTableAdapter = null;
            this.tableAdapterManager.AULATableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CARGOTableAdapter = this.cARGOTableAdapter;
            this.tableAdapterManager.FICHA_EXERCICIOSTableAdapter = null;
            this.tableAdapterManager.FREQUENCIATableAdapter = null;
            this.tableAdapterManager.FUNC_AULATableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOTableAdapter = null;
            this.tableAdapterManager.HORA_AULATableAdapter = null;
            this.tableAdapterManager.HORARIOTableAdapter = null;
            this.tableAdapterManager.LOGINTableAdapter = null;
            this.tableAdapterManager.MEDIDASTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UninoveAcademia.AcademiaUninoveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cARGOBindingNavigator
            // 
            this.cARGOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cARGOBindingNavigator.BindingSource = this.cARGOBindingSource;
            this.cARGOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cARGOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cARGOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cARGOBindingNavigatorSaveItem});
            this.cARGOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cARGOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cARGOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cARGOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cARGOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cARGOBindingNavigator.Name = "cARGOBindingNavigator";
            this.cARGOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cARGOBindingNavigator.Size = new System.Drawing.Size(452, 25);
            this.cARGOBindingNavigator.TabIndex = 0;
            this.cARGOBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cARGOBindingNavigatorSaveItem
            // 
            this.cARGOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cARGOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cARGOBindingNavigatorSaveItem.Image")));
            this.cARGOBindingNavigatorSaveItem.Name = "cARGOBindingNavigatorSaveItem";
            this.cARGOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cARGOBindingNavigatorSaveItem.Text = "Save Data";
            this.cARGOBindingNavigatorSaveItem.Click += new System.EventHandler(this.cARGOBindingNavigatorSaveItem_Click_2);
            // 
            // cARGODataGridView
            // 
            this.cARGODataGridView.AutoGenerateColumns = false;
            this.cARGODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cARGODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cARGODataGridView.DataSource = this.cARGOBindingSource;
            this.cARGODataGridView.Location = new System.Drawing.Point(58, 53);
            this.cARGODataGridView.Name = "cARGODataGridView";
            this.cARGODataGridView.Size = new System.Drawing.Size(300, 220);
            this.cARGODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CD_CARGO";
            this.dataGridViewTextBoxColumn1.HeaderText = "CD_CARGO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_CARGO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_CARGO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frmCargoTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 392);
            this.Controls.Add(this.cARGODataGridView);
            this.Controls.Add(this.cARGOBindingNavigator);
            this.Name = "frmCargoTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargo";
            this.Load += new System.EventHandler(this.frmCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.academiaUninoveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOBindingNavigator)).EndInit();
            this.cARGOBindingNavigator.ResumeLayout(false);
            this.cARGOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cARGODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AcademiaUninoveDataSet academiaUninoveDataSet;
        private System.Windows.Forms.BindingSource cARGOBindingSource;
        private AcademiaUninoveDataSetTableAdapters.CARGOTableAdapter cARGOTableAdapter;
        private AcademiaUninoveDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cARGOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cARGOBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cARGODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}