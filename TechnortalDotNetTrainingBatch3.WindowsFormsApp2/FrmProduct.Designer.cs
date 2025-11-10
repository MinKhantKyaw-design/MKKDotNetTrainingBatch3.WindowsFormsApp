namespace TechnortalDotNetTrainingBatch3.WindowsFormsApp2
{
    partial class FrmProduct
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
            dgvData = new DataGridView();
            btnSave = new Button();
            label1 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colCreatedDateTime = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { colEdit, colDelete, colProductId, colProductName, colQuantity, colPrice, colCreatedDateTime });
            dgvData.Dock = DockStyle.Bottom;
            dgvData.Location = new Point(0, 202);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(1007, 247);
            dgvData.TabIndex = 0;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkSeaGreen;
            btnSave.Location = new Point(346, 138);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 31);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 2;
            label1.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(228, 28);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(274, 31);
            txtProductName.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(228, 64);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(274, 31);
            txtQuantity.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(228, 101);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(274, 31);
            txtPrice.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 67);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 6;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 104);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 7;
            label3.Text = "Price";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.AppWorkspace;
            btnCancel.Location = new Point(228, 138);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Edit";
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Text = "Edit";
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Width = 150;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 150;
            // 
            // colProductId
            // 
            colProductId.DataPropertyName = "ProductId";
            colProductId.HeaderText = "Product Id";
            colProductId.MinimumWidth = 8;
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            colProductId.Visible = false;
            colProductId.Width = 150;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "ProductName";
            colProductName.HeaderText = "Product Name";
            colProductName.MinimumWidth = 8;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.Width = 150;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 8;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 150;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 8;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 150;
            // 
            // colCreatedDateTime
            // 
            colCreatedDateTime.DataPropertyName = "CreatedDateTime";
            colCreatedDateTime.HeaderText = "Created Date Time";
            colCreatedDateTime.MinimumWidth = 8;
            colCreatedDateTime.Name = "colCreatedDateTime";
            colCreatedDateTime.ReadOnly = true;
            colCreatedDateTime.Width = 150;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 449);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(dgvData);
            Name = "FrmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            Load += FrmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Button btnSave;
        private Label label1;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label label2;
        private Label label3;
        private Button btnCancel;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colCreatedDateTime;
    }
}