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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TestButton = new System.Windows.Forms.Button();
            this.InputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TermA_Label = new System.Windows.Forms.Label();
            this.TermA_Input = new System.Windows.Forms.TextBox();
            this.TermB_Label = new System.Windows.Forms.Label();
            this.TermC_Label = new System.Windows.Forms.Label();
            this.TermB_Input = new System.Windows.Forms.TextBox();
            this.TermC_Input = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FindRootsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstResultDisplay = new System.Windows.Forms.TextBox();
            this.SecondResultDisplay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlotCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.InputLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlotCanvas
            // 
            this.PlotCanvas.Location = new System.Drawing.Point(456, 256);
            this.PlotCanvas.Name = "PlotCanvas";
            this.PlotCanvas.Size = new System.Drawing.Size(184, 152);
            this.PlotCanvas.TabIndex = 0;
            this.PlotCanvas.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.TestButton);
            this.panel1.Controls.Add(this.InputLayout);
            this.panel1.Controls.Add(this.PlotCanvas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 421);
            this.panel1.TabIndex = 1;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(64, 344);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(128, 24);
            this.TestButton.TabIndex = 2;
            this.TestButton.Text = "Test Graphics";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // InputLayout
            // 
            this.InputLayout.ColumnCount = 2;
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InputLayout.Controls.Add(this.TermA_Label, 0, 0);
            this.InputLayout.Controls.Add(this.TermA_Input, 1, 0);
            this.InputLayout.Controls.Add(this.TermB_Label, 0, 1);
            this.InputLayout.Controls.Add(this.TermC_Label, 0, 2);
            this.InputLayout.Controls.Add(this.TermB_Input, 1, 1);
            this.InputLayout.Controls.Add(this.TermC_Input, 1, 2);
            this.InputLayout.Location = new System.Drawing.Point(48, 56);
            this.InputLayout.MinimumSize = new System.Drawing.Size(88, 136);
            this.InputLayout.Name = "InputLayout";
            this.InputLayout.RowCount = 4;
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputLayout.Size = new System.Drawing.Size(208, 152);
            this.InputLayout.TabIndex = 1;
            // 
            // TermA_Label
            // 
            this.TermA_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TermA_Label.AutoSize = true;
            this.TermA_Label.Location = new System.Drawing.Point(4, 8);
            this.TermA_Label.Name = "TermA_Label";
            this.TermA_Label.Size = new System.Drawing.Size(18, 17);
            this.TermA_Label.TabIndex = 0;
            this.TermA_Label.Text = "a:";
            // 
            // TermA_Input
            // 
            this.TermA_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TermA_Input.Location = new System.Drawing.Point(28, 4);
            this.TermA_Input.MaximumSize = new System.Drawing.Size(100, 25);
            this.TermA_Input.Name = "TermA_Input";
            this.TermA_Input.Size = new System.Drawing.Size(100, 25);
            this.TermA_Input.TabIndex = 1;
            this.TermA_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TermB_Label
            // 
            this.TermB_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TermB_Label.AutoSize = true;
            this.TermB_Label.Location = new System.Drawing.Point(3, 41);
            this.TermB_Label.Name = "TermB_Label";
            this.TermB_Label.Size = new System.Drawing.Size(19, 17);
            this.TermB_Label.TabIndex = 2;
            this.TermB_Label.Text = "b:";
            // 
            // TermC_Label
            // 
            this.TermC_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TermC_Label.AutoSize = true;
            this.TermC_Label.Location = new System.Drawing.Point(5, 74);
            this.TermC_Label.Name = "TermC_Label";
            this.TermC_Label.Size = new System.Drawing.Size(17, 17);
            this.TermC_Label.TabIndex = 3;
            this.TermC_Label.Text = "c:";
            // 
            // TermB_Input
            // 
            this.TermB_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TermB_Input.Location = new System.Drawing.Point(28, 37);
            this.TermB_Input.MaximumSize = new System.Drawing.Size(100, 25);
            this.TermB_Input.Name = "TermB_Input";
            this.TermB_Input.Size = new System.Drawing.Size(100, 25);
            this.TermB_Input.TabIndex = 4;
            this.TermB_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TermC_Input
            // 
            this.TermC_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TermC_Input.Location = new System.Drawing.Point(28, 70);
            this.TermC_Input.MaximumSize = new System.Drawing.Size(100, 25);
            this.TermC_Input.Name = "TermC_Input";
            this.TermC_Input.Size = new System.Drawing.Size(100, 25);
            this.TermC_Input.TabIndex = 5;
            this.TermC_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SecondResultDisplay, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.FirstResultDisplay, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.FindRootsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(288, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 120);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // FindRootsButton
            // 
            this.FindRootsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.FindRootsButton, 2);
            this.FindRootsButton.Location = new System.Drawing.Point(16, 3);
            this.FindRootsButton.Margin = new System.Windows.Forms.Padding(16, 3, 16, 3);
            this.FindRootsButton.Name = "FindRootsButton";
            this.FindRootsButton.Size = new System.Drawing.Size(176, 27);
            this.FindRootsButton.TabIndex = 0;
            this.FindRootsButton.Text = "Find Roots";
            this.FindRootsButton.UseVisualStyleBackColor = true;
            this.FindRootsButton.Click += new System.EventHandler(this.FindRootsButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "x1:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "x2:";
            // 
            // FirstResultDisplay
            // 
            this.FirstResultDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstResultDisplay.Location = new System.Drawing.Point(33, 37);
            this.FirstResultDisplay.MaximumSize = new System.Drawing.Size(100, 25);
            this.FirstResultDisplay.Name = "FirstResultDisplay";
            this.FirstResultDisplay.Size = new System.Drawing.Size(100, 25);
            this.FirstResultDisplay.TabIndex = 3;
            this.FirstResultDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SecondResultDisplay
            // 
            this.SecondResultDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondResultDisplay.Location = new System.Drawing.Point(33, 70);
            this.SecondResultDisplay.MaximumSize = new System.Drawing.Size(100, 25);
            this.SecondResultDisplay.Name = "SecondResultDisplay";
            this.SecondResultDisplay.Size = new System.Drawing.Size(100, 25);
            this.SecondResultDisplay.TabIndex = 4;
            this.SecondResultDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TrinomialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 421);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TrinomialsForm";
            this.Text = "Trinomials";
            ((System.ComponentModel.ISupportInitialize)(this.PlotCanvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.InputLayout.ResumeLayout(false);
            this.InputLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlotCanvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel InputLayout;
        private System.Windows.Forms.Label TermA_Label;
        private System.Windows.Forms.TextBox TermA_Input;
        private System.Windows.Forms.Label TermB_Label;
        private System.Windows.Forms.Label TermC_Label;
        private System.Windows.Forms.TextBox TermB_Input;
        private System.Windows.Forms.TextBox TermC_Input;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox SecondResultDisplay;
        private System.Windows.Forms.TextBox FirstResultDisplay;
        private System.Windows.Forms.Button FindRootsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

