namespace Aula02
{
    public class ManipulaString
    {
        private int contadorVogais;
        private int contadorConsoantes;
        public void Abreviatura(string[] nome){
            foreach (string item in nome)
            {
                if(item.Length>2){
                    Console.Write(item.Substring(0,1) + ". ");
                } else{
                    Console.Write(item+ " ");
                }
            }
        }

        public string Inverte(string nome){
            char[] letras = nome.ToCharArray(); 
            Array.Reverse(letras);
            return new string(letras);
        }
        public void VogaisEConsoante(string frase){
            contadorConsoantes = 0;
            contadorVogais = 0;
            foreach (char item in frase)
            {
                if(item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u'){
                    contadorVogais = contadorVogais+1;
                } else{
                    contadorConsoantes = contadorConsoantes +1;
                }
            }
            Console.WriteLine($"A frase '{frase}' contém {contadorVogais} vogais e {contadorConsoantes} consoantes");
        }
    }
}