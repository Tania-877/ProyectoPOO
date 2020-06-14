using System.ComponentModel;

namespace Proyecto
{
    partial class Puntajes
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
                new System.ComponentModel.ComponentResourceManager(typeof(Puntajes));
            this.LabelTop = new System.Windows.Forms.Label();
            this.btbehind2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTop
            // 
            this.LabelTop.BackColor = System.Drawing.Color.Transparent;
            this.LabelTop.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelTop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelTop.Location = new System.Drawing.Point(192, 9);
            this.LabelTop.Name = "LabelTop";
            this.LabelTop.Size = new System.Drawing.Size(255, 59);
            this.LabelTop.TabIndex = 0;
            this.LabelTop.Text = "TOP 10";
            // 
            // btbehind2
            // 
            this.btbehind2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btbehind2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btbehind2.ForeColor = System.Drawing.Color.White;
            this.btbehind2.Location = new System.Drawing.Point(30, 529);
            this.btbehind2.Name = "btbehind2";
            this.btbehind2.Size = new System.Drawing.Size(111, 29);
            this.btbehind2.TabIndex = 1;
            this.btbehind2.Text = "Regresar";
            this.btbehind2.UseVisualStyleBackColor = false;
            this.btbehind2.Click += new System.EventHandler(this.btbehind2_Click);
            // 
            // Puntajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 579);
            this.Controls.Add(this.btbehind2);
            this.Controls.Add(this.LabelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Puntajes";
            this.Text = "Puntajes";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label LabelTop;
        private System.Windows.Forms.Button btbehind2;
    }
}