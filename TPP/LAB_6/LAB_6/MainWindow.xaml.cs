using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LAB_6
{
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer;
        private List<string> playlist;

        public MainWindow()
        {
            InitializeComponent();
            mediaPlayer = new MediaPlayer();
            playlist = new List<string>();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (playlist.Count == 0)
            {
                MessageBox.Show("Добавьте файлы в плейлист", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string selectedFile = PlaylistListBox.SelectedItem as string;
            if (selectedFile == null)
                selectedFile = playlist.First();

            mediaPlayer.Open(new Uri(selectedFile));
            mediaPlayer.Play();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void AddFilesButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Аудиофайлы (*.mp3;*.wav)|*.mp3;*.wav";

            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    playlist.Add(fileName);
                    PlaylistListBox.Items.Add(fileName);
                }
            }
        }

        private void SavePlaylistButton_Click(object sender, RoutedEventArgs e)
        {
            if (playlist.Count == 0)
            {
                MessageBox.Show("Добавьте файлы в плейлист", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Плейлист (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllLines(saveFileDialog.FileName, playlist);
                MessageBox.Show("Плейлист сохранен успешно", "Сохранение плейлиста", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (StackPanel item in grid.Children.OfType<StackPanel>())
            {
                foreach (Button item1 in item.Children.OfType<Button>())
                {
                    item1.Background = new SolidColorBrush(Color.FromArgb(Convert.ToByte(rnd.Next(1, 255)), Convert.ToByte(rnd.Next(1, 255)), Convert.ToByte(rnd.Next(1, 255)), Convert.ToByte(rnd.Next(1, 255))));
                }
                item.Background = new SolidColorBrush(Color.FromArgb(Convert.ToByte(rnd.Next(1, 255)), Convert.ToByte(rnd.Next(1, 255)), Convert.ToByte(rnd.Next(1, 255)), Convert.ToByte(rnd.Next(1, 255))));
            }

        }

        private void OpenPlaylistButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Плейлист (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                playlist = File.ReadAllLines(openFileDialog.FileName).ToList();
                PlaylistListBox.Items.Clear();
                foreach (string fileName in playlist)
                {
                    PlaylistListBox.Items.Add(fileName);
                }
            }
        }
    }
}