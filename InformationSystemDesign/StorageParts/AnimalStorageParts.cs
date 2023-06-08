using InformationSystemDesign.Cards;
using System.ComponentModel;

namespace InformationSystemDesign.StorageParts;

public partial class Storage
{
    public void AddAnimalCard(AnimalCard animalCard)
    {
        _context.AnimalCards.Add(animalCard);
        _context.SaveChanges();
    }

    public void RemoveAnimalCard(AnimalCard animalCard)
    {
        _context.AnimalCards.Remove(animalCard);
        _context.SaveChanges();
    }

    public AnimalCard GetAnimalCard(object id) =>
        _context.AnimalCards.Find(id);

    public BindingList<AnimalCard> GetAnimalCards() => _context.AnimalCards.Local.ToBindingList();
}