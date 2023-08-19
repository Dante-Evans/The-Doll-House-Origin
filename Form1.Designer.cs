namespace The_Doll_House
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.Btn_Options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Title.Font = new System.Drawing.Font("SWGothi", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Title.Location = new System.Drawing.Point(147, 9);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(194, 25);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "The Doll House";
            // 
            // Btn_Start
            // 
            this.Btn_Start.BackColor = System.Drawing.Color.Crimson;
            this.Btn_Start.Font = new System.Drawing.Font("SWGothi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start.Location = new System.Drawing.Point(152, 281);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 1;
            this.Btn_Start.Text = "Enter";
            this.Btn_Start.UseVisualStyleBackColor = false;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Crimson;
            this.Btn_Exit.Font = new System.Drawing.Font("SWGothi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(152, 351);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 2;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            // 
            // Btn_Load
            // 
            this.Btn_Load.BackColor = System.Drawing.Color.Crimson;
            this.Btn_Load.Enabled = false;
            this.Btn_Load.Font = new System.Drawing.Font("SWGothi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Load.Location = new System.Drawing.Point(152, 304);
            this.Btn_Load.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(75, 23);
            this.Btn_Load.TabIndex = 3;
            this.Btn_Load.Text = "Load";
            this.Btn_Load.UseVisualStyleBackColor = false;
            // 
            // Btn_Options
            // 
            this.Btn_Options.BackColor = System.Drawing.Color.Crimson;
            this.Btn_Options.Font = new System.Drawing.Font("SWGothi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Options.Location = new System.Drawing.Point(152, 328);
            this.Btn_Options.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Options.Name = "Btn_Options";
            this.Btn_Options.Size = new System.Drawing.Size(75, 23);
            this.Btn_Options.TabIndex = 4;
            this.Btn_Options.Text = "Options";
            this.Btn_Options.UseVisualStyleBackColor = false;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 530);
            this.Controls.Add(this.Btn_Options);
            this.Controls.Add(this.Btn_Load);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Lbl_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.Button Btn_Options;
    }
}

