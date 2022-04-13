using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            //using (ETradeContext context=new ETradeContext())
            //{
            //    dataGridView1.DataSource = context.Products.ToList();
            //}
            dataGridView1.DataSource = productDal.GetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            productDal.Add(new Product
            {
                Name = textBox1.Text,
                UnitPrice = Convert.ToInt32(textBox2.Text),
                 StockAmount = Convert.ToInt32(textBox3.Text),
            }); ;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            productDal.Update(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()),

                Name = textBox1.Text,
                UnitPrice = Convert.ToInt32(textBox2.Text),
                StockAmount = Convert.ToInt32(textBox3.Text),
            });
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            productDal.Delete(new Product {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                });
        }
    }
}
