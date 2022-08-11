﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace Text_To_Speak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer reader = new SpeechSynthesizer();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Speak_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text!=""){
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(richTextBox1.Text);
        }
            else{
                MessageBox.Show("Please enter some Text First!");
            }

    }

        private void Pause_Click(object sender, EventArgs e)
        {
            if(reader!=null)
            {
                if(reader.State==SynthesizerState.Speaking)
                {
                reader.Pause();
                }
            }
        }

        private void Resume_Click(object sender, EventArgs e)
        {
         if(reader!=null){
                if(reader.State==SynthesizerState.Paused){
                reader.Resume();
                }
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.Dispose();
            }
        }

        
     }
}
