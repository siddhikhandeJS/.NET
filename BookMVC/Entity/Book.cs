using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BookProject.Entities;

[Serializable]
[Table("Book")]
public class Book{
    [Key]
    public int BId;
    [NotNull]
    public string Name{get;set;}
    [NotNull]
    public string Author{get;set;}
    [NotNull]
    public double Price{get;set;}
    [NotNull]
    public string Publication{get;set;}
    public override string ToString()
    {
        return BId+" "+Name+" "+Author+" "+Price+" "+Publication;
    }
}