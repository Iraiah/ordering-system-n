namespace los
{
    partial class frm_front
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            fburr1 = new CheckBox();
            fburr2 = new CheckBox();
            fburr3 = new CheckBox();
            fburr4 = new CheckBox();
            groupBox2 = new GroupBox();
            dbrootbeer = new CheckBox();
            dsprite = new CheckBox();
            dcoladiet = new CheckBox();
            dcola = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(492, 65);
            label1.TabIndex = 0;
            label1.Text = "Los Pollos Hermanos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(444, 99);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 3;
            label2.Text = "-Pollos Menu-";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fburr4);
            groupBox1.Controls.Add(fburr3);
            groupBox1.Controls.Add(fburr2);
            groupBox1.Controls.Add(fburr1);
            groupBox1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(291, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(189, 335);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Burritos";
            // 
            // fburr1
            // 
            fburr1.AutoSize = true;
            fburr1.Location = new Point(6, 28);
            fburr1.Name = "fburr1";
            fburr1.Size = new Size(149, 26);
            fburr1.TabIndex = 0;
            fburr1.Text = "Vegetarian Biggie";
            fburr1.UseVisualStyleBackColor = true;
            // 
            // fburr2
            // 
            fburr2.AutoSize = true;
            fburr2.Location = new Point(6, 96);
            fburr2.Name = "fburr2";
            fburr2.Size = new Size(88, 26);
            fburr2.TabIndex = 1;
            fburr2.Text = "Santa Fe";
            fburr2.UseVisualStyleBackColor = true;
            // 
            // fburr3
            // 
            fburr3.AutoSize = true;
            fburr3.Location = new Point(6, 164);
            fburr3.Name = "fburr3";
            fburr3.Size = new Size(153, 26);
            fburr3.TabIndex = 2;
            fburr3.Text = "Three Meat Biggie";
            fburr3.UseVisualStyleBackColor = true;
            // 
            // fburr4
            // 
            fburr4.AutoSize = true;
            fburr4.Location = new Point(6, 238);
            fburr4.Name = "fburr4";
            fburr4.Size = new Size(106, 26);
            fburr4.TabIndex = 3;
            fburr4.Text = "Rio Grande";
            fburr4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dbrootbeer);
            groupBox2.Controls.Add(dsprite);
            groupBox2.Controls.Add(dcoladiet);
            groupBox2.Controls.Add(dcola);
            groupBox2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(554, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(189, 335);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Los Pollos Drinks";
            // 
            // dbrootbeer
            // 
            dbrootbeer.AutoSize = true;
            dbrootbeer.Location = new Point(6, 238);
            dbrootbeer.Name = "dbrootbeer";
            dbrootbeer.Size = new Size(140, 26);
            dbrootbeer.TabIndex = 3;
            dbrootbeer.Text = "Barq's Roof Beer";
            dbrootbeer.UseVisualStyleBackColor = true;
            // 
            // dsprite
            // 
            dsprite.AutoSize = true;
            dsprite.Location = new Point(6, 164);
            dsprite.Name = "dsprite";
            dsprite.Size = new Size(69, 26);
            dsprite.TabIndex = 2;
            dsprite.Text = "Sprite";
            dsprite.UseVisualStyleBackColor = true;
            // 
            // dcoladiet
            // 
            dcoladiet.AutoSize = true;
            dcoladiet.Location = new Point(6, 96);
            dcoladiet.Name = "dcoladiet";
            dcoladiet.Size = new Size(96, 26);
            dcoladiet.TabIndex = 1;
            dcoladiet.Text = "Diet Coke";
            dcoladiet.UseVisualStyleBackColor = true;
            // 
            // dcola
            // 
            dcola.AutoSize = true;
            dcola.Location = new Point(6, 28);
            dcola.Name = "dcola";
            dcola.Size = new Size(98, 26);
            dcola.TabIndex = 0;
            dcola.Text = "Coca Cola";
            dcola.UseVisualStyleBackColor = true;
            // 
            // frm_front
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(765, 485);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F);
            Name = "frm_front";
            Text = "Los Pollos Hermanos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private CheckBox fburr4;
        private CheckBox fburr3;
        private CheckBox fburr2;
        private CheckBox fburr1;
        private GroupBox groupBox2;
        private CheckBox dbrootbeer;
        private CheckBox dsprite;
        private CheckBox dcoladiet;
        private CheckBox dcola;
    }
}
