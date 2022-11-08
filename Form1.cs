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
            StreamReader sr = new StreamReader("test.txt");
            try
            {
                label1.Text = sr.ReadToEnd();
                int count = label1.Text.Length;
                if (count == 0)
                {
                    label1.Text = "0";
                    throw new Exception("В файле нет символов для чтения");
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
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            
        }
    }
}