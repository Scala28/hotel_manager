using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace _04_GestionaleHotel
{
    public class GestioneDati
    {
        public MySqlConnection connection;

        public GestioneDati()
        {
            string s = "database=hotel; host=127.0.0.1; port=3306; user=root; pwd=";
            connection = new MySqlConnection(s);
            connection.Open();
        }

        public List<Camera> DammiCamere()
        {
            string query = "SELECT * " +
                            "FROM camere";
            List<Camera> ris = new List<Camera>();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Camera c = new Camera()
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Posti = Convert.ToInt32(reader["Posti"]),
                    Foto = Convert.ToString(reader["Foto"]),
                    Costo = Convert.ToDouble(reader["Costo"])
                };
                ris.Add(c);
            }
            reader.Close();
            foreach(Camera c in ris)
            {
                c.Voti = DammiVotiCamera(c.ID);
            }
            return ris;
        }
        public string AggiungiRecensione(Camera c, double voto)
        {
            string ris = "ok";
            try
            {
                string query = "INSERT INTO recensioni(Voto, IDCamera)" +
                    "VALUES(@Voto, @IDCamera)";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@Voto", voto);
                cmd.Parameters.AddWithValue("@IDCamera", c.ID);

                cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                ris = e.Message;
            }

            return ris;
        }
        public List<double> DammiVotiCamera(int IDcamera)
        {
            List<double> ris = new List<double>();
            string query = "SELECT Voto " +
                "FROM recensioni " +
                "WHERE recensioni.IDCamera = @IDCamera";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@IDCamera", IDcamera);

            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                ris.Add(Convert.ToDouble(reader["Voto"]));
            }
            reader.Close();

            return ris;
        }
        public List<Prenotazione> DammiPrenotazioni()
        {
            List<Prenotazione> ris = new List<Prenotazione>();

            string query = "SELECT * " +
                "FROM prenotazioni";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Prenotazione p = new Prenotazione()
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    CheckIn = Convert.ToDateTime(reader["CheckIn"]),
                    CheckOut = Convert.ToDateTime(reader["CheckOut"]),
                    NumPersone = Convert.ToInt32(reader["NumPersone"]),
                    IDTrattamento = Convert.ToString(reader["IDTrattamento"])!,
                    IDCliente = Convert.ToInt32(reader["IDCliente"]),
                    IDCamera = Convert.ToInt32(reader["IDCamera"])
                };
                ris.Add(p);
            }
            reader.Close();
            foreach(Prenotazione p in ris)
            {
                p.trattamento = DammiTrattamento(p.IDTrattamento)!;
                p.cliente = DammiCliente(p.IDCliente)!;
                p.camera = DammiCamera(p.IDCamera)!;
                p.Costo = (p.camera.Costo * (p.CheckOut - p.CheckIn).TotalDays) * p.trattamento.MoltiplicatoreCosto;
                p.Costo = Math.Truncate(p.Costo * 100) / 100;
            }
            return ris;
        }
        public List<Prenotazione> DammiPrenotazioniCamera(Camera c)
        {
            string query = "SELECT * " +
                "FROM prenotazioni INNER JOIN camere " +
                "ON prenotazioni.IDCamera = camere.ID " +
                "WHERE camere.ID = " + c.ID.ToString();
            List<Prenotazione> ris = new List<Prenotazione>();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Prenotazione p = new Prenotazione()
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    CheckIn = Convert.ToDateTime(reader["CheckIn"]),
                    CheckOut = Convert.ToDateTime(reader["CheckOut"]),
                    NumPersone = Convert.ToInt32(reader["NumPersone"]),
                    IDTrattamento = Convert.ToString(reader["IDTrattamento"])!,
                    IDCliente = Convert.ToInt32(reader["IDCliente"]),
                    IDCamera = Convert.ToInt32(reader["IDCamera"])
                };
                ris.Add(p);
            }
            reader.Close();
            foreach(Prenotazione p in ris)
            {
                p.cliente = DammiCliente(p.IDCliente)!;
                p.camera = DammiCamera(p.IDCamera)!;
                p.trattamento = DammiTrattamento(p.IDTrattamento)!;
                p.Costo = (p.camera.Costo * (p.CheckOut - p.CheckIn).TotalDays) * p.trattamento.MoltiplicatoreCosto;
                p.Costo = Math.Truncate(p.Costo * 100) / 100;
            }
            return ris;
        }
        public string AggiornaCamera(Camera c)
        {
            string ris = "ok";
            try
            {
                string query = "UPDATE camere SET Posti=@Posti, Foto=@Foto, Costo=@Costo " +
                    "WHERE ID=@ID";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Posti", c.Posti);
                cmd.Parameters.AddWithValue("@Foto", c.Foto);
                cmd.Parameters.AddWithValue("@Costo", c.Costo);
                cmd.Parameters.AddWithValue("@ID", c.ID);
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                ris = ex.Message;
            }

            return ris;
        }
        public Camera? DammiCamera(int ID)
        {
            Camera ris = null;
            string query = "SELECT * " +
                "FROM camere " +
                "WHERE ID = @ID";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);

            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                ris = new Camera()
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Posti = Convert.ToInt32(reader["Posti"]),
                    Foto = Convert.ToString(reader["Foto"]),
                    Costo = Convert.ToDouble(reader["Costo"])
                };
            }

            reader.Close();
            ris.Voti = DammiVotiCamera(ris.ID);

            return ris;
        }
        public Cliente? DammiCliente(int ID)
        {
            Cliente ris = null;
            string query = "SELECT * " +
                "FROM clienti " +
                "WHERE ID = @ID";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ris = new Cliente()
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Nome = Convert.ToString(reader["Nome"])!,
                    Cognome = Convert.ToString(reader["Cognome"])!,
                    Telefono = Convert.ToString(reader["Telefono"]),
                    email = Convert.ToString(reader["email"])
                };
            }

            reader.Close();

            return ris;
        }
        public Trattamento? DammiTrattamento(string ID)
        {
            Trattamento ris = null;
            string query = "SELECT * " +
                "FROM trattamenti " +
                "WHERE Tipo = @ID";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ris = new Trattamento()
                {
                    Tipo = Convert.ToString(reader["Tipo"]),
                    MoltiplicatoreCosto = Convert.ToDouble(reader["MoltiplicatoreCosto"])
                };
            }

            reader.Close();

            return ris;
        }
        public string AggiungiCamera(int posti, string? foto, double costo)
        {
            string ris = "ok";
            try
            {
                string query = "INSERT INTO camere(Posti, Foto, Costo) " +
                "VALUES(@posti, @foto, @costo)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@posti", posti);
                cmd.Parameters.AddWithValue("@foto", foto);
                cmd.Parameters.AddWithValue("@costo", costo);

                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                ris = ex.Message;
            }
            return ris;
        }
        public string EliminaCamera(int ID)
        {
            string ris = "ok";
            try
            {
                string query = "DELETE FROM camere " +
                    "WHERE ID = @ID";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();


            }catch(Exception ex)
            {
                ris = ex.Message;
            }
            return ris;
        }

        public List<Cliente> DammiClienti()
        {
            List<Cliente> ris = new List<Cliente>();

            string query = "SELECT * " +
                "FROM clienti";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Cliente c = new Cliente()
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Nome = reader["Nome"].ToString()!,
                    Cognome = reader["Cognome"].ToString()!,
                    Telefono = reader["Telefono"].ToString(),
                    email = reader["email"].ToString()
                };
                ris.Add(c);
            }
            reader.Close();

            return ris;
        }

        public List<Trattamento> DammiTrattamenti()
        {
            List<Trattamento> ris = new List<Trattamento>();

            string query = "SELECT * " +
                "FROM trattamenti";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Trattamento t = new Trattamento()
                {
                    Tipo = reader["Tipo"].ToString()!,
                    MoltiplicatoreCosto = Convert.ToDouble(reader["MoltiplicatoreCosto"])
                };
                ris.Add(t);
            }
            reader.Close();

            return ris;
        }
        public string AggiungiPrenotazione(DateTime checkIn, DateTime checkOut, int numPersone, string IdTrattamento, int IDCliente, int IDCamera)
        {
            string ris = "ok";
            try
            {
                string query = "INSERT INTO prenotazioni (CheckIn, CheckOut, NumPersone, IDTrattamento, IDCliente, IDCamera) " +
                    "VALUES (@CheckIn, @CheckOut, @NumPersone, @IDTrattamento, @IDCliente, @IDCamera)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CheckIn", checkIn);
                cmd.Parameters.AddWithValue("@CheckOut", checkOut);
                cmd.Parameters.AddWithValue("@NumPersone", numPersone);
                cmd.Parameters.AddWithValue("@IDTrattamento", IdTrattamento);
                cmd.Parameters.AddWithValue("@IDCliente", IDCliente);
                cmd.Parameters.AddWithValue("@IDCamera", IDCamera);

                cmd.ExecuteNonQuery();


            }catch(Exception ex)
            {
                ris = ex.Message;
            }
            return ris;
        }
        public string AggiornaPrenotazione(int ID, DateTime checkIn, DateTime checkOut, int numPersone, string IdTrattamento, int IDCliente, int IDCamera)
        {
            string ris = "ok";
            try
            {
                string query = "UPDATE prenotazioni " +
                    "SET CheckIn=@checkIn, CheckOut=@checkOut, " +
                    "NumPersone=@numPersone, IDTrattamento=@idTrattamento, IDCliente=@idCliente, IDCamera=@idCamera " +
                    "WHERE ID=@id";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@checkIn", checkIn);
                cmd.Parameters.AddWithValue("@checkOut", checkOut);
                cmd.Parameters.AddWithValue("@numPersone", numPersone);
                cmd.Parameters.AddWithValue("@idTrattamento", IdTrattamento);
                cmd.Parameters.AddWithValue("@idCliente", IDCliente);
                cmd.Parameters.AddWithValue("@idCamera", IDCamera);
                cmd.Parameters.AddWithValue("@id", ID);

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                ris = ex.Message;
            }
            return ris;
        }
        public string DeletePrenotazione(int ID)
        {
            string ris = "ok";
            try
            {
                string query = "DELETE FROM prenotazioni " +
                    "WHERE ID=@ID";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();


            }catch(Exception ex)
            {
                ris = ex.Message;
            }
            return ris;
        }

        public List<Prenotazione> DammiPrenotazioneMese(DateTime date)
        {
            List<Prenotazione> ris = new List<Prenotazione>();

            int year = date.Year;
            int month = date.Month;
            int daysInMonth = DateTime.DaysInMonth(year, month);

            string query = "SELECT * " +
                "FROM prenotazioni " +
                "WHERE CheckIn BETWEEN @startDate and @endDate";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@startDate", new DateTime(year, month, 1));
            cmd.Parameters.AddWithValue("@endDate", new DateTime(year, month, daysInMonth));

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Prenotazione p = new Prenotazione()
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    CheckIn = Convert.ToDateTime(reader["CheckIn"]),
                    CheckOut = Convert.ToDateTime(reader["CheckOut"]),
                    NumPersone = Convert.ToInt32(reader["NumPersone"]),
                    IDTrattamento = Convert.ToString(reader["IDTrattamento"])!,
                    IDCliente = Convert.ToInt32(reader["IDCliente"]),
                    IDCamera = Convert.ToInt32(reader["IDCamera"])
                };
                ris.Add(p);
            }
            reader.Close();
            foreach (Prenotazione p in ris)
            {
                p.cliente = DammiCliente(p.IDCliente)!;
                p.camera = DammiCamera(p.IDCamera)!;
                p.trattamento = DammiTrattamento(p.IDTrattamento)!;
                p.Costo = (p.camera.Costo * (p.CheckOut - p.CheckIn).TotalDays) * p.trattamento.MoltiplicatoreCosto;
                p.Costo = Math.Truncate(p.Costo * 100) / 100;
            }
            return ris;
        }
        public List<Prenotazione> DammiPrenotazioniCliente(int IdCliente)
        {
            List<Prenotazione> ris = new List<Prenotazione>();

            string query = "SELECT * " +
                "FROM prenotazioni " +
                "WHERE IDCliente=@IdCliente";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@IdCliente", IdCliente);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Prenotazione p = new Prenotazione()
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    CheckIn = Convert.ToDateTime(reader["CheckIn"]),
                    CheckOut = Convert.ToDateTime(reader["CheckOut"]),
                    NumPersone = Convert.ToInt32(reader["NumPersone"]),
                    IDTrattamento = Convert.ToString(reader["IDTrattamento"])!,
                    IDCliente = Convert.ToInt32(reader["IDCliente"]),
                    IDCamera = Convert.ToInt32(reader["IDCamera"])
                };
                ris.Add(p);
            }
            reader.Close();
            foreach (Prenotazione p in ris)
            {
                p.cliente = DammiCliente(p.IDCliente)!;
                p.camera = DammiCamera(p.IDCamera)!;
                p.trattamento = DammiTrattamento(p.IDTrattamento)!;
                p.Costo = (p.camera.Costo * (p.CheckOut - p.CheckIn).TotalDays) * p.trattamento.MoltiplicatoreCosto;
                p.Costo = Math.Truncate(p.Costo * 100) / 100;
            }
            return ris;
        }
        public List<Prenotazione> DammiPrenotazioneTrattamento(string trattamento)
        {
            List<Prenotazione> ris = new List<Prenotazione>();

            string query = "SELECT * " +
                "FROM prenotazioni " +
                "WHERE IDTrattamento=@trattamento";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@trattamento", trattamento);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Prenotazione p = new Prenotazione()
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    CheckIn = Convert.ToDateTime(reader["CheckIn"]),
                    CheckOut = Convert.ToDateTime(reader["CheckOut"]),
                    NumPersone = Convert.ToInt32(reader["NumPersone"]),
                    IDTrattamento = Convert.ToString(reader["IDTrattamento"])!,
                    IDCliente = Convert.ToInt32(reader["IDCliente"]),
                    IDCamera = Convert.ToInt32(reader["IDCamera"])
                };
                ris.Add(p);
            }
            reader.Close();
            foreach (Prenotazione p in ris)
            {
                p.cliente = DammiCliente(p.IDCliente)!;
                p.camera = DammiCamera(p.IDCamera)!;
                p.trattamento = DammiTrattamento(p.IDTrattamento)!;
                p.Costo = (p.camera.Costo * (p.CheckOut - p.CheckIn).TotalDays) * p.trattamento.MoltiplicatoreCosto;
                p.Costo = Math.Truncate(p.Costo * 100) / 100;
            }
            return ris;
        }
        public string AggiornaCliente(int ID, string Nome, string Cognome, string? Telefono, string? email)
        {
            string ris = "ok";
            try
            {
                string query = "UPDATE clienti " +
                    "SET Nome=@Nome, Cognome=@Cognome, Telefono=@Telefono, email=@email " +
                    "WHERE ID=@ID";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Cognome", Cognome);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();

            }catch(Exception e)
            {
                ris = e.Message;
            }
            return ris;
        }
        public string AggiungiCliente(string Nome, string Cognome, string? Telefono, string? email)
        {
            string ris = "ok";
            try
            {
                string query = "INSERT INTO clienti(Nome, Cognome, Telefono, email) " +
                    "VALUES (@Nome, @Cognome, @telefono, @email)";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Cognome", Cognome);
                cmd.Parameters.AddWithValue("@telefono", Telefono);
                cmd.Parameters.AddWithValue("@email", email);

                cmd.ExecuteNonQuery();

            }catch(Exception ex)
            {
                ris = ex.Message;
            }
            return ris;
        }
        public string RemoveCliente(int IdCliente)
        {
            string ris = "ok";
            try
            {
                string query = "DELETE FROM clienti " +
                    "WHERE ID=@IDcliente";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IDcliente", IdCliente);

                cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                ris = e.Message;
            }
            return ris;
        }

        public string ModificaTrattamento(string oldTipo, string newTipo, double moltiplicatore)
        {
            string ris = "ok";
            try
            {
                string query = "UPDATE trattamenti " +
                    "SET Tipo=@newTipo, MoltiplicatoreCosto=@moltiplicatore " +
                    "WHERE Tipo=@oldTipo";

                MySqlCommand cmd= new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@newTipo", newTipo);
                cmd.Parameters.AddWithValue("@moltiplicatore", moltiplicatore);
                cmd.Parameters.AddWithValue("@oldTipo", oldTipo);

                cmd.ExecuteNonQuery();


            }catch(Exception ex)
            {
                ris = ex.Message;
            }
            return ris;
        }
        public string AggiungiTrattamento(string tipo, double moltiplicatore)
        {
            string ris = "ok";
            try
            {
                string query = "INSERT INTO trattamenti(Tipo, MoltiplicatoreCosto) " +
                    "VALUES (@tipo, @moltiplicatore)";

                MySqlCommand cmd= new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@moltiplicatore", moltiplicatore);

                cmd.ExecuteNonQuery();


            }catch(Exception ex)
            {
                ris = ex.Message;
            }
            return ris;
        }
        public string EliminaTrattamento(string tipo)
        {
            string ris = "ok";
            try
            {
                string query = "DELETE FROM trattamenti " +
                    "WHERE Tipo=@tipo";

                MySqlCommand cmd= new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@tipo", tipo);

                cmd.ExecuteNonQuery();


            }catch(Exception ex)
            {
                ris = ex.Message;
            }
            return ris;
        }

    }
}
