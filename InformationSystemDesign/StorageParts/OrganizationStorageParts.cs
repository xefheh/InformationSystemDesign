using InformationSystemDesign.Cards;
using System.ComponentModel;

namespace InformationSystemDesign.StorageParts;

public partial class Storage
{
    public void AddOrganizationCard(OrganizationCard organizationCard)
    {
        _context.OrganizationCards.Add(organizationCard);
        _context.SaveChanges();
    }

    public void RemoveOrganizationCard(OrganizationCard organizationCard)
    {
        _context.OrganizationCards.Remove(organizationCard);
        _context.SaveChanges();
    }

    public OrganizationCard GetOrganizationCard(object id) =>
        _context.OrganizationCards.Find(id);

    public BindingList<OrganizationCard> GetOrganizationCards() => _context.OrganizationCards.Local.ToBindingList();

}