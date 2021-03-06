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
    public partial class Каталог : Form
    {
        int str = 1;
        string ConnStr = "Data Source=ngknn.ru;Initial Catalog=44П-Иконникова-Экзамен;Persist Security Info=True;User ID=44П;Password=H12TjtrV";
        public Каталог()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            SqlCommand cmd;
            SqlConnection cn = new SqlConnection(ConnStr);
            cn.Open();
            cmd = cn.CreateCommand();
            label4.Text = Convert.ToString(Program.count);
            label5.Text = Convert.ToString(Program.price);
            if (Program.count < 3)
            {
                label7.Text = "0%";
                label6.Visible = false;
            }
            else if ((Program.count >= 3) && (Program.count < 5))
            {
                label7.Text = "5%";
                Program.price = Convert.ToInt32(Convert.ToInt32(label5.Text) * 0.95);
                label6.Visible = true;
                label6.Text = Convert.ToString(Program.price);
            }
            else if ((Program.count >= 5) && (Program.count < 10))
            {
                label7.Text = "10%";
                Program.price = Convert.ToInt32(Convert.ToInt32(label5.Text) * 0.9);
                label6.Visible = true;
                label6.Text = Convert.ToString(Program.price);
            }
            else if (Program.count >= 10)
            {
                label7.Text = "15%";
                Program.price = Convert.ToInt32(Convert.ToInt32(label5.Text) * 0.85);
                label6.Visible = true;
                label6.Text = Convert.ToString(Program.price);
            }
            if (str == 1)
            {
                flowLayoutPanel8.Visible = true;
                cmd.CommandText = "select [Название] from Книги where id = 1";
                label9.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 1";
                label11.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 1";
                label13.Text = (string)cmd.ExecuteScalar();
                label15.Text = "250";
                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 1";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label17.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label17.Text = "Много";
                else label17.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Количество на складе] from Книги where id = 1";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label19.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label19.Text = "Много";
                else label19.Text = Convert.ToString(cmd.ExecuteScalar());
                label21.Text = "...Это была страшная игра – игра на выживание.";
                Bitmap img = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/Долгая прогулка.jpg");
                pictureBox1.Image = img;

                cmd.CommandText = "select [Название] from Книги where id = 2";
                label23.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 2";
                label25.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 2";
                label27.Text = (string)cmd.ExecuteScalar();
                label29.Text = "200";
                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 2";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label31.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label31.Text = "Много";
                else label31.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Количество на складе] from Книги where id = 2";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label33.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label33.Text = "Много";
                else label33.Text = Convert.ToString(cmd.ExecuteScalar());
                label35.Text = "В полицию Осло поступила информация о нелегальном приобретении редкого и очень страшного оружия.";
                Bitmap img2 = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/Красношейка.jpg");
                pictureBox2.Image = img2;

                cmd.CommandText = "select [Название] from Книги where id = 3";
                label37.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 3";
                label39.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 3";
                label41.Text = (string)cmd.ExecuteScalar();
                label43.Text = "300";
                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 3";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label45.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label45.Text = "Много";
                else label45.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Количество на складе] from Книги where id = 3";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label47.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label47.Text = "Много";
                else label47.Text = Convert.ToString(cmd.ExecuteScalar());
                label49.Text = "Огонь полыхает над разоренными войной землями, пожирая целые народы и стирая с карт границы прежних государств.";
                Bitmap img3 = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/Крещение огнем.jpg");
                pictureBox3.Image = img3;

                cmd.CommandText = "select [Название] from Книги where id = 4";
                label51.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 4";
                label53.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 4";
                label55.Text = (string)cmd.ExecuteScalar();
                label57.Text = "180";
                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 4";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label59.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label59.Text = "Много";
                else label59.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Количество на складе] from Книги where id = 4";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label61.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label61.Text = "Много";
                else label61.Text = Convert.ToString(cmd.ExecuteScalar());
                label63.Text = "Может ли спасение от верной гибели обернуться таким кошмаром, что даже смерть покажется милосердным даром судьбы?";
                Bitmap img4 = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/Мизери.jpg");
                pictureBox4.Image = img4;
            }
            else if (str == 2)
            {
                flowLayoutPanel8.Visible = true;
                cmd.CommandText = "select [Название] from Книги where id = 5";
                label9.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 5";
                label11.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 5";
                label13.Text = (string)cmd.ExecuteScalar();
                label15.Text = "270";
                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 5";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label17.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label17.Text = "Много";
                else label17.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Количество на складе] from Книги where id = 5";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label19.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label19.Text = "Много";
                else label19.Text = Convert.ToString(cmd.ExecuteScalar());
                label21.Text = "Странная, страшная и бесконечно притягательная книга.";
                Bitmap img = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/Повелитель мух.jpg");
                pictureBox1.Image = img;

                cmd.CommandText = "select [Название] from Книги where id = 6";
                label23.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 6";
                label25.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 6";
                label27.Text = (string)cmd.ExecuteScalar();
                label29.Text = "230";
                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 6";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label31.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label31.Text = "Много";
                else label31.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Количество на складе] from Книги where id = 6";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label33.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label33.Text = "Много";
                else label33.Text = Convert.ToString(cmd.ExecuteScalar());
                label35.Text = "Дракон похитил принцессу, чтобы сотворить древний ритуал.";
                Bitmap img2 = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/Ритуал.jpg");
                pictureBox2.Image = img2;

                cmd.CommandText = "select [Название] from Книги where id = 7";
                label37.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 7";
                label39.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 7";
                label41.Text = (string)cmd.ExecuteScalar();
                label43.Text = "320";
                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 7";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label45.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label45.Text = "Много";
                else label45.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Количество на складе] from Книги where id = 7";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label47.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label47.Text = "Много";
                else label47.Text = Convert.ToString(cmd.ExecuteScalar());
                label49.Text = "Фитц Чивэл, королевский убийца, возвращается к жизни.";
                Bitmap img3 = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/Странствия убийцы.jpg");
                pictureBox3.Image = img3;

                cmd.CommandText = "select [Название] from Книги where id = 8";
                label51.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 8";
                label53.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 8";
                label55.Text = (string)cmd.ExecuteScalar();
                label57.Text = "290";
                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 8";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label59.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label59.Text = "Много";
                else label59.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Количество на складе] from Книги where id = 8";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label61.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label61.Text = "Много";
                else label61.Text = Convert.ToString(cmd.ExecuteScalar());
                label63.Text = "Келлен со страхом ждёт своего шестнадцатого дня рождения.";
                Bitmap img4 = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/Творец заклинаний.jpg");
                pictureBox4.Image = img4;
            }
            else if (str == 3)
            {
                cmd.CommandText = "select [Название] from Книги where id = 9";
                label9.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 9";
                label11.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 9";
                label13.Text = (string)cmd.ExecuteScalar();
                label15.Text = "330";
                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 9";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label17.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label17.Text = "Много";
                else label17.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Количество на складе] from Книги where id = 9";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label19.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label19.Text = "Много";
                else label19.Text = Convert.ToString(cmd.ExecuteScalar());
                label21.Text = "Это изустная побывальщина.";
                Bitmap img = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/Финист - ясный сокол.jpg");
                pictureBox1.Image = img;

                cmd.CommandText = "select [Название] from Книги where id = 10";
                label23.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 10";
                label25.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 10";
                label27.Text = (string)cmd.ExecuteScalar();
                label29.Text = "250";
                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 10";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label31.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label31.Text = "Много";
                else label31.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Количество на складе] from Книги where id = 10";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label33.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label33.Text = "Много";
                else label33.Text = Convert.ToString(cmd.ExecuteScalar());
                label35.Text = "Тридцатитрехлетний Чарли Гордон – умственно отсталый.";
                Bitmap img2 = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/Цветы для Элджернона.jpg");
                pictureBox2.Image = img2;

                cmd.CommandText = "select [Название] from Книги where id = 11";
                label37.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 11";
                label39.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 11";
                label41.Text = (string)cmd.ExecuteScalar();
                label43.Text = "320";
                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 11";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label45.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label45.Text = "Много";
                else label45.Text = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select [Количество на складе] from Книги where id = 11";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label47.Text = "Нет";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 5) label47.Text = "Много";
                else label47.Text = Convert.ToString(cmd.ExecuteScalar());
                label49.Text = "У Николая Ланцова всегда был этот дар: верить в невозможное и делать невозможное реальностью.";
                Bitmap img3 = new Bitmap("C:/Users/Anastasia/Desktop/4 курс/экзамен 01/Книжный/Covers/Король шрамов.jpg");
                pictureBox3.Image = img3;

                flowLayoutPanel8.Visible = false;
            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (str < 3)
                str++;
            Fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (str > 1) 
                str--;
            Fill();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Program.count++;
            Program.price += Convert.ToInt32(label15.Text);
            SqlCommand cmd;
            SqlConnection cn = new SqlConnection(ConnStr);
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "select [id] from Книги where Название = \'" + label9.Text + "\'";
            Program.id = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();
            Fill();
            Корзина f = new Корзина();
            f.Fill();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            Program.count++;
            Program.price += Convert.ToInt32(label29.Text);
            SqlCommand cmd;
            SqlConnection cn = new SqlConnection(ConnStr);
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "select [id] from Книги where Название = \'" + label23.Text + "\'";
            Program.id = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();
            Fill();
            Корзина f = new Корзина();
            f.Fill();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            Program.count++;
            Program.price += Convert.ToInt32(label43.Text);
            SqlCommand cmd;
            SqlConnection cn = new SqlConnection(ConnStr);
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "select [id] from Книги where Название = \'" + label37.Text + "\'";
            Program.id = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();
            Fill();
            Корзина f = new Корзина();
            f.Fill();
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            Program.count++;
            Program.price += Convert.ToInt32(label57.Text);
            SqlCommand cmd;
            SqlConnection cn = new SqlConnection(ConnStr);
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "select [id] from Книги where Название = \'" + label51.Text + "\'";
            Program.id = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();
            Fill();
            Корзина f = new Корзина();
            f.Fill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Корзина f = new Корзина();
            f.ShowDialog();
            Fill();
        }
    }
}
