using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ES.Admin.UI.Models
{
    public class LoginControl
    {
        public static string[] Allow(object session, string url, object lastPath)
        {
            string[] returnArr = new string[2];

            if (url.StartsWith("/"))
                url = url.ToUpper().Substring(1);
            if (!url.Contains('/'))
                url += "/INDEX";
            url = EngToTr(url);
            var urlArr = url.Split('/');


            if (lastPath.ToString().StartsWith("/"))
                lastPath = lastPath.ToString().ToUpper().Substring(1);

            if (!lastPath.ToString().Contains("/"))
                lastPath = lastPath.ToString() + "/INDEX";

            lastPath = EngToTr(lastPath.ToString());
            var lastPathArr = lastPath.ToString().Split('/');


            var per = (SesPer)session;
            if (session != null)
            {
                if (per.Rol == Rol.Admin)
                    return urlArr;

                if (per.Rol == Rol.SatisTemsilcisi)
                {
                    if (url.Contains("DEFAULT"))
                    {

                        return urlArr;
                    }
                    if (url.Contains("PERSONEL"))
                    {
                        if (url.ToUpper().Contains("CREATE") || url.ToUpper().Contains("EDIT") || url.ToUpper().Contains("EDİT"))
                        {
                            return lastPathArr;
                        }
                        return urlArr;
                    }
                    if (url.ToUpper().Contains("MUSTERI") || url.ToUpper().Contains("MUSTERİ"))
                    {
                        if (url.ToUpper().Contains("CREATE") || url.ToUpper().Contains("EDIT") || url.ToUpper().Contains("EDİT"))
                        {
                            return lastPathArr;
                        }
                        return urlArr;
                    }
                    if (url.ToUpper().Contains("EMLAK") )
                    {
                        if (url.ToUpper().Contains("CREATE") || url.ToUpper().Contains("EDIT") || url.ToUpper().Contains("EDİT"))
                        {
                            return lastPathArr;
                        }
                        return urlArr;
                    }
                    if (url.Contains("PORTFOY"))
                    {
                        if (url.ToUpper().Contains("CREATE") || url.ToUpper().Contains("EDIT") || url.ToUpper().Contains("EDİT"))
                        {
                            return lastPathArr;
                        }
                        return urlArr;
                    }
                }

                return null;// return lastPathArr;
            }
            else
            {
                returnArr[0] = "LOGIN";
                returnArr[1] = "INDEX";
                return returnArr;
            }

            return returnArr;

        }

        private static string EngToTr(string text)
        {
            text = text.ToLower();

            text = text[0].ToString().ToUpper() + text.Substring(1);
            return text.Replace("İ", "I").Replace("ı", "i");

        }

    }
}