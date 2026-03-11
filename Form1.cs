namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InputText.Text = Properties.Settings.Default.InputText.ToString();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            try
            {
                var input = (this.InputText.Text);


                Properties.Settings.Default.InputText = input;
                Properties.Settings.Default.Save();

                var result = Logic.CountSameNeighborLetters(input);


                MessageBox.Show("Количество одинаковых соседних букв: " + result);
            }
            catch (FormatException)
            {
                return;
            }
        }

        public class Logic //Дано предложение. Определить, сколько в нем одинаковых
                           //соседних букв. Пробелы не учитывать.
        {
            public static int CountSameNeighborLetters(string input) //count
            {
                string checking = input.Replace(" ", "");
                checking = checking.ToLower();
                int len = checking.Length;
                int j = 0;
                for (int i = 0; i < len - 1; i++)
                {
                    if (checking[i] == checking[i + 1])
                        j++;
                }
                return j;
            }
        }

    }
}
