namespace Catering
{
    partial class ComandaProdus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCautaProdus = new System.Windows.Forms.Button();
            this.ColumnProdusCb = new System.Windows.Forms.ComboBox();
            this.CautareProdusTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.ComenziDGV = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnComanda = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numeEvenimentCb = new System.Windows.Forms.ComboBox();
            this.labelEveniment = new System.Windows.Forms.Label();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.listViewProduse = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComenziDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCautaProdus
            // 
            this.btnCautaProdus.Font = new System.Drawing.Font("Britannic Bold", 13.8F);
            this.btnCautaProdus.Location = new System.Drawing.Point(415, 382);
            this.btnCautaProdus.Name = "btnCautaProdus";
            this.btnCautaProdus.Size = new System.Drawing.Size(127, 35);
            this.btnCautaProdus.TabIndex = 43;
            this.btnCautaProdus.Text = "Cauta";
            this.btnCautaProdus.UseVisualStyleBackColor = true;
            this.btnCautaProdus.Visible = false;
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
            this.ColumnProdusCb.Location = new System.Drawing.Point(30, 383);
            this.ColumnProdusCb.Name = "ColumnProdusCb";
            this.ColumnProdusCb.Size = new System.Drawing.Size(139, 35);
            this.ColumnProdusCb.TabIndex = 42;
            this.ColumnProdusCb.Text = "All";
            this.ColumnProdusCb.Visible = false;
            // 
            // CautareProdusTb
            // 
            this.CautareProdusTb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautareProdusTb.Location = new System.Drawing.Point(194, 384);
            this.CautareProdusTb.Name = "CautareProdusTb";
            this.CautareProdusTb.Size = new System.Drawing.Size(215, 34);
            this.CautareProdusTb.TabIndex = 41;
            this.CautareProdusTb.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 31);
            this.label7.TabIndex = 40;
            this.label7.Text = "Coloana";
            this.label7.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(188, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 39;
            this.label8.Text = "Cauta";
            this.label8.Visible = false;
            // 
            // ComenziDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.ComenziDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ComenziDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ComenziDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ComenziDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ComenziDGV.Location = new System.Drawing.Point(30, 433);
            this.ComenziDGV.Name = "ComenziDGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ComenziDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ComenziDGV.RowHeadersWidth = 51;
            this.ComenziDGV.RowTemplate.Height = 24;
            this.ComenziDGV.Size = new System.Drawing.Size(976, 204);
            this.ComenziDGV.TabIndex = 35;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(415, 277);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(173, 72);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Editare comanda";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(657, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 72);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Stergere comanda";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnComanda
            // 
            this.btnComanda.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComanda.Location = new System.Drawing.Point(194, 277);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(146, 72);
            this.btnComanda.TabIndex = 30;
            this.btnComanda.Text = "Comanda";
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(703, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 31);
            this.label6.TabIndex = 37;
            this.label6.Text = "Lista produselor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Comanda produse pentru eveniment";
            // 
            // numeEvenimentCb
            // 
            this.numeEvenimentCb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeEvenimentCb.FormattingEnabled = true;
            this.numeEvenimentCb.Items.AddRange(new object[] {
            "alegeti un eveniment"});
            this.numeEvenimentCb.Location = new System.Drawing.Point(30, 112);
            this.numeEvenimentCb.Name = "numeEvenimentCb";
            this.numeEvenimentCb.Size = new System.Drawing.Size(268, 32);
            this.numeEvenimentCb.TabIndex = 44;
            this.numeEvenimentCb.SelectedIndexChanged += new System.EventHandler(this.numeEvenimentCb_SelectedIndexChanged_1);
            // 
            // labelEveniment
            // 
            this.labelEveniment.AutoSize = true;
            this.labelEveniment.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEveniment.Location = new System.Drawing.Point(24, 78);
            this.labelEveniment.Name = "labelEveniment";
            this.labelEveniment.Size = new System.Drawing.Size(170, 31);
            this.labelEveniment.TabIndex = 45;
            this.labelEveniment.Text = "Eveniment";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // listViewProduse
            // 
            this.listViewProduse.HideSelection = false;
            this.listViewProduse.Location = new System.Drawing.Point(316, 112);
            this.listViewProduse.Name = "listViewProduse";
            this.listViewProduse.Size = new System.Drawing.Size(690, 144);
            this.listViewProduse.TabIndex = 46;
            this.listViewProduse.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 31);
            this.label5.TabIndex = 47;
            this.label5.Text = "Produse";
            // 
            // ComandaProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.listViewProduse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numeEvenimentCb);
            this.Controls.Add(this.labelEveniment);
            this.Controls.Add(this.btnCautaProdus);
            this.Controls.Add(this.ColumnProdusCb);
            this.Controls.Add(this.CautareProdusTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComenziDGV);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnComanda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "ComandaProdus";
            this.Size = new System.Drawing.Size(1030, 668);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComenziDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCautaProdus;
        private System.Windows.Forms.ComboBox ColumnProdusCb;
        private System.Windows.Forms.TextBox CautareProdusTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ComenziDGV;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox numeEvenimentCb;
        private System.Windows.Forms.Label labelEveniment;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.ListView listViewProduse;
        private System.Windows.Forms.Label label5;
    }
}
