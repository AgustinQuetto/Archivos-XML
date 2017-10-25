using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona persona1 = new Persona("Leonardo", "Di Caprio");

            /*using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory+@"\personas.txt", true)) {
                sw.WriteLine(persona1.ToString());
            }*/

            /*using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\personas.txt", true))
            {
                sw.WriteLine(persona1.ToString());
            }*/

            /*StreamReader r = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\personas.txt");


            while (sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
                Thread.Sleep(2000);
            }*/

            //TextReader tr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\personas.txt");
            /*while (tr.EndOfStream == false)
            {
                Console.WriteLine(tr.ReadLine());
                Thread.Sleep(2000);
            }*/

            using (StreamWriter sw = new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\personas.xml"), false))
            {
                List<Persona> misPersonas = new List<Persona>();
                Persona persona1 = new Persona("Leonardo", "Di Caprio");
                Persona persona2 = new Persona("Ricardo", "Jejo");
                Alumnos alumno1 = new Alumnos();

                misPersonas.Add(persona1);
                misPersonas.Add(persona2);
                misPersonas.Add(alumno1);

                XmlSerializer xmls = new XmlSerializer(typeof(List<Persona>));
                xmls.Serialize(sw, misPersonas);
            }

            using(StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\personas.xml")){
                XmlSerializer xmls = new XmlSerializer(typeof(List<Persona>));
                List<Persona> misPersonas = new List<Persona>();

                misPersonas = (List<Persona>)xmls.Deserialize(sr);

                foreach(Persona p in misPersonas){
                    Console.WriteLine(p.ToString());
                }
            
            }

            Console.ReadLine();
        }
    }
}
