using System.ComponentModel;

namespace Proyecto
{
    partial class Nameuser
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
                new System.ComponentModel.ComponentResourceManager(typeof(Nameuser));
            this.btUser = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.btbehind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUser
            // 
            this.btUser.BackColor = System.Drawing.Color.Transparent;
            this.btUser.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btUser.ForeColor = System.Drawing.Color.White;
            this.btUser.Location = new System.Drawing.Point(269, 80);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(157, 42);
            this.btUser.TabIndex = 0;
            this.btUser.Text = "USUARIO";
            // 
            // labelname
            // 
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelname.ForeColor = System.Drawing.Color.White;
            this.labelname.Location = new System.Drawing.Point(168, 187);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(96, 27);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 23);
            this.textBox1.TabIndex = 2;
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btlogin.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btlogin.ForeColor = System.Drawing.Color.White;
            this.btlogin.Location = new System.Drawing.Point(248, 305);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(210, 42);
            this.btlogin.TabIndex = 3;
            this.btlogin.Text = "Entrar";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btbehind
            // 
            this.btbehind.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btbehind.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btbehind.ForeColor = System.Drawing.Color.White;
            this.btbehind.Location = new System.Drawing.Point(43, 493);
            this.btbehind.Name = "btbehind";
            this.btbehind.Size = new System.Drawing.Size(108, 29);
            this.btbehind.TabIndex = 4;
            this.btbehind.Text = "Regresar";
            this.btbehind.UseVisualStyleBackColor = false;
            this.btbehind.Click += new System.EventHandler(this.btbehind_Click);
            // 
            // Nameuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 579);
            this.Controls.Add(this.btbehind);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.btUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nameuser";
            this.Text = "Nameuser";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label btUser;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btbehind;
    }
}