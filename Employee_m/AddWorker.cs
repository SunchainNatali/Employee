using System;
using System.Collections.Generic;
namespace Employee
{
    public class AddWorker
    {
        public static void AddWorkerNew(int choices, string name, double wage,
        int subordinates, List<Worker>workers)
        {
            switch(choices)
            {
                case 1:
                    workers.Add(new Director(name, wage, subordinates));
                    break;
                case 2:
                    workers.Add(new Engineer(name, wage, subordinates));
                    break;
                case 3:
                    workers.Add(new Master(name, wage, subordinates));
                    break;
                case 4:
                    workers.Add(new Assistant(name, wage, subordinates));
                    break;
                case 5:
                    workers.Add(new JuniorWorker(name, wage, subordinates));
                    break;

            }
        }
    }
}
