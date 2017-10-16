namespace UppApplication.Forms
{
    partial class EmailForm
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
            this.tboxTo = new System.Windows.Forms.TextBox();
            this.tboxSubject = new System.Windows.Forms.TextBox();
            this.tboxBody = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxTo
            // 
            this.tboxTo.Location = new System.Drawing.Point(190, 68);
            this.tboxTo.Name = "tboxTo";
            this.tboxTo.Size = new System.Drawing.Size(272, 20);
            this.tboxTo.TabIndex = 0;
            this.tboxTo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tboxSubject
            // 
            this.tboxSubject.Location = new System.Drawing.Point(190, 128);
            this.tboxSubject.Name = "tboxSubject";
            this.tboxSubject.Size = new System.Drawing.Size(272, 20);
            this.tboxSubject.TabIndex = 1;
            // 
            // tboxBody
            // 
            this.tboxBody.Location = new System.Drawing.Point(190, 227);
            this.tboxBody.Name = "tboxBody";
            this.tboxBody.Size = new System.Drawing.Size(263, 185);
            this.tboxBody.TabIndex = 2;
            this.tboxBody.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Za:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naslov:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tekst:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(190, 463);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(263, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Posalji";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 574);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxBody);
            this.Controls.Add(this.tboxSubject);
            this.Controls.Add(this.tboxTo);
            this.Name = "EmailForm";
            this.Text = "EmailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxTo;
        private System.Windows.Forms.TextBox tboxSubject;
        private System.Windows.Forms.RichTextBox tboxBody;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
    }
}