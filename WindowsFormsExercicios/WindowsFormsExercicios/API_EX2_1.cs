using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExercicios
{
    internal class API_EX2_1
    {

        //string chaveAPI = "d0c4d691e3f1fa2da4267474044805d3";

        //public async Task<API2_EX2_2> intregacao(string cidadeNome)
        //{

        //    string cidadeID = "";

        //    if(cidadeNome == "Americana")
        //    {
        //        cidadeID = "3472343";
        //    }

        //    if (cidadeNome == "Campinas")
        //    {
        //        cidadeID = "3467865";
        //    }

        //    if (cidadeNome == "Santa Bárbara d'Oeste")
        //    {
        //        cidadeID = "3450404";
        //    }


        //    HttpClient client = new HttpClient();
        //    var respostas = await client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?id={cidadeID}&lang=pt_br&units=metric&appid={chaveAPI}");
        //    var jsonString = await respostas.Content.ReadAsStringAsync();
            
        //    var jsonObjeto = JsonConvert.DeserializeObject<API2_EX2_2>(jsonString);

        //    return jsonObjeto;
        //}
    }
}
