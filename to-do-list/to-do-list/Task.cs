using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace to_do_list
{
       public class Task
       {
              public int Id { get; set; }
              public string? Description { get; set; }
              public RadioButton RadioButton { get; set; }

              public Task(string description, int id)
              {
                     Description = description;
                     Id = id;
                     RadioButton = new RadioButton();
                     RadioButton.IsChecked =false;
              }
       }
}
