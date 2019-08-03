using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker {

    internal static class Funciones {

        // Convert an RGB value into an HLS value.
        public static void RgbToHls(int r, int g, int b, out double h, out double l, out double s) {
            // Convert RGB to a 0.0 to 1.0 range.
            double doubleR = r / 255.0;
            double doubleG = g / 255.0;
            double doubleB = b / 255.0;

            // Get the maximum and minimum RGB components.
            double max             = doubleR;
            if (max < doubleG) max = doubleG;
            if (max < doubleB) max = doubleB;

            double min             = doubleR;
            if (min > doubleG) min = doubleG;
            if (min > doubleB) min = doubleB;

            double diff = max - min;
            l = (max + min) / 2;

            if (Math.Abs(diff) < 0.00001) {
                s = 0;
                h = 0; // H is really undefined.
            }
            else {
                if (l <= 0.5) { s = diff / (max + min); }
                else { s          = diff / (2 - max - min); }

                double rDist = (max - doubleR) / diff;
                double gDist = (max - doubleG) / diff;
                double bDist = (max - doubleB) / diff;

                if (doubleR == max) { h      = bDist - gDist; }
                else if (doubleG == max) { h = (2 + rDist) - bDist; }
                else { h                     = (4 + gDist) - rDist; }

                h = h * 60;
                if (h < 0) h += 360;
            }
        }

        // Convert an HLS value into an RGB value.
        public static void HlsToRgb(double h, double l, double s, out int r, out int g, out int b) {
            double p2;

            if (l <= 0.5) { p2 = l * (1 + s); }
            else { p2          = (l + s) - (l * s); }

            double p1 = (2 * l) - p2;
            double doubleR, doubleG, doubleB;

            if (s == 0) {
                doubleR = l;
                doubleG = l;
                doubleB = l;
            }
            else {
                doubleR = QqhToRgb(p1, p2, h + 120);
                doubleG = QqhToRgb(p1, p2, h);
                doubleB = QqhToRgb(p1, p2, h - 120);
            }

            // Convert RGB to the 0 to 255 range.
            r = (int) (doubleR * 255.0);
            g = (int) (doubleG * 255.0);
            b = (int) (doubleB * 255.0);
        }

        private static double QqhToRgb(double q1, double q2, double hue) {
            if (hue > 360) { hue -= 360; }
            else if (hue < 0) hue += 360;

            if (hue < 60) return q1 + (((q2 - q1) * hue) / 60);
            if (hue < 180) return q2;
            if (hue < 240) return q1 + (((q2 - q1) * (240 - hue)) / 60);

            return q1;
        }

        public static Color TextoArgba(int a = 255, int r = 0, int g = 0, int b = 0) => Color.FromArgb(a, r, g, b);

        public static string ColorATexto(this Color color, bool alfa = false) {
            var colorHex = "";

            colorHex += $"{color.R:X2}{color.G:X2}{color.B:X2}";

            if (alfa) colorHex += $"{color.A:X2}";

            return colorHex;
        }

        public static Color HexaColor(this string hex, bool alfa) {

            try {

                string colorhex = alfa ? hex : $"{hex}FF";

                colorhex = colorhex.Replace("#", "");

                int a;
                int r;
                int g;
                int b;

                Color color;

                string rs;

                string gs;

                string bs;

                switch (colorhex.Length) {

                    case 4:

                        rs = colorhex.Substring(0, 1);
                        r  = int.Parse($"{rs}{rs}", NumberStyles.AllowHexSpecifier);
                        gs = colorhex.Substring(1, 1);
                        g  = int.Parse($"{gs}{gs}", NumberStyles.AllowHexSpecifier);
                        bs = colorhex.Substring(2, 1);
                        b  = int.Parse($"{bs}{bs}", NumberStyles.AllowHexSpecifier);
                        string astr = colorhex.Substring(3, 1);
                        a = int.Parse($"{astr}{astr}", NumberStyles.AllowHexSpecifier);

                        color = Color.FromArgb(a, r, g, b);

                        break;

                    case 5:

                        rs = colorhex.Substring(0, 1);
                        r  = int.Parse($"{rs}{rs}", NumberStyles.AllowHexSpecifier);
                        gs = colorhex.Substring(1, 1);
                        g  = int.Parse($"{gs}{gs}", NumberStyles.AllowHexSpecifier);
                        bs = colorhex.Substring(2, 1);
                        b  = int.Parse($"{bs}{bs}", NumberStyles.AllowHexSpecifier);
                        a  = int.Parse(colorhex.Substring(3, 2), NumberStyles.AllowHexSpecifier);

                        color = Color.FromArgb(a, r, g, b);

                        break;

                    case 8:

                        r = int.Parse(colorhex.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                        g = int.Parse(colorhex.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                        b = int.Parse(colorhex.Substring(4, 2), NumberStyles.AllowHexSpecifier);
                        a = int.Parse(colorhex.Substring(6, 2), NumberStyles.AllowHexSpecifier);

                        color = Color.FromArgb(a, r, g, b);

                        break;

                    default:
                        color = Color.Black;

                        break;
                }

                return color;
            }
            catch (Exception ex) {
                // MessageBox.Show(@"No se encontró un color valido");

                var test = ex.Message;

                return Color.Black;
            }
        }

        public static void ColoresListView(this ListView lv) {
            foreach (ListViewItem item in lv.Items) {
                string[] cT = item.SubItems[1].Text.Split(',');
                int      r  = int.Parse($"{cT[0]}");
                int      g  = int.Parse($"{cT[1]}");
                int      b  = int.Parse($"{cT[2]}");
                int      a  = int.Parse($"{cT[3]}");

                item.SubItems[0].BackColor = TextoArgba(a, r, g, b);

                //r = 255 - r;
                //g = 255 - g;
                //b = 255 - b;

                //item.ForeColor = Funciones.TextoArgba(a, r, g, b);

            }
        }

        public static IEnumerable<Color> Degradado(Color inicio, Color fin, int cantidad) {
            int stepA = ((fin.A - inicio.A) / (cantidad - 1));
            int stepR = ((fin.R - inicio.R) / (cantidad - 1));
            int stepG = ((fin.G - inicio.G) / (cantidad - 1));
            int stepB = ((fin.B - inicio.B) / (cantidad - 1));

            for (var i = 0; i < cantidad; i++) { yield return Color.FromArgb(inicio.A + (stepA * i), inicio.R + (stepR * i), inicio.G + (stepG * i), inicio.B + (stepB * i)); }
        }

        public static string RgbAHex(this string rgb) {

            string[] cT = rgb.Split(',');
            int      r  = int.Parse($"{cT[0]}");
            int      g  = int.Parse($"{cT[1]}");
            int      b  = int.Parse($"{cT[2]}");
            int      a  = int.Parse($"{cT[3]}");

            Color color = TextoArgba(a, r, g, b);

            string hex = color.ColorATexto(true);

            return hex;
        }

    }

}