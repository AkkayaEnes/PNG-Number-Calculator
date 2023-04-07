namespace HesapMak_210408009
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;


        /// <param name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows

        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEşittir = new System.Windows.Forms.Button();
            this.nokta = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnArtıEksi = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnÇıkar = new System.Windows.Forms.Button();
            this.btnÇarp = new System.Windows.Forms.Button();
            this.btnBöl = new System.Windows.Forms.Button();
            this.btnTemizleE = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSilson = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.sonuç = new System.Windows.Forms.TextBox();
            this.lastString = new System.Windows.Forms.Label();
            this.memoryPanel = new System.Windows.Forms.Panel();
            this.trash = new System.Windows.Forms.Button();
            this.memoryData = new System.Windows.Forms.TextBox();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.historyData = new System.Windows.Forms.TextBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.memoryPanel.SuspendLayout();
            this.historyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEşittir
            // 
            this.btnEşittir.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEşittir.FlatAppearance.BorderSize = 0;
            this.btnEşittir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEşittir.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEşittir.Location = new System.Drawing.Point(245, 419);
            this.btnEşittir.Name = "btnEşittir";
            this.btnEşittir.Size = new System.Drawing.Size(75, 45);
            this.btnEşittir.TabIndex = 0;
            this.btnEşittir.Text = "=";
            this.btnEşittir.UseVisualStyleBackColor = false;
            this.btnEşittir.Click += new System.EventHandler(this.eşittir_Click);
            this.btnEşittir.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
            this.btnEşittir.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
            // 
            // nokta
            // 
            this.nokta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nokta.FlatAppearance.BorderSize = 0;
            this.nokta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nokta.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nokta.Location = new System.Drawing.Point(164, 419);
            this.nokta.Name = "nokta";
            this.nokta.Size = new System.Drawing.Size(75, 45);
            this.nokta.TabIndex = 1;
            this.nokta.Text = ",";
            this.nokta.UseVisualStyleBackColor = false;
            this.nokta.Click += new System.EventHandler(this.nokta_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.Location = new System.Drawing.Point(83, 419);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 45);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.number_Click);
            // 
            // btnArtıEksi
            // 
            this.btnArtıEksi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnArtıEksi.FlatAppearance.BorderSize = 0;
            this.btnArtıEksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtıEksi.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnArtıEksi.Location = new System.Drawing.Point(2, 419);
            this.btnArtıEksi.Name = "btnArtıEksi";
            this.btnArtıEksi.Size = new System.Drawing.Size(75, 45);
            this.btnArtıEksi.TabIndex = 3;
            this.btnArtıEksi.Text = "±";
            this.btnArtıEksi.UseVisualStyleBackColor = false;
            this.btnArtıEksi.Click += new System.EventHandler(this.plusMin_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTopla.FlatAppearance.BorderSize = 0;
            this.btnTopla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopla.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTopla.Location = new System.Drawing.Point(245, 368);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 45);
            this.btnTopla.TabIndex = 4;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = false;
            this.btnTopla.Click += new System.EventHandler(this.plus_Click);
            this.btnTopla.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
            this.btnTopla.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
            // 
            // btnÇıkar
            // 
            this.btnÇıkar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnÇıkar.FlatAppearance.BorderSize = 0;
            this.btnÇıkar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÇıkar.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnÇıkar.Location = new System.Drawing.Point(245, 317);
            this.btnÇıkar.Name = "btnÇıkar";
            this.btnÇıkar.Size = new System.Drawing.Size(75, 45);
            this.btnÇıkar.TabIndex = 5;
            this.btnÇıkar.Text = "-";
            this.btnÇıkar.UseVisualStyleBackColor = false;
            this.btnÇıkar.Click += new System.EventHandler(this.minus_Click);
            this.btnÇıkar.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
            this.btnÇıkar.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
            // 
            // btnÇarp
            // 
            this.btnÇarp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnÇarp.FlatAppearance.BorderSize = 0;
            this.btnÇarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÇarp.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnÇarp.Location = new System.Drawing.Point(245, 266);
            this.btnÇarp.Name = "btnÇarp";
            this.btnÇarp.Size = new System.Drawing.Size(75, 45);
            this.btnÇarp.TabIndex = 6;
            this.btnÇarp.Text = "×";
            this.btnÇarp.UseVisualStyleBackColor = false;
            this.btnÇarp.Click += new System.EventHandler(this.mult_Click);
            this.btnÇarp.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
            this.btnÇarp.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
            // 
            // btnBöl
            // 
            this.btnBöl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnBöl.FlatAppearance.BorderSize = 0;
            this.btnBöl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBöl.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBöl.Location = new System.Drawing.Point(245, 215);
            this.btnBöl.Name = "btnBöl";
            this.btnBöl.Size = new System.Drawing.Size(75, 45);
            this.btnBöl.TabIndex = 7;
            this.btnBöl.Text = "÷";
            this.btnBöl.UseVisualStyleBackColor = false;
            this.btnBöl.Click += new System.EventHandler(this.div_Click);
            this.btnBöl.MouseEnter += new System.EventHandler(this.equals_MouseEnter);
            this.btnBöl.MouseLeave += new System.EventHandler(this.equals_MouseLeave);
            // 
            // btnTemizleE
            // 
            this.btnTemizleE.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTemizleE.FlatAppearance.BorderSize = 0;
            this.btnTemizleE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizleE.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnTemizleE.Location = new System.Drawing.Point(2, 215);
            this.btnTemizleE.Name = "btnTemizleE";
            this.btnTemizleE.Size = new System.Drawing.Size(75, 45);
            this.btnTemizleE.TabIndex = 12;
            this.btnTemizleE.Text = "CE";
            this.btnTemizleE.UseVisualStyleBackColor = false;
            this.btnTemizleE.Click += new System.EventHandler(this.clearE_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnTemizle.Location = new System.Drawing.Point(83, 215);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 45);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "C";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.clear_Click);
            // 
            // btnSilson
            // 
            this.btnSilson.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSilson.FlatAppearance.BorderSize = 0;
            this.btnSilson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSilson.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSilson.Location = new System.Drawing.Point(164, 215);
            this.btnSilson.Name = "btnSilson";
            this.btnSilson.Size = new System.Drawing.Size(75, 45);
            this.btnSilson.TabIndex = 14;
            this.btnSilson.Text = "←";
            this.btnSilson.UseVisualStyleBackColor = false;
            this.btnSilson.Click += new System.EventHandler(this.clearLast_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(2, 368);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 45);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.number_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(83, 368);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 45);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.number_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(164, 368);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 45);
            this.btn3.TabIndex = 17;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.number_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(2, 317);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 45);
            this.btn4.TabIndex = 18;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.number_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.Location = new System.Drawing.Point(83, 317);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 45);
            this.btn5.TabIndex = 19;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.number_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.Location = new System.Drawing.Point(164, 317);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 45);
            this.btn6.TabIndex = 20;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.number_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.Location = new System.Drawing.Point(2, 266);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 45);
            this.btn7.TabIndex = 21;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.number_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.Location = new System.Drawing.Point(83, 266);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 45);
            this.btn8.TabIndex = 22;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.number_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.Location = new System.Drawing.Point(164, 266);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 45);
            this.btn9.TabIndex = 23;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.number_Click);
            // 
            // sonuç
            // 
            this.sonuç.BackColor = System.Drawing.SystemColors.Control;
            this.sonuç.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sonuç.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonuç.ForeColor = System.Drawing.Color.DarkGreen;
            this.sonuç.Location = new System.Drawing.Point(299, 16);
            this.sonuç.Multiline = true;
            this.sonuç.Name = "sonuç";
            this.sonuç.Size = new System.Drawing.Size(318, 66);
            this.sonuç.TabIndex = 24;
            this.sonuç.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sonuç.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // lastString
            // 
            this.lastString.AutoSize = true;
            this.lastString.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastString.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lastString.Location = new System.Drawing.Point(264, 77);
            this.lastString.Name = "lastString";
            this.lastString.Size = new System.Drawing.Size(0, 20);
            this.lastString.TabIndex = 31;
            this.lastString.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // memoryPanel
            // 
            this.memoryPanel.BackColor = System.Drawing.SystemColors.Window;
            this.memoryPanel.Controls.Add(this.trash);
            this.memoryPanel.Controls.Add(this.memoryData);
            this.memoryPanel.Location = new System.Drawing.Point(12, 150);
            this.memoryPanel.Name = "memoryPanel";
            this.memoryPanel.Size = new System.Drawing.Size(340, 314);
            this.memoryPanel.TabIndex = 35;
            this.memoryPanel.Visible = false;
            // 
            // trash
            // 
            this.trash.BackColor = System.Drawing.SystemColors.Window;
            this.trash.BackgroundImage = global::Calculator.Properties.Resources.trash;
            this.trash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.trash.FlatAppearance.BorderSize = 0;
            this.trash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trash.Location = new System.Drawing.Point(284, 257);
            this.trash.Name = "trash";
            this.trash.Size = new System.Drawing.Size(35, 35);
            this.trash.TabIndex = 34;
            this.trash.UseVisualStyleBackColor = false;
            this.trash.Visible = false;
            this.trash.Click += new System.EventHandler(this.trash_Click);
            // 
            // memoryData
            // 
            this.memoryData.BackColor = System.Drawing.SystemColors.Window;
            this.memoryData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memoryData.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryData.Location = new System.Drawing.Point(20, 31);
            this.memoryData.Multiline = true;
            this.memoryData.Name = "memoryData";
            this.memoryData.Size = new System.Drawing.Size(299, 42);
            this.memoryData.TabIndex = 25;
            this.memoryData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // historyPanel
            // 
            this.historyPanel.BackColor = System.Drawing.SystemColors.Window;
            this.historyPanel.Controls.Add(this.historyData);
            this.historyPanel.Location = new System.Drawing.Point(12, 150);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(334, 314);
            this.historyPanel.TabIndex = 36;
            this.historyPanel.Visible = false;
            // 
            // historyData
            // 
            this.historyData.BackColor = System.Drawing.SystemColors.Window;
            this.historyData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyData.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyData.Location = new System.Drawing.Point(16, 15);
            this.historyData.Multiline = true;
            this.historyData.Name = "historyData";
            this.historyData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historyData.Size = new System.Drawing.Size(299, 248);
            this.historyData.TabIndex = 35;
            this.historyData.Text = "\r\n";
            this.historyData.Visible = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(2, 95);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(28, 40);
            this.pictureBox11.TabIndex = 46;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(54, 95);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(28, 40);
            this.pictureBox9.TabIndex = 45;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(28, 95);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(28, 40);
            this.pictureBox10.TabIndex = 44;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(158, 95);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 40);
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(132, 95);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 40);
            this.pictureBox6.TabIndex = 42;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(106, 95);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 40);
            this.pictureBox7.TabIndex = 41;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(80, 95);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 40);
            this.pictureBox8.TabIndex = 40;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(210, 95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 40);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(184, 95);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 40);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(236, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 40);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Calculator.Properties.Resources.hK;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(262, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 40);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(323, 468);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.memoryPanel);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lastString);
            this.Controls.Add(this.sonuç);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSilson);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnTemizleE);
            this.Controls.Add(this.btnBöl);
            this.Controls.Add(this.btnÇarp);
            this.Controls.Add(this.btnÇıkar);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.btnArtıEksi);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.nokta);
            this.Controls.Add(this.btnEşittir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(339, 507);
            this.MinimumSize = new System.Drawing.Size(339, 507);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "210408009";
            this.memoryPanel.ResumeLayout(false);
            this.memoryPanel.PerformLayout();
            this.historyPanel.ResumeLayout(false);
            this.historyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEşittir;
        private System.Windows.Forms.Button nokta;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnArtıEksi;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnÇıkar;
        private System.Windows.Forms.Button btnÇarp;
        private System.Windows.Forms.Button btnBöl;
        private System.Windows.Forms.Button btnTemizleE;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSilson;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.TextBox sonuç;
        private System.Windows.Forms.Label lastString;
        private System.Windows.Forms.Panel memoryPanel;
        private System.Windows.Forms.Button trash;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.TextBox historyData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.TextBox memoryData;
    }
}

