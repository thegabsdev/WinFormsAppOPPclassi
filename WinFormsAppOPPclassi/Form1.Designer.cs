namespace WinFormsAppOPPclassi
{
    partial class Form1
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
            buttonCreaPersona = new Button();
            buttonLeggiProprieta = new Button();
            buttonCresci = new Button();
            labelAltezza = new Label();
            labelNome = new Label();
            buttonStudente = new Button();
            labelStudente = new Label();
            buttonPrumuovi = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // buttonCreaPersona
            // 
            buttonCreaPersona.Location = new Point(80, 148);
            buttonCreaPersona.Name = "buttonCreaPersona";
            buttonCreaPersona.Size = new Size(94, 29);
            buttonCreaPersona.TabIndex = 0;
            buttonCreaPersona.Text = "Crea";
            buttonCreaPersona.UseVisualStyleBackColor = true;
            buttonCreaPersona.Click += buttonCreaPersona_Click;
            // 
            // buttonLeggiProprieta
            // 
            buttonLeggiProprieta.Enabled = false;
            buttonLeggiProprieta.Location = new Point(83, 264);
            buttonLeggiProprieta.Margin = new Padding(3, 4, 3, 4);
            buttonLeggiProprieta.Name = "buttonLeggiProprieta";
            buttonLeggiProprieta.Size = new Size(94, 28);
            buttonLeggiProprieta.TabIndex = 2;
            buttonLeggiProprieta.Text = "button1";
            buttonLeggiProprieta.UseVisualStyleBackColor = true;
            buttonLeggiProprieta.Click += buttonLeggiProprieta_Click;
            // 
            // buttonCresci
            // 
            buttonCresci.Location = new Point(83, 206);
            buttonCresci.Margin = new Padding(3, 4, 3, 4);
            buttonCresci.Name = "buttonCresci";
            buttonCresci.Size = new Size(102, 40);
            buttonCresci.TabIndex = 5;
            buttonCresci.Text = "cresci";
            buttonCresci.UseVisualStyleBackColor = true;
            buttonCresci.Click += buttonCresci_Click;
            // 
            // labelAltezza
            // 
            labelAltezza.AutoSize = true;
            labelAltezza.Location = new Point(222, 217);
            labelAltezza.Name = "labelAltezza";
            labelAltezza.Size = new Size(50, 20);
            labelAltezza.TabIndex = 6;
            labelAltezza.Text = "label1";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(198, 149);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 7;
            labelNome.Text = "label1";
            // 
            // buttonStudente
            // 
            buttonStudente.Location = new Point(450, 206);
            buttonStudente.Name = "buttonStudente";
            buttonStudente.Size = new Size(94, 29);
            buttonStudente.TabIndex = 8;
            buttonStudente.Text = "Studente";
            buttonStudente.UseVisualStyleBackColor = true;
            buttonStudente.Click += buttonStudente_Click;
            // 
            // labelStudente
            // 
            labelStudente.AutoSize = true;
            labelStudente.Location = new Point(593, 186);
            labelStudente.Name = "labelStudente";
            labelStudente.Size = new Size(42, 20);
            labelStudente.TabIndex = 9;
            labelStudente.Text = "anno";
            // 
            // buttonPrumuovi
            // 
            buttonPrumuovi.Enabled = false;
            buttonPrumuovi.Location = new Point(573, 154);
            buttonPrumuovi.Name = "buttonPrumuovi";
            buttonPrumuovi.Size = new Size(94, 29);
            buttonPrumuovi.TabIndex = 10;
            buttonPrumuovi.Text = "promuovi";
            buttonPrumuovi.UseVisualStyleBackColor = true;
            buttonPrumuovi.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(382, 241);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonPrumuovi);
            Controls.Add(labelStudente);
            Controls.Add(buttonStudente);
            Controls.Add(labelNome);
            Controls.Add(labelAltezza);
            Controls.Add(buttonCresci);
            Controls.Add(buttonCreaPersona);
            Controls.Add(buttonLeggiProprieta);
            Name = "Form1";
            Text = "FormPersona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreaPersona;
        private Button buttonLeggiProprieta;
        private Button buttonCresci;
        private Label labelAltezza;
        private Label labelNome;
        private Button buttonStudente;
        private Label labelStudente;
        private Button buttonPrumuovi;
        private DateTimePicker dateTimePicker1;
    }
}
