using System.Drawing;

namespace QRcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bSave = new System.Windows.Forms.Button();
            this.bDownload = new System.Windows.Forms.Button();
            this.bRecognize = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.bCreate = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // bSave
            // 
            resources.ApplyResources(this.bSave, "bSave");
            this.bSave.Name = "bSave";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BSave_MouseClick);
            // 
            // bDownload
            // 
            resources.ApplyResources(this.bDownload, "bDownload");
            this.bDownload.Name = "bDownload";
            this.bDownload.UseVisualStyleBackColor = true;
            this.bDownload.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bDownload_MouseClick);
            // 
            // bRecognize
            // 
            resources.ApplyResources(this.bRecognize, "bRecognize");
            this.bRecognize.Name = "bRecognize";
            this.bRecognize.UseVisualStyleBackColor = true;
            this.bRecognize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bRecognize_MouseClick);
            // 
            // label
            // 
            resources.ApplyResources(this.label, "label");
            this.label.Name = "label";
            // 
            // bCreate
            // 
            resources.ApplyResources(this.bCreate, "bCreate");
            this.bCreate.Name = "bCreate";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BCreate_MouseClick);
            // 
            // input
            // 
            resources.ApplyResources(this.input, "input");
            this.input.Name = "input";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.picture, "picture");
            this.picture.Name = "picture";
            this.picture.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picture);
            this.Controls.Add(this.input);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.label);
            this.Controls.Add(this.bRecognize);
            this.Controls.Add(this.bDownload);
            this.Controls.Add(this.bSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bDownload;
        private System.Windows.Forms.Button bRecognize;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.PictureBox picture;
    }
}
