namespace IccRareFarm.Presentation
{
    partial class CharacterForm
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
            this.character_label = new System.Windows.Forms.Label();
            this.newCharName = new System.Windows.Forms.TextBox();
            this.AddCharBtn = new System.Windows.Forms.Button();
            this.GetAll = new System.Windows.Forms.Button();
            this.characterGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.characterGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // character_label
            // 
            this.character_label.AutoSize = true;
            this.character_label.Location = new System.Drawing.Point(38, 23);
            this.character_label.Name = "character_label";
            this.character_label.Size = new System.Drawing.Size(83, 15);
            this.character_label.TabIndex = 0;
            this.character_label.Text = "Add Character";
            // 
            // newCharName
            // 
            this.newCharName.Location = new System.Drawing.Point(139, 20);
            this.newCharName.Name = "newCharName";
            this.newCharName.Size = new System.Drawing.Size(100, 23);
            this.newCharName.TabIndex = 1;
            // 
            // AddCharBtn
            // 
            this.AddCharBtn.Location = new System.Drawing.Point(256, 20);
            this.AddCharBtn.Name = "AddCharBtn";
            this.AddCharBtn.Size = new System.Drawing.Size(75, 23);
            this.AddCharBtn.TabIndex = 2;
            this.AddCharBtn.Text = "+";
            this.AddCharBtn.UseVisualStyleBackColor = true;
            this.AddCharBtn.Click += new System.EventHandler(this.AddCharBtn_Click);
            // 
            // GetAll
            // 
            this.GetAll.Location = new System.Drawing.Point(653, 383);
            this.GetAll.Name = "GetAll";
            this.GetAll.Size = new System.Drawing.Size(135, 55);
            this.GetAll.TabIndex = 3;
            this.GetAll.Text = "Get All Characters (Debug)";
            this.GetAll.UseVisualStyleBackColor = true;
            this.GetAll.Click += new System.EventHandler(this.GetAll_Click);
            // 
            // characterGrid
            // 
            this.characterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.characterGrid.Location = new System.Drawing.Point(29, 49);
            this.characterGrid.Name = "characterGrid";
            this.characterGrid.RowTemplate.Height = 25;
            this.characterGrid.Size = new System.Drawing.Size(759, 328);
            this.characterGrid.TabIndex = 4;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.characterGrid);
            this.Controls.Add(this.GetAll);
            this.Controls.Add(this.AddCharBtn);
            this.Controls.Add(this.newCharName);
            this.Controls.Add(this.character_label);
            this.Name = "CharacterForm";
            this.Text = "Character List";
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.characterGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label character_label;
        private System.Windows.Forms.TextBox newCharName;
        private System.Windows.Forms.Button AddCharBtn;
        private System.Windows.Forms.Button GetAll;
    }
}

