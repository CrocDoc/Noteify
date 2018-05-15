using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Noteify.Interfaces;
using Microsoft.Extensions.Options;
using Noteify.Configuration.Options;
using Dapper;
using System.Data.SqlClient;

namespace Noteify.Models
{
    public class UserRepository : ICRUD<User>
    {
        private readonly IOptions<Config> _config;
        public UserRepository(IOptions<Config> config)
        {
            this._config = config;
        }


        public void Create(User obj)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_config.Value.connectionStrings.DefaultConnection))
                {
                    string sqlCommand = "Insert into tb_Users (Username,Email,DateOfRegistration,IsActive) Values" +
                        " (@Username,@Email,@DateOfRegistration,@IsActive)";

                    conn.Open();
                    conn.Execute(sqlCommand, new { Username = obj.Username, Email = obj.Email, DateOfRegistration = obj.DateOfRegistration, IsActive = obj.IsActive });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public User GetObjectByID(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_config.Value.connectionStrings.DefaultConnection))
                {
                    string sqlCommand = "select * from tb_Users where id = @id";

                    conn.Open();
                    List<User> result = conn.Query<User>(sqlCommand).ToList();
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<User> GetObjects()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_config.Value.connectionStrings.DefaultConnection))
                {
                    string sqlCommand = "select * from tb_Users";

                    conn.Open();
                    List<User> result = conn.Query<User>(sqlCommand).ToList();
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public void Update(User obj)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_config.Value.connectionStrings.DefaultConnection))
                {
                    string sqlCommand = "update tb_Users set Username = @Username, Email = @Email where id = @id";

                    conn.Open();

                    conn.Execute(sqlCommand, new { Username = obj.Username, Email = obj.Email });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
