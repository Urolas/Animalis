using Microsoft.AspNetCore.Mvc.RazorPages;
using Animalis.Common;
using Animalis.Database;
using Microsoft.EntityFrameworkCore;

namespace Animalis.WebApp.Pages;

public class AnimalsModel : PageModel
{
    private readonly AppDbContext _context;

    public AnimalsModel(AppDbContext context)
    {
        _context = context;
    }
    public List<Animal> AnimalList { get; set; }

    public void OnGet()
    {
        AnimalList = _context.Animals.ToList();
        /*AnimalList = new List<Animal>
        {
            new Animal { Id = 1, AnimalType = "Lion", HeightCm = "120", WeightKg = "190", Color = "Golden", LifespanYears = "14", Diet = "Carnivore", Habitat = "Savanna", Predators = "None", AverageSpeedKmh = "50", CountriesFound = "Africa", ConservationStatus = "Vulnerable", Family = "Felidae", GestationPeriodDays = "110", TopSpeedKmh = "80", SocialStructure = "Pride", OffspringPerBirth = "3" },
            new Animal { Id = 2, AnimalType = "Elephant", HeightCm = "300", WeightKg = "6000", Color = "Grey", LifespanYears = "60", Diet = "Herbivore", Habitat = "Grassland", Predators = "None", AverageSpeedKmh = "40", CountriesFound = "Africa, Asia", ConservationStatus = "Endangered", Family = "Elephantidae", GestationPeriodDays = "660", TopSpeedKmh = "40", SocialStructure = "Herd", OffspringPerBirth = "1" }
        };*/
    }
}
