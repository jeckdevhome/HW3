using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using WindowsFormsApp2;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var context = new AppDbContext();
            //var createcar = new AppDbContext();
            var createcar = context.Cars.ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helllo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_WindowsFormsApp2_AppDbContextDataSet.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this._WindowsFormsApp2_AppDbContextDataSet.Cars);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }
    }
}
