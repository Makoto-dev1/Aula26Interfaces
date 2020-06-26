namespace Aula26Interfaces
{
    public interface ICarrinho
    {
         // CRUD

         void Criar( Produto produto );

         void Ler();

         void Alterar( int _codigo, Produto produto );

         void Deletar( Produto produto );
         
         void MostrarTotal();
    }
}