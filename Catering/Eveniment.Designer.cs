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
            this.EvenimentDGV = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idClientCb = new System.Windows.Forms.ComboBox();
            this.adresaEvenimentTb = new System.Windows.Forms.TextBox();
            this.dataComandaDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataLivrariiDTP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nrInvitatiNUD = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnComandaProduse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EvenimentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrInvitatiNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // EvenimentDGV
            // 
            this.EvenimentDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EvenimentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EvenimentDGV.Location = new System.Drawing.Point(30, 355);
            this.EvenimentDGV.Name = "EvenimentDGV";
            this.EvenimentDGV.RowHeadersWidth = 51;
            this.EvenimentDGV.RowTemplate.Height = 24;
            this.EvenimentDGV.Size = new System.Drawing.Size(976, 282);
            this.EvenimentDGV.TabIndex = 18;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(431, 252);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 43);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Editare";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(653, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 43);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Stergere";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.Location = new System.Drawing.Point(201, 252);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(127, 43);
            this.btnSalvare.TabIndex = 17;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Comanda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id Client";
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
            // idClientCb
            // 
            this.idClientCb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClientCb.FormattingEnabled = true;
            this.idClientCb.Location = new System.Drawing.Point(268, 107);
            this.idClientCb.Name = "idClientCb";
            this.idClientCb.Size = new System.Drawing.Size(140, 32);
            this.idClientCb.TabIndex = 19;
            // 
            // adresaEvenimentTb
            // 
            this.adresaEvenimentTb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresaEvenimentTb.Location = new System.Drawing.Point(442, 187);
            this.adresaEvenimentTb.Name = "adresaEvenimentTb";
            this.adresaEvenimentTb.Size = new System.Drawing.Size(228, 30);
            this.adresaEvenimentTb.TabIndex = 20;
            // 
            // dataComandaDTP
            // 
            this.dataComandaDTP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataComandaDTP.Location = new System.Drawing.Point(442, 107);
            this.dataComandaDTP.Name = "dataComandaDTP";
            this.dataComandaDTP.Size = new System.Drawing.Size(231, 30);
            this.dataComandaDTP.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(733, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Livrarii";
            // 
            // dataLivrariiDTP
            // 
            this.dataLivrariiDTP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLivrariiDTP.Location = new System.Drawing.Point(739, 107);
            this.dataLivrariiDTP.Name = "dataLivrariiDTP";
            this.dataLivrariiDTP.Size = new System.Drawing.Size(231, 30);
            this.dataLivrariiDTP.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Status";
            // 
            // statusCb
            // 
            this.statusCb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCb.FormattingEnabled = true;
            this.statusCb.Location = new System.Drawing.Point(30, 187);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(184, 32);
            this.statusCb.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(227, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nr invitati";
            // 
            // nrInvitatiNUD
            // 
            this.nrInvitatiNUD.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrInvitatiNUD.Location = new System.Drawing.Point(233, 188);
            this.nrInvitatiNUD.Name = "nrInvitatiNUD";
            this.nrInvitatiNUD.Size = new System.Drawing.Size(175, 30);
            this.nrInvitatiNUD.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 31);
            this.label9.TabIndex = 7;
            this.label9.Text = "Den eveniment";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 30);
            this.textBox1.TabIndex = 20;
            // 
            // btnComandaProduse
            // 
            this.btnComandaProduse.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComandaProduse.Location = new System.Drawing.Point(779, 180);
            this.btnComandaProduse.Name = "btnComandaProduse";
            this.btnComandaProduse.Size = new System.Drawing.Size(127, 43);
            this.btnComandaProduse.TabIndex = 16;
            this.btnComandaProduse.Text = "Stergere";
            this.btnComandaProduse.UseVisualStyleBackColor = true;
            // 
            // Eveniment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.nrInvitatiNUD);
            this.Controls.Add(this.dataLivrariiDTP);
            this.Controls.Add(this.dataComandaDTP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.adresaEvenimentTb);
            this.Controls.Add(this.statusCb);
            this.Controls.Add(this.idClientCb);
            this.Controls.Add(this.EvenimentDGV);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnComandaProduse);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Eveniment";
            this.Size = new System.Drawing.Size(1030, 668);
            ((System.ComponentModel.ISupportInitialize)(this.EvenimentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrInvitatiNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EvenimentDGV;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox idClientCb;
        private System.Windows.Forms.TextBox adresaEvenimentTb;
        private System.Windows.Forms.DateTimePicker dataComandaDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dataLivrariiDTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox statusCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nrInvitatiNUD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnComandaProduse;
    }
}
