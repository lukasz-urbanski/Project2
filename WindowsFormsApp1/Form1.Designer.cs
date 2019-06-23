namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RadioMnozenie = new System.Windows.Forms.RadioButton();
            this.RadioDzielenie = new System.Windows.Forms.RadioButton();
            this.RAdioPotegowanie = new System.Windows.Forms.RadioButton();
            this.RadioOdejmowanie = new System.Windows.Forms.RadioButton();
            this.OperationCountTB = new System.Windows.Forms.TextBox();
            this.StartBT = new System.Windows.Forms.Button();
            this.PathTB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ErrorLogTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioDodawanie = new System.Windows.Forms.RadioButton();
            this.radioModulo = new System.Windows.Forms.RadioButton();
            this.filesExtComboBox = new System.Windows.Forms.ComboBox();
            this.errorLogPathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorLogTextBox = new System.Windows.Forms.TextBox();
            this.openErrorLogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RadioMnozenie
            // 
            this.RadioMnozenie.AutoSize = true;
            this.RadioMnozenie.Location = new System.Drawing.Point(22, 35);
            this.RadioMnozenie.Margin = new System.Windows.Forms.Padding(2);
            this.RadioMnozenie.Name = "RadioMnozenie";
            this.RadioMnozenie.Size = new System.Drawing.Size(71, 17);
            this.RadioMnozenie.TabIndex = 0;
            this.RadioMnozenie.TabStop = true;
            this.RadioMnozenie.Text = "Mnożenie";
            this.RadioMnozenie.UseVisualStyleBackColor = true;
            this.RadioMnozenie.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioDzielenie
            // 
            this.RadioDzielenie.AutoSize = true;
            this.RadioDzielenie.Location = new System.Drawing.Point(22, 57);
            this.RadioDzielenie.Margin = new System.Windows.Forms.Padding(2);
            this.RadioDzielenie.Name = "RadioDzielenie";
            this.RadioDzielenie.Size = new System.Drawing.Size(68, 17);
            this.RadioDzielenie.TabIndex = 1;
            this.RadioDzielenie.TabStop = true;
            this.RadioDzielenie.Text = "Dzielenie";
            this.RadioDzielenie.UseVisualStyleBackColor = true;
            this.RadioDzielenie.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RAdioPotegowanie
            // 
            this.RAdioPotegowanie.AutoSize = true;
            this.RAdioPotegowanie.Location = new System.Drawing.Point(22, 80);
            this.RAdioPotegowanie.Margin = new System.Windows.Forms.Padding(2);
            this.RAdioPotegowanie.Name = "RAdioPotegowanie";
            this.RAdioPotegowanie.Size = new System.Drawing.Size(87, 17);
            this.RAdioPotegowanie.TabIndex = 2;
            this.RAdioPotegowanie.TabStop = true;
            this.RAdioPotegowanie.Text = "Potęgowanie";
            this.RAdioPotegowanie.UseVisualStyleBackColor = true;
            this.RAdioPotegowanie.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // RadioOdejmowanie
            // 
            this.RadioOdejmowanie.AutoSize = true;
            this.RadioOdejmowanie.Location = new System.Drawing.Point(22, 102);
            this.RadioOdejmowanie.Margin = new System.Windows.Forms.Padding(2);
            this.RadioOdejmowanie.Name = "RadioOdejmowanie";
            this.RadioOdejmowanie.Size = new System.Drawing.Size(87, 17);
            this.RadioOdejmowanie.TabIndex = 3;
            this.RadioOdejmowanie.TabStop = true;
            this.RadioOdejmowanie.Text = "odejmowanie";
            this.RadioOdejmowanie.UseVisualStyleBackColor = true;
            this.RadioOdejmowanie.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // OperationCountTB
            // 
            this.OperationCountTB.Location = new System.Drawing.Point(22, 283);
            this.OperationCountTB.Margin = new System.Windows.Forms.Padding(2);
            this.OperationCountTB.Name = "OperationCountTB";
            this.OperationCountTB.Size = new System.Drawing.Size(66, 20);
            this.OperationCountTB.TabIndex = 4;
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(105, 272);
            this.StartBT.Margin = new System.Windows.Forms.Padding(2);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(71, 28);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // PathTB
            // 
            this.PathTB.Location = new System.Drawing.Point(22, 325);
            this.PathTB.Margin = new System.Windows.Forms.Padding(2);
            this.PathTB.Name = "PathTB";
            this.PathTB.Size = new System.Drawing.Size(563, 20);
            this.PathTB.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ErrorLogTB
            // 
            this.ErrorLogTB.Location = new System.Drawing.Point(233, 34);
            this.ErrorLogTB.Margin = new System.Windows.Forms.Padding(2);
            this.ErrorLogTB.Multiline = true;
            this.ErrorLogTB.Name = "ErrorLogTB";
            this.ErrorLogTB.ReadOnly = true;
            this.ErrorLogTB.Size = new System.Drawing.Size(351, 132);
            this.ErrorLogTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ilość operacji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ścieżka do XML";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Log";
            // 
            // radioDodawanie
            // 
            this.radioDodawanie.AutoSize = true;
            this.radioDodawanie.Location = new System.Drawing.Point(22, 125);
            this.radioDodawanie.Name = "radioDodawanie";
            this.radioDodawanie.Size = new System.Drawing.Size(77, 17);
            this.radioDodawanie.TabIndex = 12;
            this.radioDodawanie.TabStop = true;
            this.radioDodawanie.Text = "dodawanie";
            this.radioDodawanie.UseVisualStyleBackColor = true;
            this.radioDodawanie.CheckedChanged += new System.EventHandler(this.RadioDodawanie_CheckedChanged);
            // 
            // radioModulo
            // 
            this.radioModulo.AutoSize = true;
            this.radioModulo.Location = new System.Drawing.Point(22, 149);
            this.radioModulo.Name = "radioModulo";
            this.radioModulo.Size = new System.Drawing.Size(59, 17);
            this.radioModulo.TabIndex = 13;
            this.radioModulo.TabStop = true;
            this.radioModulo.Text = "modulo";
            this.radioModulo.UseVisualStyleBackColor = true;
            this.radioModulo.CheckedChanged += new System.EventHandler(this.RadioModulo_CheckedChanged);
            // 
            // filesExtComboBox
            // 
            this.filesExtComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filesExtComboBox.FormattingEnabled = true;
            this.filesExtComboBox.Location = new System.Drawing.Point(22, 173);
            this.filesExtComboBox.Name = "filesExtComboBox";
            this.filesExtComboBox.Size = new System.Drawing.Size(121, 21);
            this.filesExtComboBox.TabIndex = 14;
            // 
            // errorLogPathTextBox
            // 
            this.errorLogPathTextBox.Location = new System.Drawing.Point(22, 201);
            this.errorLogPathTextBox.Name = "errorLogPathTextBox";
            this.errorLogPathTextBox.Size = new System.Drawing.Size(121, 20);
            this.errorLogPathTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ErrorLog";
            // 
            // errorLogTextBox
            // 
            this.errorLogTextBox.Location = new System.Drawing.Point(233, 189);
            this.errorLogTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.errorLogTextBox.Multiline = true;
            this.errorLogTextBox.Name = "errorLogTextBox";
            this.errorLogTextBox.ReadOnly = true;
            this.errorLogTextBox.Size = new System.Drawing.Size(351, 132);
            this.errorLogTextBox.TabIndex = 16;
            // 
            // openErrorLogButton
            // 
            this.openErrorLogButton.Location = new System.Drawing.Point(22, 228);
            this.openErrorLogButton.Name = "openErrorLogButton";
            this.openErrorLogButton.Size = new System.Drawing.Size(121, 23);
            this.openErrorLogButton.TabIndex = 18;
            this.openErrorLogButton.Text = "Open ErrorLog";
            this.openErrorLogButton.UseVisualStyleBackColor = true;
            this.openErrorLogButton.Click += new System.EventHandler(this.OpenErrorLogButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.openErrorLogButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorLogTextBox);
            this.Controls.Add(this.errorLogPathTextBox);
            this.Controls.Add(this.filesExtComboBox);
            this.Controls.Add(this.radioModulo);
            this.Controls.Add(this.radioDodawanie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorLogTB);
            this.Controls.Add(this.PathTB);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.OperationCountTB);
            this.Controls.Add(this.RadioOdejmowanie);
            this.Controls.Add(this.RAdioPotegowanie);
            this.Controls.Add(this.RadioDzielenie);
            this.Controls.Add(this.RadioMnozenie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Prog 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioMnozenie;
        private System.Windows.Forms.RadioButton RadioDzielenie;
        private System.Windows.Forms.RadioButton RAdioPotegowanie;
        private System.Windows.Forms.RadioButton RadioOdejmowanie;
        private System.Windows.Forms.TextBox OperationCountTB;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.TextBox PathTB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ErrorLogTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioDodawanie;
        private System.Windows.Forms.RadioButton radioModulo;
        private System.Windows.Forms.ComboBox filesExtComboBox;
        private System.Windows.Forms.TextBox errorLogPathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox errorLogTextBox;
        private System.Windows.Forms.Button openErrorLogButton;
    }
}

