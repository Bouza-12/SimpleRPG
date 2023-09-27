namespace UI
{
    partial class SuperAdventure : Form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl_Level = new Label();
            lbl_Experience = new Label();
            lbl_Gold = new Label();
            lbl_hitPoints = new Label();
            label5 = new Label();
            cboWeapons = new ComboBox();
            cboPotions = new ComboBox();
            btnUseWeapon = new Button();
            btnUsePotion = new Button();
            btnNorth = new Button();
            buttonbtnEast1 = new Button();
            btnWest = new Button();
            btnSouth = new Button();
            rtbLocation = new RichTextBox();
            rtbMessages = new RichTextBox();
            dgvInventory = new DataGridView();
            dgvQuests = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuests).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hit Points:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Gold";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 74);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Experience:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 100);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Level:";
            // 
            // lbl_Level
            // 
            lbl_Level.AutoSize = true;
            lbl_Level.Location = new Point(110, 99);
            lbl_Level.Name = "lbl_Level";
            lbl_Level.Size = new Size(0, 15);
            lbl_Level.TabIndex = 7;
            // 
            // lbl_Experience
            // 
            lbl_Experience.AutoSize = true;
            lbl_Experience.Location = new Point(110, 73);
            lbl_Experience.Name = "lbl_Experience";
            lbl_Experience.Size = new Size(0, 15);
            lbl_Experience.TabIndex = 6;
            // 
            // lbl_Gold
            // 
            lbl_Gold.AutoSize = true;
            lbl_Gold.Location = new Point(110, 45);
            lbl_Gold.Name = "lbl_Gold";
            lbl_Gold.Size = new Size(0, 15);
            lbl_Gold.TabIndex = 5;
            // 
            // lbl_hitPoints
            // 
            lbl_hitPoints.AutoSize = true;
            lbl_hitPoints.Location = new Point(110, 19);
            lbl_hitPoints.Name = "lbl_hitPoints";
            lbl_hitPoints.Size = new Size(0, 15);
            lbl_hitPoints.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(617, 531);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 8;
            label5.Text = "Select action";
            // 
            // cboWeapons
            // 
            cboWeapons.FormattingEnabled = true;
            cboWeapons.Location = new Point(369, 559);
            cboWeapons.Name = "cboWeapons";
            cboWeapons.Size = new Size(121, 23);
            cboWeapons.TabIndex = 9;
            // 
            // cboPotions
            // 
            cboPotions.FormattingEnabled = true;
            cboPotions.Location = new Point(369, 593);
            cboPotions.Name = "cboPotions";
            cboPotions.Size = new Size(121, 23);
            cboPotions.TabIndex = 10;
            // 
            // btnUseWeapon
            // 
            btnUseWeapon.Location = new Point(620, 559);
            btnUseWeapon.Name = "btnUseWeapon";
            btnUseWeapon.Size = new Size(75, 23);
            btnUseWeapon.TabIndex = 11;
            btnUseWeapon.Text = "Use";
            btnUseWeapon.UseVisualStyleBackColor = true;
            // 
            // btnUsePotion
            // 
            btnUsePotion.Location = new Point(620, 593);
            btnUsePotion.Name = "btnUsePotion";
            btnUsePotion.Size = new Size(75, 23);
            btnUsePotion.TabIndex = 12;
            btnUsePotion.Text = "Use";
            btnUsePotion.UseVisualStyleBackColor = true;
            // 
            // btnNorth
            // 
            btnNorth.Location = new Point(493, 433);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(75, 23);
            btnNorth.TabIndex = 13;
            btnNorth.Text = "North";
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.Click += btnNorth_Click;
            // 
            // buttonbtnEast1
            // 
            buttonbtnEast1.Location = new Point(573, 457);
            buttonbtnEast1.Name = "buttonbtnEast1";
            buttonbtnEast1.Size = new Size(75, 23);
            buttonbtnEast1.TabIndex = 14;
            buttonbtnEast1.Text = "East";
            buttonbtnEast1.UseVisualStyleBackColor = true;
            buttonbtnEast1.Click += buttonbtnEast1_Click;
            // 
            // btnWest
            // 
            btnWest.Location = new Point(412, 457);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(75, 23);
            btnWest.TabIndex = 15;
            btnWest.Text = "West";
            btnWest.UseVisualStyleBackColor = true;
            btnWest.Click += btnWest_Click;
            // 
            // btnSouth
            // 
            btnSouth.Location = new Point(493, 487);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(75, 23);
            btnSouth.TabIndex = 16;
            btnSouth.Text = "South";
            btnSouth.UseVisualStyleBackColor = true;
            btnSouth.Click += btnSouth_Click;
            // 
            // rtbLocation
            // 
            rtbLocation.Location = new Point(347, 19);
            rtbLocation.Name = "rtbLocation";
            rtbLocation.ReadOnly = true;
            rtbLocation.Size = new Size(360, 105);
            rtbLocation.TabIndex = 17;
            rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            rtbMessages.Location = new Point(347, 130);
            rtbMessages.Name = "rtbMessages";
            rtbMessages.Size = new Size(360, 286);
            rtbMessages.TabIndex = 18;
            rtbMessages.Text = "";
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AllowUserToResizeColumns = false;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvInventory.Enabled = false;
            dgvInventory.Location = new Point(16, 130);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowTemplate.Height = 25;
            dgvInventory.Size = new Size(312, 309);
            dgvInventory.TabIndex = 19;
            // 
            // dgvQuests
            // 
            dgvQuests.AllowUserToAddRows = false;
            dgvQuests.AllowUserToDeleteRows = false;
            dgvQuests.AllowUserToResizeColumns = false;
            dgvQuests.AllowUserToResizeRows = false;
            dgvQuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuests.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvQuests.Enabled = false;
            dgvQuests.Location = new Point(16, 446);
            dgvQuests.MultiSelect = false;
            dgvQuests.Name = "dgvQuests";
            dgvQuests.ReadOnly = true;
            dgvQuests.RowHeadersVisible = false;
            dgvQuests.RowTemplate.Height = 25;
            dgvQuests.Size = new Size(312, 189);
            dgvQuests.TabIndex = 20;
            // 
            // SuperAdventure
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 861);
            Controls.Add(dgvQuests);
            Controls.Add(dgvInventory);
            Controls.Add(rtbMessages);
            Controls.Add(rtbLocation);
            Controls.Add(btnSouth);
            Controls.Add(btnWest);
            Controls.Add(buttonbtnEast1);
            Controls.Add(btnNorth);
            Controls.Add(btnUsePotion);
            Controls.Add(btnUseWeapon);
            Controls.Add(cboPotions);
            Controls.Add(cboWeapons);
            Controls.Add(label5);
            Controls.Add(lbl_Level);
            Controls.Add(lbl_Experience);
            Controls.Add(lbl_Gold);
            Controls.Add(lbl_hitPoints);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SuperAdventure";
            Text = "My Game";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_Level;
        private Label lbl_Experience;
        private Label lbl_Gold;
        private Label lbl_hitPoints;
        private Label label5;
        private ComboBox cboWeapons;
        private ComboBox cboPotions;
        private Button btnUseWeapon;
        private Button btnUsePotion;
        private Button btnNorth;
        private Button buttonbtnEast1;
        private Button btnWest;
        private Button btnSouth;
        private RichTextBox rtbLocation;
        private RichTextBox rtbMessages;
        private DataGridView dgvInventory;
        private DataGridView dgvQuests;
    }
}