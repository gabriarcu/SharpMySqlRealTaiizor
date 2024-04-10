using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpMysql
{
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=film;Uid=root;Pwd=mysql;");
        private DataGridView dataGridViewForm1;

        public void UpdateGrid()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM film";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dataGridViewForm1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public Form2(DataGridView dataGridViewForm1)
        {
            InitializeComponent();
            this.dataGridViewForm1 = dataGridViewForm1;
        }

        private void btn_annulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salva_Click(object sender, EventArgs e)
        {
            int id_film = int.Parse(txt_id.Text);
            string nome = txt_nome.Text;
            string trama = txt_trama.Text;
            TimeSpan durata = new TimeSpan((int)n_ora.Value, (int)n_minuti.Value, 0);
            DateTime dataUscita = dateTimePicker1.Value;
            int idGenere = int.Parse(txt_idgenere.Text); // Assumendo che l'ID del genere sia inserito dall'utente

            // Crea un nuovo oggetto Film con i dati recuperati
            Film nuovoFilm = new Film(id_film, nome, trama, durata, dataUscita, idGenere); // L'ID del film sarà impostato a 0, poiché sarà generato automaticamente dal database

            // Esegui un'operazione di inserimento nel database
            string insertQuery = "INSERT INTO film (id_film,nome, trama, durata, data_uscita, id_genere) VALUES (@id_film, @nome, @trama, @durata, @data_uscita, @id_genere)";


            using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@id_film", nuovoFilm.id_film);
                cmd.Parameters.AddWithValue("@nome", nuovoFilm.nome);
                cmd.Parameters.AddWithValue("@trama", nuovoFilm.trama);
                cmd.Parameters.AddWithValue("@durata", nuovoFilm.durata);
                cmd.Parameters.AddWithValue("@data_uscita", nuovoFilm.data_uscita);
                cmd.Parameters.AddWithValue("@id_genere", nuovoFilm.id_genere);
                connection.Open();
                cmd.ExecuteNonQuery();
            }


            // Mostra un messaggio di conferma all'utente
            MessageBox.Show("Il film è stato aggiunto con successo.", "Film Aggiunto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            UpdateGrid();
            // Pulisci i campi del form dopo l'inserimento
            txt_nome.Text="";
            txt_trama.Text = "";
            n_ora.Value = 0;
            n_minuti.Value = 0;
            dateTimePicker1.Value = DateTime.Now; // Imposta la data di uscita a oggi dopo l'inserimento
            txt_idgenere.Text = "";
        }
    }
}
