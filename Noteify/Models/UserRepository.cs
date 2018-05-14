using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Noteify.Interfaces;
using Microsoft.Extensions.Options;
using Noteify.Configuration.Options;

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
