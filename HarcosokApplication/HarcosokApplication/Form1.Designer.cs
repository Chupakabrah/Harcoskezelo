namespace HarcosokApplication
{
    partial class KarakterLetrehozFrm
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
            this.warriorNameTxtBox = new System.Windows.Forms.TextBox();
            this.warriorNameLbl = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.harcosLetrehozGrpBox = new System.Windows.Forms.GroupBox();
            this.kepessegLetrehozGrpBox = new System.Windows.Forms.GroupBox();
            this.addAbilityBtn = new System.Windows.Forms.Button();
            this.createAbilityDescriptionRTxtBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.abilityNameTxtBox = new System.Windows.Forms.TextBox();
            this.abilityNameLbl = new System.Windows.Forms.Label();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.hasznaloLbl = new System.Windows.Forms.Label();
            this.allWarriorLbl = new System.Windows.Forms.Label();
            this.warriorsListBox = new System.Windows.Forms.ListBox();
            this.abilitiesListBox = new System.Windows.Forms.ListBox();
            this.abilitiesLbl = new System.Windows.Forms.Label();
            this.deleteWarriorBtn = new System.Windows.Forms.Button();
            this.abilityDescriptionRTxtBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modifyDescriptionBtn = new System.Windows.Forms.Button();
            this.deleteAbilityBtn = new System.Windows.Forms.Button();
            this.harcosLetrehozGrpBox.SuspendLayout();
            this.kepessegLetrehozGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // warriorNameTxtBox
            // 
            this.warriorNameTxtBox.Location = new System.Drawing.Point(47, 19);
            this.warriorNameTxtBox.Name = "warriorNameTxtBox";
            this.warriorNameTxtBox.Size = new System.Drawing.Size(135, 20);
            this.warriorNameTxtBox.TabIndex = 0;
            // 
            // warriorNameLbl
            // 
            this.warriorNameLbl.AutoSize = true;
            this.warriorNameLbl.Location = new System.Drawing.Point(8, 22);
            this.warriorNameLbl.Name = "warriorNameLbl";
            this.warriorNameLbl.Size = new System.Drawing.Size(33, 13);
            this.warriorNameLbl.TabIndex = 1;
            this.warriorNameLbl.Text = "Név: ";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(198, 17);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(92, 23);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Létrehoz";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // harcosLetrehozGrpBox
            // 
            this.harcosLetrehozGrpBox.Controls.Add(this.warriorNameTxtBox);
            this.harcosLetrehozGrpBox.Controls.Add(this.createBtn);
            this.harcosLetrehozGrpBox.Controls.Add(this.warriorNameLbl);
            this.harcosLetrehozGrpBox.Location = new System.Drawing.Point(12, 12);
            this.harcosLetrehozGrpBox.Name = "harcosLetrehozGrpBox";
            this.harcosLetrehozGrpBox.Size = new System.Drawing.Size(305, 55);
            this.harcosLetrehozGrpBox.TabIndex = 3;
            this.harcosLetrehozGrpBox.TabStop = false;
            this.harcosLetrehozGrpBox.Text = "Harcos létrehozása";
            // 
            // kepessegLetrehozGrpBox
            // 
            this.kepessegLetrehozGrpBox.Controls.Add(this.addAbilityBtn);
            this.kepessegLetrehozGrpBox.Controls.Add(this.createAbilityDescriptionRTxtBox);
            this.kepessegLetrehozGrpBox.Controls.Add(this.descriptionLbl);
            this.kepessegLetrehozGrpBox.Controls.Add(this.abilityNameTxtBox);
            this.kepessegLetrehozGrpBox.Controls.Add(this.abilityNameLbl);
            this.kepessegLetrehozGrpBox.Controls.Add(this.hasznaloComboBox);
            this.kepessegLetrehozGrpBox.Controls.Add(this.hasznaloLbl);
            this.kepessegLetrehozGrpBox.Location = new System.Drawing.Point(12, 73);
            this.kepessegLetrehozGrpBox.Name = "kepessegLetrehozGrpBox";
            this.kepessegLetrehozGrpBox.Size = new System.Drawing.Size(547, 132);
            this.kepessegLetrehozGrpBox.TabIndex = 4;
            this.kepessegLetrehozGrpBox.TabStop = false;
            this.kepessegLetrehozGrpBox.Text = "Képesség hozzáadása";
            // 
            // addAbilityBtn
            // 
            this.addAbilityBtn.Location = new System.Drawing.Point(11, 96);
            this.addAbilityBtn.Name = "addAbilityBtn";
            this.addAbilityBtn.Size = new System.Drawing.Size(82, 29);
            this.addAbilityBtn.TabIndex = 7;
            this.addAbilityBtn.Text = "Hozzáad";
            this.addAbilityBtn.UseVisualStyleBackColor = true;
            this.addAbilityBtn.Click += new System.EventHandler(this.addAbilityBtn_Click);
            // 
            // createAbilityDescriptionRTxtBox
            // 
            this.createAbilityDescriptionRTxtBox.Location = new System.Drawing.Point(244, 19);
            this.createAbilityDescriptionRTxtBox.Name = "createAbilityDescriptionRTxtBox";
            this.createAbilityDescriptionRTxtBox.Size = new System.Drawing.Size(292, 61);
            this.createAbilityDescriptionRTxtBox.TabIndex = 6;
            this.createAbilityDescriptionRTxtBox.Text = "";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(195, 23);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(43, 13);
            this.descriptionLbl.TabIndex = 5;
            this.descriptionLbl.Text = "Leírás: ";
            // 
            // abilityNameTxtBox
            // 
            this.abilityNameTxtBox.Location = new System.Drawing.Point(71, 60);
            this.abilityNameTxtBox.Name = "abilityNameTxtBox";
            this.abilityNameTxtBox.Size = new System.Drawing.Size(111, 20);
            this.abilityNameTxtBox.TabIndex = 4;
            // 
            // abilityNameLbl
            // 
            this.abilityNameLbl.AutoSize = true;
            this.abilityNameLbl.Location = new System.Drawing.Point(8, 63);
            this.abilityNameLbl.Name = "abilityNameLbl";
            this.abilityNameLbl.Size = new System.Drawing.Size(33, 13);
            this.abilityNameLbl.TabIndex = 3;
            this.abilityNameLbl.Text = "Név: ";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(71, 23);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(111, 21);
            this.hasznaloComboBox.TabIndex = 1;
            // 
            // hasznaloLbl
            // 
            this.hasznaloLbl.AutoSize = true;
            this.hasznaloLbl.Location = new System.Drawing.Point(8, 26);
            this.hasznaloLbl.Name = "hasznaloLbl";
            this.hasznaloLbl.Size = new System.Drawing.Size(57, 13);
            this.hasznaloLbl.TabIndex = 0;
            this.hasznaloLbl.Text = "Használó: ";
            // 
            // allWarriorLbl
            // 
            this.allWarriorLbl.AutoSize = true;
            this.allWarriorLbl.Location = new System.Drawing.Point(68, 227);
            this.allWarriorLbl.Name = "allWarriorLbl";
            this.allWarriorLbl.Size = new System.Drawing.Size(53, 13);
            this.allWarriorLbl.TabIndex = 8;
            this.allWarriorLbl.Text = "Harcosok";
            // 
            // warriorsListBox
            // 
            this.warriorsListBox.FormattingEnabled = true;
            this.warriorsListBox.Location = new System.Drawing.Point(23, 243);
            this.warriorsListBox.Name = "warriorsListBox";
            this.warriorsListBox.Size = new System.Drawing.Size(148, 199);
            this.warriorsListBox.TabIndex = 9;
            this.warriorsListBox.SelectedIndexChanged += new System.EventHandler(this.warriorsListBox_SelectedIndexChanged);
            // 
            // abilitiesListBox
            // 
            this.abilitiesListBox.FormattingEnabled = true;
            this.abilitiesListBox.Location = new System.Drawing.Point(177, 243);
            this.abilitiesListBox.Name = "abilitiesListBox";
            this.abilitiesListBox.Size = new System.Drawing.Size(148, 199);
            this.abilitiesListBox.TabIndex = 11;
            this.abilitiesListBox.SelectedIndexChanged += new System.EventHandler(this.abilitiesListBox_SelectedIndexChanged);
            // 
            // abilitiesLbl
            // 
            this.abilitiesLbl.AutoSize = true;
            this.abilitiesLbl.Location = new System.Drawing.Point(222, 227);
            this.abilitiesLbl.Name = "abilitiesLbl";
            this.abilitiesLbl.Size = new System.Drawing.Size(62, 13);
            this.abilitiesLbl.TabIndex = 10;
            this.abilitiesLbl.Text = "Képességei";
            // 
            // deleteWarriorBtn
            // 
            this.deleteWarriorBtn.Location = new System.Drawing.Point(23, 448);
            this.deleteWarriorBtn.Name = "deleteWarriorBtn";
            this.deleteWarriorBtn.Size = new System.Drawing.Size(148, 23);
            this.deleteWarriorBtn.TabIndex = 12;
            this.deleteWarriorBtn.Text = "Karakter Törlés";
            this.deleteWarriorBtn.UseVisualStyleBackColor = true;
            this.deleteWarriorBtn.Click += new System.EventHandler(this.DeleteWarriorBtn_Click);
            // 
            // abilityDescriptionRTxtBox
            // 
            this.abilityDescriptionRTxtBox.Location = new System.Drawing.Point(331, 243);
            this.abilityDescriptionRTxtBox.Name = "abilityDescriptionRTxtBox";
            this.abilityDescriptionRTxtBox.Size = new System.Drawing.Size(228, 125);
            this.abilityDescriptionRTxtBox.TabIndex = 13;
            this.abilityDescriptionRTxtBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Képesség leírás";
            // 
            // modifyDescriptionBtn
            // 
            this.modifyDescriptionBtn.Location = new System.Drawing.Point(331, 374);
            this.modifyDescriptionBtn.Name = "modifyDescriptionBtn";
            this.modifyDescriptionBtn.Size = new System.Drawing.Size(228, 23);
            this.modifyDescriptionBtn.TabIndex = 15;
            this.modifyDescriptionBtn.Text = "Módosítás";
            this.modifyDescriptionBtn.UseVisualStyleBackColor = true;
            this.modifyDescriptionBtn.Click += new System.EventHandler(this.modifyDescriptionBtn_Click);
            // 
            // deleteAbilityBtn
            // 
            this.deleteAbilityBtn.Location = new System.Drawing.Point(177, 448);
            this.deleteAbilityBtn.Name = "deleteAbilityBtn";
            this.deleteAbilityBtn.Size = new System.Drawing.Size(148, 23);
            this.deleteAbilityBtn.TabIndex = 16;
            this.deleteAbilityBtn.Text = "Képesség Törlés";
            this.deleteAbilityBtn.UseVisualStyleBackColor = true;
            this.deleteAbilityBtn.Click += new System.EventHandler(this.deleteAbilityBtn_Click);
            // 
            // KarakterLetrehozFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 477);
            this.Controls.Add(this.deleteAbilityBtn);
            this.Controls.Add(this.modifyDescriptionBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abilityDescriptionRTxtBox);
            this.Controls.Add(this.deleteWarriorBtn);
            this.Controls.Add(this.abilitiesListBox);
            this.Controls.Add(this.abilitiesLbl);
            this.Controls.Add(this.warriorsListBox);
            this.Controls.Add(this.allWarriorLbl);
            this.Controls.Add(this.kepessegLetrehozGrpBox);
            this.Controls.Add(this.harcosLetrehozGrpBox);
            this.Name = "KarakterLetrehozFrm";
            this.Text = "Karakter kreálás";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.harcosLetrehozGrpBox.ResumeLayout(false);
            this.harcosLetrehozGrpBox.PerformLayout();
            this.kepessegLetrehozGrpBox.ResumeLayout(false);
            this.kepessegLetrehozGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox warriorNameTxtBox;
        private System.Windows.Forms.Label warriorNameLbl;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.GroupBox harcosLetrehozGrpBox;
        private System.Windows.Forms.GroupBox kepessegLetrehozGrpBox;
        private System.Windows.Forms.Label hasznaloLbl;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.TextBox abilityNameTxtBox;
        private System.Windows.Forms.Label abilityNameLbl;
        private System.Windows.Forms.RichTextBox createAbilityDescriptionRTxtBox;
        private System.Windows.Forms.Button addAbilityBtn;
        private System.Windows.Forms.Label allWarriorLbl;
        private System.Windows.Forms.ListBox warriorsListBox;
        private System.Windows.Forms.ListBox abilitiesListBox;
        private System.Windows.Forms.Label abilitiesLbl;
        private System.Windows.Forms.Button deleteWarriorBtn;
        private System.Windows.Forms.RichTextBox abilityDescriptionRTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modifyDescriptionBtn;
        private System.Windows.Forms.Button deleteAbilityBtn;
    }
}

