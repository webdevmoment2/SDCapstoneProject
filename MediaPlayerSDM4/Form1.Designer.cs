namespace MediaPlayerSDM4
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
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(12, 12);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(782, 338);
            this.musicPlayer.TabIndex = 0;
            this.musicPlayer.Visible = false;
            this.musicPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Controls.Add(this.btn_stop);
            this.groupBox1.Controls.Add(this.btn_next);
            this.groupBox1.Controls.Add(this.btn_play);
            this.groupBox1.Controls.Add(this.btn_prev);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTROLS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_prev
            // 
            this.btn_prev.ForeColor = System.Drawing.Color.Black;
            this.btn_prev.Location = new System.Drawing.Point(18, 25);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(110, 27);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.Text = "BACK";
            this.btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_play
            // 
            this.btn_play.ForeColor = System.Drawing.Color.Black;
            this.btn_play.Location = new System.Drawing.Point(152, 25);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(110, 27);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "PLAY";
            this.btn_play.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.ForeColor = System.Drawing.Color.Black;
            this.btn_next.Location = new System.Drawing.Point(282, 25);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(110, 27);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "NEXT";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.ForeColor = System.Drawing.Color.Black;
            this.btn_stop.Location = new System.Drawing.Point(416, 25);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(110, 27);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // btn_open
            // 
            this.btn_open.ForeColor = System.Drawing.Color.Black;
            this.btn_open.Location = new System.Drawing.Point(547, 25);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(110, 27);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "IMPORT";
            this.btn_open.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(18, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(639, 109);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.musicPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_open;
    }
}

