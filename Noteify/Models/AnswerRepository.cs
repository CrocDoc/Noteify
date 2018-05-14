using Microsoft.Extensions.Options;
using Noteify.Configuration.Options;
using Noteify.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noteify.Models
{
    public class AnswerRepository : ICRUD<Answer>
    {
        private readonly IOptions<Config> _config;
        public AnswerRepository(IOptions<Config> config)
        {
            this._config = config;
        }
        public void Create(Answer obj)
        {
            throw new NotImplementedException();
        }

        public Answer GetObjectByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Answer> GetObjects()
        {
            throw new NotImplementedException();
        }

        public List<Answer> GetObjectsByIDs(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public void Update(Answer obj)
        {
            throw new NotImplementedException();
        }
    }
}
