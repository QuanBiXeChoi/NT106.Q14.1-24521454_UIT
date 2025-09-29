namespace ThucHanhBuoi1
{
    partial class Bai8
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
            txbInput = new TextBox();
            btnXuLy = new Button();
            listboxOutput = new ListBox();
            SuspendLayout();
            // 
            // txbInput
            // 
            txbInput.Location = new Point(284, 144);
            txbInput.Multiline = true;
            txbInput.Name = "txbInput";
            txbInput.ScrollBars = ScrollBars.Vertical;
            txbInput.Size = new Size(762, 78);
            txbInput.TabIndex = 0;
            // 
            // btnXuLy
            // 
            btnXuLy.Location = new Point(591, 295);
            btnXuLy.Name = "btnXuLy";
            btnXuLy.Size = new Size(150, 46);
            btnXuLy.TabIndex = 1;
            btnXuLy.Text = "Xử lý";
            btnXuLy.UseVisualStyleBackColor = true;
            btnXuLy.Click += btnXuLy_Click;
            // 
            // listboxOutput
            // 
            listboxOutput.FormattingEnabled = true;
            listboxOutput.Location = new Point(193, 408);
            listboxOutput.Name = "listboxOutput";
            listboxOutput.ScrollAlwaysVisible = true;
            listboxOutput.Size = new Size(947, 420);
            listboxOutput.TabIndex = 2;
            // 
            // Bai8
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 835);
            Controls.Add(listboxOutput);
            Controls.Add(btnXuLy);
            Controls.Add(txbInput);
            Name = "Bai8";
            Text = "Bai8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbInput;
        private Button btnXuLy;
        private ListBox listboxOutput;
    }
}