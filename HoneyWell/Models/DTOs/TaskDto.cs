using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneyWell.Models.DTOs
{
    public class TaskDto
    {
        public int TaskID { get; set; }
        public string Name { get; set; }
        public string TaskGroup { get; set; }
    }
}
