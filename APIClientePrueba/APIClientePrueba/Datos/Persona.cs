using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ObjPersona
{
    public Persona persona { get; set; }
}

public class Persona
{
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string cedula { get; set; }
    public int edad { get; set; }
}
