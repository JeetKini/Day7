using System.Collections.Generic;

namespace Day7
{
    public class WorkFlow : IWorkFlow
    {
        private List   <Itask> _tasks;
        public WorkFlow()
        {
            _tasks = new List <Itask>();    
        }

         public void Add(Itask task)
        {
            _tasks.Add(task);
        }

         public void Remove(Itask task)
        {
           _tasks.Remove(task);
        }
        public IEnumerable<Itask> GetItasks()
        {
            return _tasks;
        }
    }
}
