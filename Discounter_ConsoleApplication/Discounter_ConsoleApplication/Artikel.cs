internal class Artikel
{
    private int _art_id;
    private double _art_volumen;
    private double _art_einzelpreis;

    public double art_einzelpreis
    {
        get {return _art_einzelpreis;}
    }

    public double art_volumen
    {
        get {return _art_volumen;}
    }

    public Artikel()
    {
        //  WriteLine("Artikel  angelegt:");
    }

    public Artikel(int id, Artikel[] wk)
    { // WriteLine("Artikel {0} angelegt: ", wk[id]._art_id);
        _art_id = wk[id]._art_id;
        _art_volumen = wk[id]._art_volumen;
        _art_einzelpreis = wk[id]._art_einzelpreis; 
    }

    public Artikel(int id, double volumen, double preis)
    {
        _art_id = id;
        _art_volumen = volumen;
        _art_einzelpreis = preis;
    }
}