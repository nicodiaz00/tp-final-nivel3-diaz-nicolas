using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public enum TipoUsuario
    {
        NORMAL = 0,
        ADMIN = 1
    }
    public class Usuario
    {
        public string Nombre { get; set; }  
        public string Apellido { get; set; } 
        public string UrlImagen { get; set; }
        public int Id {  get; set; }
        public string Pass {  get; set; }
        public string Email { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        public Usuario(string email, string pass)
        {
            Email = email;
            Pass = pass;
            
            
            
        }

        public Usuario() { }
    }
}
