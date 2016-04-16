namespace M_CSHARP_TurtleGraphics
{
    partial class Turtle_Graphic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turtle_Graphic));
            this.panel3 = new System.Windows.Forms.Panel();
            this.paper_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.turtle_pbox = new System.Windows.Forms.PictureBox();
            this.commands_listbox = new System.Windows.Forms.ListBox();
            this.save_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.send_button = new System.Windows.Forms.Button();
            this.command_textbox = new System.Windows.Forms.TextBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.help_label = new System.Windows.Forms.Label();
            this.command_label = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.paper_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turtle_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.reset_button);
            this.panel3.Controls.Add(this.command_textbox);
            this.panel3.Controls.Add(this.send_button);
            this.panel3.Controls.Add(this.load_button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 60);
            this.panel3.TabIndex = 1;
            // 
            // paper_panel
            // 
            this.paper_panel.BackColor = System.Drawing.Color.Khaki;
            this.paper_panel.Controls.Add(this.turtle_pbox);
            this.paper_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paper_panel.Location = new System.Drawing.Point(0, 60);
            this.paper_panel.Name = "paper_panel";
            this.paper_panel.Size = new System.Drawing.Size(597, 301);
            this.paper_panel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.command_label);
            this.panel2.Controls.Add(this.help_label);
            this.panel2.Controls.Add(this.save_button);
            this.panel2.Controls.Add(this.commands_listbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(457, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 301);
            this.panel2.TabIndex = 3;
            // 
            // turtle_pbox
            // 
            this.turtle_pbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.turtle_pbox.Image = global::M_CSHARP_TurtleGraphics.Properties.Resources.turtle;
            this.turtle_pbox.Location = new System.Drawing.Point(81, 181);
            this.turtle_pbox.Name = "turtle_pbox";
            this.turtle_pbox.Size = new System.Drawing.Size(31, 36);
            this.turtle_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.turtle_pbox.TabIndex = 0;
            this.turtle_pbox.TabStop = false;
            // 
            // commands_listbox
            // 
            this.commands_listbox.FormattingEnabled = true;
            this.commands_listbox.Location = new System.Drawing.Point(8, 25);
            this.commands_listbox.Name = "commands_listbox";
            this.commands_listbox.Size = new System.Drawing.Size(120, 238);
            this.commands_listbox.TabIndex = 0;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(53, 269);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 1;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(510, 23);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(75, 23);
            this.load_button.TabIndex = 0;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(348, 23);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 1;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            // 
            // command_textbox
            // 
            this.command_textbox.Location = new System.Drawing.Point(13, 26);
            this.command_textbox.Name = "command_textbox";
            this.command_textbox.Size = new System.Drawing.Size(329, 20);
            this.command_textbox.TabIndex = 2;
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(429, 23);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 3;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            // 
            // help_label
            // 
            this.help_label.AutoSize = true;
            this.help_label.BackColor = System.Drawing.Color.Red;
            this.help_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.help_label.Location = new System.Drawing.Point(14, 268);
            this.help_label.Name = "help_label";
            this.help_label.Size = new System.Drawing.Size(21, 24);
            this.help_label.TabIndex = 2;
            this.help_label.Text = "?";
            // 
            // command_label
            // 
            this.command_label.AutoSize = true;
            this.command_label.Location = new System.Drawing.Point(5, 9);
            this.command_label.Name = "command_label";
            this.command_label.Size = new System.Drawing.Size(62, 13);
            this.command_label.TabIndex = 3;
            this.command_label.Text = "Commands:";
            // 
            // Turtle_Graphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(597, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paper_panel);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Turtle_Graphic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turtle Graphic";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.paper_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turtle_pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel paper_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox turtle_pbox;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.TextBox command_textbox;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Label command_label;
        private System.Windows.Forms.Label help_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ListBox commands_listbox;
    }
}

