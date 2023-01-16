using ClinicService.Models;
using System.Data.SQLite;

namespace ClinicService.Services.Impl
{
    /// <summary>
    /// ДОМАШНЯЯ РАБОТА Добавить имплементацию для текущего репозитория
    /// </summary>
    public class ConsultationRepository : IConsultationRepository
    {
        private const string connectionString = "Data Source = clinic.db; Version = 3; Pooling = true; Max Pool Size = 100;";
        public int Create(Consultation item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = @"INSERT INTO Consultations(ClientId, PetId, ConsultationDate, Description)
                                    VALUES(@ClientId, @PetId, @ConsultationDate, @Description)";
            command.Parameters.AddWithValue("@ClientId", item.ClientId);
            command.Parameters.AddWithValue("@PetId", item.PetId);
            command.Parameters.AddWithValue("@ConsultationDate", item.ConsultationDate.Ticks);
            command.Parameters.AddWithValue("@Description", item.Description);
            command.Prepare();
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res;
        }

        public int Delete(int id)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "DELETE FROM Consultations WHERE ConsultationId=@ConsID";
            command.Parameters.AddWithValue("@ConsID", id);
            command.Prepare();
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res;
        }

        public IList<Consultation> GetAll()
        {
            List<Consultation> consultations = new List<Consultation>();
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "SELECT * FROM Consultations";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Consultation consultation = new Consultation
                {
                    ConsultationId = reader.GetInt32(0),
                    ClientId = reader.GetInt32(1),
                    PetId = reader.GetInt32(2),
                    ConsultationDate = new DateTime(reader.GetInt64(3)),
                    Description = reader.GetString(4)
                };
                consultations.Add(consultation);
            }
            connection.Close();
            return consultations;
        }

        public Consultation GetById(int id)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "SELECT * FROM Consultations WHERE ConsultationId=@ConsID";
            command.Parameters.AddWithValue("@ConsID", id);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Consultation consultation = new Consultation
                {
                    ConsultationId = reader.GetInt32(0),
                    ClientId = reader.GetInt32(1),
                    PetId = reader.GetInt32(2),
                    ConsultationDate = new DateTime(reader.GetInt64(3)),
                    Description = reader.GetString(4)
                };
                connection.Close();
                return consultation;
            }
            else
            {
                connection.Close();
                return null;
            }
        }

        public int Update(Consultation item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "UPDATE Consultations SET ClientId=@ClientId, PetId=@PetId, ConsultationDate=@ConsultationDate, Description=@Description WHERE ConsultationId=@ConsID";
            command.Parameters.AddWithValue("@ClientId", item.ClientId);
            command.Parameters.AddWithValue("@PetId", item.PetId);
            command.Parameters.AddWithValue("@ConsultationDate", item.ConsultationDate.Ticks);
            command.Parameters.AddWithValue("@Description", item.Description);
            command.Parameters.AddWithValue("@ConsID", item.ConsultationId);
            command.Prepare();
            int res = command.ExecuteNonQuery();
            return res;

        }
    }
}
