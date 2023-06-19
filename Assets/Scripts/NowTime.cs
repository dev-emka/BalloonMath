using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class NowTime
{
    public static string yil;
    public static string ay;
    public static string gun;
    public static string saat;
    public static string dak;

    public static List<string> times = new List<string>() { "0", "0", "0", "0", "0" };
    public static string zaman;
    public static void Zamn()
    {
        yil = DateTime.Now.Year.ToString();
        ay = DateTime.Now.Month.ToString();
        gun = DateTime.Now.Day.ToString();
        saat = DateTime.Now.Hour.ToString();
        dak = DateTime.Now.Minute.ToString();

        zaman = gun.ToString() + "/" + ay.ToString() + "/" + yil.ToString() + "\n" + saat.ToString() + ":" + dak.ToString();
    }
}
