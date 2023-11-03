namespace Lesson6_Practice
{
    public partial class Form1 : Form
    {
        public event SendObjectEventHandler ObjectSent;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MyObject myObject = new MyObject();
            myObject.Description = textBox1.Text;

            Form2 myForm = new Form2();
            ObjectSent += myForm.UpdateLabel;
            ObjectSent?.Invoke(this, myObject);

            myForm.ShowDialog();
        }
    }
}