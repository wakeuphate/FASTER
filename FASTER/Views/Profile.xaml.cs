﻿using FASTER.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;

namespace FASTER.Views
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) => Refresh();

        public MainWindow MetroWindow => (MainWindow)Window.GetWindow(this);

        internal void Refresh()
        {
            if (DataContext == null) return;
            ((ProfileViewModel)DataContext).LoadData();
        }

        private void CopyFromClient(object sender, RoutedEventArgs e)
        {
            if (DataContext == null) return;
            ((ProfileViewModel)DataContext).ModsCopyFrom(((MenuItem)sender).Tag, "Client");
        }

        private void CopyFromServer(object sender, RoutedEventArgs e)
        {
            if (DataContext == null) return;
            ((ProfileViewModel)DataContext).ModsCopyFrom(((MenuItem)sender).Tag, "Server");
        }

        private void CopyFromHeadless(object sender, RoutedEventArgs e)
        {
            if (DataContext == null) return;
            ((ProfileViewModel)DataContext).ModsCopyFrom(((MenuItem)sender).Tag, "Headless");
        }

        private void ModsSelectAll(object sender, RoutedEventArgs e)
        {
            if (DataContext == null) return;
            ((ProfileViewModel)DataContext).ModsSelectAll(((MenuItem)sender).Tag, true);
        }

        private void ModsSelectNone(object sender, RoutedEventArgs e)
        {
            if (DataContext == null) return;
            ((ProfileViewModel)DataContext).ModsSelectAll(((MenuItem)sender).Tag, false);
        }

        private void MissionSelectAll(object sender, RoutedEventArgs e)
        {
            if (DataContext == null) return;
            ((ProfileViewModel)DataContext).MissionSelectAll(true);
        }

        private void MissionSelectNone(object sender, RoutedEventArgs e)
        {
            if (DataContext == null) return;
            ((ProfileViewModel)DataContext).MissionSelectAll(false);
        }

        private void MissionRefresh(object sender, RoutedEventArgs e)
        {
            if (DataContext == null) return;
            ((ProfileViewModel)DataContext).LoadMissions();
        }
    }
}