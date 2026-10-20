using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public DateTime ReturnDate => dateTimePicker1.Value.Date;

        public Form3()
        {
            InitializeComponent();

            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddMonths(1);

            button1.Click += (s, e) => DialogResult = DialogResult.OK;     // 確定
            button2.Click += (s, e) => DialogResult = DialogResult.Cancel; // 取消
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

