namespace MySoftApiFormApp
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
            this.btnTokenControl = new System.Windows.Forms.Button();
            this.btnEarchiveCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTokenControl
            // 
            this.btnTokenControl.Location = new System.Drawing.Point(15, 16);
            this.btnTokenControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTokenControl.Name = "btnTokenControl";
            this.btnTokenControl.Size = new System.Drawing.Size(156, 48);
            this.btnTokenControl.TabIndex = 0;
            this.btnTokenControl.Text = "Token Kontrol";
            this.btnTokenControl.UseVisualStyleBackColor = true;
            this.btnTokenControl.Click += new System.EventHandler(this.btnTokenControl_Click);
            // 
            // btnEarchiveCreate
            // 
            this.btnEarchiveCreate.Location = new System.Drawing.Point(15, 88);
            this.btnEarchiveCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnEarchiveCreate.Name = "btnEarchiveCreate";
            this.btnEarchiveCreate.Size = new System.Drawing.Size(156, 48);
            this.btnEarchiveCreate.TabIndex = 1;
            this.btnEarchiveCreate.Text = "E-Arşiv Oluştur";
            this.btnEarchiveCreate.UseVisualStyleBackColor = true;
            this.btnEarchiveCreate.Click += new System.EventHandler(this.btnEarchiveCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 459);
            this.Controls.Add(this.btnEarchiveCreate);
            this.Controls.Add(this.btnTokenControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTokenControl;
        private System.Windows.Forms.Button btnEarchiveCreate;
    }
}

