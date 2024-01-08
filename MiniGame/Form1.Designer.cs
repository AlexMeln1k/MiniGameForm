namespace MiniGame
{
    partial class frmGame
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.lbl32 = new System.Windows.Forms.Label();
            this.lblImpossibleMode = new System.Windows.Forms.CheckBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.ddlCustomAttempts = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(46, 97);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 90);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(142, 97);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 90);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(238, 97);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 90);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(46, 193);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 90);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(142, 193);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 90);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(238, 193);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 90);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(46, 289);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 90);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(142, 289);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 90);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(238, 289);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 90);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // lbl32
            // 
            this.lbl32.AutoSize = true;
            this.lbl32.Location = new System.Drawing.Point(129, 21);
            this.lbl32.Name = "lbl32";
            this.lbl32.Size = new System.Drawing.Size(51, 13);
            this.lbl32.TabIndex = 9;
            this.lbl32.Text = "Attempts:";
            // 
            // lblImpossibleMode
            // 
            this.lblImpossibleMode.AutoSize = true;
            this.lblImpossibleMode.Location = new System.Drawing.Point(274, 20);
            this.lblImpossibleMode.Name = "lblImpossibleMode";
            this.lblImpossibleMode.Size = new System.Drawing.Size(79, 17);
            this.lblImpossibleMode.TabIndex = 10;
            this.lblImpossibleMode.Text = "Hard Mode";
            this.lblImpossibleMode.UseVisualStyleBackColor = true;
            this.lblImpossibleMode.CheckedChanged += new System.EventHandler(this.lblImpossibleMode_CheckedChanged);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(95, 31);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "Start New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Best Item:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(191, 69);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 13);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "<Price>";
            // 
            // ddlCustomAttempts
            // 
            this.ddlCustomAttempts.FormattingEnabled = true;
            this.ddlCustomAttempts.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.ddlCustomAttempts.Location = new System.Drawing.Point(186, 18);
            this.ddlCustomAttempts.Name = "ddlCustomAttempts";
            this.ddlCustomAttempts.Size = new System.Drawing.Size(46, 21);
            this.ddlCustomAttempts.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 49);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 31);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 408);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ddlCustomAttempts);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblImpossibleMode);
            this.Controls.Add(this.lbl32);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 39);
            this.Name = "frmGame";
            this.Text = "Mini Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Label lbl32;
        private System.Windows.Forms.CheckBox lblImpossibleMode;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox ddlCustomAttempts;
        private System.Windows.Forms.Button btnClose;
    }
}

