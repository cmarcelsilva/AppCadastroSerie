using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCadastroSerie
{
    abstract class EntidadeBase
    {
        //TODA ENTIDADE SEMPRE TEM ID. COMO BASE PAR TODOS.. PARA FUTUROS MAIPLUCAÇÃO
        public int Id { get; protected set; }

    }
}
