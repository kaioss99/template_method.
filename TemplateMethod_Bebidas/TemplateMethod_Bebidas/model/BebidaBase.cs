namespace TemplateMethod_Bebidas
{
    // Classe abstrata — define o esqueleto do algoritmo
    public abstract class BebidaBase
    {
        // *** TEMPLATE METHOD ***
        // Sequência fixa — subclasses NÃO podem alterar a ordem
        public string Preparar()
        {
            var log = "";
            log += FerverAgua();
            log += AdicionarIngredientePrincipal();
            log += Coar();
            log += AdicionarExtras();
            return log;
        }

        // Passo igual para todas as bebidas — implementado aqui mesmo
        private string FerverAgua()
            => "🔥 Fervendo a água...\n";

        // Passos variáveis — cada bebida implementa do seu jeito
        protected abstract string AdicionarIngredientePrincipal();
        protected abstract string Coar();

        // Hook — opcional, subclasse pode ou não sobrescrever
        protected virtual string AdicionarExtras()
            => "";
    }
}
