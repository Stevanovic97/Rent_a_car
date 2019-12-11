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
                vozila.naziv = v["naziv"] != null ? v["naziv"].ToString() : string.Empty;
                vozila.model = v["model"] != null ? v["model"].ToString() : string.Empty;
                vozilas.Add(vozila);
            }

            return vozilas;
        }
        public static void AddVozila(string id, string tip, string naziv, string model)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet vozilaData = session.Execute("insert into \"vozila\" (id,tip,naziv,model) values ('"+id+"','"+tip+"', '"+naziv+"','"+model+"')"); 
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

            RowSet clientData = session.Execute("insert into \"client\" (jmbg,ime,prezime) values ('"+jmbg+"','"+ime+"','"+prezime+"'");
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
    }
}
