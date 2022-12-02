namespace IgazsagTabla
{
    partial class MainWindow
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
            if (disposing && (components != null)) {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hogyanMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.igazTblView = new System.Windows.Forms.ListView();
            this.tblLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.inLogFüg = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.ErrorMsgLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.tblLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hogyanMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(810, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hogyanMenuStrip
            // 
            this.hogyanMenuStrip.Name = "hogyanMenuStrip";
            this.hogyanMenuStrip.Size = new System.Drawing.Size(128, 36);
            this.hogyanMenuStrip.Text = "Hogyan?";
            this.hogyanMenuStrip.Click += new System.EventHandler(this.hogyanMenuStrip_Click);
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.igazTblView, 0, 1);
            this.mainLayout.Controls.Add(this.tblLayoutPanel, 0, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 42);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(810, 645);
            this.mainLayout.TabIndex = 9;
            // 
            // igazTblView
            // 
            this.igazTblView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.igazTblView.FullRowSelect = true;
            this.igazTblView.GridLines = true;
            this.igazTblView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.igazTblView.HoverSelection = true;
            this.igazTblView.Location = new System.Drawing.Point(22, 180);
            this.igazTblView.Margin = new System.Windows.Forms.Padding(22, 15, 22, 8);
            this.igazTblView.Name = "igazTblView";
            this.igazTblView.Size = new System.Drawing.Size(766, 457);
            this.igazTblView.TabIndex = 9;
            this.igazTblView.UseCompatibleStateImageBehavior = false;
            this.igazTblView.View = System.Windows.Forms.View.Details;
            // 
            // tblLayoutPanel
            // 
            this.tblLayoutPanel.ColumnCount = 3;
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tblLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tblLayoutPanel.Controls.Add(this.inLogFüg, 1, 0);
            this.tblLayoutPanel.Controls.Add(this.startBtn, 2, 0);
            this.tblLayoutPanel.Controls.Add(this.ErrorMsgLbl, 0, 1);
            this.tblLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanel.Location = new System.Drawing.Point(22, 8);
            this.tblLayoutPanel.Margin = new System.Windows.Forms.Padding(22, 8, 13, 8);
            this.tblLayoutPanel.Name = "tblLayoutPanel";
            this.tblLayoutPanel.RowCount = 2;
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanel.Size = new System.Drawing.Size(775, 149);
            this.tblLayoutPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 23, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Y";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inLogFüg
            // 
            this.inLogFüg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inLogFüg.Location = new System.Drawing.Point(68, 18);
            this.inLogFüg.Margin = new System.Windows.Forms.Padding(6, 18, 6, 8);
            this.inLogFüg.Name = "inLogFüg";
            this.inLogFüg.Size = new System.Drawing.Size(559, 39);
            this.inLogFüg.TabIndex = 4;
            this.inLogFüg.TextChanged += new System.EventHandler(this.Input1_TextChanged);
            // 
            // startBtn
            // 
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBtn.Location = new System.Drawing.Point(639, 15);
            this.startBtn.Margin = new System.Windows.Forms.Padding(6, 15, 6, 8);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(130, 54);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // ErrorMsgLbl
            // 
            this.ErrorMsgLbl.AutoSize = true;
            this.tblLayoutPanel.SetColumnSpan(this.ErrorMsgLbl, 3);
            this.ErrorMsgLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ErrorMsgLbl.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorMsgLbl.Location = new System.Drawing.Point(6, 89);
            this.ErrorMsgLbl.Margin = new System.Windows.Forms.Padding(6, 12, 6, 0);
            this.ErrorMsgLbl.Name = "ErrorMsgLbl";
            this.ErrorMsgLbl.Size = new System.Drawing.Size(763, 32);
            this.ErrorMsgLbl.TabIndex = 2;
            this.ErrorMsgLbl.Text = "Hibaüzenet szövege";
            this.ErrorMsgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 687);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MinimumSize = new System.Drawing.Size(836, 758);
            this.Name = "MainWindow";
            this.Text = "Igazságtábla generátor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.tblLayoutPanel.ResumeLayout(false);
            this.tblLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hogyanMenuStrip;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.ListView igazTblView;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorMsgLbl;
        private System.Windows.Forms.TextBox inLogFüg;
        private System.Windows.Forms.Button startBtn;





    }
}

