namespace LaserComputeLab
{
    partial class DebugIOConsole
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
            this.consoletext = new System.Windows.Forms.RichTextBox();
            this.dataInp = new System.Windows.Forms.TextBox();
            this.sendData = new System.Windows.Forms.Button();
            this.clearConsole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consoletext
            // 
            this.consoletext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.consoletext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoletext.Location = new System.Drawing.Point(13, 59);
            this.consoletext.Name = "consoletext";
            this.consoletext.ReadOnly = true;
            this.consoletext.Size = new System.Drawing.Size(773, 377);
            this.consoletext.TabIndex = 0;
            this.consoletext.Text = "";
            // 
            // dataInp
            // 
            this.dataInp.Location = new System.Drawing.Point(13, 22);
            this.dataInp.Name = "dataInp";
            this.dataInp.Size = new System.Drawing.Size(515, 22);
            this.dataInp.TabIndex = 1;
            this.dataInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataInp_KeyDown);
            // 
            // sendData
            // 
            this.sendData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendData.Location = new System.Drawing.Point(534, 17);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(123, 32);
            this.sendData.TabIndex = 2;
            this.sendData.Text = "Отправить";
            this.sendData.UseVisualStyleBackColor = true;
            this.sendData.Click += new System.EventHandler(this.sendData_Click);
            // 
            // clearConsole
            // 
            this.clearConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearConsole.Location = new System.Drawing.Point(663, 17);
            this.clearConsole.Name = "clearConsole";
            this.clearConsole.Size = new System.Drawing.Size(123, 32);
            this.clearConsole.TabIndex = 3;
            this.clearConsole.Text = "Очистить";
            this.clearConsole.UseVisualStyleBackColor = true;
            this.clearConsole.Click += new System.EventHandler(this.clearConsole_Click);
            // 
            // DebugIOConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearConsole);
            this.Controls.Add(this.sendData);
            this.Controls.Add(this.dataInp);
            this.Controls.Add(this.consoletext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DebugIOConsole";
            this.Text = "Отладка через I/O консоль устройства";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebugIOConsole_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox consoletext;
        private System.Windows.Forms.TextBox dataInp;
        private System.Windows.Forms.Button sendData;
        private System.Windows.Forms.Button clearConsole;
    }
}