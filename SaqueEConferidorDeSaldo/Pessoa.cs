namespace SaqueEConferidorDeSaldo
{
    public class Pessoa
    {

        public string nome;
        public int idade;
        public string sobreNome;
        public int pe;
        public double altura;

        public Pessoa()
        {
            nome = "";
            sobreNome = "";
        }


        public string GetInformacoesPessoa()
        {
            return "Nome: " + nome + "\n" + "Sobre Nome: " + sobreNome + "\n" + "Idade: " + idade +
           "\n" + "Altura: "  
           + altura + "\n" + "Pé: " + pe;
        }

    }

}
