
namespace ImageToLua
{
    partial class UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.ScriptBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.Open = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.Copy = new System.Windows.Forms.Button();
            this.Credits = new System.Windows.Forms.Label();
            this.Top = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Button();
            this.maxWidthAdjuster = new System.Windows.Forms.NumericUpDown();
            this.Setting1 = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.maxHeightAdjuster = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptBox)).BeginInit();
            this.Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxWidthAdjuster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHeightAdjuster)).BeginInit();
            this.SuspendLayout();
            // 
            // ScriptBox
            // 
            this.ScriptBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ScriptBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.ScriptBox.AutoScrollMinSize = new System.Drawing.Size(53, 13);
            this.ScriptBox.BackBrush = null;
            this.ScriptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ScriptBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.ScriptBox.CaretColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.ScriptBox.CharHeight = 13;
            this.ScriptBox.CharWidth = 7;
            this.ScriptBox.CommentPrefix = "--";
            this.ScriptBox.CurrentLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ScriptBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScriptBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ScriptBox.Font = new System.Drawing.Font("Courier New", 9F);
            this.ScriptBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ScriptBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ScriptBox.IsReplaceMode = false;
            this.ScriptBox.Language = FastColoredTextBoxNS.Language.Lua;
            this.ScriptBox.LeftBracket = '(';
            this.ScriptBox.LeftBracket2 = '{';
            this.ScriptBox.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ScriptBox.Location = new System.Drawing.Point(6, 36);
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ScriptBox.ReadOnly = true;
            this.ScriptBox.ReservedCountOfLineNumberChars = 5;
            this.ScriptBox.RightBracket = ')';
            this.ScriptBox.RightBracket2 = '}';
            this.ScriptBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.ScriptBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ScriptBox.ServiceColors")));
            this.ScriptBox.ServiceLinesColor = System.Drawing.Color.Transparent;
            this.ScriptBox.Size = new System.Drawing.Size(244, 298);
            this.ScriptBox.TabIndex = 13;
            this.ScriptBox.Zoom = 100;
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Open.ForeColor = System.Drawing.Color.White;
            this.Open.Location = new System.Drawing.Point(256, 114);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(121, 33);
            this.Open.TabIndex = 15;
            this.Open.Text = "Open Image";
            this.Open.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            this.Open.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Open.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.Open.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.Open.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(256, 36);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(121, 33);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear Script";
            this.Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            this.Clear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Clear.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.Clear.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.Clear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // ofd
            // 
            this.ofd.Filter = "Image file (*.png)|*.png";
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Copy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Copy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Copy.ForeColor = System.Drawing.Color.White;
            this.Copy.Location = new System.Drawing.Point(256, 75);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(121, 33);
            this.Copy.TabIndex = 16;
            this.Copy.Text = "Copy Script";
            this.Copy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            this.Copy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Copy.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.Copy.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.Copy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(259, 316);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(118, 15);
            this.Credits.TabIndex = 17;
            this.Credits.Text = "github.com/mov-ebx";
            this.Credits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable);
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Top.Controls.Add(this.Exit);
            this.Top.Controls.Add(this.Minimize);
            this.Top.Controls.Add(this.Title);
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(384, 30);
            this.Top.TabIndex = 20;
            this.Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(363, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(21, 21);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "X";
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Exit.UseCompatibleTextRendering = true;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Exit.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.Exit.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.Exit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Minimize.Location = new System.Drawing.Point(340, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(21, 21);
            this.Minimize.TabIndex = 12;
            this.Minimize.Text = "_";
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Minimize.UseCompatibleTextRendering = true;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Minimize.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.Minimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Title.Location = new System.Drawing.Point(145, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(119, 15);
            this.Title.TabIndex = 0;
            this.Title.Text = "Image2Lua - v1.0.0b";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Info.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Info.ForeColor = System.Drawing.Color.White;
            this.Info.Location = new System.Drawing.Point(256, 280);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(121, 33);
            this.Info.TabIndex = 21;
            this.Info.Text = "How To Use";
            this.Info.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Info.UseVisualStyleBackColor = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            this.Info.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Info.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.Info.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.Info.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // maxWidthAdjuster
            // 
            this.maxWidthAdjuster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.maxWidthAdjuster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxWidthAdjuster.ForeColor = System.Drawing.Color.White;
            this.maxWidthAdjuster.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxWidthAdjuster.Location = new System.Drawing.Point(277, 196);
            this.maxWidthAdjuster.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.maxWidthAdjuster.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.maxWidthAdjuster.Name = "maxWidthAdjuster";
            this.maxWidthAdjuster.Size = new System.Drawing.Size(97, 21);
            this.maxWidthAdjuster.TabIndex = 24;
            this.maxWidthAdjuster.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // Setting1
            // 
            this.Setting1.AutoSize = true;
            this.Setting1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Setting1.Location = new System.Drawing.Point(253, 178);
            this.Setting1.Name = "Setting1";
            this.Setting1.Size = new System.Drawing.Size(104, 17);
            this.Setting1.TabIndex = 25;
            this.Setting1.Text = "Max Resolution";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(257, 198);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(18, 15);
            this.WidthLabel.TabIndex = 26;
            this.WidthLabel.Text = "W";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(257, 225);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(16, 15);
            this.HeightLabel.TabIndex = 28;
            this.HeightLabel.Text = "H";
            // 
            // maxHeightAdjuster
            // 
            this.maxHeightAdjuster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.maxHeightAdjuster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxHeightAdjuster.ForeColor = System.Drawing.Color.White;
            this.maxHeightAdjuster.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxHeightAdjuster.Location = new System.Drawing.Point(277, 223);
            this.maxHeightAdjuster.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.maxHeightAdjuster.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.maxHeightAdjuster.Name = "maxHeightAdjuster";
            this.maxHeightAdjuster.Size = new System.Drawing.Size(97, 21);
            this.maxHeightAdjuster.TabIndex = 27;
            this.maxHeightAdjuster.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(384, 340);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.maxHeightAdjuster);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.Setting1);
            this.Controls.Add(this.maxWidthAdjuster);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ScriptBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image2Lua";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draggable);
            ((System.ComponentModel.ISupportInitialize)(this.ScriptBox)).EndInit();
            this.Top.ResumeLayout(false);
            this.Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxWidthAdjuster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHeightAdjuster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox ScriptBox;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Label Credits;
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.NumericUpDown maxWidthAdjuster;
        private System.Windows.Forms.Label Setting1;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.NumericUpDown maxHeightAdjuster;
    }
}

