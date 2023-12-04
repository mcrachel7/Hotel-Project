
namespace Tarea3_Hotel
{
    partial class Secundario
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.combTipo = new System.Windows.Forms.ComboBox();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.combCapa = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label_NHabitacion = new System.Windows.Forms.Label();
            this.label_tipo = new System.Windows.Forms.Label();
            this.label_Descrip = new System.Windows.Forms.Label();
            this.label_Capa = new System.Windows.Forms.Label();
            this.label_hotel = new System.Windows.Forms.Label();
            this.btnAct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_guardar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.MistyRose;
            this.btn_guardar.Location = new System.Drawing.Point(236, 320);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(132, 37);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Agregar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // combTipo
            // 
            this.combTipo.FormattingEnabled = true;
            this.combTipo.Items.AddRange(new object[] {
            "Suite",
            "Deluxe",
            "Sencilla"});
            this.combTipo.Location = new System.Drawing.Point(360, 141);
            this.combTipo.Name = "combTipo";
            this.combTipo.Size = new System.Drawing.Size(117, 21);
            this.combTipo.TabIndex = 4;
            // 
            // txtDescri
            // 
            this.txtDescri.Location = new System.Drawing.Point(360, 185);
            this.txtDescri.Multiline = true;
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(173, 40);
            this.txtDescri.TabIndex = 2;
            // 
            // combCapa
            // 
            this.combCapa.FormattingEnabled = true;
            this.combCapa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.combCapa.Location = new System.Drawing.Point(360, 244);
            this.combCapa.Name = "combCapa";
            this.combCapa.Size = new System.Drawing.Size(128, 21);
            this.combCapa.TabIndex = 3;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(360, 97);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(163, 20);
            this.txtNum.TabIndex = 5;
            // 
            // label_NHabitacion
            // 
            this.label_NHabitacion.AutoSize = true;
            this.label_NHabitacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NHabitacion.Location = new System.Drawing.Point(245, 95);
            this.label_NHabitacion.Name = "label_NHabitacion";
            this.label_NHabitacion.Size = new System.Drawing.Size(96, 20);
            this.label_NHabitacion.TabIndex = 6;
            this.label_NHabitacion.Text = "No.Habitación";
            // 
            // label_tipo
            // 
            this.label_tipo.AutoSize = true;
            this.label_tipo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipo.Location = new System.Drawing.Point(215, 139);
            this.label_tipo.Name = "label_tipo";
            this.label_tipo.Size = new System.Drawing.Size(126, 20);
            this.label_tipo.TabIndex = 7;
            this.label_tipo.Text = "Tipo de Habitación";
            // 
            // label_Descrip
            // 
            this.label_Descrip.AutoSize = true;
            this.label_Descrip.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Descrip.Location = new System.Drawing.Point(245, 185);
            this.label_Descrip.Name = "label_Descrip";
            this.label_Descrip.Size = new System.Drawing.Size(83, 20);
            this.label_Descrip.TabIndex = 8;
            this.label_Descrip.Text = "Descripción";
            // 
            // label_Capa
            // 
            this.label_Capa.AutoSize = true;
            this.label_Capa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Capa.Location = new System.Drawing.Point(250, 244);
            this.label_Capa.Name = "label_Capa";
            this.label_Capa.Size = new System.Drawing.Size(74, 20);
            this.label_Capa.TabIndex = 9;
            this.label_Capa.Text = "Capacidad";
            // 
            // label_hotel
            // 
            this.label_hotel.AutoSize = true;
            this.label_hotel.Font = new System.Drawing.Font("Forte", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_hotel.Location = new System.Drawing.Point(160, 33);
            this.label_hotel.Name = "label_hotel";
            this.label_hotel.Size = new System.Drawing.Size(477, 35);
            this.label_hotel.TabIndex = 11;
            this.label_hotel.Text = "CONTROL DE HABITACIONES";
            // 
            // btnAct
            // 
            this.btnAct.BackColor = System.Drawing.Color.Firebrick;
            this.btnAct.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAct.ForeColor = System.Drawing.Color.MistyRose;
            this.btnAct.Location = new System.Drawing.Point(445, 320);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(132, 37);
            this.btnAct.TabIndex = 12;
            this.btnAct.Text = "Limpiar";
            this.btnAct.UseVisualStyleBackColor = false;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // Secundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.label_hotel);
            this.Controls.Add(this.label_Capa);
            this.Controls.Add(this.label_Descrip);
            this.Controls.Add(this.label_tipo);
            this.Controls.Add(this.label_NHabitacion);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.combCapa);
            this.Controls.Add(this.txtDescri);
            this.Controls.Add(this.combTipo);
            this.Controls.Add(this.btn_guardar);
            this.Name = "Secundario";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox combTipo;
        private System.Windows.Forms.TextBox txtDescri;
        private System.Windows.Forms.ComboBox combCapa;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label_NHabitacion;
        private System.Windows.Forms.Label label_tipo;
        private System.Windows.Forms.Label label_Descrip;
        private System.Windows.Forms.Label label_Capa;
        private System.Windows.Forms.Label label_hotel;
        private System.Windows.Forms.Button btnAct;
    }
}