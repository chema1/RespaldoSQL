namespace respaldoSQL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtDataSourse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtLocalizacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtRespaldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.txtDataSourse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL SERVER AUTENTIFICACION";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(445, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "DESCONECTAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "CONECTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(326, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(85, 52);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(151, 20);
            this.txtUserID.TabIndex = 4;
            // 
            // txtDataSourse
            // 
            this.txtDataSourse.Location = new System.Drawing.Point(85, 25);
            this.txtDataSourse.Name = "txtDataSourse";
            this.txtDataSourse.Size = new System.Drawing.Size(341, 20);
            this.txtDataSourse.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataSourse";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SELECCION DE LA BD";
            // 
            // comboBD
            // 
            this.comboBD.FormattingEnabled = true;
            this.comboBD.Location = new System.Drawing.Point(96, 33);
            this.comboBD.Name = "comboBD";
            this.comboBD.Size = new System.Drawing.Size(224, 21);
            this.comboBD.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Base de Datos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.txtLocalizacion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(574, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RESPALDO DE LA BASE DE DATOS";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(445, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "RESPALDAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(445, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "EXAMINAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtLocalizacion
            // 
            this.txtLocalizacion.Location = new System.Drawing.Point(108, 28);
            this.txtLocalizacion.Name = "txtLocalizacion";
            this.txtLocalizacion.Size = new System.Drawing.Size(168, 20);
            this.txtLocalizacion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "LOCALIZACION";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.txtRespaldo);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(574, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RESTAURACION DE LA BASE DE DATOS";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(445, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "RESTAURAR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(445, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "EXAMINAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtRespaldo
            // 
            this.txtRespaldo.Location = new System.Drawing.Point(143, 41);
            this.txtRespaldo.Name = "txtRespaldo";
            this.txtRespaldo.Size = new System.Drawing.Size(283, 20);
            this.txtRespaldo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "PATH DE RESPALDO";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "IMPORTAR DATOS DESDE EXCEL A SQL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 485);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 139);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 636);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SQL RESPALDO Y RESTAURACION DE LA BASE DE DATOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtDataSourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtLocalizacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtRespaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

