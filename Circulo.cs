namespace RepartidoCirculo;

public class Circulo
{
    private double radio;

    public double Radio
    {
        get { return radio; }
        set { radio = value; }
    }

    public Circulo(double radio)
    {
        this.Radio = radio;
    }

    public double GetArea(double radio)
    {
        double a = Math.PI;
        return radio * radio * a;
    }
}