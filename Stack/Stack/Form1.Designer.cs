namespace Stack
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
            this.Stack_New = new System.Windows.Forms.Button();
            this.FillStack = new System.Windows.Forms.Button();
            this.ProperAccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stack_New
            // 
            this.Stack_New.Location = new System.Drawing.Point(12, 47);
            this.Stack_New.Name = "Stack_New";
            this.Stack_New.Size = new System.Drawing.Size(75, 23);
            this.Stack_New.TabIndex = 0;
            this.Stack_New.Text = "Stack";
            this.Stack_New.UseVisualStyleBackColor = true;
            this.Stack_New.Click += new System.EventHandler(this.Stack_New_Click);
            // 
            // FillStack
            // 
            this.FillStack.Location = new System.Drawing.Point(142, 47);
            this.FillStack.Name = "FillStack";
            this.FillStack.Size = new System.Drawing.Size(75, 23);
            this.FillStack.TabIndex = 1;
            this.FillStack.Text = "FillStack";
            this.FillStack.UseVisualStyleBackColor = true;
            this.FillStack.Click += new System.EventHandler(this.FillStack_Click);
            // 
            // ProperAccess
            // 
            this.ProperAccess.Location = new System.Drawing.Point(144, 95);
            this.ProperAccess.Name = "ProperAccess";
            this.ProperAccess.Size = new System.Drawing.Size(108, 23);
            this.ProperAccess.TabIndex = 2;
            this.ProperAccess.Text = "ProperAccess";
            this.ProperAccess.UseVisualStyleBackColor = true;
            this.ProperAccess.Click += new System.EventHandler(this.ProperAccess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.ProperAccess);
            this.Controls.Add(this.FillStack);
            this.Controls.Add(this.Stack_New);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Stack_New;
        private System.Windows.Forms.Button FillStack;
        private System.Windows.Forms.Button ProperAccess;
    }
}

