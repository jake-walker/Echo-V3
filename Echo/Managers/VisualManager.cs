﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Echo.Managers
{
    class VisualManager
    {
        public static void Cleanup()
        {
            try
            {
                MainWindow.main.Dispatcher.Invoke(() => {
                    MainWindow.main.listBoxChannels.Items.Clear();
                    MainWindow.main.listBoxMessages.Items.Clear();
                    MainWindow.main.listBoxUsers.Items.Clear();
                });
            }
            catch
            {
                MessageBox.Show("Unknown error - did the server crash?");
            }
        }

        public static void ClearMessages()
        {
            MainWindow.main.Dispatcher.Invoke(() => {
                MainWindow.main.listBoxMessages.Items.Clear();
            });
        }
        public static void ClearUsers()
        {
            MainWindow.main.Dispatcher.Invoke(() => {
                MainWindow.main.listBoxUsers.Items.Clear();
            });
        }
    }
}
