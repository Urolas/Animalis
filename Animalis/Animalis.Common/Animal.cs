using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animalis.Common;

public class Animal
{
    [Key]
    [Column("id")]
    public int Id { get; set; }  // Clé primaire

    [Column("animal")]
    [StringLength(26)]
    public string AnimalType { get; set; }

    [Column("height_cm")]
    [StringLength(14)]
    public string HeightCm { get; set; }

    [Column("weight_kg")]
    [StringLength(14)]
    public string WeightKg { get; set; }

    [Column("color")]
    [StringLength(23)]
    public string Color { get; set; }

    [Column("lifespan_years")]
    [StringLength(14)]
    public string LifespanYears { get; set; }

    [Column("diet")]
    [StringLength(22)]
    public string Diet { get; set; }

    [Column("habitat")]
    [StringLength(27)]
    public string Habitat { get; set; }

    [Column("predators")]
    [StringLength(28)]
    public string Predators { get; set; }

    [Column("average_speed_kmh")]
    [StringLength(16)]
    public string AverageSpeedKmh { get; set; }

    [Column("countries_found")]
    [StringLength(37)]
    public string CountriesFound { get; set; }

    [Column("conservation_status")]
    [StringLength(37)]
    public string ConservationStatus { get; set; }

    [Column("family")]
    [StringLength(17)]
    public string Family { get; set; }

    [Column("gestation_period_days")]
    [StringLength(21)]
    public string GestationPeriodDays { get; set; }

    [Column("top_speed_kmh")]
    [StringLength(14)]
    public string TopSpeedKmh { get; set; }

    [Column("social_structure")]
    [StringLength(13)]
    public string SocialStructure { get; set; }

    [Column("offspring_per_birth")]
    [StringLength(17)]
    public string OffspringPerBirth { get; set; }
}
