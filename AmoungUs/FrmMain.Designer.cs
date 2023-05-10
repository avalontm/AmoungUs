namespace AmoungUs
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            BtnStart = new Button();
            label1 = new Label();
            TxtName = new TextBox();
            TxtRol = new TextBox();
            label2 = new Label();
            TxtTeam = new TextBox();
            label3 = new Label();
            TxtNivel = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(10, 235);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(291, 42);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "Iniciar";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(71, 10);
            TxtName.Name = "TxtName";
            TxtName.ReadOnly = true;
            TxtName.Size = new Size(232, 23);
            TxtName.TabIndex = 2;
            // 
            // TxtRol
            // 
            TxtRol.Location = new Point(71, 39);
            TxtRol.Name = "TxtRol";
            TxtRol.ReadOnly = true;
            TxtRol.Size = new Size(232, 23);
            TxtRol.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 44);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 3;
            label2.Text = "Rol";
            // 
            // TxtTeam
            // 
            TxtTeam.Location = new Point(71, 68);
            TxtTeam.Name = "TxtTeam";
            TxtTeam.ReadOnly = true;
            TxtTeam.Size = new Size(232, 23);
            TxtTeam.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 73);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 5;
            label3.Text = "Equipo";
            // 
            // TxtNivel
            // 
            TxtNivel.Location = new Point(72, 98);
            TxtNivel.Name = "TxtNivel";
            TxtNivel.ReadOnly = true;
            TxtNivel.Size = new Size(231, 23);
            TxtNivel.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 103);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 7;
            label4.Text = "Nivel";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 289);
            Controls.Add(TxtNivel);
            Controls.Add(label4);
            Controls.Add(TxtTeam);
            Controls.Add(label3);
            Controls.Add(TxtRol);
            Controls.Add(label2);
            Controls.Add(TxtName);
            Controls.Add(label1);
            Controls.Add(BtnStart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AmongUS - Steam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnStart;
        private Label label1;
        private TextBox TxtName;
        private TextBox TxtRol;
        private Label label2;
        private TextBox TxtTeam;
        private Label label3;
        private TextBox TxtNivel;
        private Label label4;
    }
}