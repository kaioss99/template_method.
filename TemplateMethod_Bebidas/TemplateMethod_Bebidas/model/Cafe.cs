namespace TemplateMethod_Bebidas
{
    public class Cafe : BebidaBase
    {
        protected override string AdicionarIngredientePrincipal()
            => " Adicionando pó de café...\n";

        protected override string Coar()
            => " Coando o café no filtro...\n";

        // Sobrescreve o hook para adicionar açúcar
        protected override string AdicionarExtras()
            => " Adicionando açúcar...\n";
    }
}
