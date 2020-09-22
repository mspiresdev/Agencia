using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
   public class BaseModel
    {
        private DateTime agora = DateTime.Now;

        public int Id { get; set; }
        public DateTime Registro
        {
            get
            {
                return agora;
            }
            set
            {
                agora = value;
            }
        }

        public bool? Visivel { get; set; }

        public DateTime UltimaAtualizacao {
            get
            {
                return agora;
            }
            set
            {
                agora = value;
            }
        } 
    }
}
