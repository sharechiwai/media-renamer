namespace Media_Renamer
{
    partial class frmMediaRenamer
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
            lblSourceFolder = new Label();
            label1 = new Label();
            txtSourceFolder = new TextBox();
            txtDestination = new TextBox();
            btnSelectSourceFolder = new Button();
            btnSelectDestination = new Button();
            btnProcess = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblSourceFolder
            // 
            lblSourceFolder.AutoSize = true;
            lblSourceFolder.Location = new Point(40, 49);
            lblSourceFolder.Name = "lblSourceFolder";
            lblSourceFolder.Size = new Size(125, 25);
            lblSourceFolder.TabIndex = 0;
            lblSourceFolder.Text = "Source Folder:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 145);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 1;
            label1.Text = "Destination Folder:";
            // 
            // txtSourceFolder
            // 
            txtSourceFolder.Location = new Point(40, 88);
            txtSourceFolder.Name = "txtSourceFolder";
            txtSourceFolder.Size = new Size(622, 31);
            txtSourceFolder.TabIndex = 2;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(40, 182);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(619, 31);
            txtDestination.TabIndex = 3;
            // 
            // btnSelectSourceFolder
            // 
            btnSelectSourceFolder.Location = new Point(706, 88);
            btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            btnSelectSourceFolder.Size = new Size(98, 34);
            btnSelectSourceFolder.TabIndex = 4;
            btnSelectSourceFolder.Text = "Browse";
            btnSelectSourceFolder.UseVisualStyleBackColor = true;
            btnSelectSourceFolder.Click += btnSelectSourceFolder_Click;
            // 
            // btnSelectDestination
            // 
            btnSelectDestination.Location = new Point(706, 182);
            btnSelectDestination.Name = "btnSelectDestination";
            btnSelectDestination.Size = new Size(98, 34);
            btnSelectDestination.TabIndex = 5;
            btnSelectDestination.Text = "Browse";
            btnSelectDestination.UseVisualStyleBackColor = true;
            btnSelectDestination.Click += btnSelectDestination_Click;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(40, 319);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(147, 79);
            btnProcess.TabIndex = 6;
            btnProcess.Text = "Process";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 278);
            label2.Name = "label2";
            label2.Size = new Size(1008, 25);
            label2.TabIndex = 7;
            label2.Text = "By pressng \"Process\", it will copy the file from Source Folder to Destination folder and rename the file base on ExIF Date Taken";
            // 
            // frmMediaRenamer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 770);
            Controls.Add(label2);
            Controls.Add(btnProcess);
            Controls.Add(btnSelectDestination);
            Controls.Add(btnSelectSourceFolder);
            Controls.Add(txtDestination);
            Controls.Add(txtSourceFolder);
            Controls.Add(label1);
            Controls.Add(lblSourceFolder);
            Name = "frmMediaRenamer";
            Text = "Media Renamer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSourceFolder;
        private Label label1;
        private TextBox txtSourceFolder;
        private TextBox txtDestination;
        private Button btnSelectSourceFolder;
        private Button btnSelectDestination;
        private Button btnProcess;
        private Label label2;
    }
}
