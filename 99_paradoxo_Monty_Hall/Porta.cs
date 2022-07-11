
using System;

namespace Curso
{   class Porta
    {
        public string PortaNr { get; set; }
        public bool Premiada { get; set; }
        public bool Escolhida { get; set; }
        public bool Valida { get; set; }

        public Porta(string PortaNr)
        {
            this.PortaNr = PortaNr;
            this.Premiada = false;
            this.Escolhida = false;
            this.Valida = true;
        }

        public override string ToString()
        {            
            return  this.PortaNr + 
                    ", premiada=" +     this.Premiada + 
                    ", escolhida=" +    this.Escolhida + 
                    ", válida=" +       this.Valida;
        }
    }
}