using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class PacienteDAO
    {
        private GestorFichero gf;

        public PacienteDAO(string rutaFichero)
        {
            gf = new GestorFichero(rutaFichero);
        }

        public PacienteDAO(GestorFichero gf)
        {
            this.gf = gf;
        }

        public PacienteDAO()
        {
        }

        public List<Paciente> selectAll()
        {
            List<Paciente> pacientes = new List<Paciente>();
            foreach (string line in gf.leerlinea())
            {
                string[] data = line.Split(':');
                pacientes.Add(new Paciente(data[0], data[1], data[2],data[3], data[4], Int32.Parse(data[5])));
            }
            return pacientes;
        }
        public Paciente selectByDNI(string dni)
        {
            List<Paciente> pacientes = new List<Paciente>();
            foreach (string line in gf.leerlinea())
            {
                string[] data = line.Split(':');
                if (data[4].Equals(dni))
                    return new Paciente(data[0], data[1], data[2], data[3], data[4], Int32.Parse(data[5]));
            }
            return null;
        }

        public bool obtenerDNY(string dni)
        {
            List<Paciente> pacientes = new List<Paciente>();
            foreach (string line in gf.leerlinea())
            {
                string[] data = line.Split(':');
                if (data[0].Equals(dni))
                    return true;
            }
            return false;
        }


        public Paciente selectByNHC(int nhc)
        {
            List<Paciente> pacientes = new List<Paciente>();
            foreach (string line in gf.leerlinea())
            {
                string[] data = line.Split(':');
                if (Int32.Parse(data[5]).Equals(nhc))
                {
                    return new Paciente(data[0], data[1], data[2], data[3], data[4], Int32.Parse(data[5]));
                }
              
            }
            return null;
        }
        public void Save(Paciente paciente)
        {
            String texto = paciente.Nombre + ":" + paciente.Apellidos +":"+paciente.Direccion+":"+paciente.Poblacion+":"+paciente.Dni+":"+paciente.Nhc;
            gf.write(texto);
        }

        public String SavePaciente(Paciente paciente)
        {
            String texto = paciente.Nombre + ":" + paciente.Apellidos + ":" + paciente.Direccion + ":" + paciente.Poblacion + ":" + paciente.Dni + ":" + paciente.Nhc;
            gf.write(texto);
            return texto;
        }


    }
}
