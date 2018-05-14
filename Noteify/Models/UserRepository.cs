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
            using (SqlConnection conn = new SqlConnection(_config.Value.connectionStrings.DefaultConnection))
            {
                string sqlCommand = "Insert into tb_Users (Username,Email,DateOfRegistration,IsActive) Values ({obj.Username},{obj.Email},{Datetime.Now},{true})";
            }
                throw new NotImplementedException();
        }

        public User GetObjectByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetObjects()
        {
            throw new NotImplementedException();
        }

        public List<User> GetObjectsByIDs(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public void Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
