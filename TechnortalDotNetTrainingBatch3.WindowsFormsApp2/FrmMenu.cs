namespace TechnortalDotNetTrainingBatch3.WindowsFormsApp2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            frm.ShowDialog();
            //MessageBox.Show("");
            //frm.ShowDialog();
        }

        private void productCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductCategory frm2 = new FrmProductCategory();
            frm2.ShowDialog();
        }
    }
}
