using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    
    public class Paciente
    {

        private string dni;
        private string nombre;
        private string apellidos;
        private int nhc;
        private string direccion;
        private string poblacion;
        private string tlf;
        private List<String> otrosTlf;
        private bool male;
        private long fechaNacimiento;
        private string email;
        private string profecion;
        private string alergias;
        private GrupoSanguineo grupoSanguineo;
        private string enfermedades;
        private string entidadSanitaria;
        private int numAsegurado;

        public Paciente()
        {
        }

        /**
         * Constructor con datos obligatorios 
         */

        public Paciente( string nombre, string apellidos, string direccion, string poblacion, string dni, int nhc)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Nhc = nhc;
            this.Direccion = direccion;
            this.Poblacion = poblacion;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Nhc { get => nhc; set => nhc = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        public string Tlf { get => tlf; set => tlf = value; }
        public List<string> OtrosTlf { get => otrosTlf; set => otrosTlf = value; }
        public bool Male { get => male; set => male = value; }
        public long FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Email { get => email; set => email = value; }
        public string Profecion { get => profecion; set => profecion = value; }
        public string Alergias { get => alergias; set => alergias = value; }
        public GrupoSanguineo GrupoSanguineo { get => grupoSanguineo; set => grupoSanguineo = value; }
        public string Enfermedades { get => enfermedades; set => enfermedades = value; }
        public string EntidadSanitaria { get => entidadSanitaria; set => entidadSanitaria = value; }
        public int NumAsegurado { get => numAsegurado; set => numAsegurado = value; }

        public void setGrupoSanguineo(string valor)
        {
            grupoSanguineo = GruposSanguineos.convert(valor);
        }
        public bool comprobar()
        {
            if (comprobarDNI() && !String.IsNullOrWhiteSpace(nombre) && !String.IsNullOrWhiteSpace(apellidos) && !String.IsNullOrWhiteSpace(direccion) && !String.IsNullOrWhiteSpace(poblacion))
            {
                return true;
            }
            return false;
        }

        private bool comprobarDNI()
        {
            string dni_numeros = dni.Substring(0, dni.Length - 1);
            string dni_letra = dni.Substring(dni.Length - 1, 1);
            bool validar_numero = int.TryParse(dni_numeros, out int dni_int);
            if (!validar_numero)
            {
                return false;
            }
            if (calcularLetraDni(dni_int) != dni_letra)
            {
                return false;
            }
            return true;
        }


        private bool DNIRepetido()
        {

            string dni_numeros = dni.Substring(0, dni.Length - 1);
            string dni_letra = dni.Substring(dni.Length - 1, 1);
            bool validar_numero = int.TryParse(dni_numeros, out int dni_int);
            if (!validar_numero)
            {
                return false;
            }
            if (calcularLetraDni(dni_int) != dni_letra)
            {
                return false;
            }
            return true;
        }




        private static string calcularLetraDni(int dni_numero)
        {
            //Cargamos los digitos de control
            string[] letras = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dni_numero % 23;
            return letras[mod];
        }
    }
    public enum GrupoSanguineo
    {
        O_NEGATIVO,
        O_POSITIVO,
        A_POSITIVO,
        A_NEGATIVO,
        B_POSITIVO,
        B_NEGATIVO,
        AB_POSITIVO,
        AB_NEGATIVO,
        DESCONOCIDO
    }

    public class GruposSanguineos
    {
        public static GrupoSanguineo convert(string value)
        {
            switch (value)
            {
                case "0negativo":
                    return GrupoSanguineo.O_NEGATIVO;
                case "0positivo":
                    return GrupoSanguineo.O_POSITIVO;
                case "apositivo":
                    return GrupoSanguineo.A_POSITIVO;
                case "anegativo":
                    return GrupoSanguineo.A_NEGATIVO;
                case "bpositivo":
                    return GrupoSanguineo.B_POSITIVO;
                case "bnegativo":
                    return GrupoSanguineo.B_NEGATIVO;
                case "abpositivo":
                    return GrupoSanguineo.AB_POSITIVO;
                case "abnegativo":
                    return GrupoSanguineo.AB_NEGATIVO;
                default:
                    return GrupoSanguineo.DESCONOCIDO;
            }
        }


        public static GrupoSanguineo convertFromComboBox(string value)
        {
            switch (value)
            {
                case "0 Negativo":
                    return GrupoSanguineo.O_NEGATIVO;
                case "0 Positivo":
                    return GrupoSanguineo.O_POSITIVO;
                case "A Positivo":
                    return GrupoSanguineo.A_POSITIVO;
                case "A Negativo":
                    return GrupoSanguineo.A_NEGATIVO;
                case "B Positivo":
                    return GrupoSanguineo.B_POSITIVO;
                case "B Negativo":
                    return GrupoSanguineo.B_NEGATIVO;
                case "AB Positivo":
                    return GrupoSanguineo.AB_POSITIVO;
                case "AB Negativo":
                    return GrupoSanguineo.AB_NEGATIVO;
                default:
                    return GrupoSanguineo.DESCONOCIDO;
            }
        }
    }
}