namespace koryagin1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.inputBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.translateButton = new System.Windows.Forms.Button();
			this.outputLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// inputBox
			// 
			this.inputBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.inputBox.Location = new System.Drawing.Point(30, 64);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(577, 27);
			this.inputBox.TabIndex = 0;
			this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(96, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(441, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Введите словами число на французском для перевода в число";
			// 
			// translateButton
			// 
			this.translateButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.translateButton.Location = new System.Drawing.Point(168, 102);
			this.translateButton.Name = "translateButton";
			this.translateButton.Size = new System.Drawing.Size(287, 60);
			this.translateButton.TabIndex = 2;
			this.translateButton.Text = "Перевести";
			this.translateButton.UseVisualStyleBackColor = true;
			this.translateButton.Click += new System.EventHandler(this.TranslateButton_Click);
			// 
			// outputLabel
			// 
			this.outputLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.outputLabel.Location = new System.Drawing.Point(30, 177);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(577, 76);
			this.outputLabel.TabIndex = 3;
			this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.ClientSize = new System.Drawing.Size(639, 263);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.translateButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inputBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Практика 1 Муравьев БСБО-01-20";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button translateButton;
		private System.Windows.Forms.Label outputLabel;
	}
}

