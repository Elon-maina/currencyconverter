namespace currencyconverter
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(amount_txt.Text);

            if (comboBox1.SelectedItem == "KSH" && comboBox2.SelectedItem == "USD")
            {
                int conv = amount / 140;
                currencydisplayer.Text= conv.ToString();
            }
            if (comboBox1.SelectedItem == "USD" && comboBox2.SelectedItem == "KSH")
            {
                int conv = amount * 140;
                currencydisplayer.Text = conv.ToString();
            }
            if (comboBox1.SelectedItem == "KSH" && comboBox2.SelectedItem == "POUND")
            {
                int conv = amount / 180;
                currencydisplayer.Text = conv.ToString();
            }
            if (comboBox1.SelectedItem == "POUND" && comboBox2.SelectedItem == "KSH")
            {
                int conv = amount * 180;
                currencydisplayer.Text = conv.ToString();
            }
            if (comboBox1.SelectedItem == "USD" && comboBox2.SelectedItem == "POUND")
            {
                int conv = (int)(amount / 1.22);
                currencydisplayer.Text = conv.ToString();
            }
            if (comboBox1.SelectedItem == "USD" && comboBox2.SelectedItem == "POUND")
            {
                int conv = (int)(amount *1.22);
                currencydisplayer.Text = conv.ToString();
            }
        }
    }
}