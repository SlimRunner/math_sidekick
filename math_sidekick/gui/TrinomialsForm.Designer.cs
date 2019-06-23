namespace math_sidekick
{
    partial class TrinomialsForm
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
            this.PlotCanvas = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TextInputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SecondResultDisplay = new System.Windows.Forms.TextBox();
            this.FirstResultDisplay = new System.Windows.Forms.TextBox();
            this.FindRootsButton = new System.Windows.Forms.Button();
            this.TermA_Label = new System.Windows.Forms.Label();
            this.SecondResLabel = new System.Windows.Forms.Label();
            this.TermA_Input = new System.Windows.Forms.TextBox();
            this.FirstResLabel = new System.Windows.Forms.Label();
            this.TermB_Label = new System.Windows.Forms.Label();
            this.TermC_Label = new System.Windows.Forms.Label();
            this.TermB_Input = new System.Windows.Forms.TextBox();
            this.TermC_Input = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlotCanvas)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.TextInputLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlotCanvas
            // 
            this.PlotCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlotCanvas.Location = new System.Drawing.Point(209, 90);
            this.PlotCanvas.Margin = new System.Windows.Forms.Padding(6);
            this.PlotCanvas.Name = "PlotCanvas";
            this.PlotCanvas.Size = new System.Drawing.Size(401, 337);
            this.PlotCanvas.TabIndex = 0;
            this.PlotCanvas.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.MainLayout);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(4);
            this.MainPanel.Size = new System.Drawing.Size(624, 441);
            this.MainPanel.TabIndex = 0;
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.MainLayout.Controls.Add(this.TextInputLayout, 0, 1);
            this.MainLayout.Controls.Add(this.TitleLabel, 0, 0);
            this.MainLayout.Controls.Add(this.PlotCanvas, 1, 2);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(4, 4);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Size = new System.Drawing.Size(616, 433);
            this.MainLayout.TabIndex = 0;
            // 
            // TextInputLayout
            // 
            this.TextInputLayout.ColumnCount = 3;
            this.TextInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TextInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TextInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.TextInputLayout.Controls.Add(this.SecondResultDisplay, 1, 5);
            this.TextInputLayout.Controls.Add(this.TermA_Label, 0, 0);
            this.TextInputLayout.Controls.Add(this.SecondResLabel, 0, 5);
            this.TextInputLayout.Controls.Add(this.TermA_Input, 2, 0);
            this.TextInputLayout.Controls.Add(this.FirstResLabel, 0, 4);
            this.TextInputLayout.Controls.Add(this.FindRootsButton, 1, 3);
            this.TextInputLayout.Controls.Add(this.TermB_Label, 0, 1);
            this.TextInputLayout.Controls.Add(this.TermC_Label, 0, 2);
            this.TextInputLayout.Controls.Add(this.TermB_Input, 2, 1);
            this.TextInputLayout.Controls.Add(this.TermC_Input, 2, 2);
            this.TextInputLayout.Controls.Add(this.FirstResultDisplay, 1, 4);
            this.TextInputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextInputLayout.Location = new System.Drawing.Point(0, 44);
            this.TextInputLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TextInputLayout.MinimumSize = new System.Drawing.Size(88, 136);
            this.TextInputLayout.Name = "TextInputLayout";
            this.TextInputLayout.RowCount = 7;
            this.MainLayout.SetRowSpan(this.TextInputLayout, 2);
            this.TextInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TextInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TextInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TextInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TextInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TextInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TextInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TextInputLayout.Size = new System.Drawing.Size(203, 389);
            this.TextInputLayout.TabIndex = 1;
            // 
            // SecondResultDisplay
            // 
            this.SecondResultDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextInputLayout.SetColumnSpan(this.SecondResultDisplay, 2);
            this.SecondResultDisplay.Location = new System.Drawing.Point(47, 214);
            this.SecondResultDisplay.Margin = new System.Windows.Forms.Padding(6);
            this.SecondResultDisplay.Name = "SecondResultDisplay";
            this.SecondResultDisplay.ReadOnly = true;
            this.SecondResultDisplay.Size = new System.Drawing.Size(150, 30);
            this.SecondResultDisplay.TabIndex = 10;
            this.SecondResultDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SecondResultDisplay.Enter += new System.EventHandler(this.TextOutputGroup_Enter);
            // 
            // FirstResultDisplay
            // 
            this.FirstResultDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextInputLayout.SetColumnSpan(this.FirstResultDisplay, 2);
            this.FirstResultDisplay.Location = new System.Drawing.Point(47, 172);
            this.FirstResultDisplay.Margin = new System.Windows.Forms.Padding(6);
            this.FirstResultDisplay.Name = "FirstResultDisplay";
            this.FirstResultDisplay.ReadOnly = true;
            this.FirstResultDisplay.Size = new System.Drawing.Size(150, 30);
            this.FirstResultDisplay.TabIndex = 8;
            this.FirstResultDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FirstResultDisplay.Enter += new System.EventHandler(this.TextOutputGroup_Enter);
            // 
            // FindRootsButton
            // 
            this.FindRootsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextInputLayout.SetColumnSpan(this.FindRootsButton, 2);
            this.FindRootsButton.Location = new System.Drawing.Point(45, 130);
            this.FindRootsButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindRootsButton.Name = "FindRootsButton";
            this.FindRootsButton.Size = new System.Drawing.Size(154, 32);
            this.FindRootsButton.TabIndex = 6;
            this.FindRootsButton.Text = "Find Roots";
            this.FindRootsButton.UseVisualStyleBackColor = true;
            this.FindRootsButton.Click += new System.EventHandler(this.FindRootsButton_Click);
            // 
            // TermA_Label
            // 
            this.TermA_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TermA_Label.AutoSize = true;
            this.TermA_Label.Location = new System.Drawing.Point(14, 10);
            this.TermA_Label.Name = "TermA_Label";
            this.TermA_Label.Size = new System.Drawing.Size(24, 22);
            this.TermA_Label.TabIndex = 0;
            this.TermA_Label.Text = "&a:";
            // 
            // SecondResLabel
            // 
            this.SecondResLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SecondResLabel.AutoSize = true;
            this.SecondResLabel.Location = new System.Drawing.Point(3, 218);
            this.SecondResLabel.Name = "SecondResLabel";
            this.SecondResLabel.Size = new System.Drawing.Size(35, 22);
            this.SecondResLabel.TabIndex = 9;
            this.SecondResLabel.Text = "x&2:";
            // 
            // TermA_Input
            // 
            this.TermA_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TermA_Input.BackColor = System.Drawing.SystemColors.Window;
            this.TermA_Input.Location = new System.Drawing.Point(100, 6);
            this.TermA_Input.Margin = new System.Windows.Forms.Padding(6);
            this.TermA_Input.Name = "TermA_Input";
            this.TermA_Input.Size = new System.Drawing.Size(97, 30);
            this.TermA_Input.TabIndex = 1;
            this.TermA_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TermA_Input.TextChanged += new System.EventHandler(this.TextInputGroup_TextChanged);
            this.TermA_Input.Enter += new System.EventHandler(this.TextInputGroup_Enter);
            // 
            // FirstResLabel
            // 
            this.FirstResLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FirstResLabel.AutoSize = true;
            this.FirstResLabel.Location = new System.Drawing.Point(3, 176);
            this.FirstResLabel.Name = "FirstResLabel";
            this.FirstResLabel.Size = new System.Drawing.Size(35, 22);
            this.FirstResLabel.TabIndex = 7;
            this.FirstResLabel.Text = "x&1:";
            // 
            // TermB_Label
            // 
            this.TermB_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TermB_Label.AutoSize = true;
            this.TermB_Label.Location = new System.Drawing.Point(13, 52);
            this.TermB_Label.Name = "TermB_Label";
            this.TermB_Label.Size = new System.Drawing.Size(25, 22);
            this.TermB_Label.TabIndex = 2;
            this.TermB_Label.Text = "&b:";
            // 
            // TermC_Label
            // 
            this.TermC_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TermC_Label.AutoSize = true;
            this.TermC_Label.Location = new System.Drawing.Point(15, 94);
            this.TermC_Label.Name = "TermC_Label";
            this.TermC_Label.Size = new System.Drawing.Size(23, 22);
            this.TermC_Label.TabIndex = 4;
            this.TermC_Label.Text = "&c:";
            // 
            // TermB_Input
            // 
            this.TermB_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TermB_Input.Location = new System.Drawing.Point(100, 48);
            this.TermB_Input.Margin = new System.Windows.Forms.Padding(6);
            this.TermB_Input.Name = "TermB_Input";
            this.TermB_Input.Size = new System.Drawing.Size(97, 30);
            this.TermB_Input.TabIndex = 3;
            this.TermB_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TermB_Input.TextChanged += new System.EventHandler(this.TextInputGroup_TextChanged);
            this.TermB_Input.Enter += new System.EventHandler(this.TextInputGroup_Enter);
            // 
            // TermC_Input
            // 
            this.TermC_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TermC_Input.Location = new System.Drawing.Point(100, 90);
            this.TermC_Input.Margin = new System.Windows.Forms.Padding(6);
            this.TermC_Input.Name = "TermC_Input";
            this.TermC_Input.Size = new System.Drawing.Size(97, 30);
            this.TermC_Input.TabIndex = 5;
            this.TermC_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TermC_Input.TextChanged += new System.EventHandler(this.TextInputGroup_TextChanged);
            this.TermC_Input.Enter += new System.EventHandler(this.TextInputGroup_Enter);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.MainLayout.SetColumnSpan(this.TitleLabel, 2);
            this.TitleLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(162, 8);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(8);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(292, 28);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Quadratic Trinomial Solver";
            // 
            // TrinomialsForm
            // 
            this.AcceptButton = this.FindRootsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(480, 360);
            this.Name = "TrinomialsForm";
            this.Text = "Quadratic Trinomials Solver";
            ((System.ComponentModel.ISupportInitialize)(this.PlotCanvas)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.TextInputLayout.ResumeLayout(false);
            this.TextInputLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlotCanvas;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel TextInputLayout;
        private System.Windows.Forms.Label TermA_Label;
        private System.Windows.Forms.TextBox TermA_Input;
        private System.Windows.Forms.Label TermB_Label;
        private System.Windows.Forms.Label TermC_Label;
        private System.Windows.Forms.TextBox TermB_Input;
        private System.Windows.Forms.TextBox TermC_Input;
        private System.Windows.Forms.TextBox SecondResultDisplay;
        private System.Windows.Forms.TextBox FirstResultDisplay;
        private System.Windows.Forms.Button FindRootsButton;
        private System.Windows.Forms.Label FirstResLabel;
        private System.Windows.Forms.Label SecondResLabel;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Label TitleLabel;
    }
}

