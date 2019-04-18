namespace ExtraClass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.txtAttack = new System.Windows.Forms.TextBox();
            this.txtChance = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbxTypes = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxHero = new System.Windows.Forms.ComboBox();
            this.cbxSide = new System.Windows.Forms.ComboBox();
            this.cbxVillian = new System.Windows.Forms.ComboBox();
            this.btnFight = new System.Windows.Forms.Button();
            this.rtbFight = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbxTypes);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtChance);
            this.panel1.Controls.Add(this.txtAttack);
            this.panel1.Controls.Add(this.txtHealth);
            this.panel1.Controls.Add(this.txtAlias);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 308);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Character";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Health";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chance";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(44, 37);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(100, 20);
            this.txtAlias.TabIndex = 5;
            // 
            // txtHealth
            // 
            this.txtHealth.Location = new System.Drawing.Point(44, 66);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(100, 20);
            this.txtHealth.TabIndex = 6;
            // 
            // txtAttack
            // 
            this.txtAttack.Location = new System.Drawing.Point(44, 96);
            this.txtAttack.Name = "txtAttack";
            this.txtAttack.Size = new System.Drawing.Size(100, 20);
            this.txtAttack.TabIndex = 7;
            // 
            // txtChance
            // 
            this.txtChance.Location = new System.Drawing.Point(44, 120);
            this.txtChance.Name = "txtChance";
            this.txtChance.Size = new System.Drawing.Size(100, 20);
            this.txtChance.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 282);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type of charater";
            // 
            // lbxTypes
            // 
            this.lbxTypes.FormattingEnabled = true;
            this.lbxTypes.Items.AddRange(new object[] {
            "Hero",
            "Villain",
            "Sidekick"});
            this.lbxTypes.Location = new System.Drawing.Point(6, 181);
            this.lbxTypes.Name = "lbxTypes";
            this.lbxTypes.Size = new System.Drawing.Size(179, 95);
            this.lbxTypes.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.rtbFight);
            this.panel2.Controls.Add(this.btnFight);
            this.panel2.Controls.Add(this.cbxVillian);
            this.panel2.Controls.Add(this.cbxSide);
            this.panel2.Controls.Add(this.cbxHero);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(213, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 308);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sidekick";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Villian";
            // 
            // cbxHero
            // 
            this.cbxHero.FormattingEnabled = true;
            this.cbxHero.Location = new System.Drawing.Point(50, 9);
            this.cbxHero.Name = "cbxHero";
            this.cbxHero.Size = new System.Drawing.Size(121, 21);
            this.cbxHero.TabIndex = 3;
            // 
            // cbxSide
            // 
            this.cbxSide.FormattingEnabled = true;
            this.cbxSide.Location = new System.Drawing.Point(50, 34);
            this.cbxSide.Name = "cbxSide";
            this.cbxSide.Size = new System.Drawing.Size(121, 21);
            this.cbxSide.TabIndex = 4;
            // 
            // cbxVillian
            // 
            this.cbxVillian.FormattingEnabled = true;
            this.cbxVillian.Location = new System.Drawing.Point(50, 58);
            this.cbxVillian.Name = "cbxVillian";
            this.cbxVillian.Size = new System.Drawing.Size(121, 21);
            this.cbxVillian.TabIndex = 5;
            // 
            // btnFight
            // 
            this.btnFight.Location = new System.Drawing.Point(6, 103);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(165, 23);
            this.btnFight.TabIndex = 6;
            this.btnFight.Text = "Fight";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // rtbFight
            // 
            this.rtbFight.Location = new System.Drawing.Point(177, 34);
            this.rtbFight.Name = "rtbFight";
            this.rtbFight.Size = new System.Drawing.Size(172, 242);
            this.rtbFight.TabIndex = 7;
            this.rtbFight.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Fight Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(588, 331);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbxTypes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtChance;
        private System.Windows.Forms.TextBox txtAttack;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbFight;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.ComboBox cbxVillian;
        private System.Windows.Forms.ComboBox cbxSide;
        private System.Windows.Forms.ComboBox cbxHero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

