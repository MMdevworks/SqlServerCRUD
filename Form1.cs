using _10._3dbCRUD.Services;

namespace _10._3dbCRUD
{
    public partial class Form1 : Form
    {
        CRUD crud;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crud = new CRUD();
            carGrid.DataSource = crud.GetAllRecords();
            carGrid.Columns[4].Visible = false;
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;
        }
    }
}
