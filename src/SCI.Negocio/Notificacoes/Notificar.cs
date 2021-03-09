using SCI.Negocio.Interfaces;
using SCI.Negocio.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace SCI.Negocio.Notificacoes
{
    public class Notificar : INotificar
    {
        private List<Notificacao> _notificacoes;
        public Notificar()
        {
            _notificacoes = new List<Notificacao>();
        }
        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }
        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }
        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
