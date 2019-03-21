namespace WindowsFormsApp1
{
    partial class Simulation
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
            this.DémoComp = new System.Windows.Forms.Button();
            this.Reboot = new System.Windows.Forms.Button();
            this.SimCompBox = new System.Windows.Forms.GroupBox();
            this.Lentlabel = new System.Windows.Forms.Label();
            this.RapLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.VitTrackbar = new System.Windows.Forms.TrackBar();
            this.VitLabel = new System.Windows.Forms.Label();
            this.radioPasFull = new System.Windows.Forms.RadioButton();
            this.radio5Pas = new System.Windows.Forms.RadioButton();
            this.radio1Pas = new System.Windows.Forms.RadioButton();
            this.nbMouvLabel = new System.Windows.Forms.Label();
            this.PlacerCavalierButton = new System.Windows.Forms.Button();
            this.RandomCoorButton = new System.Windows.Forms.Button();
            this.OrdLabel = new System.Windows.Forms.Label();
            this.AbsLabel = new System.Windows.Forms.Label();
            this.PosDepLabel = new System.Windows.Forms.Label();
            this.OrdTextbox = new System.Windows.Forms.TextBox();
            this.AbsTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReculerButton = new System.Windows.Forms.Button();
            this.AvancerButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.SimCompBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VitTrackbar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DémoComp
            // 
            this.DémoComp.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DémoComp.Location = new System.Drawing.Point(40, 49);
            this.DémoComp.Name = "DémoComp";
            this.DémoComp.Size = new System.Drawing.Size(181, 36);
            this.DémoComp.TabIndex = 0;
            this.DémoComp.Text = "Go !";
            this.DémoComp.UseVisualStyleBackColor = true;
            this.DémoComp.Click += new System.EventHandler(this.DémoComp_Click);
            // 
            // Reboot
            // 
            this.Reboot.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reboot.Location = new System.Drawing.Point(5, 263);
            this.Reboot.Name = "Reboot";
            this.Reboot.Size = new System.Drawing.Size(110, 46);
            this.Reboot.TabIndex = 1;
            this.Reboot.Text = "Remise à zéro";
            this.Reboot.UseVisualStyleBackColor = true;
            this.Reboot.Click += new System.EventHandler(this.Reboot_Click);
            // 
            // SimCompBox
            // 
            this.SimCompBox.Controls.Add(this.Lentlabel);
            this.SimCompBox.Controls.Add(this.RapLabel);
            this.SimCompBox.Controls.Add(this.StopButton);
            this.SimCompBox.Controls.Add(this.VitTrackbar);
            this.SimCompBox.Controls.Add(this.VitLabel);
            this.SimCompBox.Controls.Add(this.DémoComp);
            this.SimCompBox.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimCompBox.Location = new System.Drawing.Point(810, 344);
            this.SimCompBox.Margin = new System.Windows.Forms.Padding(2);
            this.SimCompBox.Name = "SimCompBox";
            this.SimCompBox.Padding = new System.Windows.Forms.Padding(2);
            this.SimCompBox.Size = new System.Drawing.Size(251, 224);
            this.SimCompBox.TabIndex = 2;
            this.SimCompBox.TabStop = false;
            this.SimCompBox.Text = "Simulation Complète";
            // 
            // Lentlabel
            // 
            this.Lentlabel.AutoSize = true;
            this.Lentlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lentlabel.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lentlabel.Location = new System.Drawing.Point(152, 196);
            this.Lentlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lentlabel.Name = "Lentlabel";
            this.Lentlabel.Size = new System.Drawing.Size(78, 14);
            this.Lentlabel.TabIndex = 13;
            this.Lentlabel.Text = "10 secondes";
            // 
            // RapLabel
            // 
            this.RapLabel.AutoSize = true;
            this.RapLabel.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RapLabel.Location = new System.Drawing.Point(12, 196);
            this.RapLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RapLabel.Name = "RapLabel";
            this.RapLabel.Size = new System.Drawing.Size(65, 14);
            this.RapLabel.TabIndex = 12;
            this.RapLabel.Text = "1 seconde";
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(39, 90);
            this.StopButton.Margin = new System.Windows.Forms.Padding(2);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(181, 35);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Stop !";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // VitTrackbar
            // 
            this.VitTrackbar.Location = new System.Drawing.Point(39, 156);
            this.VitTrackbar.Margin = new System.Windows.Forms.Padding(2);
            this.VitTrackbar.Minimum = 1;
            this.VitTrackbar.Name = "VitTrackbar";
            this.VitTrackbar.Size = new System.Drawing.Size(181, 45);
            this.VitTrackbar.TabIndex = 9;
            this.VitTrackbar.Value = 1;
            // 
            // VitLabel
            // 
            this.VitLabel.AutoSize = true;
            this.VitLabel.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VitLabel.Location = new System.Drawing.Point(95, 135);
            this.VitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VitLabel.Name = "VitLabel";
            this.VitLabel.Size = new System.Drawing.Size(48, 14);
            this.VitLabel.TabIndex = 6;
            this.VitLabel.Text = "Vitesse";
            // 
            // radioPasFull
            // 
            this.radioPasFull.AutoSize = true;
            this.radioPasFull.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPasFull.Location = new System.Drawing.Point(162, 229);
            this.radioPasFull.Margin = new System.Windows.Forms.Padding(2);
            this.radioPasFull.Name = "radioPasFull";
            this.radioPasFull.Size = new System.Drawing.Size(83, 18);
            this.radioPasFull.TabIndex = 18;
            this.radioPasFull.TabStop = true;
            this.radioPasFull.Text = "Maximum";
            this.radioPasFull.UseVisualStyleBackColor = true;
            this.radioPasFull.CheckedChanged += new System.EventHandler(this.radioPas_CheckedChanged);
            // 
            // radio5Pas
            // 
            this.radio5Pas.AutoSize = true;
            this.radio5Pas.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio5Pas.Location = new System.Drawing.Point(98, 229);
            this.radio5Pas.Margin = new System.Windows.Forms.Padding(2);
            this.radio5Pas.Name = "radio5Pas";
            this.radio5Pas.Size = new System.Drawing.Size(57, 18);
            this.radio5Pas.TabIndex = 17;
            this.radio5Pas.TabStop = true;
            this.radio5Pas.Text = "5 pas";
            this.radio5Pas.UseVisualStyleBackColor = true;
            this.radio5Pas.CheckedChanged += new System.EventHandler(this.radioPas_CheckedChanged);
            // 
            // radio1Pas
            // 
            this.radio1Pas.AutoSize = true;
            this.radio1Pas.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1Pas.Location = new System.Drawing.Point(25, 229);
            this.radio1Pas.Margin = new System.Windows.Forms.Padding(2);
            this.radio1Pas.Name = "radio1Pas";
            this.radio1Pas.Size = new System.Drawing.Size(57, 18);
            this.radio1Pas.TabIndex = 16;
            this.radio1Pas.TabStop = true;
            this.radio1Pas.Text = "1 pas";
            this.radio1Pas.UseVisualStyleBackColor = true;
            this.radio1Pas.CheckedChanged += new System.EventHandler(this.radioPas_CheckedChanged);
            // 
            // nbMouvLabel
            // 
            this.nbMouvLabel.AutoSize = true;
            this.nbMouvLabel.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbMouvLabel.Location = new System.Drawing.Point(52, 199);
            this.nbMouvLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nbMouvLabel.Name = "nbMouvLabel";
            this.nbMouvLabel.Size = new System.Drawing.Size(165, 14);
            this.nbMouvLabel.TabIndex = 15;
            this.nbMouvLabel.Text = "Nombre de pas du cavalier";
            // 
            // PlacerCavalierButton
            // 
            this.PlacerCavalierButton.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacerCavalierButton.Location = new System.Drawing.Point(54, 144);
            this.PlacerCavalierButton.Margin = new System.Windows.Forms.Padding(2);
            this.PlacerCavalierButton.Name = "PlacerCavalierButton";
            this.PlacerCavalierButton.Size = new System.Drawing.Size(141, 36);
            this.PlacerCavalierButton.TabIndex = 11;
            this.PlacerCavalierButton.Text = "Placer Cavalier";
            this.PlacerCavalierButton.UseVisualStyleBackColor = true;
            this.PlacerCavalierButton.Click += new System.EventHandler(this.PlacerCavalierButton_Click);
            // 
            // RandomCoorButton
            // 
            this.RandomCoorButton.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomCoorButton.Location = new System.Drawing.Point(54, 110);
            this.RandomCoorButton.Margin = new System.Windows.Forms.Padding(2);
            this.RandomCoorButton.Name = "RandomCoorButton";
            this.RandomCoorButton.Size = new System.Drawing.Size(141, 28);
            this.RandomCoorButton.TabIndex = 8;
            this.RandomCoorButton.Text = "Randomize";
            this.RandomCoorButton.UseVisualStyleBackColor = true;
            this.RandomCoorButton.Click += new System.EventHandler(this.RandomCoorButton_Click);
            // 
            // OrdLabel
            // 
            this.OrdLabel.AutoSize = true;
            this.OrdLabel.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdLabel.Location = new System.Drawing.Point(137, 56);
            this.OrdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrdLabel.Name = "OrdLabel";
            this.OrdLabel.Size = new System.Drawing.Size(64, 14);
            this.OrdLabel.TabIndex = 5;
            this.OrdLabel.Text = "Ordonnée";
            // 
            // AbsLabel
            // 
            this.AbsLabel.AutoSize = true;
            this.AbsLabel.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsLabel.Location = new System.Drawing.Point(52, 56);
            this.AbsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AbsLabel.Name = "AbsLabel";
            this.AbsLabel.Size = new System.Drawing.Size(57, 14);
            this.AbsLabel.TabIndex = 4;
            this.AbsLabel.Text = "Abscisse";
            // 
            // PosDepLabel
            // 
            this.PosDepLabel.AutoSize = true;
            this.PosDepLabel.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosDepLabel.Location = new System.Drawing.Point(61, 30);
            this.PosDepLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PosDepLabel.Name = "PosDepLabel";
            this.PosDepLabel.Size = new System.Drawing.Size(129, 16);
            this.PosDepLabel.TabIndex = 3;
            this.PosDepLabel.Text = "Position de départ";
            // 
            // OrdTextbox
            // 
            this.OrdTextbox.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdTextbox.Location = new System.Drawing.Point(132, 72);
            this.OrdTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.OrdTextbox.Name = "OrdTextbox";
            this.OrdTextbox.Size = new System.Drawing.Size(76, 21);
            this.OrdTextbox.TabIndex = 2;
            this.OrdTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AbsTextbox
            // 
            this.AbsTextbox.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsTextbox.Location = new System.Drawing.Point(40, 72);
            this.AbsTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.AbsTextbox.Name = "AbsTextbox";
            this.AbsTextbox.Size = new System.Drawing.Size(76, 21);
            this.AbsTextbox.TabIndex = 1;
            this.AbsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReculerButton);
            this.groupBox1.Controls.Add(this.AvancerButton);
            this.groupBox1.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(810, 583);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(251, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step by step";
            // 
            // ReculerButton
            // 
            this.ReculerButton.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReculerButton.Location = new System.Drawing.Point(25, 79);
            this.ReculerButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReculerButton.Name = "ReculerButton";
            this.ReculerButton.Size = new System.Drawing.Size(212, 32);
            this.ReculerButton.TabIndex = 1;
            this.ReculerButton.Text = "Reculer";
            this.ReculerButton.UseVisualStyleBackColor = true;
            this.ReculerButton.Click += new System.EventHandler(this.ReculerButton_Click);
            // 
            // AvancerButton
            // 
            this.AvancerButton.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvancerButton.Location = new System.Drawing.Point(25, 38);
            this.AvancerButton.Margin = new System.Windows.Forms.Padding(2);
            this.AvancerButton.Name = "AvancerButton";
            this.AvancerButton.Size = new System.Drawing.Size(212, 36);
            this.AvancerButton.TabIndex = 0;
            this.AvancerButton.Text = "Avancer";
            this.AvancerButton.UseVisualStyleBackColor = true;
            this.AvancerButton.Click += new System.EventHandler(this.AvancerButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReplayButton);
            this.groupBox2.Controls.Add(this.AbsTextbox);
            this.groupBox2.Controls.Add(this.radioPasFull);
            this.groupBox2.Controls.Add(this.OrdTextbox);
            this.groupBox2.Controls.Add(this.Reboot);
            this.groupBox2.Controls.Add(this.PlacerCavalierButton);
            this.groupBox2.Controls.Add(this.radio5Pas);
            this.groupBox2.Controls.Add(this.PosDepLabel);
            this.groupBox2.Controls.Add(this.AbsLabel);
            this.groupBox2.Controls.Add(this.radio1Pas);
            this.groupBox2.Controls.Add(this.OrdLabel);
            this.groupBox2.Controls.Add(this.RandomCoorButton);
            this.groupBox2.Controls.Add(this.nbMouvLabel);
            this.groupBox2.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(810, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(251, 315);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            // 
            // ReplayButton
            // 
            this.ReplayButton.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayButton.Location = new System.Drawing.Point(132, 263);
            this.ReplayButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(115, 46);
            this.ReplayButton.TabIndex = 20;
            this.ReplayButton.Text = "Rejouer";
            this.ReplayButton.UseVisualStyleBackColor = true;
            this.ReplayButton.Click += new System.EventHandler(this.ReplayButton_Click);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 807);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SimCompBox);
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.SimCompBox.ResumeLayout(false);
            this.SimCompBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VitTrackbar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DémoComp;
        private System.Windows.Forms.Button Reboot;
        private System.Windows.Forms.GroupBox SimCompBox;
        private System.Windows.Forms.Button RandomCoorButton;
        private System.Windows.Forms.Label VitLabel;
        private System.Windows.Forms.Label OrdLabel;
        private System.Windows.Forms.Label AbsLabel;
        private System.Windows.Forms.Label PosDepLabel;
        private System.Windows.Forms.TextBox OrdTextbox;
        private System.Windows.Forms.TextBox AbsTextbox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TrackBar VitTrackbar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ReculerButton;
        private System.Windows.Forms.Button AvancerButton;
        private System.Windows.Forms.Button PlacerCavalierButton;
        private System.Windows.Forms.Label Lentlabel;
        private System.Windows.Forms.Label RapLabel;
        private System.Windows.Forms.Label nbMouvLabel;
        private System.Windows.Forms.RadioButton radioPasFull;
        private System.Windows.Forms.RadioButton radio5Pas;
        private System.Windows.Forms.RadioButton radio1Pas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ReplayButton;
    }
}