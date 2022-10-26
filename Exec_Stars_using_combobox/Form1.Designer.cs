namespace Exec_Stars_using_combobox
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
			this.rowLabel = new System.Windows.Forms.Label();
			this.rowsTextBox = new System.Windows.Forms.TextBox();
			this.layoutLabel = new System.Windows.Forms.Label();
			this.layoutCbBox = new System.Windows.Forms.ComboBox();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.generateButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rowLabel
			// 
			this.rowLabel.AutoSize = true;
			this.rowLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rowLabel.Location = new System.Drawing.Point(144, 89);
			this.rowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.rowLabel.Name = "rowLabel";
			this.rowLabel.Size = new System.Drawing.Size(52, 25);
			this.rowLabel.TabIndex = 0;
			this.rowLabel.Text = "列數";
			// 
			// rowsTextBox
			// 
			this.rowsTextBox.Location = new System.Drawing.Point(211, 85);
			this.rowsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rowsTextBox.Name = "rowsTextBox";
			this.rowsTextBox.Size = new System.Drawing.Size(132, 25);
			this.rowsTextBox.TabIndex = 1;
			this.rowsTextBox.TextChanged += new System.EventHandler(this.rowLabel_TextChanged);
			// 
			// layoutLabel
			// 
			this.layoutLabel.AutoSize = true;
			this.layoutLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.layoutLabel.Location = new System.Drawing.Point(144, 144);
			this.layoutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.layoutLabel.Name = "layoutLabel";
			this.layoutLabel.Size = new System.Drawing.Size(52, 25);
			this.layoutLabel.TabIndex = 2;
			this.layoutLabel.Text = "呈現";
			// 
			// layoutCbBox
			// 
			this.layoutCbBox.FormattingEnabled = true;
			this.layoutCbBox.Items.AddRange(new object[] {
            "靠左直角三角形",
            "靠右直角三角形",
            "等腰直角三角形"});
			this.layoutCbBox.Location = new System.Drawing.Point(211, 141);
			this.layoutCbBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.layoutCbBox.Name = "layoutCbBox";
			this.layoutCbBox.Size = new System.Drawing.Size(132, 23);
			this.layoutCbBox.TabIndex = 3;
			// 
			// resultTextBox
			// 
			this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultTextBox.Location = new System.Drawing.Point(147, 195);
			this.resultTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.resultTextBox.Multiline = true;
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.resultTextBox.Size = new System.Drawing.Size(315, 289);
			this.resultTextBox.TabIndex = 4;
			this.resultTextBox.WordWrap = false;
			// 
			// generateButton
			// 
			this.generateButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.generateButton.Location = new System.Drawing.Point(372, 85);
			this.generateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(91, 81);
			this.generateButton.TabIndex = 5;
			this.generateButton.Text = "產生";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(637, 579);
			this.Controls.Add(this.generateButton);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.layoutCbBox);
			this.Controls.Add(this.layoutLabel);
			this.Controls.Add(this.rowsTextBox);
			this.Controls.Add(this.rowLabel);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "三角形產生器";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label rowLabel;
		private System.Windows.Forms.TextBox rowsTextBox;
		private System.Windows.Forms.Label layoutLabel;
		private System.Windows.Forms.ComboBox layoutCbBox;
		private System.Windows.Forms.TextBox resultTextBox;
		private System.Windows.Forms.Button generateButton;
	}
}

