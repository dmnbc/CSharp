internal class Artikel
{
    private int _art_id;
    private double _art_volumen;
    private double _art_einzelpreis;

    public double art_einzelpreis
    {
        get
        {
            return _art_einzelpreis;
        }
    }

    public double art_volumen
    {
        get
        {
            return _art_volumen;
        }
    }



    public Artikel()
    {
        //  WriteLine("Artikel  angelegt:");
    }

    public Artikel(int id, Artikel[] wk)
    { // WriteLine("Artikel {0} angelegt: ", wk[id]._art_id);
        _art_id = wk[id]._art_id;
        _art_volumen = wk[id]._art_volumen;//1.0/((double)id*3);
        _art_einzelpreis = wk[id]._art_einzelpreis; // 1.0 / ((double) id * 5) ;
                                                    //    WriteLine("Der Artikel hat ein Volumen von {0:F2} und einen Preis von {1:F2}", _art_volumen, _art_einzelpreis);
    }


    public Artikel(int id, double volumen, double preis)
    {
        // WriteLine("Artikel {0} angelegt: ", id);
        _art_id = id;
        _art_volumen = volumen;
        _art_einzelpreis = preis;
    }


}