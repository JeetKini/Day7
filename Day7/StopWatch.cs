using System;

namespace Day7
{
    class StopWatch { 
        private DateTime _start;
        private DateTime _stop;
        private bool _running;
        public void StartTime()
        { 
            _start = DateTime.Now;
            if (_running)
            {
                throw new Exception("StopWatch is already running");
            }
                _start = DateTime.Now;
            Console.WriteLine(TimeSpan.Zero);
            _running = true;
            
        }
        public void StopTime() {
            if (!_running)
            {
                throw new Exception("StopWatch is not running");

            }
                _stop = DateTime.Now;
            
            _running = false;
        }
        public TimeSpan GetInterval() { 
        return _stop - _start;
        }
    
    }
}
