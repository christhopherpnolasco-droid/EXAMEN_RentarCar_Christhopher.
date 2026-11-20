namespace EXAMEN_RentarCar_Christhopher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCliente = new TextBox();
            dptSalida = new DateTimePicker();
            chkCorpotativo = new CheckBox();
            txtVehuculo = new TextBox();
            txtTarifa = new TextBox();
            nudDias = new NumericUpDown();
            rbtBasico = new RadioButton();
            rbtCompleto = new RadioButton();
            rbtSucursal = new RadioButton();
            radioButton4 = new RadioButton();
            chkGps = new CheckBox();
            Alquileres = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bntAgregar = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            bntCalcular = new Button();
            bntLimpiar = new Button();
            bntSalir = new Button();
            label14 = new Label();
            Seguro = new GroupBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblDomicilio = new Label();
            lblItbis = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(145, 106);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(177, 23);
            txtCliente.TabIndex = 0;
            txtCliente.TextChanged += textBox1_TextChanged;
            // 
            // dptSalida
            // 
            dptSalida.Location = new Point(135, 228);
            dptSalida.Name = "dptSalida";
            dptSalida.Size = new Size(200, 23);
            dptSalida.TabIndex = 1;
            // 
            // chkCorpotativo
            // 
            chkCorpotativo.AutoSize = true;
            chkCorpotativo.Location = new Point(105, 170);
            chkCorpotativo.Name = "chkCorpotativo";
            chkCorpotativo.Size = new Size(129, 19);
            chkCorpotativo.TabIndex = 2;
            chkCorpotativo.Text = "Cliente Corporativo";
            chkCorpotativo.UseVisualStyleBackColor = true;
            // 
            // txtVehuculo
            // 
            txtVehuculo.Location = new Point(135, 278);
            txtVehuculo.Name = "txtVehuculo";
            txtVehuculo.Size = new Size(200, 23);
            txtVehuculo.TabIndex = 3;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(135, 345);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(200, 23);
            txtTarifa.TabIndex = 4;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(135, 396);
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(200, 23);
            nudDias.TabIndex = 5;
            // 
            // rbtBasico
            // 
            rbtBasico.AutoSize = true;
            rbtBasico.Location = new Point(135, 498);
            rbtBasico.Name = "rbtBasico";
            rbtBasico.Size = new Size(59, 19);
            rbtBasico.TabIndex = 6;
            rbtBasico.TabStop = true;
            rbtBasico.Text = "Basico";
            rbtBasico.UseVisualStyleBackColor = true;
            // 
            // rbtCompleto
            // 
            rbtCompleto.AutoSize = true;
            rbtCompleto.Location = new Point(135, 546);
            rbtCompleto.Name = "rbtCompleto";
            rbtCompleto.Size = new Size(151, 19);
            rbtCompleto.TabIndex = 7;
            rbtCompleto.TabStop = true;
            rbtCompleto.Text = "Completo (+ RD $1000 )";
            rbtCompleto.UseVisualStyleBackColor = true;
            // 
            // rbtSucursal
            // 
            rbtSucursal.AutoSize = true;
            rbtSucursal.Location = new Point(15, 27);
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.Size = new Size(69, 19);
            rbtSucursal.TabIndex = 8;
            rbtSucursal.TabStop = true;
            rbtSucursal.Text = "Sucursal";
            rbtSucursal.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(15, 75);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(149, 19);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "Domicilio (+ RD $ 2000)";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // chkGps
            // 
            chkGps.AutoSize = true;
            chkGps.Location = new Point(145, 613);
            chkGps.Name = "chkGps";
            chkGps.Size = new Size(114, 19);
            chkGps.TabIndex = 10;
            chkGps.Text = "GPS ( + RD$ 300)";
            chkGps.UseVisualStyleBackColor = true;
            // 
            // Alquileres
            // 
            Alquileres.FormattingEnabled = true;
            Alquileres.Location = new Point(577, 220);
            Alquileres.Name = "Alquileres";
            Alquileres.Size = new Size(390, 199);
            Alquileres.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 114);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 12;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 234);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 13;
            label2.Text = "Salida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 286);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 14;
            label3.Text = "Vehiculo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 353);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 15;
            label4.Text = "Tarifa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 404);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 16;
            label5.Text = "Dias";
            // 
            // bntAgregar
            // 
            bntAgregar.Location = new Point(610, 106);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(271, 66);
            bntAgregar.TabIndex = 17;
            bntAgregar.Text = "AGREGAR AL ALQUILER";
            bntAgregar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(595, 498);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 22;
            label10.Text = "Subtotal";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(595, 532);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 23;
            label11.Text = "Descuento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(595, 572);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 24;
            label12.Text = "Domicilio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(595, 613);
            label13.Name = "label13";
            label13.Size = new Size(72, 15);
            label13.TabIndex = 25;
            label13.Text = "ITBIS ( 18 %)";
            // 
            // bntCalcular
            // 
            bntCalcular.Location = new Point(135, 662);
            bntCalcular.Name = "bntCalcular";
            bntCalcular.Size = new Size(110, 55);
            bntCalcular.TabIndex = 26;
            bntCalcular.Text = "Calcular Total";
            bntCalcular.UseVisualStyleBackColor = true;
            // 
            // bntLimpiar
            // 
            bntLimpiar.Location = new Point(307, 662);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(110, 55);
            bntLimpiar.TabIndex = 27;
            bntLimpiar.Text = "Nuevo Alquiler";
            bntLimpiar.UseVisualStyleBackColor = true;
            // 
            // bntSalir
            // 
            bntSalir.Location = new Point(470, 662);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(110, 55);
            bntSalir.TabIndex = 28;
            bntSalir.Text = "Salir";
            bntSalir.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(641, 662);
            label14.Name = "label14";
            label14.Size = new Size(92, 15);
            label14.TabIndex = 29;
            label14.Text = "TOTAL A PAGAR";
            // 
            // Seguro
            // 
            Seguro.Location = new Point(122, 471);
            Seguro.Name = "Seguro";
            Seguro.Size = new Size(183, 116);
            Seguro.TabIndex = 35;
            Seguro.TabStop = false;
            Seguro.Text = "Seguro";
            Seguro.Enter += groupBox1_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(rbtSucursal);
            groupBox1.Location = new Point(351, 471);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 116);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrga";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(577, 190);
            label6.Name = "label6";
            label6.Size = new Size(348, 15);
            label6.TabIndex = 37;
            label6.Text = "Dias             Vehiculo              Tarifa                                              Total";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(662, 494);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(0, 15);
            lblSubtotal.TabIndex = 38;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(665, 532);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(0, 15);
            lblDescuento.TabIndex = 39;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Location = new Point(665, 572);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(0, 15);
            lblDomicilio.TabIndex = 40;
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(695, 613);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(0, 15);
            lblItbis.TabIndex = 41;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(779, 662);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 42;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 729);
            Controls.Add(lblTotal);
            Controls.Add(lblItbis);
            Controls.Add(lblDomicilio);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label14);
            Controls.Add(bntSalir);
            Controls.Add(bntLimpiar);
            Controls.Add(bntCalcular);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(bntAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Alquileres);
            Controls.Add(chkGps);
            Controls.Add(rbtCompleto);
            Controls.Add(rbtBasico);
            Controls.Add(nudDias);
            Controls.Add(txtTarifa);
            Controls.Add(txtVehuculo);
            Controls.Add(chkCorpotativo);
            Controls.Add(dptSalida);
            Controls.Add(txtCliente);
            Controls.Add(Seguro);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private DateTimePicker dptSalida;
        private CheckBox chkCorpotativo;
        private TextBox txtVehuculo;
        private TextBox txtTarifa;
        private NumericUpDown nudDias;
        private RadioButton rbtBasico;
        private RadioButton rbtCompleto;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton rbtSucursal;
        private RadioButton radioButton4;
        private CheckBox chkGps;
        private ListBox Alquileres;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button bntAgregar;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button bntCalcular;
        private Button bntLimpiar;
        private Button bntSalir;
        private Label label14;
        private GroupBox Seguro;
        private GroupBox groupBox1;
        private Label label6;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblDomicilio;
        private Label lblItbis;
        private Label lblTotal;
    }
}
