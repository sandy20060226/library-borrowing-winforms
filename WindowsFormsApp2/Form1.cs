using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               $"是否借閱《{button1.Text}》？",
               "借閱確認",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            Form2 form2 = new Form2();
            if (form2.ShowDialog() != DialogResult.OK) return;

            string name = form2.UserName;
            string phone = form2.UserPhone;

            Form3 form3 = new Form3();
            if (form3.ShowDialog() != DialogResult.OK) return;

            DateTime returnDate = form3.ReturnDate;

            MessageBox.Show(
                $"借閱成功！\n\n" +
                $"借閱者：{name}\n" +
                $"電話：{phone}\n" +
                $"還書日期：{returnDate:yyyy/MM/dd}\n\n" +
                $"祝你有個好的閱讀體驗",
                "完成",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"是否借閱《{button2.Text}》？",
                "借閱確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            Form2 form2 = new Form2();
            if (form2.ShowDialog() != DialogResult.OK) return;

            string name = form2.UserName;
            string phone = form2.UserPhone;

            Form3 form3 = new Form3();
            if (form3.ShowDialog() != DialogResult.OK) return;

            DateTime returnDate = form3.ReturnDate;

            MessageBox.Show(
                $"借閱成功！\n\n" +
                $"借閱者：{name}\n" +
                $"電話：{phone}\n" +
                $"還書日期：{returnDate:yyyy/MM/dd}\n\n" +
                $"祝你有個好的閱讀體驗",
                "完成",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"是否借閱《{button3.Text}》？",
                "借閱確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            Form2 form2 = new Form2();
            if (form2.ShowDialog() != DialogResult.OK) return;

            string name = form2.UserName;
            string phone = form2.UserPhone;

            Form3 form3 = new Form3();
            if (form3.ShowDialog() != DialogResult.OK) return;

            DateTime returnDate = form3.ReturnDate;

            MessageBox.Show(
                $"借閱成功！\n\n" +
                $"借閱者：{name}\n" +
                $"電話：{phone}\n" +
                $"還書日期：{returnDate:yyyy/MM/dd}\n\n" +
                $"祝你有個好的閱讀體驗",
                "完成",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
