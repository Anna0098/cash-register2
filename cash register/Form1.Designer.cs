namespace cash_register
{
    partial class cashRegister
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
            this.calculateB = new System.Windows.Forms.Button();
            this.bread = new System.Windows.Forms.Label();
            this.milk = new System.Windows.Forms.Label();
            this.egg = new System.Windows.Forms.Label();
            this.inputMilk = new System.Windows.Forms.TextBox();
            this.inputEgg = new System.Windows.Forms.TextBox();
            this.inputBread = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.outputTotal = new System.Windows.Forms.Label();
            this.outputTax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateB
            // 
            this.calculateB.Location = new System.Drawing.Point(53, 244);
            this.calculateB.Name = "calculateB";
            this.calculateB.Size = new System.Drawing.Size(109, 26);
            this.calculateB.TabIndex = 0;
            this.calculateB.Text = "Calculate";
            this.calculateB.UseVisualStyleBackColor = true;
            this.calculateB.Click += new System.EventHandler(this.calculateB_Click);
            // 
            // bread
            // 
            this.bread.AutoSize = true;
            this.bread.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bread.Location = new System.Drawing.Point(12, 99);
            this.bread.Name = "bread";
            this.bread.Size = new System.Drawing.Size(94, 36);
            this.bread.TabIndex = 1;
            this.bread.Text = "Bread";
            this.bread.Click += new System.EventHandler(this.label1_Click);
            // 
            // milk
            // 
            this.milk.AutoSize = true;
            this.milk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milk.Location = new System.Drawing.Point(12, 136);
            this.milk.Name = "milk";
            this.milk.Size = new System.Drawing.Size(69, 36);
            this.milk.TabIndex = 2;
            this.milk.Text = "Milk";
            // 
            // egg
            // 
            this.egg.AutoSize = true;
            this.egg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egg.Location = new System.Drawing.Point(12, 178);
            this.egg.Name = "egg";
            this.egg.Size = new System.Drawing.Size(69, 36);
            this.egg.TabIndex = 3;
            this.egg.Text = "Egg";
            // 
            // inputMilk
            // 
            this.inputMilk.Location = new System.Drawing.Point(112, 149);
            this.inputMilk.Name = "inputMilk";
            this.inputMilk.Size = new System.Drawing.Size(50, 22);
            this.inputMilk.TabIndex = 4;
            // 
            // inputEgg
            // 
            this.inputEgg.Location = new System.Drawing.Point(112, 192);
            this.inputEgg.Name = "inputEgg";
            this.inputEgg.Size = new System.Drawing.Size(50, 22);
            this.inputEgg.TabIndex = 5;
            // 
            // inputBread
            // 
            this.inputBread.Location = new System.Drawing.Point(112, 112);
            this.inputBread.Name = "inputBread";
            this.inputBread.Size = new System.Drawing.Size(50, 22);
            this.inputBread.TabIndex = 6;
            this.inputBread.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(81, 292);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 16);
            this.output.TabIndex = 7;
            // 
            // outputTotal
            // 
            this.outputTotal.AutoSize = true;
            this.outputTotal.Location = new System.Drawing.Point(81, 355);
            this.outputTotal.Name = "outputTotal";
            this.outputTotal.Size = new System.Drawing.Size(0, 16);
            this.outputTotal.TabIndex = 8;
            // 
            // outputTax
            // 
            this.outputTax.AutoSize = true;
            this.outputTax.Location = new System.Drawing.Point(81, 326);
            this.outputTax.Name = "outputTax";
            this.outputTax.Size = new System.Drawing.Size(0, 16);
            this.outputTax.TabIndex = 9;
            this.outputTax.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.outputTax);
            this.Controls.Add(this.outputTotal);
            this.Controls.Add(this.output);
            this.Controls.Add(this.inputBread);
            this.Controls.Add(this.inputEgg);
            this.Controls.Add(this.inputMilk);
            this.Controls.Add(this.egg);
            this.Controls.Add(this.milk);
            this.Controls.Add(this.bread);
            this.Controls.Add(this.calculateB);
            this.Name = "cashRegister";
            this.Text = "Cash Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateB;
        private System.Windows.Forms.Label bread;
        private System.Windows.Forms.Label milk;
        private System.Windows.Forms.Label egg;
        private System.Windows.Forms.TextBox inputMilk;
        private System.Windows.Forms.TextBox inputEgg;
        private System.Windows.Forms.TextBox inputBread;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label outputTotal;
        private System.Windows.Forms.Label outputTax;
    }
}

