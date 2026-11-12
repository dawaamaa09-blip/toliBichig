using Microsoft.Data.Sqlite;
namespace toliBichig
{
    public partial class Form1 : Form
    {
        private string dbPath = @"C:\toli-db\toli.db";
        private string savedDbPath = @"C:\toli-db\saved.db";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadWords()
        {
            dataGridView1.Rows.Clear();

            using (var connection = new SqliteConnection(
                $@"Data Source={dbPath}"))
            {
                connection.Open();

                string sql = "SELECT id, eng, mon, rus FROM words";

                using (var command = new SqliteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(
                            reader["id"],
                            reader["eng"],
                            reader["mon"],
                            reader["rus"]
                        );
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadWords();
            LoadSavedWords();

            lblCount.Text =
                $"Нийт: {dataGridView1.Rows.Count} үг · Санасан: {dataGridView2.Rows.Count}";
        }


        private void LoadSavedWords()
        {
            dataGridView2.Rows.Clear();

            using (var connection = new SqliteConnection(
                $@"Data Source={savedDbPath}"))
            {
                connection.Open();

                string sql = "SELECT eng, mon, rus FROM saved_words";

                using (var command = new SqliteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGridView2.Rows.Add(
                            reader["eng"],
                            reader["mon"],
                            reader["rus"]
                        );
                    }
                }
            }
        }

    }
}
