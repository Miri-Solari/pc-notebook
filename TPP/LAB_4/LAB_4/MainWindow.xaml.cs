using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LAB_4
{
    public partial class MainWindow : Window
    {
        private string filePath;

        public MainWindow()
        {
            InitializeComponent();
            filePath = "notes.txt";
            LoadNotes();
        }

        private void SaveNotes()
        {
            string text = textBox.Text.Trim();
            if (!string.IsNullOrEmpty(text))
            {
                File.WriteAllText(filePath, text);
            }
        }

        private void LoadNotes()
        {
            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                textBox.Text = text;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveNotes();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (colorComboBox.SelectedItem.ToString() != null)
            {
                string colorName = colorComboBox.SelectedItem.ToString()[38..];
                Color color = (Color)ColorConverter.ConvertFromString(colorName);
                SolidColorBrush brush = new SolidColorBrush(color);
                textBox.Background = brush;
            }
        }

        private void FontComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fontComboBox.SelectedItem != null)
            {
                string fontFamily = fontComboBox.SelectedItem.ToString()[38..];
                textBox.FontFamily = new FontFamily(fontFamily);
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

    }
}