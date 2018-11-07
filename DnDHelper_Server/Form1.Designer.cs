namespace DnDHelper_Server
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
            this.Main_tbCntrl = new System.Windows.Forms.TabControl();
            this.Main_ConnectionData_tbPg = new System.Windows.Forms.TabPage();
            this.Main_Chat_tbPg = new System.Windows.Forms.TabPage();
            this.Main_Chat_History_txtBx = new System.Windows.Forms.TextBox();
            this.Main_Chat_Message_txtBx = new System.Windows.Forms.TextBox();
            this.Main_Chat_Send_btn = new System.Windows.Forms.Button();
            this.Main_tbCntrl.SuspendLayout();
            this.Main_Chat_tbPg.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_tbCntrl
            // 
            this.Main_tbCntrl.Controls.Add(this.Main_ConnectionData_tbPg);
            this.Main_tbCntrl.Controls.Add(this.Main_Chat_tbPg);
            this.Main_tbCntrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_tbCntrl.Font = new System.Drawing.Font("Coolsville", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_tbCntrl.Location = new System.Drawing.Point(0, 0);
            this.Main_tbCntrl.Margin = new System.Windows.Forms.Padding(8);
            this.Main_tbCntrl.Name = "Main_tbCntrl";
            this.Main_tbCntrl.SelectedIndex = 0;
            this.Main_tbCntrl.Size = new System.Drawing.Size(321, 374);
            this.Main_tbCntrl.TabIndex = 0;
            // 
            // Main_ConnectionData_tbPg
            // 
            this.Main_ConnectionData_tbPg.Location = new System.Drawing.Point(4, 28);
            this.Main_ConnectionData_tbPg.Name = "Main_ConnectionData_tbPg";
            this.Main_ConnectionData_tbPg.Padding = new System.Windows.Forms.Padding(3);
            this.Main_ConnectionData_tbPg.Size = new System.Drawing.Size(313, 342);
            this.Main_ConnectionData_tbPg.TabIndex = 0;
            this.Main_ConnectionData_tbPg.Text = "Connection";
            this.Main_ConnectionData_tbPg.UseVisualStyleBackColor = true;
            // 
            // Main_Chat_tbPg
            // 
            this.Main_Chat_tbPg.Controls.Add(this.Main_Chat_Send_btn);
            this.Main_Chat_tbPg.Controls.Add(this.Main_Chat_Message_txtBx);
            this.Main_Chat_tbPg.Controls.Add(this.Main_Chat_History_txtBx);
            this.Main_Chat_tbPg.Location = new System.Drawing.Point(4, 28);
            this.Main_Chat_tbPg.Name = "Main_Chat_tbPg";
            this.Main_Chat_tbPg.Padding = new System.Windows.Forms.Padding(3);
            this.Main_Chat_tbPg.Size = new System.Drawing.Size(313, 342);
            this.Main_Chat_tbPg.TabIndex = 1;
            this.Main_Chat_tbPg.Text = "Chat";
            this.Main_Chat_tbPg.UseVisualStyleBackColor = true;
            // 
            // Main_Chat_History_txtBx
            // 
            this.Main_Chat_History_txtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Chat_History_txtBx.Location = new System.Drawing.Point(8, 6);
            this.Main_Chat_History_txtBx.Multiline = true;
            this.Main_Chat_History_txtBx.Name = "Main_Chat_History_txtBx";
            this.Main_Chat_History_txtBx.ReadOnly = true;
            this.Main_Chat_History_txtBx.Size = new System.Drawing.Size(299, 220);
            this.Main_Chat_History_txtBx.TabIndex = 0;
            // 
            // Main_Chat_Message_txtBx
            // 
            this.Main_Chat_Message_txtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Chat_Message_txtBx.Font = new System.Drawing.Font("Coolsville", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Chat_Message_txtBx.Location = new System.Drawing.Point(9, 233);
            this.Main_Chat_Message_txtBx.Name = "Main_Chat_Message_txtBx";
            this.Main_Chat_Message_txtBx.Size = new System.Drawing.Size(298, 31);
            this.Main_Chat_Message_txtBx.TabIndex = 1;
            // 
            // Main_Chat_Send_btn
            // 
            this.Main_Chat_Send_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Chat_Send_btn.Location = new System.Drawing.Point(9, 270);
            this.Main_Chat_Send_btn.Name = "Main_Chat_Send_btn";
            this.Main_Chat_Send_btn.Size = new System.Drawing.Size(296, 64);
            this.Main_Chat_Send_btn.TabIndex = 2;
            this.Main_Chat_Send_btn.Text = "Send";
            this.Main_Chat_Send_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 374);
            this.Controls.Add(this.Main_tbCntrl);
            this.Name = "Form1";
            this.Text = "DnD-Helpr-0.01-SERVER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main_tbCntrl.ResumeLayout(false);
            this.Main_Chat_tbPg.ResumeLayout(false);
            this.Main_Chat_tbPg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Main_tbCntrl;
        private System.Windows.Forms.TabPage Main_ConnectionData_tbPg;
        private System.Windows.Forms.TabPage Main_Chat_tbPg;
        private System.Windows.Forms.Button Main_Chat_Send_btn;
        private System.Windows.Forms.TextBox Main_Chat_Message_txtBx;
        private System.Windows.Forms.TextBox Main_Chat_History_txtBx;
    }
}

