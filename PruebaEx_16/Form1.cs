namespace PruebaEx_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            labelSaludo.Text = "¿Que tal estas? " + textBox.Text;
        }
    }
}