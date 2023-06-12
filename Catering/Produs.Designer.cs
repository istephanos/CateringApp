namespace Catering
{
    partial class Produs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProdusDGV = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.descriereProdusTb = new System.Windows.Forms.TextBox();
            this.denumireProdusTb = new System.Windows.Forms.TextBox();
            this.labelDescriere = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pretProdusNUD = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCautaProdus = new System.Windows.Forms.Button();
            this.ColumnProdusCb = new System.Windows.Forms.ComboBox();
            this.CautareProdusTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProdusDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretProdusNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdusDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.ProdusDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProdusDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProdusDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdusDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.ProdusDGV.Location = new System.Drawing.Point(30, 298);
            this.ProdusDGV.Name = "ProdusDGV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdusDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ProdusDGV.RowHeadersWidth = 51;
            this.ProdusDGV.RowTemplate.Height = 24;
            this.ProdusDGV.Size = new System.Drawing.Size(976, 339);
            this.ProdusDGV.TabIndex = 7;
            this.ProdusDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdusDGV_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(411, 172);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 43);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Editare";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(633, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 43);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Stergere";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.Location = new System.Drawing.Point(181, 172);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(127, 43);
            this.btnSalvare.TabIndex = 4;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // descriereProdusTb
            // 
            this.descriereProdusTb.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriereProdusTb.Location = new System.Drawing.Point(694, 110);
            this.descriereProdusTb.Name = "descriereProdusTb";
            this.descriereProdusTb.Size = new System.Drawing.Size(228, 38);
            this.descriereProdusTb.TabIndex = 3;
            this.descriereProdusTb.TextChanged += new System.EventHandler(this.eventDesciereProdusTb);
            // 
            // denumireProdusTb
            // 
            this.denumireProdusTb.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denumireProdusTb.Location = new System.Drawing.Point(30, 110);
            this.denumireProdusTb.Name = "denumireProdusTb";
            this.denumireProdusTb.Size = new System.Drawing.Size(228, 38);
            this.denumireProdusTb.TabIndex = 1;
            this.denumireProdusTb.TextChanged += new System.EventHandler(this.eventDenumireProdusTb);
            // 
            // labelDescriere
            // 
            this.labelDescriere.AutoSize = true;
            this.labelDescriere.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriere.Location = new System.Drawing.Point(688, 76);
            this.labelDescriere.Name = "labelDescriere";
            this.labelDescriere.Size = new System.Drawing.Size(168, 31);
            this.labelDescriere.TabIndex = 6;
            this.labelDescriere.Text = "Descriere";
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPret.Location = new System.Drawing.Point(358, 76);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(86, 31);
            this.labelPret.TabIndex = 7;
            this.labelPret.Text = "Pret";
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumire.Location = new System.Drawing.Point(24, 76);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(154, 31);
            this.labelDenumire.TabIndex = 8;
            this.labelDenumire.Text = "Denumire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(703, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lista produselor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Introducere date produse";
            // 
            // pretProdusNUD
            // 
            this.pretProdusNUD.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretProdusNUD.Location = new System.Drawing.Point(364, 110);
            this.pretProdusNUD.Name = "pretProdusNUD";
            this.pretProdusNUD.Size = new System.Drawing.Size(175, 38);
            this.pretProdusNUD.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCautaProdus
            // 
            this.btnCautaProdus.Font = new System.Drawing.Font("Britannic Bold", 13.8F);
            this.btnCautaProdus.Location = new System.Drawing.Point(415, 254);
            this.btnCautaProdus.Name = "btnCautaProdus";
            this.btnCautaProdus.Size = new System.Drawing.Size(127, 35);
            this.btnCautaProdus.TabIndex = 26;
            this.btnCautaProdus.Text = "Cauta";
            this.btnCautaProdus.UseVisualStyleBackColor = true;
            // 
            // ColumnProdusCb
            // 
            this.ColumnProdusCb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnProdusCb.FormattingEnabled = true;
            this.ColumnProdusCb.Items.AddRange(new object[] {
            "All",
            "ID_CLIENT",
            "NUME_CLIENT",
            "PRENUME_CLIENT",
            "TELEFON_CLIENT",
            "EMAIL_CLIENT"});
            this.ColumnProdusCb.Location = new System.Drawing.Point(30, 255);
            this.ColumnProdusCb.Name = "ColumnProdusCb";
            this.ColumnProdusCb.Size = new System.Drawing.Size(139, 35);
            this.ColumnProdusCb.TabIndex = 25;
            this.ColumnProdusCb.Text = "All";
            // 
            // CautareProdusTb
            // 
            this.CautareProdusTb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautareProdusTb.Location = new System.Drawing.Point(194, 256);
            this.CautareProdusTb.Name = "CautareProdusTb";
            this.CautareProdusTb.Size = new System.Drawing.Size(215, 34);
            this.CautareProdusTb.TabIndex = 24;
            this.CautareProdusTb.TextChanged += new System.EventHandler(this.CautareProdusTb_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(188, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cauta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "Coloana";
            // 
            // Produs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnCautaProdus);
            this.Controls.Add(this.ColumnProdusCb);
            this.Controls.Add(this.CautareProdusTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pretProdusNUD);
            this.Controls.Add(this.ProdusDGV);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.descriereProdusTb);
            this.Controls.Add(this.denumireProdusTb);
            this.Controls.Add(this.labelDescriere);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Produs";
            this.Size = new System.Drawing.Size(1030, 668);
            ((System.ComponentModel.ISupportInitialize)(this.ProdusDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretProdusNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProdusDGV;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.TextBox descriereProdusTb;
        private System.Windows.Forms.TextBox denumireProdusTb;
        private System.Windows.Forms.Label labelDescriere;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pretProdusNUD;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCautaProdus;
        private System.Windows.Forms.ComboBox ColumnProdusCb;
        private System.Windows.Forms.TextBox CautareProdusTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
