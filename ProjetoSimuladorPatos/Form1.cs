using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimuladorPatosForms
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Pato> patos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            patos = new Dictionary<string, Pato>
            {
                { "Pato Real", new PatoReal() },
                { "Pato de Borracha", new PatoDeBorracha() },
                { "Pato de Madeira", new PatoDeMadeira() },
                { "Pato Cabeça Vermelha", new PatoCabecaVermelha() },
                { "Pato Patolino",new PatoPatolino ()},
                { "Pato Azul", new PatoAzul()},
                { "Pato Tio Patinhas", new PatoTioPatinhas() }
            };

            comboPatos.Items.AddRange(new object[] {
                "Pato Real", "Pato de Borracha", "Pato de Madeira", "Pato Cabeça Vermelha","Pato Patolino","Pato Azul","Pato Tio Patinhas"
            });
            comboPatos.SelectedIndex = 0;
        }

        private void btnOuvirSom_Click(object sender, EventArgs e)
        {
            string selecionado = comboPatos.SelectedItem.ToString();
            if (patos.TryGetValue(selecionado, out Pato pato))
            {
                lblSom.Text = pato.FazerSom();
            }
        }
    }
}
