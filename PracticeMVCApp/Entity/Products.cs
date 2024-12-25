using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace practicemvc.Entities;

[Serializable]
[Table("Product")]
public class Product{
    [Key]
    public int PId{get;set;}
    [NotNull]
    public string Name{get;set;}
    [NotNull]
    public string Price{get;set;}
    [NotNull]
    public string Type{get;set;}
    [NotNull]
    public string Brand{get;set;}
    public override string ToString()
    {
        return PId+" "+Name+" "+" "+Price+" "+Type+" "+Brand;
    }
}