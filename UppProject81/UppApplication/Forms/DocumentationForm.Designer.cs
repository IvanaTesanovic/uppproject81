namespace UppApplication.Forms
{
    partial class DocumentationForm
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
            this.tboxFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlDepartment = new System.Windows.Forms.ComboBox();
            this.cboxDocSubmitted = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxFirstname
            // 
            this.tboxFirstname.Location = new System.Drawing.Point(191, 66);
            this.tboxFirstname.Name = "tboxFirstname";
            this.tboxFirstname.Size = new System.Drawing.Size(183, 20);
            this.tboxFirstname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last name:";
            // 
            // tboxLastname
            // 
            this.tboxLastname.Location = new System.Drawing.Point(191, 114);
            this.tboxLastname.Name = "tboxLastname";
            this.tboxLastname.Size = new System.Drawing.Size(183, 20);
            this.tboxLastname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department:";
            // 
            // ddlDepartment
            // 
            this.ddlDepartment.FormattingEnabled = true;
            this.ddlDepartment.Location = new System.Drawing.Point(191, 161);
            this.ddlDepartment.Name = "ddlDepartment";
            this.ddlDepartment.Size = new System.Drawing.Size(183, 21);
            this.ddlDepartment.TabIndex = 6;
            // 
            // cboxDocSubmitted
            // 
            this.cboxDocSubmitted.AutoSize = true;
            this.cboxDocSubmitted.Location = new System.Drawing.Point(191, 210);
            this.cboxDocSubmitted.Name = "cboxDocSubmitted";
            this.cboxDocSubmitted.Size = new System.Drawing.Size(146, 17);
            this.cboxDocSubmitted.TabIndex = 7;
            this.cboxDocSubmitted.Text = "Documentation submitted";
            this.cboxDocSubmitted.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(191, 279);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(183, 23);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // DocumentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 419);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxDocSubmitted);
            this.Controls.Add(this.ddlDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxLastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxFirstname);
            this.Name = "DocumentationForm";
            this.Tag = "fef";
            this.Text = "DocumentationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlDepartment;
        private System.Windows.Forms.CheckBox cboxDocSubmitted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okButton;
    }
}