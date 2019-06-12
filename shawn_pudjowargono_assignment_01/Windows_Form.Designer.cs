namespace shawn_pudjowargono_assignment_01
{
    partial class Windows_Form
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
            this.begin_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.x_input = new System.Windows.Forms.NumericUpDown();
            this.y_input = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.number_of_trials_input = new System.Windows.Forms.NumericUpDown();
            this.strategy_A = new System.Windows.Forms.RadioButton();
            this.strategy_B = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.x_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_trials_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // begin_button
            // 
            this.begin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.begin_button.Location = new System.Drawing.Point(255, 330);
            this.begin_button.Margin = new System.Windows.Forms.Padding(4);
            this.begin_button.Name = "begin_button";
            this.begin_button.Size = new System.Drawing.Size(100, 39);
            this.begin_button.TabIndex = 0;
            this.begin_button.Text = "Begin";
            this.begin_button.UseVisualStyleBackColor = true;
            this.begin_button.Click += new System.EventHandler(this.begin_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Knight Start Position";
            // 
            // x_input
            // 
            this.x_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_input.Location = new System.Drawing.Point(387, 94);
            this.x_input.Margin = new System.Windows.Forms.Padding(4);
            this.x_input.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.x_input.Name = "x_input";
            this.x_input.Size = new System.Drawing.Size(61, 26);
            this.x_input.TabIndex = 2;
            // 
            // y_input
            // 
            this.y_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.y_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_input.Location = new System.Drawing.Point(387, 124);
            this.y_input.Margin = new System.Windows.Forms.Padding(4);
            this.y_input.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.y_input.Name = "y_input";
            this.y_input.Size = new System.Drawing.Size(61, 26);
            this.y_input.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome to the Knight\'s Tour Simulation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(68, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Strategy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(68, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of Trials:";
            // 
            // number_of_trials_input
            // 
            this.number_of_trials_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number_of_trials_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_of_trials_input.Location = new System.Drawing.Point(298, 272);
            this.number_of_trials_input.Margin = new System.Windows.Forms.Padding(4);
            this.number_of_trials_input.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.number_of_trials_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.number_of_trials_input.Name = "number_of_trials_input";
            this.number_of_trials_input.Size = new System.Drawing.Size(61, 26);
            this.number_of_trials_input.TabIndex = 9;
            this.number_of_trials_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // strategy_A
            // 
            this.strategy_A.AutoSize = true;
            this.strategy_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.strategy_A.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.strategy_A.Location = new System.Drawing.Point(201, 165);
            this.strategy_A.Margin = new System.Windows.Forms.Padding(4);
            this.strategy_A.Name = "strategy_A";
            this.strategy_A.Size = new System.Drawing.Size(158, 29);
            this.strategy_A.TabIndex = 11;
            this.strategy_A.TabStop = true;
            this.strategy_A.Text = "Non-Intelligent";
            this.strategy_A.UseVisualStyleBackColor = true;
            // 
            // strategy_B
            // 
            this.strategy_B.AutoSize = true;
            this.strategy_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.strategy_B.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.strategy_B.Location = new System.Drawing.Point(201, 202);
            this.strategy_B.Margin = new System.Windows.Forms.Padding(4);
            this.strategy_B.Name = "strategy_B";
            this.strategy_B.Size = new System.Drawing.Size(108, 29);
            this.strategy_B.TabIndex = 12;
            this.strategy_B.TabStop = true;
            this.strategy_B.Text = "Heuristic";
            this.strategy_B.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(339, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(339, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Y:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::shawn_pudjowargono_assignment_01.Properties.Resources.knight;
            this.pictureBox1.Location = new System.Drawing.Point(555, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Windows_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.strategy_B);
            this.Controls.Add(this.strategy_A);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.number_of_trials_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.y_input);
            this.Controls.Add(this.x_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.begin_button);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Windows_Form";
            this.Text = "Knight\'s Tour Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.x_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_trials_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button begin_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown x_input;
        private System.Windows.Forms.NumericUpDown y_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown number_of_trials_input;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton strategy_A;
        private System.Windows.Forms.RadioButton strategy_B;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}