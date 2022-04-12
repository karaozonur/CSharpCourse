using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONET_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal pr = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Data Table Veri çekme
          
            dataGridView1.DataSource = pr.GetDataTableAll();
            
           
            
        }
        private void LoadProduct()
        {
            //List Doldurma
            dataGridView1.DataSource = pr.GetListAll();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            pr.Add(new Product { 
                Name= textBox1.Text,
                UnitPrice= Convert.ToDecimal(textBox2.Text),
                StockAmount = Convert.ToInt32(textBox3.Text),
            }); 
            LoadProduct();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pr.Update(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                Name = textBox1.Text,
                 UnitPrice = Convert.ToDecimal(textBox2.Text),
                StockAmount = Convert.ToInt32(textBox3.Text),
            }); ;
            LoadProduct();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            pr.Delete(id);
            LoadProduct();
        }
    }
}
