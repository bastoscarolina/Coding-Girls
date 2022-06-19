namespace Aula02
{
    public class Fatura
    {
        string numeroFatura {get;set;} = String.Empty;
        string[] descricaoProdutos {get;set;}
        int[] quantidadeProdutos{get;set;}
        double[] precoProdutos{get;set;}
        double valorFatura;

        public Fatura(){
            this.numeroFatura = " 001 ";
        }
        
        public void setNumeroFatura(string NumeroFatura){
            this.numeroFatura = NumeroFatura;
        }
        public string getNumeroFatura(){
            return numeroFatura;
        }

        public void setDescricaoProdutos(string[] DescricaoProdutos){
            this.descricaoProdutos = DescricaoProdutos;
        }
        public void getDescricaoProdutos(){
            for (int i = 0; i < descricaoProdutos.Length; i++)
            {
                Console.WriteLine(descricaoProdutos[i]);
            }
        }
        public void setQuantidadeProdutos(int[] QuantidadeProdutos){
            this.quantidadeProdutos = QuantidadeProdutos;
        }
        public void getQuantidadeProdutos(){
            for (int i = 0; i < quantidadeProdutos.Length; i++)
            {
                Console.WriteLine(quantidadeProdutos[i]);
            }
        }

        public void setPrecoProdutos(double[] PrecoProdutos){
            this.precoProdutos = PrecoProdutos;
        }
        public void getPrecoProdutos(){
            for (int i = 0; i < precoProdutos.Length; i++)
            {
                Console.WriteLine(precoProdutos[i]);
            }
            
        }
        public double ValorFatura(int[] quantidadeProdutos, double[] precoProdutos){
            valorFatura = 0;
            if(quantidadeProdutos.Length == precoProdutos.Length){
                for (int i = 0; i < quantidadeProdutos.Length; i++)
                {
                    valorFatura += (double)quantidadeProdutos[i]* precoProdutos[i];
                }
            } else{
                Console.WriteLine("Verifique se as quantidades e os preços estão corretos");
            }
            return valorFatura;
        }

    }
}