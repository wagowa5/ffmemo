
namespace FFMemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fromText = new System.Windows.Forms.TextBox();
            this.toText = new System.Windows.Forms.TextBox();
            this.transButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.chatLabel = new System.Windows.Forms.Label();
            this.isTimestamp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fromText
            // 
            this.fromText.Font = new System.Drawing.Font("XIV AXIS Std ATK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromText.Location = new System.Drawing.Point(12, 90);
            this.fromText.Multiline = true;
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(428, 557);
            this.fromText.TabIndex = 0;
            // 
            // toText
            // 
            this.toText.Font = new System.Drawing.Font("XIV AXIS Std ATK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toText.Location = new System.Drawing.Point(663, 90);
            this.toText.Multiline = true;
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(428, 557);
            this.toText.TabIndex = 1;
            // 
            // transButton
            // 
            this.transButton.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transButton.Location = new System.Drawing.Point(472, 333);
            this.transButton.Name = "transButton";
            this.transButton.Size = new System.Drawing.Size(161, 69);
            this.transButton.TabIndex = 2;
            this.transButton.Text = "変換";
            this.transButton.UseVisualStyleBackColor = true;
            this.transButton.Click += new System.EventHandler(this.transButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(795, 15);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(161, 69);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "マクロ保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            // 
            // chatLabel
            // 
            this.chatLabel.AutoSize = true;
            this.chatLabel.Font = new System.Drawing.Font("XIV AXIS Std ATK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chatLabel.Location = new System.Drawing.Point(131, 45);
            this.chatLabel.Name = "chatLabel";
            this.chatLabel.Size = new System.Drawing.Size(171, 29);
            this.chatLabel.TabIndex = 4;
            this.chatLabel.Text = "コピー元チャット";
            // 
            // isTimestamp
            // 
            this.isTimestamp.AutoSize = true;
            this.isTimestamp.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isTimestamp.Location = new System.Drawing.Point(472, 298);
            this.isTimestamp.Name = "isTimestamp";
            this.isTimestamp.Size = new System.Drawing.Size(167, 29);
            this.isTimestamp.TabIndex = 5;
            this.isTimestamp.Text = "タイムスタンプ有無";
            this.isTimestamp.UseVisualStyleBackColor = true;
            this.isTimestamp.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 659);
            this.Controls.Add(this.isTimestamp);
            this.Controls.Add(this.chatLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.transButton);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.fromText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromText;
        private System.Windows.Forms.TextBox toText;
        private System.Windows.Forms.Button transButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label chatLabel;
        private System.Windows.Forms.CheckBox isTimestamp;
    }
}

