using Microsoft.Win32;
using System;
using System.IO;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
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

namespace LAB_7
{
    public partial class MainWindow : Window
    {
        private SpeechSynthesizer synthesizer;
        private PromptVolume volume;
        private PromptRate rate;

        public MainWindow()
        {
            InitializeComponent();
            volume = PromptVolume.Default;
            rate = PromptRate.Medium;
            synthesizer = new SpeechSynthesizer();
            
    }

        private void LoadFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                string fileContents = File.ReadAllText(filePath);
                TextInput.Text = fileContents;
            }
        }

        private void SaveSpeechButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "WAV Files|*.wav";
            if (saveFileDialog.ShowDialog() == true)
            {
                string filePath = saveFileDialog.FileName;
                string text = TextInput.Text;
                PromptBuilder promptBuilder = new PromptBuilder();



                promptBuilder.StartStyle(new PromptStyle()
                {
                    Volume = volume,
                    Rate = rate
                });
                promptBuilder.AppendText(text);
                promptBuilder.EndStyle();
                synthesizer.SetOutputToWaveFile(filePath);
                synthesizer.Speak(promptBuilder);
                synthesizer.SetOutputToDefaultAudioDevice();
                MessageBox.Show("Речь сохранена успешно!");
            }
        }

        private void PlaySpeechButton_Click(object sender, RoutedEventArgs e)
        {
            string text = TextInput.Text;
            PromptBuilder promptBuilder = new PromptBuilder();
            

            
            promptBuilder.StartStyle(new PromptStyle()
            {
                Volume = volume,
                Rate = rate
            });
            promptBuilder.AppendText(text);
            promptBuilder.EndStyle();

            synthesizer.SpeakAsync(promptBuilder);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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

        private void setting_Button_Click(object sender, RoutedEventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Введите желаемый уровень громкости(0-100):", "Ввод громкости", "");
            int volumeValue = Convert.ToInt32(name);
            volume = (PromptVolume)volumeValue;

            string rater = Microsoft.VisualBasic.Interaction.InputBox("Введите желаемую скорость воспроизведения(1-5, 1-очень быстро, 5-очень медленно):", "Ввод громкости", "");
            int rateValue = Convert.ToInt32(rater);
            rate = (PromptRate)rateValue;
            MessageBox.Show(volume.ToString());
            MessageBox.Show(rate.ToString());
        }
    }

}
