using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MKKDotNetTrainingBatch3.ConsoleApp1.Database.AppDbContextModels;

namespace TechnortalDotNetTrainingBatch3.WindowsFormsApp2
{
    public partial class FrmProductCategory : Form
    {
        private readonly AppDbContext db = new AppDbContext();
        private int editId = 0;

        public FrmProductCategory()
        {
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
        }

        private void FrmProductCategory_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            dgvData.DataSource = db.TblProductCategories
                .Where(x => x.DeleteFlag == false)
                .OrderByDescending(x => x.ProductCategoryId)
                .ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            txtProductCategoryCode.Clear();
            txtProductCategoryName.Clear();
            txtProductCategoryCode.Focus();
            editId = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductCategoryCode.Text) ||
                string.IsNullOrWhiteSpace(txtProductCategoryName.Text))
            {
                MessageBox.Show("Please enter both Code and Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editId == 0)
            {
                Save();
            }
            else
            {
                Edit();
            }

            ClearControls();
            BindData();
        }

        private void Save()
        {
            string code = txtProductCategoryCode.Text.Trim();
            string name = txtProductCategoryName.Text.Trim();

            TblProductCategory category = new TblProductCategory
            {
                ProductCategoryCode = code,
                ProductCategoryName = name,
                DeleteFlag = false
            };

            db.TblProductCategories.Add(category);
            int result = db.SaveChanges();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            MessageBox.Show(message);
        }

        private void Edit()
        {
            string code = txtProductCategoryCode.Text.Trim();
            string name = txtProductCategoryName.Text.Trim();

            var item = db.TblProductCategories
                   .Where(x => x.DeleteFlag == false)
                   .FirstOrDefault(x => x.ProductCategoryId == editId);

            if (item == null)
            {
                MessageBox.Show("Data not found.");
                return;
            }

            item.ProductCategoryCode = code;
            item.ProductCategoryName = name;

            int result = db.SaveChanges();
            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            MessageBox.Show(message);

            editId = 0;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (e.ColumnIndex == 0) // Edit
            {
                string value = dgvData.Rows[e.RowIndex].Cells["colProductCategoryId"].Value.ToString();
                int id = Convert.ToInt32(value);
                var item = db.TblProductCategories
                    .Where(x => x.DeleteFlag == false)
                    .FirstOrDefault(x => x.ProductCategoryId == id);

                if (item is null)
                {
                    MessageBox.Show("No data found.");
                    BindData();
                    return;
                }

                txtProductCategoryCode.Text = item.ProductCategoryCode;
                txtProductCategoryName.Text = item.ProductCategoryName;
                editId = item.ProductCategoryId;
            }
            else if (e.ColumnIndex == 1)
            {
                var result = MessageBox.Show("Are you sure you want to delete this category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) return;

                int id = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["colProductCategoryId"].Value.ToString());
                var item = db.TblProductCategories
                    .Where(x => x.DeleteFlag == false).
                    FirstOrDefault(x => x.ProductCategoryId == id);

                if (item is null)
                {
                    MessageBox.Show("No data found.");
                    BindData();
                    return;
                }

                item.DeleteFlag = true;
                db.SaveChanges();
                MessageBox.Show("Deleted successfully.");
                BindData();
            }
        }
    }
}
