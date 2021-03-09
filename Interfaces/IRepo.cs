using System.Collections.Generic;

namespace series.interfaces
   

{
    public interface IRepo <T>
    {
        List <T> lista();
        
        T RetornaPorId(int id);

        void Insere(T EntidadeBase);

        void Exclui(int id);

        void Atualiza(int id, T EntidadeBase);

        int ProximoId(); 


    }
}