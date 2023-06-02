
namespace Mimock
{
    partial class Mimock
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
            this.label2 = new System.Windows.Forms.Label();
            this.speakerPathInput = new System.Windows.Forms.TextBox();
            this.languageTagInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.manualInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.speakButton = new System.Windows.Forms.Button();
            this.wordSpaceInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.registerInput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.outputDeviceBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputDeviceBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.formLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speaker Folder Path";
            // 
            // speakerPathInput
            // 
            this.speakerPathInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speakerPathInput.Location = new System.Drawing.Point(12, 116);
            this.speakerPathInput.Name = "speakerPathInput";
            this.speakerPathInput.Size = new System.Drawing.Size(316, 22);
            this.speakerPathInput.TabIndex = 3;
            this.speakerPathInput.TextChanged += new System.EventHandler(this.speakerPathInput_TextChanged);
            // 
            // languageTagInput
            // 
            this.languageTagInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageTagInput.Location = new System.Drawing.Point(12, 195);
            this.languageTagInput.Name = "languageTagInput";
            this.languageTagInput.Size = new System.Drawing.Size(194, 22);
            this.languageTagInput.TabIndex = 7;
            this.languageTagInput.Text = "en-US";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Listener Language Tag";
            // 
            // manualInput
            // 
            this.manualInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualInput.Location = new System.Drawing.Point(351, 116);
            this.manualInput.Name = "manualInput";
            this.manualInput.Size = new System.Drawing.Size(316, 22);
            this.manualInput.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Manual Text Input";
            // 
            // speakButton
            // 
            this.speakButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speakButton.Location = new System.Drawing.Point(409, 162);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(216, 55);
            this.speakButton.TabIndex = 10;
            this.speakButton.Text = "SPEAK!";
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // wordSpaceInput
            // 
            this.wordSpaceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordSpaceInput.Location = new System.Drawing.Point(12, 279);
            this.wordSpaceInput.Name = "wordSpaceInput";
            this.wordSpaceInput.Size = new System.Drawing.Size(194, 22);
            this.wordSpaceInput.TabIndex = 12;
            this.wordSpaceInput.Text = "0";
            this.wordSpaceInput.TextChanged += new System.EventHandler(this.wordSpaceInput_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Word Spacing (ms)";
            // 
            // registerInput
            // 
            this.registerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerInput.Location = new System.Drawing.Point(558, 290);
            this.registerInput.Name = "registerInput";
            this.registerInput.Size = new System.Drawing.Size(121, 42);
            this.registerInput.TabIndex = 13;
            this.registerInput.Text = "Register Word Regocgnition";
            this.registerInput.UseVisualStyleBackColor = true;
            this.registerInput.Click += new System.EventHandler(this.LoadSpeechRecognition);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = " ";
            // 
            // outputDeviceBox
            // 
            this.outputDeviceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputDeviceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDeviceBox.FormattingEnabled = true;
            this.outputDeviceBox.Location = new System.Drawing.Point(355, 32);
            this.outputDeviceBox.Name = "outputDeviceBox";
            this.outputDeviceBox.Size = new System.Drawing.Size(312, 24);
            this.outputDeviceBox.TabIndex = 4;
            this.outputDeviceBox.SelectedIndexChanged += new System.EventHandler(this.outputDeviceBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Audio Input";
            // 
            // inputDeviceBox
            // 
            this.inputDeviceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDeviceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDeviceBox.FormattingEnabled = true;
            this.inputDeviceBox.Items.AddRange(new object[] {
            "This can not be, sorry."});
            this.inputDeviceBox.Location = new System.Drawing.Point(16, 32);
            this.inputDeviceBox.Name = "inputDeviceBox";
            this.inputDeviceBox.Size = new System.Drawing.Size(312, 24);
            this.inputDeviceBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(431, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Select Speaker Folder Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SetSpeakerPath);
            // 
            // formLog
            // 
            this.formLog.Location = new System.Drawing.Point(217, 162);
            this.formLog.Multiline = true;
            this.formLog.Name = "formLog";
            this.formLog.Size = new System.Drawing.Size(178, 169);
            this.formLog.TabIndex = 15;
            // 
            // Mimock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 344);
            this.Controls.Add(this.formLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.registerInput);
            this.Controls.Add(this.wordSpaceInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.manualInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.languageTagInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputDeviceBox);
            this.Controls.Add(this.speakerPathInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputDeviceBox);
            this.Name = "Mimock";
            this.Text = "Mimock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox speakerPathInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox manualInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.TextBox wordSpaceInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registerInput;
        private System.Windows.Forms.TextBox languageTagInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox outputDeviceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inputDeviceBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox formLog;
    }
}

