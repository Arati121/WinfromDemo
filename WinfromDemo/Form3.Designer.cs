
namespace WinfromDemo
{
    partial class Form3
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
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.txtDid = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.Label();
            this.btnbinaryRead = new System.Windows.Forms.Button();
            this.btnbinaryWrite = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(404, 24);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(125, 23);
            this.btnCreateFolder.TabIndex = 1;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // txtDid
            // 
            this.txtDid.AutoSize = true;
            this.txtDid.Location = new System.Drawing.Point(230, 102);
            this.txtDid.Name = "txtDid";
            this.txtDid.Size = new System.Drawing.Size(44, 13);
            this.txtDid.TabIndex = 2;
            this.txtDid.Text = "Dept ID";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(230, 164);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(35, 13);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Name";
            // 
            // txtLocation
            // 
            this.txtLocation.AutoSize = true;
            this.txtLocation.Location = new System.Drawing.Point(230, 219);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(48, 13);
            this.txtLocation.TabIndex = 4;
            this.txtLocation.Text = "Location";
            this.txtLocation.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnbinaryRead
            // 
            this.btnbinaryRead.Location = new System.Drawing.Point(468, 285);
            this.btnbinaryRead.Name = "btnbinaryRead";
            this.btnbinaryRead.Size = new System.Drawing.Size(75, 23);
            this.btnbinaryRead.TabIndex = 6;
            this.btnbinaryRead.Text = "Binary Read";
            this.btnbinaryRead.UseVisualStyleBackColor = true;
            // 
            // btnbinaryWrite
            // 
            this.btnbinaryWrite.Location = new System.Drawing.Point(215, 285);
            this.btnbinaryWrite.Name = "btnbinaryWrite";
            this.btnbinaryWrite.Size = new System.Drawing.Size(75, 23);
            this.btnbinaryWrite.TabIndex = 7;
            this.btnbinaryWrite.Text = "Binary Write";
            this.btnbinaryWrite.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(404, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(404, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(404, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 10;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(203, 24);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 11;
            this.btnFile.Text = "Create File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnbinaryWrite);
            this.Controls.Add(this.btnbinaryRead);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDid);
            this.Controls.Add(this.btnCreateFolder);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Label txtDid;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtLocation;
        private System.Windows.Forms.Button btnbinaryRead;
        private System.Windows.Forms.Button btnbinaryWrite;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnFile;
    }
}