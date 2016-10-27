﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfSimple
{
    class MainWindowViewModel
    {
        private ICommand m_ButtonCommand;
        public ICommand ButtonCommand
        {
            get
            {
                return m_ButtonCommand;
            }
            set
            {
                m_ButtonCommand = value;
            }
        }
        public MainWindowViewModel()
        {
            ButtonCommand = new RelayCommand(new Action<object>(ShowMessage));
        }
        public void ShowMessage(object obj)
        {
            MessageBox.Show(obj.ToString());
        }
    }
}
