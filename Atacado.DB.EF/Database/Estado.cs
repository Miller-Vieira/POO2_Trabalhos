namespace Atacado.DB.EF.Database;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("Estado")]
public partial class Estado
{
    [Key]
    public Int64 CodigoEstado {get; set;} 

    [Unicode(false)]
    public string Nome {get; set;} = null!;

    public string UF {get; set;} = null!;

    Int64 CodigoRegiao {get; set;} 


    public Estado()
    {
              
    }


    


}
