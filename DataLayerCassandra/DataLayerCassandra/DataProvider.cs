using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerCassandra;
using DataLayerCassandra.Entiteti;
using Cassandra;

namespace DataLayerCassandra
{
    public static class DataProvider
    {
        #region Vozila
        public static Vozila GetVozila(string id_vozila)
        {
            ISession session = SessionManager.GetSession();
            Vozila vozila = new Vozila();

            if (session == null)
                return null;

            Row vozilaData = session.Execute("select * from \"vozila\" where \"id\"='" + id_vozila + "'").FirstOrDefault();
            if (vozilaData != null)
            {
                vozila.id_vozila = vozilaData["id"] != null ? vozilaData["id"].ToString() : string.Empty;
                vozila.tip = vozilaData["tip"] != null ? vozilaData["tip"].ToString() : string.Empty;
                vozila.naziv = vozilaData["naziv"] != null ? vozilaData["naziv"].ToString() : string.Empty;
                vozila.model = vozilaData["model"] != null ? vozilaData["model"].ToString() : string.Empty;

            }

            return vozila;
        
        }
        public static List<Vozila> GetVozilas()
        {
            ISession session = SessionManager.GetSession();
            List<Vozila> vozilas = new List<Vozila>();

            if (session == null)
                return null;

            var vozilasData = session.Execute("select * from \"vozila\"");

            foreach(var v in vozilasData)
            {
                Vozila vozila = new Vozila();
                vozila.id_vozila = v["id"] != null ? v["id"].ToString() : string.Empty;
                vozila.tip = v["tip"] != null ? v["tip"].ToString() : string.Empty;
                vozila.isrent = v["isrent"] != null ? v["isrent"].ToString() : string.Empty;
                vozila.naziv = v["naziv"] != null ? v["naziv"].ToString() : string.Empty;
                vozila.model = v["model"] != null ? v["model"].ToString() : string.Empty;
                vozilas.Add(vozila);
            }

            return vozilas;
        }
        public static List<Vozila> GetVozilaTip(string tip)
        {
            ISession session = SessionManager.GetSession();
            List<Vozila> vozilas = new List<Vozila>();

            if (session == null)
                return null;

            var vozilasData = session.Execute("select * from \"vozila\" where \"tip\"='" + tip+ "' ALLOW FILTERING");

            foreach (var v in vozilasData)
            {
                Vozila vozila = new Vozila();
                vozila.id_vozila = v["id"] != null ? v["id"].ToString() : string.Empty;
                vozila.tip = v["tip"] != null ? v["tip"].ToString() : string.Empty;
                vozila.isrent = v["isrent"] != null ? v["isrent"].ToString() : string.Empty;
                vozila.naziv = v["naziv"] != null ? v["naziv"].ToString() : string.Empty;
                vozila.model = v["model"] != null ? v["model"].ToString() : string.Empty;
                vozilas.Add(vozila);
            }

            return vozilas;
        }
        public static void AddVozila(string id, string isrent,string tip, string naziv, string model)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet vozilaData = session.Execute("insert into \"vozila\" (id,isrent,tip,naziv,model) values ('"+id+"','"+isrent+"','"+tip+"', '"+naziv+"','"+model+"')"); 
        }
        public static void DeleteVozila(string id)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet vozilaData = session.Execute("delete from \"vozila\" where \"id\" ='"+id+"'");
        }
        #endregion

        #region Client
        public static Client GetClient(string jmbg)
        {
            ISession session = SessionManager.GetSession();
            Client client = new Client();

            if (session == null)
                return null;

            Row clientData = session.Execute("select * from \"client\" where \"jmbg\"='"+jmbg+"'").FirstOrDefault();

            if (clientData != null)
            {
                client.jmbg = clientData["jmbg"] != null ? clientData["jmbg"].ToString() : string.Empty;
                client.ime_client = clientData["ime"] != null ? clientData["ime"].ToString() : string.Empty;
                client.prezime_client = clientData["prezime"] != null ? clientData["prezime"].ToString() : string.Empty;
            }

            return client;
        }
        public static List<Client> GetClients()
        {
            ISession session = SessionManager.GetSession();
            List<Client> clients = new List<Client>();

            if (session == null)
                return null;

            var clientsData = session.Execute("select * from \"client\"");

            foreach (var c in clientsData)
            {
                Client client = new Client();
                client.jmbg = c["jmbg"] != null ? c["jmbg"].ToString() : string.Empty;
                client.ime_client = c["ime"] != null ? c["ime"].ToString() : string.Empty;
                client.prezime_client = c["prezime"] != null ? c["prezime"].ToString() : string.Empty;
                clients.Add(client);
            }

            return clients;
        }
        public static void AddClient(string jmbg, string ime, string prezime)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet clientData = session.Execute("insert into \"client\" (jmbg,ime,prezime) values ('"+jmbg+"','"+ime+"','"+prezime+"')");
        }
        public static void DeleteClient(string jmbg)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet clientData = session.Execute("delete from \"client\" where \"jmbg\"='"+jmbg+"'");
        }
        #endregion

        #region Radnik
        public static Radnik GetRadnik(string id)
        {
            ISession session = SessionManager.GetSession();
            Radnik radnik = new Radnik();

            if (session == null)
                return null;

            Row radnikData = session.Execute("select * from \"radnik\" where \"id\"='" + id + "'").FirstOrDefault();

            if (radnikData != null)
            {
                radnik.id_radnika= radnikData["id"] != null ? radnikData["id"].ToString() : string.Empty;
                radnik.ime_radnika= radnikData["ime"] != null ? radnikData["ime"].ToString() : string.Empty;
                radnik.prezime_radnika = radnikData["prezime"] != null ? radnikData["prezime"].ToString() : string.Empty;
            }

            return radnik;
        }
        public static List<Radnik> GetRadniks()
        {
            ISession session = SessionManager.GetSession();
            List<Radnik> radniks = new List<Radnik>();

            if (session == null)
                return null;

            var radniksData = session.Execute("select * from \"radnik\"");

            foreach (var c in radniksData)
            {
                Radnik radnik = new Radnik();
                radnik.id_radnika = c["id"] != null ? c["id"].ToString() : string.Empty;
                radnik.ime_radnika = c["ime"] != null ? c["ime"].ToString() : string.Empty;
                radnik.prezime_radnika = c["prezime"] != null ? c["prezime"].ToString() : string.Empty;
                radniks.Add(radnik);
            }

            return radniks;
        }
        public static void AddRadnik(string id, string ime, string prezime)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet radnikData = session.Execute("insert into \"radnik\" (id,ime,prezime)  values ('" + id+ "','" + ime + "','" + prezime + "')");
        }
        public static void DeleteRadnik(string id)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet radnikData = session.Execute("delete from \"radnik\" where \"id\"='" + id + "'");
        }
        #endregion

        #region RentVozilo
        public static RentVozilo GetRentVozilo(string id)
        {
            ISession session = SessionManager.GetSession();
            RentVozilo rentVozilo = new RentVozilo();

            if (session == null)
                return null;

            Row rentData = session.Execute("select * from \"rentvozila\" where \"id\"='"+id+"'").FirstOrDefault();
            if(rentData!=null)
            {
                rentVozilo.id_rent = rentData["id_rent"] != null ? rentData["id_rent"].ToString() : string.Empty;
                rentVozilo.jmbg= rentData["jmbg"] != null ? rentData["jmbg"].ToString() : string.Empty;
                rentVozilo.id_vozila= rentData["id_vozila"] != null ? rentData["id_vozila"].ToString() : string.Empty;
                
                rentVozilo.date_rent = rentData["date_rent"] != null ? rentData["date_rent"].ToString() : string.Empty;
                rentVozilo.date_to_return = rentData["date_to_return"] != null ? rentData["date_to_return"].ToString() : string.Empty;
            }
            return rentVozilo;
        }

        public static List<RentVozilo> GetRentVozilos()
        {
            ISession session = SessionManager.GetSession();
            List<RentVozilo> vozilas = new List<RentVozilo>();

            if (session == null)
                return null;

            var vozilasData = session.Execute("select * from \"rentvozila\"");

            foreach (var v in vozilasData)
            {
                RentVozilo vozila = new RentVozilo();
                vozila.id_rent= v["id_rent"] != null ? v["id_rent"].ToString() : string.Empty;
               
                vozila.jmbg = v["jmbg"] != null ? v["jmbg"].ToString() : string.Empty;
                vozila.id_vozila = v["id_vozila"] != null ? v["id_vozila"].ToString() : string.Empty;
                vozilas.Add(vozila);
            }

            return vozilas;
        }

        public static void addRent(string id_rent, string id_vozila, string jmbg)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return;
            DateTime dt = DateTime.Now;
            RowSet clientData = session.Execute("insert into \"rentvozila\" (date_rent, date_to_return, id_rent, id_vozila, jmbg) values ('" + dt.ToString() + "','" + "" + "','" + id_rent + "','" + id_vozila + "','" + jmbg + "')");
        }

        public static void removeRent(string id_vozila)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return;

            var rv = session.Execute("select id_rent from \"rentvozila\" where \"id_vozila\" ='" + id_vozila + "'  ALLOW FILTERING");
            session.Execute("delete from \"rentvozila\" where \"id_rent\" ='" + rv + "'");
        }

        public static void updateState(string stanje, string id)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            Vozila v = DataProvider.GetVozila(id);
            session.Execute("update vozila set \"isrent\"='" + stanje + "'where \"id\"='" + id + "'");

        }
        #endregion
    }
}
