namespace Q1
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
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.checkbutton = new System.Windows.Forms.Button();
			this.outputLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(52, 78);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(100, 29);
			this.inputTextBox.TabIndex = 0;
			// 
			// checkbutton
			// 
			this.checkbutton.Location = new System.Drawing.Point(260, 69);
			this.checkbutton.Name = "checkbutton";
			this.checkbutton.Size = new System.Drawing.Size(75, 38);
			this.checkbutton.TabIndex = 1;
			this.checkbutton.Text = "驗證";
			this.checkbutton.UseVisualStyleBackColor = true;
			this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
			// 
			// outputLabel
			// 
			this.outputLabel.AutoSize = true;
			this.outputLabel.Location = new System.Drawing.Point(65, 196);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(98, 18);
			this.outputLabel.TabIndex = 2;
			this.outputLabel.Text = "請輸入數字";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 450);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.checkbutton);
			this.Controls.Add(this.inputTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Button checkbutton;
		private System.Windows.Forms.Label outputLabel;
	}
}

