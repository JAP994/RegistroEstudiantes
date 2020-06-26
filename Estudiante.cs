public class Estudiante
{
    private string primerNombre;
    private string segundoNombre;
    private string primerApellido;
    private string segundoApellido;
    public Estudiante(string nonmbre1, string nombre2, string apellido1, string apellido2)
    {
        primerNombre = nonmbre1;
        segundoNombre =nombre2;
        primerApellido =apellido1;
        segundoApellido =apellido2;
    }
    public string imprimirTodo()
    {
        return primerNombre + " " + segundoNombre + " " + primerApellido + " " + segundoApellido;
    }

}