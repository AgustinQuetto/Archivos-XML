using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Archivos
{
    [XmlInclude(typeof(Alumnos))]
    public class Persona
    {
        private string _nombre;
        private string _apellido;

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = value;
            }
        }

        public Persona() {
            this._apellido = "Anonimo";
            this._nombre = "Anonimo";
        }

        public Persona(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }
    }
}
