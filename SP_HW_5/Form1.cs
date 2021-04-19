using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_HW_5
{
    public partial class Form1 : Form
    {
        string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
            "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
            "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris " +
            "nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in " +
            "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla " +
            "pariatur? Excepteur sint occaecat cupidatat non proident, sunt in " +
            "culpa qui officia deserunt mollit anim id est laborum!";
        char[] cText;
        int sentCount;
        int wordsCount;
        int symCount;
        int interroganiveCount;
        int exlamationCount;
        CancellationTokenSource tokenSource;
        public Form1()
        {
            InitializeComponent();
            tokenSource = new CancellationTokenSource();
            richTextBox1.Text = text;
            cText = text.ToCharArray();
            comboBox1.SelectedIndex = 0;
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            Task task = Task.Factory.StartNew(AnaliseText, tokenSource.Token, tokenSource.Token);
            task.Wait();
            if(comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show($"Sentences in the text : {sentCount}\nSymbols in the text : {symCount}\nWords in the text : {wordsCount}\n" +
                $"Interrogative sentences : {interroganiveCount}\nExlamation sentences {exlamationCount}");
            }
           else if(comboBox1.SelectedIndex == 1)
            {
                PrintReport();
            }
            task.Dispose();
        }
        private void AnaliseText(object c)
        {
            var cancel = (CancellationToken)c;
            cancel.ThrowIfCancellationRequested(); 
            sentCount = CountSentences();
            symCount = CountSymbols();
            wordsCount = CountWords();
            interroganiveCount = CountInterrogative();
            exlamationCount = CountExlamation();

        }
        private int CountSentences()
        {
            int sCount = 0;
            foreach(var item in cText)
            {
                if (item == '.' || item == '!' || item == '?') sCount++;
            }
            return sCount;
        }
        private int CountSymbols()
        {
            string temp = text.Replace(" ", "");
            return temp.Length;
        }
        private int CountWords()
        {
            string[] temp = text.Split(' ');
            return temp.Length;
        }
        private int CountInterrogative()
        {
            int result = 0;
            foreach(var item in cText)
            {
                if (item == '?') result++;
            }
            return result;
        }
        private int CountExlamation()
        {
            int result = 0;
            foreach (var item in cText)
            {
                if (item == '!') result++;
            }
            return result;
        }
        private void PrintReport()
        {
            using (SaveFileDialog sd = new SaveFileDialog())
            {
                sd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                try
                {
                    if (sd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sd.FileName, false, System.Text.Encoding.Default))
                        {
                            sw.WriteLine($"Sentences in the text : {sentCount}\nSymbols in the text : {symCount}\nWords in the text : {wordsCount}\n" +
                            $"Interrogative sentences : {interroganiveCount}\nExlamation sentences {exlamationCount}");
                        }
                    }
                }
                catch { MessageBox.Show("Error!"); };
            }
        }
    }
}
