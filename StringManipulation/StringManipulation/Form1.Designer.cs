
namespace StringManipulation
{
    partial class StringManipulation
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
            this.RemoveVowelsBtn = new System.Windows.Forms.Button();
            this.IndexBtn = new System.Windows.Forms.Button();
            this.RemoveSecLastBtn = new System.Windows.Forms.Button();
            this.FirstMiddleLastBtn = new System.Windows.Forms.Button();
            this.CharAndVowelBtn = new System.Windows.Forms.Button();
            this.InputTxtBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.DisplayRichTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RemoveVowelsBtn
            // 
            this.RemoveVowelsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveVowelsBtn.Location = new System.Drawing.Point(534, 483);
            this.RemoveVowelsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveVowelsBtn.Name = "RemoveVowelsBtn";
            this.RemoveVowelsBtn.Size = new System.Drawing.Size(371, 88);
            this.RemoveVowelsBtn.TabIndex = 26;
            this.RemoveVowelsBtn.Text = "Remove All Vowels";
            this.RemoveVowelsBtn.UseVisualStyleBackColor = true;
            this.RemoveVowelsBtn.Click += new System.EventHandler(this.RemoveVowelsBtn_Click);
            // 
            // IndexBtn
            // 
            this.IndexBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexBtn.Location = new System.Drawing.Point(534, 388);
            this.IndexBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IndexBtn.Name = "IndexBtn";
            this.IndexBtn.Size = new System.Drawing.Size(371, 88);
            this.IndexBtn.TabIndex = 25;
            this.IndexBtn.Text = "Get Index of First Vowel";
            this.IndexBtn.UseVisualStyleBackColor = true;
            this.IndexBtn.Click += new System.EventHandler(this.IndexBtn_Click);
            // 
            // RemoveSecLastBtn
            // 
            this.RemoveSecLastBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSecLastBtn.Location = new System.Drawing.Point(534, 293);
            this.RemoveSecLastBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveSecLastBtn.Name = "RemoveSecLastBtn";
            this.RemoveSecLastBtn.Size = new System.Drawing.Size(371, 88);
            this.RemoveSecLastBtn.TabIndex = 24;
            this.RemoveSecLastBtn.Text = "Remove Second to Last Word";
            this.RemoveSecLastBtn.UseVisualStyleBackColor = true;
            this.RemoveSecLastBtn.Click += new System.EventHandler(this.RemoveSecLastBtn_Click);
            // 
            // FirstMiddleLastBtn
            // 
            this.FirstMiddleLastBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstMiddleLastBtn.Location = new System.Drawing.Point(534, 198);
            this.FirstMiddleLastBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstMiddleLastBtn.Name = "FirstMiddleLastBtn";
            this.FirstMiddleLastBtn.Size = new System.Drawing.Size(371, 88);
            this.FirstMiddleLastBtn.TabIndex = 23;
            this.FirstMiddleLastBtn.Text = "Get First, Middle, and Last Letter";
            this.FirstMiddleLastBtn.UseVisualStyleBackColor = true;
            this.FirstMiddleLastBtn.Click += new System.EventHandler(this.FirstMiddleLastBtn_Click);
            // 
            // CharAndVowelBtn
            // 
            this.CharAndVowelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharAndVowelBtn.Location = new System.Drawing.Point(534, 103);
            this.CharAndVowelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CharAndVowelBtn.Name = "CharAndVowelBtn";
            this.CharAndVowelBtn.Size = new System.Drawing.Size(371, 88);
            this.CharAndVowelBtn.TabIndex = 22;
            this.CharAndVowelBtn.Text = "Count Characters and Vowels";
            this.CharAndVowelBtn.UseVisualStyleBackColor = true;
            this.CharAndVowelBtn.Click += new System.EventHandler(this.CharAndVowelBtn_Click);
            // 
            // InputTxtBox
            // 
            this.InputTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTxtBox.Location = new System.Drawing.Point(344, 41);
            this.InputTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputTxtBox.Name = "InputTxtBox";
            this.InputTxtBox.Size = new System.Drawing.Size(561, 35);
            this.InputTxtBox.TabIndex = 21;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(28, 41);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(299, 29);
            this.InputLabel.TabIndex = 20;
            this.InputLabel.Text = "Write Your Sentence Here:";
            // 
            // DisplayRichTB
            // 
            this.DisplayRichTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayRichTB.Location = new System.Drawing.Point(33, 103);
            this.DisplayRichTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisplayRichTB.Name = "DisplayRichTB";
            this.DisplayRichTB.Size = new System.Drawing.Size(494, 466);
            this.DisplayRichTB.TabIndex = 19;
            this.DisplayRichTB.Text = "";
            // 
            // StringManipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 603);
            this.Controls.Add(this.RemoveVowelsBtn);
            this.Controls.Add(this.IndexBtn);
            this.Controls.Add(this.RemoveSecLastBtn);
            this.Controls.Add(this.FirstMiddleLastBtn);
            this.Controls.Add(this.CharAndVowelBtn);
            this.Controls.Add(this.InputTxtBox);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.DisplayRichTB);
            this.Name = "StringManipulation";
            this.Text = "String Manipulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveVowelsBtn;
        private System.Windows.Forms.Button IndexBtn;
        private System.Windows.Forms.Button RemoveSecLastBtn;
        private System.Windows.Forms.Button FirstMiddleLastBtn;
        private System.Windows.Forms.Button CharAndVowelBtn;
        private System.Windows.Forms.TextBox InputTxtBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.RichTextBox DisplayRichTB;
    }
}

