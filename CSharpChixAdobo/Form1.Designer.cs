namespace WindowsFormsApplication1
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblYouWillNeed = new System.Windows.Forms.Label();
            this.lblSweetOnion = new System.Windows.Forms.Label();
            this.lblGarlicCloves = new System.Windows.Forms.Label();
            this.lblSoySauce = new System.Windows.Forms.Label();
            this.lblVinegar = new System.Windows.Forms.Label();
            this.lblPounds = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(191, 27);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 40);
            this.txtWeight.TabIndex = 0;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtWeight, "Enter the Chicken weight (#.##)");
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculate.BackgroundImage")));
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalculate.Location = new System.Drawing.Point(222, 74);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCalculate.Size = new System.Drawing.Size(39, 38);
            this.btnCalculate.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnCalculate, "Press to Calculate");
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(159, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(170, 12);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Enter Weight of the Chicken (#.##)";
            // 
            // lblYouWillNeed
            // 
            this.lblYouWillNeed.AutoSize = true;
            this.lblYouWillNeed.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouWillNeed.Location = new System.Drawing.Point(30, 124);
            this.lblYouWillNeed.Name = "lblYouWillNeed";
            this.lblYouWillNeed.Size = new System.Drawing.Size(113, 16);
            this.lblYouWillNeed.TabIndex = 4;
            this.lblYouWillNeed.Text = "You Will Need:";
            // 
            // lblSweetOnion
            // 
            this.lblSweetOnion.AutoSize = true;
            this.lblSweetOnion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSweetOnion.Location = new System.Drawing.Point(9, 149);
            this.lblSweetOnion.Name = "lblSweetOnion";
            this.lblSweetOnion.Size = new System.Drawing.Size(0, 18);
            this.lblSweetOnion.TabIndex = 10;
            // 
            // lblGarlicCloves
            // 
            this.lblGarlicCloves.AutoSize = true;
            this.lblGarlicCloves.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarlicCloves.Location = new System.Drawing.Point(9, 203);
            this.lblGarlicCloves.Name = "lblGarlicCloves";
            this.lblGarlicCloves.Size = new System.Drawing.Size(0, 18);
            this.lblGarlicCloves.TabIndex = 6;
            // 
            // lblSoySauce
            // 
            this.lblSoySauce.AutoSize = true;
            this.lblSoySauce.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoySauce.Location = new System.Drawing.Point(9, 167);
            this.lblSoySauce.Name = "lblSoySauce";
            this.lblSoySauce.Size = new System.Drawing.Size(0, 18);
            this.lblSoySauce.TabIndex = 7;
            // 
            // lblVinegar
            // 
            this.lblVinegar.AutoSize = true;
            this.lblVinegar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVinegar.Location = new System.Drawing.Point(9, 185);
            this.lblVinegar.Name = "lblVinegar";
            this.lblVinegar.Size = new System.Drawing.Size(0, 18);
            this.lblVinegar.TabIndex = 8;
            // 
            // lblPounds
            // 
            this.lblPounds.AutoSize = true;
            this.lblPounds.Location = new System.Drawing.Point(292, 52);
            this.lblPounds.Name = "lblPounds";
            this.lblPounds.Size = new System.Drawing.Size(26, 13);
            this.lblPounds.TabIndex = 11;
            this.lblPounds.Text = "(lbs)";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Aqua;
            this.btnClear.Location = new System.Drawing.Point(204, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Start Over";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(138, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "All Done!";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 243);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 100);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._10;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(10, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 106);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(350, 385);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPounds);
            this.Controls.Add(this.lblVinegar);
            this.Controls.Add(this.lblSoySauce);
            this.Controls.Add(this.lblGarlicCloves);
            this.Controls.Add(this.lblSweetOnion);
            this.Controls.Add(this.lblYouWillNeed);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWeight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chicken Adobo Calculator 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblYouWillNeed;
        private System.Windows.Forms.Label lblSweetOnion;
        private System.Windows.Forms.Label lblGarlicCloves;
        private System.Windows.Forms.Label lblSoySauce;
        private System.Windows.Forms.Label lblVinegar;
        private System.Windows.Forms.Label lblPounds;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

