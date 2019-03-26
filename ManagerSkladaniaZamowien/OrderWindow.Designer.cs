namespace OrderSubmissionManager
{
    partial class OrderWindow
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
            this.AddItemButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveToXML_Button = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data urodzenia";
            // 
            // AddItemButton
            // 
            this.AddItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddItemButton.Location = new System.Drawing.Point(29, 144);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(138, 32);
            this.AddItemButton.TabIndex = 3;
            this.AddItemButton.Text = "Dodaj produkt";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.Location = new System.Drawing.Point(184, 144);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(133, 32);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Usuń produkt";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChangeButton.Location = new System.Drawing.Point(339, 144);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChangeButton.Size = new System.Drawing.Size(132, 32);
            this.ChangeButton.TabIndex = 5;
            this.ChangeButton.Text = "Zmień produkt";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Location = new System.Drawing.Point(20, 204);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.ReadOnly = true;
            this.OrderDataGridView.Size = new System.Drawing.Size(568, 274);
            this.OrderDataGridView.TabIndex = 6;
            // 
            // SaveToXML_Button
            // 
            this.SaveToXML_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveToXML_Button.Location = new System.Drawing.Point(456, 493);
            this.SaveToXML_Button.Name = "SaveToXML_Button";
            this.SaveToXML_Button.Size = new System.Drawing.Size(132, 32);
            this.SaveToXML_Button.TabIndex = 7;
            this.SaveToXML_Button.Text = "Zapisz do XML";
            this.SaveToXML_Button.UseVisualStyleBackColor = true;
            this.SaveToXML_Button.Click += new System.EventHandler(this.SaveToXML_Button_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(248, 493);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(192, 32);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Zapisz do bazy danych";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F);
            this.NameTextBox.Location = new System.Drawing.Point(231, 11);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(357, 30);
            this.NameTextBox.TabIndex = 9;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F);
            this.SurnameTextBox.Location = new System.Drawing.Point(231, 51);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(357, 30);
            this.SurnameTextBox.TabIndex = 10;
            // 
            // BirthdayTextBox
            // 
            this.BirthdayTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F);
            this.BirthdayTextBox.Location = new System.Drawing.Point(231, 92);
            this.BirthdayTextBox.Name = "BirthdayTextBox";
            this.BirthdayTextBox.Size = new System.Drawing.Size(357, 30);
            this.BirthdayTextBox.TabIndex = 11;
            // 
            // OrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 537);
            this.Controls.Add(this.BirthdayTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SaveToXML_Button);
            this.Controls.Add(this.OrderDataGridView);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderWindow";
            this.Text = "Nowe zamówienie";
            this.Load += new System.EventHandler(this.OrderWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.Button SaveToXML_Button;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox BirthdayTextBox;
    }
}