using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Protocol.Plugins;

namespace DoanThiQuynhChi114.Models;
public class Sinhvien
{
    public string? PersonID { get; set; }
    [ForeignKey("PersonID")]
    public Person? Person { get; set; }
    public string Fullname { get; set; }
    public string Address { get; set; }

}