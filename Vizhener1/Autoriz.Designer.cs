namespace Vizhener1
{
    partial class Autoriz
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRega = new System.Windows.Forms.Label();
            this.label_perehodNaReg = new System.Windows.Forms.Label();
            this.exit_auto = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoButton = new System.Windows.Forms.Button();
            this.AutoPassBox = new System.Windows.Forms.TextBox();
            this.AutoLoginBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            this.panel2.Controls.Add(this.labelRega);
            this.panel2.Controls.Add(this.label_perehodNaReg);
            this.panel2.Controls.Add(this.exit_auto);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.AutoButton);
            this.panel2.Controls.Add(this.AutoPassBox);
            this.panel2.Controls.Add(this.AutoLoginBox);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 439);
            this.panel2.TabIndex = 9;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove_1);
            // 
            // labelRega
            // 
            this.labelRega.AutoSize = true;
            this.labelRega.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRega.Location = new System.Drawing.Point(296, 11);
            this.labelRega.Name = "labelRega";
            this.labelRega.Size = new System.Drawing.Size(224, 35);
            this.labelRega.TabIndex = 15;
            this.labelRega.Text = "Авторизация";
            // 
            // label_perehodNaReg
            // 
            this.label_perehodNaReg.AutoSize = true;
            this.label_perehodNaReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_perehodNaReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_perehodNaReg.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_perehodNaReg.Location = new System.Drawing.Point(496, 295);
            this.label_perehodNaReg.Name = "label_perehodNaReg";
            this.label_perehodNaReg.Size = new System.Drawing.Size(127, 19);
            this.label_perehodNaReg.TabIndex = 17;
            this.label_perehodNaReg.Text = "Нет аккаунта ?";
            this.label_perehodNaReg.Click += new System.EventHandler(this.label_perehodNaReg_Click);
            // 
            // exit_auto
            // 
            this.exit_auto.AutoSize = true;
            this.exit_auto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_auto.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_auto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_auto.Location = new System.Drawing.Point(759, 11);
            this.exit_auto.Name = "exit_auto";
            this.exit_auto.Size = new System.Drawing.Size(20, 18);
            this.exit_auto.TabIndex = 16;
            this.exit_auto.Text = "X";
            this.exit_auto.Click += new System.EventHandler(this.exit_auto_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vizhener1.Properties.Resources.for_autoriz;
            this.pictureBox2.Location = new System.Drawing.Point(0, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 377);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vizhener1.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(406, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vizhener1.Properties.Resources.man_login;
            this.pictureBox3.Location = new System.Drawing.Point(406, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(473, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(473, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин";
            // 
            // AutoButton
            // 
            this.AutoButton.BackColor = System.Drawing.Color.White;
            this.AutoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoButton.FlatAppearance.BorderSize = 0;
            this.AutoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AutoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AutoButton.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoButton.Location = new System.Drawing.Point(466, 253);
            this.AutoButton.Name = "AutoButton";
            this.AutoButton.Size = new System.Drawing.Size(182, 28);
            this.AutoButton.TabIndex = 0;
            this.AutoButton.Text = "Войти";
            this.AutoButton.UseVisualStyleBackColor = false;
            this.AutoButton.Click += new System.EventHandler(this.AutoButton_Click);
            // 
            // AutoPassBox
            // 
            this.AutoPassBox.Location = new System.Drawing.Point(477, 196);
            this.AutoPassBox.Name = "AutoPassBox";
            this.AutoPassBox.Size = new System.Drawing.Size(161, 20);
            this.AutoPassBox.TabIndex = 3;
            this.AutoPassBox.UseSystemPasswordChar = true;
            this.AutoPassBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoPassBox_KeyPress);
            // 
            // AutoLoginBox
            // 
            this.AutoLoginBox.Location = new System.Drawing.Point(477, 123);
            this.AutoLoginBox.Name = "AutoLoginBox";
            this.AutoLoginBox.Size = new System.Drawing.Size(161, 20);
            this.AutoLoginBox.TabIndex = 2;
            this.AutoLoginBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoLoginBox_KeyPress);
            // 
            // Autoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 435);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autoriz";
            this.Text = "Autoriz";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AutoButton;
        private System.Windows.Forms.TextBox AutoPassBox;
        private System.Windows.Forms.TextBox AutoLoginBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label exit_auto;
        private System.Windows.Forms.Label label_perehodNaReg;
        private System.Windows.Forms.Label labelRega;
    }
}