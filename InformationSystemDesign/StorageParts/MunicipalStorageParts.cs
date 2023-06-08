using InformationSystemDesign.Cards;
using System.ComponentModel;

namespace InformationSystemDesign.StorageParts;

public partial class Storage
{
    public void AddMunicipalCard(MunicipalCard municipalCard)
    {
        _context.MunicipalCards.Add(municipalCard);
        _context.SaveChanges();
    }
    public void RemoveMunicipalCard(MunicipalCard municipalCard)
    {
        _context.MunicipalCards.Remove(municipalCard);
        _context.SaveChanges();
    }

    public MunicipalCard GetMunicipalCard(object id) =>
        _context.MunicipalCards.Find(id);

    public BindingList<MunicipalCard> GetMunicipalCards() => _context.MunicipalCards.Local.ToBindingList();
}