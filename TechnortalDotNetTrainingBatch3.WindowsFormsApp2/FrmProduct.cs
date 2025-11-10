using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MKKDotNetTrainingBatch3.ConsoleApp1.Database.AppDbContextModels;

namespace TechnortalDotNetTrainingBatch3.WindowsFormsApp2
{
    public partial class FrmProduct : Form
    {
        private readonly AppDbContext db = new AppDbContext();
        private int editId = 0;

        public FrmProduct()
        {
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
        }
        
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            dgvData.DataSource = db.TblProducts
                .Where(x => x.DeleteFlag == false)
                .OrderByDescending(x => x.ProductId)
                .ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtProductName.Focus();
            editId = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
            string productName = txtProductName.Text.Trim();
            int qty = Convert.ToInt32(txtQuantity.Text.Trim());
            decimal price = Convert.ToDecimal(txtPrice.Text.Trim());

            TblProduct product = new TblProduct
            {
                CreatedDateTime = DateTime.Now,
                DeleteFlag = false,
                Price = price,
                ProductName = productName,
                Quantity = qty,
            };

            db.TblProducts.Add(product);
            int result = db.SaveChanges();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            MessageBox.Show(message);
        }

        private void Edit()
        {
            string productName = txtProductName.Text.Trim();
            int qty = Convert.ToInt32(txtQuantity.Text.Trim());
            decimal price = Convert.ToDecimal(txtPrice.Text.Trim());

            var item = db.TblProducts
                   .Where(x => x.DeleteFlag == false)
                   .FirstOrDefault(x => x.ProductId == editId);

            item.ProductName = productName;
            item.Quantity = qty;
            item.Price = price;
            item.ModifiedDateTime = DateTime.Now;

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
                string value = dgvData.Rows[e.RowIndex].Cells["colProductId"].Value.ToString();
                int id = Convert.ToInt32(value);
                var item = db.TblProducts
                    .Where(x => x.DeleteFlag == false)
                    .FirstOrDefault(x => x.ProductId == id);
                if (item is null)
                {
                    MessageBox.Show("No data found.");
                    BindData();
                    return;
                }

                txtProductName.Text = item.ProductName;
                txtPrice.Text = item.Price.ToString();
                txtQuantity.Text = item.Quantity.ToString();
                editId = item.ProductId;
            }
            else if (e.ColumnIndex == 1) // Delete
            {
                var result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) return;

                // Delete Flag = true

                string value = dgvData.Rows[e.RowIndex].Cells["colProductId"].Value.ToString();

                int id = Convert.ToInt32(value);
                var item = db.TblProducts
                    .Where(x => x.DeleteFlag == false)
                    .FirstOrDefault(x => x.ProductId == id);
                if (item is null)
                {
                    MessageBox.Show("No data found.");
                    BindData();
                    return;
                }

                item.DeleteFlag = true;

                int result2 = db.SaveChanges();
                string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
                MessageBox.Show(message);
                BindData();
            }
        }
    }
}
