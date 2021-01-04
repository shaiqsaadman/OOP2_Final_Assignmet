namespace FinalAssignment.Views
{
    partial class AllBooks
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
            this.dataGridViewSrc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSrc = new System.Windows.Forms.TextBox();
            this.buttonSrc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSrc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSrc
            // 
            this.dataGridViewSrc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSrc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSrc.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSrc.Name = "dataGridViewSrc";
            this.dataGridViewSrc.Size = new System.Drawing.Size(454, 161);
            this.dataGridViewSrc.TabIndex = 5;
            this.dataGridViewSrc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSrc_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(63, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // textBoxSrc
            // 
            this.textBoxSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSrc.Location = new System.Drawing.Point(68, 88);
            this.textBoxSrc.Name = "textBoxSrc";
            this.textBoxSrc.Size = new System.Drawing.Size(267, 32);
            this.textBoxSrc.TabIndex = 3;
            this.textBoxSrc.TextChanged += new System.EventHandler(this.textBoxSrc_TextChanged);
            // 
            // buttonSrc
            // 
            this.buttonSrc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSrc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSrc.Location = new System.Drawing.Point(342, 88);
            this.buttonSrc.Name = "buttonSrc";
            this.buttonSrc.Size = new System.Drawing.Size(99, 32);
            this.buttonSrc.TabIndex = 6;
            this.buttonSrc.Text = "Search";
            this.buttonSrc.UseVisualStyleBackColor = false;
            this.buttonSrc.Click += new System.EventHandler(this.buttonSrc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewSrc);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(68, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 167);
            this.panel1.TabIndex = 7;
            // 
            // AllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSrc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSrc);
            this.Name = "AllBooks";
            this.Text = "AllBooks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSrc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSrc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSrc;
        private System.Windows.Forms.Button buttonSrc;
        private System.Windows.Forms.Panel panel1;
    }
}