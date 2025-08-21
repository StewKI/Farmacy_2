namespace Farmacy.Forme
{
    partial class DodajSertifikacijuForm
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
            lblNaziv = new Label();
            datum = new Label();
            dtpDatumS = new DateTimePicker();
            txtNaziv = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(37, 45);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(39, 15);
            lblNaziv.TabIndex = 3;
            lblNaziv.Text = "Naziv:";
            lblNaziv.Click += lblPrezime_Click;
            // 
            // datum
            // 
            datum.AutoSize = true;
            datum.Location = new Point(37, 98);
            datum.Name = "datum";
            datum.Size = new Size(46, 15);
            datum.TabIndex = 4;
            datum.Text = "Datum:";
            // 
            // dtpDatumS
            // 
            dtpDatumS.Format = DateTimePickerFormat.Short;
            dtpDatumS.Location = new Point(108, 98);
            dtpDatumS.Name = "dtpDatumS";
            dtpDatumS.Size = new Size(200, 23);
            dtpDatumS.TabIndex = 8;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(108, 45);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(200, 23);
            txtNaziv.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(154, 159);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(263, 159);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Otkazi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DodajSertifikacijuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 194);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNaziv);
            Controls.Add(dtpDatumS);
            Controls.Add(datum);
            Controls.Add(lblNaziv);
            Name = "DodajSertifikacijuForm";
            Text = "DodajSertifikacijuForm";
            Load += DodajSertifikacijuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNaziv;
        private Label datum;
        private DateTimePicker dtpDatumS;
        private TextBox txtNaziv;
        private Button button1;
        private Button button2;
    }
}