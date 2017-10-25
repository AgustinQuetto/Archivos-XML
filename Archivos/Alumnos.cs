using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Archivos
{
    public class Alumnos:Persona
    {
        private int _legajo;
        public int Legajo { get { return this._legajo; } set { this._legajo = value; } }

        public Alumnos():base(){
            this.Legajo = 0;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Legajo;
        }
    }
}
