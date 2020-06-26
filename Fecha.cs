public class Fecha
{
    private string _dia;
    private string _mes;

    private string _anio;


    public Fecha(string dia, string mes, string anio)
    {
        _dia = dia;
        _mes = mes;
        _anio = anio;

    }
    public string obtenerFecha()
    {
        return _dia +" " + _mes +" " + _anio ;
    }

}