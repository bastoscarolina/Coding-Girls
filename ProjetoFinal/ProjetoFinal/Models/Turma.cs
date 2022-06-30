namespace ProjetoFinal.Models
{
    public class Turma
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        #region Navigation Properties
        public virtual List<Aluno>? Alunos { get; set; }
        #endregion
    }
}
