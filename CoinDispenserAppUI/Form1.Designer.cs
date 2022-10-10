
namespace CoinDispenserAppUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.amntTXT = new System.Windows.Forms.TextBox();
            this.submitBTN = new System.Windows.Forms.Button();
            this.msgLBL = new System.Windows.Forms.Label();
            this.changeGRPBOX = new System.Windows.Forms.GroupBox();
            this.rsltLBL = new System.Windows.Forms.Label();
            this.clrBTN = new System.Windows.Forms.Button();
            this.changeGRPBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Amount:";
            // 
            // amntTXT
            // 
            this.amntTXT.Location = new System.Drawing.Point(144, 25);
            this.amntTXT.Name = "amntTXT";
            this.amntTXT.Size = new System.Drawing.Size(135, 23);
            this.amntTXT.TabIndex = 1;
            // 
            // submitBTN
            // 
            this.submitBTN.Location = new System.Drawing.Point(297, 24);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(75, 23);
            this.submitBTN.TabIndex = 2;
            this.submitBTN.Text = "Submit";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_ClickAsync);
            // 
            // msgLBL
            // 
            this.msgLBL.AutoSize = true;
            this.msgLBL.ForeColor = System.Drawing.Color.Red;
            this.msgLBL.Location = new System.Drawing.Point(43, 59);
            this.msgLBL.Name = "msgLBL";
            this.msgLBL.Size = new System.Drawing.Size(0, 15);
            this.msgLBL.TabIndex = 3;
            // 
            // changeGRPBOX
            // 
            this.changeGRPBOX.Controls.Add(this.rsltLBL);
            this.changeGRPBOX.Location = new System.Drawing.Point(12, 121);
            this.changeGRPBOX.Name = "changeGRPBOX";
            this.changeGRPBOX.Size = new System.Drawing.Size(776, 307);
            this.changeGRPBOX.TabIndex = 4;
            this.changeGRPBOX.TabStop = false;
            this.changeGRPBOX.Text = "Change";
            // 
            // rsltLBL
            // 
            this.rsltLBL.AutoSize = true;
            this.rsltLBL.Location = new System.Drawing.Point(19, 28);
            this.rsltLBL.Name = "rsltLBL";
            this.rsltLBL.Size = new System.Drawing.Size(0, 15);
            this.rsltLBL.TabIndex = 0;
            // 
            // clrBTN
            // 
            this.clrBTN.Location = new System.Drawing.Point(378, 25);
            this.clrBTN.Name = "clrBTN";
            this.clrBTN.Size = new System.Drawing.Size(75, 23);
            this.clrBTN.TabIndex = 5;
            this.clrBTN.Text = "Clear";
            this.clrBTN.UseVisualStyleBackColor = true;
            this.clrBTN.Click += new System.EventHandler(this.clrBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clrBTN);
            this.Controls.Add(this.changeGRPBOX);
            this.Controls.Add(this.msgLBL);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.amntTXT);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Coin Dispenser Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.changeGRPBOX.ResumeLayout(false);
            this.changeGRPBOX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amntTXT;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Label msgLBL;
        private System.Windows.Forms.GroupBox changeGRPBOX;
        private System.Windows.Forms.Label rsltLBL;
        private System.Windows.Forms.Button clrBTN;
    }
}

