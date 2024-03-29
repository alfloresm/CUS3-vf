﻿using System;
using System.Collections.Generic;

namespace CUS3_V4.Models
{
    public partial class TUsuario
    {
        public TUsuario()
        {
            TUsuarioModalidadFkIuDniNavigation = new HashSet<TUsuarioModalidad>();
            TUsuarioModalidadFkIuDniParejaNavigation = new HashSet<TUsuarioModalidad>();
        }

        public int PkIuDni { get; set; }
        public string VuNombre { get; set; }
        public string VuApaterno { get; set; }
        public string VuAmaterno { get; set; }
        public DateTime? DuFechaNacimiento { get; set; }
        public string VuContraseña { get; set; }
        public string VuSexo { get; set; }
        public string VuNacademia { get; set; }
        public int? FkIuCodCategoria { get; set; }
        public int? FkItuTipoUsuario { get; set; }
        public int? FkIuIdEstado { get; set; }
        public string VuFoto { get; set; }

        public TTipoUsuario FkItuTipoUsuarioNavigation { get; set; }
        public TCategoria FkIuCodCategoriaNavigation { get; set; }
        public TEstadoCon FkIuIdEstadoNavigation { get; set; }
        public ICollection<TUsuarioModalidad> TUsuarioModalidadFkIuDniNavigation { get; set; }
        public ICollection<TUsuarioModalidad> TUsuarioModalidadFkIuDniParejaNavigation { get; set; }
    }
}
