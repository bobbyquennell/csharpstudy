using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6BeeHiveManagementSystem
{
    class Queen
    {
        private worker[] workers;
        private int shiftsNumber;
        public Queen(worker[] workers, int shiftsNumber)
        {
            //creat the queen's worker bees
            this.workers = new worker[workers.Length];
            this.workers = workers;
            // initialize some private value;
            //shiftsNumber ???????
        }
        public bool AssignWork(string JobToDo, int ShiftsNeeded)
        {
            // find a worker that is available for this Job.
            for (int i = 0; i < workers.Length - 1; i++)
            {
                if (workers[i].DoThisJob(JobToDo, ShiftsNeeded))
                {
                    return true;
                }
                
            }
            //cannot find one available worker bee to do this job
            return false;
        }
        public void WorkTheNextShift()
        {
            //maker all worker bees to work a shift
            for (int i = 0; i < workers.Length - 1; i++)
            {
                workers[i].WorkOneShift();

            }
            //check worker bees' status
            //make a shift's report.
        }
        private string getWorkerbeeStatus(worker theWorker)
        {
           if(string.IsNullOrEmpty(theWorker.CurrentJob))
           {}  //output: worker #x is not working;
           else
	       {
               switch (theWorker.ShiftsLeft)
               {
                  default:
               }
	       }

        }
    }
}
