namespace Simulador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.BTNJugar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.Goles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amlocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rojlocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVisitante = new System.Windows.Forms.DataGridView();
            this.golvisitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amvisitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rojvisitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblminutos = new System.Windows.Forms.Label();
            this.lblgolloc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblgolvis = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblDelantero4 = new System.Windows.Forms.Label();
            this.lblDelantero3 = new System.Windows.Forms.Label();
            this.lblVolante6 = new System.Windows.Forms.Label();
            this.lblVolante5 = new System.Windows.Forms.Label();
            this.lblDefensor6 = new System.Windows.Forms.Label();
            this.lblDefensor5 = new System.Windows.Forms.Label();
            this.lblArquero2 = new System.Windows.Forms.Label();
            this.cmbDel = new System.Windows.Forms.ComboBox();
            this.cmbVol = new System.Windows.Forms.ComboBox();
            this.cmbDef = new System.Windows.Forms.ComboBox();
            this.cmbArq = new System.Windows.Forms.ComboBox();
            this.btnDelantero = new System.Windows.Forms.Button();
            this.btnMedio = new System.Windows.Forms.Button();
            this.btnDefensor = new System.Windows.Forms.Button();
            this.btnArquero = new System.Windows.Forms.Button();
            this.lblDefensor4 = new System.Windows.Forms.Label();
            this.lblVolante1 = new System.Windows.Forms.Label();
            this.lblDelantero1 = new System.Windows.Forms.Label();
            this.lblDelantero2 = new System.Windows.Forms.Label();
            this.lblVolante4 = new System.Windows.Forms.Label();
            this.lblVolante3 = new System.Windows.Forms.Label();
            this.lblDefensor1 = new System.Windows.Forms.Label();
            this.lblVolante2 = new System.Windows.Forms.Label();
            this.lblDefensor3 = new System.Windows.Forms.Label();
            this.lblDefensor2 = new System.Windows.Forms.Label();
            this.lblArquero = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DimGray;
            this.comboBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.DimGray;
            this.comboBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(209, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(161, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tu Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Equipo Rival";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(28, 652);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(217, 73);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver ";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // BTNJugar
            // 
            this.BTNJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNJugar.Location = new System.Drawing.Point(106, 169);
            this.BTNJugar.Name = "BTNJugar";
            this.BTNJugar.Size = new System.Drawing.Size(159, 59);
            this.BTNJugar.TabIndex = 10;
            this.BTNJugar.Text = "Jugar";
            this.BTNJugar.UseVisualStyleBackColor = false;
            this.BTNJugar.Click += new System.EventHandler(this.BTNJugar_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvLocal
            // 
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Goles,
            this.minuto,
            this.amlocal,
            this.rojlocal});
            this.dgvLocal.Location = new System.Drawing.Point(12, 271);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.Size = new System.Drawing.Size(245, 120);
            this.dgvLocal.TabIndex = 16;
            // 
            // Goles
            // 
            this.Goles.HeaderText = "Gol";
            this.Goles.Name = "Goles";
            // 
            // minuto
            // 
            this.minuto.HeaderText = "Minuto";
            this.minuto.Name = "minuto";
            // 
            // amlocal
            // 
            this.amlocal.HeaderText = "Amarillas";
            this.amlocal.Name = "amlocal";
            // 
            // rojlocal
            // 
            this.rojlocal.HeaderText = "Rojas";
            this.rojlocal.Name = "rojlocal";
            // 
            // dgvVisitante
            // 
            this.dgvVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.golvisitante,
            this.minutog,
            this.amvisitante,
            this.rojvisitante});
            this.dgvVisitante.Location = new System.Drawing.Point(260, 271);
            this.dgvVisitante.Name = "dgvVisitante";
            this.dgvVisitante.Size = new System.Drawing.Size(245, 120);
            this.dgvVisitante.TabIndex = 17;
            // 
            // golvisitante
            // 
            this.golvisitante.HeaderText = "Gol";
            this.golvisitante.Name = "golvisitante";
            // 
            // minutog
            // 
            this.minutog.HeaderText = "Minuto";
            this.minutog.Name = "minutog";
            // 
            // amvisitante
            // 
            this.amvisitante.HeaderText = "Amarillas";
            this.amvisitante.Name = "amvisitante";
            // 
            // rojvisitante
            // 
            this.rojvisitante.HeaderText = "Rojas";
            this.rojvisitante.Name = "rojvisitante";
            // 
            // lblminutos
            // 
            this.lblminutos.AutoSize = true;
            this.lblminutos.BackColor = System.Drawing.Color.Transparent;
            this.lblminutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminutos.ForeColor = System.Drawing.Color.White;
            this.lblminutos.Location = new System.Drawing.Point(289, 169);
            this.lblminutos.Name = "lblminutos";
            this.lblminutos.Size = new System.Drawing.Size(46, 42);
            this.lblminutos.TabIndex = 18;
            this.lblminutos.Text = "0\'";
            // 
            // lblgolloc
            // 
            this.lblgolloc.AutoSize = true;
            this.lblgolloc.BackColor = System.Drawing.Color.Transparent;
            this.lblgolloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgolloc.ForeColor = System.Drawing.Color.White;
            this.lblgolloc.Location = new System.Drawing.Point(271, 222);
            this.lblgolloc.Name = "lblgolloc";
            this.lblgolloc.Size = new System.Drawing.Size(39, 42);
            this.lblgolloc.TabIndex = 19;
            this.lblgolloc.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(299, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 42);
            this.label5.TabIndex = 20;
            this.label5.Text = "-";
            // 
            // lblgolvis
            // 
            this.lblgolvis.AutoSize = true;
            this.lblgolvis.BackColor = System.Drawing.Color.Transparent;
            this.lblgolvis.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgolvis.ForeColor = System.Drawing.Color.White;
            this.lblgolvis.Location = new System.Drawing.Point(318, 222);
            this.lblgolvis.Name = "lblgolvis";
            this.lblgolvis.Size = new System.Drawing.Size(39, 42);
            this.lblgolvis.TabIndex = 21;
            this.lblgolvis.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(377, 188);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 22;
            // 
            // lblDelantero4
            // 
            this.lblDelantero4.AutoSize = true;
            this.lblDelantero4.Location = new System.Drawing.Point(566, 342);
            this.lblDelantero4.Name = "lblDelantero4";
            this.lblDelantero4.Size = new System.Drawing.Size(53, 13);
            this.lblDelantero4.TabIndex = 100;
            this.lblDelantero4.Text = "Delantero";
            // 
            // lblDelantero3
            // 
            this.lblDelantero3.AutoSize = true;
            this.lblDelantero3.Location = new System.Drawing.Point(566, 320);
            this.lblDelantero3.Name = "lblDelantero3";
            this.lblDelantero3.Size = new System.Drawing.Size(53, 13);
            this.lblDelantero3.TabIndex = 99;
            this.lblDelantero3.Text = "Delantero";
            // 
            // lblVolante6
            // 
            this.lblVolante6.AutoSize = true;
            this.lblVolante6.Location = new System.Drawing.Point(567, 298);
            this.lblVolante6.Name = "lblVolante6";
            this.lblVolante6.Size = new System.Drawing.Size(78, 13);
            this.lblVolante6.TabIndex = 98;
            this.lblVolante6.Text = "Mediocampista";
            // 
            // lblVolante5
            // 
            this.lblVolante5.AutoSize = true;
            this.lblVolante5.Location = new System.Drawing.Point(567, 273);
            this.lblVolante5.Name = "lblVolante5";
            this.lblVolante5.Size = new System.Drawing.Size(78, 13);
            this.lblVolante5.TabIndex = 97;
            this.lblVolante5.Text = "Mediocampista";
            // 
            // lblDefensor6
            // 
            this.lblDefensor6.AutoSize = true;
            this.lblDefensor6.Location = new System.Drawing.Point(566, 248);
            this.lblDefensor6.Name = "lblDefensor6";
            this.lblDefensor6.Size = new System.Drawing.Size(50, 13);
            this.lblDefensor6.TabIndex = 96;
            this.lblDefensor6.Text = "Defensor";
            // 
            // lblDefensor5
            // 
            this.lblDefensor5.AutoSize = true;
            this.lblDefensor5.Location = new System.Drawing.Point(566, 222);
            this.lblDefensor5.Name = "lblDefensor5";
            this.lblDefensor5.Size = new System.Drawing.Size(50, 13);
            this.lblDefensor5.TabIndex = 95;
            this.lblDefensor5.Text = "Defensor";
            // 
            // lblArquero2
            // 
            this.lblArquero2.AutoSize = true;
            this.lblArquero2.Location = new System.Drawing.Point(567, 203);
            this.lblArquero2.Name = "lblArquero2";
            this.lblArquero2.Size = new System.Drawing.Size(44, 13);
            this.lblArquero2.TabIndex = 94;
            this.lblArquero2.Text = "Arquero";
            // 
            // cmbDel
            // 
            this.cmbDel.FormattingEnabled = true;
            this.cmbDel.Location = new System.Drawing.Point(880, 86);
            this.cmbDel.Name = "cmbDel";
            this.cmbDel.Size = new System.Drawing.Size(121, 21);
            this.cmbDel.TabIndex = 93;
            // 
            // cmbVol
            // 
            this.cmbVol.FormattingEnabled = true;
            this.cmbVol.Location = new System.Drawing.Point(753, 86);
            this.cmbVol.Name = "cmbVol";
            this.cmbVol.Size = new System.Drawing.Size(121, 21);
            this.cmbVol.TabIndex = 92;
            // 
            // cmbDef
            // 
            this.cmbDef.FormattingEnabled = true;
            this.cmbDef.Location = new System.Drawing.Point(626, 86);
            this.cmbDef.Name = "cmbDef";
            this.cmbDef.Size = new System.Drawing.Size(121, 21);
            this.cmbDef.TabIndex = 91;
            // 
            // cmbArq
            // 
            this.cmbArq.FormattingEnabled = true;
            this.cmbArq.Location = new System.Drawing.Point(496, 86);
            this.cmbArq.Name = "cmbArq";
            this.cmbArq.Size = new System.Drawing.Size(121, 21);
            this.cmbArq.TabIndex = 90;
            // 
            // btnDelantero
            // 
            this.btnDelantero.Location = new System.Drawing.Point(908, 113);
            this.btnDelantero.Name = "btnDelantero";
            this.btnDelantero.Size = new System.Drawing.Size(75, 23);
            this.btnDelantero.TabIndex = 89;
            this.btnDelantero.Text = "Aceptar";
            this.btnDelantero.UseVisualStyleBackColor = true;
            this.btnDelantero.Click += new System.EventHandler(this.btnDelantero_Click_1);
            // 
            // btnMedio
            // 
            this.btnMedio.Location = new System.Drawing.Point(779, 113);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(75, 23);
            this.btnMedio.TabIndex = 88;
            this.btnMedio.Text = "Aceptar";
            this.btnMedio.UseVisualStyleBackColor = true;
            this.btnMedio.Click += new System.EventHandler(this.btnMedio_Click_1);
            // 
            // btnDefensor
            // 
            this.btnDefensor.Location = new System.Drawing.Point(647, 113);
            this.btnDefensor.Name = "btnDefensor";
            this.btnDefensor.Size = new System.Drawing.Size(75, 23);
            this.btnDefensor.TabIndex = 87;
            this.btnDefensor.Text = "Aceptar";
            this.btnDefensor.UseVisualStyleBackColor = true;
            this.btnDefensor.Click += new System.EventHandler(this.btnDefensor_Click_1);
            // 
            // btnArquero
            // 
            this.btnArquero.Location = new System.Drawing.Point(522, 113);
            this.btnArquero.Name = "btnArquero";
            this.btnArquero.Size = new System.Drawing.Size(75, 23);
            this.btnArquero.TabIndex = 86;
            this.btnArquero.Text = "Aceptar";
            this.btnArquero.UseVisualStyleBackColor = true;
            this.btnArquero.Click += new System.EventHandler(this.btnArquero_Click_1);
            // 
            // lblDefensor4
            // 
            this.lblDefensor4.AutoSize = true;
            this.lblDefensor4.Location = new System.Drawing.Point(714, 320);
            this.lblDefensor4.Name = "lblDefensor4";
            this.lblDefensor4.Size = new System.Drawing.Size(50, 13);
            this.lblDefensor4.TabIndex = 85;
            this.lblDefensor4.Text = "Defensor";
            // 
            // lblVolante1
            // 
            this.lblVolante1.AutoSize = true;
            this.lblVolante1.Location = new System.Drawing.Point(799, 366);
            this.lblVolante1.Name = "lblVolante1";
            this.lblVolante1.Size = new System.Drawing.Size(78, 13);
            this.lblVolante1.TabIndex = 84;
            this.lblVolante1.Text = "Mediocampista";
            // 
            // lblDelantero1
            // 
            this.lblDelantero1.AutoSize = true;
            this.lblDelantero1.Location = new System.Drawing.Point(739, 534);
            this.lblDelantero1.Name = "lblDelantero1";
            this.lblDelantero1.Size = new System.Drawing.Size(53, 13);
            this.lblDelantero1.TabIndex = 83;
            this.lblDelantero1.Text = "Delantero";
            // 
            // lblDelantero2
            // 
            this.lblDelantero2.AutoSize = true;
            this.lblDelantero2.Location = new System.Drawing.Point(899, 534);
            this.lblDelantero2.Name = "lblDelantero2";
            this.lblDelantero2.Size = new System.Drawing.Size(53, 13);
            this.lblDelantero2.TabIndex = 82;
            this.lblDelantero2.Text = "Delantero";
            // 
            // lblVolante4
            // 
            this.lblVolante4.AutoSize = true;
            this.lblVolante4.Location = new System.Drawing.Point(813, 478);
            this.lblVolante4.Name = "lblVolante4";
            this.lblVolante4.Size = new System.Drawing.Size(78, 13);
            this.lblVolante4.TabIndex = 81;
            this.lblVolante4.Text = "Mediocampista";
            // 
            // lblVolante3
            // 
            this.lblVolante3.AutoSize = true;
            this.lblVolante3.Location = new System.Drawing.Point(714, 409);
            this.lblVolante3.Name = "lblVolante3";
            this.lblVolante3.Size = new System.Drawing.Size(78, 13);
            this.lblVolante3.TabIndex = 80;
            this.lblVolante3.Text = "Mediocampista";
            // 
            // lblDefensor1
            // 
            this.lblDefensor1.AutoSize = true;
            this.lblDefensor1.Location = new System.Drawing.Point(776, 298);
            this.lblDefensor1.Name = "lblDefensor1";
            this.lblDefensor1.Size = new System.Drawing.Size(50, 13);
            this.lblDefensor1.TabIndex = 79;
            this.lblDefensor1.Text = "Defensor";
            // 
            // lblVolante2
            // 
            this.lblVolante2.AutoSize = true;
            this.lblVolante2.Location = new System.Drawing.Point(905, 409);
            this.lblVolante2.Name = "lblVolante2";
            this.lblVolante2.Size = new System.Drawing.Size(78, 13);
            this.lblVolante2.TabIndex = 78;
            this.lblVolante2.Text = "Mediocampista";
            // 
            // lblDefensor3
            // 
            this.lblDefensor3.AutoSize = true;
            this.lblDefensor3.Location = new System.Drawing.Point(933, 320);
            this.lblDefensor3.Name = "lblDefensor3";
            this.lblDefensor3.Size = new System.Drawing.Size(50, 13);
            this.lblDefensor3.TabIndex = 77;
            this.lblDefensor3.Text = "Defensor";
            // 
            // lblDefensor2
            // 
            this.lblDefensor2.AutoSize = true;
            this.lblDefensor2.Location = new System.Drawing.Point(858, 298);
            this.lblDefensor2.Name = "lblDefensor2";
            this.lblDefensor2.Size = new System.Drawing.Size(50, 13);
            this.lblDefensor2.TabIndex = 76;
            this.lblDefensor2.Text = "Defensor";
            // 
            // lblArquero
            // 
            this.lblArquero.AutoSize = true;
            this.lblArquero.Location = new System.Drawing.Point(833, 203);
            this.lblArquero.Name = "lblArquero";
            this.lblArquero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblArquero.Size = new System.Drawing.Size(44, 13);
            this.lblArquero.TabIndex = 75;
            this.lblArquero.Text = "Arquero";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(703, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 482);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1004, 733);
            this.Controls.Add(this.lblDelantero4);
            this.Controls.Add(this.lblDelantero3);
            this.Controls.Add(this.lblVolante6);
            this.Controls.Add(this.lblVolante5);
            this.Controls.Add(this.lblDefensor6);
            this.Controls.Add(this.lblDefensor5);
            this.Controls.Add(this.lblArquero2);
            this.Controls.Add(this.cmbDel);
            this.Controls.Add(this.cmbVol);
            this.Controls.Add(this.cmbDef);
            this.Controls.Add(this.cmbArq);
            this.Controls.Add(this.btnDelantero);
            this.Controls.Add(this.btnMedio);
            this.Controls.Add(this.btnDefensor);
            this.Controls.Add(this.btnArquero);
            this.Controls.Add(this.lblDefensor4);
            this.Controls.Add(this.lblVolante1);
            this.Controls.Add(this.lblDelantero1);
            this.Controls.Add(this.lblDelantero2);
            this.Controls.Add(this.lblVolante4);
            this.Controls.Add(this.lblVolante3);
            this.Controls.Add(this.lblDefensor1);
            this.Controls.Add(this.lblVolante2);
            this.Controls.Add(this.lblDefensor3);
            this.Controls.Add(this.lblDefensor2);
            this.Controls.Add(this.lblArquero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblgolvis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblgolloc);
            this.Controls.Add(this.lblminutos);
            this.Controls.Add(this.dgvVisitante);
            this.Controls.Add(this.dgvLocal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNJugar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button BTNJugar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.DataGridView dgvVisitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn golvisitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutog;
        private System.Windows.Forms.DataGridViewTextBoxColumn amvisitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn rojvisitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goles;
        private System.Windows.Forms.DataGridViewTextBoxColumn minuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn amlocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn rojlocal;
        private System.Windows.Forms.Label lblminutos;
        private System.Windows.Forms.Label lblgolloc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblgolvis;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblDelantero4;
        private System.Windows.Forms.Label lblDelantero3;
        private System.Windows.Forms.Label lblVolante6;
        private System.Windows.Forms.Label lblVolante5;
        private System.Windows.Forms.Label lblDefensor6;
        private System.Windows.Forms.Label lblDefensor5;
        private System.Windows.Forms.Label lblArquero2;
        private System.Windows.Forms.ComboBox cmbDel;
        private System.Windows.Forms.ComboBox cmbVol;
        private System.Windows.Forms.ComboBox cmbDef;
        private System.Windows.Forms.ComboBox cmbArq;
        private System.Windows.Forms.Button btnDelantero;
        private System.Windows.Forms.Button btnMedio;
        private System.Windows.Forms.Button btnDefensor;
        private System.Windows.Forms.Button btnArquero;
        private System.Windows.Forms.Label lblDefensor4;
        private System.Windows.Forms.Label lblVolante1;
        private System.Windows.Forms.Label lblDelantero1;
        private System.Windows.Forms.Label lblDelantero2;
        private System.Windows.Forms.Label lblVolante4;
        private System.Windows.Forms.Label lblVolante3;
        private System.Windows.Forms.Label lblDefensor1;
        private System.Windows.Forms.Label lblVolante2;
        private System.Windows.Forms.Label lblDefensor3;
        private System.Windows.Forms.Label lblDefensor2;
        private System.Windows.Forms.Label lblArquero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

