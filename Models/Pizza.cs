using System.ComponentModel.DataAnnotations;

namespace RazorPagesPizza.Models;
 //Gör en klass för pizza
public class Pizza
{
    //Varje pizza har ett id, konstruktor
    public int Id { get; set; }

    [Required]
    
    //har namn, ? kan vara null 
    public string? Name { get; set; }
    
    //Pizzasize är egen enum
    public PizzaSize Size { get; set; }
    public bool IsGlutenFree { get; set; }

    [Range(0.01, 9999.99)]
    public decimal Price { get; set; }
}

public enum PizzaSize { Small, Medium, Large }