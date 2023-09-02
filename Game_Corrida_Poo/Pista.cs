using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Corrida_Poo
{
    internal class Pista
    {
       
        public Pista(int ptamanho,Corredor atleta) 
        {   // vai receber via parametro
            this.tamanho = ptamanho;
            this.atleta = atleta;
            this.posAtleta = 0;
           
        }   
        public int tamanho { get; set; } // pista tamanho

        
        
        private int posAtleta;  // corredor posição acesso permitido somente aqui na classe

        public int PosAtleta
        {
            get { return this.posAtleta; }
            //set { this.posCorredor = value; } acesso publico somente leitura
        }

       
        
        private Corredor atleta { get; set; } // essa propriedade é uma variavel derivada da classe Corredor, por isso ela pode chamar
                                              // metodos da classe Corredor
         // imagem da pista e do corredort da pista
      
        
        public Boolean AtualizarCorrida() 
        {
            Boolean ganhou = false;
            if (this.posAtleta < this.tamanho)
            {
                this.posAtleta += this.atleta.Correr(); // aqui vemos uma propriedade "atleta" derivada da classe Corredor chamando um metodo da mesma
            }
            if(this.posAtleta>=this.tamanho)
            {
                ganhou = true;
                this.posAtleta = this.tamanho;
            }
            
            return ganhou;
        }

        public void ExibirPista()
        {
               string pista = ""; // representa a pista 
               string corredorPista = ""; // representa o corredor na pista
            // monta imagem do corredor na pista na  posição atual dele
           
            
            for (int i = 0; i < this.tamanho + 15; i++) // como aqui esta so desenhando a pista acrescentei o 15 para estender mais a pista para que a mesma se alongue até o fim do percurso do corredor
            {

                pista += "_";
                if (i == this.PosAtleta)

                {
                    corredorPista += this.atleta.Nome;
                }
                else
                {
                    corredorPista += " ";
                }

            }
            // exibir minha pista e o corredor

            Console.WriteLine("pos-" + posAtleta + "_" + corredorPista);
            Console.WriteLine(pista);
           

        }

    }
}
