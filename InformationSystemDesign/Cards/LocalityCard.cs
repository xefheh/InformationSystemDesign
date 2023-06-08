using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InformationSystemDesign.Cards;

[Table("Locality")]
public class LocalityCard
{
    [Browsable(false), Key]
    public int LocalityIdentity { get; set; }

    [DisplayName("Название города")]
    public string Name { get; set; }

    [DisplayName("Цена осмотра")]
    public decimal InspectionPrice { get; set; }

    [Browsable(false)]
    public ICollection<MunicipalCard> MunicipalCards { get; set; }

    public override string ToString() => Name;
}