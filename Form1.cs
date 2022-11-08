namespace ДЗ19._10._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadFile();
        }
        private void ReadFile()
        {
            String path = @"D:\Академия Шаг\Forms\ДЗ19.10.22\bin\Debug\net6.0-windows\test.txt";
            StreamReader sr = new StreamReader(path);
            label1.Text = sr.ReadToEnd();
            int count = label1.Text.Length;
            if(count == 0)
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = "";
                for (int i = 0; i < count; i++)
                {
                    label1.Text = count.ToString();
                    progressBar1.Value = i;
                }
            }
            
        }
    }
}