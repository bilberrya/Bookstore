using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Книжный
{
    public partial class Корзина : Form
    {
        string ConnStr = "Data Source=ngknn.ru;Initial Catalog=44П-Иконникова-Экзамен;Persist Security Info=True;User ID=44П;Password=H12TjtrV";
        public Корзина()
        {
            InitializeComponent();
            Fill();
        }

        public void Fill()
        {
            if (Program.count == 0)
            {
                flowLayoutPanel3.Visible = false;
                flowLayoutPanel4.Visible = false;
                flowLayoutPanel6.Visible = false;
                flowLayoutPanel8.Visible = false;
            }
            else if (Program.count == 1)
            {
                flowLayoutPanel3.Visible = true;
                flowLayoutPanel4.Visible = false;
                flowLayoutPanel6.Visible = false;
                flowLayoutPanel8.Visible = false;
                SqlCommand cmd;
                SqlConnection cn = new SqlConnection(ConnStr);
                cn.Open();
                cmd = cn.CreateCommand();
                cmd.CommandText = "select [Название] from Книги where id = " + Program.id;
                label9.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Автор] from Книги where id = " + Program.id;
                label11.Text = Convert.ToString(cmd.ExecuteScalar());
                label13.Text = "1";
                cmd.CommandText = "select [Цена] from Книги where id = " + Program.id;
                label15.Text = Convert.ToString(cmd.ExecuteScalar());
                Bitmap img = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/" + label9.Text + ".jpg");
                pictureBox1.Image = img;
                cn.Close();

            }
            else if (Program.count == 2)
            {
                flowLayoutPanel3.Visible = true;
                flowLayoutPanel4.Visible = true;
                flowLayoutPanel6.Visible = false;
                flowLayoutPanel8.Visible = false;
                SqlCommand cmd;
                SqlConnection cn = new SqlConnection(ConnStr);
                cn.Open();
                cmd = cn.CreateCommand();
                cmd.CommandText = "select [Название] from Книги where id = " + Program.id;
                label10.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Автор] from Книги where id = " + Program.id;
                label7.Text = Convert.ToString(cmd.ExecuteScalar());
                label6.Text = "1";
                cmd.CommandText = "select [Цена] from Книги where id = " + Program.id;
                label5.Text = Convert.ToString(cmd.ExecuteScalar());
                Bitmap img = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/" + label10.Text + ".jpg");
                pictureBox2.Image = img;
                cn.Close();
            }
            else if (Program.count == 3)
            {
                flowLayoutPanel3.Visible = true;
                flowLayoutPanel4.Visible = true;
                flowLayoutPanel6.Visible = true;
                flowLayoutPanel8.Visible = false;
                SqlCommand cmd;
                SqlConnection cn = new SqlConnection(ConnStr);
                cn.Open();
                cmd = cn.CreateCommand();
                cmd.CommandText = "select [Название] from Книги where id = " + Program.id;
                label26.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Автор] from Книги where id = " + Program.id;
                label25.Text = Convert.ToString(cmd.ExecuteScalar());
                label24.Text = "1";
                cmd.CommandText = "select [Цена] from Книги where id = " + Program.id;
                label23.Text = Convert.ToString(cmd.ExecuteScalar());
                Bitmap img = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/" + label26.Text + ".jpg");
                pictureBox3.Image = img;
                cn.Close();
            }
            else if (Program.count == 4)
            {
                flowLayoutPanel3.Visible = true;
                flowLayoutPanel4.Visible = true;
                flowLayoutPanel6.Visible = true;
                flowLayoutPanel8.Visible = true;
                SqlCommand cmd;
                SqlConnection cn = new SqlConnection(ConnStr);
                cn.Open();
                cmd = cn.CreateCommand();
                cmd.CommandText = "select [Название] from Книги where id = " + Program.id;
                label35.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Автор] from Книги where id = " + Program.id;
                label34.Text = Convert.ToString(cmd.ExecuteScalar());
                label33.Text = "1";
                cmd.CommandText = "select [Цена] from Книги where id = " + Program.id;
                label32.Text = Convert.ToString(cmd.ExecuteScalar());
                Bitmap img = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/" + label35.Text + ".jpg");
                pictureBox1.Image = img;
                cn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы точно хотите очистить корзину?", "Удаление", MessageBoxButtons.OK);
            Program.count = 0;
            Program.price = 0;
            Fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
