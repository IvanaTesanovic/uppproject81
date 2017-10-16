namespace UppApplication.Forms
{
    partial class ComissionForm
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
            this.cboxMentor = new System.Windows.Forms.CheckBox();
            this.numComission = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numComission)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxMentor
            // 
            this.cboxMentor.AutoSize = true;
            this.cboxMentor.Location = new System.Drawing.Point(65, 53);
            this.cboxMentor.Name = "cboxMentor";
            this.cboxMentor.Size = new System.Drawing.Size(168, 17);
            this.cboxMentor.TabIndex = 0;
            this.cboxMentor.Text = "Mentor sprecen da prisustvuje";
            this.cboxMentor.UseVisualStyleBackColor = true;
            // 
            // numComission
            // 
            this.numComission.Location = new System.Drawing.Point(321, 119);
            this.numComission.Name = "numComission";
            this.numComission.Size = new System.Drawing.Size(120, 20);
            this.numComission.TabIndex = 1;
            this.numComission.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj clanova komisije koji ne moze da prisustvuje:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(68, 189);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(165, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "button1";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // ComissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 285);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numComission);
            this.Controls.Add(this.cboxMentor);
            this.Name = "ComissionForm";
            this.Text = "ComissionForm";
            ((System.ComponentModel.ISupportInitialize)(this.numComission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cboxMentor;
        private System.Windows.Forms.NumericUpDown numComission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
    }
}