namespace Lab4
{
    partial class QualificationForm
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
            this.GpaText = new System.Windows.Forms.Label();
            this.GPAInput = new System.Windows.Forms.TextBox();
            this.TestScoreInput = new System.Windows.Forms.TextBox();
            this.AdmissionText = new System.Windows.Forms.Label();
            this.QualificationOutput = new System.Windows.Forms.Label();
            this.MainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AcceptOutput = new System.Windows.Forms.Label();
            this.RejectOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GpaText
            // 
            this.GpaText.Location = new System.Drawing.Point(2, 21);
            this.GpaText.Name = "GpaText";
            this.GpaText.Size = new System.Drawing.Size(140, 23);
            this.GpaText.TabIndex = 0;
            this.GpaText.Text = "Enter GPA (0.0 - 4.0) :";
            // 
            // GPAInput
            // 
            this.GPAInput.Location = new System.Drawing.Point(208, 18);
            this.GPAInput.Name = "GPAInput";
            this.GPAInput.Size = new System.Drawing.Size(100, 20);
            this.GPAInput.TabIndex = 1;
            // 
            // TestScoreInput
            // 
            this.TestScoreInput.Location = new System.Drawing.Point(208, 69);
            this.TestScoreInput.Name = "TestScoreInput";
            this.TestScoreInput.Size = new System.Drawing.Size(100, 20);
            this.TestScoreInput.TabIndex = 2;
            // 
            // AdmissionText
            // 
            this.AdmissionText.Location = new System.Drawing.Point(2, 72);
            this.AdmissionText.Name = "AdmissionText";
            this.AdmissionText.Size = new System.Drawing.Size(187, 23);
            this.AdmissionText.TabIndex = 3;
            this.AdmissionText.Text = "Enter admission test score ( 0 - 100 ) :";
            // 
            // QualificationOutput
            // 
            this.QualificationOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.QualificationOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QualificationOutput.Location = new System.Drawing.Point(208, 118);
            this.QualificationOutput.Name = "QualificationOutput";
            this.QualificationOutput.Size = new System.Drawing.Size(100, 34);
            this.QualificationOutput.TabIndex = 4;
            this.QualificationOutput.Click += new System.EventHandler(this.QualificationOutput_Click);
            // 
            // MainButton
            // 
            this.MainButton.Location = new System.Drawing.Point(12, 98);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(170, 54);
            this.MainButton.TabIndex = 5;
            this.MainButton.Text = "Do You Qualify?";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Accept Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reject Count";
            // 
            // AcceptOutput
            // 
            this.AcceptOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AcceptOutput.Location = new System.Drawing.Point(80, 178);
            this.AcceptOutput.Name = "AcceptOutput";
            this.AcceptOutput.Size = new System.Drawing.Size(62, 23);
            this.AcceptOutput.TabIndex = 8;
            // 
            // RejectOutput
            // 
            this.RejectOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RejectOutput.Location = new System.Drawing.Point(80, 218);
            this.RejectOutput.Name = "RejectOutput";
            this.RejectOutput.Size = new System.Drawing.Size(62, 23);
            this.RejectOutput.TabIndex = 9;
            // 
            // QualificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 260);
            this.Controls.Add(this.RejectOutput);
            this.Controls.Add(this.AcceptOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.QualificationOutput);
            this.Controls.Add(this.AdmissionText);
            this.Controls.Add(this.TestScoreInput);
            this.Controls.Add(this.GPAInput);
            this.Controls.Add(this.GpaText);
            this.Name = "QualificationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GpaText;
        private System.Windows.Forms.TextBox GPAInput;
        private System.Windows.Forms.TextBox TestScoreInput;
        private System.Windows.Forms.Label AdmissionText;
        private System.Windows.Forms.Label QualificationOutput;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AcceptOutput;
        private System.Windows.Forms.Label RejectOutput;
    }
}

