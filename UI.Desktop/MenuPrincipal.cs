﻿using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class MenuPrincipal : ApplicationForm
    {
        public MenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
        }

        public Usuario user { get; set; }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            //Application.Run(new Materias());
            //this.Hide();
            Materias mat = new Materias();
            mat.ShowDialog();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.ShowDialog();
        }
    }
}
