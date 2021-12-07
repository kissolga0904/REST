namespace REST_client
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
            this.GetAll_btn = new System.Windows.Forms.Button();
            this.GetCarById_btn = new System.Windows.Forms.Button();
            this.get_car_by_id_numeric = new System.Windows.Forms.NumericUpDown();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.delete_id_numeric = new System.Windows.Forms.NumericUpDown();
            this.tulajdonos_tb = new System.Windows.Forms.TextBox();
            this.marka_tb = new System.Windows.Forms.TextBox();
            this.tulajdonos_update_tb = new System.Windows.Forms.TextBox();
            this.marka_update_tb = new System.Windows.Forms.TextBox();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.tipus_tb = new System.Windows.Forms.TextBox();
            this.szin_tb = new System.Windows.Forms.TextBox();
            this.rendszam_tb = new System.Windows.Forms.TextBox();
            this.tipus_update_tb = new System.Windows.Forms.TextBox();
            this.szin_update_tb = new System.Windows.Forms.TextBox();
            this.rendszam_update_tb = new System.Windows.Forms.TextBox();
            this.autok_dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tulajdonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Márka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Típus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szín = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rendszám = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.get_car_by_id_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_id_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autok_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // GetAll_btn
            // 
            this.GetAll_btn.BackColor = System.Drawing.Color.DarkRed;
            this.GetAll_btn.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GetAll_btn.ForeColor = System.Drawing.Color.Linen;
            this.GetAll_btn.Location = new System.Drawing.Point(447, 12);
            this.GetAll_btn.Name = "GetAll_btn";
            this.GetAll_btn.Size = new System.Drawing.Size(196, 53);
            this.GetAll_btn.TabIndex = 1;
            this.GetAll_btn.Text = "Get All Cars";
            this.GetAll_btn.UseVisualStyleBackColor = false;
            this.GetAll_btn.Click += new System.EventHandler(this.GetAll_btn_Click);
            // 
            // GetCarById_btn
            // 
            this.GetCarById_btn.BackColor = System.Drawing.Color.Maroon;
            this.GetCarById_btn.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GetCarById_btn.ForeColor = System.Drawing.Color.Linen;
            this.GetCarById_btn.Location = new System.Drawing.Point(12, 79);
            this.GetCarById_btn.Name = "GetCarById_btn";
            this.GetCarById_btn.Size = new System.Drawing.Size(196, 55);
            this.GetCarById_btn.TabIndex = 2;
            this.GetCarById_btn.Text = "Get Car By Id";
            this.GetCarById_btn.UseVisualStyleBackColor = false;
            this.GetCarById_btn.Click += new System.EventHandler(this.GetCarById_btn_Click);
            // 
            // get_car_by_id_numeric
            // 
            this.get_car_by_id_numeric.Location = new System.Drawing.Point(214, 114);
            this.get_car_by_id_numeric.Name = "get_car_by_id_numeric";
            this.get_car_by_id_numeric.Size = new System.Drawing.Size(106, 20);
            this.get_car_by_id_numeric.TabIndex = 3;
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Delete_btn.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Delete_btn.ForeColor = System.Drawing.Color.Linen;
            this.Delete_btn.Location = new System.Drawing.Point(12, 194);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(196, 55);
            this.Delete_btn.TabIndex = 4;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Insert_btn
            // 
            this.Insert_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Insert_btn.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Insert_btn.ForeColor = System.Drawing.Color.Bisque;
            this.Insert_btn.Location = new System.Drawing.Point(12, 332);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(196, 55);
            this.Insert_btn.TabIndex = 5;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = false;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Update_btn.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Update_btn.ForeColor = System.Drawing.Color.Linen;
            this.Update_btn.Location = new System.Drawing.Point(12, 460);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(196, 55);
            this.Update_btn.TabIndex = 6;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // delete_id_numeric
            // 
            this.delete_id_numeric.Location = new System.Drawing.Point(214, 229);
            this.delete_id_numeric.Name = "delete_id_numeric";
            this.delete_id_numeric.Size = new System.Drawing.Size(106, 20);
            this.delete_id_numeric.TabIndex = 7;
            // 
            // tulajdonos_tb
            // 
            this.tulajdonos_tb.Location = new System.Drawing.Point(12, 306);
            this.tulajdonos_tb.Name = "tulajdonos_tb";
            this.tulajdonos_tb.Size = new System.Drawing.Size(100, 20);
            this.tulajdonos_tb.TabIndex = 8;
            // 
            // marka_tb
            // 
            this.marka_tb.Location = new System.Drawing.Point(118, 306);
            this.marka_tb.Name = "marka_tb";
            this.marka_tb.Size = new System.Drawing.Size(100, 20);
            this.marka_tb.TabIndex = 9;
            // 
            // tulajdonos_update_tb
            // 
            this.tulajdonos_update_tb.Location = new System.Drawing.Point(12, 434);
            this.tulajdonos_update_tb.Name = "tulajdonos_update_tb";
            this.tulajdonos_update_tb.Size = new System.Drawing.Size(100, 20);
            this.tulajdonos_update_tb.TabIndex = 10;
            // 
            // marka_update_tb
            // 
            this.marka_update_tb.Location = new System.Drawing.Point(118, 434);
            this.marka_update_tb.Name = "marka_update_tb";
            this.marka_update_tb.Size = new System.Drawing.Size(100, 20);
            this.marka_update_tb.TabIndex = 12;
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(468, 170);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(106, 20);
            this.username_tb.TabIndex = 16;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(468, 212);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(106, 20);
            this.password_tb.TabIndex = 17;
            // 
            // tipus_tb
            // 
            this.tipus_tb.Location = new System.Drawing.Point(224, 306);
            this.tipus_tb.Name = "tipus_tb";
            this.tipus_tb.Size = new System.Drawing.Size(100, 20);
            this.tipus_tb.TabIndex = 18;
            // 
            // szin_tb
            // 
            this.szin_tb.Location = new System.Drawing.Point(330, 306);
            this.szin_tb.Name = "szin_tb";
            this.szin_tb.Size = new System.Drawing.Size(100, 20);
            this.szin_tb.TabIndex = 19;
            // 
            // rendszam_tb
            // 
            this.rendszam_tb.Location = new System.Drawing.Point(437, 305);
            this.rendszam_tb.Name = "rendszam_tb";
            this.rendszam_tb.Size = new System.Drawing.Size(100, 20);
            this.rendszam_tb.TabIndex = 20;
            // 
            // tipus_update_tb
            // 
            this.tipus_update_tb.Location = new System.Drawing.Point(224, 434);
            this.tipus_update_tb.Name = "tipus_update_tb";
            this.tipus_update_tb.Size = new System.Drawing.Size(100, 20);
            this.tipus_update_tb.TabIndex = 21;
            // 
            // szin_update_tb
            // 
            this.szin_update_tb.Location = new System.Drawing.Point(330, 434);
            this.szin_update_tb.Name = "szin_update_tb";
            this.szin_update_tb.Size = new System.Drawing.Size(100, 20);
            this.szin_update_tb.TabIndex = 22;
            // 
            // rendszam_update_tb
            // 
            this.rendszam_update_tb.Location = new System.Drawing.Point(437, 434);
            this.rendszam_update_tb.Name = "rendszam_update_tb";
            this.rendszam_update_tb.Size = new System.Drawing.Size(100, 20);
            this.rendszam_update_tb.TabIndex = 23;
            // 
            // autok_dgv
            // 
            this.autok_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autok_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tulajdonos,
            this.Márka,
            this.Típus,
            this.Szín,
            this.Rendszám});
            this.autok_dgv.Location = new System.Drawing.Point(649, 12);
            this.autok_dgv.Name = "autok_dgv";
            this.autok_dgv.Size = new System.Drawing.Size(645, 503);
            this.autok_dgv.TabIndex = 24;
            this.autok_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.autok_dgv_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Tulajdonos
            // 
            this.Tulajdonos.HeaderText = "Tulajdonos";
            this.Tulajdonos.Name = "Tulajdonos";
            // 
            // Márka
            // 
            this.Márka.HeaderText = "Márka";
            this.Márka.Name = "Márka";
            // 
            // Típus
            // 
            this.Típus.HeaderText = "Típus";
            this.Típus.Name = "Típus";
            // 
            // Szín
            // 
            this.Szín.HeaderText = "Szín";
            this.Szín.Name = "Szín";
            // 
            // Rendszám
            // 
            this.Rendszám.HeaderText = "Rendszám";
            this.Rendszám.Name = "Rendszám";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Linen;
            this.Username.Location = new System.Drawing.Point(389, 171);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(72, 16);
            this.Username.TabIndex = 25;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Linen;
            this.Password.Location = new System.Drawing.Point(389, 213);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(72, 16);
            this.Password.TabIndex = 26;
            this.Password.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1330, 541);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.autok_dgv);
            this.Controls.Add(this.rendszam_update_tb);
            this.Controls.Add(this.szin_update_tb);
            this.Controls.Add(this.tipus_update_tb);
            this.Controls.Add(this.rendszam_tb);
            this.Controls.Add(this.szin_tb);
            this.Controls.Add(this.tipus_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.marka_update_tb);
            this.Controls.Add(this.tulajdonos_update_tb);
            this.Controls.Add(this.marka_tb);
            this.Controls.Add(this.tulajdonos_tb);
            this.Controls.Add(this.delete_id_numeric);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.get_car_by_id_numeric);
            this.Controls.Add(this.GetCarById_btn);
            this.Controls.Add(this.GetAll_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.get_car_by_id_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_id_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autok_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GetAll_btn;
        private System.Windows.Forms.Button GetCarById_btn;
        private System.Windows.Forms.NumericUpDown get_car_by_id_numeric;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.NumericUpDown delete_id_numeric;
        private System.Windows.Forms.TextBox tulajdonos_tb;
        private System.Windows.Forms.TextBox marka_tb;
        private System.Windows.Forms.TextBox tulajdonos_update_tb;
        private System.Windows.Forms.TextBox marka_update_tb;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox tipus_tb;
        private System.Windows.Forms.TextBox szin_tb;
        private System.Windows.Forms.TextBox rendszam_tb;
        private System.Windows.Forms.TextBox tipus_update_tb;
        private System.Windows.Forms.TextBox szin_update_tb;
        private System.Windows.Forms.TextBox rendszam_update_tb;
        private System.Windows.Forms.DataGridView autok_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tulajdonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Márka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Típus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Szín;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rendszám;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
    }
}

