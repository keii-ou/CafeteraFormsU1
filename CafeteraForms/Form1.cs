namespace CafeteraForms
{
    public partial class Form1 : Form
    {
        public Cafetera miCafetera = new Cafetera(5);
        public Form1()
        {
            InitializeComponent();
            ActualizarIntefaz();
        }

        public void btnEncender_Click(object sender, EventArgs e)
        {
            miCafetera.AlternarEncendido();
            ActualizarIntefaz();
        }

        private void btnServir_Click(object sender, EventArgs e)
        {
            if (miCafetera.Encendida && miCafetera.CantidadCafe > 0)
            {
                miCafetera.Servir();
                MessageBox.Show("Café servido. Disfruta tú café!", "Éxito.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarInterfaz();

            }
            else
            {
                MessageBox.Show("No hay café para servir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ActualizarInterfaz()
        {
            lblEstado.Text = miCafetera.Encendida ? "Estado: ENCENDIDA" : "Esado: APAGADA";
            lblCantidad.Text = $"Cantidad de café: {miCafetera.CantidadCafe} tazas";
            lblEstado.ForeColor = miCafetera.Encendida ? Color.Green : Color.Red;
            progressCafe.Maximum = miCafetera.CapacidadMax;
            progressCafe.Value = miCafetera.CantidadCafe;
            btnServir.Enabled = miCafetera.Encendida;
            btnRellenar.Enabled = miCafetera.Encendida;
        }

        private void btnRellenar_Click(object sebder, EventArgs e)
        {
            miCafetera.Rellenar();
            MessageBox.Show("Cafetera llena! puede volver a servir");
            ActualizarIntefaz();
        }

        private void ActualizarIntefaz()
        {
            lblEstado.Text = miCafetera.Encendida ? "Estado: ENCENDIDA" : "Esado: APAGADA";
            lblCantidad.Text = $"Cantidad de café: {miCafetera.CantidadCafe} tazas";
            lblEstado.ForeColor = miCafetera.Encendida ? Color.Green : Color.Red;
            progressCafe.Maximum = miCafetera.CapacidadMax;
            progressCafe.Value = miCafetera.CantidadCafe;
            btnServir.Enabled = miCafetera.Encendida;
            btnRellenar.Enabled = miCafetera.Encendida;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void progressCafe_Click(object sender, EventArgs e)
        {

        }
    }
}
