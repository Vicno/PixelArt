namespace Paint3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlls = new System.Windows.Forms.GroupBox();
            this.radioButtonScale05X = new System.Windows.Forms.RadioButton();
            this.radioButtonScale2X = new System.Windows.Forms.RadioButton();
            this.TranslateDrawing = new System.Windows.Forms.RadioButton();
            this.FloodPaint = new System.Windows.Forms.RadioButton();
            this.Elipse = new System.Windows.Forms.RadioButton();
            this.BresenhamCircle = new System.Windows.Forms.RadioButton();
            this.BresenhamLine = new System.Windows.Forms.RadioButton();
            this.drawPixel = new System.Windows.Forms.RadioButton();
            this.drawDDALine = new System.Windows.Forms.RadioButton();
            this.Delete = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorSelect = new System.Windows.Forms.Button();
            this.SizeBar = new System.Windows.Forms.TrackBar();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ColorBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.Rotate90Right = new System.Windows.Forms.RadioButton();
            this.Rotate90Left = new System.Windows.Forms.RadioButton();
            this.controlls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 800);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // controlls
            // 
            this.controlls.Controls.Add(this.Rotate90Left);
            this.controlls.Controls.Add(this.Rotate90Right);
            this.controlls.Controls.Add(this.radioButtonScale05X);
            this.controlls.Controls.Add(this.radioButtonScale2X);
            this.controlls.Controls.Add(this.TranslateDrawing);
            this.controlls.Controls.Add(this.FloodPaint);
            this.controlls.Controls.Add(this.Elipse);
            this.controlls.Controls.Add(this.BresenhamCircle);
            this.controlls.Controls.Add(this.BresenhamLine);
            this.controlls.Controls.Add(this.drawPixel);
            this.controlls.Controls.Add(this.drawDDALine);
            this.controlls.Location = new System.Drawing.Point(859, 12);
            this.controlls.Name = "controlls";
            this.controlls.Size = new System.Drawing.Size(152, 376);
            this.controlls.TabIndex = 1;
            this.controlls.TabStop = false;
            this.controlls.Text = "controlls";
            // 
            // radioButtonScale05X
            // 
            this.radioButtonScale05X.AutoSize = true;
            this.radioButtonScale05X.Location = new System.Drawing.Point(6, 220);
            this.radioButtonScale05X.Name = "radioButtonScale05X";
            this.radioButtonScale05X.Size = new System.Drawing.Size(97, 21);
            this.radioButtonScale05X.TabIndex = 8;
            this.radioButtonScale05X.TabStop = true;
            this.radioButtonScale05X.Text = "Scale 0.5X";
            this.radioButtonScale05X.UseVisualStyleBackColor = true;
            this.radioButtonScale05X.CheckedChanged += new System.EventHandler(this.radioButtonScale05X_CheckedChanged);
            // 
            // radioButtonScale2X
            // 
            this.radioButtonScale2X.AutoSize = true;
            this.radioButtonScale2X.Location = new System.Drawing.Point(7, 193);
            this.radioButtonScale2X.Name = "radioButtonScale2X";
            this.radioButtonScale2X.Size = new System.Drawing.Size(85, 21);
            this.radioButtonScale2X.TabIndex = 7;
            this.radioButtonScale2X.TabStop = true;
            this.radioButtonScale2X.Text = "Scale 2X";
            this.radioButtonScale2X.UseVisualStyleBackColor = true;
            this.radioButtonScale2X.CheckedChanged += new System.EventHandler(this.radioButtonScale2X_CheckedChanged);
            // 
            // TranslateDrawing
            // 
            this.TranslateDrawing.AutoSize = true;
            this.TranslateDrawing.Location = new System.Drawing.Point(7, 166);
            this.TranslateDrawing.Name = "TranslateDrawing";
            this.TranslateDrawing.Size = new System.Drawing.Size(89, 21);
            this.TranslateDrawing.TabIndex = 6;
            this.TranslateDrawing.TabStop = true;
            this.TranslateDrawing.Text = "Translate";
            this.TranslateDrawing.UseVisualStyleBackColor = true;
            this.TranslateDrawing.CheckedChanged += new System.EventHandler(this.TranslateDrawing_CheckedChanged);
            // 
            // FloodPaint
            // 
            this.FloodPaint.AutoSize = true;
            this.FloodPaint.Location = new System.Drawing.Point(6, 349);
            this.FloodPaint.Name = "FloodPaint";
            this.FloodPaint.Size = new System.Drawing.Size(96, 21);
            this.FloodPaint.TabIndex = 5;
            this.FloodPaint.TabStop = true;
            this.FloodPaint.Text = "FloodPaint";
            this.FloodPaint.UseVisualStyleBackColor = true;
            this.FloodPaint.CheckedChanged += new System.EventHandler(this.FloodPaint_CheckedChanged);
            // 
            // Elipse
            // 
            this.Elipse.AutoSize = true;
            this.Elipse.Location = new System.Drawing.Point(7, 138);
            this.Elipse.Name = "Elipse";
            this.Elipse.Size = new System.Drawing.Size(67, 21);
            this.Elipse.TabIndex = 4;
            this.Elipse.TabStop = true;
            this.Elipse.Text = "Elipse";
            this.Elipse.UseVisualStyleBackColor = true;
            this.Elipse.CheckedChanged += new System.EventHandler(this.Elipse_CheckedChanged);
            // 
            // BresenhamCircle
            // 
            this.BresenhamCircle.AutoSize = true;
            this.BresenhamCircle.Location = new System.Drawing.Point(7, 110);
            this.BresenhamCircle.Name = "BresenhamCircle";
            this.BresenhamCircle.Size = new System.Drawing.Size(136, 21);
            this.BresenhamCircle.TabIndex = 3;
            this.BresenhamCircle.TabStop = true;
            this.BresenhamCircle.Text = "BresenhamCircle";
            this.BresenhamCircle.UseVisualStyleBackColor = true;
            this.BresenhamCircle.CheckedChanged += new System.EventHandler(this.BresenhamCircle_CheckedChanged);
            // 
            // BresenhamLine
            // 
            this.BresenhamLine.AutoSize = true;
            this.BresenhamLine.Location = new System.Drawing.Point(7, 82);
            this.BresenhamLine.Name = "BresenhamLine";
            this.BresenhamLine.Size = new System.Drawing.Size(128, 21);
            this.BresenhamLine.TabIndex = 2;
            this.BresenhamLine.TabStop = true;
            this.BresenhamLine.Text = "BresenhamLine";
            this.BresenhamLine.UseVisualStyleBackColor = true;
            this.BresenhamLine.CheckedChanged += new System.EventHandler(this.BresenhamLine_CheckedChanged);
            // 
            // drawPixel
            // 
            this.drawPixel.AutoSize = true;
            this.drawPixel.Checked = true;
            this.drawPixel.Location = new System.Drawing.Point(7, 27);
            this.drawPixel.Name = "drawPixel";
            this.drawPixel.Size = new System.Drawing.Size(88, 21);
            this.drawPixel.TabIndex = 1;
            this.drawPixel.TabStop = true;
            this.drawPixel.Text = "drawPixel";
            this.drawPixel.UseVisualStyleBackColor = true;
            this.drawPixel.CheckedChanged += new System.EventHandler(this.drawPixel_CheckedChanged);
            // 
            // drawDDALine
            // 
            this.drawDDALine.AutoSize = true;
            this.drawDDALine.Location = new System.Drawing.Point(7, 54);
            this.drawDDALine.Name = "drawDDALine";
            this.drawDDALine.Size = new System.Drawing.Size(115, 21);
            this.drawDDALine.TabIndex = 0;
            this.drawDDALine.Text = "drawDDALine";
            this.drawDDALine.UseVisualStyleBackColor = true;
            this.drawDDALine.CheckedChanged += new System.EventHandler(this.drawDDALine_CheckedChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(859, 394);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(152, 48);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ColorSelect
            // 
            this.ColorSelect.Location = new System.Drawing.Point(859, 448);
            this.ColorSelect.Name = "ColorSelect";
            this.ColorSelect.Size = new System.Drawing.Size(152, 50);
            this.ColorSelect.TabIndex = 3;
            this.ColorSelect.Text = "Color Select";
            this.ColorSelect.UseVisualStyleBackColor = true;
            this.ColorSelect.Click += new System.EventHandler(this.ColorSelect_Click);
            // 
            // SizeBar
            // 
            this.SizeBar.Location = new System.Drawing.Point(859, 577);
            this.SizeBar.Maximum = 100;
            this.SizeBar.Minimum = 10;
            this.SizeBar.Name = "SizeBar";
            this.SizeBar.Size = new System.Drawing.Size(152, 56);
            this.SizeBar.TabIndex = 4;
            this.SizeBar.Value = 12;
            this.SizeBar.Scroll += new System.EventHandler(this.SizeBar_Scroll);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.BackColor = System.Drawing.Color.White;
            this.SizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SizeLabel.Location = new System.Drawing.Point(859, 636);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(2, 27);
            this.SizeLabel.TabIndex = 5;
            // 
            // ColorBox
            // 
            this.ColorBox.BackColor = System.Drawing.Color.Black;
            this.ColorBox.Location = new System.Drawing.Point(881, 504);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(100, 50);
            this.ColorBox.TabIndex = 6;
            this.ColorBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(863, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pixel Dimensionator";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(891, 817);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(44, 17);
            this.labelTest.TabIndex = 10;
            this.labelTest.Text = "TEST";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(879, 789);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 11;
            this.buttonTest.Text = "TestButton";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(879, 681);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(67, 23);
            this.buttonUp.TabIndex = 12;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(818, 720);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(56, 23);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(953, 720);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(58, 23);
            this.buttonRight.TabIndex = 0;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(879, 749);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(71, 23);
            this.buttonDown.TabIndex = 13;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(884, 720);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(63, 23);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Rotate90Right
            // 
            this.Rotate90Right.AutoSize = true;
            this.Rotate90Right.Location = new System.Drawing.Point(7, 247);
            this.Rotate90Right.Name = "Rotate90Right";
            this.Rotate90Right.Size = new System.Drawing.Size(120, 21);
            this.Rotate90Right.TabIndex = 9;
            this.Rotate90Right.TabStop = true;
            this.Rotate90Right.Text = "Rotate90Right";
            this.Rotate90Right.UseVisualStyleBackColor = true;
            this.Rotate90Right.CheckedChanged += new System.EventHandler(this.Rotate90Right_CheckedChanged);
            // 
            // Rotate90Left
            // 
            this.Rotate90Left.AutoSize = true;
            this.Rotate90Left.Location = new System.Drawing.Point(7, 274);
            this.Rotate90Left.Name = "Rotate90Left";
            this.Rotate90Left.Size = new System.Drawing.Size(111, 21);
            this.Rotate90Left.TabIndex = 10;
            this.Rotate90Left.TabStop = true;
            this.Rotate90Left.Text = "Rotate90Left";
            this.Rotate90Left.UseVisualStyleBackColor = true;
            this.Rotate90Left.CheckedChanged += new System.EventHandler(this.Rotate90Left_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 843);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.SizeBar);
            this.Controls.Add(this.ColorSelect);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.controlls);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlls.ResumeLayout(false);
            this.controlls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox controlls;
        private System.Windows.Forms.RadioButton drawDDALine;
        private System.Windows.Forms.RadioButton drawPixel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ColorSelect;
        private System.Windows.Forms.TrackBar SizeBar;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.PictureBox ColorBox;
        private System.Windows.Forms.RadioButton BresenhamLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton BresenhamCircle;
        private System.Windows.Forms.RadioButton Elipse;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.RadioButton FloodPaint;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.RadioButton TranslateDrawing;
        private System.Windows.Forms.RadioButton radioButtonScale2X;
        private System.Windows.Forms.RadioButton radioButtonScale05X;
        private System.Windows.Forms.RadioButton Rotate90Right;
        private System.Windows.Forms.RadioButton Rotate90Left;
    }
}

