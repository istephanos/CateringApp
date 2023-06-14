namespace Catering
{
    partial class Eveniment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EvenimentDGV = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.labelNumeClient = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numeClientCb = new System.Windows.Forms.ComboBox();
            this.adresaEvenimentTb = new System.Windows.Forms.TextBox();
            this.labelDataLivrarii = new System.Windows.Forms.Label();
            this.dataLivrariiDTP = new System.Windows.Forms.DateTimePicker();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.statusCb = new System.Windows.Forms.ComboBox();
            this.labelNrInvitati = new System.Windows.Forms.Label();
            this.nrInvitatiNUD = new System.Windows.Forms.NumericUpDown();
            this.labelDenumireEveniment = new System.Windows.Forms.Label();
            this.denumireEvenimentTb = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EvenimentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrInvitatiNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // EvenimentDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.EvenimentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EvenimentDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EvenimentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EvenimentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EvenimentDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.EvenimentDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EvenimentDGV.Location = new System.Drawing.Point(30, 355);
            this.EvenimentDGV.Name = "EvenimentDGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EvenimentDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.EvenimentDGV.RowHeadersWidth = 51;
            this.EvenimentDGV.RowTemplate.Height = 24;
            this.EvenimentDGV.Size = new System.Drawing.Size(976, 282);
            this.EvenimentDGV.TabIndex = 17;
            this.EvenimentDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EvenimentDGV_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(376, 252);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 43);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Editare Comanda";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(598, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 43);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Stergere";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.Location = new System.Drawing.Point(146, 252);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(127, 43);
            this.btnSalvare.TabIndex = 14;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // labelNumeClient
            // 
            this.labelNumeClient.AutoSize = true;
            this.labelNumeClient.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeClient.Location = new System.Drawing.Point(270, 73);
            this.labelNumeClient.Name = "labelNumeClient";
            this.labelNumeClient.Size = new System.Drawing.Size(193, 31);
            this.labelNumeClient.TabIndex = 8;
            this.labelNumeClient.Text = "Nume client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(675, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lista evenimentelor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Introducere date eveniment";
            // 
            // numeClientCb
            // 
            this.numeClientCb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeClientCb.FormattingEnabled = true;
            this.numeClientCb.Location = new System.Drawing.Point(276, 107);
            this.numeClientCb.Name = "numeClientCb";
            this.numeClientCb.Size = new System.Drawing.Size(177, 32);
            this.numeClientCb.TabIndex = 8;
            // 
            // adresaEvenimentTb
            // 
            this.adresaEvenimentTb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresaEvenimentTb.Location = new System.Drawing.Point(499, 187);
            this.adresaEvenimentTb.Name = "adresaEvenimentTb";
            this.adresaEvenimentTb.Size = new System.Drawing.Size(228, 30);
            this.adresaEvenimentTb.TabIndex = 12;
            this.adresaEvenimentTb.TextChanged += new System.EventHandler(this.eventAdresaEvenimentTb);
            // 
            // labelDataLivrarii
            // 
            this.labelDataLivrarii.AutoSize = true;
            this.labelDataLivrarii.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataLivrarii.Location = new System.Drawing.Point(493, 73);
            this.labelDataLivrarii.Name = "labelDataLivrarii";
            this.labelDataLivrarii.Size = new System.Drawing.Size(225, 31);
            this.labelDataLivrarii.TabIndex = 7;
            this.labelDataLivrarii.Text = "Data Livrarii";
            // 
            // dataLivrariiDTP
            // 
            this.dataLivrariiDTP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLivrariiDTP.Location = new System.Drawing.Point(499, 107);
            this.dataLivrariiDTP.Name = "dataLivrariiDTP";
            this.dataLivrariiDTP.Size = new System.Drawing.Size(231, 30);
            this.dataLivrariiDTP.TabIndex = 9;
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresa.Location = new System.Drawing.Point(493, 153);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(130, 31);
            this.labelAdresa.TabIndex = 7;
            this.labelAdresa.Text = "Adresa";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(3, 153);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(122, 31);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Status";
            // 
            // statusCb
            // 
            this.statusCb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCb.FormattingEnabled = true;
            this.statusCb.Items.AddRange(new object[] {
            "in asteptare",
            "finalizata"});
            this.statusCb.Location = new System.Drawing.Point(9, 187);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(226, 32);
            this.statusCb.TabIndex = 10;
            // 
            // labelNrInvitati
            // 
            this.labelNrInvitati.AutoSize = true;
            this.labelNrInvitati.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNrInvitati.Location = new System.Drawing.Point(270, 153);
            this.labelNrInvitati.Name = "labelNrInvitati";
            this.labelNrInvitati.Size = new System.Drawing.Size(181, 31);
            this.labelNrInvitati.TabIndex = 8;
            this.labelNrInvitati.Text = "Nr invitati";
            // 
            // nrInvitatiNUD
            // 
            this.nrInvitatiNUD.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrInvitatiNUD.Location = new System.Drawing.Point(276, 188);
            this.nrInvitatiNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nrInvitatiNUD.Name = "nrInvitatiNUD";
            this.nrInvitatiNUD.Size = new System.Drawing.Size(175, 30);
            this.nrInvitatiNUD.TabIndex = 11;
            // 
            // labelDenumireEveniment
            // 
            this.labelDenumireEveniment.AutoSize = true;
            this.labelDenumireEveniment.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumireEveniment.Location = new System.Drawing.Point(3, 73);
            this.labelDenumireEveniment.Name = "labelDenumireEveniment";
            this.labelDenumireEveniment.Size = new System.Drawing.Size(232, 31);
            this.labelDenumireEveniment.TabIndex = 7;
            this.labelDenumireEveniment.Text = "Den eveniment";
            // 
            // denumireEvenimentTb
            // 
            this.denumireEvenimentTb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denumireEvenimentTb.Location = new System.Drawing.Point(9, 107);
            this.denumireEvenimentTb.Name = "denumireEvenimentTb";
            this.denumireEvenimentTb.Size = new System.Drawing.Size(226, 30);
            this.denumireEvenimentTb.TabIndex = 7;
            this.denumireEvenimentTb.TextChanged += new System.EventHandler(this.eventDenumireEvenimentTb);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Eveniment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.nrInvitatiNUD);
            this.Controls.Add(this.dataLivrariiDTP);
            this.Controls.Add(this.denumireEvenimentTb);
            this.Controls.Add(this.adresaEvenimentTb);
            this.Controls.Add(this.statusCb);
            this.Controls.Add(this.numeClientCb);
            this.Controls.Add(this.EvenimentDGV);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.labelDenumireEveniment);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.labelDataLivrarii);
            this.Controls.Add(this.labelNrInvitati);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelNumeClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Eveniment";
            this.Size = new System.Drawing.Size(1030, 668);
            ((System.ComponentModel.ISupportInitialize)(this.EvenimentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrInvitatiNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EvenimentDGV;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Label labelNumeClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox numeClientCb;
        private System.Windows.Forms.TextBox adresaEvenimentTb;
        private System.Windows.Forms.Label labelDataLivrarii;
        private System.Windows.Forms.DateTimePicker dataLivrariiDTP;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox statusCb;
        private System.Windows.Forms.Label labelNrInvitati;
        private System.Windows.Forms.NumericUpDown nrInvitatiNUD;
        private System.Windows.Forms.Label labelDenumireEveniment;
        private System.Windows.Forms.TextBox denumireEvenimentTb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
