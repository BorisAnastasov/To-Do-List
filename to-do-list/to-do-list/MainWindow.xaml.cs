﻿using System;
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
       /// <summary>
       /// Interaction logic for MainWindow.xaml
       /// </summary>
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

              private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
              {

              }

              private void Button_Click(object sender, RoutedEventArgs e)
              {
                     string input = inputBox.Text;
                     inputBox.Text = "";
                     int id = taskManager.Tasks.Count;

                     Task task = new(input, id);

                     taskManager.AddTask(task);

                     taskManager.ShowAllTasks(listBox);
              }
       }
}
