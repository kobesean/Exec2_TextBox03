namespace Q3
{
	partial class Form1
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
			this.outputLabel = new System.Windows.Forms.Label();
			this.checkButton = new System.Windows.Forms.Button();
			this.dateTimeTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// outputLabel
			// 
			this.outputLabel.AutoSize = true;
			this.outputLabel.Location = new System.Drawing.Point(91, 222);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(134, 18);
			this.outputLabel.TabIndex = 0;
			this.outputLabel.Text = "請輸入您的生日";
			// 
			// checkButton
			// 
			this.checkButton.Location = new System.Drawing.Point(245, 96);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(75, 23);
			this.checkButton.TabIndex = 1;
			this.checkButton.Text = "驗證";
			this.checkButton.UseVisualStyleBackColor = true;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// dateTimeTextBox
			// 
			this.dateTimeTextBox.Location = new System.Drawing.Point(60, 90);
			this.dateTimeTextBox.Name = "dateTimeTextBox";
			this.dateTimeTextBox.Size = new System.Drawing.Size(100, 29);
			this.dateTimeTextBox.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 431);
			this.Controls.Add(this.dateTimeTextBox);
			this.Controls.Add(this.checkButton);
			this.Controls.Add(this.outputLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label outputLabel;
		private System.Windows.Forms.Button checkButton;
		private System.Windows.Forms.TextBox dateTimeTextBox;
	}
}

