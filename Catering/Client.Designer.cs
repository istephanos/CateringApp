namespace Catering
{
    partial class Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumeClient = new System.Windows.Forms.Label();
            this.labelPrenumeClient = new System.Windows.Forms.Label();
            this.labelTelefonClient = new System.Windows.Forms.Label();
            this.labelEmailClient = new System.Windows.Forms.Label();
            this.NumeClientTb = new System.Windows.Forms.TextBox();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ClientDGV = new System.Windows.Forms.DataGridView();
            this.PrenumeClientTb = new System.Windows.Forms.TextBox();
            this.TelefonClientTb = new System.Windows.Forms.TextBox();
            this.EmailClientTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ColumnCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CautareTb = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introducere date clienti";
            // 
            // labelNumeClient
            // 
            this.labelNumeClient.AutoSize = true;
            this.labelNumeClient.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeClient.Location = new System.Drawing.Point(22, 96);
            this.labelNumeClient.Name = "labelNumeClient";
            this.labelNumeClient.Size = new System.Drawing.Size(89, 31);
            this.labelNumeClient.TabIndex = 0;
            this.labelNumeClient.Text = "Nume";
            // 
            // labelPrenumeClient
            // 
            this.labelPrenumeClient.AutoSize = true;
            this.labelPrenumeClient.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenumeClient.Location = new System.Drawing.Point(268, 96);
            this.labelPrenumeClient.Name = "labelPrenumeClient";
            this.labelPrenumeClient.Size = new System.Drawing.Size(144, 31);
            this.labelPrenumeClient.TabIndex = 0;
            this.labelPrenumeClient.Text = "Prenume";
            // 
            // labelTelefonClient
            // 
            this.labelTelefonClient.AutoSize = true;
            this.labelTelefonClient.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefonClient.Location = new System.Drawing.Point(517, 96);
            this.labelTelefonClient.Name = "labelTelefonClient";
            this.labelTelefonClient.Size = new System.Drawing.Size(135, 31);
            this.labelTelefonClient.TabIndex = 0;
            this.labelTelefonClient.Text = "Telefon";
            // 
            // labelEmailClient
            // 
            this.labelEmailClient.AutoSize = true;
            this.labelEmailClient.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailClient.Location = new System.Drawing.Point(762, 96);
            this.labelEmailClient.Name = "labelEmailClient";
            this.labelEmailClient.Size = new System.Drawing.Size(101, 31);
            this.labelEmailClient.TabIndex = 0;
            this.labelEmailClient.Text = "Email";
            // 
            // NumeClientTb
            // 
            this.NumeClientTb.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeClientTb.Location = new System.Drawing.Point(28, 130);
            this.NumeClientTb.Name = "NumeClientTb";
            this.NumeClientTb.Size = new System.Drawing.Size(228, 38);
            this.NumeClientTb.TabIndex = 1;
            this.NumeClientTb.TextChanged += new System.EventHandler(this.eventNumeClientTb);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.Location = new System.Drawing.Point(183, 184);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(127, 43);
            this.btnSalvare.TabIndex = 5;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(635, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 43);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Stergere";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(413, 184);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 43);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Editare";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(701, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lista clientilor";
            // 
            // ClientDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.ClientDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientDGV.Location = new System.Drawing.Point(28, 295);
            this.ClientDGV.Name = "ClientDGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClientDGV.RowHeadersWidth = 51;
            this.ClientDGV.RowTemplate.Height = 24;
            this.ClientDGV.Size = new System.Drawing.Size(976, 339);
            this.ClientDGV.TabIndex = 10;
            this.ClientDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientDGV_CellClick);
            // 
            // PrenumeClientTb
            // 
            this.PrenumeClientTb.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenumeClientTb.Location = new System.Drawing.Point(274, 130);
            this.PrenumeClientTb.Name = "PrenumeClientTb";
            this.PrenumeClientTb.Size = new System.Drawing.Size(228, 38);
            this.PrenumeClientTb.TabIndex = 2;
            this.PrenumeClientTb.TextChanged += new System.EventHandler(this.eventPrenumeClientTb);
            // 
            // TelefonClientTb
            // 
            this.TelefonClientTb.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonClientTb.Location = new System.Drawing.Point(523, 130);
            this.TelefonClientTb.Name = "TelefonClientTb";
            this.TelefonClientTb.Size = new System.Drawing.Size(228, 38);
            this.TelefonClientTb.TabIndex = 3;
            this.TelefonClientTb.TextChanged += new System.EventHandler(this.eventTelefonClientTb);
            // 
            // EmailClientTb
            // 
            this.EmailClientTb.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailClientTb.Location = new System.Drawing.Point(768, 130);
            this.EmailClientTb.Name = "EmailClientTb";
            this.EmailClientTb.Size = new System.Drawing.Size(228, 38);
            this.EmailClientTb.TabIndex = 4;
            this.EmailClientTb.TextChanged += new System.EventHandler(this.eventEmailClient);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Coloana";
            // 
            // ColumnCb
            // 
            this.ColumnCb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnCb.FormattingEnabled = true;
            this.ColumnCb.Items.AddRange(new object[] {
            "All",
            "ID_CLIENT",
            "NUME_CLIENT",
            "PRENUME_CLIENT",
            "TELEFON_CLIENT",
            "EMAIL_CLIENT"});
            this.ColumnCb.Location = new System.Drawing.Point(28, 257);
            this.ColumnCb.Name = "ColumnCb";
            this.ColumnCb.Size = new System.Drawing.Size(139, 35);
            this.ColumnCb.TabIndex = 8;
            this.ColumnCb.Text = "All";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(186, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cauta";
            // 
            // CautareTb
            // 
            this.CautareTb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautareTb.Location = new System.Drawing.Point(192, 258);
            this.CautareTb.Name = "CautareTb";
            this.CautareTb.Size = new System.Drawing.Size(215, 34);
            this.CautareTb.TabIndex = 9;
            this.CautareTb.TextChanged += new System.EventHandler(this.CautareTb_TextChanged);
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Britannic Bold", 13.8F);
            this.btnCauta.Location = new System.Drawing.Point(413, 256);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(127, 35);
            this.btnCauta.TabIndex = 9;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.ColumnCb);
            this.Controls.Add(this.ClientDGV);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.EmailClientTb);
            this.Controls.Add(this.TelefonClientTb);
            this.Controls.Add(this.PrenumeClientTb);
            this.Controls.Add(this.CautareTb);
            this.Controls.Add(this.NumeClientTb);
            this.Controls.Add(this.labelEmailClient);
            this.Controls.Add(this.labelTelefonClient);
            this.Controls.Add(this.labelPrenumeClient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelNumeClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Size = new System.Drawing.Size(1030, 668);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumeClient;
        private System.Windows.Forms.Label labelPrenumeClient;
        private System.Windows.Forms.Label labelTelefonClient;
        private System.Windows.Forms.Label labelEmailClient;
        private System.Windows.Forms.TextBox NumeClientTb;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ClientDGV;
        private System.Windows.Forms.TextBox PrenumeClientTb;
        private System.Windows.Forms.TextBox TelefonClientTb;
        private System.Windows.Forms.TextBox EmailClientTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ColumnCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CautareTb;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
