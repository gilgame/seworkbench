﻿using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Gilgame.SEWorkbench.ViewModels
{
    public class EditorViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<PageViewModel> _Items = new ObservableCollection<PageViewModel>();
        public ObservableCollection<PageViewModel> Items
        {
            get
            {
                return _Items;
            }
        }
        
        public bool HasChildren
        {
            get
            {
                return _Items.Count > 0;
            }
        }

        public EditorViewModel()
        {
            _Items.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged("HasChildren");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public void SelectionChanged()
        {
            // TODO implementation (if needed ?)
            //OnPropertyChanged("SelectedItemType");
        }
    }
}
