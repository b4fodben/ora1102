int jelszo_erosseg(string jelszo)
{
    int jelszo_eros = 1;

    if (jelszo.Length >= 8)
    {
        jelszo_eros += 2;
    }
    if (jelszo.Length >= 5)
    {
        jelszo_eros += 1;
    }

    foreach (char karakter in jelszo)
    {
        if (karakter == '.')
        {
            jelszo_eros += 2;
        }
        if (karakter == '-')
        {
            jelszo_eros += 2;
        }
        if (karakter == '_')
        {
            jelszo_eros += 2;
        }
    }

    if (jelszo.Contains("123"))
    {
        jelszo_eros = 0;
    }
    if (jelszo.Contains("jelszo"))
    {
        jelszo_eros = 0;
    }
    if (jelszo.Length == 0)
    {
        jelszo_eros = 0;
    }

    return jelszo_eros;

}

Console.WriteLine(jelszo_erosseg("hazi_macska_4_life"));

string maganhangzot_torol(string szoveg)
{
    string ujszoveg = "";

    string maganhangzok = "aáiíöőüűóoúueé";

    foreach (char a in szoveg)
    {
        char karakter = char.ToLower(a);

        if (maganhangzok.Contains(karakter))
        {

        }
        else
        {
            ujszoveg += a;
        }
    }

    return ujszoveg;
}

Console.WriteLine(maganhangzot_torol("Iden Java szigeten voltunk nyaralni. Nem is tudtam, hogy elneveztek egy helyet egy programozasi nyelvrol"));

string elmozdulas(string iranyok)
{
    int xLepesek = 0;
    int yLepesek = 0;

    foreach (char karakter in iranyok)
    {
        if (char.ToLower(karakter) == 'f')
        {
            yLepesek++;
        }
        if (char.ToLower(karakter) == 'l')
        {
            yLepesek--;
        }
        if (char.ToLower(karakter) == 'j')
        {
            xLepesek++;
        }
        if (char.ToLower(karakter) == 'b')
        {
            xLepesek--;
        }
    }

    string kimenet = "";

    if (xLepesek != 0)
    {
        if (xLepesek < 0)
        {
            kimenet += $"{Math.Abs(xLepesek)} lepes balra ";
        }else if (xLepesek > 0)
        {
            kimenet += $"{Math.Abs(xLepesek)} lepes jobbra ";
        }
    }

    if (yLepesek != 0)
    {
        if (yLepesek < 0)
        {
            kimenet += $"{Math.Abs(yLepesek)} lepes le";
        }
        else if (yLepesek > 0)
        {
            kimenet += $"{Math.Abs(yLepesek)} lepes fel";
        }
    }

    if (yLepesek == 0 & xLepesek == 0)
    {
        kimenet = "Nem mentunk sehova";
    }

    return kimenet;
}

Console.WriteLine(elmozdulas("FFLLBBJJ"));