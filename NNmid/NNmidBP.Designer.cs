namespace NNmidBP
{
    partial class NNmidBP_page
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NNmidBP_page));
            this.label_title = new System.Windows.Forms.Label();
            this.groupBox_display = new System.Windows.Forms.GroupBox();
            this.button_SetTest = new System.Windows.Forms.Button();
            this.textBox_TestInput = new System.Windows.Forms.TextBox();
            this.label_disOutLog = new System.Windows.Forms.Label();
            this.richTextBox_disOutputLog = new System.Windows.Forms.RichTextBox();
            this.button_disInConfirm = new System.Windows.Forms.Button();
            this.groupBox_Ctrl = new System.Windows.Forms.GroupBox();
            this.textBox_MaxErrorTor = new System.Windows.Forms.TextBox();
            this.button_SaveBP = new System.Windows.Forms.Button();
            this.button_LoadBP = new System.Windows.Forms.Button();
            this.textBox_LearningRate = new System.Windows.Forms.TextBox();
            this.textBox_NNArchitecture = new System.Windows.Forms.TextBox();
            this.label_numLR = new System.Windows.Forms.Label();
            this.label_numT = new System.Windows.Forms.Label();
            this.textBox_numOutput = new System.Windows.Forms.TextBox();
            this.label_numOut = new System.Windows.Forms.Label();
            this.textBox_numHDlayers = new System.Windows.Forms.TextBox();
            this.label_numHD = new System.Windows.Forms.Label();
            this.button_ArchitectureConfirm = new System.Windows.Forms.Button();
            this.label_NetArc = new System.Windows.Forms.Label();
            this.label_numIn = new System.Windows.Forms.Label();
            this.textBox_numInput = new System.Windows.Forms.TextBox();
            this.label_numPat = new System.Windows.Forms.Label();
            this.textBox_numPatterns = new System.Windows.Forms.TextBox();
            this.label_tIhint = new System.Windows.Forms.Label();
            this.richTextBox_Input = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Target = new System.Windows.Forms.RichTextBox();
            this.button_FinishTraining = new System.Windows.Forms.Button();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.label_trOutLog = new System.Windows.Forms.Label();
            this.button_ConfirmIO = new System.Windows.Forms.Button();
            this.groupBox_training = new System.Windows.Forms.GroupBox();
            this.button_ThreadStop = new System.Windows.Forms.Button();
            this.button_SetInput = new System.Windows.Forms.Button();
            this.button_SetTarget = new System.Windows.Forms.Button();
            this.label_Cnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_display.SuspendLayout();
            this.groupBox_Ctrl.SuspendLayout();
            this.groupBox_training.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(20, 17);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(316, 39);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Error Back-Propagation";
            // 
            // groupBox_display
            // 
            this.groupBox_display.Controls.Add(this.button_SetTest);
            this.groupBox_display.Controls.Add(this.textBox_TestInput);
            this.groupBox_display.Controls.Add(this.label_disOutLog);
            this.groupBox_display.Controls.Add(this.richTextBox_disOutputLog);
            this.groupBox_display.Controls.Add(this.button_disInConfirm);
            this.groupBox_display.Location = new System.Drawing.Point(601, 61);
            this.groupBox_display.Name = "groupBox_display";
            this.groupBox_display.Size = new System.Drawing.Size(371, 490);
            this.groupBox_display.TabIndex = 10;
            this.groupBox_display.TabStop = false;
            this.groupBox_display.Text = "3. Display";
            // 
            // button_SetTest
            // 
            this.button_SetTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SetTest.BackgroundImage")));
            this.button_SetTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SetTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_SetTest.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_SetTest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_SetTest.Location = new System.Drawing.Point(123, 21);
            this.button_SetTest.Name = "button_SetTest";
            this.button_SetTest.Size = new System.Drawing.Size(61, 27);
            this.button_SetTest.TabIndex = 198;
            this.button_SetTest.Text = "Input";
            this.button_SetTest.UseVisualStyleBackColor = true;
            this.button_SetTest.Click += new System.EventHandler(this.button_SetTest_Click);
            // 
            // textBox_TestInput
            // 
            this.textBox_TestInput.Location = new System.Drawing.Point(11, 21);
            this.textBox_TestInput.Name = "textBox_TestInput";
            this.textBox_TestInput.Size = new System.Drawing.Size(104, 27);
            this.textBox_TestInput.TabIndex = 194;
            this.textBox_TestInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_onlyPositiveNumBlank_KeyPress);
            // 
            // label_disOutLog
            // 
            this.label_disOutLog.AutoSize = true;
            this.label_disOutLog.Location = new System.Drawing.Point(8, 55);
            this.label_disOutLog.Name = "label_disOutLog";
            this.label_disOutLog.Size = new System.Drawing.Size(102, 19);
            this.label_disOutLog.TabIndex = 193;
            this.label_disOutLog.Text = "Ouput text log";
            // 
            // richTextBox_disOutputLog
            // 
            this.richTextBox_disOutputLog.Enabled = false;
            this.richTextBox_disOutputLog.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_disOutputLog.Location = new System.Drawing.Point(10, 75);
            this.richTextBox_disOutputLog.Name = "richTextBox_disOutputLog";
            this.richTextBox_disOutputLog.ReadOnly = true;
            this.richTextBox_disOutputLog.Size = new System.Drawing.Size(350, 405);
            this.richTextBox_disOutputLog.TabIndex = 191;
            this.richTextBox_disOutputLog.Text = "";
            // 
            // button_disInConfirm
            // 
            this.button_disInConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_disInConfirm.BackgroundImage")));
            this.button_disInConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_disInConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_disInConfirm.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_disInConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_disInConfirm.Location = new System.Drawing.Point(192, 21);
            this.button_disInConfirm.Name = "button_disInConfirm";
            this.button_disInConfirm.Size = new System.Drawing.Size(168, 27);
            this.button_disInConfirm.TabIndex = 186;
            this.button_disInConfirm.Text = "Confirm an Input";
            this.button_disInConfirm.UseVisualStyleBackColor = true;
            this.button_disInConfirm.Click += new System.EventHandler(this.button_TestConfirm_Click);
            // 
            // groupBox_Ctrl
            // 
            this.groupBox_Ctrl.Controls.Add(this.textBox_MaxErrorTor);
            this.groupBox_Ctrl.Controls.Add(this.button_SaveBP);
            this.groupBox_Ctrl.Controls.Add(this.button_LoadBP);
            this.groupBox_Ctrl.Controls.Add(this.textBox_LearningRate);
            this.groupBox_Ctrl.Controls.Add(this.textBox_NNArchitecture);
            this.groupBox_Ctrl.Controls.Add(this.label_numLR);
            this.groupBox_Ctrl.Controls.Add(this.label_numT);
            this.groupBox_Ctrl.Controls.Add(this.textBox_numOutput);
            this.groupBox_Ctrl.Controls.Add(this.label_numOut);
            this.groupBox_Ctrl.Controls.Add(this.textBox_numHDlayers);
            this.groupBox_Ctrl.Controls.Add(this.label_numHD);
            this.groupBox_Ctrl.Controls.Add(this.button_ArchitectureConfirm);
            this.groupBox_Ctrl.Controls.Add(this.label_NetArc);
            this.groupBox_Ctrl.Controls.Add(this.label_numIn);
            this.groupBox_Ctrl.Controls.Add(this.textBox_numInput);
            this.groupBox_Ctrl.Controls.Add(this.label_numPat);
            this.groupBox_Ctrl.Controls.Add(this.textBox_numPatterns);
            this.groupBox_Ctrl.Location = new System.Drawing.Point(14, 61);
            this.groupBox_Ctrl.Name = "groupBox_Ctrl";
            this.groupBox_Ctrl.Size = new System.Drawing.Size(190, 490);
            this.groupBox_Ctrl.TabIndex = 11;
            this.groupBox_Ctrl.TabStop = false;
            this.groupBox_Ctrl.Text = "1. NNA Init.";
            // 
            // textBox_MaxErrorTor
            // 
            this.textBox_MaxErrorTor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaxErrorTor.Location = new System.Drawing.Point(12, 305);
            this.textBox_MaxErrorTor.Name = "textBox_MaxErrorTor";
            this.textBox_MaxErrorTor.Size = new System.Drawing.Size(167, 24);
            this.textBox_MaxErrorTor.TabIndex = 200;
            this.textBox_MaxErrorTor.Text = "0.1";
            // 
            // button_SaveBP
            // 
            this.button_SaveBP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SaveBP.BackgroundImage")));
            this.button_SaveBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SaveBP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_SaveBP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.button_SaveBP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_SaveBP.Location = new System.Drawing.Point(12, 386);
            this.button_SaveBP.Name = "button_SaveBP";
            this.button_SaveBP.Size = new System.Drawing.Size(167, 30);
            this.button_SaveBP.TabIndex = 199;
            this.button_SaveBP.Text = "Save BPFile";
            this.button_SaveBP.UseVisualStyleBackColor = true;
            this.button_SaveBP.Click += new System.EventHandler(this.butto_SaveBP_Click);
            // 
            // button_LoadBP
            // 
            this.button_LoadBP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_LoadBP.BackgroundImage")));
            this.button_LoadBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_LoadBP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_LoadBP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.button_LoadBP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_LoadBP.Location = new System.Drawing.Point(12, 418);
            this.button_LoadBP.Name = "button_LoadBP";
            this.button_LoadBP.Size = new System.Drawing.Size(167, 30);
            this.button_LoadBP.TabIndex = 1;
            this.button_LoadBP.Text = "Load BPFile";
            this.button_LoadBP.UseVisualStyleBackColor = true;
            this.button_LoadBP.Click += new System.EventHandler(this.button_LoadBP_Click);
            // 
            // textBox_LearningRate
            // 
            this.textBox_LearningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LearningRate.Location = new System.Drawing.Point(12, 259);
            this.textBox_LearningRate.Name = "textBox_LearningRate";
            this.textBox_LearningRate.Size = new System.Drawing.Size(167, 24);
            this.textBox_LearningRate.TabIndex = 197;
            this.textBox_LearningRate.Text = "0.9";
            this.textBox_LearningRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Only_PositiveDoubleInput_KeyPress);
            this.textBox_LearningRate.Leave += new System.EventHandler(this.textBox_double_Leave);
            // 
            // textBox_NNArchitecture
            // 
            this.textBox_NNArchitecture.Enabled = false;
            this.textBox_NNArchitecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NNArchitecture.Location = new System.Drawing.Point(12, 356);
            this.textBox_NNArchitecture.Name = "textBox_NNArchitecture";
            this.textBox_NNArchitecture.ReadOnly = true;
            this.textBox_NNArchitecture.Size = new System.Drawing.Size(167, 24);
            this.textBox_NNArchitecture.TabIndex = 195;
            this.textBox_NNArchitecture.Text = "5 → 3 → 3";
            // 
            // label_numLR
            // 
            this.label_numLR.AutoSize = true;
            this.label_numLR.Location = new System.Drawing.Point(5, 238);
            this.label_numLR.Name = "label_numLR";
            this.label_numLR.Size = new System.Drawing.Size(137, 19);
            this.label_numLR.TabIndex = 196;
            this.label_numLR.Text = "Learning Rate (0, 1]";
            // 
            // label_numT
            // 
            this.label_numT.AutoSize = true;
            this.label_numT.Location = new System.Drawing.Point(5, 286);
            this.label_numT.Name = "label_numT";
            this.label_numT.Size = new System.Drawing.Size(143, 19);
            this.label_numT.TabIndex = 193;
            this.label_numT.Text = "Max Error Tollerance";
            // 
            // textBox_numOutput
            // 
            this.textBox_numOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_numOutput.Location = new System.Drawing.Point(12, 211);
            this.textBox_numOutput.Name = "textBox_numOutput";
            this.textBox_numOutput.Size = new System.Drawing.Size(167, 24);
            this.textBox_numOutput.TabIndex = 192;
            this.textBox_numOutput.Text = "3";
            this.textBox_numOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_onlyPositiveNum_KeyPress);
            this.textBox_numOutput.Leave += new System.EventHandler(this.textBox_num_Leave);
            // 
            // label_numOut
            // 
            this.label_numOut.AutoSize = true;
            this.label_numOut.Location = new System.Drawing.Point(5, 190);
            this.label_numOut.Name = "label_numOut";
            this.label_numOut.Size = new System.Drawing.Size(168, 19);
            this.label_numOut.TabIndex = 191;
            this.label_numOut.Text = "Number of Output ( < 5 )";
            // 
            // textBox_numHDlayers
            // 
            this.textBox_numHDlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_numHDlayers.Location = new System.Drawing.Point(12, 163);
            this.textBox_numHDlayers.Name = "textBox_numHDlayers";
            this.textBox_numHDlayers.Size = new System.Drawing.Size(167, 24);
            this.textBox_numHDlayers.TabIndex = 188;
            this.textBox_numHDlayers.Text = "3";
            this.textBox_numHDlayers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_onlyPositiveNum_KeyPress);
            this.textBox_numHDlayers.Leave += new System.EventHandler(this.textBox_num_Leave);
            // 
            // label_numHD
            // 
            this.label_numHD.AutoSize = true;
            this.label_numHD.Location = new System.Drawing.Point(5, 123);
            this.label_numHD.Name = "label_numHD";
            this.label_numHD.Size = new System.Drawing.Size(177, 38);
            this.label_numHD.TabIndex = 187;
            this.label_numHD.Text = "Number of HDlayer\r\n[(I+O)/2] <= [HD] <= [I+O]";
            // 
            // button_ArchitectureConfirm
            // 
            this.button_ArchitectureConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ArchitectureConfirm.BackgroundImage")));
            this.button_ArchitectureConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ArchitectureConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ArchitectureConfirm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.button_ArchitectureConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_ArchitectureConfirm.Location = new System.Drawing.Point(12, 450);
            this.button_ArchitectureConfirm.Name = "button_ArchitectureConfirm";
            this.button_ArchitectureConfirm.Size = new System.Drawing.Size(167, 30);
            this.button_ArchitectureConfirm.TabIndex = 185;
            this.button_ArchitectureConfirm.Text = "Confirm";
            this.button_ArchitectureConfirm.UseVisualStyleBackColor = true;
            this.button_ArchitectureConfirm.Click += new System.EventHandler(this.button_ArchitectureConfirm_Click);
            // 
            // label_NetArc
            // 
            this.label_NetArc.AutoSize = true;
            this.label_NetArc.Location = new System.Drawing.Point(6, 334);
            this.label_NetArc.Name = "label_NetArc";
            this.label_NetArc.Size = new System.Drawing.Size(141, 19);
            this.label_NetArc.TabIndex = 8;
            this.label_NetArc.Text = "Network Achitecture";
            // 
            // label_numIn
            // 
            this.label_numIn.AutoSize = true;
            this.label_numIn.Location = new System.Drawing.Point(5, 73);
            this.label_numIn.Name = "label_numIn";
            this.label_numIn.Size = new System.Drawing.Size(156, 19);
            this.label_numIn.TabIndex = 6;
            this.label_numIn.Text = "Number of Input ( < 5 )";
            // 
            // textBox_numInput
            // 
            this.textBox_numInput.Location = new System.Drawing.Point(12, 94);
            this.textBox_numInput.Name = "textBox_numInput";
            this.textBox_numInput.Size = new System.Drawing.Size(167, 27);
            this.textBox_numInput.TabIndex = 5;
            this.textBox_numInput.Text = "5";
            this.textBox_numInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_onlyPositiveNum_KeyPress);
            this.textBox_numInput.Leave += new System.EventHandler(this.textBox_num_Leave);
            // 
            // label_numPat
            // 
            this.label_numPat.AutoSize = true;
            this.label_numPat.Location = new System.Drawing.Point(5, 23);
            this.label_numPat.Name = "label_numPat";
            this.label_numPat.Size = new System.Drawing.Size(181, 19);
            this.label_numPat.TabIndex = 4;
            this.label_numPat.Text = "Number of Patterns ( < 20)";
            // 
            // textBox_numPatterns
            // 
            this.textBox_numPatterns.Location = new System.Drawing.Point(12, 44);
            this.textBox_numPatterns.Name = "textBox_numPatterns";
            this.textBox_numPatterns.Size = new System.Drawing.Size(167, 27);
            this.textBox_numPatterns.TabIndex = 3;
            this.textBox_numPatterns.Text = "4";
            this.textBox_numPatterns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_onlyPositiveNum_KeyPress);
            this.textBox_numPatterns.Leave += new System.EventHandler(this.textBox_num_Leave);
            // 
            // label_tIhint
            // 
            this.label_tIhint.AutoSize = true;
            this.label_tIhint.Location = new System.Drawing.Point(6, 23);
            this.label_tIhint.Name = "label_tIhint";
            this.label_tIhint.Size = new System.Drawing.Size(291, 19);
            this.label_tIhint.TabIndex = 3;
            this.label_tIhint.Text = "(Input history)                      (Output history)";
            // 
            // richTextBox_Input
            // 
            this.richTextBox_Input.Location = new System.Drawing.Point(10, 51);
            this.richTextBox_Input.Name = "richTextBox_Input";
            this.richTextBox_Input.Size = new System.Drawing.Size(172, 171);
            this.richTextBox_Input.TabIndex = 7;
            this.richTextBox_Input.Text = "";
            // 
            // richTextBox_Target
            // 
            this.richTextBox_Target.Location = new System.Drawing.Point(188, 51);
            this.richTextBox_Target.Name = "richTextBox_Target";
            this.richTextBox_Target.Size = new System.Drawing.Size(172, 171);
            this.richTextBox_Target.TabIndex = 8;
            this.richTextBox_Target.Text = "";
            // 
            // button_FinishTraining
            // 
            this.button_FinishTraining.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_FinishTraining.BackgroundImage")));
            this.button_FinishTraining.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_FinishTraining.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_FinishTraining.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.button_FinishTraining.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_FinishTraining.Location = new System.Drawing.Point(10, 450);
            this.button_FinishTraining.Name = "button_FinishTraining";
            this.button_FinishTraining.Size = new System.Drawing.Size(168, 30);
            this.button_FinishTraining.TabIndex = 182;
            this.button_FinishTraining.Text = "Training";
            this.button_FinishTraining.UseVisualStyleBackColor = true;
            this.button_FinishTraining.Click += new System.EventHandler(this.button_FinishTraining_Click);
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Location = new System.Drawing.Point(10, 283);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.Size = new System.Drawing.Size(351, 160);
            this.richTextBox_Log.TabIndex = 189;
            this.richTextBox_Log.Text = "";
            // 
            // label_trOutLog
            // 
            this.label_trOutLog.AutoSize = true;
            this.label_trOutLog.Location = new System.Drawing.Point(6, 261);
            this.label_trOutLog.Name = "label_trOutLog";
            this.label_trOutLog.Size = new System.Drawing.Size(32, 19);
            this.label_trOutLog.TabIndex = 191;
            this.label_trOutLog.Text = "Log";
            // 
            // button_ConfirmIO
            // 
            this.button_ConfirmIO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ConfirmIO.BackgroundImage")));
            this.button_ConfirmIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ConfirmIO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ConfirmIO.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.button_ConfirmIO.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_ConfirmIO.Location = new System.Drawing.Point(10, 228);
            this.button_ConfirmIO.Name = "button_ConfirmIO";
            this.button_ConfirmIO.Size = new System.Drawing.Size(351, 30);
            this.button_ConfirmIO.TabIndex = 192;
            this.button_ConfirmIO.Text = "Confirm Input/Output";
            this.button_ConfirmIO.UseVisualStyleBackColor = true;
            this.button_ConfirmIO.Click += new System.EventHandler(this.button_ConfirmIO_Click);
            // 
            // groupBox_training
            // 
            this.groupBox_training.Controls.Add(this.button_ThreadStop);
            this.groupBox_training.Controls.Add(this.button_SetInput);
            this.groupBox_training.Controls.Add(this.button_SetTarget);
            this.groupBox_training.Controls.Add(this.label_Cnt);
            this.groupBox_training.Controls.Add(this.button_ConfirmIO);
            this.groupBox_training.Controls.Add(this.label_trOutLog);
            this.groupBox_training.Controls.Add(this.richTextBox_Log);
            this.groupBox_training.Controls.Add(this.button_FinishTraining);
            this.groupBox_training.Controls.Add(this.richTextBox_Target);
            this.groupBox_training.Controls.Add(this.richTextBox_Input);
            this.groupBox_training.Controls.Add(this.label_tIhint);
            this.groupBox_training.Location = new System.Drawing.Point(218, 61);
            this.groupBox_training.Name = "groupBox_training";
            this.groupBox_training.Size = new System.Drawing.Size(371, 490);
            this.groupBox_training.TabIndex = 9;
            this.groupBox_training.TabStop = false;
            this.groupBox_training.Text = "2. Training (Max 10000 times)";
            // 
            // button_ThreadStop
            // 
            this.button_ThreadStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ThreadStop.BackgroundImage")));
            this.button_ThreadStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ThreadStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ThreadStop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.button_ThreadStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_ThreadStop.Location = new System.Drawing.Point(272, 450);
            this.button_ThreadStop.Name = "button_ThreadStop";
            this.button_ThreadStop.Size = new System.Drawing.Size(88, 30);
            this.button_ThreadStop.TabIndex = 197;
            this.button_ThreadStop.Text = "Stop";
            this.button_ThreadStop.UseVisualStyleBackColor = true;
            this.button_ThreadStop.Click += new System.EventHandler(this.button_ThreadStop_Click);
            // 
            // button_SetInput
            // 
            this.button_SetInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SetInput.BackgroundImage")));
            this.button_SetInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SetInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_SetInput.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_SetInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_SetInput.Location = new System.Drawing.Point(122, 21);
            this.button_SetInput.Name = "button_SetInput";
            this.button_SetInput.Size = new System.Drawing.Size(60, 24);
            this.button_SetInput.TabIndex = 196;
            this.button_SetInput.Text = "Input";
            this.button_SetInput.UseVisualStyleBackColor = true;
            this.button_SetInput.Click += new System.EventHandler(this.button_SetInput_Click);
            // 
            // button_SetTarget
            // 
            this.button_SetTarget.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SetTarget.BackgroundImage")));
            this.button_SetTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SetTarget.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_SetTarget.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_SetTarget.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_SetTarget.Location = new System.Drawing.Point(300, 21);
            this.button_SetTarget.Name = "button_SetTarget";
            this.button_SetTarget.Size = new System.Drawing.Size(60, 24);
            this.button_SetTarget.TabIndex = 195;
            this.button_SetTarget.Text = "Output";
            this.button_SetTarget.UseVisualStyleBackColor = true;
            this.button_SetTarget.Click += new System.EventHandler(this.button_SetTarget_Click);
            // 
            // label_Cnt
            // 
            this.label_Cnt.AutoSize = true;
            this.label_Cnt.Location = new System.Drawing.Point(195, 456);
            this.label_Cnt.Name = "label_Cnt";
            this.label_Cnt.Size = new System.Drawing.Size(17, 19);
            this.label_Cnt.TabIndex = 193;
            this.label_Cnt.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "(using randomized initial weight; bad initial weights may cause endless learning." +
    ")";
            // 
            // NNmidBP_page
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_Ctrl);
            this.Controls.Add(this.groupBox_display);
            this.Controls.Add(this.groupBox_training);
            this.Controls.Add(this.label_title);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NNmidBP_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NNmidBP_page_FormClosing);
            this.groupBox_display.ResumeLayout(false);
            this.groupBox_display.PerformLayout();
            this.groupBox_Ctrl.ResumeLayout(false);
            this.groupBox_Ctrl.PerformLayout();
            this.groupBox_training.ResumeLayout(false);
            this.groupBox_training.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.GroupBox groupBox_display;
        private System.Windows.Forms.GroupBox groupBox_Ctrl;
        private System.Windows.Forms.Label label_numIn;
        private System.Windows.Forms.TextBox textBox_numInput;
        private System.Windows.Forms.Label label_numPat;
        private System.Windows.Forms.TextBox textBox_numPatterns;
        public System.Windows.Forms.Button button_ArchitectureConfirm;
        private System.Windows.Forms.TextBox textBox_numHDlayers;
        private System.Windows.Forms.Label label_numHD;
        private System.Windows.Forms.TextBox textBox_NNArchitecture;
        private System.Windows.Forms.Label label_numT;
        private System.Windows.Forms.TextBox textBox_numOutput;
        private System.Windows.Forms.Label label_numOut;
        private System.Windows.Forms.Label label_NetArc;
        private System.Windows.Forms.TextBox textBox_LearningRate;
        private System.Windows.Forms.Label label_numLR;
        public System.Windows.Forms.Button button_disInConfirm;
        private System.Windows.Forms.Label label_disOutLog;
        private System.Windows.Forms.RichTextBox richTextBox_disOutputLog;
        public System.Windows.Forms.Button button_LoadBP;
        public System.Windows.Forms.Button button_SaveBP;
        private System.Windows.Forms.TextBox textBox_MaxErrorTor;
        private System.Windows.Forms.Label label_tIhint;
        private System.Windows.Forms.RichTextBox richTextBox_Input;
        private System.Windows.Forms.RichTextBox richTextBox_Target;
        public System.Windows.Forms.Button button_FinishTraining;
        private System.Windows.Forms.RichTextBox richTextBox_Log;
        private System.Windows.Forms.Label label_trOutLog;
        public System.Windows.Forms.Button button_ConfirmIO;
        private System.Windows.Forms.GroupBox groupBox_training;
        private System.Windows.Forms.Label label_Cnt;
        private System.Windows.Forms.TextBox textBox_TestInput;
        public System.Windows.Forms.Button button_SetInput;
        public System.Windows.Forms.Button button_SetTarget;
        public System.Windows.Forms.Button button_ThreadStop;
        public System.Windows.Forms.Button button_SetTest;
        private System.Windows.Forms.Label label1;
    }
}

