namespace SuggestionGen
{
	partial class SuggestionGenForm
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
			this.englishTextBox = new System.Windows.Forms.TextBox();
			this.englishLabel = new System.Windows.Forms.Label();
			this.originalLabel = new System.Windows.Forms.Label();
			this.originalTextBox = new System.Windows.Forms.TextBox();
			this.copyCodeButton = new System.Windows.Forms.Button();
			this.titleLabel = new System.Windows.Forms.Label();
			this.languageTextBox = new System.Windows.Forms.TextBox();
			this.sourceLinkTextBox = new System.Windows.Forms.TextBox();
			this.sourceLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.sourceTextTextBox = new System.Windows.Forms.TextBox();
			this.authorTextBox = new System.Windows.Forms.TextBox();
			this.createdAtTextBox = new System.Windows.Forms.TextBox();
			this.authorLabel = new System.Windows.Forms.Label();
			this.createdAtLabel = new System.Windows.Forms.Label();
			this.clearButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// englishTextBox
			// 
			this.englishTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.englishTextBox.Location = new System.Drawing.Point(12, 103);
			this.englishTextBox.Multiline = true;
			this.englishTextBox.Name = "englishTextBox";
			this.englishTextBox.Size = new System.Drawing.Size(350, 266);
			this.englishTextBox.TabIndex = 0;
			// 
			// englishLabel
			// 
			this.englishLabel.AutoSize = true;
			this.englishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.englishLabel.Location = new System.Drawing.Point(12, 75);
			this.englishLabel.Name = "englishLabel";
			this.englishLabel.Size = new System.Drawing.Size(83, 25);
			this.englishLabel.TabIndex = 1;
			this.englishLabel.Text = "English";
			this.englishLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// originalLabel
			// 
			this.originalLabel.AutoSize = true;
			this.originalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.originalLabel.Location = new System.Drawing.Point(373, 75);
			this.originalLabel.Name = "originalLabel";
			this.originalLabel.Size = new System.Drawing.Size(327, 25);
			this.originalLabel.TabIndex = 2;
			this.originalLabel.Text = "Original (language:                     )";
			this.originalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// originalTextBox
			// 
			this.originalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.originalTextBox.Location = new System.Drawing.Point(378, 103);
			this.originalTextBox.Multiline = true;
			this.originalTextBox.Name = "originalTextBox";
			this.originalTextBox.Size = new System.Drawing.Size(350, 266);
			this.originalTextBox.TabIndex = 3;
			// 
			// copyCodeButton
			// 
			this.copyCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.copyCodeButton.Location = new System.Drawing.Point(222, 441);
			this.copyCodeButton.Name = "copyCodeButton";
			this.copyCodeButton.Size = new System.Drawing.Size(325, 32);
			this.copyCodeButton.TabIndex = 4;
			this.copyCodeButton.Text = "Copy HTML code to clipboard";
			this.copyCodeButton.UseVisualStyleBackColor = true;
			this.copyCodeButton.Click += new System.EventHandler(this.CopyToClipboard);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.titleLabel.Location = new System.Drawing.Point(95, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(544, 57);
			this.titleLabel.TabIndex = 5;
			this.titleLabel.Text = "Suggestion HTML Generator";
			// 
			// languageTextBox
			// 
			this.languageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.languageTextBox.Location = new System.Drawing.Point(566, 79);
			this.languageTextBox.Name = "languageTextBox";
			this.languageTextBox.Size = new System.Drawing.Size(117, 21);
			this.languageTextBox.TabIndex = 6;
			// 
			// sourceLinkTextBox
			// 
			this.sourceLinkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sourceLinkTextBox.Location = new System.Drawing.Point(500, 409);
			this.sourceLinkTextBox.Name = "sourceLinkTextBox";
			this.sourceLinkTextBox.Size = new System.Drawing.Size(228, 26);
			this.sourceLinkTextBox.TabIndex = 7;
			// 
			// sourceLabel
			// 
			this.sourceLabel.AutoSize = true;
			this.sourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sourceLabel.Location = new System.Drawing.Point(375, 410);
			this.sourceLabel.Name = "sourceLabel";
			this.sourceLabel.Size = new System.Drawing.Size(119, 25);
			this.sourceLabel.TabIndex = 8;
			this.sourceLabel.Text = "Source link";
			this.sourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(375, 378);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 25);
			this.label1.TabIndex = 9;
			this.label1.Text = "Source text";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sourceTextTextBox
			// 
			this.sourceTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sourceTextTextBox.Location = new System.Drawing.Point(500, 377);
			this.sourceTextTextBox.Name = "sourceTextTextBox";
			this.sourceTextTextBox.Size = new System.Drawing.Size(228, 26);
			this.sourceTextTextBox.TabIndex = 10;
			// 
			// authorTextBox
			// 
			this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.authorTextBox.Location = new System.Drawing.Point(85, 377);
			this.authorTextBox.Name = "authorTextBox";
			this.authorTextBox.Size = new System.Drawing.Size(277, 26);
			this.authorTextBox.TabIndex = 11;
			// 
			// createdAtTextBox
			// 
			this.createdAtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.createdAtTextBox.Location = new System.Drawing.Point(156, 409);
			this.createdAtTextBox.Name = "createdAtTextBox";
			this.createdAtTextBox.Size = new System.Drawing.Size(206, 26);
			this.createdAtTextBox.TabIndex = 12;
			// 
			// authorLabel
			// 
			this.authorLabel.AutoSize = true;
			this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.authorLabel.Location = new System.Drawing.Point(9, 378);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(75, 25);
			this.authorLabel.TabIndex = 13;
			this.authorLabel.Text = "Author";
			this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// createdAtLabel
			// 
			this.createdAtLabel.AutoSize = true;
			this.createdAtLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createdAtLabel.Location = new System.Drawing.Point(9, 410);
			this.createdAtLabel.Name = "createdAtLabel";
			this.createdAtLabel.Size = new System.Drawing.Size(147, 21);
			this.createdAtLabel.TabIndex = 14;
			this.createdAtLabel.Text = "dd.MM.yyyy hh:mm";
			this.createdAtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// clearButton
			// 
			this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.clearButton.Location = new System.Drawing.Point(618, 441);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(109, 32);
			this.clearButton.TabIndex = 15;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.ClearTextBoxes);
			// 
			// SuggestionGenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(739, 481);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.createdAtLabel);
			this.Controls.Add(this.authorLabel);
			this.Controls.Add(this.createdAtTextBox);
			this.Controls.Add(this.authorTextBox);
			this.Controls.Add(this.sourceTextTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sourceLabel);
			this.Controls.Add(this.sourceLinkTextBox);
			this.Controls.Add(this.languageTextBox);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.copyCodeButton);
			this.Controls.Add(this.originalTextBox);
			this.Controls.Add(this.originalLabel);
			this.Controls.Add(this.englishLabel);
			this.Controls.Add(this.englishTextBox);
			this.Name = "SuggestionGenForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox englishTextBox;
		private System.Windows.Forms.Label englishLabel;
		private System.Windows.Forms.Label originalLabel;
		private System.Windows.Forms.TextBox originalTextBox;
		private System.Windows.Forms.Button copyCodeButton;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.TextBox languageTextBox;
		private System.Windows.Forms.TextBox sourceLinkTextBox;
		private System.Windows.Forms.Label sourceLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox sourceTextTextBox;
		private System.Windows.Forms.TextBox authorTextBox;
		private System.Windows.Forms.TextBox createdAtTextBox;
		private System.Windows.Forms.Label authorLabel;
		private System.Windows.Forms.Label createdAtLabel;
		private System.Windows.Forms.Button clearButton;
	}
}

