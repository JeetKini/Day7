using System;

namespace Day7
{
    class WorkFlowEngine
    {
        public void run(IWorkFlow workFlow)
        {

            foreach (Itask I in workFlow.GetItasks())
            {
                try
                {
                    I.Execute();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        internal void run()
        {
            throw new NotImplementedException();
        }
    }
}
