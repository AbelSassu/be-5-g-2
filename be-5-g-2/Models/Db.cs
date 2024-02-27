namespace be_5_g_2.Models
{
    public static class Db
    {
        private static int _maxId = 3;

        private static List<Dipendente> _dipendenti { get; set; } = [
            new Dipendente() {DipendenteId = 1, Nome= "Francesco", Cognome = "Missorini", Indirizzo ="Via Brombeis", CodiceFiscale ="1234567891011123123", Coniugato = true, Figli = 3, Mansione = "Schiavista" },
            new Dipendente() {DipendenteId = 2, Nome= "Marco", Cognome = "Silveri", Indirizzo ="Via cagliari", CodiceFiscale ="123456789101113232132", Coniugato = true, Figli = 11, Mansione = "Leccapiedi" },
            new Dipendente() {DipendenteId = 3, Nome= "Domenico", Cognome = "Villani", Indirizzo ="Via alghero", CodiceFiscale ="123456789101112", Coniugato = true, Figli = 0, Mansione = "Guarda Cantieri" }
            ];
        public static List<Dipendente> getAll()
        { 
            return _dipendenti;
        }
        public static Dipendente? getByID(int? id)
        { 
            if(id == null) return null;
            for (int i = 0; i < _dipendenti.Count; i++)
            { 
                Dipendente dipendente = _dipendenti[i];
                if (_dipendenti[i].DipendenteId == id)
                { 
                    return dipendente;
                }
            }
            return null;
        }
        public static Dipendente AggiungiDipendente(string nome, string cognome, string indirizzo, string codiceFiscale, bool coniugato, int figli, string mansione)
        {
            _maxId++;
            var dipendente = new Dipendente() { DipendenteId = _maxId, Nome=nome, Cognome = cognome, Indirizzo = indirizzo, CodiceFiscale= codiceFiscale,Coniugato = coniugato,  Figli = figli, Mansione = mansione};
            _dipendenti.Add(dipendente);
            return dipendente;
        }
    }
}
