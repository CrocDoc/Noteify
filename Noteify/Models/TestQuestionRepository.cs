using Microsoft.Extensions.Options;
using Noteify.Configuration.Options;
using Noteify.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noteify.Models
{
    public class TestQuestionRepository : ICRUD<TestQuestion>
    {
        private readonly IOptions<Config> _config;
        public TestQuestionRepository(IOptions<Config> config)
        {
            this._config = config;
        }
        public void Create(TestQuestion obj)
        {
            throw new NotImplementedException();
        }

        public TestQuestion GetObjectByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TestQuestion> GetObjects()
        {
            throw new NotImplementedException();
        }

        public List<TestQuestion> GetObjectsByIDs(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public void Update(TestQuestion obj)
        {
            throw new NotImplementedException();
        }
    }
}
