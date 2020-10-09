using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using MusicPlayer.Model;

namespace MusicPlayer.ViewModel
{
    public class MainViewModel
    {
        private ObservableCollection<MainModel> _nameCollection;
        public ObservableCollection<MainModel> NameCollection
        {
            get
            {
                return _nameCollection;
            }
            set
            {
                _nameCollection = value;
            }
        }
        public MainViewModel()
        {
            Do();
        }
        private void Do()
        {
            NameCollection = new ObservableCollection<MainModel>();
            NameCollection.Add(new MainModel() { Name = "张三" });
            NameCollection.Add(new MainModel() { Name = "李四" });
            NameCollection.Add(new MainModel() { Name = "王五" });
        }
    }
}
