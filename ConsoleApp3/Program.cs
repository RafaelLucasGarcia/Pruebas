using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.IO;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {


            var preguntas = LeerJson.Leer();
            Menu.ImprimirMenu(preguntas);
            Console.ReadLine();


        }       
    }
    public class LeerJson {

        
        
        public static List<Pregunta> Leer()

        {
             List<Pregunta> preguntas = new List<Pregunta>();
            string ruta = "C:/Users/Usuario/source/repos/ConsoleApp3/ConsoleApp3/json1.json";
            var  json = File.ReadAllText(ruta);
            StringReader r = new StringReader(json);
            JsonTextReader reader = new JsonTextReader(r);


            while (reader.Read()) {

                Pregunta actual = new Pregunta();
                preguntas.Add(actual);

            }                    
            return preguntas;
        }
    }

    public class Pregunta
    {
        
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public List<Parametro> Parametros { get; set; }
        /*string json = @"{
          'Name': 'Bad Boys',
          'ReleaseDate': '1995-4-7T00:00:00',
          'Genres': [
            'Action',
            'Comedy'
          ]
        ";
        Movie m = JsonConvert.DeserializeObject<Movie>(json);
        string name = m.Name;*/
        // Bad Boys
        

    }
    public class Parametro {
        public string Tipo{get; set;}
        public string Nombre{get; set;}
    }


    public class Menu {
       
        public static void ImprimirMenu(List<Pregunta> preguntas) {
            foreach (var p in preguntas) {
                Console.WriteLine(p.Id + " - " + p.Descripcion);
            }     
        }
        public static string LeerRespuesta() {
            return Console.ReadLine();
        }
    }

    public class Sql {



    }
   
}


