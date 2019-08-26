namespace VisualizzaAndamentoProduzione
{
    partial class FrmSemaforo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSemaforo));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LblTempo = new System.Windows.Forms.Label();
            this.PictureGreen = new System.Windows.Forms.PictureBox();
            this.PictureYellow = new System.Windows.Forms.PictureBox();
            this.PictureRed = new System.Windows.Forms.PictureBox();
            this.LblProd = new System.Windows.Forms.Label();
            this.LblMax = new System.Windows.Forms.Label();
            this.LblMin = new System.Windows.Forms.Label();
            this.LblUguale = new System.Windows.Forms.Label();
            this.LblMeno = new System.Windows.Forms.Label();
            this.LblPiu = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblDatoNonRilevabile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRed)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LblTempo);
            this.splitContainer1.Panel1.Controls.Add(this.PictureGreen);
            this.splitContainer1.Panel1.Controls.Add(this.PictureYellow);
            this.splitContainer1.Panel1.Controls.Add(this.PictureRed);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LblProd);
            this.splitContainer1.Panel2.Controls.Add(this.LblMax);
            this.splitContainer1.Panel2.Controls.Add(this.LblMin);
            this.splitContainer1.Panel2.Controls.Add(this.LblUguale);
            this.splitContainer1.Panel2.Controls.Add(this.LblMeno);
            this.splitContainer1.Panel2.Controls.Add(this.LblPiu);
            this.splitContainer1.Size = new System.Drawing.Size(1349, 592);
            this.splitContainer1.SplitterDistance = 710;
            this.splitContainer1.TabIndex = 0;
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Location = new System.Drawing.Point(317, 9);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(0, 17);
            this.LblTempo.TabIndex = 3;
            // 
            // PictureGreen
            // 
            this.PictureGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureGreen.Image = ((System.Drawing.Image)(resources.GetObject("PictureGreen.Image")));
            this.PictureGreen.Location = new System.Drawing.Point(0, 0);
            this.PictureGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureGreen.Name = "PictureGreen";
            this.PictureGreen.Size = new System.Drawing.Size(707, 590);
            this.PictureGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureGreen.TabIndex = 2;
            this.PictureGreen.TabStop = false;
            // 
            // PictureYellow
            // 
            this.PictureYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureYellow.Image = ((System.Drawing.Image)(resources.GetObject("PictureYellow.Image")));
            this.PictureYellow.Location = new System.Drawing.Point(0, 0);
            this.PictureYellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureYellow.Name = "PictureYellow";
            this.PictureYellow.Size = new System.Drawing.Size(707, 590);
            this.PictureYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureYellow.TabIndex = 1;
            this.PictureYellow.TabStop = false;
            // 
            // PictureRed
            // 
            this.PictureRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureRed.Image = ((System.Drawing.Image)(resources.GetObject("PictureRed.Image")));
            this.PictureRed.Location = new System.Drawing.Point(0, 2);
            this.PictureRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureRed.Name = "PictureRed";
            this.PictureRed.Size = new System.Drawing.Size(707, 586);
            this.PictureRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureRed.TabIndex = 0;
            this.PictureRed.TabStop = false;
            // 
            // LblProd
            // 
            this.LblProd.AutoSize = true;
            this.LblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProd.Location = new System.Drawing.Point(172, 197);
            this.LblProd.Name = "LblProd";
            this.LblProd.Size = new System.Drawing.Size(651, 283);
            this.LblProd.TabIndex = 5;
            this.LblProd.Text = "Prod";
            // 
            // LblMax
            // 
            this.LblMax.AutoSize = true;
            this.LblMax.Location = new System.Drawing.Point(17, 39);
            this.LblMax.Name = "LblMax";
            this.LblMax.Size = new System.Drawing.Size(33, 17);
            this.LblMax.TabIndex = 4;
            this.LblMax.Text = "Max";
            // 
            // LblMin
            // 
            this.LblMin.AutoSize = true;
            this.LblMin.Location = new System.Drawing.Point(17, 14);
            this.LblMin.Name = "LblMin";
            this.LblMin.Size = new System.Drawing.Size(30, 17);
            this.LblMin.TabIndex = 3;
            this.LblMin.Text = "Min";
            // 
            // LblUguale
            // 
            this.LblUguale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUguale.BackColor = System.Drawing.Color.LawnGreen;
            this.LblUguale.Font = new System.Drawing.Font("Microsoft Sans Serif", 250.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUguale.Location = new System.Drawing.Point(11, 10);
            this.LblUguale.Name = "LblUguale";
            this.LblUguale.Size = new System.Drawing.Size(629, 590);
            this.LblUguale.TabIndex = 2;
            this.LblUguale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMeno
            // 
            this.LblMeno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMeno.BackColor = System.Drawing.Color.Crimson;
            this.LblMeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 250.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMeno.Location = new System.Drawing.Point(3, 2);
            this.LblMeno.Name = "LblMeno";
            this.LblMeno.Size = new System.Drawing.Size(629, 590);
            this.LblMeno.TabIndex = 1;
            this.LblMeno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPiu
            // 
            this.LblPiu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPiu.BackColor = System.Drawing.Color.Yellow;
            this.LblPiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 250.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPiu.Location = new System.Drawing.Point(3, 0);
            this.LblPiu.Name = "LblPiu";
            this.LblPiu.Size = new System.Drawing.Size(629, 590);
            this.LblPiu.TabIndex = 0;
            this.LblPiu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDatoNonRilevabile
            // 
            this.LblDatoNonRilevabile.BackColor = System.Drawing.SystemColors.Info;
            this.LblDatoNonRilevabile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDatoNonRilevabile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDatoNonRilevabile.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatoNonRilevabile.Location = new System.Drawing.Point(0, 0);
            this.LblDatoNonRilevabile.Name = "LblDatoNonRilevabile";
            this.LblDatoNonRilevabile.Size = new System.Drawing.Size(1349, 592);
            this.LblDatoNonRilevabile.TabIndex = 5;
            this.LblDatoNonRilevabile.Text = "Dato attualmente non rilevabile";
            this.LblDatoNonRilevabile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSemaforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 592);
            this.Controls.Add(this.LblDatoNonRilevabile);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSemaforo";
            this.Text = "FrmSemaforo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox PictureGreen;
        private System.Windows.Forms.PictureBox PictureYellow;
        private System.Windows.Forms.PictureBox PictureRed;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Label LblUguale;
        private System.Windows.Forms.Label LblMeno;
        private System.Windows.Forms.Label LblPiu;
        private System.Windows.Forms.Label LblProd;
        private System.Windows.Forms.Label LblMax;
        private System.Windows.Forms.Label LblMin;
        private System.Windows.Forms.Label LblDatoNonRilevabile;
    }
}