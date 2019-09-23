namespace Circustrein
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
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.rbtnSmall = new System.Windows.Forms.RadioButton();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnMedium = new System.Windows.Forms.RadioButton();
            this.rbtnLarge = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnCarnivore = new System.Windows.Forms.RadioButton();
            this.rbtnHerbivore = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.Location = new System.Drawing.Point(348, 18);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(347, 186);
            this.lbAnimals.TabIndex = 0;
            // 
            // rbtnSmall
            // 
            this.rbtnSmall.AutoSize = true;
            this.rbtnSmall.Location = new System.Drawing.Point(6, 38);
            this.rbtnSmall.Name = "rbtnSmall";
            this.rbtnSmall.Size = new System.Drawing.Size(50, 17);
            this.rbtnSmall.TabIndex = 1;
            this.rbtnSmall.TabStop = true;
            this.rbtnSmall.Text = "Small";
            this.rbtnSmall.UseVisualStyleBackColor = true;
            this.rbtnSmall.CheckedChanged += new System.EventHandler(this.rbtnSmall_CheckedChanged);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(119, 148);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnimal.TabIndex = 2;
            this.btnAddAnimal.Text = "Add";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddAnimal);
            this.groupBox1.Controls.Add(this.rbtnCarnivore);
            this.groupBox1.Controls.Add(this.rbtnHerbivore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbtnLarge);
            this.groupBox1.Controls.Add(this.rbtnMedium);
            this.groupBox1.Controls.Add(this.rbtnSmall);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 179);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add animal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size:";
            // 
            // rbtnMedium
            // 
            this.rbtnMedium.AutoSize = true;
            this.rbtnMedium.Location = new System.Drawing.Point(6, 61);
            this.rbtnMedium.Name = "rbtnMedium";
            this.rbtnMedium.Size = new System.Drawing.Size(62, 17);
            this.rbtnMedium.TabIndex = 2;
            this.rbtnMedium.TabStop = true;
            this.rbtnMedium.Text = "Medium";
            this.rbtnMedium.UseVisualStyleBackColor = true;
            // 
            // rbtnLarge
            // 
            this.rbtnLarge.AutoSize = true;
            this.rbtnLarge.Location = new System.Drawing.Point(6, 84);
            this.rbtnLarge.Name = "rbtnLarge";
            this.rbtnLarge.Size = new System.Drawing.Size(52, 17);
            this.rbtnLarge.TabIndex = 3;
            this.rbtnLarge.TabStop = true;
            this.rbtnLarge.Text = "Large";
            this.rbtnLarge.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Diet:";
            // 
            // rbtnCarnivore
            // 
            this.rbtnCarnivore.AutoSize = true;
            this.rbtnCarnivore.Location = new System.Drawing.Point(6, 151);
            this.rbtnCarnivore.Name = "rbtnCarnivore";
            this.rbtnCarnivore.Size = new System.Drawing.Size(70, 17);
            this.rbtnCarnivore.TabIndex = 6;
            this.rbtnCarnivore.TabStop = true;
            this.rbtnCarnivore.Text = "Carnivore";
            this.rbtnCarnivore.UseVisualStyleBackColor = true;
            // 
            // rbtnHerbivore
            // 
            this.rbtnHerbivore.AutoSize = true;
            this.rbtnHerbivore.Location = new System.Drawing.Point(6, 128);
            this.rbtnHerbivore.Name = "rbtnHerbivore";
            this.rbtnHerbivore.Size = new System.Drawing.Size(71, 17);
            this.rbtnHerbivore.TabIndex = 5;
            this.rbtnHerbivore.TabStop = true;
            this.rbtnHerbivore.Text = "Herbivore";
            this.rbtnHerbivore.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 247);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbAnimals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAnimals;
        private System.Windows.Forms.RadioButton rbtnSmall;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnCarnivore;
        private System.Windows.Forms.RadioButton rbtnHerbivore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnLarge;
        private System.Windows.Forms.RadioButton rbtnMedium;
    }
}

