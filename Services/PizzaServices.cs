using RazorPagesPizza.Models;

namespace RazorPagesPizza.Services;
public static class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static int nextId = 3;
    static PizzaService()
    {
        //Vi gör några "defaultpizzor" som alltid dyker upp 
        Pizzas = new List<Pizza>
                {
                    new Pizza { Id = 1, Name = "Classic Italian", Price=20.00M, Size=PizzaSize.    Large, IsGlutenFree = false },
                    new Pizza { Id = 2, Name = "Veggie", Price=15.00M, Size=PizzaSize.Small,     IsGlutenFree = true }
                };
    }

    //Lägger till alla objekt av typen Pizza i våran lista?
    public static List<Pizza> GetAll() => Pizzas;

    //Varje pizza får ett Id som antingen är första godtyckliga eller default
    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    //Här ökar vi pizza-Id med 1 för varje pizza som läggs till
    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }

    //Denna funktion tar bort pizzan från listan (om den existerar)
    public static void Delete(int id)
    {
        var pizza = Get(id);
        if (pizza is null)
            return;

        Pizzas.Remove(pizza);
    }

    //Vi uppdaterar pizzans plats i listan. 
    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if (index == -1)
            return;

        Pizzas[index] = pizza;
    }
                }