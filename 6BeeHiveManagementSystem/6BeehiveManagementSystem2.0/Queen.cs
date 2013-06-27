using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6BeeHiveManagementSystem2_0
{
    class Queen
    {
        private worker[] workers;
        private int shiftsNumber;
        public Queen(worker[] workers)
        {
            //creat the queen's worker bees
            this.workers = new worker[workers.Length];
            this.workers = workers;
            // initialize some private value;
            shiftsNumber = 0;
        }
        public bool AssignWork(string JobToDo, int ShiftsNeeded)
        {
            // find a worker that is available for this Job.
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(JobToDo, ShiftsNeeded))
                {
                    return true;
                }
                
            }
            //cannot find one available worker bee to do this job
            return false;
        }
        public string WorkTheNextShift()
        {
            shiftsNumber++; 
            string myReport = "Report for shift #" + shiftsNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                bool isWorkDone = workers[i].WorkOneShift();
                if (isWorkDone)
                {
                    myReport += "Worker #" + (i+1) + " finished the job\r\n";
                }
                myReport += getWorkerbeeStatusAndReport(workers[i], i + 1);

            }
            return myReport;

        }
        private string getWorkerbeeStatusAndReport(worker theWorker, int workerNum)
        {
            string report = "";
          if (!string.IsNullOrEmpty(theWorker.CurrentJob))
	      {
               switch (theWorker.ShiftsLeft)
               {
                   case 1:
                       report = "Worker #" + workerNum + " will be done with '" + theWorker.CurrentJob
                           + "' after this shift\r\n";
                       break;
                  default:
                       report = "Worker #" + workerNum + " is doing '" + theWorker.CurrentJob + "' for "
                        + theWorker.ShiftsLeft + " more shifts\r\n";
                       break;
               }
	       }
          else//if (string.IsNullOrEmpty(theWorker.CurrentJob))        
           {
               report += "Worker #" + workerNum + " is not working\r\n";
           }

           return report;
        }
    }
}
