using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public String TaskName { get; set; }
        public String TaskDescription { get; set; }
        public String TaskAuthor { get; set; }

        public Task()
        {

        }



    }
}
