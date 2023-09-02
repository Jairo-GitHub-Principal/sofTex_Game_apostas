using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Corrida_Poo
{
    public enum AtletaEscolhido { Antonio, Bianca, Carlos };
    public class Corredor
    {
        
        public Corredor() 
        { 
            this.Nome = "";
        }   
        public Corredor(string name)
        {
            this.Nome = name;
        }

        private string nome;

        public string Nome
        {
            get { return this.nome; }
            set {
                this.nome = value.ToLower();
                if (value.Length > 1)
                {
                    this.nome = value[0].ToString().ToLower();
                }
                else if (value.Length == 0)
                {
                    this.nome = "?";
                }
               
                
               

               
            }
        }

        public static Random random = new Random();


        public int Correr()
        {
           
            return random.Next(8,16);
        }
            
            
            }
}
