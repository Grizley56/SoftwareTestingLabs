namespace FilePathTester
{
	partial class FilePathTesterForm
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
			this.pathTextBox = new System.Windows.Forms.TextBox();
			this.addPathButton = new System.Windows.Forms.Button();
			this.validPathLv = new System.Windows.Forms.ListBox();
			this.invalidPathLv = new System.Windows.Forms.ListBox();
			this.deleteValidPathButton = new System.Windows.Forms.Button();
			this.moveValidPathButton = new System.Windows.Forms.Button();
			this.moveBackInvalidPathButton = new System.Windows.Forms.Button();
			this.deleteInvalidPathButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pathTextBox
			// 
			this.pathTextBox.Location = new System.Drawing.Point(12, 24);
			this.pathTextBox.Name = "pathTextBox";
			this.pathTextBox.Size = new System.Drawing.Size(287, 20);
			this.pathTextBox.TabIndex = 0;
			// 
			// addPathButton
			// 
			this.addPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addPathButton.Location = new System.Drawing.Point(323, 22);
			this.addPathButton.Name = "addPathButton";
			this.addPathButton.Size = new System.Drawing.Size(129, 23);
			this.addPathButton.TabIndex = 1;
			this.addPathButton.Text = "Добавить";
			this.addPathButton.UseVisualStyleBackColor = true;
			this.addPathButton.Click += new System.EventHandler(this.ConfirmButtonClick);
			// 
			// validPathLv
			// 
			this.validPathLv.FormattingEnabled = true;
			this.validPathLv.Location = new System.Drawing.Point(12, 96);
			this.validPathLv.Name = "validPathLv";
			this.validPathLv.Size = new System.Drawing.Size(201, 95);
			this.validPathLv.TabIndex = 2;
			// 
			// invalidPathLv
			// 
			this.invalidPathLv.FormattingEnabled = true;
			this.invalidPathLv.Location = new System.Drawing.Point(251, 96);
			this.invalidPathLv.Name = "invalidPathLv";
			this.invalidPathLv.Size = new System.Drawing.Size(201, 95);
			this.invalidPathLv.TabIndex = 3;
			// 
			// deleteValidPathButton
			// 
			this.deleteValidPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deleteValidPathButton.Location = new System.Drawing.Point(12, 197);
			this.deleteValidPathButton.Name = "deleteValidPathButton";
			this.deleteValidPathButton.Size = new System.Drawing.Size(92, 23);
			this.deleteValidPathButton.TabIndex = 4;
			this.deleteValidPathButton.Text = "Удалить";
			this.deleteValidPathButton.UseVisualStyleBackColor = true;
			this.deleteValidPathButton.Click += new System.EventHandler(this.ValidLvRemove);
			// 
			// moveValidPathButton
			// 
			this.moveValidPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.moveValidPathButton.Location = new System.Drawing.Point(110, 197);
			this.moveValidPathButton.Name = "moveValidPathButton";
			this.moveValidPathButton.Size = new System.Drawing.Size(103, 23);
			this.moveValidPathButton.TabIndex = 5;
			this.moveValidPathButton.Text = "Переместить";
			this.moveValidPathButton.UseVisualStyleBackColor = true;
			this.moveValidPathButton.Click += new System.EventHandler(this.ValidLvMove);
			// 
			// moveBackInvalidPathButton
			// 
			this.moveBackInvalidPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.moveBackInvalidPathButton.Location = new System.Drawing.Point(351, 197);
			this.moveBackInvalidPathButton.Name = "moveBackInvalidPathButton";
			this.moveBackInvalidPathButton.Size = new System.Drawing.Size(101, 23);
			this.moveBackInvalidPathButton.TabIndex = 7;
			this.moveBackInvalidPathButton.Text = "Вернуть";
			this.moveBackInvalidPathButton.UseVisualStyleBackColor = true;
			this.moveBackInvalidPathButton.Click += new System.EventHandler(this.InvalidLvReturn);
			// 
			// deleteInvalidPathButton
			// 
			this.deleteInvalidPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deleteInvalidPathButton.Location = new System.Drawing.Point(251, 197);
			this.deleteInvalidPathButton.Name = "deleteInvalidPathButton";
			this.deleteInvalidPathButton.Size = new System.Drawing.Size(92, 23);
			this.deleteInvalidPathButton.TabIndex = 6;
			this.deleteInvalidPathButton.Text = "Удалить";
			this.deleteInvalidPathButton.UseVisualStyleBackColor = true;
			this.deleteInvalidPathButton.Click += new System.EventHandler(this.InvalidLvRemove);
			// 
			// FilePathTesterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 265);
			this.Controls.Add(this.moveBackInvalidPathButton);
			this.Controls.Add(this.deleteInvalidPathButton);
			this.Controls.Add(this.moveValidPathButton);
			this.Controls.Add(this.deleteValidPathButton);
			this.Controls.Add(this.invalidPathLv);
			this.Controls.Add(this.validPathLv);
			this.Controls.Add(this.addPathButton);
			this.Controls.Add(this.pathTextBox);
			this.Name = "FilePathTesterForm";
			this.Text = "FilePathTester";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox pathTextBox;
		private System.Windows.Forms.Button addPathButton;
		private System.Windows.Forms.ListBox validPathLv;
		private System.Windows.Forms.ListBox invalidPathLv;
		private System.Windows.Forms.Button deleteValidPathButton;
		private System.Windows.Forms.Button moveValidPathButton;
		private System.Windows.Forms.Button moveBackInvalidPathButton;
		private System.Windows.Forms.Button deleteInvalidPathButton;
	}
}

