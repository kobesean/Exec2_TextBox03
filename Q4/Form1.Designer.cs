namespace Q4
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
			this.calcButton = new System.Windows.Forms.Button();
			this.peopleTextBox = new System.Windows.Forms.TextBox();
			this.carTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.outputLable = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// calcButton
			// 
			this.calcButton.Location = new System.Drawing.Point(308, 91);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(75, 23);
			this.calcButton.TabIndex = 0;
			this.calcButton.Text = "計算";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// peopleTextBox
			// 
			this.peopleTextBox.Location = new System.Drawing.Point(34, 58);
			this.peopleTextBox.Name = "peopleTextBox";
			this.peopleTextBox.Size = new System.Drawing.Size(100, 29);
			this.peopleTextBox.TabIndex = 1;
			// 
			// carTextBox
			// 
			this.carTextBox.Location = new System.Drawing.Point(34, 139);
			this.carTextBox.Name = "carTextBox";
			this.carTextBox.Size = new System.Drawing.Size(100, 29);
			this.carTextBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(180, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "人數";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(183, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "車數";
			// 
			// outputLable
			// 
			this.outputLable.AutoSize = true;
			this.outputLable.Location = new System.Drawing.Point(34, 269);
			this.outputLable.Name = "outputLable";
			this.outputLable.Size = new System.Drawing.Size(152, 18);
			this.outputLable.TabIndex = 5;
			this.outputLable.Text = "請輸入人數及車數";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 412);
			this.Controls.Add(this.outputLable);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.carTextBox);
			this.Controls.Add(this.peopleTextBox);
			this.Controls.Add(this.calcButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button calcButton;
		private System.Windows.Forms.TextBox peopleTextBox;
		private System.Windows.Forms.TextBox carTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label outputLable;
	}
}

