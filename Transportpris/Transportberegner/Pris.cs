namespace Transportpris.Transportberegner;

public class Pris
{
    public int pris(int afstand, int vaegt)
    {
        var pris = 0;
        switch ((afstand, vaegt))
        {
            case (<5, <10):
                break;
            case(<5,>=10):
                pris = 50;
                break;
            case(>=5, <10):
                pris = 75;
                break;
            default:
                pris = 100;
                break;
        }

        return pris;
    }
}