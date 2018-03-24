namespace Expenses.Win.Views.ExpenseCategoryList
{
	partial class ExpenseCategoryList
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.addButton = new System.Windows.Forms.Button();
			this.expenseCategoriesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.addButton);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(301, 48);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(3, 3);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(121, 39);
			this.addButton.TabIndex = 0;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			// 
			// expenseCategoriesFlowPanel
			// 
			this.expenseCategoriesFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.expenseCategoriesFlowPanel.Location = new System.Drawing.Point(0, 48);
			this.expenseCategoriesFlowPanel.Name = "expenseCategoriesFlowPanel";
			this.expenseCategoriesFlowPanel.Size = new System.Drawing.Size(301, 217);
			this.expenseCategoriesFlowPanel.TabIndex = 2;
			// 
			// ExpenseCategoryList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.expenseCategoriesFlowPanel);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "ExpenseCategoryList";
			this.Size = new System.Drawing.Size(301, 265);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.FlowLayoutPanel expenseCategoriesFlowPanel;
	}
}
