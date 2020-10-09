using Microsoft.Win32;
using MusicPlayer.ViewModel;
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
using System.IO;
using TagLib;

namespace MusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            this.viewModel = new MainViewModel();
            this.DataContext = viewModel;

        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Play.Content = "播放";
            var tfile = TagLib.File.Create(@"H:/pagetest/test.mp3");
            string title = tfile.Tag.Title;
            filePath.Text = title;
        }

        private void menuOpen_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                viewModel.NameCollection.Add(new Model.MainModel() { Name=openFileDialog.FileName});
                var tfile = TagLib.File.Create(@"H:/pagetest/test.mp3");
                string title = tfile.Tag.Title;
            }

        }
    }
}
