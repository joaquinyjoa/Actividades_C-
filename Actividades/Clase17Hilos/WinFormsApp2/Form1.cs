namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void AsignarHora(object sender, EventArgs e)
        {
            //PUNTO1
            //creo otro hilo
            //Task tarea = Task.Run(() => {
            //    while (true)
            //    {
            //        DateTime ahora = DateTime.Now;//intancio la fecha,hora y segundos
            //        this.Invoke(() =>//llavo al hilo principal para que cambie el label
            //        {
            //            this.lblHora.Text = ahora.ToString();
            //        });
            //        Thread.Sleep(1000); //espero un segundo
            //    }
            //});
            DateTime ahora = DateTime.Now;//intancio la fecha,hora y segundos
            //Task tarea = Task.Run(() =>
            //{
            //    while (true)
            //    {

            //        this.Invoke(() =>//llavo al hilo principal para que cambie el label
            //        {
            //            this.lblHora.Text = ahora.ToString();

            //        });
            //        Thread.Sleep(1000); //espero un segundo
            //                            // Sumo 1 segundo y 1 hora cada ciclo
            //        ahora = ahora.AddSeconds(1).AddHours(1);
            //    }
            //});
            ahora = ahora.AddSeconds(1).AddHours(1);
            lblHora.Text = ahora.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AsignarHora();
            this.timer1.Tick += AsignarHora;
            this.timer1.Interval = 1000;     // 1 segundo
            this.timer1.Start();
        }
    }
}
