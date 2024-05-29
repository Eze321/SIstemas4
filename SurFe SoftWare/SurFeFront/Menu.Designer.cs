namespace SurFe
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            bindingSource1 = new BindingSource(components);
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            btSalir = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.BackgroundImage = SurFeFront.Properties.Resources.venta;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 348);
            button2.Name = "button2";
            button2.Size = new Size(100, 60);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(581, 163);
            button3.Name = "button3";
            button3.Size = new Size(151, 43);
            button3.TabIndex = 2;
            button3.Text = "DEPOSITO";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.BackgroundImage = SurFeFront.Properties.Resources.clientes1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(118, 348);
            button1.Name = "button1";
            button1.Size = new Size(100, 60);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btSalir
            // 
            btSalir.BackColor = Color.DarkCyan;
            btSalir.BackgroundImage = SurFeFront.Properties.Resources.saliiir;
            btSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btSalir.FlatAppearance.BorderColor = Color.White;
            btSalir.FlatStyle = FlatStyle.Flat;
            btSalir.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btSalir.Location = new Point(632, 348);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(100, 60);
            btSalir.TabIndex = 5;
            btSalir.UseVisualStyleBackColor = false;
            btSalir.Click += btSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(44, 411);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Venta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(149, 411);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Cliente";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(668, 411);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 8;
            label3.Text = "Salir";
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(581, 114);
            button4.Name = "button4";
            button4.Size = new Size(151, 43);
            button4.TabIndex = 3;
            button4.Text = "INFORMES";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DodgerBlue;
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(581, 65);
            button5.Name = "button5";
            button5.Size = new Size(151, 43);
            button5.TabIndex = 6;
            button5.Text = "PRODUCTOS";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            BackgroundImage = SurFeFront.Properties.Resources.FONDO_OV;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(744, 431);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(btSalir);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button btSalir;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button4;
        private Button button5;
    }
}