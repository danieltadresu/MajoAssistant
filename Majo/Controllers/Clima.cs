using Majo.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Majo.Controllers
{
    public static class Clima
    {

        public static void printWeather()
        {
            printWeatherIntern(getWeatherIntern());
        }
        private static ClimaModel getWeatherIntern()
        {
            var path = @"https://www.metaweather.com/api/location/349859/";

            var request = (HttpWebRequest)WebRequest.Create(path);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            ClimaModel climaModel = new ClimaModel();

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null)
                            return climaModel;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody

                            dynamic data = JObject.Parse(responseBody);
                            climaModel.minTemp = data.consolidated_weather[0].min_temp;
                            climaModel.maxTemp = data.consolidated_weather[0].max_temp;
                            climaModel.actTemp = data.consolidated_weather[0].the_temp;
                            climaModel.humedity = data.consolidated_weather[0].humidity;
                            
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
            return climaModel;
        }
   
        private static void printWeatherIntern(ClimaModel clima)
        {
            string message = $@"
  _____ _    ____ _ _                       _        _   _             
 | ____| |  / ___| (_)_ __ ___   __ _    __| | ___  | | | | ___  _   _ 
 |  _| | | | |   | | | '_ ` _ \ / _` |  / _` |/ _ \ | |_| |/ _ \| | | |
 | |___| | | |___| | | | | | | | (_| | | (_| |  __/ |  _  | (_) | |_| |
 |_____|_|  \____|_|_|_| |_| |_|\__,_|  \__,_|\___| |_| |_|\___/ \__, |
                                                                 |___/ 
Temperatura Actual:    {clima.actTemp}
Temperatura Maxima:    {clima.maxTemp}
Temperatura Minima:    {clima.minTemp}
Humedad para Hoy  :    {clima.humedity}

";
            Console.WriteLine(message);

        }
    }
}
