namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> fuels = new()
            {
                "A-92",
                "A-95",
                "A-98",
                "Dizel"
            };
            comboBox1.Items.AddRange(fuels.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                textBox_liter.Enabled = true;
            else
            {
                textBox_liter.Enabled = false;
                textBox_liter.Text = "0";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                textBox_cash.Enabled = true;
            else
            {
                textBox_cash.Enabled = false;
                textBox_cash.Text = "0";
            }
        }
        private void textBox_liter_TextChanged(object sender, EventArgs e)
        {
            if (!(double.TryParse(textBox_liter.Text, out _)) && !(textBox_liter.Text == string.Empty) || textBox_liter.Text.Contains("."))
            {
                MessageBox.Show("Hərf və nömrə düzgün yazılmalıdır.");
                textBox_liter.Text = textBox_liter.Text.Remove(textBox_liter.Text.Length - 1, 1);
            }

            if (!(string.IsNullOrEmpty(textBox_liter.Text)))
            {
                label4.Visible = true;
                label4.Text = (double.Parse(textBox_liter.Text) * double.Parse(textBox_price.Text)).ToString() + "$";
            }
        }

        private void textBox_cash_TextChanged(object sender, EventArgs e)
        {
            if (!(double.TryParse(textBox_cash.Text, out _)) && !(textBox_cash.Text == string.Empty) || textBox_cash.Text.Contains("."))
            {
                MessageBox.Show("Qiymət nömrələnməlidir və düzgün yazılmalıdır!");
                textBox_cash.Text = textBox_cash.Text.Remove(textBox_cash.Text.Length - 1, 1);
            }

            if (!(string.IsNullOrEmpty(textBox_cash.Text)))
            {
                label4.Text = (double.Parse(textBox_cash.Text) / double.Parse(textBox_cash.Text)).ToString() + "Liter";
                label4.Visible = true;
            }
        }
        private void textBox_price_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox_liter.Enabled)
                textBox_liter_TextChanged(sender, e);
            else if (textBox_cash.Enabled)
                textBox_cash_TextChanged(sender, e);
        }


        private void checkBox_hotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hotdog.Checked)
                textBox_hdPrice.Enabled = true;
            else
            {
                textBox_hdPrice.Enabled = false;
                textBox_hdPrice.Text = "0";
            }
        }

        private void textBox_hdPrice_TextChanged(object sender, EventArgs e)
        {
            if (!(double.TryParse(textBox_hdPrice.Text, out _)) && !(textBox_hdPrice.Text == string.Empty) || textBox_hdPrice.Text.Contains(".") || textBox_hdPrice.Text.Contains(","))
            {
                MessageBox.Show("Say və rəqəm düzgün yazılmalıdır!");
                textBox_hdPrice.Text = textBox_hdPrice.Text.Remove(textBox_hdPrice.Text.Length - 1, 1);
            }
            else if (string.IsNullOrEmpty(textBox_hdPrice.Text))
            {
                textBox_hdPrice.Text = "0";
            }
            

        }




        private void textBox_hamPrice_TextChanged(object sender, EventArgs e)
        {
            if (!(double.TryParse(textBox_hamPrice.Text, out _)) && !(textBox_hamPrice.Text == string.Empty) || textBox_hamPrice.Text.Contains(".") || textBox_hamPrice.Text.Contains(","))
            {
                MessageBox.Show("Say və rəqəm düzgün yazılmalıdır!");
                textBox_hamPrice.Text = textBox_hamPrice.Text.Remove(textBox_hamPrice.Text.Length - 1, 1);
            }
            else if (string.IsNullOrEmpty(textBox_hamPrice.Text))
            {
                textBox_hamPrice.Text = "0";
            }
            
        }

        private void textBox_friesPrice_TextChanged(object sender, EventArgs e)
        {
            if (!(double.TryParse(textBox_friesPrice.Text, out _)) && !(textBox_friesPrice.Text == string.Empty) || textBox_friesPrice.Text.Contains(".") || textBox_friesPrice.Text.Contains(","))
            {
                MessageBox.Show("Say və rəqəm düzgün yazılmalıdır!");
                textBox_friesPrice.Text = textBox_friesPrice.Text.Remove(textBox_friesPrice.Text.Length - 1, 1);
            }
            else if (string.IsNullOrEmpty(textBox_friesPrice.Text))
            {
                textBox_friesPrice.Text = "0";
            }
           
        }
        private void textBox1_cokePrice_TextChanged(object sender, EventArgs e)
        {
            if (!(double.TryParse(textBox1_cokePrice.Text, out _)) && !(textBox1_cokePrice.Text == string.Empty) || textBox1_cokePrice.Text.Contains(".") || textBox1_cokePrice.Text.Contains(","))
            {
                MessageBox.Show("Say və rəqəm düzgün yazılmalıdır!");
                textBox1_cokePrice.Text = textBox1_cokePrice.Text.Remove(textBox1_cokePrice.Text.Length - 1, 1);
            }
            else if (string.IsNullOrEmpty(textBox1_cokePrice.Text))
            {
                textBox1_cokePrice.Text = "0";
            }
           
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        private void label16_Click_1(object sender, EventArgs e)
        {

        }
        private void label16_ChangeValue_1(object sender, EventArgs e)
        {

        }
  
    }
}