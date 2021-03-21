using SCI.Negocio.Modelos;
using System.Collections.Generic;

namespace SCI.Negocio.Interfaces
{
    public interface INotificar
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
