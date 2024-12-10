namespace Ahora_si
{
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
            // Asignar eventos MouseEnter y MouseLeave para todas las labels
            Label[] labels = { label1, label2, label4, label5, label6 };

            foreach (var labs in labels)
            {
                labs.MouseEnter += Label_MouseEnter_ChangeToGray;
                labs.MouseLeave += Label_MouseLeave_ChangeToBlack;

            }
            // Eventos especiales para label3
            label3.MouseEnter += Label3_MouseEnter_ChangeToGold;
            label3.MouseLeave += Label3_MouseLeave_ChangeToBlack;
        }


        // Métodos para cambiar el color de las etiquetas excepto label3
        private void Label_MouseEnter_ChangeToGray(object? sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.Gray; // Cambiar a color gris
        }

        private void Label_MouseLeave_ChangeToBlack(object? sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.Black; // Regresar a color negro
        }

        // Métodos especiales para label3
        private void Label3_MouseEnter_ChangeToGold(object? sender, EventArgs e)
        {
            label3.ForeColor = Color.Gold; // Cambiar a color dorado
        }

        private void Label3_MouseLeave_ChangeToBlack(object? sender, EventArgs e)
        {
            label3.ForeColor = Color.Black; // Regresar a color negro
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
