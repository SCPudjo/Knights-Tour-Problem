namespace shawn_pudjowargono_assignment_01
{
    partial class Results_Form
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
            this.results_button = new System.Windows.Forms.Button();
            this.strategy_label = new System.Windows.Forms.Label();
            this.results_display_box = new System.Windows.Forms.TextBox();
            this.results_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // results_button
            // 
            this.results_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.results_button.Location = new System.Drawing.Point(121, 358);
            this.results_button.Name = "results_button";
            this.results_button.Size = new System.Drawing.Size(226, 39);
            this.results_button.TabIndex = 2;
            this.results_button.Text = "View Full Results";
            this.results_button.UseVisualStyleBackColor = true;
            this.results_button.Click += new System.EventHandler(this.results_button_Click);
            // 
            // strategy_label
            // 
            this.strategy_label.AutoSize = true;
            this.strategy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strategy_label.ForeColor = System.Drawing.SystemColors.Control;
            this.strategy_label.Location = new System.Drawing.Point(45, 38);
            this.strategy_label.Name = "strategy_label";
            this.strategy_label.Size = new System.Drawing.Size(0, 32);
            this.strategy_label.TabIndex = 4;
            // 
            // results_display_box
            // 
            this.results_display_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.results_display_box.Location = new System.Drawing.Point(67, 77);
            this.results_display_box.Multiline = true;
            this.results_display_box.Name = "results_display_box";
            this.results_display_box.ReadOnly = true;
            this.results_display_box.Size = new System.Drawing.Size(332, 250);
            this.results_display_box.TabIndex = 5;
            // 
            // results_label
            // 
            this.results_label.AutoSize = true;
            this.results_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.results_label.Location = new System.Drawing.Point(61, 25);
            this.results_label.Name = "results_label";
            this.results_label.Size = new System.Drawing.Size(157, 32);
            this.results_label.TabIndex = 6;
            this.results_label.Text = "Last Result";
            // 
            // Results_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(458, 432);
            this.Controls.Add(this.results_label);
            this.Controls.Add(this.results_display_box);
            this.Controls.Add(this.strategy_label);
            this.Controls.Add(this.results_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Results_Form";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button results_button;
        private System.Windows.Forms.Label strategy_label;
        private System.Windows.Forms.TextBox results_display_box;
        private System.Windows.Forms.Label results_label;
    }
}