using System.Collections.Generic;

namespace Day7
{
    public interface IWorkFlow {
        void Add(Itask task);
         void Remove(Itask task);
        IEnumerable<Itask> GetItasks();
    }
}
