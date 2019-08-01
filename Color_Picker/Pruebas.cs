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

    internal sealed partial class Pruebas : Form {

        public Pruebas() => InitializeComponent();

        private void Button1_Click(object sender, EventArgs e) {
            try {
                Color cinicial = Funciones.HexaColor(textBox1.Text, false);
                Color cfinal   = Funciones.HexaColor(textBox2.Text, false);
                int   cantidad = int.Parse($"{numericUpDown1.Value}");

                IEnumerable<Color> degradado = Funciones.Degradado(cinicial, cfinal, cantidad);

                listView1.Items.Clear();

                foreach (ListViewItem colorLista in degradado.Select(color => $"{color.R},{color.G},{color.B},{color.A}").Select(colorTexto => new ListViewItem(colorTexto))) {
                    colorLista.SubItems.Add("");
                    colorLista.UseItemStyleForSubItems = false;
                    listView1.Items.Add(colorLista);
                }

                Funciones.ColoresListView(listView1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

    }

}