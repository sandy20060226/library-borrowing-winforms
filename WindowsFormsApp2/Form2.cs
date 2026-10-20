using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public string UserName { get; private set; }
        public string UserPhone { get; private set; }

        public Form2()
        {
            InitializeComponent();

            // 電話只能輸入數字
            textBox2.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            };

            button1.Click += button1_Click; // 確定
            button2.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); }; // 取消
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();

            // 姓名只能中文（可含空白：王 小明）
            if (!Regex.IsMatch(name, @"^[\u4e00-\u9fff\s]+$"))
            {
                MessageBox.Show("姓名必須為中文");
                return;
            }

            // 電話只能數字
            if (!Regex.IsMatch(phone, @"^\d+$"))
            {
                MessageBox.Show("電話必須為數字");
                return;
            }

            UserName = name;
            UserPhone = phone;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

