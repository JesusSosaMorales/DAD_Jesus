using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class GestorFichero
    {
        private string path;

        public GestorFichero(string path)
        {
            this.Path = path;
        }
        public string Path { get => path; set => path = value; }

        public String[] leerlinea()
        {
            StreamReader reader = new StreamReader(path);
            List<String> lines = new List<String>();
            while (!reader.EndOfStream)
            {
                lines.Add(reader.ReadLine());
            }
            return lines.ToArray();
        }
        
        public String leerTodo()
        {
            StreamReader reader = new StreamReader(path);
            String output = "";
            while (!reader.EndOfStream)
            {
                output += reader.ReadLine() + "\n";
            }
            reader.Close();
            return output;
        }

        public void write(string value)
        {
            StreamWriter writer = new StreamWriter(path,true);
            writer.WriteLine("\n"+value);
            writer.Flush();
            writer.Close();

        }

        public void sobrecargar(List<Paciente> pacientes)
        {
            StreamWriter writer = new StreamWriter(path);
            PacienteDAO pacienteDAO = new PacienteDAO();
            foreach(Paciente paciente in pacientes)
            {
                writer.WriteLine(pacienteDAO.SavePaciente(paciente));
                writer.Flush();
            }
            writer.Close();

        }
    }
}