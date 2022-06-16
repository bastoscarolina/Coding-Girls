namespace Aula01
{
    public class Voo
    {
        private int[] assentos = new int[100];
        private int quantidadeVagasLivres;
        private int assentoLivre;
        public DateTime data = new DateTime();

        public bool OcuparVaga(int assento){ 
            if(assentos[assento-1] == 0){
                assentos[assento-1]=1;
                return true;
            } else {
                return false;
            }    
        }
        public int VagasLivre(){
            quantidadeVagasLivres =0;

            for (int i = 0; i < assentos.Length; i++)
            {
                if(assentos[i] == 0){
                    quantidadeVagasLivres = quantidadeVagasLivres + 1;
                }   
            }
            return quantidadeVagasLivres;
        }

        public int CadeiraLivre(){
            
            for (int i = 0; i < assentos.Length; i++)
            {
                if (assentos[i] == 0)
                {    
                  assentoLivre = i; 
                  break; 
                }
            }
            return assentoLivre +1;
        }

        public void verHorario(){
            Console.WriteLine($"O voo será {data.ToString("dd/MM/yyyy HH:mm:ss")}");
        }
    }
}