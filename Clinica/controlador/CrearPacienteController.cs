using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlador
{
    public class CrearPacienteController
    {
        private GestorFichero gf;
        Paciente pacienteCreado;
        public CrearPacienteController()
        {
            gf = new GestorFichero("pacientes.txt");
            PacienteCreado = null;
        }

        public Paciente PacienteCreado { get => pacienteCreado; set => pacienteCreado = value; }

        public bool comprobarExistenciaDNI(string dni)
        {
            PacienteDAO pacienteDAO = new PacienteDAO (gf);
            return pacienteDAO.obtenerDNY(dni);
        }
        public bool crearPaciente(string nombre, string apellidos, string direccion, string poblacion, string dni, int nhc)
        {
            PacienteDAO pacienteDao = new PacienteDAO(gf);
            
            PacienteCreado = new Paciente( nombre, apellidos, direccion, poblacion, dni, nhc);
            if (PacienteCreado.comprobar())
            {
                pacienteDao.Save(pacienteCreado);
                return true;
            }
            return false;


        }

        public Boolean actualizarPaciente(String fechaNacimiento,
                Boolean male, String profecion, String email, String tlfPrincipal,
                List<String> tlf, String alergias, String enfermedades,
                String grupoSanguineo, String entidadSanitaria,
                int numeroAsegurado)
        {
            try
            {
                pacienteCreado.FechaNacimiento = Convert.ToDateTime(fechaNacimiento).Millisecond;
                pacienteCreado.Male = male;
                pacienteCreado.Profecion = profecion;
                pacienteCreado.Email = email;
                pacienteCreado.Tlf = tlfPrincipal;
                pacienteCreado.OtrosTlf = tlf;
                pacienteCreado.Alergias = alergias;
                pacienteCreado.Enfermedades = enfermedades;
                pacienteCreado.GrupoSanguineo = GruposSanguineos.convertFromComboBox(grupoSanguineo);
                pacienteCreado.EntidadSanitaria = entidadSanitaria;
                pacienteCreado.NumAsegurado = numeroAsegurado;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
