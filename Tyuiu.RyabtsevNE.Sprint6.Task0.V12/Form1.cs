using Tyuiu.RyabtsevNE.Sprint6.Task0.V12.Lib;

namespace Tyuiu.RyabtsevNE.Sprint6.Task0.V12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRes_RNE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_RNE_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox1.Text, out n))
            {
                DataService ds = new DataService();
                int a;
                a = Convert.ToInt32(textBox1.Text);
                double b = ds.Calculate(a);
                textBoxVarX_RNE.Text = b.ToString();
            }
            else MessageBox.Show("ошибка ввода данных", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }
    }
}
