namespace Resturant_Automation
{
    partial class MainInterface
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
            this.BottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.FeedbackButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.OurTitles = new System.Windows.Forms.Label();
            this.RestaurantTitle = new System.Windows.Forms.Label();
            this.AdvertisementsPanel = new System.Windows.Forms.Panel();
            this.AdminSignIn = new System.Windows.Forms.LinkLabel();
            this.CallWaiterButton = new System.Windows.Forms.Button();
            this.MainInterfacePicBoxLarge = new System.Windows.Forms.PictureBox();
            this.MainInterfaceSidePicBoxLarge = new System.Windows.Forms.PictureBox();
            this.MainInterfaceSidePicBoxSmall = new System.Windows.Forms.PictureBox();
            this.BottomPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.AdvertisementsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainInterfacePicBoxLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainInterfaceSidePicBoxLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainInterfaceSidePicBoxSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.Black;
            this.BottomPanel.Controls.Add(this.MenuButton);
            this.BottomPanel.Controls.Add(this.FeedbackButton);
            this.BottomPanel.Location = new System.Drawing.Point(190, 396);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(579, 86);
            this.BottomPanel.TabIndex = 0;
            this.BottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BottomPanel_Paint);
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(3, 3);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(272, 80);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // FeedbackButton
            // 
            this.FeedbackButton.Location = new System.Drawing.Point(281, 3);
            this.FeedbackButton.Name = "FeedbackButton";
            this.FeedbackButton.Size = new System.Drawing.Size(292, 80);
            this.FeedbackButton.TabIndex = 1;
            this.FeedbackButton.Text = "Please provide us feedback and share your experience";
            this.FeedbackButton.UseVisualStyleBackColor = true;
            this.FeedbackButton.Click += new System.EventHandler(this.FeedbackButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.Maroon;
            this.LogoPanel.Controls.Add(this.MainInterfacePicBoxLarge);
            this.LogoPanel.Controls.Add(this.OurTitles);
            this.LogoPanel.Controls.Add(this.RestaurantTitle);
            this.LogoPanel.Location = new System.Drawing.Point(190, 12);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(579, 378);
            this.LogoPanel.TabIndex = 0;
            this.LogoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoPanel_Paint);
            // 
            // OurTitles
            // 
            this.OurTitles.AutoSize = true;
            this.OurTitles.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OurTitles.Location = new System.Drawing.Point(256, 67);
            this.OurTitles.Name = "OurTitles";
            this.OurTitles.Size = new System.Drawing.Size(317, 30);
            this.OurTitles.TabIndex = 1;
            this.OurTitles.Text = "Powered by SAAN Developers";
            // 
            // RestaurantTitle
            // 
            this.RestaurantTitle.AutoSize = true;
            this.RestaurantTitle.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RestaurantTitle.Location = new System.Drawing.Point(74, 0);
            this.RestaurantTitle.Name = "RestaurantTitle";
            this.RestaurantTitle.Size = new System.Drawing.Size(499, 67);
            this.RestaurantTitle.TabIndex = 0;
            this.RestaurantTitle.Text = "Welcome To Kaybees";
            // 
            // AdvertisementsPanel
            // 
            this.AdvertisementsPanel.BackColor = System.Drawing.Color.Black;
            this.AdvertisementsPanel.Controls.Add(this.MainInterfaceSidePicBoxSmall);
            this.AdvertisementsPanel.Controls.Add(this.MainInterfaceSidePicBoxLarge);
            this.AdvertisementsPanel.Controls.Add(this.AdminSignIn);
            this.AdvertisementsPanel.Controls.Add(this.CallWaiterButton);
            this.AdvertisementsPanel.Location = new System.Drawing.Point(13, 12);
            this.AdvertisementsPanel.Name = "AdvertisementsPanel";
            this.AdvertisementsPanel.Size = new System.Drawing.Size(171, 470);
            this.AdvertisementsPanel.TabIndex = 1;
            this.AdvertisementsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdvertisementsPanel_Paint);
            // 
            // AdminSignIn
            // 
            this.AdminSignIn.AutoSize = true;
            this.AdminSignIn.Location = new System.Drawing.Point(12, 365);
            this.AdminSignIn.Name = "AdminSignIn";
            this.AdminSignIn.Size = new System.Drawing.Size(96, 13);
            this.AdminSignIn.TabIndex = 1;
            this.AdminSignIn.TabStop = true;
            this.AdminSignIn.Text = "Administrator Login";
            this.AdminSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AdminSignIn_LinkClicked);
            // 
            // CallWaiterButton
            // 
            this.CallWaiterButton.Location = new System.Drawing.Point(4, 384);
            this.CallWaiterButton.Name = "CallWaiterButton";
            this.CallWaiterButton.Size = new System.Drawing.Size(164, 83);
            this.CallWaiterButton.TabIndex = 0;
            this.CallWaiterButton.Text = "Call a waiter";
            this.CallWaiterButton.UseVisualStyleBackColor = true;
            this.CallWaiterButton.Click += new System.EventHandler(this.CallWaiterButton_Click);
            // 
            // MainInterfacePicBoxLarge
            // 
            this.MainInterfacePicBoxLarge.Location = new System.Drawing.Point(3, 100);
            this.MainInterfacePicBoxLarge.Name = "MainInterfacePicBoxLarge";
            this.MainInterfacePicBoxLarge.Size = new System.Drawing.Size(570, 275);
            this.MainInterfacePicBoxLarge.TabIndex = 2;
            this.MainInterfacePicBoxLarge.TabStop = false;
            this.MainInterfacePicBoxLarge.Click += new System.EventHandler(this.MainInterfacePicBoxLarge_Click);
            // 
            // MainInterfaceSidePicBoxLarge
            // 
            this.MainInterfaceSidePicBoxLarge.Location = new System.Drawing.Point(4, 100);
            this.MainInterfaceSidePicBoxLarge.Name = "MainInterfaceSidePicBoxLarge";
            this.MainInterfaceSidePicBoxLarge.Size = new System.Drawing.Size(164, 262);
            this.MainInterfaceSidePicBoxLarge.TabIndex = 2;
            this.MainInterfaceSidePicBoxLarge.TabStop = false;
            this.MainInterfaceSidePicBoxLarge.Click += new System.EventHandler(this.MainInterfaceSidePicBoxLarge_Click);
            // 
            // MainInterfaceSidePicBoxSmall
            // 
            this.MainInterfaceSidePicBoxSmall.Location = new System.Drawing.Point(4, 3);
            this.MainInterfaceSidePicBoxSmall.Name = "MainInterfaceSidePicBoxSmall";
            this.MainInterfaceSidePicBoxSmall.Size = new System.Drawing.Size(164, 91);
            this.MainInterfaceSidePicBoxSmall.TabIndex = 3;
            this.MainInterfaceSidePicBoxSmall.TabStop = false;
            this.MainInterfaceSidePicBoxSmall.Click += new System.EventHandler(this.MainInterfaceSidePicBoxSmall_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(781, 494);
            this.Controls.Add(this.AdvertisementsPanel);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.BottomPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place your order here";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.BottomPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.AdvertisementsPanel.ResumeLayout(false);
            this.AdvertisementsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainInterfacePicBoxLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainInterfaceSidePicBoxLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainInterfaceSidePicBoxSmall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel BottomPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel AdvertisementsPanel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button FeedbackButton;
        private System.Windows.Forms.LinkLabel AdminSignIn;
        private System.Windows.Forms.Button CallWaiterButton;
        private System.Windows.Forms.Label OurTitles;
        private System.Windows.Forms.Label RestaurantTitle;
        private System.Windows.Forms.PictureBox MainInterfacePicBoxLarge;
        private System.Windows.Forms.PictureBox MainInterfaceSidePicBoxSmall;
        private System.Windows.Forms.PictureBox MainInterfaceSidePicBoxLarge;
    }
}