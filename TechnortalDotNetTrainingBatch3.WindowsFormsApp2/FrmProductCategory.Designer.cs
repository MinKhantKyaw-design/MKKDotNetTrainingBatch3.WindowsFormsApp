namespace TechnortalDotNetTrainingBatch3.WindowsFormsApp2
{
    partial class FrmProductCategory
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
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            txtProductCategoryCode = new TextBox();
            txtProductCategoryName = new TextBox();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            colProductCategoryId = new DataGridViewTextBoxColumn();
            colProductCategoryCode = new DataGridViewTextBoxColumn();
            colProductCategoryName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] {
                colEdit,
                colDelete,
                colProductCategoryId,
                colProductCategoryCode,
                colProductCategoryName
            });
            dgvData.Dock = DockStyle.Bottom;
            dgvData.Location = new Point(0, 180);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(700, 250);
            dgvData.TabIndex = 0;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkSeaGreen;
            btnSave.Location = new Point(290, 120);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.AppWorkspace;
            btnCancel.Location = new Point(172, 120);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 30);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 5;
            label1.Text = "Product Category Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 70);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 6;
            label2.Text = "Product Category Name";
            // 
            // txtProductCategoryCode
            // 
            txtProductCategoryCode.Location = new Point(270, 27);
            txtProductCategoryCode.Name = "txtProductCategoryCode";
            txtProductCategoryCode.Size = new Size(250, 31);
            txtProductCategoryCode.TabIndex = 1;
            // 
            // txtProductCategoryName
            // 
            txtProductCategoryName.Location = new Point(270, 67);
            txtProductCategoryName.Name = "txtProductCategoryName";
            txtProductCategoryName.Size = new Size(250, 31);
            txtProductCategoryName.TabIndex = 2;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Edit";
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Text = "Edit";
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Width = 80;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 80;
            // 
            // colProductCategoryId
            // 
            colProductCategoryId.DataPropertyName = "ProductCategoryId";
            colProductCategoryId.HeaderText = "ID";
            colProductCategoryId.MinimumWidth = 8;
            colProductCategoryId.Name = "colProductCategoryId";
            colProductCategoryId.ReadOnly = true;
            colProductCategoryId.Visible = false;
            colProductCategoryId.Width = 80;
            // 
            // colProductCategoryCode
            // 
            colProductCategoryCode.DataPropertyName = "ProductCategoryCode";
            colProductCategoryCode.HeaderText = "Category Code";
            colProductCategoryCode.MinimumWidth = 8;
            colProductCategoryCode.Name = "colProductCategoryCode";
            colProductCategoryCode.ReadOnly = true;
            colProductCategoryCode.Width = 200;
            // 
            // colProductCategoryName
            // 
            colProductCategoryName.DataPropertyName = "ProductCategoryName";
            colProductCategoryName.HeaderText = "Category Name";
            colProductCategoryName.MinimumWidth = 8;
            colProductCategoryName.Name = "colProductCategoryName";
            colProductCategoryName.ReadOnly = true;
            colProductCategoryName.Width = 200;
            // 
            // FrmProductCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 430);
            Controls.Add(txtProductCategoryName);
            Controls.Add(txtProductCategoryCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dgvData);
            Name = "FrmProductCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Category";
            Load += FrmProductCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private TextBox txtProductCategoryCode;
        private TextBox txtProductCategoryName;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewTextBoxColumn colProductCategoryId;
        private DataGridViewTextBoxColumn colProductCategoryCode;
        private DataGridViewTextBoxColumn colProductCategoryName;
    }
}
