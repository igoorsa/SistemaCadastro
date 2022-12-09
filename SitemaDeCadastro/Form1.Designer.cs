namespace SitemaDeCadastro
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTxt = new System.Windows.Forms.DateTimePicker();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.Sexo = new System.Windows.Forms.GroupBox();
            this.RadioO = new System.Windows.Forms.RadioButton();
            this.RadioF = new System.Windows.Forms.RadioButton();
            this.RadioM = new System.Windows.Forms.RadioButton();
            this.CarCheck = new System.Windows.Forms.CheckBox();
            this.HouseCheck = new System.Windows.Forms.CheckBox();
            this.ChildrenCheck = new System.Windows.Forms.CheckBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.PhoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Listas_Nomes = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.Status = new System.Windows.Forms.ComboBox();
            this.Sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // DateTxt
            // 
            this.DateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTxt.Location = new System.Drawing.Point(357, 92);
            this.DateTxt.Name = "DateTxt";
            this.DateTxt.Size = new System.Drawing.Size(429, 32);
            this.DateTxt.TabIndex = 4;
            this.DateTxt.Value = new System.DateTime(2000, 1, 4, 0, 0, 0, 0);
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(357, 37);
            this.NameTxt.MinimumSize = new System.Drawing.Size(4, 4);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(429, 32);
            this.NameTxt.TabIndex = 5;
            // 
            // Sexo
            // 
            this.Sexo.Controls.Add(this.RadioO);
            this.Sexo.Controls.Add(this.RadioF);
            this.Sexo.Controls.Add(this.RadioM);
            this.Sexo.Location = new System.Drawing.Point(23, 249);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(293, 77);
            this.Sexo.TabIndex = 7;
            this.Sexo.TabStop = false;
            this.Sexo.Text = "Sexo";
            // 
            // RadioO
            // 
            this.RadioO.AutoSize = true;
            this.RadioO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioO.Location = new System.Drawing.Point(207, 30);
            this.RadioO.Name = "RadioO";
            this.RadioO.Size = new System.Drawing.Size(75, 24);
            this.RadioO.TabIndex = 2;
            this.RadioO.Text = "Outros";
            this.RadioO.UseVisualStyleBackColor = true;
            // 
            // RadioF
            // 
            this.RadioF.AutoSize = true;
            this.RadioF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioF.Location = new System.Drawing.Point(109, 30);
            this.RadioF.Name = "RadioF";
            this.RadioF.Size = new System.Drawing.Size(92, 24);
            this.RadioF.TabIndex = 1;
            this.RadioF.Text = "Feminino";
            this.RadioF.UseVisualStyleBackColor = true;
            // 
            // RadioM
            // 
            this.RadioM.AutoSize = true;
            this.RadioM.Checked = true;
            this.RadioM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioM.Location = new System.Drawing.Point(5, 30);
            this.RadioM.Name = "RadioM";
            this.RadioM.Size = new System.Drawing.Size(98, 24);
            this.RadioM.TabIndex = 0;
            this.RadioM.TabStop = true;
            this.RadioM.Text = "Masculino";
            this.RadioM.UseVisualStyleBackColor = true;
            // 
            // CarCheck
            // 
            this.CarCheck.AutoSize = true;
            this.CarCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarCheck.Location = new System.Drawing.Point(357, 296);
            this.CarCheck.Name = "CarCheck";
            this.CarCheck.Size = new System.Drawing.Size(233, 30);
            this.CarCheck.TabIndex = 8;
            this.CarCheck.Text = "Possui Carro Próprio";
            this.CarCheck.UseVisualStyleBackColor = true;
            // 
            // HouseCheck
            // 
            this.HouseCheck.AutoSize = true;
            this.HouseCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseCheck.Location = new System.Drawing.Point(563, 249);
            this.HouseCheck.Name = "HouseCheck";
            this.HouseCheck.Size = new System.Drawing.Size(223, 30);
            this.HouseCheck.TabIndex = 11;
            this.HouseCheck.Text = "Possui Casa Própia";
            this.HouseCheck.UseVisualStyleBackColor = true;
            // 
            // ChildrenCheck
            // 
            this.ChildrenCheck.AutoSize = true;
            this.ChildrenCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildrenCheck.Location = new System.Drawing.Point(357, 249);
            this.ChildrenCheck.Name = "ChildrenCheck";
            this.ChildrenCheck.Size = new System.Drawing.Size(161, 30);
            this.ChildrenCheck.TabIndex = 12;
            this.ChildrenCheck.Text = "Possui Filhos";
            this.ChildrenCheck.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(23, 357);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(217, 59);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Cadastrar/Alterar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(298, 357);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(217, 59);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Exlcuir";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(569, 357);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(217, 59);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Limpar Campo";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTxt.Location = new System.Drawing.Point(357, 150);
            this.PhoneTxt.Mask = "(00) 00000-0000";
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(429, 32);
            this.PhoneTxt.TabIndex = 17;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(15, 194);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(198, 45);
            this.label.TabIndex = 18;
            this.label.Text = "Estado Civil";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Listas_Nomes
            // 
            this.Listas_Nomes.FormattingEnabled = true;
            this.Listas_Nomes.Location = new System.Drawing.Point(23, 422);
            this.Listas_Nomes.Name = "Listas_Nomes";
            this.Listas_Nomes.Size = new System.Drawing.Size(763, 108);
            this.Listas_Nomes.TabIndex = 20;
            this.Listas_Nomes.DoubleClick += new System.EventHandler(this.Listas_Nomes_DoubleClick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(812, 24);
            this.menuStrip2.TabIndex = 21;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(812, 24);
            this.menuStrip3.TabIndex = 22;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // Status
            // 
            this.Status.DisplayMember = "1";
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Viúvo",
            "Divórciado"});
            this.Status.Location = new System.Drawing.Point(357, 204);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(429, 33);
            this.Status.TabIndex = 23;
            this.Status.TabStop = false;
            this.Status.Tag = "";
            this.Status.ValueMember = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 547);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Listas_Nomes);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.ChildrenCheck);
            this.Controls.Add(this.HouseCheck);
            this.Controls.Add(this.CarCheck);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.DateTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Sexo.ResumeLayout(false);
            this.Sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.GroupBox Sexo;
        private System.Windows.Forms.RadioButton RadioO;
        private System.Windows.Forms.RadioButton RadioF;
        private System.Windows.Forms.RadioButton RadioM;
        private System.Windows.Forms.CheckBox CarCheck;
        private System.Windows.Forms.CheckBox HouseCheck;
        private System.Windows.Forms.CheckBox ChildrenCheck;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox PhoneTxt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox Listas_Nomes;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ComboBox Status;
    }
}

