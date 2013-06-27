using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6BeehiveManagementSystem2_0
{
    class Queen : Bee
    {
        private worker[] workers;
        private int shiftsNumber;
        public Queen(worker[] workers)
            :base(275)
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
            double TotalHoneyConsumption = 0 ; 
            shiftsNumber++; 
            string myReport = "Report for shift #" + shiftsNumber + "\r\n";
            //Get total honey consumption
            for (int i = 0; i < workers.Length; i++)
                TotalHoneyConsumption += workers[i].GetHoneyConsumption();  
            TotalHoneyConsumption += GetHoneyConsumption();

            for (int i = 0; i < workers.Length; i++)
            {
                bool isWorkDone = workers[i].WorkOneShift();
                
                if (isWorkDone)
                {
                    myReport += "Worker #" + (i+1) + " finished the job\r\n";
                }
                myReport += getWorkerbeeStatusAndReport(workers[i], i + 1);

            }

            myReport += "Total honey consumption: " + TotalHoneyConsumption + " units \r\n";
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

        public override double GetHoneyConsumption()
        {
            double myHoneyConsumption = workers[0].GetHoneyConsumption();
            int currentWorkingBeeNum = 0;

            //find who use the most honey
            for (int i = 0; i < workers.Length; i++)
            {
                if (myHoneyConsumption <= workers[i].GetHoneyConsumption())
                    myHoneyConsumption = workers[i].GetHoneyConsumption();//find who use the most honey
                if (!string.IsNullOrEmpty(workers[i].CurrentJob))
                    currentWorkingBeeNum++;//get how many bees are working
            }
            if ((currentWorkingBeeNum <= 2) && (currentWorkingBeeNum > 0))
                myHoneyConsumption += 20;
            if (currentWorkingBeeNum >= 3)
                myHoneyConsumption += 30;
            return myHoneyConsumption;
        }
    }
}
