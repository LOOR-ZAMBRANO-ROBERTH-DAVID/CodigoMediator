using System;
using EjemploDeMediador.Interfaces;
using EjemploDeMediador.Clases;

namespace EjemploDeMediador.Clases
{
    public class UserAdmin : IColleague
    {
        public UserAdmin(IMediator mediator) : base(mediator) /*Recibe el mediador*/
        {
        }
        public override string Recive(string message)
        {
            return "Un administrador recibe: "+message;
        }
    }
}
