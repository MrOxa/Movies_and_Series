﻿namespace Movies_and_Series
{
    partial class FormSeriesUpload
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxActors = new System.Windows.Forms.TextBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelActors = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSeason = new System.Windows.Forms.Label();
            this.labelEpsisode = new System.Windows.Forms.Label();
            this.numericUpDownSeason = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEpisode = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpisode)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(0, 573);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(550, 36);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(161, 283);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(352, 201);
            this.richTextBoxDescription.TabIndex = 16;
            this.richTextBoxDescription.Text = "";
            // 
            // textBoxActors
            // 
            this.textBoxActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxActors.Location = new System.Drawing.Point(161, 144);
            this.textBoxActors.Name = "textBoxActors";
            this.textBoxActors.Size = new System.Drawing.Size(352, 20);
            this.textBoxActors.TabIndex = 15;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownYear.Location = new System.Drawing.Point(161, 89);
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYear.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(161, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(352, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.AutoSize = true;
            this.labelDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDescription.Location = new System.Drawing.Point(82, 283);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Description";
            // 
            // labelActors
            // 
            this.labelActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelActors.AutoSize = true;
            this.labelActors.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelActors.Location = new System.Drawing.Point(82, 144);
            this.labelActors.Name = "labelActors";
            this.labelActors.Size = new System.Drawing.Size(37, 13);
            this.labelActors.TabIndex = 11;
            this.labelActors.Text = "Actors";
            // 
            // labelYear
            // 
            this.labelYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYear.AutoSize = true;
            this.labelYear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelYear.Location = new System.Drawing.Point(82, 89);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 13);
            this.labelYear.TabIndex = 10;
            this.labelYear.Text = "Year";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelName.Location = new System.Drawing.Point(82, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            // 
            // labelSeason
            // 
            this.labelSeason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSeason.AutoSize = true;
            this.labelSeason.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSeason.Location = new System.Drawing.Point(82, 189);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(43, 13);
            this.labelSeason.TabIndex = 18;
            this.labelSeason.Text = "Season";
            // 
            // labelEpsisode
            // 
            this.labelEpsisode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEpsisode.AutoSize = true;
            this.labelEpsisode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelEpsisode.Location = new System.Drawing.Point(82, 233);
            this.labelEpsisode.Name = "labelEpsisode";
            this.labelEpsisode.Size = new System.Drawing.Size(45, 13);
            this.labelEpsisode.TabIndex = 19;
            this.labelEpsisode.Text = "Episode";
            // 
            // numericUpDownSeason
            // 
            this.numericUpDownSeason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSeason.Location = new System.Drawing.Point(161, 189);
            this.numericUpDownSeason.Name = "numericUpDownSeason";
            this.numericUpDownSeason.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSeason.TabIndex = 20;
            // 
            // numericUpDownEpisode
            // 
            this.numericUpDownEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownEpisode.Location = new System.Drawing.Point(161, 242);
            this.numericUpDownEpisode.Name = "numericUpDownEpisode";
            this.numericUpDownEpisode.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEpisode.TabIndex = 21;
            // 
            // FormSeriesUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 609);
            this.Controls.Add(this.numericUpDownEpisode);
            this.Controls.Add(this.numericUpDownSeason);
            this.Controls.Add(this.labelEpsisode);
            this.Controls.Add(this.labelSeason);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxActors);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelActors);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelName);
            this.Name = "FormSeriesUpload";
            this.Text = "FormSeriesUpload";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpisode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxActors;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelActors;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSeason;
        private System.Windows.Forms.Label labelEpsisode;
        private System.Windows.Forms.NumericUpDown numericUpDownSeason;
        private System.Windows.Forms.NumericUpDown numericUpDownEpisode;
    }
}