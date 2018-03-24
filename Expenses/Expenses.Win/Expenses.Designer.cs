namespace Expenses.Win
{
	partial class Expenses
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
			this.expensePanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// expensePanel
			// 
			this.expensePanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.expensePanel.Location = new System.Drawing.Point(0, 0);
			this.expensePanel.Name = "expensePanel";
			this.expensePanel.Size = new System.Drawing.Size(468, 717);
			this.expensePanel.TabIndex = 0;
			// 
			// Expenses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1443, 717);
			this.Controls.Add(this.expensePanel);
			this.Name = "Expenses";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel expensePanel;
	}
}

