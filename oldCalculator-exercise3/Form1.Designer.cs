namespace oldCalculator_exercise3
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
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.PnlDisplayContainer = new System.Windows.Forms.Panel();
            this.PnlDisplay = new System.Windows.Forms.Panel();
            this.TxtStoreToggle = new System.Windows.Forms.TextBox();
            this.TxtCurrent = new System.Windows.Forms.TextBox();
            this.TxtPrevious = new System.Windows.Forms.TextBox();
            this.PnlControls = new System.Windows.Forms.Panel();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnSubtraction = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.Btn1X = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnBackSpaces = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnPM = new System.Windows.Forms.Button();
            this.BtnSquareRoot = new System.Windows.Forms.Button();
            this.BtnMC = new System.Windows.Forms.Button();
            this.BtnMR = new System.Windows.Forms.Button();
            this.BtnMS = new System.Windows.Forms.Button();
            this.BtnMPlus = new System.Windows.Forms.Button();
            this.BtnMSubstract = new System.Windows.Forms.Button();
            this.PnlControlNums = new System.Windows.Forms.Panel();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnDecimal = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.PnlDisplayContainer.SuspendLayout();
            this.PnlDisplay.SuspendLayout();
            this.PnlControls.SuspendLayout();
            this.PnlControlNums.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(287, 28);
            this.PnlMenu.TabIndex = 0;
            // 
            // PnlDisplayContainer
            // 
            this.PnlDisplayContainer.Controls.Add(this.PnlDisplay);
            this.PnlDisplayContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDisplayContainer.Location = new System.Drawing.Point(0, 28);
            this.PnlDisplayContainer.Name = "PnlDisplayContainer";
            this.PnlDisplayContainer.Size = new System.Drawing.Size(287, 75);
            this.PnlDisplayContainer.TabIndex = 1;
            // 
            // PnlDisplay
            // 
            this.PnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDisplay.Controls.Add(this.TxtStoreToggle);
            this.PnlDisplay.Controls.Add(this.TxtCurrent);
            this.PnlDisplay.Controls.Add(this.TxtPrevious);
            this.PnlDisplay.Location = new System.Drawing.Point(14, 6);
            this.PnlDisplay.Margin = new System.Windows.Forms.Padding(9);
            this.PnlDisplay.Name = "PnlDisplay";
            this.PnlDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.PnlDisplay.Size = new System.Drawing.Size(261, 69);
            this.PnlDisplay.TabIndex = 0;
            // 
            // TxtStoreToggle
            // 
            this.TxtStoreToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.TxtStoreToggle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtStoreToggle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtStoreToggle.Location = new System.Drawing.Point(4, 40);
            this.TxtStoreToggle.Margin = new System.Windows.Forms.Padding(0);
            this.TxtStoreToggle.Multiline = true;
            this.TxtStoreToggle.Name = "TxtStoreToggle";
            this.TxtStoreToggle.ReadOnly = true;
            this.TxtStoreToggle.Size = new System.Drawing.Size(20, 20);
            this.TxtStoreToggle.TabIndex = 2;
            this.TxtStoreToggle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCurrent
            // 
            this.TxtCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.TxtCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCurrent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtCurrent.Dock = System.Windows.Forms.DockStyle.Right;
            this.TxtCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCurrent.ForeColor = System.Drawing.Color.Black;
            this.TxtCurrent.Location = new System.Drawing.Point(28, 33);
            this.TxtCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.TxtCurrent.Multiline = true;
            this.TxtCurrent.Name = "TxtCurrent";
            this.TxtCurrent.ReadOnly = true;
            this.TxtCurrent.Size = new System.Drawing.Size(228, 31);
            this.TxtCurrent.TabIndex = 1;
            this.TxtCurrent.Text = "0";
            this.TxtCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtPrevious
            // 
            this.TxtPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.TxtPrevious.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrevious.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtPrevious.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtPrevious.ForeColor = System.Drawing.Color.Black;
            this.TxtPrevious.Location = new System.Drawing.Point(3, 3);
            this.TxtPrevious.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.TxtPrevious.Multiline = true;
            this.TxtPrevious.Name = "TxtPrevious";
            this.TxtPrevious.ReadOnly = true;
            this.TxtPrevious.Size = new System.Drawing.Size(253, 30);
            this.TxtPrevious.TabIndex = 0;
            this.TxtPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PnlControls
            // 
            this.PnlControls.Controls.Add(this.BtnPlus);
            this.PnlControls.Controls.Add(this.BtnSubtraction);
            this.PnlControls.Controls.Add(this.BtnEquals);
            this.PnlControls.Controls.Add(this.BtnMultiply);
            this.PnlControls.Controls.Add(this.Btn1X);
            this.PnlControls.Controls.Add(this.BtnDivision);
            this.PnlControls.Controls.Add(this.BtnPercent);
            this.PnlControls.Controls.Add(this.BtnBackSpaces);
            this.PnlControls.Controls.Add(this.BtnC);
            this.PnlControls.Controls.Add(this.BtnCE);
            this.PnlControls.Controls.Add(this.BtnPM);
            this.PnlControls.Controls.Add(this.BtnSquareRoot);
            this.PnlControls.Controls.Add(this.BtnMC);
            this.PnlControls.Controls.Add(this.BtnMR);
            this.PnlControls.Controls.Add(this.BtnMS);
            this.PnlControls.Controls.Add(this.BtnMPlus);
            this.PnlControls.Controls.Add(this.BtnMSubstract);
            this.PnlControls.Controls.Add(this.PnlControlNums);
            this.PnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlControls.Location = new System.Drawing.Point(0, 106);
            this.PnlControls.Name = "PnlControls";
            this.PnlControls.Size = new System.Drawing.Size(287, 257);
            this.PnlControls.TabIndex = 2;
            // 
            // BtnPlus
            // 
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlus.Location = new System.Drawing.Point(181, 208);
            this.BtnPlus.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(42, 36);
            this.BtnPlus.TabIndex = 18;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.Handler_Operation_Clicked);
            // 
            // BtnSubtraction
            // 
            this.BtnSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtraction.Location = new System.Drawing.Point(181, 166);
            this.BtnSubtraction.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSubtraction.Name = "BtnSubtraction";
            this.BtnSubtraction.Size = new System.Drawing.Size(42, 36);
            this.BtnSubtraction.TabIndex = 16;
            this.BtnSubtraction.Text = "-";
            this.BtnSubtraction.UseVisualStyleBackColor = true;
            this.BtnSubtraction.Click += new System.EventHandler(this.Handler_Operation_Clicked);
            // 
            // BtnEquals
            // 
            this.BtnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquals.Location = new System.Drawing.Point(236, 166);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(42, 78);
            this.BtnEquals.TabIndex = 15;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = true;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiply.Location = new System.Drawing.Point(181, 126);
            this.BtnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(42, 36);
            this.BtnMultiply.TabIndex = 14;
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.Handler_Operation_Clicked);
            // 
            // Btn1X
            // 
            this.Btn1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1X.Location = new System.Drawing.Point(236, 126);
            this.Btn1X.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1X.Name = "Btn1X";
            this.Btn1X.Size = new System.Drawing.Size(42, 36);
            this.Btn1X.TabIndex = 13;
            this.Btn1X.Text = "1/x";
            this.Btn1X.UseVisualStyleBackColor = true;
            // 
            // BtnDivision
            // 
            this.BtnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivision.Location = new System.Drawing.Point(181, 84);
            this.BtnDivision.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(42, 36);
            this.BtnDivision.TabIndex = 12;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.Handler_Operation_Clicked);
            // 
            // BtnPercent
            // 
            this.BtnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPercent.Location = new System.Drawing.Point(236, 84);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(42, 36);
            this.BtnPercent.TabIndex = 11;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = true;
            // 
            // BtnBackSpaces
            // 
            this.BtnBackSpaces.Location = new System.Drawing.Point(9, 45);
            this.BtnBackSpaces.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBackSpaces.Name = "BtnBackSpaces";
            this.BtnBackSpaces.Size = new System.Drawing.Size(42, 36);
            this.BtnBackSpaces.TabIndex = 10;
            this.BtnBackSpaces.Text = "←";
            this.BtnBackSpaces.UseVisualStyleBackColor = true;
            this.BtnBackSpaces.Click += new System.EventHandler(this.BtnBackSpaces_Click);
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(118, 45);
            this.BtnC.Margin = new System.Windows.Forms.Padding(0);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(42, 36);
            this.BtnC.TabIndex = 9;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.Location = new System.Drawing.Point(62, 45);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(42, 36);
            this.BtnCE.TabIndex = 8;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnPM
            // 
            this.BtnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPM.Location = new System.Drawing.Point(181, 45);
            this.BtnPM.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(42, 36);
            this.BtnPM.TabIndex = 7;
            this.BtnPM.Text = "±";
            this.BtnPM.UseVisualStyleBackColor = true;
            this.BtnPM.Click += new System.EventHandler(this.BtnPM_Click);
            // 
            // BtnSquareRoot
            // 
            this.BtnSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSquareRoot.Location = new System.Drawing.Point(236, 45);
            this.BtnSquareRoot.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSquareRoot.Name = "BtnSquareRoot";
            this.BtnSquareRoot.Size = new System.Drawing.Size(42, 36);
            this.BtnSquareRoot.TabIndex = 6;
            this.BtnSquareRoot.Text = "√";
            this.BtnSquareRoot.UseVisualStyleBackColor = true;
            // 
            // BtnMC
            // 
            this.BtnMC.Location = new System.Drawing.Point(9, 3);
            this.BtnMC.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMC.Name = "BtnMC";
            this.BtnMC.Size = new System.Drawing.Size(42, 36);
            this.BtnMC.TabIndex = 5;
            this.BtnMC.Text = "MC";
            this.BtnMC.UseVisualStyleBackColor = true;
            // 
            // BtnMR
            // 
            this.BtnMR.Location = new System.Drawing.Point(62, 1);
            this.BtnMR.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMR.Name = "BtnMR";
            this.BtnMR.Size = new System.Drawing.Size(42, 36);
            this.BtnMR.TabIndex = 4;
            this.BtnMR.Text = "MR";
            this.BtnMR.UseVisualStyleBackColor = true;
            // 
            // BtnMS
            // 
            this.BtnMS.Location = new System.Drawing.Point(118, 3);
            this.BtnMS.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMS.Name = "BtnMS";
            this.BtnMS.Size = new System.Drawing.Size(42, 36);
            this.BtnMS.TabIndex = 3;
            this.BtnMS.Text = "MS";
            this.BtnMS.UseVisualStyleBackColor = true;
            // 
            // BtnMPlus
            // 
            this.BtnMPlus.Location = new System.Drawing.Point(181, 3);
            this.BtnMPlus.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMPlus.Name = "BtnMPlus";
            this.BtnMPlus.Size = new System.Drawing.Size(42, 36);
            this.BtnMPlus.TabIndex = 2;
            this.BtnMPlus.Text = "M+";
            this.BtnMPlus.UseVisualStyleBackColor = true;
            // 
            // BtnMSubstract
            // 
            this.BtnMSubstract.Location = new System.Drawing.Point(236, 3);
            this.BtnMSubstract.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMSubstract.Name = "BtnMSubstract";
            this.BtnMSubstract.Size = new System.Drawing.Size(42, 36);
            this.BtnMSubstract.TabIndex = 1;
            this.BtnMSubstract.Text = "M-";
            this.BtnMSubstract.UseVisualStyleBackColor = true;
            // 
            // PnlControlNums
            // 
            this.PnlControlNums.Controls.Add(this.Btn0);
            this.PnlControlNums.Controls.Add(this.BtnDecimal);
            this.PnlControlNums.Controls.Add(this.Btn1);
            this.PnlControlNums.Controls.Add(this.Btn2);
            this.PnlControlNums.Controls.Add(this.Btn3);
            this.PnlControlNums.Controls.Add(this.Btn4);
            this.PnlControlNums.Controls.Add(this.Btn5);
            this.PnlControlNums.Controls.Add(this.Btn6);
            this.PnlControlNums.Controls.Add(this.Btn7);
            this.PnlControlNums.Controls.Add(this.Btn8);
            this.PnlControlNums.Controls.Add(this.Btn9);
            this.PnlControlNums.Location = new System.Drawing.Point(0, 84);
            this.PnlControlNums.Name = "PnlControlNums";
            this.PnlControlNums.Size = new System.Drawing.Size(171, 176);
            this.PnlControlNums.TabIndex = 0;
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(9, 124);
            this.Btn0.Margin = new System.Windows.Forms.Padding(0);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(95, 36);
            this.Btn0.TabIndex = 11;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Handler_Num_Clicked);
            // 
            // BtnDecimal
            // 
            this.BtnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDecimal.Location = new System.Drawing.Point(118, 124);
            this.BtnDecimal.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDecimal.Name = "BtnDecimal";
            this.BtnDecimal.Size = new System.Drawing.Size(42, 36);
            this.BtnDecimal.TabIndex = 9;
            this.BtnDecimal.Text = ".";
            this.BtnDecimal.UseVisualStyleBackColor = true;
            this.BtnDecimal.Click += new System.EventHandler(this.Handler_Num_Clicked);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(9, 82);
            this.Btn1.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(42, 36);
            this.Btn1.TabIndex = 8;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Handler_Num_Clicked);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(62, 82);
            this.Btn2.Margin = new System.Windows.Forms.Padding(0);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(42, 36);
            this.Btn2.TabIndex = 7;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Handler_Num_Clicked);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(118, 82);
            this.Btn3.Margin = new System.Windows.Forms.Padding(0);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(42, 36);
            this.Btn3.TabIndex = 6;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Handler_Num_Clicked);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(9, 42);
            this.Btn4.Margin = new System.Windows.Forms.Padding(0);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(42, 36);
            this.Btn4.TabIndex = 5;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Handler_Num_Clicked);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(62, 42);
            this.Btn5.Margin = new System.Windows.Forms.Padding(0);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(42, 36);
            this.Btn5.TabIndex = 4;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Handler_Num_Clicked);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(118, 42);
            this.Btn6.Margin = new System.Windows.Forms.Padding(0);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(42, 36);
            this.Btn6.TabIndex = 3;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Handler_Num_Clicked);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(9, 0);
            this.Btn7.Margin = new System.Windows.Forms.Padding(0);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(42, 36);
            this.Btn7.TabIndex = 2;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Handler_Num_Clicked);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(62, 0);
            this.Btn8.Margin = new System.Windows.Forms.Padding(0);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(42, 36);
            this.Btn8.TabIndex = 1;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Handler_Num_Clicked);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(118, 0);
            this.Btn9.Margin = new System.Windows.Forms.Padding(0);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(42, 36);
            this.Btn9.TabIndex = 0;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Handler_Num_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(287, 363);
            this.Controls.Add(this.PnlControls);
            this.Controls.Add(this.PnlDisplayContainer);
            this.Controls.Add(this.PnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlDisplayContainer.ResumeLayout(false);
            this.PnlDisplay.ResumeLayout(false);
            this.PnlDisplay.PerformLayout();
            this.PnlControls.ResumeLayout(false);
            this.PnlControlNums.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Panel PnlDisplayContainer;
        private System.Windows.Forms.Panel PnlControls;
        private System.Windows.Forms.Panel PnlControlNums;
        private System.Windows.Forms.Button BtnMSubstract;
        private System.Windows.Forms.Button BtnMC;
        private System.Windows.Forms.Button BtnMR;
        private System.Windows.Forms.Button BtnMS;
        private System.Windows.Forms.Button BtnMPlus;
        private System.Windows.Forms.Button BtnBackSpaces;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnPM;
        private System.Windows.Forms.Button BtnSquareRoot;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnSubtraction;
        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button Btn1X;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnDecimal;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Panel PnlDisplay;
        private System.Windows.Forms.TextBox TxtPrevious;
        private System.Windows.Forms.TextBox TxtStoreToggle;
        private System.Windows.Forms.TextBox TxtCurrent;
    }
}

