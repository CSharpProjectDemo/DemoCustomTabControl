namespace DemoCustomTabControl
{
    partial class demoCustomTabControlForm
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
            this.panelButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnTab1 = new System.Windows.Forms.Button();
            this.btnTab2 = new System.Windows.Forms.Button();
            this.btnTab3 = new System.Windows.Forms.Button();
            this.btnTab4 = new System.Windows.Forms.Button();
            this.btnTab5 = new System.Windows.Forms.Button();
            this.panelTabControl = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.panelButton.SuspendLayout();
            this.panelTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.ColumnCount = 5;
            this.panelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelButton.Controls.Add(this.btnTab1, 0, 0);
            this.panelButton.Controls.Add(this.btnTab2, 1, 0);
            this.panelButton.Controls.Add(this.btnTab3, 2, 0);
            this.panelButton.Controls.Add(this.btnTab4, 3, 0);
            this.panelButton.Controls.Add(this.btnTab5, 4, 0);
            this.panelButton.Location = new System.Drawing.Point(2, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.RowCount = 1;
            this.panelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelButton.Size = new System.Drawing.Size(781, 48);
            this.panelButton.TabIndex = 0;
            // 
            // btnTab1
            // 
            this.btnTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTab1.FlatAppearance.BorderSize = 0;
            this.btnTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTab1.Location = new System.Drawing.Point(3, 3);
            this.btnTab1.Name = "btnTab1";
            this.btnTab1.Size = new System.Drawing.Size(150, 42);
            this.btnTab1.TabIndex = 0;
            this.btnTab1.Text = "Tab 1";
            this.btnTab1.UseVisualStyleBackColor = true;
            this.btnTab1.Click += new System.EventHandler(this.btnTab1_Click);
            // 
            // btnTab2
            // 
            this.btnTab2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTab2.FlatAppearance.BorderSize = 0;
            this.btnTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTab2.Location = new System.Drawing.Point(159, 3);
            this.btnTab2.Name = "btnTab2";
            this.btnTab2.Size = new System.Drawing.Size(150, 42);
            this.btnTab2.TabIndex = 0;
            this.btnTab2.Text = "Tab 2";
            this.btnTab2.UseVisualStyleBackColor = true;
            this.btnTab2.Click += new System.EventHandler(this.btnTab2_Click);
            // 
            // btnTab3
            // 
            this.btnTab3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTab3.FlatAppearance.BorderSize = 0;
            this.btnTab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTab3.Location = new System.Drawing.Point(315, 3);
            this.btnTab3.Name = "btnTab3";
            this.btnTab3.Size = new System.Drawing.Size(150, 42);
            this.btnTab3.TabIndex = 0;
            this.btnTab3.Text = "Tab 3";
            this.btnTab3.UseVisualStyleBackColor = true;
            this.btnTab3.Click += new System.EventHandler(this.btnTab3_Click);
            // 
            // btnTab4
            // 
            this.btnTab4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTab4.FlatAppearance.BorderSize = 0;
            this.btnTab4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTab4.Location = new System.Drawing.Point(471, 3);
            this.btnTab4.Name = "btnTab4";
            this.btnTab4.Size = new System.Drawing.Size(150, 42);
            this.btnTab4.TabIndex = 0;
            this.btnTab4.Text = "Tab 4";
            this.btnTab4.UseVisualStyleBackColor = true;
            this.btnTab4.Click += new System.EventHandler(this.btnTab4_Click);
            // 
            // btnTab5
            // 
            this.btnTab5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTab5.FlatAppearance.BorderSize = 0;
            this.btnTab5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTab5.Location = new System.Drawing.Point(627, 3);
            this.btnTab5.Name = "btnTab5";
            this.btnTab5.Size = new System.Drawing.Size(151, 42);
            this.btnTab5.TabIndex = 0;
            this.btnTab5.Text = "Tab 5";
            this.btnTab5.UseVisualStyleBackColor = true;
            this.btnTab5.Click += new System.EventHandler(this.btnTab5_Click);
            // 
            // panelTabControl
            // 
            this.panelTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTabControl.ColumnCount = 1;
            this.panelTabControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTabControl.Controls.Add(this.tabControl, 0, 0);
            this.panelTabControl.Location = new System.Drawing.Point(2, 49);
            this.panelTabControl.Name = "panelTabControl";
            this.panelTabControl.RowCount = 1;
            this.panelTabControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTabControl.Size = new System.Drawing.Size(781, 432);
            this.panelTabControl.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 426);
            this.tabControl.TabIndex = 0;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            this.tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDown);
            // 
            // demoCustomTabControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.panelTabControl);
            this.Controls.Add(this.panelButton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(800, 520);
            this.Name = "demoCustomTabControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Custom Tabcontrol";
            this.Load += new System.EventHandler(this.demoCustomTabControlForm_Load);
            this.panelButton.ResumeLayout(false);
            this.panelTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelButton;
        private System.Windows.Forms.Button btnTab1;
        private System.Windows.Forms.Button btnTab2;
        private System.Windows.Forms.Button btnTab3;
        private System.Windows.Forms.Button btnTab4;
        private System.Windows.Forms.Button btnTab5;
        private System.Windows.Forms.TableLayoutPanel panelTabControl;
        private System.Windows.Forms.TabControl tabControl;
    }
}

