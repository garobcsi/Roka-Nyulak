
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
            this.btRun.Location = new System.Drawing.Point(12, 12);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 43);
            this.btRun.TabIndex = 1;
            this.btRun.Text = "START";
            this.btRun.UseVisualStyleBackColor = false;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btStep
            // 
            this.btStep.Location = new System.Drawing.Point(93, 12);
            this.btStep.Name = "btStep";
            this.btStep.Size = new System.Drawing.Size(75, 43);
            this.btStep.TabIndex = 2;
            this.btStep.Text = "Step";
            this.btStep.UseVisualStyleBackColor = true;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(174, 12);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 43);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            // 
            // btDraw
            // 
            this.btDraw.Location = new System.Drawing.Point(255, 12);
            this.btDraw.Name = "btDraw";
            this.btDraw.Size = new System.Drawing.Size(75, 43);
            this.btDraw.TabIndex = 4;
            this.btDraw.Text = "Draw";
            this.btDraw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 676);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGrid;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btStep;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btDraw;
    }
}

