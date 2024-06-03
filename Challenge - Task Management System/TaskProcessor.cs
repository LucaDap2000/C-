using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge___Task_Management_System
{
    internal class TaskProcessor<TTask, TResult> where TTask : ITask<TResult>
    {
        private TTask task;

        public TaskProcessor(TTask taskParam)
        {
            this.task = taskParam;
        }

        public TResult Execute()
        {
            return task.Perform();
        }
    }
}
