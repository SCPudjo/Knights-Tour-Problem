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
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.strategy_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid
            // 
            this.data_grid.AllowUserToResizeColumns = false;
            this.data_grid.AllowUserToResizeRows = false;
            this.data_grid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.GridColor = System.Drawing.Color.Gainsboro;
            this.data_grid.Location = new System.Drawing.Point(65, 119);
            this.data_grid.Name = "data_grid";
            this.data_grid.ReadOnly = true;
            this.data_grid.RowTemplate.Height = 24;
            this.data_grid.Size = new System.Drawing.Size(240, 150);
            this.data_grid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // strategy_label
            // 
            this.strategy_label.AutoSize = true;
            this.strategy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strategy_label.ForeColor = System.Drawing.SystemColors.Control;
            this.strategy_label.Location = new System.Drawing.Point(59, 48);
            this.strategy_label.Name = "strategy_label";
            this.strategy_label.Size = new System.Drawing.Size(93, 32);
            this.strategy_label.TabIndex = 4;
            this.strategy_label.Text = "label1";
            // 
            // Results_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(694, 477);
            this.Controls.Add(this.strategy_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Results_Form";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label strategy_label;
    }
}