﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities; //agregado
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic:BusinessLogic
    {

        private UsuarioAdapter _usuario;
        public UsuarioLogic() //Constructor base
        {

            //UsuarioAdapter _usuario = new UsuarioAdapter();
            _usuario = new UsuarioAdapter();

        }

        public UsuarioAdapter UsuarioData //Propiedad UsuarioData del tipo Data.Database.UsuarioAdapter
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }

        public Usuario GetOne(int ID)
        {
            
             
            return (UsuarioData.GetOne(ID));
        }

        public List<Usuario> GetAll() 
        {
            return UsuarioData.GetAll(); // UsuarioData.GetAll() devuelve ---> return new List<Usuario>(Usuarios);
        }

        public void Save(Usuario usuario)
        {
            UsuarioData.Save(usuario);

        }
        public void Delete(int ID)
        {
            //invocar metodo delete de usuariodata
            UsuarioData.Delete(ID);

        }

        public Usuario GetUsuarioLogin(string user, string pass)
        {
            return UsuarioData.GetUsuarioLogin(user, pass);
        }

        public bool Existe(string user)
        {
            return UsuarioData.Existe(user);
        }


    }
}
