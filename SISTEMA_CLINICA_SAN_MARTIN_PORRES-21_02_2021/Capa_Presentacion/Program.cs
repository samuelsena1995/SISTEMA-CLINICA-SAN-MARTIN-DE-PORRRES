using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Net;
namespace Capa_Presentacion
{
   public static class Program
    {
        /// <summary>
        public static string PASSWORD_DESENCRIPTAR;
        /// </summary>     
        public static DataTable Datos;
        public static string Nombre_Cargo;
        public static string Nombre_Usuario;
        public static string Nombre_Trabajador;
        public static string CONTRASEÑA_USUARIO;
        public static int Id_Usuario;
        public static int Id_Rol;
        public static string ID_PERMISO;
        public static string ID_USUARIO;
        public static int Menu_Principal;

        public static string ID_USUARIO_2;
        /// <summary>
        public static string IP_PC() {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork") {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }
        /// </summary>

        #region Variables
        public static bool Seleccionar_Sala = false;
        public static bool Seleccionar_Paciente = false;
        public static bool sekleccionar_evolucionmedica = false;

        public static bool isnuevo = false;
        public static bool ismodificar = false;
        public static bool Cambio_Estado = false;
        public static bool Consultar = false;
        public static bool Eliminar = false;
        public static bool AsignacionPermiso = false;
        public static bool SeleccionarTiposSala = false;
        public static int Tiene_Ficha_paciente = 0;
        public static int Tiene_Funcionnes = 0;
        public static int Tiene_Medico = 0;
        public static int Tiene_Tiposala = 0;
        public static int Tiene_Sala = 0;
        public static int Tiene_Usuario = 0;

        public static string Tiene_Ficha_paciente1 = "";
        public static string Tiene_Funcionnes1 = "";
        public static string Tiene_Medico1 = "";
        public static string Tiene_Tiposala1 = "";
        public static string Tiene_Sala1 = "";
        public static string Tiene_Usuario1 = "";

        //  public static string[] REGLAS_USUARIO { get; set; }
        // public static string[] REGLAS_USUARIO_GLOBAL { get; set; }
        #endregion
        #region funcionario
        public static bool isnuevo_funcionario = false;
        public static bool ismodificar_funcionario = false;
        public static bool Cambio_Estado_funcionario = false;
        public static bool Consultar_funcionario = false;
        public static bool Eliminar_funcionario = false;
        #endregion
        #region Medico
        public static bool isnuevo_medico = false;
        public static bool ismodificar_medico = false;
        public static bool Cambio_Estado_medico = false;
        public static bool Consultar_medico = false;
        public static bool Eliminar_medico = false;
        #endregion
        #region TipoSala
        public static bool isnuevo_TipoSala = false;
        public static bool ismodificar_TipoSala = false;
        public static bool Cambio_Estado_TipoSala = false;
        public static bool Consultar_TipoSala = false;
        public static bool Eliminar_TipoSala = false;
        #endregion
        #region Sala
        public static bool isnuevo_Sala = false;
        public static bool ismodificar_Sala = false;
        public static bool Cambio_Estado_Sala = false;
        public static bool Consultar_Sala = false;
        public static bool Eliminar_Sala = false;
        #endregion
        #region Paciente
        public static bool isnuevo_paciente = false;
        public static bool ismodificar_paciente = false;
        public static bool Cambio_Estado_paciente = false;
        public static bool Consultar_paciente = false;
        public static bool Eliminar_paciente = false;
        #endregion

        #region internacion
        public static bool isnuevo_internacion = false;
        public static bool ismodificar_internacion = false;
        public static bool Cambio_Estado_internacion = false;
        public static bool Consultar_internacion = false;
        public static bool Eliminar_internacion = false;
        #endregion
        #region usuario
        public static bool isnuevo_usuario = false;
        public static bool ismodificar_usuario = false;
        public static bool Cambio_Estado_usuario = false;
        public static bool Consultar_usuario = false;
        public static bool Eliminar_usuario = false;
        #endregion
        #region ASIGNACION_SALA
        public static bool isnuevo_ASIGNACION_SALA = false;
        public static bool ismodificar_ASIGNACION_SALA = false;
        public static bool Cambio_Estado_ASIGNACION_SALA = false;
        public static bool Consultar_ASIGNACION_SALA = false;
        public static bool Eliminar_ASIGNACION_SALA = false;
        #endregion

        #region Evolucion_medica
        public static bool isnuevo_evolucion = false;
        public static bool ismodificar_evolucion = false;
        public static bool Cambio_Estado_evolucion = false;
        public static bool Consultar_evolucion = false;
        public static bool Eliminar_evolucion = false;
        #endregion
        #region EstudioLaboratorio
        public static bool isnuevo_EstudioLaboratorio = false;
        public static bool ismodificar_EstudioLaboratorio = false;
        public static bool Cambio_Estado_EstudioLaboratorio = false;
        public static bool Consultar_EstudioLaboratorio = false;
        public static bool Eliminar_EstudioLaboratorio = false;
        public static bool Anular_EstudioLaboratorio = false;
        #endregion
        public static int[] resultado_funcion = new int[40];
        public static string[] resultado_funcion_permisos = new string[2000];
        public static string[] HOLA = new string[2000];
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_INICIO_SESION());
        }
    }
}
