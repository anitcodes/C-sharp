using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;

namespace TextToSpeech
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSpech_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Please enter text");
            }
            else
            {
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

                speechSynthesizer.Rate = SpeedtrackBar.Value;//speed trackbar
                speechSynthesizer.Volume = VolumetrackBar.Value;//speech volume

                //for male and female speech
                if(voicecomboBox.Text == "Male")
                {
                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Male);
                }
                else
                {
                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                }

                    speechSynthesizer.Speak(richTextBox1.Text);
                richTextBox1.Focus();
            }
        }

        private void VolumetrackBar_Scroll(object sender, EventArgs e)
        {

        }
    }
}
