using CRUDWinFormsMVPP.Models;
using MvpCrudApp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CRUDWinFormsMVPP._Repositories
{
    public class PetRepository : BaseRepository, IPetRepository
    {
        public PetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(PetModel petModel)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO pet (pet_name, pet_type, pet_colour) VALUES (@name, @type, @colour)";
                command.Parameters.AddWithValue("@name", petModel.Name);
                command.Parameters.AddWithValue("@type", petModel.Type);
                command.Parameters.AddWithValue("@colour", petModel.Colour);
                command.ExecuteNonQuery();
            }
        }

        public void Edit(PetModel petModel)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE pet SET pet_name=@name, pet_type=@type, pet_colour=@colour WHERE pet_id=@id";
                command.Parameters.AddWithValue("@name", petModel.Name);
                command.Parameters.AddWithValue("@type", petModel.Type);
                command.Parameters.AddWithValue("@colour", petModel.Colour);
                command.Parameters.AddWithValue("@id", petModel.Id);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM pet WHERE pet_id=@id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<PetModel> GetAll()
        {
            var petList = new List<PetModel>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM pet ORDER BY pet_id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        petList.Add(new PetModel
                        {
                            Id = Convert.ToInt32(reader["pet_id"]),
                            Name = reader["pet_name"].ToString(),
                            Type = reader["pet_type"].ToString(),
                            Colour = reader["pet_colour"].ToString()
                        });
                    }
                }
            }
            return petList;
        }

        public IEnumerable<PetModel> GetByValue(string value)
        {
            var petList = new List<PetModel>();
            int petId = int.TryParse(value, out int id) ? id : 0;

            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM pet 
                                        WHERE pet_id=@id OR pet_name LIKE CONCAT(@name, '%') 
                                        ORDER BY pet_id DESC";
                command.Parameters.AddWithValue("@id", petId);
                command.Parameters.AddWithValue("@name", value);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        petList.Add(new PetModel
                        {
                            Id = Convert.ToInt32(reader["pet_id"]),
                            Name = reader["pet_name"].ToString(),
                            Type = reader["pet_type"].ToString(),
                            Colour = reader["pet_colour"].ToString()
                        });
                    }
                }
            }
            return petList;
        }
    }
}