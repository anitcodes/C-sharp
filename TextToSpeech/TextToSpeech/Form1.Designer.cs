namespace TextToSpeech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cross = new System.Windows.Forms.PictureBox();
            this.btnSpech = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.voicecomboBox = new System.Windows.Forms.ComboBox();
            this.SpeedtrackBar = new System.Windows.Forms.TrackBar();
            this.VolumetrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumetrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // cross
            // 
            this.cross.Image = ((System.Drawing.Image)(resources.GetObject("cross.Image")));
            this.cross.Location = new System.Drawing.Point(533, 12);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(39, 33);
            this.cross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cross.TabIndex = 0;
            this.cross.TabStop = false;
            this.cross.Click += new System.EventHandler(this.cross_Click);
            // 
            // btnSpech
            // 
            this.btnSpech.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpech.Location = new System.Drawing.Point(12, 66);
            this.btnSpech.Name = "btnSpech";
            this.btnSpech.Size = new System.Drawing.Size(115, 33);
            this.btnSpech.TabIndex = 1;
            this.btnSpech.Text = "Speech";
            this.btnSpech.UseVisualStyleBackColor = true;
            this.btnSpech.Click += new System.EventHandler(this.btnSpech_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 127);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(560, 219);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // voicecomboBox
            // 
            this.voicecomboBox.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voicecomboBox.FormattingEnabled = true;
            this.voicecomboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.voicecomboBox.Location = new System.Drawing.Point(364, 66);
            this.voicecomboBox.Name = "voicecomboBox";
            this.voicecomboBox.Size = new System.Drawing.Size(208, 33);
            this.voicecomboBox.TabIndex = 2;
            // 
            // SpeedtrackBar
            // 
            this.SpeedtrackBar.Location = new System.Drawing.Point(62, 365);
            this.SpeedtrackBar.Name = "SpeedtrackBar";
            this.SpeedtrackBar.Size = new System.Drawing.Size(167, 45);
            this.SpeedtrackBar.TabIndex = 3;
            // 
            // VolumetrackBar
            // 
            this.VolumetrackBar.Location = new System.Drawing.Point(403, 365);
            this.VolumetrackBar.Maximum = 100;
            this.VolumetrackBar.Minimum = 10;
            this.VolumetrackBar.Name = "VolumetrackBar";
            this.VolumetrackBar.Size = new System.Drawing.Size(169, 45);
            this.VolumetrackBar.TabIndex = 4;
            this.VolumetrackBar.Value = 75;
            this.VolumetrackBar.Scroll += new System.EventHandler(this.VolumetrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Volume";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VolumetrackBar);
            this.Controls.Add(this.SpeedtrackBar);
            this.Controls.Add(this.voicecomboBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSpech);
            this.Controls.Add(this.cross);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextToSpeech";
            ((System.ComponentModel.ISupportInitialize)(this.cross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumetrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cross;
        private System.Windows.Forms.Button btnSpech;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox voicecomboBox;
        private System.Windows.Forms.TrackBar SpeedtrackBar;
        private System.Windows.Forms.TrackBar VolumetrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

