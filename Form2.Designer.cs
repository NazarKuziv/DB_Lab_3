namespace DB_Lab_3
{
    partial class Form2
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
            this.Log_in_button = new System.Windows.Forms.Button();
            this.Log_up_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Log_in_button
            // 
            this.Log_in_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_in_button.Location = new System.Drawing.Point(32, 117);
            this.Log_in_button.Name = "Log_in_button";
            this.Log_in_button.Size = new System.Drawing.Size(100, 30);
            this.Log_in_button.TabIndex = 0;
            this.Log_in_button.Text = "Log in";
            this.Log_in_button.UseVisualStyleBackColor = true;
            this.Log_in_button.Click += new System.EventHandler(this.Log_in_button_Click);
            // 
            // Log_up_button
            // 
            this.Log_up_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_up_button.Location = new System.Drawing.Point(154, 117);
            this.Log_up_button.Name = "Log_up_button";
            this.Log_up_button.Size = new System.Drawing.Size(100, 30);
            this.Log_up_button.TabIndex = 1;
            this.Log_up_button.Text = "Log up";
            this.Log_up_button.UseVisualStyleBackColor = true;
            this.Log_up_button.Click += new System.EventHandler(this.Log_up_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // userNameTb
            // 
            this.userNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameTb.Location = new System.Drawing.Point(107, 20);
            this.userNameTb.Name = "userNameTb";
            this.userNameTb.Size = new System.Drawing.Size(161, 26);
            this.userNameTb.TabIndex = 4;
            // 
            // passwordTb
            // 
            this.passwordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTb.Location = new System.Drawing.Point(107, 65);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(161, 26);
            this.passwordTb.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 161);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.userNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Log_up_button);
            this.Controls.Add(this.Log_in_button);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Log_in_button;
        private System.Windows.Forms.Button Log_up_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTb;
        private System.Windows.Forms.TextBox passwordTb;
    }
}