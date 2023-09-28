namespace CashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.doenerAmountLabel = new System.Windows.Forms.Label();
            this.friesAmountLabel = new System.Windows.Forms.Label();
            this.drinksAmountLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxlabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.calculateCostButton = new System.Windows.Forms.Button();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.doenerInput = new System.Windows.Forms.TextBox();
            this.pommesInput = new System.Windows.Forms.TextBox();
            this.drinksInput = new System.Windows.Forms.TextBox();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Font = new System.Drawing.Font("Poor Richard", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(1, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(694, 114);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "         DÖNER KEBAB";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // doenerAmountLabel
            // 
            this.doenerAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.doenerAmountLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doenerAmountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.doenerAmountLabel.Location = new System.Drawing.Point(26, 138);
            this.doenerAmountLabel.Name = "doenerAmountLabel";
            this.doenerAmountLabel.Size = new System.Drawing.Size(227, 47);
            this.doenerAmountLabel.TabIndex = 1;
            this.doenerAmountLabel.Text = "Anzahl der Döner:";
            // 
            // friesAmountLabel
            // 
            this.friesAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.friesAmountLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesAmountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.friesAmountLabel.Location = new System.Drawing.Point(26, 172);
            this.friesAmountLabel.Name = "friesAmountLabel";
            this.friesAmountLabel.Size = new System.Drawing.Size(227, 44);
            this.friesAmountLabel.TabIndex = 2;
            this.friesAmountLabel.Text = "Anzahl der Pommes:";
            // 
            // drinksAmountLabel
            // 
            this.drinksAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.drinksAmountLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksAmountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.drinksAmountLabel.Location = new System.Drawing.Point(26, 204);
            this.drinksAmountLabel.Name = "drinksAmountLabel";
            this.drinksAmountLabel.Size = new System.Drawing.Size(234, 34);
            this.drinksAmountLabel.TabIndex = 3;
            this.drinksAmountLabel.Text = "Anzahl der Coladosen:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subtotalLabel.Location = new System.Drawing.Point(12, 313);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(204, 22);
            this.subtotalLabel.TabIndex = 4;
            this.subtotalLabel.Text = "Brutto:";
            // 
            // taxlabel
            // 
            this.taxlabel.BackColor = System.Drawing.Color.Transparent;
            this.taxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.taxlabel.Location = new System.Drawing.Point(12, 347);
            this.taxlabel.Name = "taxlabel";
            this.taxlabel.Size = new System.Drawing.Size(204, 22);
            this.taxlabel.TabIndex = 5;
            this.taxlabel.Text = "Mehrwertsteuer:";
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalLabel.Location = new System.Drawing.Point(12, 379);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(204, 22);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Netto:";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tenderedLabel.Location = new System.Drawing.Point(17, 444);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(199, 22);
            this.tenderedLabel.TabIndex = 8;
            this.tenderedLabel.Text = "Bezahlt:";
            // 
            // calculateCostButton
            // 
            this.calculateCostButton.BackColor = System.Drawing.Color.Black;
            this.calculateCostButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateCostButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateCostButton.Location = new System.Drawing.Point(96, 259);
            this.calculateCostButton.Name = "calculateCostButton";
            this.calculateCostButton.Size = new System.Drawing.Size(195, 36);
            this.calculateCostButton.TabIndex = 9;
            this.calculateCostButton.Text = "Preis Berechnen";
            this.calculateCostButton.UseVisualStyleBackColor = false;
            this.calculateCostButton.Click += new System.EventHandler(this.calculateCostButton_Click);
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.Color.Black;
            this.calculateChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateChangeButton.Location = new System.Drawing.Point(96, 490);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(195, 37);
            this.calculateChangeButton.TabIndex = 10;
            this.calculateChangeButton.Text = "Rückgeld Berechnen";
            this.calculateChangeButton.UseVisualStyleBackColor = false;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeLabel.Location = new System.Drawing.Point(12, 546);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(204, 26);
            this.changeLabel.TabIndex = 11;
            this.changeLabel.Text = "Wechselgeld:";
            // 
            // doenerInput
            // 
            this.doenerInput.Location = new System.Drawing.Point(259, 140);
            this.doenerInput.Name = "doenerInput";
            this.doenerInput.Size = new System.Drawing.Size(86, 22);
            this.doenerInput.TabIndex = 12;
            // 
            // pommesInput
            // 
            this.pommesInput.Location = new System.Drawing.Point(259, 178);
            this.pommesInput.Name = "pommesInput";
            this.pommesInput.Size = new System.Drawing.Size(86, 22);
            this.pommesInput.TabIndex = 13;
            // 
            // drinksInput
            // 
            this.drinksInput.Location = new System.Drawing.Point(259, 210);
            this.drinksInput.Name = "drinksInput";
            this.drinksInput.Size = new System.Drawing.Size(86, 22);
            this.drinksInput.TabIndex = 14;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.BackColor = System.Drawing.Color.Black;
            this.printReceiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.printReceiptButton.Location = new System.Drawing.Point(96, 598);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(195, 72);
            this.printReceiptButton.TabIndex = 15;
            this.printReceiptButton.Text = "Kassenbon ausdrucken";
            this.printReceiptButton.UseVisualStyleBackColor = false;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.SystemColors.Control;
            this.subtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(259, 313);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(86, 22);
            this.subtotalOutput.TabIndex = 16;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.SystemColors.Control;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(259, 347);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(86, 22);
            this.taxOutput.TabIndex = 17;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.Control;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(259, 379);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(86, 22);
            this.totalOutput.TabIndex = 18;
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.SystemColors.Control;
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(259, 546);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(86, 26);
            this.changeOutput.TabIndex = 20;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(259, 444);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(86, 22);
            this.tenderedInput.TabIndex = 21;
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(351, 140);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(0, 25);
            this.receiptLabel.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(452, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(681, 698);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.drinksInput);
            this.Controls.Add(this.pommesInput);
            this.Controls.Add(this.doenerInput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.calculateCostButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxlabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.drinksAmountLabel);
            this.Controls.Add(this.friesAmountLabel);
            this.Controls.Add(this.doenerAmountLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Doener Kasse";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label doenerAmountLabel;
        private System.Windows.Forms.Label friesAmountLabel;
        private System.Windows.Forms.Label drinksAmountLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxlabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button calculateCostButton;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.TextBox doenerInput;
        private System.Windows.Forms.TextBox pommesInput;
        private System.Windows.Forms.TextBox drinksInput;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

