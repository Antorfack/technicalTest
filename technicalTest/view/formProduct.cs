using technicalTest.data;

namespace technicalTest.view
{
    public partial class formProduct : Form
    {
        public formProduct()
        {
            InitializeComponent();
        }

        private void formProduct_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void work_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            nState_save = 1; //Nuevo registro
            this.CleanText();
            this.StatusText(true);
            this.Status_ButtonProcess(true);
            this.Status_PrincipalButton(false);
            productCode.Focus();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            nState_save = 0;
            this.CleanText();
            this.StatusText(false);
            this.Status_ButtonProcess(false);
            this.Status_PrincipalButton(true);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.Product_list("%");
        }

        #region "Variables"
        int nCode_pr = 0;
        int nState_save = 0;
        #endregion

        #region "Metods"
        private void CleanText()
        {
            productCode.Clear();
            barCode.Clear();
            description.Clear();
            stock.Clear();
            price.Clear();

        }

        private void StatusText(bool lState)
        {
            productCode.Enabled = lState;
            barCode.Enabled = lState;
            description.Enabled = lState;
            stock.Enabled = lState;
            price.Enabled = lState;
        }

        private void Status_ButtonProcess(bool lState)
        {
            save.Visible = lState;
            cancel.Visible = lState;
        }

        private void Status_PrincipalButton(bool lState)
        {
            buttonNew.Enabled = lState;
            buttonDelete.Enabled = lState;
            buttonUpdate.Enabled = lState;
        }

        private void Product_list(string cSearch)
        {
            D_Products Data = new D_Products();

            dgvGridListProduct.DataSource = Data.Product_list(cSearch);
        }
        #endregion


       
    }
}
