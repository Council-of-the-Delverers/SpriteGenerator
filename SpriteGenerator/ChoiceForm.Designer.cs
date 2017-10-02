namespace SpriteGenerator
{
    partial class ChoiceForm
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
            this.characterBtn = new System.Windows.Forms.Button();
            this.swordBtn = new System.Windows.Forms.Button();
            this.hammerBtn = new System.Windows.Forms.Button();
            this.monsterBtn = new System.Windows.Forms.Button();
            this.itemBtn = new System.Windows.Forms.Button();
            this.wandBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // characterBtn
            // 
            this.characterBtn.Location = new System.Drawing.Point(30, 18);
            this.characterBtn.Name = "characterBtn";
            this.characterBtn.Size = new System.Drawing.Size(88, 23);
            this.characterBtn.TabIndex = 0;
            this.characterBtn.Text = "Character";
            this.characterBtn.UseVisualStyleBackColor = true;
            this.characterBtn.Click += new System.EventHandler(this.characterBtn_Click);
            // 
            // swordBtn
            // 
            this.swordBtn.Location = new System.Drawing.Point(30, 47);
            this.swordBtn.Name = "swordBtn";
            this.swordBtn.Size = new System.Drawing.Size(88, 23);
            this.swordBtn.TabIndex = 1;
            this.swordBtn.Text = "Sword";
            this.swordBtn.UseVisualStyleBackColor = true;
            this.swordBtn.Click += new System.EventHandler(this.swordBtn_Click);
            // 
            // hammerBtn
            // 
            this.hammerBtn.Location = new System.Drawing.Point(30, 76);
            this.hammerBtn.Name = "hammerBtn";
            this.hammerBtn.Size = new System.Drawing.Size(88, 23);
            this.hammerBtn.TabIndex = 2;
            this.hammerBtn.Text = "Hammer";
            this.hammerBtn.UseVisualStyleBackColor = true;
            this.hammerBtn.Click += new System.EventHandler(this.hammerBtn_Click);
            // 
            // monsterBtn
            // 
            this.monsterBtn.Location = new System.Drawing.Point(30, 105);
            this.monsterBtn.Name = "monsterBtn";
            this.monsterBtn.Size = new System.Drawing.Size(88, 23);
            this.monsterBtn.TabIndex = 3;
            this.monsterBtn.Text = "Monster";
            this.monsterBtn.UseVisualStyleBackColor = true;
            this.monsterBtn.Click += new System.EventHandler(this.monsterBtn_Click);
            // 
            // itemBtn
            // 
            this.itemBtn.Location = new System.Drawing.Point(30, 134);
            this.itemBtn.Name = "itemBtn";
            this.itemBtn.Size = new System.Drawing.Size(88, 23);
            this.itemBtn.TabIndex = 4;
            this.itemBtn.Text = "Item";
            this.itemBtn.UseVisualStyleBackColor = true;
            this.itemBtn.Click += new System.EventHandler(this.itemBtn_Click);
            // 
            // wandBtn
            // 
            this.wandBtn.Location = new System.Drawing.Point(30, 163);
            this.wandBtn.Name = "wandBtn";
            this.wandBtn.Size = new System.Drawing.Size(88, 23);
            this.wandBtn.TabIndex = 5;
            this.wandBtn.Text = "Wand";
            this.wandBtn.UseVisualStyleBackColor = true;
            this.wandBtn.Click += new System.EventHandler(this.wandBtn_Click);
            // 
            // ChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 205);
            this.Controls.Add(this.wandBtn);
            this.Controls.Add(this.itemBtn);
            this.Controls.Add(this.monsterBtn);
            this.Controls.Add(this.hammerBtn);
            this.Controls.Add(this.swordBtn);
            this.Controls.Add(this.characterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoiceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button characterBtn;
        private System.Windows.Forms.Button swordBtn;
        private System.Windows.Forms.Button hammerBtn;
        private System.Windows.Forms.Button monsterBtn;
        private System.Windows.Forms.Button itemBtn;
        private System.Windows.Forms.Button wandBtn;
    }
}