using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeAnimais
{
    public class Animal
    {
        private string nome;

        //métodos de acesso
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private string tipo;
        public string Tipo
        {
            get { return tipo; }    
            set 
            {
                if (value == "CACHORRO" || value == "GATO" || value == "PEIXE")
                {
                    tipo = value.ToUpper(); 
                }
                else //caso seja informado um valor diferente dos 3 válidos, o tipo definido será peixe
                {
                    tipo = "PEIXE";
                }
            }
        }

    }
}
