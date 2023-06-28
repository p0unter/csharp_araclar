namespace Proc_1
{
    public partial class Proc : Form
    {
        public Proc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
            MessageBox.Show("Komut gönderildi!");
            label10.Text = "Komut Baþarýlý!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "YAZDIRILDI!";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox3.Text);
            comboBox2.Items.Add(textBox4.Text);
            comboBox2.Items.Add(textBox5.Text);
            listBox2.Items.Add(textBox3.Text);
            listBox2.Items.Add(textBox4.Text);
            listBox2.Items.Add(textBox5.Text);
            MessageBox.Show("Komut gönderildi!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Add(textBox7.Text + " " + textBox6.Text);
            MessageBox.Show("Komut gönderildi!");
            label11.Text = "Komut Baþarýlý!";
            button4.Text = "GÖNDERÝLDÝ!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox3.Text);
            comboBox2.Items.Add(textBox4.Text);
            comboBox2.Items.Add(textBox5.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text);
            listBox2.Items.Add(textBox4.Text);
            listBox2.Items.Add(textBox5.Text);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add("Numara: " + maskedTextBox1.Text);
            listBox3.Items.Add("TC: " + maskedTextBox2.Text);
            listBox3.Items.Add("Tarih: " + maskedTextBox3.Text);
            listBox3.Items.Add("Saat: " + maskedTextBox4.Text);
            MessageBox.Show("Komut gönderildi!");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Text);
        }
    }
}