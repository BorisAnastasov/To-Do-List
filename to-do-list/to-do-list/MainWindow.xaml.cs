using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace to_do_list
{
       public partial class MainWindow : Window
       {
              public TaskManager taskManager = new();

              public MainWindow()
              {
                     InitializeComponent();
              }

              private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
              {

              }

              private void Button_Click(object sender, RoutedEventArgs e)
              {
                     if (inputBox.Text == "Enter your text here..." || string.IsNullOrWhiteSpace(inputBox.Text))
                     {
                            MessageBox.Show("Enter a valid task!");
                     }
                     else
                     {
                            string input = inputBox.Text;
                            inputBox.Text = "";
                            int id = taskManager.Tasks.Count + 1;

                            Task task = new(input, id);

                            taskManager.AddTask(task);

                            taskManager.ShowAllTasks(listBox);
                     }
              }

              private void InputBox_GotFocus(object sender, RoutedEventArgs e)
              {
                     if (inputBox.Text == "Enter your text here...")
                     {
                            inputBox.Text = "";
                     }
              }

              private void InputBox_LostFocus(object sender, RoutedEventArgs e)
              {
                     if (string.IsNullOrWhiteSpace(inputBox.Text))
                     {
                            inputBox.Text = "Enter your text here...";
                     }
              }
       }
}
