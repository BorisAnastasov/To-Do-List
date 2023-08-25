using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_do_list
{
       public class Task
       {
              public int Id { get; set; }
              public string? Description { get; set; }
              public bool IsCompleted { get; set; }

              public Task(string description, int id)
              {
                     Description = description;
                     Id = id;
                     IsCompleted = false;
              }
       }
}
