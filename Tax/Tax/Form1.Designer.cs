
namespace Tax
{
    partial class TAX_form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.EXIT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Tip = new System.Windows.Forms.Label();
            this.label_Tips = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_dateTimePickerEnd = new System.Windows.Forms.Label();
            this.label_dateTimePickerStart = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_WholeYear = new System.Windows.Forms.RadioButton();
            this.radioButton_Duration = new System.Windows.Forms.RadioButton();
            this.panel_ResultShow = new System.Windows.Forms.Panel();
            this.label_ResultShow = new System.Windows.Forms.Label();
            this.label_CCHPMessage = new System.Windows.Forms.Label();
            this.label_DateEnd = new System.Windows.Forms.Label();
            this.label_DateStart = new System.Windows.Forms.Label();
            this.label_VehicleMessage = new System.Windows.Forms.Label();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.comboBox_ccHP = new System.Windows.Forms.ComboBox();
            this.comboBox_Vehicle = new System.Windows.Forms.ComboBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.label_CCHP = new System.Windows.Forms.Label();
            this.lable_Duration = new System.Windows.Forms.Label();
            this.label_Used = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_ResultShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(641, 577);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(99, 27);
            this.EXIT.TabIndex = 29;
            this.EXIT.Text = "關閉程式";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 577);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 27);
            this.button2.TabIndex = 23;
            this.button2.Text = "重新填寫";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "確定送出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_Tip
            // 
            this.label_Tip.AutoSize = true;
            this.label_Tip.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Tip.ForeColor = System.Drawing.Color.Navy;
            this.label_Tip.Location = new System.Drawing.Point(15, 62);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(132, 25);
            this.label_Tip.TabIndex = 34;
            this.label_Tip.Text = "貼心小叮嚀：";
            // 
            // label_Tips
            // 
            this.label_Tips.AutoSize = true;
            this.label_Tips.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Tips.Location = new System.Drawing.Point(16, 92);
            this.label_Tips.Name = "label_Tips";
            this.label_Tips.Size = new System.Drawing.Size(78, 22);
            this.label_Tips.TabIndex = 33;
            this.label_Tips.Text = "叮嚀內容";
            this.label_Tips.Click += new System.EventHandler(this.label_Tips_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("標楷體", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Title.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(400, 33);
            this.label_Title.TabIndex = 32;
            this.label_Title.Text = "使用牌照稅應納稅額試算";
            // 
            // label_dateTimePickerEnd
            // 
            this.label_dateTimePickerEnd.AutoSize = true;
            this.label_dateTimePickerEnd.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.label_dateTimePickerEnd.Location = new System.Drawing.Point(726, 158);
            this.label_dateTimePickerEnd.Name = "label_dateTimePickerEnd";
            this.label_dateTimePickerEnd.Size = new System.Drawing.Size(45, 22);
            this.label_dateTimePickerEnd.TabIndex = 49;
            this.label_dateTimePickerEnd.Text = "-----";
            // 
            // label_dateTimePickerStart
            // 
            this.label_dateTimePickerStart.AutoSize = true;
            this.label_dateTimePickerStart.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.label_dateTimePickerStart.Location = new System.Drawing.Point(545, 158);
            this.label_dateTimePickerStart.Name = "label_dateTimePickerStart";
            this.label_dateTimePickerStart.Size = new System.Drawing.Size(45, 22);
            this.label_dateTimePickerStart.TabIndex = 48;
            this.label_dateTimePickerStart.Text = "-----";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_WholeYear);
            this.panel1.Controls.Add(this.radioButton_Duration);
            this.panel1.Location = new System.Drawing.Point(166, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 50);
            this.panel1.TabIndex = 47;
            // 
            // radioButton_WholeYear
            // 
            this.radioButton_WholeYear.AutoSize = true;
            this.radioButton_WholeYear.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.radioButton_WholeYear.Location = new System.Drawing.Point(15, 15);
            this.radioButton_WholeYear.Name = "radioButton_WholeYear";
            this.radioButton_WholeYear.Size = new System.Drawing.Size(93, 29);
            this.radioButton_WholeYear.TabIndex = 6;
            this.radioButton_WholeYear.TabStop = true;
            this.radioButton_WholeYear.Text = "全年度";
            this.radioButton_WholeYear.UseVisualStyleBackColor = true;
            this.radioButton_WholeYear.CheckedChanged += new System.EventHandler(this.radioButton_WholeYear_CheckedChanged);
            // 
            // radioButton_Duration
            // 
            this.radioButton_Duration.AutoSize = true;
            this.radioButton_Duration.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.radioButton_Duration.Location = new System.Drawing.Point(136, 15);
            this.radioButton_Duration.Name = "radioButton_Duration";
            this.radioButton_Duration.Size = new System.Drawing.Size(93, 29);
            this.radioButton_Duration.TabIndex = 7;
            this.radioButton_Duration.TabStop = true;
            this.radioButton_Duration.Text = "依期間";
            this.radioButton_Duration.UseVisualStyleBackColor = true;
            this.radioButton_Duration.CheckedChanged += new System.EventHandler(this.radioButton_Duration_CheckedChanged);
            // 
            // panel_ResultShow
            // 
            this.panel_ResultShow.AutoScroll = true;
            this.panel_ResultShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ResultShow.Controls.Add(this.label_ResultShow);
            this.panel_ResultShow.Location = new System.Drawing.Point(166, 386);
            this.panel_ResultShow.Name = "panel_ResultShow";
            this.panel_ResultShow.Size = new System.Drawing.Size(633, 174);
            this.panel_ResultShow.TabIndex = 46;
            // 
            // label_ResultShow
            // 
            this.label_ResultShow.AutoSize = true;
            this.label_ResultShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ResultShow.Location = new System.Drawing.Point(4, 6);
            this.label_ResultShow.Name = "label_ResultShow";
            this.label_ResultShow.Size = new System.Drawing.Size(92, 25);
            this.label_ResultShow.TabIndex = 14;
            this.label_ResultShow.Text = "文字敘述";
            this.label_ResultShow.Click += new System.EventHandler(this.label_ResultShow_Click);
            // 
            // label_CCHPMessage
            // 
            this.label_CCHPMessage.AutoSize = true;
            this.label_CCHPMessage.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_CCHPMessage.Location = new System.Drawing.Point(682, 326);
            this.label_CCHPMessage.Name = "label_CCHPMessage";
            this.label_CCHPMessage.Size = new System.Drawing.Size(45, 22);
            this.label_CCHPMessage.TabIndex = 45;
            this.label_CCHPMessage.Text = "-----";
            // 
            // label_DateEnd
            // 
            this.label_DateEnd.AutoSize = true;
            this.label_DateEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_DateEnd.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_DateEnd.Location = new System.Drawing.Point(695, 155);
            this.label_DateEnd.Name = "label_DateEnd";
            this.label_DateEnd.Size = new System.Drawing.Size(32, 25);
            this.label_DateEnd.TabIndex = 44;
            this.label_DateEnd.Text = "到";
            // 
            // label_DateStart
            // 
            this.label_DateStart.AutoSize = true;
            this.label_DateStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_DateStart.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_DateStart.Location = new System.Drawing.Point(498, 155);
            this.label_DateStart.Name = "label_DateStart";
            this.label_DateStart.Size = new System.Drawing.Size(32, 25);
            this.label_DateStart.TabIndex = 43;
            this.label_DateStart.Text = "從";
            this.label_DateStart.Click += new System.EventHandler(this.label_DateStart_Click);
            // 
            // label_VehicleMessage
            // 
            this.label_VehicleMessage.AutoSize = true;
            this.label_VehicleMessage.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_VehicleMessage.Location = new System.Drawing.Point(454, 245);
            this.label_VehicleMessage.Name = "label_VehicleMessage";
            this.label_VehicleMessage.Size = new System.Drawing.Size(45, 22);
            this.label_VehicleMessage.TabIndex = 42;
            this.label_VehicleMessage.Text = "-----";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Location = new System.Drawing.Point(700, 183);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(150, 25);
            this.dateTimePicker_End.TabIndex = 41;
            this.dateTimePicker_End.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_End.ValueChanged += new System.EventHandler(this.dateTimePicker_End_ValueChanged);
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(503, 184);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(150, 25);
            this.dateTimePicker_Start.TabIndex = 40;
            this.dateTimePicker_Start.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // comboBox_ccHP
            // 
            this.comboBox_ccHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ccHP.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_ccHP.FormattingEnabled = true;
            this.comboBox_ccHP.Location = new System.Drawing.Point(176, 320);
            this.comboBox_ccHP.Name = "comboBox_ccHP";
            this.comboBox_ccHP.Size = new System.Drawing.Size(447, 28);
            this.comboBox_ccHP.TabIndex = 39;
            this.comboBox_ccHP.SelectedIndexChanged += new System.EventHandler(this.comboBox_ccHP_SelectedIndexChanged);
            // 
            // comboBox_Vehicle
            // 
            this.comboBox_Vehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Vehicle.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_Vehicle.FormattingEnabled = true;
            this.comboBox_Vehicle.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車",
            "電動機車",
            "電動自用小客車",
            "電動營業用小客車",
            "電動貨車及大客車",
            "曳引車"});
            this.comboBox_Vehicle.Location = new System.Drawing.Point(176, 243);
            this.comboBox_Vehicle.Name = "comboBox_Vehicle";
            this.comboBox_Vehicle.Size = new System.Drawing.Size(237, 28);
            this.comboBox_Vehicle.TabIndex = 38;
            this.comboBox_Vehicle.SelectedIndexChanged += new System.EventHandler(this.comboBox_Vehicle_SelectedIndexChanged);
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label_Result.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_Result.Location = new System.Drawing.Point(43, 393);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(92, 25);
            this.label_Result.TabIndex = 37;
            this.label_Result.Text = "試算結果";
            // 
            // label_CCHP
            // 
            this.label_CCHP.AutoSize = true;
            this.label_CCHP.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label_CCHP.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_CCHP.Location = new System.Drawing.Point(43, 323);
            this.label_CCHP.Name = "label_CCHP";
            this.label_CCHP.Size = new System.Drawing.Size(92, 25);
            this.label_CCHP.TabIndex = 36;
            this.label_CCHP.Text = "汽缸馬力";
            // 
            // lable_Duration
            // 
            this.lable_Duration.AutoSize = true;
            this.lable_Duration.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lable_Duration.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lable_Duration.Location = new System.Drawing.Point(43, 183);
            this.lable_Duration.Name = "lable_Duration";
            this.lable_Duration.Size = new System.Drawing.Size(92, 25);
            this.lable_Duration.TabIndex = 35;
            this.lable_Duration.Text = "使用期間";
            // 
            // label_Used
            // 
            this.label_Used.AutoSize = true;
            this.label_Used.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Used.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_Used.Location = new System.Drawing.Point(43, 242);
            this.label_Used.Name = "label_Used";
            this.label_Used.Size = new System.Drawing.Size(92, 25);
            this.label_Used.TabIndex = 50;
            this.label_Used.Text = "牌照用途";
            // 
            // TAX_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 616);
            this.Controls.Add(this.label_Used);
            this.Controls.Add(this.label_dateTimePickerEnd);
            this.Controls.Add(this.label_dateTimePickerStart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_ResultShow);
            this.Controls.Add(this.label_CCHPMessage);
            this.Controls.Add(this.label_DateEnd);
            this.Controls.Add(this.label_DateStart);
            this.Controls.Add(this.label_VehicleMessage);
            this.Controls.Add(this.dateTimePicker_End);
            this.Controls.Add(this.dateTimePicker_Start);
            this.Controls.Add(this.comboBox_ccHP);
            this.Controls.Add(this.comboBox_Vehicle);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label_CCHP);
            this.Controls.Add(this.lable_Duration);
            this.Controls.Add(this.label_Tip);
            this.Controls.Add(this.label_Tips);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TAX_form";
            this.Text = "TaxForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_ResultShow.ResumeLayout(false);
            this.panel_ResultShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Tip;
        private System.Windows.Forms.Label label_Tips;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_dateTimePickerEnd;
        private System.Windows.Forms.Label label_dateTimePickerStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_WholeYear;
        private System.Windows.Forms.RadioButton radioButton_Duration;
        private System.Windows.Forms.Panel panel_ResultShow;
        private System.Windows.Forms.Label label_ResultShow;
        private System.Windows.Forms.Label label_CCHPMessage;
        private System.Windows.Forms.Label label_DateEnd;
        private System.Windows.Forms.Label label_DateStart;
        private System.Windows.Forms.Label label_VehicleMessage;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.ComboBox comboBox_ccHP;
        private System.Windows.Forms.ComboBox comboBox_Vehicle;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Label label_CCHP;
        private System.Windows.Forms.Label lable_Duration;
        private System.Windows.Forms.Label label_Used;
    }
}

