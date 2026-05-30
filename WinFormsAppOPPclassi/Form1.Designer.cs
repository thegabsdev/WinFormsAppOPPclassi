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
            buttonCreaPersona.Location = new Point(70, 111);
            buttonCreaPersona.Margin = new Padding(3, 2, 3, 2);
            buttonCreaPersona.Name = "buttonCreaPersona";
            buttonCreaPersona.Size = new Size(82, 22);
            buttonCreaPersona.TabIndex = 0;
            buttonCreaPersona.Text = "Crea";
            buttonCreaPersona.UseVisualStyleBackColor = true;
            buttonCreaPersona.Click += buttonCreaPersona_Click;
            // 
            // buttonLeggiProprieta
            // 
            buttonLeggiProprieta.Enabled = false;
            buttonLeggiProprieta.Location = new Point(73, 198);
            buttonLeggiProprieta.Name = "buttonLeggiProprieta";
            buttonLeggiProprieta.Size = new Size(82, 21);
            buttonLeggiProprieta.TabIndex = 2;
            buttonLeggiProprieta.Text = "button1";
            buttonLeggiProprieta.UseVisualStyleBackColor = true;
            buttonLeggiProprieta.Click += buttonLeggiProprieta_Click;
            // 
            // buttonCresci
            // 
            buttonCresci.Location = new Point(73, 154);
            buttonCresci.Name = "buttonCresci";
            buttonCresci.Size = new Size(89, 30);
            buttonCresci.TabIndex = 5;
            buttonCresci.Text = "cresci";
            buttonCresci.UseVisualStyleBackColor = true;
            buttonCresci.Click += buttonCresci_Click;
            // 
            // labelAltezza
            // 
            labelAltezza.AutoSize = true;
            labelAltezza.Location = new Point(194, 163);
            labelAltezza.Name = "labelAltezza";
            labelAltezza.Size = new Size(38, 15);
            labelAltezza.TabIndex = 6;
            labelAltezza.Text = "label1";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(173, 112);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(38, 15);
            labelNome.TabIndex = 7;
            labelNome.Text = "label1";
            // 
            // buttonStudente
            // 
            buttonStudente.Location = new Point(394, 154);
            buttonStudente.Margin = new Padding(3, 2, 3, 2);
            buttonStudente.Name = "buttonStudente";
            buttonStudente.Size = new Size(82, 22);
            buttonStudente.TabIndex = 8;
            buttonStudente.Text = "Studente";
            buttonStudente.UseVisualStyleBackColor = true;
            buttonStudente.Click += buttonStudente_Click;
            // 
            // labelStudente
            // 
            labelStudente.AutoSize = true;
            labelStudente.Location = new Point(519, 140);
            labelStudente.Name = "labelStudente";
            labelStudente.Size = new Size(34, 15);
            labelStudente.TabIndex = 9;
            labelStudente.Text = "anno";
            // 
            // buttonPrumuovi
            // 
            buttonPrumuovi.Enabled = false;
            buttonPrumuovi.Location = new Point(501, 116);
            buttonPrumuovi.Margin = new Padding(3, 2, 3, 2);
            buttonPrumuovi.Name = "buttonPrumuovi";
            buttonPrumuovi.Size = new Size(82, 22);
            buttonPrumuovi.TabIndex = 10;
            buttonPrumuovi.Text = "promuovi";
            buttonPrumuovi.UseVisualStyleBackColor = true;
            buttonPrumuovi.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(334, 181);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonPrumuovi);
            Controls.Add(labelStudente);
            Controls.Add(buttonStudente);
            Controls.Add(labelNome);
            Controls.Add(labelAltezza);
            Controls.Add(buttonCresci);
            Controls.Add(buttonCreaPersona);
            Controls.Add(buttonLeggiProprieta);
            Margin = new Padding(3, 2, 3, 2);
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
