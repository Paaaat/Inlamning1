namespace Inlamning1
{
    partial class Form1
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
            this.Dataview = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gatuadress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Epost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Födelsedag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.txtFödelsedag = new System.Windows.Forms.TextBox();
            this.txtEpost = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtPostort = new System.Windows.Forms.TextBox();
            this.txtPostnummer = new System.Windows.Forms.TextBox();
            this.txtGatuadress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lstPersoner = new System.Windows.Forms.ListBox();
            this.txtSok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdUppdatera = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // Dataview
            // 
            this.Dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Namn,
            this.Gatuadress,
            this.Postnummer,
            this.Postort,
            this.Telefon,
            this.Epost,
            this.Födelsedag});
            this.Dataview.Location = new System.Drawing.Point(179, 12);
            this.Dataview.Name = "Dataview";
            this.Dataview.RowHeadersVisible = false;
            this.Dataview.Size = new System.Drawing.Size(805, 380);
            this.Dataview.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Namn
            // 
            this.Namn.HeaderText = "Namn";
            this.Namn.Name = "Namn";
            // 
            // Gatuadress
            // 
            this.Gatuadress.HeaderText = "Gatuadress";
            this.Gatuadress.Name = "Gatuadress";
            // 
            // Postnummer
            // 
            this.Postnummer.HeaderText = "Postnummer";
            this.Postnummer.Name = "Postnummer";
            // 
            // Postort
            // 
            this.Postort.HeaderText = "Postort";
            this.Postort.Name = "Postort";
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // Epost
            // 
            this.Epost.HeaderText = "Epost";
            this.Epost.Name = "Epost";
            // 
            // Födelsedag
            // 
            this.Födelsedag.HeaderText = "Födelsedag";
            this.Födelsedag.Name = "Födelsedag";
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(1099, 102);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(100, 20);
            this.txtNamn.TabIndex = 1;
            // 
            // txtFödelsedag
            // 
            this.txtFödelsedag.Location = new System.Drawing.Point(1099, 258);
            this.txtFödelsedag.Name = "txtFödelsedag";
            this.txtFödelsedag.Size = new System.Drawing.Size(100, 20);
            this.txtFödelsedag.TabIndex = 2;
            // 
            // txtEpost
            // 
            this.txtEpost.Location = new System.Drawing.Point(1099, 232);
            this.txtEpost.Name = "txtEpost";
            this.txtEpost.Size = new System.Drawing.Size(100, 20);
            this.txtEpost.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(1099, 206);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtPostort
            // 
            this.txtPostort.Location = new System.Drawing.Point(1099, 180);
            this.txtPostort.Name = "txtPostort";
            this.txtPostort.Size = new System.Drawing.Size(100, 20);
            this.txtPostort.TabIndex = 5;
            // 
            // txtPostnummer
            // 
            this.txtPostnummer.Location = new System.Drawing.Point(1099, 154);
            this.txtPostnummer.Name = "txtPostnummer";
            this.txtPostnummer.Size = new System.Drawing.Size(100, 20);
            this.txtPostnummer.TabIndex = 6;
            // 
            // txtGatuadress
            // 
            this.txtGatuadress.Location = new System.Drawing.Point(1099, 128);
            this.txtGatuadress.Name = "txtGatuadress";
            this.txtGatuadress.Size = new System.Drawing.Size(100, 20);
            this.txtGatuadress.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1033, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1033, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gatuadress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1033, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Postnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1033, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Postort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1033, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1033, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Epost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1033, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Födelsedag";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(1124, 295);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 15;
            this.cmdAdd.Text = "Lägg till";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lstPersoner
            // 
            this.lstPersoner.FormattingEnabled = true;
            this.lstPersoner.Location = new System.Drawing.Point(12, 12);
            this.lstPersoner.Name = "lstPersoner";
            this.lstPersoner.Size = new System.Drawing.Size(150, 381);
            this.lstPersoner.TabIndex = 17;
            this.lstPersoner.SelectedIndexChanged += new System.EventHandler(this.lstPersoner_SelectedIndexChanged);
            // 
            // txtSok
            // 
            this.txtSok.Location = new System.Drawing.Point(40, 399);
            this.txtSok.Name = "txtSok";
            this.txtSok.Size = new System.Drawing.Size(122, 20);
            this.txtSok.TabIndex = 18;
            this.txtSok.TextChanged += new System.EventHandler(this.txtSok_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sök";
            // 
            // cmdUppdatera
            // 
            this.cmdUppdatera.Location = new System.Drawing.Point(1036, 295);
            this.cmdUppdatera.Name = "cmdUppdatera";
            this.cmdUppdatera.Size = new System.Drawing.Size(75, 23);
            this.cmdUppdatera.TabIndex = 20;
            this.cmdUppdatera.Text = "Uppdatera";
            this.cmdUppdatera.UseVisualStyleBackColor = true;
            this.cmdUppdatera.Click += new System.EventHandler(this.cmdUppdatera_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(1036, 324);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 22);
            this.cmdDelete.TabIndex = 21;
            this.cmdDelete.Text = "Tabort";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 432);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdUppdatera);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSok);
            this.Controls.Add(this.lstPersoner);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGatuadress);
            this.Controls.Add(this.txtPostnummer);
            this.Controls.Add(this.txtPostort);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEpost);
            this.Controls.Add(this.txtFödelsedag);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.Dataview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dataview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gatuadress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Epost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Födelsedag;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.TextBox txtFödelsedag;
        private System.Windows.Forms.TextBox txtEpost;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtPostort;
        private System.Windows.Forms.TextBox txtPostnummer;
        private System.Windows.Forms.TextBox txtGatuadress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ListBox lstPersoner;
        private System.Windows.Forms.TextBox txtSok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdUppdatera;
        private System.Windows.Forms.Button cmdDelete;
    }
}

