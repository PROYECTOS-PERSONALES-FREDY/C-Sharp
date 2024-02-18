
public class Rootobject
{
    public Persona persona { get; set; }
}

public class Persona
{
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string cedula { get; set; }
    public int edad { get; set; }
    public Direccion direccion { get; set; }
    public Carro carro { get; set; }
}

public class Direccion
{
    public string calle { get; set; }
    public string numero { get; set; }
    public string ciudad { get; set; }
    public string codigo_postal { get; set; }
}

public class Carro
{
    public string marca { get; set; }
    public string modelo { get; set; }
    public int anio { get; set; }
    public string color { get; set; }
    public string placa { get; set; }
    public Caracteristicas caracteristicas { get; set; }
}

public class Caracteristicas
{
    public string motor { get; set; }
    public string transmision { get; set; }
    public string traccion { get; set; }
    public int kilometraje { get; set; }
}
