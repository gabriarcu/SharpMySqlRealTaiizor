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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=film;Uid=root;Pwd=mysql;");
        Film f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM film";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                DataGridView1.DataSource = dataTable;
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

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Assicurati che almeno una riga sia selezionata
            if (DataGridView1.SelectedRows.Count > 0)
            {
                // Ottieni la riga selezionata
                DataGridViewRow selectedRow = DataGridView1.SelectedRows[0];
                // Ottieni i dati della riga selezionata
                int id = int.Parse(selectedRow.Cells["id_film"].Value.ToString());
                string nome = selectedRow.Cells["nome"].Value.ToString();
                string trama = selectedRow.Cells["trama"].Value.ToString();
                TimeSpan durata = TimeSpan.Parse(selectedRow.Cells["durata"].Value.ToString());
                DateTime datauscita = DateTime.Parse(selectedRow.Cells["data_uscita"].Value.ToString());
                int idgenere = int.Parse(selectedRow.Cells["id_genere"].Value.ToString());

                f = new Film(id, nome, trama, durata, datauscita, idgenere);

                txt_id.Text = f.id_film.ToString();
                txt_nome.Text = f.nome;
                txt_trama.Text = f.trama;
                dateTimePicker1.Value = f.data_uscita;
                n_ora.Value = f.durata.Hours;
                n_minuti.Value = f.durata.Minutes;
                txt_idgenere.Text = f.id_genere.ToString();
                groupBox1.Enabled = true;

            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void btn_modifica_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            aloneNotice1.Text = "Enable";
        }

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                int idFilmToDelete = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["id_film"].Value);

                DialogResult result = MessageBox.Show($"Sei sicuro di voler eliminare il film {idFilmToDelete}?", "Conferma Eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM film WHERE id_film = @id_film";


                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id_film", idFilmToDelete);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }


                    DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows[0].Index);

                    MessageBox.Show("Il film è stato eliminato con successo.", "Eliminazione Completata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            else
            {
                // Nessuna riga selezionata, mostra un messaggio all'utente
                MessageBox.Show("Seleziona un film da eliminare.", "Nessuna Selezione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_annulla_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            aloneNotice1.Text = "Disable";
        }

        private void btn_salva_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                // Ottieni la riga selezionata
                DataGridViewRow selectedRow = DataGridView1.SelectedRows[0];

                // Ottieni i nuovi valori dalle TextBox o altri controlli
                int id = int.Parse(txt_id.Text);
                string nome = txt_nome.Text;
                string trama = txt_trama.Text;
                TimeSpan durata = new TimeSpan((int)n_ora.Value, (int)n_minuti.Value, 0); // Creazione di un oggetto TimeSpan basato sui valori nelle NumericUpDown
                DateTime datauscita = dateTimePicker1.Value;
                int idgenere = int.Parse(txt_idgenere.Text);

                // Aggiorna i valori delle celle nella DataGridView
                selectedRow.Cells["id_film"].Value = id;
                selectedRow.Cells["nome"].Value = nome;
                selectedRow.Cells["trama"].Value = trama;
                selectedRow.Cells["durata"].Value = durata.ToString(); // Converti TimeSpan in stringa per inserire nella cella
                selectedRow.Cells["data_uscita"].Value = datauscita;
                selectedRow.Cells["id_genere"].Value = idgenere;

                // Aggiorna il record nel database
                // Esegui la query di aggiornamento utilizzando i nuovi valori
                string updateQuery = "UPDATE film SET nome = @nome, trama = @trama, durata = @durata, data_uscita = @data_uscita, id_genere = @id_genere WHERE id_film = @id_film";


                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@trama", trama);
                    cmd.Parameters.AddWithValue("@durata", durata);
                    cmd.Parameters.AddWithValue("@data_uscita", datauscita);
                    cmd.Parameters.AddWithValue("@id_genere", idgenere);
                    cmd.Parameters.AddWithValue("@id_film", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Film aggiornato correttamente.", "Aggiornamento Completato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Clone();
            }

            groupBox2.Enabled = false;
            aloneNotice1.Text = "Disable";
        }

        private void btn_esci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuovo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(DataGridView1);
            form2.Show();
        }
    }
}
