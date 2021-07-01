using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yuzhakov_NIkita_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //int Max_t_h = Convert.ToInt32(this.Max_T_H.Text);
           
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //int Dop_v_p_m_t = Convert.ToInt32(this.Dop_V_P_M_T.Text);
        }

        private void Min_Dop_t_h_TextChanged(object sender, EventArgs e)
        {
            //int Min_dop_t_h= Convert.ToInt32(this.Min_Dop_T_H.Text);
        }

        private void Dop_v_n_m_t_TextChanged(object sender, EventArgs e)
        {
            //int Dop_v_n_m_t = Convert.ToInt32(this.Dop_V_N_M_T.Text);
        }

        private void DV_N_I_TextChanged(object sender, EventArgs e)
        {
            ///int dv_n_i = Convert.ToInt32(this.DV_N_I.Text);
        }

        private void T_TextChanged(object sender, EventArgs e)
        {
            //int t = Convert.ToInt32(this.T.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Max_t_h = Convert.ToInt32(this.Max_T_H.Text);
            int Dop_v_p_m_t = Convert.ToInt32(this.Dop_V_P_M_T.Text);
            int Min_dop_t_h = Convert.ToInt32(this.Min_Dop_T_H.Text); //Переменные
            int Dop_v_n_m_t = Convert.ToInt32(this.Dop_V_N_M_T.Text);
            string t = Convert.ToString(this.T.Text);

            int D = Convert.ToInt32(this.Day);
            int MM = Convert.ToInt32(this.Month); //Дата
            int Y = Convert.ToInt32(this.Year);

            int H = Convert.ToInt32(this.chas); //Часы
            int M = Convert.ToInt32(this.Minutes);

            
            int[] j = new int[t.Length]; // в массив int
            int i = 0;
            foreach (int c in t)
            {
                j[i] = Convert.ToInt32(c.ToString()); i++;

                if (c > Max_t_h)
                {
                    MessageBox.Show("Нарушена максимально допустимая температура");
                }
                if (c < Min_dop_t_h)
                {
                    MessageBox.Show("Нарушена минимально допустимая температура");
                }
            }
            


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Month_TextChanged(object sender, EventArgs e)
        {
            //int M = Convert.ToInt32(this.Month);
        }

        private void Year_TextChanged(object sender, EventArgs e)
        {
           // int Y = Convert.ToInt32(this.Year);
        }

        private void Day_TextChanged(object sender, EventArgs e)
        {
            //int D = Convert.ToInt32(this.Day);
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            //int H = Convert.ToInt32(this.chas);
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            //int M = Convert.ToInt32(this.Minutes);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
