namespace DisplayBtnArray
{
    partial class DisplayBtnArray_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayBtnArray_page));
            this.textBox_Xamount = new System.Windows.Forms.TextBox();
            this.textBox_Yamount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Xamount
            // 
            this.textBox_Xamount.Location = new System.Drawing.Point(43, 17);
            this.textBox_Xamount.Name = "textBox_Xamount";
            this.textBox_Xamount.Size = new System.Drawing.Size(100, 22);
            this.textBox_Xamount.TabIndex = 0;
            this.textBox_Xamount.Text = "4";
            this.textBox_Xamount.Visible = false;
            // 
            // textBox_Yamount
            // 
            this.textBox_Yamount.Location = new System.Drawing.Point(43, 54);
            this.textBox_Yamount.Name = "textBox_Yamount";
            this.textBox_Yamount.Size = new System.Drawing.Size(100, 22);
            this.textBox_Yamount.TabIndex = 1;
            this.textBox_Yamount.Text = "4";
            this.textBox_Yamount.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "X :";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y :";
            this.label2.Visible = false;
            // 
            // button_refresh
            // 
            this.button_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_refresh.BackgroundImage")));
            this.button_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_refresh.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_refresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_refresh.Location = new System.Drawing.Point(496, 17);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(130, 40);
            this.button_refresh.TabIndex = 56;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Visible = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 59);
            this.button1.TabIndex = 57;
            this.button1.Text = "display\r\nbinary\r\narray";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(496, 150);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 270);
            this.richTextBox1.TabIndex = 58;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // button_Confirm
            // 
            this.button_Confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Confirm.BackgroundImage")));
            this.button_Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Confirm.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_Confirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Confirm.Location = new System.Drawing.Point(573, 17);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(130, 40);
            this.button_Confirm.TabIndex = 59;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // DisplayBtnArray_page
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(715, 517);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Yamount);
            this.Controls.Add(this.textBox_Xamount);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayBtnArray_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Button Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Xamount;
        private System.Windows.Forms.TextBox textBox_Yamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_Confirm;
    }
}

