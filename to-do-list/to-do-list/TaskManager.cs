using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
namespace to_do_list
{
       public class TaskManager
       {
              private List<Task> tasks = new();

              public List<Task> Tasks
              {
                     get { return tasks; }
              }

              public void AddTask(Task task)
              {
                     tasks.Add(task);
              }

              public void ShowAllTasks(ListBox listBox)
              {
                     listBox.Items.Clear();
                     foreach (Task task in tasks)
                     {
                            ItemsControl item = new ItemsControl();
                            listBox.Items.Add($"{task.Id}. {task.Description}");
                     }
              }
       }
}
