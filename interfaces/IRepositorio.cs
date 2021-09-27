using System.Collections.Generic;

namespace DIO.Avanade.CRUD.Series.interfaces{

    public interface IRepositorio<T>{

        List<T> lista();

        void Atualiza(int id, T entidade);
        void Exclui(int id);
        void Insere(T entidade);
        T RetornaPorID(int id);
        int ProximoID();
    }
}