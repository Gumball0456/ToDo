using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model;

public class TodoItem 
{
    public long Id { get; set; }
    
    [Column(TypeName="text")] // necessary due to sqlite 
    public string? Title { get; set; }
    [Column(TypeName="text")] // necessary due to sqlite
    public string? Description { get; set; }
    public bool Complete { get; set; }
}
