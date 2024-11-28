namespace DynamicMemory_List_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblCounter = new Label();
            txtNumber = new TextBox();
            btnAdd = new Button();
            lstvNumbers = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 81);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Location = new Point(91, 163);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(16, 15);
            lblCounter.TabIndex = 1;
            lblCounter.Text = "...";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(148, 78);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(139, 118);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstvNumbers
            // 
            lstvNumbers.Location = new Point(278, 33);
            lstvNumbers.Name = "lstvNumbers";
            lstvNumbers.Size = new Size(224, 182);
            lstvNumbers.TabIndex = 4;
            lstvNumbers.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 282);
            Controls.Add(lstvNumbers);
            Controls.Add(btnAdd);
            Controls.Add(txtNumber);
            Controls.Add(lblCounter);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCounter;
        private TextBox txtNumber;
        private Button btnAdd;
        private ListView lstvNumbers;
    }
}
