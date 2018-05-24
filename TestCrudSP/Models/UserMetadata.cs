using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestCrudSP.Models
{
    public class UserMetadata
    {
        [Required]
        [Display(Name = "Id Usuario")]
        public int cod_usuario { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre de usuario")]
        public string txt_user { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Contraseña")]
        public string txt_password { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name = "Nombre")]
        public string txt_nombre { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name = "Appellido")]
        public string txt_apellido { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Documento")]
        public string nro_doc { get; set; }
        public Nullable<int> cod_rol { get; set; }
        [Display(Name = "Activo")]
        public Nullable<int> sn_activo { get; set; }

    }

    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
    }

}