using System;
using System.IO;
using System.Speech.Synthesis;
using System.Windows;
namespace LAB_7
{
    public partial class MainWindow : Window
    {
        private SpeechSynthesizer synthesizer;

        public MainWindow()
        {
            InitializeComponent();
            synthesizer = new SpeechSynthesizer();
        }

        private void LoadFileButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();

                if (fileExtension == ".txt")
                {
                    string text = File.ReadAllText(filePath);
                    inputTextBox.Text = text;
                }
                else if (fileExtension == ".wav")
                {
                    synthesizer.SetOutputToDefaultAudioDevice();
                    synthesizer.SpeakAsyncCancelAll();
                    synthesizer.SpeakAsync(filePath);
                }
                else
                {
                    MessageBox.Show("Неподдерживаемый формат файла.");
                }
            }
        }

        private void SynthesizeButton_Click(object sender, RoutedEventArgs e)
        {
            string text = inputTextBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                synthesizer.SetOutputToDefaultAudioDevice();
                synthesizer.SpeakAsyncCancelAll();
                synthesizer.SpeakAsync(text);
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string text = inputTextBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
                if (saveFileDialog.ShowDialog() == true)
                {
                    string filePath = saveFileDialog.FileName;
                    synthesizer.SetOutputToWaveFile(filePath);
                    synthesizer.Speak(text);
                    synthesizer.SetOutputToDefaultAudioDevice();
                }
            }
        }
    }
}
