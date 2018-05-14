using Microsoft.Extensions.Options;
using Noteify.Configuration.Options;
using Noteify.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noteify.Models
{
    public class TestRepository : ICRUD<Test>
    {
        private readonly IOptions<Config> _config;
        public TestRepository(IOptions<Config> config)
        {
            this._config = config;
        }
        public void Create(Test obj)
        {
            throw new NotImplementedException();
        }

        public Test GetObjectByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Test> GetObjects()
        {
            throw new NotImplementedException();
        }

        public List<Test> GetObjectsByIDs(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public void Update(Test obj)
        {
            throw new NotImplementedException();
        }
    }
}
