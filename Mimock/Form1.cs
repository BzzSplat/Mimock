using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Media;
using System.Threading;
using System.IO;
using NAudio.Wave;

namespace Mimock
{
    public partial class Mimock : Form
    {
        public SpeechRecognitionEngine recognizer = null;
        string path;
        private int wordSpace, outputDevice;
        Random rand = new Random();

        public Mimock()
        {
            InitializeComponent();

            //populate output device dropdown
            for(int i = 0; i < WaveIn.DeviceCount; i++)
            {
                WaveOutCapabilities deviceInfo = WaveOut.GetCapabilities(i);
                outputDeviceBox.Items.Add(deviceInfo.ProductName);
            }

            formLog.ScrollBars = ScrollBars.Vertical;
            formLog.Text += "This is the log, and this is a test message!\r\nTo clear this log just select and delete the text.";
        }

        private void SetSpeakerPath(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                path = folderBrowserDialog1.SelectedPath;
            speakerPathInput.Text = path;
        }

        //set up speech recognizer
        private void LoadSpeechRecognition(object sender, EventArgs e)
        {
            string cultInfo = languageTagInput.Text;

            Console.WriteLine("Loading speech engine with culture: " + cultInfo + "\n");

            // Create an in-process speech recognizer for the en-US locale.
            recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo(cultInfo));
            // Create and load a dictation grammar.  
            recognizer.LoadGrammar(new DictationGrammar());
            // Add a handler for the speech recognized event.
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Recognizer_SpeechRecognized);
            // Configure input to the speech recognizer.
            recognizer.SetInputToDefaultAudioDevice();
            // Start asynchronous, continuous speech recognition.  
            recognizer.RecognizeAsync(RecognizeMode.Multiple);

            formLog.Text += "\r\nLoaded speech recognizer with tag: " + cultInfo;
        }

        //when recognizing a sentence say it
        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string result = e.Result.Text;
            Console.WriteLine("Recognized: " + result);
            formLog.Text += "\r\nRecognized: " + result;

            manualInput.Text = result;
            Speak();
        }

        private void Speak()
        {
            if (path == "")
                return;

            //log recorded words
            formLog.Text += $"\r\nSpeaking: \"{manualInput.Text}\"";

            //seperate sentence from the input into words
            string[] words = manualInput.Text.Split(' ');

            //replace words that sound similar to others to reduce folder size, add exceptions text file per voice pack
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = WordReplacement(words[i]);

                //if file or folder does not exist replace with error sound
                if(Directory.Exists(path + @"\" + words[i]))
                {
                    //search for a folder named after the word, and then pick a random file within. Files named as numbers for less coding.
                    Console.WriteLine(path + @"\" + words[i]);
                    Console.WriteLine(words[i] + @"\" + "1" + ".wav");

                    int fileCount = Directory.GetFiles(path + @"\" + words[i]).Length;
                    words[i] = words[i] + @"\" + rand.Next(1, fileCount+1) + ".wav";
                }
                else if (File.Exists(path + @"\" + words[i] + ".wav"))
                {
                    words[i] += ".wav";
                }
                else
                {
                    formLog.Text += "\r\nMissing word: \"" + words[i] + "\"";
                    words[i] = "_error.wav";
                }
            }



            WaveFileReader wav = null;
            var output = new WaveOutEvent { DeviceNumber = outputDevice };

            foreach (string w in words)
            {
                Console.WriteLine(w + " ");
                try
                {
                    if (w != "")
                    {
                        wav = new WaveFileReader(path + @"\" + w.ToLower());
                        output.Init(wav);
                        output.Play();

                        //wait in increments until file is no longer playing, couldn't find a better way and I don't know threading stuffs
                        while (output.PlaybackState == PlaybackState.Playing)
                        {
                            Thread.Sleep(10);
                        }

                        wav.Dispose();
                        output.Dispose();
                    }
                    Thread.Sleep(wordSpace);
                }
                catch (Exception error) 
                {
                    Console.WriteLine(error.Message);
                    formLog.Text += "\r\n" + error.Message;
                }
            }
        }

        private string WordReplacement(string word)
        {
            //I've tried to make it look nicer, but it didn't function
            if (word == "1")
                return "one";
            else if (word == "2")
                return "two";
            else if (word == "3")
                return "three";
            else if (word == "4")
                return "four";
            else if (word == "5")
                return "five";
            else if (word == "6")
                return "six";
            else if (word == "7")
                return "seven";
            else if (word == "8")
                return "eight";
            else if (word == "9")
                return "nine";
            else if (word == "10")
                return "ten";
            else if (word == "11")
                return "eleven";
            else if (word == "12")
                return "twelve";
            else if (word == "13")
                return "thirteen";
            else if (word == "14")
                return "fourteen";
            else if (word == "15")
                return "fifteen";
            else if (word == "16")
                return "sixteen";
            else if (word == "17")
                return "seventeen";
            else if (word == "18")
                return "eighteen";
            else if (word == "19")
                return "ninteen";
            else if (word == "20")
                return "twenty";
            else if (word == "know")
                return "no";
            else if (word == "to")
                return "two";
            else if (word == "ate")
                return "eight";
            else if (word == "for")
                return "four";
            else if (word == "knows")
                return "nose";
            else if (word == "rap")
                return "wrap";
            else if (word == "bee")
                return "be";
            else if (word == "colour")
                return "color";
            else if (word == "witch")
                return "which";
            else if (word == "weigh")
                return "way";
            else if (word == "cum")
                return "come";
            else if (word == "wood")
                return "would";
            else if (word == "mail")
                return "male";
            else if (word == "mails")
                return "males";
            else if (word == "hear")
                return "here";
            else if (word == "be")
                return "b";
            else if (word == "halve")
                return "have";
            else if (word == "their")
                return "there";
            else if (word == "butt")
                return "but";
            else if (word == "r")
                return "are";
            else if (word == "you're")
                return "your";
            else if (word == "weighted")
                return "waited";
            else if (word == "daddy's")
                return "daddies";
            else if (word == "width")
                return "with";
            else if (word == "clothes")
                return "close";
            else if (word == "then")
                return "than";
            else if (word == "too")
                return "two";
            else if (word == "bee")
                return "b";
            else if (word == "plain")
                return "plane";
            else if (word == "whole")
                return "hole";
            else if (word == "wether")
                return "weather";
            else if (word == "meat")
                return "meet";
            else if (word == "okay")
                return "ok";
            else if (word == "reign")
                return "rain";
            else if (word == "high")
                return "hi";
            else if (word == "son")
                return "sun";
            else if (word == "c")
                return "see";
            else if (word == "u")
                return "you";
            else if (word == "sea")
                return "see";
            else if (word == "effect")
                return "affect";
            else if (word == "el")
                return "l";
            else if (word == "ail")
                return "ale";
            else if (word == "our")
                return "hour";
            else if (word == "ours")
                return "hours";
            else if (word == "bred")
                return "bread";
            else if (word == "bye")
                return "by";

            return word;
        }

        private void outputDeviceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputDevice = outputDeviceBox.SelectedIndex;
        }

        private void speakButton_Click(object sender, EventArgs e)
        {
            Speak();
        }

        private void speakerPathInput_TextChanged(object sender, EventArgs e)
        {
            path = speakerPathInput.Text;
            Console.WriteLine("Path: " + path);
        }

        private void wordSpaceInput_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(wordSpaceInput.Text, out int num))
                wordSpace = int.Parse(wordSpaceInput.Text);
            else
                formLog.Text += "\r\nThat's not a whole number.";
        }
    }
}
