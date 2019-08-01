using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker {

    internal sealed partial class Degradado : Form {

        public Degradado() => InitializeComponent();

        private void BtnDegradado_Click(object sender, EventArgs e) {
            try {

                if (string.IsNullOrWhiteSpace(TbColorInicial.Text)) {
                    MessageBox.Show(@"Ingrese color Inicial");

                    return;
                }

                if (string.IsNullOrWhiteSpace(TbColorFinal.Text)) {
                    MessageBox.Show(@"Ingrese color Final");

                    return;
                }

                if (int.Parse($"{NumCantidadColores.Value}") < 0) {
                    MessageBox.Show(@"Ingrese una cantidad mayor a 0");

                    return;
                }

                string txtInicial = TbColorInicial.Text.Replace("#", "").Trim();
                string txtFinal = TbColorFinal.Text.Replace("#", "").Trim();

                bool alfaCi = (txtInicial.Length >= 8) || (txtInicial.Length == 4) ;
                bool alfaCf = (txtFinal.Length >= 8) || (txtFinal.Length == 4);

                Color cinicial = TbColorInicial.Text.HexaColor(alfaCi);
                Color cfinal   = TbColorFinal.Text.HexaColor(alfaCf);
                int   cantidad = int.Parse($"{NumCantidadColores.Value}") + 2;

                IEnumerable<Color> degradado = Funciones.Degradado(cinicial, cfinal, cantidad);

                LvColores.Items.Clear();

                foreach (ListViewItem colorLista in degradado.Select(color => $"{color.R},{color.G},{color.B},{color.A}").Select(colorTexto => new ListViewItem(colorTexto))) {
                    colorLista.SubItems.Add("");
                    colorLista.UseItemStyleForSubItems = false;
                    LvColores.Items.Add(colorLista);
                }

                LvColores.ColoresListView();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnAgregar_Click(object sender, EventArgs e) {
            try {
                if (Owner == null) { return; }

                var listViewColores = (Owner as Principal).Controls["LisVieColores"] as ListView;

                foreach (ListViewItem item in LvColores.SelectedItems) {

                    var colorLista = new ListViewItem(item.Text);
                    colorLista.SubItems.Add("");
                    colorLista.UseItemStyleForSubItems = false;
                    listViewColores.Items.Add(colorLista);

                }

                listViewColores.ColoresListView();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void TbColorInicial_DoubleClick(object sender, EventArgs e) {
            if (Owner == null) { return; }

            var listViewColores = (Owner as Principal).Controls["LisVieColores"] as ListView;

            if (listViewColores.SelectedItems.Count == 0) return;

            string colorRgb = listViewColores.SelectedItems[0].Text;
            TbColorInicial.Text = colorRgb.RgbAHex();
        }

        private void TbColorFinal_DoubleClick(object sender, EventArgs e) {
            if (Owner == null) { return; }

            var listViewColores = (Owner as Principal).Controls["LisVieColores"] as ListView;

            if (listViewColores.SelectedItems.Count == 0) return;

            string colorRgb = listViewColores.SelectedItems[0].Text;
            TbColorFinal.Text = colorRgb.RgbAHex();
        }

    }

}