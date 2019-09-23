namespace Circustrein
{
    partial class View
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("123");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("4576");
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.rbtnSmall = new System.Windows.Forms.RadioButton();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbtnCarnivore = new System.Windows.Forms.RadioButton();
            this.rbtnHerbivore = new System.Windows.Forms.RadioButton();
            this.lblAddAnimal = new System.Windows.Forms.Label();
            this.rbtnLarge = new System.Windows.Forms.RadioButton();
            this.rbtnMedium = new System.Windows.Forms.RadioButton();
            this.gbDiet = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lvSortedCoupes = new System.Windows.Forms.ListView();
            this.gbSize.SuspendLayout();
            this.gbDiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.Location = new System.Drawing.Point(152, 12);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(159, 199);
            this.lbAnimals.TabIndex = 0;
            // 
            // rbtnSmall
            // 
            this.rbtnSmall.AutoSize = true;
            this.rbtnSmall.Location = new System.Drawing.Point(6, 19);
            this.rbtnSmall.Name = "rbtnSmall";
            this.rbtnSmall.Size = new System.Drawing.Size(50, 17);
            this.rbtnSmall.TabIndex = 1;
            this.rbtnSmall.TabStop = true;
            this.rbtnSmall.Text = "Small";
            this.rbtnSmall.UseVisualStyleBackColor = true;
            this.rbtnSmall.CheckedChanged += new System.EventHandler(this.radiobuttonsSize_CheckedChanged);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(71, 188);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnimal.TabIndex = 2;
            this.btnAddAnimal.Text = "Add";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbtnLarge);
            this.gbSize.Controls.Add(this.rbtnMedium);
            this.gbSize.Controls.Add(this.rbtnSmall);
            this.gbSize.Location = new System.Drawing.Point(9, 25);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(137, 88);
            this.gbSize.TabIndex = 3;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size:";
            // 
            // rbtnCarnivore
            // 
            this.rbtnCarnivore.AutoSize = true;
            this.rbtnCarnivore.Location = new System.Drawing.Point(6, 42);
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
            this.rbtnHerbivore.Location = new System.Drawing.Point(6, 19);
            this.rbtnHerbivore.Name = "rbtnHerbivore";
            this.rbtnHerbivore.Size = new System.Drawing.Size(71, 17);
            this.rbtnHerbivore.TabIndex = 5;
            this.rbtnHerbivore.TabStop = true;
            this.rbtnHerbivore.Text = "Herbivore";
            this.rbtnHerbivore.UseVisualStyleBackColor = true;
            // 
            // lblAddAnimal
            // 
            this.lblAddAnimal.AutoSize = true;
            this.lblAddAnimal.Location = new System.Drawing.Point(12, 9);
            this.lblAddAnimal.Name = "lblAddAnimal";
            this.lblAddAnimal.Size = new System.Drawing.Size(62, 13);
            this.lblAddAnimal.TabIndex = 4;
            this.lblAddAnimal.Text = "Add animal:";
            // 
            // rbtnLarge
            // 
            this.rbtnLarge.AutoSize = true;
            this.rbtnLarge.Location = new System.Drawing.Point(6, 65);
            this.rbtnLarge.Name = "rbtnLarge";
            this.rbtnLarge.Size = new System.Drawing.Size(52, 17);
            this.rbtnLarge.TabIndex = 3;
            this.rbtnLarge.TabStop = true;
            this.rbtnLarge.Text = "Large";
            this.rbtnLarge.UseVisualStyleBackColor = true;
            this.rbtnLarge.CheckedChanged += new System.EventHandler(this.radiobuttonsSize_CheckedChanged);
            // 
            // rbtnMedium
            // 
            this.rbtnMedium.AutoSize = true;
            this.rbtnMedium.Location = new System.Drawing.Point(6, 42);
            this.rbtnMedium.Name = "rbtnMedium";
            this.rbtnMedium.Size = new System.Drawing.Size(62, 17);
            this.rbtnMedium.TabIndex = 2;
            this.rbtnMedium.TabStop = true;
            this.rbtnMedium.Text = "Medium";
            this.rbtnMedium.UseVisualStyleBackColor = true;
            this.rbtnMedium.CheckedChanged += new System.EventHandler(this.radiobuttonsSize_CheckedChanged);
            // 
            // gbDiet
            // 
            this.gbDiet.Controls.Add(this.rbtnHerbivore);
            this.gbDiet.Controls.Add(this.rbtnCarnivore);
            this.gbDiet.Location = new System.Drawing.Point(9, 116);
            this.gbDiet.Name = "gbDiet";
            this.gbDiet.Size = new System.Drawing.Size(137, 67);
            this.gbDiet.TabIndex = 4;
            this.gbDiet.TabStop = false;
            this.gbDiet.Text = "Diet:";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(317, 74);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 48);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort into coupes";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lvSortedCoupes
            // 
            listViewGroup1.Header = "ListViewGroup1";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup2";
            listViewGroup2.Name = "listViewGroup2";
            this.lvSortedCoupes.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            listViewItem1.Group = listViewGroup1;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.Group = listViewGroup2;
            this.lvSortedCoupes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvSortedCoupes.Location = new System.Drawing.Point(398, 12);
            this.lvSortedCoupes.Name = "lvSortedCoupes";
            this.lvSortedCoupes.Size = new System.Drawing.Size(200, 199);
            this.lvSortedCoupes.TabIndex = 6;
            this.lvSortedCoupes.UseCompatibleStateImageBehavior = false;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 247);
            this.Controls.Add(this.lvSortedCoupes);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.gbDiet);
            this.Controls.Add(this.lblAddAnimal);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.lbAnimals);
            this.Name = "View";
            this.Text = "Form1";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbDiet.ResumeLayout(false);
            this.gbDiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAnimals;
        private System.Windows.Forms.RadioButton rbtnSmall;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbtnCarnivore;
        private System.Windows.Forms.RadioButton rbtnHerbivore;
        private System.Windows.Forms.Label lblAddAnimal;
        private System.Windows.Forms.RadioButton rbtnLarge;
        private System.Windows.Forms.RadioButton rbtnMedium;
        private System.Windows.Forms.GroupBox gbDiet;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListView lvSortedCoupes;
    }
}

