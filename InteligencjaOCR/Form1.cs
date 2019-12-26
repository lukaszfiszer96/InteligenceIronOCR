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
using IronOcr;
using System.Diagnostics;

namespace InteligencjaOCR
{
    public partial class Form1 : Form
    {

        string filePath = string.Empty;
        OcrResult autoOcrResult;
        OcrResult advancedOcrResult;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_readFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            btn_readFile.Visible = false;
            lb_wait.Visible = true;
            UseAutoOCR();
            UseAdvancedOCR();
            lb_wait.Visible = false;
            btn_generateRaport.Visible = true;
        }
        private void UseAutoOCR()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            AutoOcr OCR = new AutoOcr();
            autoOcrResult = OCR.Read(filePath);
            sw.Stop();
            lb_timeAutoOCR.Text = "Czas wykonania:" + sw.ElapsedMilliseconds.ToString()+" ms";
            richTextBox1.Text = autoOcrResult.Text;
        }   
       
        private void UseAdvancedOCR()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            AdvancedOcr advancedOcr = new AdvancedOcr()
            {
                CleanBackgroundNoise = true,
                ColorDepth = 5,
                ColorSpace = AdvancedOcr.OcrColorSpace.Color,
                DetectWhiteTextOnDarkBackgrounds = false,
                EnhanceContrast = true,
                EnhanceResolution = true,
                InputImageType = AdvancedOcr.InputTypes.Document,
                ReadBarCodes = false,
                RotateAndStraighten = true,
                Strategy = AdvancedOcr.OcrStrategy.Advanced
            };

            advancedOcrResult = advancedOcr.Read(filePath);
            sw.Stop();
            lb_timeAdvancedOCR.Text = "Czas wykonania:"+sw.ElapsedMilliseconds.ToString()+" ms";
            richTextBox2.Text = advancedOcrResult.Text;          
        }

        private void btn_generateRaport_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(autoOcrResult, advancedOcrResult);
            form2.ShowDialog();
        }

        private void btn_closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
