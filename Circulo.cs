namespace RepartidoCirculo;

public class Circulo
{
    private double radio;
    private double perimetro;
    public double Radio
    {
        get { return radio; }
        set { radio = value; }
    }

    public double Perimetro
    {
        get { return perimetro; }
        set { perimetro = value; }
    }

    public Circulo(double radio, double perimetro)
    {
        this.Radio = radio;
        this.Perimetro = perimetro;
    }

    public double GetArea(double radio)
    {
        double a = Math.PI;
        return radio * radio * a;
    }

    public double GetPerimetro(double perimetro)
    {
        double a = Math.PI;
        return 2 * a * radio;
    }
}