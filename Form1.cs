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
        private void Clear()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
                tb.Text = string.Empty;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var id = carGrid.CurrentRow.Cells[0].Value;
            var carToUpdate = crud.FindCar((int)id);
            txtcarid.Text = carToUpdate.CarId.ToString();
            txtcarid.ReadOnly = true;
            txtvin.Text = carToUpdate.VIN;
            txtmake.Text = carToUpdate.Make;
            txtmodel.Text = carToUpdate.Model;
            txtyear.Text = carToUpdate.Year.ToString();
            txtprice.Text = carToUpdate.Price.ToString(); ;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtcarid.Text);
            var carToUpdate = crud.FindCar(id);
            carToUpdate.VIN = txtvin.Text;
            carToUpdate.Make = txtmake.Text;
            carToUpdate.Model = txtmodel.Text;
            carToUpdate.Year = int.Parse(txtyear.Text);
            carToUpdate.Price = double.Parse(txtprice.Text);
            crud.UpdateRecord(id, carToUpdate);
            MessageBox.Show("Record Updated!");
            carGrid.DataSource = crud.GetAllRecords();
            btnUpdate.Enabled = false;
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = carGrid.CurrentRow.Cells[0].Value;
            crud.DeleteRecord((int)id);
            MessageBox.Show("Record Deleted!");
            carGrid.DataSource = crud.GetAllRecords();
        }
    }
}
