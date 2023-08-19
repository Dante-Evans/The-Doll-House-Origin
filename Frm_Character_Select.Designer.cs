namespace The_Doll_House
{
    partial class Frm_Character_Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Character_Select));
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Grb_Characters = new System.Windows.Forms.GroupBox();
            this.Pic_Female = new System.Windows.Forms.PictureBox();
            this.Pic_Male = new System.Windows.Forms.PictureBox();
            this.Rbtn_Female = new System.Windows.Forms.RadioButton();
            this.Rbtn_Male = new System.Windows.Forms.RadioButton();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Grb_Characters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Female)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Male)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Name.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Name.Location = new System.Drawing.Point(17, 14);
            this.Lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(39, 14);
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "Name";
            // 
            // Txt_Name
            // 
            this.Txt_Name.ForeColor = System.Drawing.Color.Crimson;
            this.Txt_Name.Location = new System.Drawing.Point(21, 32);
            this.Txt_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(132, 23);
            this.Txt_Name.TabIndex = 1;
            this.Txt_Name.Text = "Name";
            // 
            // Grb_Characters
            // 
            this.Grb_Characters.BackColor = System.Drawing.Color.Transparent;
            this.Grb_Characters.Controls.Add(this.Rbtn_Male);
            this.Grb_Characters.Controls.Add(this.Rbtn_Female);
            this.Grb_Characters.Controls.Add(this.Pic_Male);
            this.Grb_Characters.Controls.Add(this.Pic_Female);
            this.Grb_Characters.ForeColor = System.Drawing.Color.Red;
            this.Grb_Characters.Location = new System.Drawing.Point(13, 62);
            this.Grb_Characters.Name = "Grb_Characters";
            this.Grb_Characters.Size = new System.Drawing.Size(200, 196);
            this.Grb_Characters.TabIndex = 2;
            this.Grb_Characters.TabStop = false;
            this.Grb_Characters.Text = "Characters";
            // 
            // Pic_Female
            // 
            this.Pic_Female.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Female.Image")));
            this.Pic_Female.Location = new System.Drawing.Point(8, 22);
            this.Pic_Female.Name = "Pic_Female";
            this.Pic_Female.Size = new System.Drawing.Size(59, 100);
            this.Pic_Female.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Female.TabIndex = 0;
            this.Pic_Female.TabStop = false;
            // 
            // Pic_Male
            // 
            this.Pic_Male.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Male.Image")));
            this.Pic_Male.Location = new System.Drawing.Point(128, 22);
            this.Pic_Male.Name = "Pic_Male";
            this.Pic_Male.Size = new System.Drawing.Size(59, 100);
            this.Pic_Male.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Male.TabIndex = 1;
            this.Pic_Male.TabStop = false;
            // 
            // Rbtn_Female
            // 
            this.Rbtn_Female.AutoSize = true;
            this.Rbtn_Female.Location = new System.Drawing.Point(8, 128);
            this.Rbtn_Female.Name = "Rbtn_Female";
            this.Rbtn_Female.Size = new System.Drawing.Size(66, 18);
            this.Rbtn_Female.TabIndex = 2;
            this.Rbtn_Female.TabStop = true;
            this.Rbtn_Female.Tag = "Female";
            this.Rbtn_Female.Text = "Female";
            this.Rbtn_Female.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Male
            // 
            this.Rbtn_Male.AutoSize = true;
            this.Rbtn_Male.Location = new System.Drawing.Point(128, 128);
            this.Rbtn_Male.Name = "Rbtn_Male";
            this.Rbtn_Male.Size = new System.Drawing.Size(51, 18);
            this.Rbtn_Male.TabIndex = 3;
            this.Rbtn_Male.TabStop = true;
            this.Rbtn_Male.Text = "Male";
            this.Rbtn_Male.UseVisualStyleBackColor = true;
            // 
            // Btn_Create
            // 
            this.Btn_Create.Location = new System.Drawing.Point(13, 294);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(75, 28);
            this.Btn_Create.TabIndex = 3;
            this.Btn_Create.Text = "Create";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // Frm_Character_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 485);
            this.Controls.Add(this.Btn_Create);
            this.Controls.Add(this.Grb_Characters);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Lbl_Name);
            this.Font = new System.Drawing.Font("SWGothi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_Character_Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Select";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Grb_Characters.ResumeLayout(false);
            this.Grb_Characters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Female)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Male)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.GroupBox Grb_Characters;
        private System.Windows.Forms.PictureBox Pic_Female;
        private System.Windows.Forms.PictureBox Pic_Male;
        private System.Windows.Forms.RadioButton Rbtn_Female;
        private System.Windows.Forms.RadioButton Rbtn_Male;
        private System.Windows.Forms.Button Btn_Create;
    }
}