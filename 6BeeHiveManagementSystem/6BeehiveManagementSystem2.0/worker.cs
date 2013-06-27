using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6BeehiveManagementSystem2_0
{
    class worker : Bee
    {
        private string[] jobICanDo;
        public string CurrentJob { get; private set; }
        //private int shiftsLeft;
        public override int ShiftsLeft
        {
            get { return shiftsToWork - shiftsWorked; }
            //set { shiftsLeft = ShiftsLeft; }
        }
        private int shiftsToWork;
        private int shiftsWorked;
        public worker(int beeWeight, string[] jobCanDo)
            : base(beeWeight)
        {
            jobICanDo = new string[jobCanDo.Length];
            jobICanDo = jobCanDo;
            //for (int i = 0; i < jobCanDo.Length - 1; i++)
            //{
            //    jobICanDo[i] = jobCanDo[i];
            //}

        }
        public bool DoThisJob(string jobToDo, int shiftsToWork)
        {
            if (isJobICanDo(jobToDo))
	        {
                if (string.IsNullOrEmpty(CurrentJob))
                {
                    CurrentJob = jobToDo;
                    this.shiftsToWork = shiftsToWork;
                    shiftsWorked = 0;
                    return true;
                }
		 
	        }
            return false;
        }
        public bool WorkOneShift(){
            if (!string.IsNullOrEmpty(CurrentJob))
            {
                shiftsWorked++;
                //ShiftsLeft = shiftsToWork - shiftsWorked;
                if (ShiftsLeft == 0)
                {
                    shiftsToWork = 0;
                    shiftsWorked = 0;
                    CurrentJob = "";
                    return true; // job finished
                }
            } 
            return false; // job not yet finished
        }
        private bool isJobICanDo(string job)
        {
            for (int i = 0; i < jobICanDo.Length; i++)
            {
                if (jobICanDo[i] == job)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
