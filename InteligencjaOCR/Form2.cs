using IronOcr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteligencjaOCR
{
    public partial class Form2 : Form

    {
        private string txtfilePath = string.Empty;
        private StreamReader streamReader;
        private OcrResult autoOCR_result;
        private OcrResult advancedOCR_result;

        public Form2(OcrResult autoOCR, OcrResult advancedOCR)
        {
            autoOCR_result = autoOCR;
            advancedOCR_result = advancedOCR;

            InitializeComponent();       
            SetTxtFile();
            GenerateRaport();

        }
        private void SetTxtFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Txt Files|*.txt;";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtfilePath = openFileDialog.FileName;
                }
            }
        }
        private StreamReader SetStreamReader()
        {
            try
            {
                return streamReader = new StreamReader(txtfilePath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void GenerateRaport()
        {
            SetCharCount();
            SetWordsCount();
            SetPercent();
        }
        private void SetCharCount()
        {
            lb_charCountAutoOCR.Text = GetCharCount(autoOCR_result).ToString();
            lb_charCountAdvancedOCR.Text = GetCharCount(advancedOCR_result).ToString();
            lb_charCountTxt.Text = GetCharCountTxt().ToString();
        }

        private int GetCharCount(OcrResult ocrResult)
        {
            return ocrResult.Text.Length;
        }
        private int GetCharCountTxt()
        {
            return SetStreamReader().ReadToEnd().Length;
        }

        private void SetWordsCount()
        {
            lb_wordsCountAutoOCR.Text = GetWordsCount(autoOCR_result).ToString();
            lb_wordsCountAdvancedOCR.Text = GetWordsCount(advancedOCR_result).ToString();
            lb_wordsCountTxtFile.Text = GetWordsCountTxt().ToString();
        }

        private int GetWordsCount(OcrResult ocrResult)
        {
            return ocrResult.Pages[0].WordCount;
        }
        private int GetWordsCountTxt()
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            return SetStreamReader().ReadToEnd().Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Length;
        }

        private void SetPercent()
        {
            lb_percentAutoOCR.Text = GetPercent(autoOCR_result).ToString()+"%";
            lb_percentAdvancedOCR.Text = GetPercent(advancedOCR_result).ToString()+"%";
        }
        private int GetPercent(OcrResult ocrResult)
        {
            int wordsPercent = (GetWordsCount(ocrResult) * 100) / GetWordsCountTxt();
            int charPercent = (GetCharCount(ocrResult) * 100) / GetCharCountTxt();
            int wynik;
            if (wordsPercent > 100 || charPercent > 100)
            {
                wynik = ((wordsPercent+charPercent)/2)-100;
                return (100 - wynik)>=0? 100-wynik:0;
            }
            else
                return (wordsPercent + charPercent) / 2;


        }
    }
    
}   
