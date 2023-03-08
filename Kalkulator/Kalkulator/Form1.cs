namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            var arr = textBox1.Text.ToCharArray();
            if (arr[arr.Length-1] != '+')
            {
                textBox1.Text = textBox1.Text + "+";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn_hasil_Click(object sender, EventArgs e)
        {
            var arr2 = textBox1.Text.ToCharArray();
            if (arr2[arr2.Length - 1] != '+')
            {
                var arr = textBox1.Text.Split('+');
                var ans = 0;
                for (var i = 0; i < arr.Length; i++)
                {
                    ans += Convert.ToInt32(arr[i]);
                }
                textBox1.Text = ans.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}