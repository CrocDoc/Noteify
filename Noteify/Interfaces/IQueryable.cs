using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noteify.Interfaces
{
    interface ICRUD<T>
    {
        void Create(T obj);
        T GetObjectByID(int id);
        List<T> GetObjects();
        void Update(T obj);

    }
}
