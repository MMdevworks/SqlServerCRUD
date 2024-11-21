using _10._3dbCRUD.Models;
using _10._3dbCRUD.Services;
using System.Xml.Linq;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtcarid.Text = (crud.GetMaxId() + 1).ToString();
            txtcarid.ReadOnly = true;
            txtvin.Clear();
            txtmake.Clear();
            txtmodel.Clear();
            txtyear.Clear();
            txtprice.Clear();
            btnSubmit.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcarid.Text))
            {
                var newcar = new Car();
                newcar.CarId = int.Parse(txtcarid.Text);
                newcar.VIN = txtvin.Text;
                newcar.Make = txtmake.Text;
                newcar.Model = txtmodel.Text;
                newcar.Year = int.Parse(txtyear.Text);
                newcar.Price = double.Parse(txtprice.Text);
                crud.AddRecord(newcar);
                MessageBox.Show("Record Added!");
            }
            btnSubmit.Enabled = false;
            carGrid.DataSource = crud.GetAllRecords();
        }
    }
}
