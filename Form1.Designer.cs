namespace _10._3dbCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            carGrid = new DataGridView();
            lblcarid = new Label();
            lblvin = new Label();
            lblmake = new Label();
            lblmodel = new Label();
            lblyear = new Label();
            lblprice = new Label();
            txtcarid = new TextBox();
            txtvin = new TextBox();
            txtmake = new TextBox();
            txtmodel = new TextBox();
            txtyear = new TextBox();
            txtprice = new TextBox();
            btnAdd = new Button();
            btnSubmit = new Button();
            btnSelect = new Button();
            btnUpdate = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)carGrid).BeginInit();
            SuspendLayout();
            // 
            // carGrid
            // 
            carGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carGrid.Location = new Point(55, 26);
            carGrid.Name = "carGrid";
            carGrid.Size = new Size(683, 208);
            carGrid.TabIndex = 0;
            // 
            // lblcarid
            // 
            lblcarid.AutoSize = true;
            lblcarid.Location = new Point(112, 257);
            lblcarid.Name = "lblcarid";
            lblcarid.Size = new Size(38, 15);
            lblcarid.TabIndex = 1;
            lblcarid.Text = "Car Id";
            // 
            // lblvin
            // 
            lblvin.AutoSize = true;
            lblvin.Location = new Point(112, 289);
            lblvin.Name = "lblvin";
            lblvin.Size = new Size(26, 15);
            lblvin.TabIndex = 2;
            lblvin.Text = "VIN";
            // 
            // lblmake
            // 
            lblmake.AutoSize = true;
            lblmake.Location = new Point(112, 321);
            lblmake.Name = "lblmake";
            lblmake.Size = new Size(36, 15);
            lblmake.TabIndex = 3;
            lblmake.Text = "Make";
            // 
            // lblmodel
            // 
            lblmodel.AutoSize = true;
            lblmodel.Location = new Point(112, 353);
            lblmodel.Name = "lblmodel";
            lblmodel.Size = new Size(41, 15);
            lblmodel.TabIndex = 4;
            lblmodel.Text = "Model";
            // 
            // lblyear
            // 
            lblyear.AutoSize = true;
            lblyear.Location = new Point(112, 385);
            lblyear.Name = "lblyear";
            lblyear.Size = new Size(29, 15);
            lblyear.TabIndex = 5;
            lblyear.Text = "Year";
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Location = new Point(112, 417);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(33, 15);
            lblprice.TabIndex = 6;
            lblprice.Text = "Price";
            // 
            // txtcarid
            // 
            txtcarid.Location = new Point(188, 254);
            txtcarid.Name = "txtcarid";
            txtcarid.Size = new Size(100, 23);
            txtcarid.TabIndex = 7;
            // 
            // txtvin
            // 
            txtvin.Location = new Point(188, 286);
            txtvin.Name = "txtvin";
            txtvin.Size = new Size(100, 23);
            txtvin.TabIndex = 8;
            // 
            // txtmake
            // 
            txtmake.Location = new Point(188, 318);
            txtmake.Name = "txtmake";
            txtmake.Size = new Size(100, 23);
            txtmake.TabIndex = 9;
            // 
            // txtmodel
            // 
            txtmodel.Location = new Point(188, 350);
            txtmodel.Name = "txtmodel";
            txtmodel.Size = new Size(100, 23);
            txtmodel.TabIndex = 10;
            // 
            // txtyear
            // 
            txtyear.Location = new Point(188, 382);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(100, 23);
            txtyear.TabIndex = 11;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(188, 414);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(100, 23);
            txtprice.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(359, 253);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(359, 289);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(462, 253);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(116, 23);
            btnSelect.TabIndex = 15;
            btnSelect.Text = "Select to Update";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(462, 289);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update Record";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(606, 253);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(606, 289);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdate);
            Controls.Add(btnSelect);
            Controls.Add(btnSubmit);
            Controls.Add(btnAdd);
            Controls.Add(txtprice);
            Controls.Add(txtyear);
            Controls.Add(txtmodel);
            Controls.Add(txtmake);
            Controls.Add(txtvin);
            Controls.Add(txtcarid);
            Controls.Add(lblprice);
            Controls.Add(lblyear);
            Controls.Add(lblmodel);
            Controls.Add(lblmake);
            Controls.Add(lblvin);
            Controls.Add(lblcarid);
            Controls.Add(carGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)carGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView carGrid;
        private Label lblcarid;
        private Label lblvin;
        private Label lblmake;
        private Label lblmodel;
        private Label lblyear;
        private Label lblprice;
        private TextBox txtcarid;
        private TextBox txtvin;
        private TextBox txtmake;
        private TextBox txtmodel;
        private TextBox txtyear;
        private TextBox txtprice;
        private Button btnAdd;
        private Button btnSubmit;
        private Button btnSelect;
        private Button btnUpdate;
        private Button btnRefresh;
        private Button btnDelete;
    }
}
