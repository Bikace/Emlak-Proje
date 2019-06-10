using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
namespace ES.UI
{
    static class Utils
    {
        public static void LogTut(string islem, string metotAdi, string mesaj, LogDurum ht)
        {

            string dosyaAdi = DateTime.Now.ToShortDateString();
        //var fileName = Directory.GetCurrentDirectory() + "\\" + dosyaAdi + "_Log.txt";
       
           var fileName = "C:\\Users\\soner.kose\\Desktop\\EmlakSitesiProje-2\\ES.UI\\bin" + "\\" + dosyaAdi + "_Log.txt";

            StreamWriter objWriter = new StreamWriter(fileName, true);//true ekleme yapar txt ye, false txt boşaltır yazar

            string sablon = @"  Zaman: {0}
                                Islem : {1}
                                Metot: {2}
                                Mesaj: {3}
                                Durum: {4}";
            sablon = string.Format(sablon, DateTime.Now, islem, metotAdi, mesaj, ht.ToString());
            objWriter.WriteLine(sablon);
            objWriter.Close();
        }
    }
    enum LogDurum
    {
        Info,
        Succes,
        Error,
        Warning
    }
}