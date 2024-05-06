
    var sviDomovi = new List<ProizvodniMetod.DomZaZamenu>
        {
            new ProizvodniMetod.DomZaZamenu("Beograd", 120, 3, 10),
            new ProizvodniMetod.DomZaZamenu("Novi Sad", 100, 2, 10),
            new ProizvodniMetod.DomZaZamenu("Niš", 150, 4,10)
        };

    string lokacija = "Beograd";
    int minVelicina = 100;
    int minBrojSoba = 2;
    int opremljenost = 4;

    var rezultatiPretrage = ProizvodniMetod.PretragaDomova.PretraziDomove(sviDomovi, lokacija, minVelicina, minBrojSoba, opremljenost);

    Console.WriteLine("Rezultati pretrage:");
    foreach (var dom in rezultatiPretrage)
    {
        Console.WriteLine($"Lokacija: {dom.Lokacija}, Veličina: {dom.Velicina}, Broj soba: {dom.BrojSoba}");
    }
