
namespace practica071021
{
    partial class frmAlumno
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
            this.dtgAlumnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdStudent = new MetroFramework.Controls.MetroTextBox();
            this.txtNameStudent = new MetroFramework.Controls.MetroTextBox();
            this.txtLastNameStudent = new MetroFramework.Controls.MetroTextBox();
            this.txtAgeStudent = new MetroFramework.Controls.MetroTextBox();
            this.cbYearStudent = new System.Windows.Forms.ComboBox();
            this.cbSesionStudent = new System.Windows.Forms.ComboBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAlumnos
            // 
            this.dtgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlumnos.Location = new System.Drawing.Point(48, 303);
            this.dtgAlumnos.Name = "dtgAlumnos";
            this.dtgAlumnos.RowHeadersWidth = 51;
            this.dtgAlumnos.RowTemplate.Height = 24;
            this.dtgAlumnos.Size = new System.Drawing.Size(751, 150);
            this.dtgAlumnos.TabIndex = 0;
            this.dtgAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlumnos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Grado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sección";
            // 
            // txtIdStudent
            // 
            // 
            // 
            // 
            this.txtIdStudent.CustomButton.Image = null;
            this.txtIdStudent.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtIdStudent.CustomButton.Name = "";
            this.txtIdStudent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdStudent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdStudent.CustomButton.TabIndex = 1;
            this.txtIdStudent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdStudent.CustomButton.UseSelectable = true;
            this.txtIdStudent.CustomButton.Visible = false;
            this.txtIdStudent.Lines = new string[0];
            this.txtIdStudent.Location = new System.Drawing.Point(96, 75);
            this.txtIdStudent.MaxLength = 32767;
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.PasswordChar = '\0';
            this.txtIdStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdStudent.SelectedText = "";
            this.txtIdStudent.SelectionLength = 0;
            this.txtIdStudent.SelectionStart = 0;
            this.txtIdStudent.ShortcutsEnabled = true;
            this.txtIdStudent.Size = new System.Drawing.Size(192, 23);
            this.txtIdStudent.TabIndex = 8;
            this.txtIdStudent.UseSelectable = true;
            this.txtIdStudent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdStudent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNameStudent
            // 
            // 
            // 
            // 
            this.txtNameStudent.CustomButton.Image = null;
            this.txtNameStudent.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtNameStudent.CustomButton.Name = "";
            this.txtNameStudent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameStudent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameStudent.CustomButton.TabIndex = 1;
            this.txtNameStudent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameStudent.CustomButton.UseSelectable = true;
            this.txtNameStudent.CustomButton.Visible = false;
            this.txtNameStudent.Lines = new string[0];
            this.txtNameStudent.Location = new System.Drawing.Point(96, 110);
            this.txtNameStudent.MaxLength = 32767;
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.PasswordChar = '\0';
            this.txtNameStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameStudent.SelectedText = "";
            this.txtNameStudent.SelectionLength = 0;
            this.txtNameStudent.SelectionStart = 0;
            this.txtNameStudent.ShortcutsEnabled = true;
            this.txtNameStudent.Size = new System.Drawing.Size(192, 23);
            this.txtNameStudent.TabIndex = 9;
            this.txtNameStudent.UseSelectable = true;
            this.txtNameStudent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameStudent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastNameStudent
            // 
            // 
            // 
            // 
            this.txtLastNameStudent.CustomButton.Image = null;
            this.txtLastNameStudent.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtLastNameStudent.CustomButton.Name = "";
            this.txtLastNameStudent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastNameStudent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastNameStudent.CustomButton.TabIndex = 1;
            this.txtLastNameStudent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastNameStudent.CustomButton.UseSelectable = true;
            this.txtLastNameStudent.CustomButton.Visible = false;
            this.txtLastNameStudent.Lines = new string[0];
            this.txtLastNameStudent.Location = new System.Drawing.Point(96, 154);
            this.txtLastNameStudent.MaxLength = 32767;
            this.txtLastNameStudent.Name = "txtLastNameStudent";
            this.txtLastNameStudent.PasswordChar = '\0';
            this.txtLastNameStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastNameStudent.SelectedText = "";
            this.txtLastNameStudent.SelectionLength = 0;
            this.txtLastNameStudent.SelectionStart = 0;
            this.txtLastNameStudent.ShortcutsEnabled = true;
            this.txtLastNameStudent.Size = new System.Drawing.Size(192, 23);
            this.txtLastNameStudent.TabIndex = 10;
            this.txtLastNameStudent.UseSelectable = true;
            this.txtLastNameStudent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastNameStudent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAgeStudent
            // 
            // 
            // 
            // 
            this.txtAgeStudent.CustomButton.Image = null;
            this.txtAgeStudent.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtAgeStudent.CustomButton.Name = "";
            this.txtAgeStudent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAgeStudent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAgeStudent.CustomButton.TabIndex = 1;
            this.txtAgeStudent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAgeStudent.CustomButton.UseSelectable = true;
            this.txtAgeStudent.CustomButton.Visible = false;
            this.txtAgeStudent.Lines = new string[0];
            this.txtAgeStudent.Location = new System.Drawing.Point(420, 75);
            this.txtAgeStudent.MaxLength = 32767;
            this.txtAgeStudent.Name = "txtAgeStudent";
            this.txtAgeStudent.PasswordChar = '\0';
            this.txtAgeStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAgeStudent.SelectedText = "";
            this.txtAgeStudent.SelectionLength = 0;
            this.txtAgeStudent.SelectionStart = 0;
            this.txtAgeStudent.ShortcutsEnabled = true;
            this.txtAgeStudent.Size = new System.Drawing.Size(75, 23);
            this.txtAgeStudent.TabIndex = 11;
            this.txtAgeStudent.UseSelectable = true;
            this.txtAgeStudent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAgeStudent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbYearStudent
            // 
            this.cbYearStudent.FormattingEnabled = true;
            this.cbYearStudent.Items.AddRange(new object[] {
            "Primer Grado",
            "Segundo Grado",
            "Tercer Grado",
            "Cuarto Grado",
            "Quinto Grado ",
            "Sexto Grado",
            "Septimo Grado ",
            "Octavo Grado ",
            "Noveno Grado "});
            this.cbYearStudent.Location = new System.Drawing.Point(420, 112);
            this.cbYearStudent.Name = "cbYearStudent";
            this.cbYearStudent.Size = new System.Drawing.Size(121, 24);
            this.cbYearStudent.TabIndex = 12;
            // 
            // cbSesionStudent
            // 
            this.cbSesionStudent.FormattingEnabled = true;
            this.cbSesionStudent.Items.AddRange(new object[] {
            "\"A\"",
            "\"B\"",
            "\"C\""});
            this.cbSesionStudent.Location = new System.Drawing.Point(420, 153);
            this.cbSesionStudent.Name = "cbSesionStudent";
            this.cbSesionStudent.Size = new System.Drawing.Size(121, 24);
            this.cbSesionStudent.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 44);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 44);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(743, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 49);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Salir";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAlumno
            // 
            this.ClientSize = new System.Drawing.Size(846, 465);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbSesionStudent);
            this.Controls.Add(this.cbYearStudent);
            this.Controls.Add(this.txtAgeStudent);
            this.Controls.Add(this.txtLastNameStudent);
            this.Controls.Add(this.txtNameStudent);
            this.Controls.Add(this.txtIdStudent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgAlumnos);
            this.Name = "frmAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtLastname;
        private MetroFramework.Controls.MetroTextBox txtAge;
        private MetroFramework.Controls.MetroTextBox txtSesion;
        private MetroFramework.Controls.MetroTextBox txtSchoolyear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.DataGridView dtgAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtIdStudent;
        private MetroFramework.Controls.MetroTextBox txtNameStudent;
        private MetroFramework.Controls.MetroTextBox txtLastNameStudent;
        private MetroFramework.Controls.MetroTextBox txtAgeStudent;
        private System.Windows.Forms.ComboBox cbYearStudent;
        private System.Windows.Forms.ComboBox cbSesionStudent;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnExit;
    }
}