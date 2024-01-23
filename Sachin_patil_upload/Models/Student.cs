
// Student.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Student
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Department is required")]
    public string Department { get; set; }

    [NotMapped]
    public IFormFile? ImageFile { get; set; }

    public string? Image { get; set; } // Assuming you store the image file path or base64 string
}



