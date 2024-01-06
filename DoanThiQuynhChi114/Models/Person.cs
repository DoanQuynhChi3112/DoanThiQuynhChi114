using System.ComponentModel.DataAnnotations;
using NuGet.Protocol.Plugins;

namespace DoanThiQuynhChi114.Models;
public class Person
{
    [Key]
    public string? PersonID { get; set; }
    public int Age { get; set; }
    public DateTime Ngaysinh { get; set; }

}