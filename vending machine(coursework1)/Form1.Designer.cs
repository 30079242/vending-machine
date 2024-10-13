namespace vending_machine_coursework1_
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            textBoxInstruction = new TextBox();
            TwixBtn = new Button();
            textBoxBasket = new TextBox();
            MonsterBtn = new Button();
            CrispsBtn = new Button();
            NoodlesBtn = new Button();
            TwixTextBox = new TextBox();
            EnergyDrinkTextBox = new TextBox();
            NoodlesTextBox = new TextBox();
            CrispsTextBox = new TextBox();
            textBoxTotal = new TextBox();
            SuspendLayout();
            // 
            // textBoxInstruction
            // 
            textBoxInstruction.BackColor = SystemColors.ButtonHighlight;
            textBoxInstruction.BorderStyle = BorderStyle.None;
            textBoxInstruction.Cursor = Cursors.No;
            textBoxInstruction.Font = new Font("Segoe Script", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInstruction.ForeColor = SystemColors.ControlText;
            textBoxInstruction.Location = new Point(33, 37);
            textBoxInstruction.Name = "textBoxInstruction";
            textBoxInstruction.ReadOnly = true;
            textBoxInstruction.Size = new Size(622, 45);
            textBoxInstruction.TabIndex = 1;
            textBoxInstruction.Text = "click on items you would ike to puchase";
            // 
            // TwixBtn
            // 
            TwixBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TwixBtn.BackColor = SystemColors.ControlLightLight;
            TwixBtn.BackgroundImage = (Image)resources.GetObject("TwixBtn.BackgroundImage");
            TwixBtn.BackgroundImageLayout = ImageLayout.Stretch;
            TwixBtn.Font = new Font("Courier New", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TwixBtn.ForeColor = SystemColors.ActiveCaptionText;
            TwixBtn.Location = new Point(85, 111);
            TwixBtn.Name = "TwixBtn";
            TwixBtn.Size = new Size(219, 218);
            TwixBtn.TabIndex = 2;
            TwixBtn.TextAlign = ContentAlignment.BottomCenter;
            TwixBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            TwixBtn.UseVisualStyleBackColor = false;
            TwixBtn.Click += GenericBtn_Click;
            // 
            // textBoxBasket
            // 
            textBoxBasket.BackColor = SystemColors.ButtonHighlight;
            textBoxBasket.BorderStyle = BorderStyle.None;
            textBoxBasket.Cursor = Cursors.No;
            textBoxBasket.Font = new Font("Segoe Script", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxBasket.ForeColor = SystemColors.MenuText;
            textBoxBasket.Location = new Point(692, 111);
            textBoxBasket.Multiline = true;
            textBoxBasket.Name = "textBoxBasket";
            textBoxBasket.ReadOnly = true;
            textBoxBasket.ScrollBars = ScrollBars.Horizontal;
            textBoxBasket.Size = new Size(338, 218);
            textBoxBasket.TabIndex = 3;
            textBoxBasket.Text = "Basket: ";
            // 
            // MonsterBtn
            // 
            MonsterBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MonsterBtn.BackgroundImage = (Image)resources.GetObject("MonsterBtn.BackgroundImage");
            MonsterBtn.BackgroundImageLayout = ImageLayout.Stretch;
            MonsterBtn.Font = new Font("Courier New", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MonsterBtn.Location = new Point(371, 111);
            MonsterBtn.Name = "MonsterBtn";
            MonsterBtn.Size = new Size(219, 218);
            MonsterBtn.TabIndex = 4;
            MonsterBtn.TextAlign = ContentAlignment.BottomCenter;
            MonsterBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            MonsterBtn.UseVisualStyleBackColor = true;
            MonsterBtn.Click += GenericBtn_Click;
            // 
            // CrispsBtn
            // 
            CrispsBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CrispsBtn.BackgroundImage = Properties.Resources.spin_prod_ec_801114001;
            CrispsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CrispsBtn.Font = new Font("Courier New", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrispsBtn.ForeColor = SystemColors.InfoText;
            CrispsBtn.Location = new Point(85, 396);
            CrispsBtn.Name = "CrispsBtn";
            CrispsBtn.Size = new Size(219, 218);
            CrispsBtn.TabIndex = 5;
            CrispsBtn.TextAlign = ContentAlignment.BottomCenter;
            CrispsBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            CrispsBtn.UseVisualStyleBackColor = true;
            CrispsBtn.Click += GenericBtn_Click;
            // 
            // NoodlesBtn
            // 
            NoodlesBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NoodlesBtn.BackgroundImage = (Image)resources.GetObject("NoodlesBtn.BackgroundImage");
            NoodlesBtn.BackgroundImageLayout = ImageLayout.Stretch;
            NoodlesBtn.Font = new Font("Courier New", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoodlesBtn.ForeColor = SystemColors.InfoText;
            NoodlesBtn.Location = new Point(371, 396);
            NoodlesBtn.Name = "NoodlesBtn";
            NoodlesBtn.Size = new Size(219, 218);
            NoodlesBtn.TabIndex = 6;
            NoodlesBtn.TextAlign = ContentAlignment.BottomCenter;
            NoodlesBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            NoodlesBtn.UseVisualStyleBackColor = true;
            NoodlesBtn.Click += GenericBtn_Click;
            // 
            // TwixTextBox
            // 
            TwixTextBox.BackColor = SystemColors.ButtonHighlight;
            TwixTextBox.BorderStyle = BorderStyle.None;
            TwixTextBox.Cursor = Cursors.UpArrow;
            TwixTextBox.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TwixTextBox.Location = new Point(85, 328);
            TwixTextBox.Name = "TwixTextBox";
            TwixTextBox.ReadOnly = true;
            TwixTextBox.Size = new Size(219, 29);
            TwixTextBox.TabIndex = 7;
            TwixTextBox.Text = "Twix Bar:         1.50£";
            // 
            // EnergyDrinkTextBox
            // 
            EnergyDrinkTextBox.BackColor = SystemColors.ButtonHighlight;
            EnergyDrinkTextBox.BorderStyle = BorderStyle.None;
            EnergyDrinkTextBox.Cursor = Cursors.UpArrow;
            EnergyDrinkTextBox.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnergyDrinkTextBox.Location = new Point(371, 328);
            EnergyDrinkTextBox.Name = "EnergyDrinkTextBox";
            EnergyDrinkTextBox.ReadOnly = true;
            EnergyDrinkTextBox.Size = new Size(219, 29);
            EnergyDrinkTextBox.TabIndex = 8;
            EnergyDrinkTextBox.Text = "Energy Drink:   2.30£";
            // 
            // NoodlesTextBox
            // 
            NoodlesTextBox.BackColor = SystemColors.ButtonHighlight;
            NoodlesTextBox.BorderStyle = BorderStyle.None;
            NoodlesTextBox.Cursor = Cursors.UpArrow;
            NoodlesTextBox.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoodlesTextBox.Location = new Point(371, 616);
            NoodlesTextBox.Name = "NoodlesTextBox";
            NoodlesTextBox.ReadOnly = true;
            NoodlesTextBox.Size = new Size(219, 29);
            NoodlesTextBox.TabIndex = 9;
            NoodlesTextBox.Text = "Noodles:            1.20£";
            // 
            // CrispsTextBox
            // 
            CrispsTextBox.BackColor = SystemColors.ButtonHighlight;
            CrispsTextBox.BorderStyle = BorderStyle.None;
            CrispsTextBox.Cursor = Cursors.UpArrow;
            CrispsTextBox.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrispsTextBox.Location = new Point(85, 616);
            CrispsTextBox.Name = "CrispsTextBox";
            CrispsTextBox.ReadOnly = true;
            CrispsTextBox.Size = new Size(219, 29);
            CrispsTextBox.TabIndex = 10;
            CrispsTextBox.Text = "Crisps:              0.89£";
            // 
            // textBoxTotal
            // 
            textBoxTotal.BackColor = SystemColors.ButtonHighlight;
            textBoxTotal.BorderStyle = BorderStyle.None;
            textBoxTotal.Font = new Font("Segoe Script", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTotal.Location = new Point(692, 396);
            textBoxTotal.Multiline = true;
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(339, 207);
            textBoxTotal.TabIndex = 11;
            textBoxTotal.Text = "Total:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1134, 701);
            Controls.Add(textBoxTotal);
            Controls.Add(CrispsTextBox);
            Controls.Add(NoodlesTextBox);
            Controls.Add(EnergyDrinkTextBox);
            Controls.Add(TwixTextBox);
            Controls.Add(NoodlesBtn);
            Controls.Add(CrispsBtn);
            Controls.Add(textBoxBasket);
            Controls.Add(TwixBtn);
            Controls.Add(textBoxInstruction);
            Controls.Add(MonsterBtn);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            ShowInTaskbar = false;
            Text = "Sayna's vending machine";
            TransparencyKey = Color.FromArgb(192, 0, 192);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Twixbtn;
        private TextBox textBoxInstruction;
        private Button TwixBtn;
        private TextBox textBoxBasket;
        private Button MonsterBtn;
        private Button CrispsBtn;
        private Button NoodlesBtn;
        private TextBox TwixTextBox;
        private TextBox EnergyDrinkTextBox;
        private TextBox NoodlesTextBox;
        private TextBox CrispsTextBox;
        private TextBox textBoxTotal;
    }
}
