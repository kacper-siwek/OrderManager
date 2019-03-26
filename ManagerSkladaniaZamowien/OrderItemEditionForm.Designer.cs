namespace OrderSubmissionManager
{
    partial class OrderItemEditionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa produktu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ilość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cena";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F);
            this.ItemNameTextBox.Location = new System.Drawing.Point(268, 28);
            this.ItemNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(356, 36);
            this.ItemNameTextBox.TabIndex = 4;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F);
            this.AmountTextBox.Location = new System.Drawing.Point(268, 100);
            this.AmountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(356, 36);
            this.AmountTextBox.TabIndex = 5;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F);
            this.PriceTextBox.Location = new System.Drawing.Point(268, 165);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(356, 36);
            this.PriceTextBox.TabIndex = 6;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubmitButton.Location = new System.Drawing.Point(449, 274);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(176, 39);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Dodaj";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitButton.Location = new System.Drawing.Point(56, 274);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(176, 39);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Wyjście";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OrderItemEditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 347);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderItemEditionForm";
            this.Text = "Dodawanie/edycja produktów";
            this.Load += new System.EventHandler(this.OrderItemEditionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ExitButton;
    }
}