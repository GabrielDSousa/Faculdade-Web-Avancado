using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroDeJogos.db.model
{
    public class Game 
    {
        private Guid id { get; set; }
        private string titulo { get; set; }
        private string genero { get; set; }
        private DateTime dtlancamento { get; set; }
        private string estudio { get; set; }


    }
}