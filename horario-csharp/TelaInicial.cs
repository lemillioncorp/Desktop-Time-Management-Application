using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace horario_csharp
{
    public partial class TelaInicial : MetroFramework.Forms.MetroForm
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //Botão Abrir Menu
        private void FotoMenu_Click(object sender, EventArgs e)
        {
            NaoMostarMenu();

        }

        //Botão fechar Menu
        private void FotoMenuFechar_Click(object sender, EventArgs e)
        {
            MostarMenu();

            fotoMenu.Visible = true;
           
        }

        private void FotoMenu_MouseHover(object sender, EventArgs e)
        {
            NaoMostarMenu();

        }

        private void TelaInicial_MouseHover(object sender, EventArgs e)
        {
            MostarMenu();

        }

        private void FotoModoLight_Click(object sender, EventArgs e)
        {
            fotoMenuModoLight.Visible = true;
	    this.fotoMenuModoLight.Location = new System.Drawing.Point(10, 46);
            fotoMenu.Visible = false;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.painelMenu.Theme = MetroFramework.MetroThemeStyle.Light;
            this.panelIconesMenu.Theme = MetroFramework.MetroThemeStyle.Light;

        }

        private void FotoModoDark_Click(object sender, EventArgs e)
        {
            fotoMenuModoLight.Visible = false;
            fotoMenu.Visible = true;

            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.painelMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelIconesMenu.Theme = MetroFramework.MetroThemeStyle.Dark;

        }

        private void TelaInicial_Click(object sender, EventArgs e)
        {
           //NaoMostarMenu();
        }
        private void TelaInicial_MouseLeave(object sender, EventArgs e)
        {
           // MostarMenu();

        }
        private void TelaInicial_Leave(object sender, EventArgs e)
        {
          
        }

        private void FotoMenu_MouseLeave(object sender, EventArgs e)
        {
            NaoMostarMenu();
        }


        //Não Mostar Menu
        private void NaoMostarMenu()
        {
            checkedMenu.Checked = true;
            if (checkedMenu.Checked == true)
            {
                painelMenu.Visible = true;
                this.painelMenu.HorizontalScrollbarBarColor = true;
                this.painelMenu.HorizontalScrollbarHighlightOnWheel = false;
                this.painelMenu.HorizontalScrollbarSize = 10;
                this.painelMenu.Location = new System.Drawing.Point(54, 46);
                this.painelMenu.Name = "painelMenu";
                this.painelMenu.Size = new System.Drawing.Size(210, 419);
                this.painelMenu.TabIndex = 6;
                this.painelMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
                this.painelMenu.VerticalScrollbarBarColor = true;
                this.painelMenu.VerticalScrollbarHighlightOnWheel = true;
                this.painelMenu.VerticalScrollbarSize = 50;

                this.panelIconesMenu.Size = new System.Drawing.Size(48, 414);
            }
        }

        //Mostar Menu
        private void MostarMenu()
        {
            checkedMenu.Checked = false;
            if (checkedMenu.Checked == false)
            {
                painelMenu.Visible = false;
            }
        }
    }
}




















