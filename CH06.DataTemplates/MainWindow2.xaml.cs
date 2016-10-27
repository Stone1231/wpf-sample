﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CH06.DataTemplates
{
    /// <summary>
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
            DataContext = new ObservableCollection<Person> {
                new Person { Name = "Bart", Age = 10 },
                new Employee { Name = "Homer", Age = 45, Department = "Nuclear" },
                new Person { Name = "Marge", Age = 35 },
                new Employee { Name = "Lisa", Age = 12, Department = "Accounting" },
                new Person { Name = "Maggie", Age = 1 }
            };
        }
    }
}
