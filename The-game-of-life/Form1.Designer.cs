
namespace The_game_of_life
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
            this.pbGrid = new System.Windows.Forms.PictureBox();
            this.btRun = new System.Windows.Forms.Button();
            this.btStep = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btDraw = new System.Windows.Forms.Button();
            this.btAnimalOrGrass = new System.Windows.Forms.Button();
            this.btAnimal = new System.Windows.Forms.Button();
            this.btGrass = new System.Windows.Forms.Button();
            this.laAnimal = new System.Windows.Forms.Label();
            this.laGrass = new System.Windows.Forms.Label();
            this.laAnimalOrGrass = new System.Windows.Forms.Label();
            this.laRun = new System.Windows.Forms.Label();
            this.laIteration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGrid
            // 
            this.pbGrid.Location = new System.Drawing.Point(0, 85);
            this.pbGrid.Name = "pbGrid";
            this.pbGrid.Size = new System.Drawing.Size(1279, 591);
            this.pbGrid.TabIndex = 0;
            this.pbGrid.TabStop = false;
            this.pbGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbGrid_MouseDown);
            this.pbGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbGrid_MouseMove);
            this.pbGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbGrid_MouseUp);
            // 
            // btRun
            // 
            this.btRun.BackColor = System.Drawing.Color.Green;
            this.btRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRun.Location = new System.Drawing.Point(12, 21);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 43);
            this.btRun.TabIndex = 1;
            this.btRun.Text = "START";
            this.btRun.UseVisualStyleBackColor = false;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btStep
            // 
            this.btStep.BackColor = System.Drawing.SystemColors.Control;
            this.btStep.Location = new System.Drawing.Point(93, 21);
            this.btStep.Name = "btStep";
            this.btStep.Size = new System.Drawing.Size(75, 43);
            this.btStep.TabIndex = 2;
            this.btStep.Text = "Step";
            this.btStep.UseVisualStyleBackColor = false;
            this.btStep.Click += new System.EventHandler(this.btStep_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.Control;
            this.btReset.Location = new System.Drawing.Point(174, 21);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 43);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btDraw
            // 
            this.btDraw.BackColor = System.Drawing.SystemColors.Control;
            this.btDraw.Location = new System.Drawing.Point(255, 21);
            this.btDraw.Name = "btDraw";
            this.btDraw.Size = new System.Drawing.Size(75, 43);
            this.btDraw.TabIndex = 4;
            this.btDraw.Text = "Draw";
            this.btDraw.UseVisualStyleBackColor = false;
            this.btDraw.Click += new System.EventHandler(this.btDraw_Click);
            // 
            // btAnimalOrGrass
            // 
            this.btAnimalOrGrass.Location = new System.Drawing.Point(336, 21);
            this.btAnimalOrGrass.Name = "btAnimalOrGrass";
            this.btAnimalOrGrass.Size = new System.Drawing.Size(75, 43);
            this.btAnimalOrGrass.TabIndex = 7;
            this.btAnimalOrGrass.Text = "Grass";
            this.btAnimalOrGrass.UseVisualStyleBackColor = false;
            this.btAnimalOrGrass.Visible = false;
            this.btAnimalOrGrass.Click += new System.EventHandler(this.btAnimalOrGrass_Click);
            // 
            // btAnimal
            // 
            this.btAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.btAnimal.Location = new System.Drawing.Point(417, 21);
            this.btAnimal.Name = "btAnimal";
            this.btAnimal.Size = new System.Drawing.Size(94, 43);
            this.btAnimal.TabIndex = 8;
            this.btAnimal.Text = "Fox";
            this.btAnimal.UseVisualStyleBackColor = false;
            this.btAnimal.Visible = false;
            this.btAnimal.Click += new System.EventHandler(this.btAnimal_Click);
            // 
            // btGrass
            // 
            this.btGrass.BackColor = System.Drawing.SystemColors.Control;
            this.btGrass.Location = new System.Drawing.Point(417, 21);
            this.btGrass.Name = "btGrass";
            this.btGrass.Size = new System.Drawing.Size(94, 43);
            this.btGrass.TabIndex = 9;
            this.btGrass.Text = "Fűkezdemnény";
            this.btGrass.UseVisualStyleBackColor = false;
            this.btGrass.Visible = false;
            this.btGrass.Click += new System.EventHandler(this.btGrass_Click);
            // 
            // laAnimal
            // 
            this.laAnimal.Location = new System.Drawing.Point(414, 5);
            this.laAnimal.Name = "laAnimal";
            this.laAnimal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laAnimal.Size = new System.Drawing.Size(97, 13);
            this.laAnimal.TabIndex = 10;
            this.laAnimal.Text = "Animal";
            this.laAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laAnimal.Visible = false;
            // 
            // laGrass
            // 
            this.laGrass.Location = new System.Drawing.Point(414, 5);
            this.laGrass.Name = "laGrass";
            this.laGrass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laGrass.Size = new System.Drawing.Size(97, 13);
            this.laGrass.TabIndex = 11;
            this.laGrass.Text = "Grass";
            this.laGrass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laGrass.Visible = false;
            // 
            // laAnimalOrGrass
            // 
            this.laAnimalOrGrass.AutoSize = true;
            this.laAnimalOrGrass.Location = new System.Drawing.Point(354, 5);
            this.laAnimalOrGrass.Name = "laAnimalOrGrass";
            this.laAnimalOrGrass.Size = new System.Drawing.Size(37, 13);
            this.laAnimalOrGrass.TabIndex = 12;
            this.laAnimalOrGrass.Text = "Select";
            this.laAnimalOrGrass.Visible = false;
            // 
            // laRun
            // 
            this.laRun.Location = new System.Drawing.Point(9, 5);
            this.laRun.Name = "laRun";
            this.laRun.Size = new System.Drawing.Size(321, 13);
            this.laRun.TabIndex = 13;
            this.laRun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // laIteration
            // 
            this.laIteration.AutoSize = true;
            this.laIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.laIteration.Location = new System.Drawing.Point(1106, 9);
            this.laIteration.Name = "laIteration";
            this.laIteration.Size = new System.Drawing.Size(163, 29);
            this.laIteration.TabIndex = 14;
            this.laIteration.Text = "Iteration: 0000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 676);
            this.Controls.Add(this.laIteration);
            this.Controls.Add(this.laRun);
            this.Controls.Add(this.laAnimalOrGrass);
            this.Controls.Add(this.laGrass);
            this.Controls.Add(this.laAnimal);
            this.Controls.Add(this.btGrass);
            this.Controls.Add(this.btAnimal);
            this.Controls.Add(this.btAnimalOrGrass);
            this.Controls.Add(this.btDraw);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btStep);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.pbGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGrid;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btStep;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btDraw;
        private System.Windows.Forms.Button btAnimalOrGrass;
        private System.Windows.Forms.Button btAnimal;
        private System.Windows.Forms.Button btGrass;
        private System.Windows.Forms.Label laAnimal;
        private System.Windows.Forms.Label laGrass;
        private System.Windows.Forms.Label laAnimalOrGrass;
        private System.Windows.Forms.Label laRun;
        private System.Windows.Forms.Label laIteration;
    }
}

