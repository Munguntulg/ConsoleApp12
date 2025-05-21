namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nemeh = new Button();
            hasah = new Button();
            Tentsuu = new Button();
            MS = new Button();
            ys = new Button();
            guraw = new Button();
            dorow = new Button();
            taw = new Button();
            zurgaa = new Button();
            doloo = new Button();
            naim = new Button();
            neg = new Button();
            hoyr = new Button();
            teg = new Button();
            tegteg = new Button();
            clear = new Button();
            too_haruulah = new TextBox();
            butsah = new Button();
            SuspendLayout();
            // 
            // Nemeh
            // 
            Nemeh.BackColor = SystemColors.ActiveCaptionText;
            Nemeh.Font = new Font("Segoe UI", 13F);
            Nemeh.ForeColor = SystemColors.ControlLightLight;
            Nemeh.Location = new Point(372, 291);
            Nemeh.Margin = new Padding(3, 4, 3, 4);
            Nemeh.Name = "Nemeh";
            Nemeh.Size = new Size(108, 65);
            Nemeh.TabIndex = 0;
            Nemeh.Text = "+";
            Nemeh.UseVisualStyleBackColor = false;
            Nemeh.Click += Nemeh_Click;
            // 
            // hasah
            // 
            hasah.BackColor = SystemColors.ActiveCaptionText;
            hasah.Font = new Font("Segoe UI", 13F);
            hasah.ForeColor = SystemColors.ControlLightLight;
            hasah.Location = new Point(372, 364);
            hasah.Margin = new Padding(3, 4, 3, 4);
            hasah.Name = "hasah";
            hasah.Size = new Size(108, 65);
            hasah.TabIndex = 1;
            hasah.Text = "-";
            hasah.UseVisualStyleBackColor = false;
            hasah.Click += hasah_Click;
            // 
            // Tentsuu
            // 
            Tentsuu.BackColor = SystemColors.ControlDarkDark;
            Tentsuu.ForeColor = SystemColors.ControlLightLight;
            Tentsuu.Location = new Point(372, 437);
            Tentsuu.Margin = new Padding(3, 4, 3, 4);
            Tentsuu.Name = "Tentsuu";
            Tentsuu.Size = new Size(108, 65);
            Tentsuu.TabIndex = 14;
            Tentsuu.Text = "=";
            Tentsuu.UseVisualStyleBackColor = false;
            Tentsuu.Click += Tentsuu_Click;
            // 
            // MS
            // 
            MS.BackColor = SystemColors.ActiveCaptionText;
            MS.ForeColor = SystemColors.ControlLightLight;
            MS.Location = new Point(372, 218);
            MS.Margin = new Padding(3, 4, 3, 4);
            MS.Name = "MS";
            MS.Size = new Size(108, 65);
            MS.TabIndex = 13;
            MS.Text = "MS";
            MS.UseVisualStyleBackColor = false;
            MS.Click += Memory_Click;
            // 
            // ys
            // 
            ys.Font = new Font("Segoe UI", 13F);
            ys.Location = new Point(258, 218);
            ys.Margin = new Padding(3, 4, 3, 4);
            ys.Name = "ys";
            ys.Size = new Size(108, 65);
            ys.TabIndex = 15;
            ys.Text = "9";
            ys.UseVisualStyleBackColor = true;
            ys.Click += neg_Click;
            // 
            // guraw
            // 
            guraw.Font = new Font("Segoe UI", 13F);
            guraw.Location = new Point(258, 364);
            guraw.Margin = new Padding(3, 4, 3, 4);
            guraw.Name = "guraw";
            guraw.Size = new Size(108, 65);
            guraw.TabIndex = 16;
            guraw.Text = "3";
            guraw.UseVisualStyleBackColor = true;
            guraw.Click += neg_Click;
            // 
            // dorow
            // 
            dorow.Font = new Font("Segoe UI", 13F);
            dorow.Location = new Point(30, 291);
            dorow.Margin = new Padding(3, 4, 3, 4);
            dorow.Name = "dorow";
            dorow.Size = new Size(108, 65);
            dorow.TabIndex = 17;
            dorow.Text = "4";
            dorow.UseVisualStyleBackColor = true;
            dorow.Click += neg_Click;
            // 
            // taw
            // 
            taw.Font = new Font("Segoe UI", 13F);
            taw.Location = new Point(144, 291);
            taw.Margin = new Padding(3, 4, 3, 4);
            taw.Name = "taw";
            taw.Size = new Size(108, 65);
            taw.TabIndex = 18;
            taw.Text = "5";
            taw.UseVisualStyleBackColor = true;
            taw.Click += neg_Click;
            // 
            // zurgaa
            // 
            zurgaa.Font = new Font("Segoe UI", 13F);
            zurgaa.Location = new Point(258, 291);
            zurgaa.Margin = new Padding(3, 4, 3, 4);
            zurgaa.Name = "zurgaa";
            zurgaa.Size = new Size(108, 65);
            zurgaa.TabIndex = 19;
            zurgaa.Text = "6";
            zurgaa.UseVisualStyleBackColor = true;
            zurgaa.Click += neg_Click;
            // 
            // doloo
            // 
            doloo.Font = new Font("Segoe UI", 13F);
            doloo.Location = new Point(30, 218);
            doloo.Margin = new Padding(3, 4, 3, 4);
            doloo.Name = "doloo";
            doloo.Size = new Size(108, 65);
            doloo.TabIndex = 20;
            doloo.Text = "7";
            doloo.UseVisualStyleBackColor = true;
            doloo.Click += neg_Click;
            // 
            // naim
            // 
            naim.Font = new Font("Segoe UI", 13F);
            naim.Location = new Point(144, 218);
            naim.Margin = new Padding(3, 4, 3, 4);
            naim.Name = "naim";
            naim.Size = new Size(108, 65);
            naim.TabIndex = 21;
            naim.Text = "8";
            naim.UseVisualStyleBackColor = true;
            naim.Click += neg_Click;
            // 
            // neg
            // 
            neg.Font = new Font("Segoe UI", 13F);
            neg.Location = new Point(30, 364);
            neg.Margin = new Padding(3, 4, 3, 4);
            neg.Name = "neg";
            neg.Size = new Size(108, 65);
            neg.TabIndex = 22;
            neg.Text = "1";
            neg.UseVisualStyleBackColor = true;
            neg.Click += neg_Click;
            // 
            // hoyr
            // 
            hoyr.Font = new Font("Segoe UI", 13F);
            hoyr.Location = new Point(144, 364);
            hoyr.Margin = new Padding(3, 4, 3, 4);
            hoyr.Name = "hoyr";
            hoyr.Size = new Size(108, 65);
            hoyr.TabIndex = 23;
            hoyr.Text = "2";
            hoyr.UseVisualStyleBackColor = true;
            hoyr.Click += neg_Click;
            // 
            // teg
            // 
            teg.Font = new Font("Segoe UI", 13F);
            teg.Location = new Point(30, 437);
            teg.Margin = new Padding(3, 4, 3, 4);
            teg.Name = "teg";
            teg.Size = new Size(108, 65);
            teg.TabIndex = 24;
            teg.Text = "0";
            teg.UseVisualStyleBackColor = true;
            teg.Click += neg_Click;
            // 
            // tegteg
            // 
            tegteg.Font = new Font("Segoe UI", 13F);
            tegteg.Location = new Point(576, 503);
            tegteg.Margin = new Padding(3, 4, 3, 4);
            tegteg.Name = "tegteg";
            tegteg.Size = new Size(0, 0);
            tegteg.TabIndex = 25;
            tegteg.Text = "00";
            tegteg.UseVisualStyleBackColor = true;
            tegteg.Click += neg_Click;




            // 
            // clear
            // 
            clear.BackColor = SystemColors.Info;
            clear.Font = new Font("Segoe UI", 13F);
            clear.Location = new Point(258, 438);
            clear.Margin = new Padding(3, 4, 3, 4);
            clear.Name = "clear";
            clear.Size = new Size(108, 65);
            clear.TabIndex = 27;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += button1_Click;
            // 
            // too_haruulah
            // 
            too_haruulah.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            too_haruulah.Location = new Point(30, 128);
            too_haruulah.Multiline = true;
            too_haruulah.Name = "too_haruulah";
            too_haruulah.Size = new Size(450, 63);
            too_haruulah.TabIndex = 28;
            too_haruulah.TextChanged += too_haruulah_TextChanged;
            // 
            // butsah
            // 
            butsah.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butsah.Location = new Point(144, 436);
            butsah.Name = "butsah";
            butsah.Size = new Size(108, 65);
            butsah.TabIndex = 29;
            butsah.Text = "X";
            butsah.UseVisualStyleBackColor = true;
            butsah.Click += butsah_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(butsah);
            Controls.Add(too_haruulah);
            Controls.Add(clear);
            Controls.Add(tegteg);
            Controls.Add(teg);
            Controls.Add(hoyr);
            Controls.Add(neg);
            Controls.Add(naim);
            Controls.Add(doloo);
            Controls.Add(zurgaa);
            Controls.Add(taw);
            Controls.Add(dorow);
            Controls.Add(guraw);
            Controls.Add(ys);
            Controls.Add(MS);
            Controls.Add(Tentsuu);
            Controls.Add(hasah);
            Controls.Add(Nemeh);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Nemeh;
        private Button hasah;
        private Button Tentsuu;
        private Button MS;
        private Button ys;
        private Button guraw;
        private Button dorow;
        private Button taw;
        private Button zurgaa;
        private Button doloo;
        private Button naim;
        private Button neg;
        private Button hoyr;
        private Button teg;
        private Button tegteg;
        private Button clear;
        private TextBox too_haruulah;
        private Button butsah;
    }
}
