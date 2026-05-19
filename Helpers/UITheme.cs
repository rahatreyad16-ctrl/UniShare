using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace UniShare.Helpers
{
    public static class UITheme
    {
        public static Color DarkBackground = Color.FromArgb(18, 24, 32);
        public static Color PanelColor = Color.FromArgb(28, 35, 45);
        public static Color AccentGreen = Color.FromArgb(0, 200, 120);
        public static Color AccentBlue = Color.FromArgb(0, 140, 255);
        public static Color TextWhite = Color.White;
        public static Color TextMuted = Color.FromArgb(180, 190, 200);

        public static void StyleForm(Form form)
        {
            form.BackColor = DarkBackground;
            form.Font = new Font("Segoe UI", 10);
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        public static void StyleButton(Button btn)
        {
            btn.BackColor = AccentGreen;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Height = 42;
            btn.Cursor = Cursors.Hand;
        }

        public static void StylePanel(Panel panel)
        {
            panel.BackColor = PanelColor;
            panel.Padding = new Padding(15);
        }

        public static void StyleGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = PanelColor;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 45, 60);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(25, 32, 42);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = AccentGreen;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
