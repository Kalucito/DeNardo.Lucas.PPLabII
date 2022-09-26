﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Usuario
    {
        #region Atributos

        private string nombreCompleto;
        private string email;
        private string contraseña;
        private eTipoDeUsuario tipoDeUsuario;
        #endregion

        public Usuario(string nombreCompleto, string email, string contraseña, eTipoDeUsuario tipoDeUsuario)
        {
            this.nombreCompleto = nombreCompleto; 
            this.email = email;
            this.contraseña = contraseña;
            this.tipoDeUsuario = tipoDeUsuario;
        }

        #region Propiedades
        public string Email
        {
            get { return this.email; }
        }
        public string Contraseña
        {
            get { return this.contraseña; }
        }
        #endregion


        public enum eTipoDeUsuario
        {
            Vendedor,
            Dueño
        }
    }
}
