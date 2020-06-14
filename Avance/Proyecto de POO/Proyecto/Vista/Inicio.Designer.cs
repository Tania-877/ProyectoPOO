using System.ComponentModel;

namespace Proyecto
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btplay = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.btscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btplay
            // 
            this.btplay.BackColor = System.Drawing.Color.DarkGray;
            this.btplay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btplay.ForeColor = System.Drawing.Color.White;
            this.btplay.Location = new System.Drawing.Point(264, 55);
            this.btplay.Name = "btplay";
            this.btplay.Size = new System.Drawing.Size(157, 47);
            this.btplay.TabIndex = 0;
            this.btplay.Text = "JUGAR";
            this.btplay.UseVisualStyleBackColor = false;
            this.btplay.Click += new System.EventHandler(this.btplay_Click);
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.Color.DarkGray;
            this.btexit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btexit.ForeColor = System.Drawing.Color.White;
            this.btexit.Location = new System.Drawing.Point(264, 436);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(157, 47);
            this.btexit.TabIndex = 1;
            this.btexit.Text = "SALIR";
            this.btexit.UseVisualStyleBackColor = false;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btscore
            // 
            this.btscore.BackColor = System.Drawing.Color.DarkGray;
            this.btscore.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btscore.ForeColor = System.Drawing.Color.White;
            this.btscore.Location = new System.Drawing.Point(264, 162);
            this.btscore.Name = "btscore";
            this.btscore.Size = new System.Drawing.Size(157, 47);
            this.btscore.TabIndex = 2;
            this.btscore.Text = "PUNTAJE";
            this.btscore.UseVisualStyleBackColor = false;
            this.btscore.Click += new System.EventHandler(this.btscore_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 579);
            this.Controls.Add(this.btscore);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btplay;
        private System.Windows.Forms.Button btscore;
    }
}