using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class KeresztrejtvenyRacs
{
    private List<string> Adatsorok;
    private char[,] Racs;
    private int[,] Sorszamok;

    public int SorokDb { get; private set; }
    public int OszlopokDb { get; private set; }

    public KeresztrejtvenyRacs(string forrasNev)
    {
        BeolvasAdatsorok(forrasNev);

        SorokDb = Adatsorok.Count;
        OszlopokDb = Adatsorok[0].Length;

        Racs = new char[SorokDb + 2, OszlopokDb + 2];
        Sorszamok = new int[SorokDb + 2, OszlopokDb + 2];

        FeltoltRacs();
    }

    private void BeolvasAdatsorok(string fajlnev)
    {
        Adatsorok = File.ReadAllLines(fajlnev).ToList();
    }

    private void FeltoltRacs()
    {
        for (int i = 0; i < SorokDb + 2; i++)
        {
            for (int j = 0; j < OszlopokDb + 2; j++)
            {
                Racs[i, j] = '#';
            }
        }

        for (int i = 0; i < SorokDb; i++)
        {
            for (int j = 0; j < OszlopokDb; j++)
            {
                Racs[i + 1, j + 1] = Adatsorok[i][j];
            }
        }
    }
}