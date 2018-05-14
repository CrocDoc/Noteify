using Microsoft.Extensions.Options;
using Noteify.Configuration.Options;
using Noteify.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noteify.Models
{
    public class QuestionRepository : ICRUD<Question>
    {
        private readonly IOptions<Config> _config;
        public QuestionRepository(IOptions<Config> config)
        {
            this._config = config;
        }
        public void Create(Question obj)
        {
            throw new NotImplementedException();
        }

        public Question GetObjectByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetObjects()
        {
            throw new NotImplementedException();
        }

        public List<Question> GetObjectsByIDs(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public void Update(Question obj)
        {
            throw new NotImplementedException();
        }
    }
}
