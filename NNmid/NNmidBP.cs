using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NNmidBP.NN_BP;
using System.IO;
using System.Threading;
using DisplayBtnArray;
namespace NNmidBP
{
    public partial class NNmidBP_page : Form
    {
        public static bool Executing = false;
        Thread t_learn;
        BP bp;
        BP_FileHandler bp_fileHandle;
        public NNmidBP_page()
        {
            InitializeComponent();
            
            ///Goto_ArchitectureSettingMode();
            InitBP();

            //while(button_LoadBP.Focused != true)
            {
                button_LoadBP.Focus();
            }
        }
        public void InitBP()
        {
            bp = new BP();
            SetBp_NNCtrl();
            bp_fileHandle = new BP_FileHandler(ref bp);
        }
        /*
        public void Goto_ArchitectureSettingMode()
        {
            groupBox_Ctrl.Enabled = true;
            groupBox_training.Enabled = false;
            groupBox_display.Enabled = false;
        }
        public void Goto_TrainingMode()
        {
            groupBox_Ctrl.Enabled = false;
            groupBox_training.Enabled = true;
            groupBox_display.Enabled = false;
        }
        public void Goto_DisplayMode()
        {
            groupBox_Ctrl.Enabled = false;
            groupBox_training.Enabled = false;
            groupBox_display.Enabled = true;
        }*/
        /// <summary>從資料更新UI</summary>
        private void Refresh_UI_byBP()
        {
            //NN Ctrl GroupBox
            textBox_numPatterns.Text  = bp.number_of_input_patterns.ToString();
            textBox_numInput.Text     = bp.input_array_size.ToString();
            textBox_numHDlayers.Text  = bp.hidden_array_size.ToString();
            textBox_numOutput.Text    = bp.output_array_size.ToString();
            textBox_LearningRate.Text = bp.learning_rate.ToString("F3");
            textBox_MaxErrorTor.Text    = bp.max_error_tollerance.ToString("F3");
            textBox_NNArchitecture.Text = String.Format("{0} → {1} → {2}", bp.input_array_size, bp.hidden_array_size, bp.output_array_size);
            label_Cnt.Text = bp.TrainingCnt.ToString();
            richTextBox_Log.Text = bp.TrainingLog;
            richTextBox_Input.Clear();
            for (int i = 0; i < bp.number_of_input_patterns; i++)                
            {
                for (int j = 0; j < bp.input_array_size; j++)
                    richTextBox_Input.Text+=(bp.input[i][j] +" ");
                richTextBox_Input.Text+="\n";
            }
            richTextBox_Target.Clear();
            for (int i = 0; i < bp.number_of_input_patterns; i++)
            {
                for (int j = 0; j < bp.output_array_size; j++)
                    richTextBox_Target.Text += (bp.target[i][j] + " ");
                richTextBox_Target.Text += "\n";
            }

            richTextBox_disOutputLog.Clear();
        }
        /// <summary>Leave時檢查不合法數值</summary>
        private void textBox_num_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                if (Convert.ToInt32(tb.Text) <= 0)
                    tb.Text = "1";
                if (Convert.ToInt32(tb.Text) >= BP.Max_Size)
                    tb.Text = BP.Max_Size.ToString();

                if(tb == textBox_numHDlayers)
                {
                    int inputSize  = Convert.ToInt32(textBox_numInput.Text);
                    int HiddenSize = Convert.ToInt32(textBox_numHDlayers.Text);
                    int OutputSize = Convert.ToInt32(textBox_numOutput.Text);
                    if (HiddenSize < (inputSize + OutputSize) / 2)
                        HiddenSize = (inputSize + OutputSize) / 2;
                    if (HiddenSize > (inputSize + OutputSize))
                        HiddenSize = inputSize + OutputSize;
                    textBox_numHDlayers.Text = HiddenSize.ToString();
                }
            }
            catch{}
        }
        /// <summary>Leave時檢查不合法數值</summary>
        private void textBox_double_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                if (Convert.ToDouble(tb.Text) <= 0.0)
                    tb.Text = "0.1";
            }
            catch{}
        }
        const int BackSpace = 8;
        private void textBox_onlyPositiveNumBlank_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < '0' | (int)e.KeyChar > '9') & (int)e.KeyChar != BackSpace & (int)e.KeyChar != ' ')
                e.Handled = true;
        }
        /// <summary>KeyPress限制輸入非負整數</summary>
        private void textBox_onlyPositiveNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < '0' | (int)e.KeyChar > '9') & (int)e.KeyChar != BackSpace)
                e.Handled = true;
        }
        /// <summary>KeyPress限制輸入非負浮點數</summary>
        private void textBox_Only_PositiveDoubleInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < '0' | (int)e.KeyChar > '9') & (int)e.KeyChar != BackSpace & (int)e.KeyChar != '.')
                e.Handled = true;
        }
        /// <summary>從NNCtrl初始化BP</summary>
        public void SetBp_NNCtrl()
        {
            //LoadUI Value
            int patterns       = Convert.ToInt32(textBox_numPatterns.Text);
            int inputSize      = Convert.ToInt32(textBox_numInput.Text);
            int OutputSize = Convert.ToInt32(textBox_numOutput.Text);

            int HiddenSize     = Convert.ToInt32(textBox_numHDlayers.Text);
            if (HiddenSize < (inputSize + OutputSize) / 2)
                HiddenSize = (inputSize + OutputSize) / 2;
            if (HiddenSize > (inputSize + OutputSize))
                HiddenSize = inputSize + OutputSize;
            textBox_numHDlayers.Text = HiddenSize.ToString();

            
            double L_Rate      = Convert.ToDouble(textBox_LearningRate.Text);
            double MaxErrorTor = Convert.ToDouble(textBox_MaxErrorTor.Text);

            bp.Initialize(inputSize, OutputSize, HiddenSize, L_Rate, patterns, MaxErrorTor);
            textBox_NNArchitecture.Text = String.Format("{0} → {1} → {2}", bp.input_array_size, bp.hidden_array_size, bp.output_array_size);
        }
        private void button_ArchitectureConfirm_Click(object sender, EventArgs e)
        {
            bp.Inputed = false;
            SetBp_NNCtrl();
        }

        private void button_LoadBP_Click(object sender, EventArgs e)
        {
            BP load_bp = bp_fileHandle.LoadBy_OpenFIleDialog();
            if (load_bp == null)
                MessageBox.Show("讀取失敗，檔案格式不符或被使用者取消");
            else
                bp = load_bp;

            Refresh_UI_byBP();

            
        }

        private void butto_SaveBP_Click(object sender, EventArgs e)
        {
            SetBp_NNCtrl();
            bp_fileHandle.SaveBy_OpenFIleDialog();
        }

        private void button_FinishTraining_Click(object sender, EventArgs e)
        {
            if (Executing)
            {
                MessageBox.Show("正在執行學習");
                return;
            }
            label_Cnt.Text = "1";
            richTextBox_Log.Text = "";
            if (!bp.Inputed)
            {
                MessageBox.Show("尚未輸入測資");
                return;
            }
                
            bp.Rand_Init();
            t_learn = new Thread(do_learn);
            t_learn.Start();
        }
        public void do_learn()
        {
            Executing = true;
            string log = bp.leran10000(label_Cnt);
            
            richTextBox_Log.Parent.Invoke((MethodInvoker)delegate
                {
                    richTextBox_Log.Text = log.ToString();
                    richTextBox_Log.SelectionStart = richTextBox_Log.TextLength;
                    richTextBox_Log.ScrollToCaret();
                });
            Executing = false;
        }
        
        private void button_ConfirmIO_Click(object sender, EventArgs e)
        {
            if (!bp.Input_Para(richTextBox_Input, richTextBox_Target))            
                MessageBox.Show("格式錯誤");            
        }

        private void button_SetInput_Click(object sender, EventArgs e)
        {
            DisplayBtnArray_page form = new DisplayBtnArray_page(bp.input_array_size,bp.number_of_input_patterns,richTextBox_Input.Text);
            form.ShowDialog();
            richTextBox_Input.Text = form.ret_Str;
        }

        private void button_SetTarget_Click(object sender, EventArgs e)
        {
            DisplayBtnArray_page form = new DisplayBtnArray_page(bp.output_array_size, bp.number_of_input_patterns,richTextBox_Target.Text);
            form.ShowDialog();
            richTextBox_Target.Text = form.ret_Str;
        }

        private void button_TestConfirm_Click(object sender, EventArgs e)
        {
            //richTextBox_disOutputLog.Clear();
            string str =  bp.test_2(textBox_TestInput);
            if(str =="")            
                MessageBox.Show("輸入格式錯誤");
            try
            {
                string IN = textBox_TestInput.Text;
                IN = new string(IN.ToCharArray(0, IN.Length - 2));
                string OUT = str;
                OUT = new string(OUT.ToCharArray(1, OUT.Length - 1));
                richTextBox_disOutputLog.Text += "(" + IN + ") is:\n" + OUT;
                richTextBox_disOutputLog.SelectionStart = richTextBox_disOutputLog.TextLength;
                richTextBox_disOutputLog.ScrollToCaret();
            }
            catch
            {

            }
        }
        public void StopThread()
        {
            if (Executing)
                t_learn.Abort();
            Executing = false;
        }

        private void button_ThreadStop_Click(object sender, EventArgs e)
        {
            StopThread();
        }

        private void button_SetTest_Click(object sender, EventArgs e)
        {
            DisplayBtnArray_page form = new DisplayBtnArray_page(bp.input_array_size,1);
            form.ShowDialog();
            textBox_TestInput.Text = form.ret_Str;
        }

        private void NNmidBP_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopThread();
        }

    }
}
