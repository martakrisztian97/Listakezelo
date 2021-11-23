using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListakezeloForm {
  public partial class formLista : Form {
    public formLista() {
      InitializeComponent();
    }

    private void btnKilepes_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void btnHozzaad_Click(object sender, EventArgs e) {
      txtNev.Text = txtNev.Text.Trim();
      if (lstLista.Items.Contains((txtNev.Text.ToLower()))) {
        MessageBox.Show("Ilyen elem már van a listában!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtNev.Focus();
      } else {
        if (txtNev.Text != "") {
          lstLista.Items.Add(txtNev.Text.ToLower());
          txtNev.Text = "";
          txtNev.Focus();
          btnDarabszam_Click(sender, e);
        } else {
          MessageBox.Show("Üres szöveget nem viszek fel!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void txtNev_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        btnHozzaad_Click(sender, e);
      }
    }

    private void btnDarabszam_Click(object sender, EventArgs e) {
      lblDarab.Text = "A listában az elemek száma: " + lstLista.Items.Count.ToString();
    }

    private void btnMinden_Click(object sender, EventArgs e) {
      DialogResult valasz;
      valasz = MessageBox.Show("Valóban törölni akar minden elemet?", "Törlés",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
      if (valasz == DialogResult.Yes) {
        lstLista.Items.Clear();
      }
    }
  }
}
