namespace Vizhener1
{
    partial class Start
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_start = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.StartRegButton = new System.Windows.Forms.Button();
            this.StartAutoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.exit_start);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.StartRegButton);
            this.panel1.Controls.Add(this.StartAutoButton);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 450);
            this.panel1.TabIndex = 9;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // exit_start
            // 
            this.exit_start.AutoSize = true;
            this.exit_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_start.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_start.Location = new System.Drawing.Point(747, 11);
            this.exit_start.Name = "exit_start";
            this.exit_start.Size = new System.Drawing.Size(20, 18);
            this.exit_start.TabIndex = 16;
            this.exit_start.Text = "X";
            this.exit_start.Click += new System.EventHandler(this.exit_start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vizhener1.Properties.Resources.beidzhik;
            this.pictureBox1.Location = new System.Drawing.Point(571, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vizhener1.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(381, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vizhener1.Properties.Resources.disk;
            this.pictureBox3.Location = new System.Drawing.Point(0, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(374, 363);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // StartRegButton
            // 
            this.StartRegButton.BackColor = System.Drawing.Color.White;
            this.StartRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartRegButton.FlatAppearance.BorderSize = 0;
            this.StartRegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartRegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.StartRegButton.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartRegButton.Location = new System.Drawing.Point(596, 202);
            this.StartRegButton.Name = "StartRegButton";
            this.StartRegButton.Size = new System.Drawing.Size(117, 60);
            this.StartRegButton.TabIndex = 1;
            this.StartRegButton.Text = "Создать аккаунт ";
            this.StartRegButton.UseVisualStyleBackColor = false;
            this.StartRegButton.Click += new System.EventHandler(this.StartRegButton_Click);
            // 
            // StartAutoButton
            // 
            this.StartAutoButton.BackColor = System.Drawing.Color.White;
            this.StartAutoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartAutoButton.FlatAppearance.BorderSize = 0;
            this.StartAutoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartAutoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.StartAutoButton.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartAutoButton.Location = new System.Drawing.Point(406, 202);
            this.StartAutoButton.Name = "StartAutoButton";
            this.StartAutoButton.Size = new System.Drawing.Size(117, 60);
            this.StartAutoButton.TabIndex = 0;
            this.StartAutoButton.Text = "Авторизация";
            this.StartAutoButton.UseVisualStyleBackColor = false;
            this.StartAutoButton.Click += new System.EventHandler(this.StartAutoButton_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 444);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start";
            this.Text = "Start";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StartRegButton;
        private System.Windows.Forms.Button StartAutoButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exit_start;
    }
}