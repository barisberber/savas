using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Savas.Library.Concrete;

namespace Savas.Desktop
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun;

        public AnaForm()
        {
            InitializeComponent();

            _oyun = new Oyun(ucakSavarPanel, savasAlaniPanel);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.UcaksavariHareketEttir(Library.Enum.Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.UcaksavariHareketEttir(Library.Enum.Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;
            }
        }

        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
            sureLabel.Text = _oyun.GecenSure.ToString(@"m\:ss");
        }
    }
}
