using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;


namespace Trabalho1_ProgVis
{
    [Table("Credenciais")]
    public class Credencial
    {
        public UInt64 Id { get; set; }

        public const String SALT = "1FnM6_";

        public String NomeUsuario { get; set; }
        
        private String _senha;

        [Required]
        [StringLength(64)]
        public String Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = ComputeSHA256(value, SALT);
            }
        }
        public Perfil Perfil { get; set; }

        public Usuario Usuario { get; set; }

        public DateTime UltimoAcesso { get; set; }

        #region Hashing
        public static String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, null);
        }

        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(salt + input));

                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }
        #endregion
    }
}
