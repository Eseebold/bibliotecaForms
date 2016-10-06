using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using bibliotecaForms.Models;

namespace bibliotecaForms.DAL
{
    interface UsuarioRepository
    {
      
            IList<Usuario> getAll();
            Usuario getById(Guid codigo);
            Usuario update(Usuario usuario)
        
    }
}