using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            this.Text = $"Compu de {Environment.UserName}";
            this.ConfigurarLogoSistemaOperativo();
            this.lblSistemaOperativo.Text = $"Sistema operativo: {Environment.OSVersion}";
            this.lblNombreMaquina.Text = $"{Environment.MachineName}";
            this.ConfigurarArquitectura();
            this.lblCantProcesadores.Text = $"Cant. procesadores: {Environment.ProcessorCount} procesadores lógicos";
            this.lblDirectorioActual.Text = $"Identificación ejecutada en: {Environment.NewLine}{Environment.CurrentDirectory}";
            this.ConfigurarEspacioTotalYDisponible();

        }

        private void ConfigurarLogoSistemaOperativo() 
        {
            bool MacOs = OperatingSystem.IsMacOS();
            bool windows = OperatingSystem.IsWindows();
            bool linux = OperatingSystem.IsLinux();

            if (MacOs)
            {
                picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
            else if (windows)
            {
                picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
            else if (linux)
            {
                picboxSistemaOperativo.Image = Properties.Resources.linux;
            }

        }

        private void ConfigurarArquitectura() 
        {
            bool es64Bits = Environment.Is64BitOperatingSystem;

            if (Environment.Is64BitOperatingSystem)
            {
                lblArquitectura.Text = "Arquitectura: 64 bits";
            }
            else
            {
                lblArquitectura.Text = "Arquitectura: 32 bits";
            }
        }

        private void ConfigurarEspacioTotalYDisponible()
        {
            long espacioTotalBytes = 0;
            long espacioDisponibleBytes = 0;

            // Recorre todas las unidades montadas
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                // Solo considera unidades que están listas
                if (drive.IsReady)
                {
                    espacioTotalBytes += drive.TotalSize;
                    espacioDisponibleBytes += drive.AvailableFreeSpace;
                }
            }

            // Convierte de bytes a gigabytes (1 GB = 1024 * 1024 * 1024 bytes)
            long espacioTotalGB = espacioTotalBytes / (1024 * 1024 * 1024);
            long espacioDisponibleGB = espacioDisponibleBytes / (1024 * 1024 * 1024);

            // Asigna a los labels
            lblEspacioTotal.Text = $"Espacio total: {espacioTotalGB} Gigabytes";
            lblEspacioDisponible.Text = $"Espacio disponible: {espacioDisponibleGB} Gigabytes";
        }
    }
}
