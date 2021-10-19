namespace ReportsPlus
{
    partial class OnStart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnStart));
            this.welcomeScreen = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.checkButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // welcomeScreen
            // 
            this.welcomeScreen.AnimateWindow = true;
            this.welcomeScreen.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_NEGATIVE;
            this.welcomeScreen.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(219)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(181, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "ReportsPlus V1.0 | BETA";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(743, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 4;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-3, 104);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(806, 14);
            this.bunifuSeparator1.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(190)))), ((int)(((byte)(219)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(82)))), ((int)(((byte)(99)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::ReportsPlus.Properties.Resources._674_6741279_employer_icon_removebg_preview;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(293, 133);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(196, 42);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "СЪЗДАВАНЕ";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.Transparent;
            this.checkButton.BorderRadius = 10;
            this.checkButton.BorderThickness = 2;
            this.checkButton.CheckedState.Parent = this.checkButton;
            this.checkButton.CustomImages.Parent = this.checkButton;
            this.checkButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkButton.DisabledState.Parent = this.checkButton;
            this.checkButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(190)))), ((int)(((byte)(219)))));
            this.checkButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.checkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(82)))), ((int)(((byte)(99)))));
            this.checkButton.HoverState.Parent = this.checkButton;
            this.checkButton.Image = global::ReportsPlus.Properties.Resources._720424;
            this.checkButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.checkButton.ImageSize = new System.Drawing.Size(30, 30);
            this.checkButton.Location = new System.Drawing.Point(293, 47);
            this.checkButton.Name = "checkButton";
            this.checkButton.ShadowDecoration.Enabled = true;
            this.checkButton.ShadowDecoration.Parent = this.checkButton;
            this.checkButton.Size = new System.Drawing.Size(196, 42);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "ПРОВЕРКА";
            this.checkButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // OnStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(800, 218);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.checkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OnStart";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm welcomeScreen;
        private Guna.UI2.WinForms.Guna2Button checkButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
    }
}

