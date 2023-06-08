using System.ComponentModel;
using InformationSystemDesign.Cards;

namespace InformationSystemDesign.StorageParts;

public partial class Storage
{
    public void AddInspectionCard(InspectionCard inspectionCard)
    {
        _context.InspectionCards.Add(inspectionCard);
        _context.SaveChanges();
    }

    public void RemoveInspectionCard(InspectionCard inspectionCard)
    {
        _context.InspectionCards.Remove(inspectionCard);
        _context.SaveChanges();
    }

    public InspectionCard GetInspectionCard(object id) => _context.InspectionCards.Find(id);

    public BindingList<InspectionCard> GetInspectionCards() =>
        _context.InspectionCards.Local.ToBindingList();
}