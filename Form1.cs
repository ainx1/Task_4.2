namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {

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
