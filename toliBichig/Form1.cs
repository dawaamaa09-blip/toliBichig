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
            if (dataGridView1.CurrentRow == null ||
                dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Засах үгээ сонгоно уу!");
                return;
            }

            int id = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells[0].Value);

            using (var connection = new SqliteConnection(
                $@"Data Source={dbPath}"))
            {
                connection.Open();

                string sql =
                    "UPDATE words SET eng=@eng, mon=@mon, rus=@rus " +
                    "WHERE id=@id";

                using var command =
                    new SqliteCommand(sql, connection);

                command.Parameters.AddWithValue("@eng", txtEnglsh.Text.Trim());
                command.Parameters.AddWithValue("@mon", txtMongolian.Text.Trim());
                command.Parameters.AddWithValue("@rus", txtRussian.Text.Trim());
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }

            LoadWords();
            MessageBox.Show("Үг амжилттай засагдлаа!");
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
            UpdateCount();
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


        private void UpdateCount()
        {
            using var conn1 = new SqliteConnection(
                $@"Data Source={dbPath}");
            conn1.Open();

            using var cmd1 = new SqliteCommand(
                "SELECT COUNT(*) FROM words", conn1);

            int total = Convert.ToInt32(cmd1.ExecuteScalar());

            using var conn2 = new SqliteConnection(
                $@"Data Source={savedDbPath}");
            conn2.Open();

            using var cmd2 = new SqliteCommand(
                "SELECT COUNT(*) FROM saved_words", conn2);

            int saved = Convert.ToInt32(cmd2.ExecuteScalar());

            lblCount.Text =
                $"Нийт: {total} үг · Санасан: {saved}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string eng = txtEnglsh.Text.Trim();
            string mon = txtMongolian.Text.Trim();
            string rus = txtRussian.Text.Trim();

            if (eng == "" || mon == "" || rus == "")
            {
                MessageBox.Show("Бүх талбарыг бөглөнө үү!");
                return;
            }

            using (var connection = new SqliteConnection(
                $@"Data Source={dbPath}"))
            {
                connection.Open();

                string sql =
                    "INSERT INTO words (eng, mon, rus) " +
                    "VALUES (@eng, @mon, @rus)";

                using var command =
                    new SqliteCommand(sql, connection);

                command.Parameters.AddWithValue("@eng", eng);
                command.Parameters.AddWithValue("@mon", mon);
                command.Parameters.AddWithValue("@rus", rus);

                command.ExecuteNonQuery();
            }

            LoadWords();
            UpdateCount();

            MessageBox.Show("Үг амжилттай нэмэгдлээ!");
        }
    }
}
