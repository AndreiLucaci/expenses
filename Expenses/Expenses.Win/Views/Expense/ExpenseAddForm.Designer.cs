namespace Expenses.Win.Views.Expense
{
	partial class ExpenseAddForm
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
			this.titleLbl = new System.Windows.Forms.Label();
			this.titleTxt = new System.Windows.Forms.TextBox();
			this.descriptionLbl = new System.Windows.Forms.Label();
			this.descriptionTxt = new System.Windows.Forms.RichTextBox();
			this.dateLbl = new System.Windows.Forms.Label();
			this.datePicker = new System.Windows.Forms.DateTimePicker();
			this.priceLbl = new System.Windows.Forms.Label();
			this.priceNumeric = new System.Windows.Forms.NumericUpDown();
			this.addBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.resetBtn = new System.Windows.Forms.Button();
			this.favouriteBtn = new System.Windows.Forms.Button();
			this.headerLbl = new System.Windows.Forms.Label();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.titleLbl);
			this.flowLayoutPanel1.Controls.Add(this.titleTxt);
			this.flowLayoutPanel1.Controls.Add(this.descriptionLbl);
			this.flowLayoutPanel1.Controls.Add(this.descriptionTxt);
			this.flowLayoutPanel1.Controls.Add(this.dateLbl);
			this.flowLayoutPanel1.Controls.Add(this.datePicker);
			this.flowLayoutPanel1.Controls.Add(this.priceLbl);
			this.flowLayoutPanel1.Controls.Add(this.priceNumeric);
			this.flowLayoutPanel1.Controls.Add(this.addBtn);
			this.flowLayoutPanel1.Controls.Add(this.cancelBtn);
			this.flowLayoutPanel1.Controls.Add(this.resetBtn);
			this.flowLayoutPanel1.Controls.Add(this.favouriteBtn);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 36);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(475, 433);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// titleLbl
			// 
			this.titleLbl.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLbl.Location = new System.Drawing.Point(3, 0);
			this.titleLbl.Name = "titleLbl";
			this.titleLbl.Size = new System.Drawing.Size(100, 23);
			this.titleLbl.TabIndex = 8;
			this.titleLbl.Text = "Title:";
			this.titleLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.titleLbl.Click += new System.EventHandler(this.nameLbl_Click);
			// 
			// titleTxt
			// 
			this.titleTxt.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleTxt.Location = new System.Drawing.Point(109, 3);
			this.titleTxt.Name = "titleTxt";
			this.titleTxt.Size = new System.Drawing.Size(350, 23);
			this.titleTxt.TabIndex = 0;
			// 
			// descriptionLbl
			// 
			this.descriptionLbl.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.descriptionLbl.Location = new System.Drawing.Point(3, 29);
			this.descriptionLbl.Name = "descriptionLbl";
			this.descriptionLbl.Size = new System.Drawing.Size(100, 99);
			this.descriptionLbl.TabIndex = 9;
			this.descriptionLbl.Text = "Description:";
			this.descriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.descriptionLbl.Click += new System.EventHandler(this.descriptionLbl_Click);
			// 
			// descriptionTxt
			// 
			this.descriptionTxt.Location = new System.Drawing.Point(109, 32);
			this.descriptionTxt.Name = "descriptionTxt";
			this.descriptionTxt.Size = new System.Drawing.Size(350, 96);
			this.descriptionTxt.TabIndex = 1;
			this.descriptionTxt.Text = "";
			// 
			// dateLbl
			// 
			this.dateLbl.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateLbl.Location = new System.Drawing.Point(3, 131);
			this.dateLbl.Name = "dateLbl";
			this.dateLbl.Size = new System.Drawing.Size(100, 26);
			this.dateLbl.TabIndex = 10;
			this.dateLbl.Text = "Date:";
			this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.dateLbl.Click += new System.EventHandler(this.dateLbl_Click);
			// 
			// datePicker
			// 
			this.datePicker.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datePicker.Location = new System.Drawing.Point(109, 134);
			this.datePicker.Name = "datePicker";
			this.datePicker.Size = new System.Drawing.Size(350, 23);
			this.datePicker.TabIndex = 2;
			// 
			// priceLbl
			// 
			this.priceLbl.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.priceLbl.Location = new System.Drawing.Point(3, 160);
			this.priceLbl.Name = "priceLbl";
			this.priceLbl.Size = new System.Drawing.Size(100, 26);
			this.priceLbl.TabIndex = 11;
			this.priceLbl.Text = "Price:";
			this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.priceLbl.Click += new System.EventHandler(this.priceLbl_Click);
			// 
			// priceNumeric
			// 
			this.priceNumeric.DecimalPlaces = 4;
			this.priceNumeric.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.priceNumeric.Location = new System.Drawing.Point(109, 163);
			this.priceNumeric.Name = "priceNumeric";
			this.priceNumeric.Size = new System.Drawing.Size(350, 23);
			this.priceNumeric.TabIndex = 3;
			this.priceNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.priceNumeric.ThousandsSeparator = true;
			// 
			// addBtn
			// 
			this.addBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBtn.Location = new System.Drawing.Point(3, 192);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(110, 43);
			this.addBtn.TabIndex = 4;
			this.addBtn.Text = "Save";
			this.addBtn.UseVisualStyleBackColor = true;
			// 
			// cancelBtn
			// 
			this.cancelBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelBtn.Location = new System.Drawing.Point(119, 192);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(110, 43);
			this.cancelBtn.TabIndex = 5;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			// 
			// resetBtn
			// 
			this.resetBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetBtn.Location = new System.Drawing.Point(235, 192);
			this.resetBtn.Name = "resetBtn";
			this.resetBtn.Size = new System.Drawing.Size(110, 43);
			this.resetBtn.TabIndex = 6;
			this.resetBtn.Text = "Reset";
			this.resetBtn.UseVisualStyleBackColor = true;
			this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
			// 
			// favouriteBtn
			// 
			this.favouriteBtn.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.favouriteBtn.Location = new System.Drawing.Point(351, 192);
			this.favouriteBtn.Name = "favouriteBtn";
			this.favouriteBtn.Size = new System.Drawing.Size(110, 43);
			this.favouriteBtn.TabIndex = 7;
			this.favouriteBtn.Tag = "Add to favourite";
			this.favouriteBtn.Text = "★";
			this.favouriteBtn.UseVisualStyleBackColor = true;
			// 
			// headerLbl
			// 
			this.headerLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.headerLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerLbl.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.headerLbl.Location = new System.Drawing.Point(0, 0);
			this.headerLbl.Name = "headerLbl";
			this.headerLbl.Size = new System.Drawing.Size(475, 36);
			this.headerLbl.TabIndex = 1;
			this.headerLbl.Text = "This is the add form";
			this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ExpenseAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.headerLbl);
			this.Name = "ExpenseAddForm";
			this.Size = new System.Drawing.Size(475, 469);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label titleLbl;
		private System.Windows.Forms.TextBox titleTxt;
		private System.Windows.Forms.Label descriptionLbl;
		private System.Windows.Forms.RichTextBox descriptionTxt;
		private System.Windows.Forms.Label dateLbl;
		private System.Windows.Forms.DateTimePicker datePicker;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button resetBtn;
		private System.Windows.Forms.Button favouriteBtn;
		private System.Windows.Forms.Label priceLbl;
		private System.Windows.Forms.NumericUpDown priceNumeric;
		private System.Windows.Forms.Label headerLbl;
	}
}
