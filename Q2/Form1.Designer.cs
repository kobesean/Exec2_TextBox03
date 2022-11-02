namespace Q2
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
			this.dateTimeTextBox = new System.Windows.Forms.TextBox();
			this.CheckButton = new System.Windows.Forms.Button();
			this.outputLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dateTimeTextBox
			// 
			this.dateTimeTextBox.Location = new System.Drawing.Point(92, 88);
			this.dateTimeTextBox.Name = "dateTimeTextBox";
			this.dateTimeTextBox.Size = new System.Drawing.Size(100, 29);
			this.dateTimeTextBox.TabIndex = 0;
			// 
			// CheckButton
			// 
			this.CheckButton.Location = new System.Drawing.Point(314, 93);
			this.CheckButton.Name = "CheckButton";
			this.CheckButton.Size = new System.Drawing.Size(75, 23);
			this.CheckButton.TabIndex = 1;
			this.CheckButton.Text = "驗證";
			this.CheckButton.UseVisualStyleBackColor = true;
			this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
			// 
			// outputLabel
			// 
			this.outputLabel.AutoSize = true;
			this.outputLabel.Location = new System.Drawing.Point(113, 197);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(98, 18);
			this.outputLabel.TabIndex = 2;
			this.outputLabel.Text = "請輸入日期";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 403);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.CheckButton);
			this.Controls.Add(this.dateTimeTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox dateTimeTextBox;
		private System.Windows.Forms.Button CheckButton;
		private System.Windows.Forms.Label outputLabel;
	}
}

