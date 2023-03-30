namespace Atacado.DB.EF.Database;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class Cidade
{
    [Key]
   public Int64 CodigoCidade {get; set;}

    [Unicode(false)]
   public string Nome {get; set;} = null!;

   public Int64 CodigoIBGE7 {get;set;} 

   public Int64 CodigoEstado {get; set;}


   public Cidade()
   {
      
   }
}


