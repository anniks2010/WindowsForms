namespace CurrencyConverter
{
    partial class Form1
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
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.fromcombo1 = new System.Windows.Forms.ComboBox();
            this.tocombo2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.display_txt = new System.Windows.Forms.Label();
            this.conv_btn = new System.Windows.Forms.Button();
            this.display_date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Amount";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(204, 58);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(100, 20);
            this.amount_txt.TabIndex = 1;
            this.amount_txt.TextChanged += new System.EventHandler(this.Amount_txt_TextChanged);
            // 
            // fromcombo1
            // 
            this.fromcombo1.FormattingEnabled = true;
            this.fromcombo1.Items.AddRange(new object[] {
            "AUD",
            "SEK",
            "USD",
            "RUB",
            "PLN"});
            this.fromcombo1.Location = new System.Drawing.Point(204, 107);
            this.fromcombo1.Name = "fromcombo1";
            this.fromcombo1.Size = new System.Drawing.Size(121, 21);
            this.fromcombo1.TabIndex = 2;
            // 
            // tocombo2
            // 
            this.tocombo2.FormattingEnabled = true;
            this.tocombo2.Items.AddRange(new object[] {
            "EUR"});
            this.tocombo2.Location = new System.Drawing.Point(204, 149);
            this.tocombo2.Name = "tocombo2";
            this.tocombo2.Size = new System.Drawing.Size(121, 21);
            this.tocombo2.TabIndex = 3;
            this.tocombo2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Convert From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Convert To";
            // 
            // display_txt
            // 
            this.display_txt.AutoSize = true;
            this.display_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.display_txt.Location = new System.Drawing.Point(52, 189);
            this.display_txt.Name = "display_txt";
            this.display_txt.Size = new System.Drawing.Size(115, 13);
            this.display_txt.TabIndex = 6;
            this.display_txt.Text = "Converted Amount:";
            // 
            // conv_btn
            // 
            this.conv_btn.Location = new System.Drawing.Point(330, 54);
            this.conv_btn.Name = "conv_btn";
            this.conv_btn.Size = new System.Drawing.Size(75, 23);
            this.conv_btn.TabIndex = 7;
            this.conv_btn.Text = "Convert";
            this.conv_btn.UseVisualStyleBackColor = true;
            this.conv_btn.Click += new System.EventHandler(this.Conv_btn_Click);
            // 
            // display_date
            // 
            this.display_date.AutoSize = true;
            this.display_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.display_date.Location = new System.Drawing.Point(52, 216);
            this.display_date.Name = "display_date";
            this.display_date.Size = new System.Drawing.Size(38, 13);
            this.display_date.TabIndex = 9;
            this.display_date.Text = "Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(472, 259);
            this.Controls.Add(this.display_date);
            this.Controls.Add(this.conv_btn);
            this.Controls.Add(this.display_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tocombo2);
            this.Controls.Add(this.fromcombo1);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foreign currency caclulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.ComboBox fromcombo1;
        private System.Windows.Forms.ComboBox tocombo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label display_txt;
        private System.Windows.Forms.Button conv_btn;
        private System.Windows.Forms.Label display_date;
    }
}

