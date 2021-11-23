
namespace ListakezeloForm {
  partial class formLista {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLista));
      this.lblNev = new System.Windows.Forms.Label();
      this.txtNev = new System.Windows.Forms.TextBox();
      this.btnHozzaad = new System.Windows.Forms.Button();
      this.btnBetu = new System.Windows.Forms.Button();
      this.btnHatter = new System.Windows.Forms.Button();
      this.btnSorbarendez = new System.Windows.Forms.Button();
      this.btnMinden = new System.Windows.Forms.Button();
      this.btnTorol = new System.Windows.Forms.Button();
      this.lstLista = new System.Windows.Forms.ListBox();
      this.btnKilepes = new System.Windows.Forms.Button();
      this.lblDarab = new System.Windows.Forms.Label();
      this.btnDarabszam = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblNev
      // 
      this.lblNev.BackColor = System.Drawing.Color.Transparent;
      this.lblNev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblNev.Location = new System.Drawing.Point(20, 20);
      this.lblNev.Name = "lblNev";
      this.lblNev.Size = new System.Drawing.Size(200, 50);
      this.lblNev.TabIndex = 0;
      this.lblNev.Text = "Írja be a felvivendő nevet!";
      this.lblNev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtNev
      // 
      this.txtNev.Location = new System.Drawing.Point(30, 70);
      this.txtNev.Name = "txtNev";
      this.txtNev.Size = new System.Drawing.Size(180, 27);
      this.txtNev.TabIndex = 1;
      this.txtNev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtNev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNev_KeyDown);
      // 
      // btnHozzaad
      // 
      this.btnHozzaad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnHozzaad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnHozzaad.Location = new System.Drawing.Point(355, 60);
      this.btnHozzaad.Name = "btnHozzaad";
      this.btnHozzaad.Size = new System.Drawing.Size(150, 40);
      this.btnHozzaad.TabIndex = 2;
      this.btnHozzaad.Text = "Hozzáad";
      this.btnHozzaad.UseVisualStyleBackColor = true;
      this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
      // 
      // btnBetu
      // 
      this.btnBetu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnBetu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnBetu.Location = new System.Drawing.Point(355, 300);
      this.btnBetu.Name = "btnBetu";
      this.btnBetu.Size = new System.Drawing.Size(150, 40);
      this.btnBetu.TabIndex = 3;
      this.btnBetu.Text = "Betűt színez";
      this.btnBetu.UseVisualStyleBackColor = true;
      this.btnBetu.Click += new System.EventHandler(this.btnBetu_Click);
      // 
      // btnHatter
      // 
      this.btnHatter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnHatter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnHatter.Location = new System.Drawing.Point(355, 240);
      this.btnHatter.Name = "btnHatter";
      this.btnHatter.Size = new System.Drawing.Size(150, 40);
      this.btnHatter.TabIndex = 4;
      this.btnHatter.Text = "Hátteret színez";
      this.btnHatter.UseVisualStyleBackColor = true;
      this.btnHatter.Click += new System.EventHandler(this.btnHatter_Click);
      // 
      // btnSorbarendez
      // 
      this.btnSorbarendez.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnSorbarendez.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnSorbarendez.Location = new System.Drawing.Point(355, 360);
      this.btnSorbarendez.Name = "btnSorbarendez";
      this.btnSorbarendez.Size = new System.Drawing.Size(150, 40);
      this.btnSorbarendez.TabIndex = 5;
      this.btnSorbarendez.Text = "Sorbarendez";
      this.btnSorbarendez.UseVisualStyleBackColor = true;
      this.btnSorbarendez.Click += new System.EventHandler(this.btnSorbarendez_Click);
      // 
      // btnMinden
      // 
      this.btnMinden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnMinden.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnMinden.Location = new System.Drawing.Point(355, 180);
      this.btnMinden.Name = "btnMinden";
      this.btnMinden.Size = new System.Drawing.Size(150, 40);
      this.btnMinden.TabIndex = 6;
      this.btnMinden.Text = "Mindent töröl";
      this.btnMinden.UseVisualStyleBackColor = true;
      this.btnMinden.Click += new System.EventHandler(this.btnMinden_Click);
      // 
      // btnTorol
      // 
      this.btnTorol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnTorol.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnTorol.Location = new System.Drawing.Point(355, 120);
      this.btnTorol.Name = "btnTorol";
      this.btnTorol.Size = new System.Drawing.Size(150, 40);
      this.btnTorol.TabIndex = 7;
      this.btnTorol.Text = "Töröl";
      this.btnTorol.UseVisualStyleBackColor = true;
      this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
      // 
      // lstLista
      // 
      this.lstLista.FormattingEnabled = true;
      this.lstLista.ItemHeight = 20;
      this.lstLista.Location = new System.Drawing.Point(540, 60);
      this.lstLista.Name = "lstLista";
      this.lstLista.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.lstLista.Size = new System.Drawing.Size(240, 424);
      this.lstLista.TabIndex = 8;
      // 
      // btnKilepes
      // 
      this.btnKilepes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnKilepes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnKilepes.Location = new System.Drawing.Point(585, 498);
      this.btnKilepes.Name = "btnKilepes";
      this.btnKilepes.Size = new System.Drawing.Size(150, 40);
      this.btnKilepes.TabIndex = 9;
      this.btnKilepes.Text = "Kilépés";
      this.btnKilepes.UseVisualStyleBackColor = true;
      this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
      // 
      // lblDarab
      // 
      this.lblDarab.BackColor = System.Drawing.Color.Transparent;
      this.lblDarab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblDarab.Location = new System.Drawing.Point(20, 498);
      this.lblDarab.Name = "lblDarab";
      this.lblDarab.Size = new System.Drawing.Size(498, 40);
      this.lblDarab.TabIndex = 10;
      this.lblDarab.Text = "A listában az elemek száma: 0";
      this.lblDarab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnDarabszam
      // 
      this.btnDarabszam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnDarabszam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnDarabszam.Location = new System.Drawing.Point(355, 420);
      this.btnDarabszam.Name = "btnDarabszam";
      this.btnDarabszam.Size = new System.Drawing.Size(150, 40);
      this.btnDarabszam.TabIndex = 11;
      this.btnDarabszam.Text = "Darabszám";
      this.btnDarabszam.UseVisualStyleBackColor = true;
      this.btnDarabszam.Visible = false;
      this.btnDarabszam.Click += new System.EventHandler(this.btnDarabszam_Click);
      // 
      // formLista
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(800, 550);
      this.Controls.Add(this.btnDarabszam);
      this.Controls.Add(this.lblDarab);
      this.Controls.Add(this.btnKilepes);
      this.Controls.Add(this.lstLista);
      this.Controls.Add(this.btnTorol);
      this.Controls.Add(this.btnMinden);
      this.Controls.Add(this.btnSorbarendez);
      this.Controls.Add(this.btnHatter);
      this.Controls.Add(this.btnBetu);
      this.Controls.Add(this.btnHozzaad);
      this.Controls.Add(this.txtNev);
      this.Controls.Add(this.lblNev);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "formLista";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Listakezelő";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblNev;
    private System.Windows.Forms.TextBox txtNev;
    private System.Windows.Forms.Button btnHozzaad;
    private System.Windows.Forms.Button btnBetu;
    private System.Windows.Forms.Button btnHatter;
    private System.Windows.Forms.Button btnSorbarendez;
    private System.Windows.Forms.Button btnMinden;
    private System.Windows.Forms.Button btnTorol;
    private System.Windows.Forms.ListBox lstLista;
    private System.Windows.Forms.Button btnKilepes;
    private System.Windows.Forms.Label lblDarab;
    private System.Windows.Forms.Button btnDarabszam;
  }
}

