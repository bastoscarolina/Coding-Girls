namespace Aula05
{
    public class Biblioteca
    {
        Livro[] livros = new Livro[1];
        Periodico[] periodicos = new Periodico[1];
        int quantidadeLivros = 1;
        int quantidadePeriodicos = 1;

        public Livro[] Livros{
            get{
                return livros;
            }
        }
        public Periodico[] Periodicos{
            get{
                return periodicos;
            }
        }
        public Livro AdicionaLivro(string livroTitulo){
            Livro livro = new Livro(livroTitulo);
            livros[quantidadeLivros-1] = livro;
            Array.Resize(ref livros, livros.Length +1);
            quantidadeLivros +=1;

            return livro;
        }
        public Periodico AdicionaPeriodico(string periodicoTitulo, int periodicoVolume){
            Periodico periodico = new Periodico(periodicoTitulo, periodicoVolume);
            periodicos[quantidadePeriodicos-1]= periodico;
            Array.Resize(ref periodicos, periodicos.Length +1);
            quantidadePeriodicos+=1;

            return periodico;
        }
        public void AcervoBiblioteca(){
            for (int i = 0; i < this.livros.Length; i++)
            {
                if(this.livros[i]!= null){
                    Console.WriteLine($"{this.livros[i].Titulo} está {this.livros[i].Situacao}");
                }
            }
            
            for (int i = 0; i < this.periodicos.Length; i++)
            {
                if(this.periodicos[i]!= null){
                    Console.WriteLine($"{this.periodicos[i].Titulo} está {this.periodicos[i].Situacao}");
                }
            }
        }
        public void Emprestimo(Livro livro){
            if(livro.Situacao == "Disponivel"){
                livro.Situacao = "Emprestado";
                Console.WriteLine($"Data de devolução: {DateTime.Now.AddDays(7)}. Boa leitura!");
            }else{
                Console.WriteLine($"{livro.Titulo} já está emprestado");
            }
        }
        public void Devolucao(Livro livro){
            if(livro.Situacao == "Emprestado"){
                livro.Situacao = "Disponivel";
            }else{
                Console.WriteLine($"{livro.Titulo} já está na biblioteca");
            }
        }
        public void LerPeriodico(Periodico periodico){
            if(periodico.Situacao == "na estante"){
                periodico.Situacao = "está sendo lido";
            }else{
                Console.WriteLine($"{periodico.Titulo} {periodico.Volume} já está sendo lido");
            }
        }
    }
    public abstract class Acervo
    {
        protected string titulo = String.Empty;
        
        
    }

    public class Livro : Acervo 
    {
        public Livro(string titulo){
            this.titulo = titulo;
        }
        public string Titulo{
            get{
                return titulo;
            }
        }
        private string situacao = "Disponivel";
        public string Situacao {
            get{
                return situacao;
            }
            set{
                situacao = value;
            }
        }
                
    }
    public class Periodico : Acervo 
    {
        public Periodico(string titulo, int volume){
            this.titulo = titulo;
            this.volume = volume;
        }
        private int volume;
        public int Volume{
            get{
                return volume;
            }
        }
        public string Titulo{
            get{
                return titulo;
            }
        }
        private string situacao = "na estante";
        public string Situacao {
            get{
                return situacao;
            }
            set{
                situacao = value;
            }
        }
    }
}