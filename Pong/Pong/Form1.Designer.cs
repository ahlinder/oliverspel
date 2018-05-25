namespace Pong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spelplan = new System.Windows.Forms.Panel();
            this.liv3PCB = new System.Windows.Forms.PictureBox();
            this.liv2PCB = new System.Windows.Forms.PictureBox();
            this.liv1PCB = new System.Windows.Forms.PictureBox();
            this.lblMeny = new System.Windows.Forms.Label();
            this.lblPoäng = new System.Windows.Forms.Label();
            this.rack = new System.Windows.Forms.PictureBox();
            this.boll = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.spelplan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liv3PCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liv2PCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liv1PCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boll)).BeginInit();
            this.SuspendLayout();
            // 
            // spelplan
            // 
            this.spelplan.BackColor = System.Drawing.Color.Gray;
            this.spelplan.Controls.Add(this.liv3PCB);
            this.spelplan.Controls.Add(this.liv2PCB);
            this.spelplan.Controls.Add(this.liv1PCB);
            this.spelplan.Controls.Add(this.lblMeny);
            this.spelplan.Controls.Add(this.lblPoäng);
            this.spelplan.Controls.Add(this.rack);
            this.spelplan.Controls.Add(this.boll);
            this.spelplan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spelplan.Location = new System.Drawing.Point(0, 0);
            this.spelplan.Name = "spelplan";
            this.spelplan.Size = new System.Drawing.Size(1350, 729);
            this.spelplan.TabIndex = 0;
            // 
            // liv3PCB
            // 
            this.liv3PCB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("liv3PCB.BackgroundImage")));
            this.liv3PCB.Location = new System.Drawing.Point(1194, 12);
            this.liv3PCB.Name = "liv3PCB";
            this.liv3PCB.Size = new System.Drawing.Size(40, 40);
            this.liv3PCB.TabIndex = 6;
            this.liv3PCB.TabStop = false;
            // 
            // liv2PCB
            // 
            this.liv2PCB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("liv2PCB.BackgroundImage")));
            this.liv2PCB.Location = new System.Drawing.Point(1244, 12);
            this.liv2PCB.Name = "liv2PCB";
            this.liv2PCB.Size = new System.Drawing.Size(40, 40);
            this.liv2PCB.TabIndex = 5;
            this.liv2PCB.TabStop = false;
            // 
            // liv1PCB
            // 
            this.liv1PCB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("liv1PCB.BackgroundImage")));
            this.liv1PCB.Location = new System.Drawing.Point(1294, 12);
            this.liv1PCB.Name = "liv1PCB";
            this.liv1PCB.Size = new System.Drawing.Size(40, 40);
            this.liv1PCB.TabIndex = 4;
            this.liv1PCB.TabStop = false;
            // 
            // lblMeny
            // 
            this.lblMeny.AutoSize = true;
            this.lblMeny.Font = new System.Drawing.Font("Eras Medium ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeny.Location = new System.Drawing.Point(195, 99);
            this.lblMeny.Name = "lblMeny";
            this.lblMeny.Size = new System.Drawing.Size(0, 23);
            this.lblMeny.TabIndex = 3;
            // 
            // lblPoäng
            // 
            this.lblPoäng.AutoSize = true;
            this.lblPoäng.Font = new System.Drawing.Font("Eras Medium ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoäng.Location = new System.Drawing.Point(24, 25);
            this.lblPoäng.Name = "lblPoäng";
            this.lblPoäng.Size = new System.Drawing.Size(0, 23);
            this.lblPoäng.TabIndex = 2;
            // 
            // rack
            // 
            this.rack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rack.BackgroundImage")));
            this.rack.Location = new System.Drawing.Point(144, 276);
            this.rack.Name = "rack";
            this.rack.Size = new System.Drawing.Size(140, 20);
            this.rack.TabIndex = 1;
            this.rack.TabStop = false;
            // 
            // boll
            // 
            this.boll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boll.BackgroundImage")));
            this.boll.Location = new System.Drawing.Point(170, 63);
            this.boll.Name = "boll";
            this.boll.Size = new System.Drawing.Size(25, 25);
            this.boll.TabIndex = 0;
            this.boll.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.spelplan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.spelplan.ResumeLayout(false);
            this.spelplan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liv3PCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liv2PCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liv1PCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel spelplan;
        private System.Windows.Forms.PictureBox rack;
        private System.Windows.Forms.PictureBox boll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPoäng;
        private System.Windows.Forms.Label lblMeny;
        private System.Windows.Forms.PictureBox liv1PCB;
        private System.Windows.Forms.PictureBox liv3PCB;
        private System.Windows.Forms.PictureBox liv2PCB;
    }
}

