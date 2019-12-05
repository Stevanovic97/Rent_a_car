using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using CassandraDataLayer.Entity;

namespace CassandraDataLayer
{
    public static class DataProvider
    {
        #region Client

        public static Client GetClient(string jmbg)
        {
            ISession session = SessionManager.GetSession();
            Client client = new Client();

            if (session == null)
                return null;

            Row clientData = session.Execute("select * from \"clien\" where \"jmbg\"='1010101010101'").FirstOrDefault();

            if (clientData != null)
            {
                client.jmbg = clientData["jmbg"] != null ? clientData["jmbg"].ToString() : string.Empty;
                client.ime = clientData["ime"] != null ? clientData["ime"].ToString() : string.Empty;
                client.prezime = clientData["prezime"] != null ? clientData["prezime"].ToString() : string.Empty;
            }
            return client;
        }

        public static List<Client> GetClients()
        {
            ISession session = SessionManager.GetSession();
            List<Client> clients = new List<Client>();

            if (session == null)
                return null;

            var clientsData = session.Execute("select * from\"clien\"");

            foreach (var clientData in clientsData)
            {
                Client client = new Client();
                client.jmbg = clientData["jmbg"] != null ? clientData["jmbg"].ToString() : string.Empty;
                client.ime = clientData["ime"] != null ? clientData["ime"].ToString() : string.Empty;
                client.prezime = clientData["prezime"] != null ? clientData["prezime"].ToString() : string.Empty;
                clients.Add(client);
            }
            return clients;
        }

        public static void AddClient(string jmbg,string ime,string prezime)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet clientData = session.Execute("insert into \"clien\" (\"jmbg\", ime, prezime) values ('"+jmbg+"','"+ime+"','"+prezime+"')");
        }

        public static void DeleteClient(string jmbg)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet clientData = session.Execute("delete from \"clien\" where \"jmbg\" = '" + jmbg + "'");
        }
        #endregion

        #region Cars
        public static Cars GetCars(string id)
        {
            ISession session = SessionManager.GetSession();
            Cars car = new Cars();

            if (session == null)
                return null;

            Row carData = session.Execute("select * from \"cars\" where \"id\"='"+id+"'").FirstOrDefault();

            if (carData != null)
            {
                car.id = carData["id"] != null ? carData["id"].ToString() : string.Empty;
                car.naziv = carData["naziv"] != null ? carData["naziv"].ToString() : string.Empty;
                car.model = carData["model"] != null ? carData["model"].ToString() : string.Empty;
            }

            return car;
        }

        public static List<Cars> GetCars()
        {
            ISession session = SessionManager.GetSession();
            List<Cars> cars = new List<Cars>();

            if (session == null)
                return null;

            var carsData = session.Execute("select * from \"cars\"");

            foreach (var carData in carsData)
            {
                Cars car = new Cars();
                car.id = carData["id"] != null ? carData["id"].ToString() : string.Empty;
                car.naziv = carData["naziv"] != null ? carData["naziv"].ToString() : string.Empty;
                car.model = carData["model"] != null ? carData["model"].ToString() : string.Empty;
                cars.Add(car);
            }
            return cars;
        }

        public static void AddCars(string id, string naziv, string model)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet carData = session.Execute("insert into \"cars\"(id,naziv,model) values ('"+id+"','"+naziv+"','"+model+"')");
        }

        public static void DeleteCars(string id)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet carData = session.Execute("delete from \"cars\" where \"id\" = '" + id + "'");
        }
        #endregion

        #region Employee
        public static Employee GetEmployee(string id_employee)
        {
            ISession session = SessionManager.GetSession();
            Employee employee = new Employee();

            if (session == null)
                return null;

            Row employeeData = session.Execute("select * from \"employee\" where \"id_employee\"='"+id_employee+"'").FirstOrDefault();

            if (employeeData != null)
            {
                employee.EmployeeId = employeeData["id_employee"] != null ? employeeData["id_employee"].ToString() : string.Empty;
                employee.EmployeeName = employeeData["name_employee"] != null ? employeeData["name_employee"].ToString() : string.Empty;
                employee.EmployeeLname = employeeData["lname_employee"] != null ? employeeData["lname_employee"].ToString() : string.Empty;
            }
            return employee;
        }

        public static List<Employee> GetEmployees()
        {
            ISession session = SessionManager.GetSession();
            List<Employee> employees = new List<Employee>();

            if (session == null)
                return null;

            var empData = session.Execute("select * from \"employee\"");

            foreach (var emp in empData)
            {
                Employee e = new Employee();
                e.EmployeeId = emp["id_employee"] != null ? emp["id_employee"].ToString() : string.Empty;
                e.EmployeeName = emp["name_employee"] != null ? emp["name_employee"].ToString() : string.Empty;
                e.EmployeeLname = emp["lname_employee"] != null ? emp["lname_employee"].ToString() : string.Empty;

                employees.Add(e);
            }
            return employees;
        }

        public static void AddEmployee(string id, string name, string lname)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet empData = session.Execute("insert into \"employee\"(id_employee,name_employee,lname_employee) values ('"
                +id+"','"+name+"','"+lname+"')");
        }

        public static void DeleteEmployee(string id)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet empData = session.Execute("delete from \"employee\" where \"id_employee\"='"+id+"'");
        }
        #endregion
    }
}
