namespace ReportsPlus
{
    partial class CheckPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckPerson));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.welcomeCore = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.egnBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // welcomeCore
            // 
            this.welcomeCore.AnimateWindow = true;
            this.welcomeCore.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "ЕГН";
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
            this.guna2Button1.Location = new System.Drawing.Point(64, 41);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(196, 32);
            this.guna2Button1.TabIndex = 17;
            this.guna2Button1.Text = "ПРОВЕРКА";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // egnBox
            // 
            this.egnBox.AcceptsReturn = false;
            this.egnBox.AcceptsTab = false;
            this.egnBox.AnimationSpeed = 200;
            this.egnBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.egnBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.egnBox.AutoSizeHeight = true;
            this.egnBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.egnBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("egnBox.BackgroundImage")));
            this.egnBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.egnBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.egnBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.egnBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.egnBox.BorderRadius = 15;
            this.egnBox.BorderThickness = 2;
            this.egnBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.egnBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.egnBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.egnBox.DefaultText = "";
            this.egnBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.egnBox.HideSelection = true;
            this.egnBox.IconLeft = null;
            this.egnBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.egnBox.IconPadding = 10;
            this.egnBox.IconRight = null;
            this.egnBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.egnBox.Lines = new string[0];
            this.egnBox.Location = new System.Drawing.Point(64, 9);
            this.egnBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.egnBox.MaxLength = 32767;
            this.egnBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.egnBox.Modified = false;
            this.egnBox.Multiline = false;
            this.egnBox.Name = "egnBox";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.egnBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.egnBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.egnBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.egnBox.OnIdleState = stateProperties8;
            this.egnBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.egnBox.PasswordChar = '\0';
            this.egnBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.egnBox.PlaceholderText = "Enter text";
            this.egnBox.ReadOnly = false;
            this.egnBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.egnBox.SelectedText = "";
            this.egnBox.SelectionLength = 0;
            this.egnBox.SelectionStart = 0;
            this.egnBox.ShortcutsEnabled = true;
            this.egnBox.Size = new System.Drawing.Size(217, 26);
            this.egnBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.egnBox.TabIndex = 16;
            this.egnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.egnBox.TextMarginBottom = 0;
            this.egnBox.TextMarginLeft = 3;
            this.egnBox.TextMarginTop = 1;
            this.egnBox.TextPlaceholder = "Enter text";
            this.egnBox.UseSystemPasswordChar = false;
            this.egnBox.WordWrap = true;
            // 
            // CheckPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 87);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.egnBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckPerson";
            this.Text = "CheckPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm welcomeCore;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox egnBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}