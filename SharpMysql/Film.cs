using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMysql
{
    public class Film
    {
        public int id_film { get; set; }
        public string nome { get; set; }
        public string trama { get; set; }
        public TimeSpan durata { get; set; }
        public DateTime data_uscita { get; set; }
        public int id_genere { get; set; }

        public Film(int id_film_, string nome_, string trama_, TimeSpan durata_, DateTime data_uscita_, int id_genere_)
        {
            this.id_film = id_film_;
            this.nome = nome_;
            this.trama = trama_;
            this.durata = durata_;
            this.data_uscita = data_uscita_;
            this.id_genere = id_genere_;
        }
        public override string ToString()
        {
            return $"Id: {id_film}, Nome: {nome}, Trama: {trama}, durata: {durata}, dataUscita: {data_uscita}, idgenere: {id_genere}";
        }
    }
}
