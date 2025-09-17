namespace Farmacy.Forme
{
    partial class OdaberiTipZaposlenogForm
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
            btnFarmaceut = new Button();
            btnTehnicar = new Button();
            btnMenadzer = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnFarmaceut
            // 
            btnFarmaceut.Location = new Point(50, 80);
            btnFarmaceut.Name = "btnFarmaceut";
            btnFarmaceut.Size = new Size(120, 40);
            btnFarmaceut.TabIndex = 0;
            btnFarmaceut.Text = "Farmaceut";
            btnFarmaceut.UseVisualStyleBackColor = true;
            btnFarmaceut.Click += btnFarmaceut_Click;
            // 
            // btnTehnicar
            // 
            btnTehnicar.Location = new Point(200, 80);
            btnTehnicar.Name = "btnTehnicar";
            btnTehnicar.Size = new Size(120, 40);
            btnTehnicar.TabIndex = 1;
            btnTehnicar.Text = "Tehničar";
            btnTehnicar.UseVisualStyleBackColor = true;
            btnTehnicar.Click += btnTehnicar_Click;
            // 
            // btnMenadzer
            // 
            btnMenadzer.Location = new Point(350, 80);
            btnMenadzer.Name = "btnMenadzer";
            btnMenadzer.Size = new Size(120, 40);
            btnMenadzer.TabIndex = 2;
            btnMenadzer.Text = "Menadžer";
            btnMenadzer.UseVisualStyleBackColor = true;
            btnMenadzer.Click += btnMenadzer_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(200, 150);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 30);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Otkaži";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(150, 30);
            label1.Name = "label1";
            label1.Size = new Size(220, 21);
            label1.TabIndex = 4;
            label1.Text = "Odaberite tip zaposlenog";
            // 
            // OdaberiTipZaposlenogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 200);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnMenadzer);
            Controls.Add(btnTehnicar);
            Controls.Add(btnFarmaceut);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OdaberiTipZaposlenogForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj zaposlenog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFarmaceut;
        private Button btnTehnicar;
        private Button btnMenadzer;
        private Button btnCancel;
        private Label label1;
    }
}
