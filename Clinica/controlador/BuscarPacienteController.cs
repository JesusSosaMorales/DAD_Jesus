using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlador
{
    public class BuscarPacienteController
    {
        private GestorFichero gf;

        public BuscarPacienteController()
        {
            gf = new GestorFichero("pacientes.txt");
        }

        public List<Paciente> BuscarPacienteByNHC(String NHC)
        {
            PacienteDAO pacienteDao = new PacienteDAO(gf);
            List<Paciente> pacientes = new List<Paciente>();
            pacientes.Add(pacienteDao.selectByNHC(Int32.Parse(NHC)));
            return pacientes;
        }
        public List<Paciente> BuscarPacienteByDNI(String DNI)
        {
            PacienteDAO pacienteDao = new PacienteDAO(gf);
            List<Paciente> pacientes = new List<Paciente>();
            pacientes.Add(pacienteDao.selectByDNI(DNI));
            return pacientes;
        }
        public List<Paciente> BuscarTodosLosPacientes()
        {
            PacienteDAO pacienteDao = new PacienteDAO(gf);
            List<Paciente> pacientes = new List<Paciente>();
            pacientes = pacienteDao.selectAll();
            return pacientes;
        }
        public Boolean comprobarDNI(String dni)
        {
            PacienteDAO pacienteDao = new PacienteDAO(gf);
            if (pacienteDao.selectByDNI(dni)!=null)
            {
                return true;
            }

            return false;
        }

        public Boolean comprobarNHC(String nhc)
        {
            PacienteDAO pacienteDao = new PacienteDAO(gf);
            if (pacienteDao.selectByNHC(Int32.Parse(nhc)) != null)
            {
                return true;
            }

            return false;
        }

        public void buscarParaBorrar(String DNI, String Nombre, String Apellidos, int NHC, String direccion, String poblacion)
        {
            Paciente pacienteBorrar = new Paciente(Nombre, Apellidos,direccion,poblacion,DNI,NHC );
            PacienteDAO pacienteDao = new PacienteDAO(gf);
            List<Paciente> pacientes = new List<Paciente>();
            pacientes = pacienteDao.selectAll();
            for (int i = 0; i < pacientes.Count; i++)
            {
                if(pacientes[i].Dni == pacienteBorrar.Dni)
                {
                    pacientes.RemoveAt(i);
                }
                gf.sobrecargar(pacientes);
            }

        }

        public List<Paciente> BuscarPaciente(String DNI, String NHC)
        {
            PacienteDAO pacienteDao = new PacienteDAO(gf);
            List<Paciente> pacientes = new List<Paciente>();
            if (String.IsNullOrEmpty(DNI) && String.IsNullOrEmpty(NHC))
            {
                pacientes=pacienteDao.selectAll();
                return pacientes;
            }
            else
            {
                if (String.IsNullOrEmpty(DNI))
                {
                    pacientes.Add(pacienteDao.selectByNHC(Int32.Parse(NHC)));
                    return pacientes;
                }
                else
                {
                    pacientes.Add(pacienteDao.selectByDNI(DNI));
                    return pacientes;
                }
            }
            

        }


        

    }
}
