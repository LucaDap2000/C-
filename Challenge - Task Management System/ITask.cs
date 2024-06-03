using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge___Task_Management_System
{
    internal interface ITask<TResult>
    {
        TResult Perform();
    }
}
