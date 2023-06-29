namespace Fase4_Nelson_Rueda
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnLoginIngresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLoginContrasena = new System.Windows.Forms.TextBox();
            this.lblLoginContrasena = new System.Windows.Forms.Label();
            this.lblLoginAutor = new System.Windows.Forms.Label();
            this.lblLoginNombreApp = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoginIngresar
            // 
            this.btnLoginIngresar.Location = new System.Drawing.Point(302, 291);
            this.btnLoginIngresar.Name = "btnLoginIngresar";
            this.btnLoginIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnLoginIngresar.TabIndex = 0;
            this.btnLoginIngresar.Text = "Ingresar";
            this.btnLoginIngresar.UseVisualStyleBackColor = true;
            this.btnLoginIngresar.Click += new System.EventHandler(this.btnLoginIngresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(302, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 196);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtLoginContrasena
            // 
            this.txtLoginContrasena.Location = new System.Drawing.Point(139, 176);
            this.txtLoginContrasena.Name = "txtLoginContrasena";
            this.txtLoginContrasena.PasswordChar = '*';
            this.txtLoginContrasena.Size = new System.Drawing.Size(100, 23);
            this.txtLoginContrasena.TabIndex = 10;
            // 
            // lblLoginContrasena
            // 
            this.lblLoginContrasena.AutoSize = true;
            this.lblLoginContrasena.Location = new System.Drawing.Point(99, 145);
            this.lblLoginContrasena.Name = "lblLoginContrasena";
            this.lblLoginContrasena.Size = new System.Drawing.Size(197, 15);
            this.lblLoginContrasena.TabIndex = 9;
            this.lblLoginContrasena.Text = "Para continua, ingrese la contraseña";
            // 
            // lblLoginAutor
            // 
            this.lblLoginAutor.AutoSize = true;
            this.lblLoginAutor.Location = new System.Drawing.Point(113, 111);
            this.lblLoginAutor.Name = "lblLoginAutor";
            this.lblLoginAutor.Size = new System.Drawing.Size(164, 15);
            this.lblLoginAutor.TabIndex = 7;
            this.lblLoginAutor.Text = "Nelson Miguel Rueda Chacón";
            // 
            // lblLoginNombreApp
            // 
            this.lblLoginNombreApp.AutoSize = true;
            this.lblLoginNombreApp.Location = new System.Drawing.Point(129, 61);
            this.lblLoginNombreApp.Name = "lblLoginNombreApp";
            this.lblLoginNombreApp.Size = new System.Drawing.Size(147, 15);
            this.lblLoginNombreApp.TabIndex = 12;
            this.lblLoginNombreApp.Text = "Arbol Binario de Busqueda";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 332);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 23);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 367);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblLoginNombreApp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLoginContrasena);
            this.Controls.Add(this.lblLoginContrasena);
            this.Controls.Add(this.lblLoginAutor);
            this.Controls.Add(this.btnLoginIngresar);
            this.Name = "FormLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoginIngresar;
        private PictureBox pictureBox1;
        private TextBox txtLoginContrasena;
        private Label lblLoginContrasena;
        private Label lblLoginAutor;
        private Label lblLoginNombreApp;
        private DateTimePicker dateTimePicker1;
    }
}