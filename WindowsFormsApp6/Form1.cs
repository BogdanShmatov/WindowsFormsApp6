using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 4; //Указываем количество строк
            dataGridView1.ColumnCount = 3; //Указываем количество столбцов
            dataGridView2.RowCount = 4; //Указываем количество строк
            dataGridView2.ColumnCount = 3; //Указываем количество столбцов
            int[,] a = new int[4, 3]; //Инициализируем массив
            int i, j, z;
          
            //Заполняем матрицу случайными числами
            Random rand = new Random();
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                }
            }
       
                   
            //Выводим матрицу в dataGridView1
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
                    dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
                }
            }
           
            a[0, 1] = a[1,1] + a[2,2] + a[0,0]; 
            
            dataGridView2.Rows[3].Cells[2].Value = Convert.ToString(a[0,1]);

            textBox1.Text = Convert.ToString(a[0, 0]) + " + "+ Convert.ToString(a[1, 1]) + " + " + Convert.ToString(a[2, 2]) + " = " + Convert.ToString(a[0, 1]);





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
