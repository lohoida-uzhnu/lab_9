namespace lab_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void resultButton_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime birthDate = dtpBirthDate.Value;

            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }
            if (age < 0)
            {
                ageResult.Text = "Ви ще не народилися(";
                return;
            }
            string category = "";

            switch (age)
            {
                case int n when (n >= 0 && n <= 12):
                    category = "Дитина (0-12 років)";
                    break;
                case int n when (n >= 13 && n <= 17):
                    category = "Підліток (13-17 років)";
                    break;
                case int n when (n >= 18 && n <= 64):
                    category = "Дорослий (18-64 років)";
                    break;
                default:
                    category = "Літня людина (65+ років)";
                    break;
            }

            ageResult.Text = $"Вік: {age}. Категорія: {category}";
        }

        public void downloadFileDate_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(ofd.FileName);
                if (DateTime.TryParse(fileContent, out DateTime fileDate))
                {
                    dtpBirthDate.Value = fileDate;
                    resultButton_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Невірний формат дати у файлі.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
