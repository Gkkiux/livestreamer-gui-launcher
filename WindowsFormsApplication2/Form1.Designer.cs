namespace LivestreamerLauncher
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.buttonBest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.qualityButtons = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter launch options:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_Validating);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Validating);
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(379, 23);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(75, 23);
            this.buttonLaunch.TabIndex = 2;
            this.buttonLaunch.Text = "Launch";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // buttonBest
            // 
            this.buttonBest.Location = new System.Drawing.Point(460, 23);
            this.buttonBest.Name = "buttonBest";
            this.buttonBest.Size = new System.Drawing.Size(75, 23);
            this.buttonBest.TabIndex = 6;
            this.buttonBest.Text = "Best";
            this.buttonBest.UseVisualStyleBackColor = true;
            this.buttonBest.Click += new System.EventHandler(this.buttonBest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Quality";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonQualities_Click);
            // 
            // qualityButtons
            // 
            this.qualityButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.qualityButtons.AutoScroll = true;
            this.qualityButtons.AutoSize = true;
            this.qualityButtons.ColumnCount = 1;
            this.qualityButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.qualityButtons.Location = new System.Drawing.Point(1, 49);
            this.qualityButtons.Margin = new System.Windows.Forms.Padding(0);
            this.qualityButtons.MaximumSize = new System.Drawing.Size(544, 50);
            this.qualityButtons.Name = "qualityButtons";
            this.qualityButtons.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.qualityButtons.RowCount = 1;
            this.qualityButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.qualityButtons.Size = new System.Drawing.Size(544, 50);
            this.qualityButtons.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonLaunch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 101);
            this.Controls.Add(this.qualityButtons);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBest);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Launch Livestreamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.Button buttonBest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel qualityButtons;
    }
}

