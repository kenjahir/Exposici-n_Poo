using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladeChat
{
    
    public  abstract class Usuarios
    {
        protected IMediator Mediator;
        protected string NombredeUsuario = String.Empty;

        // ESTA CLASE RECIBE EN SU CONSTRUCTOR EL MEDIADOR Y NOMBRE DE USUARIO.
        public Usuarios(IMediator mediator, string nombredeusuario)
        {
            Mediator = mediator;
            NombredeUsuario = nombredeusuario;
        }

        // METODOS ABSTRACTOS QUE IMPLEMENTAMOS 
        public abstract void EnviarMensaje(string mensaje);
        public abstract void RecibirMensaje(string mensaje);

        // OBTENEMOS EL NOMBRE DE USUARIO
        public string Obtenernombredeusuario() => NombredeUsuario;



    }
}