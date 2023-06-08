using InformationSystemDesign.Cards;
using InformationSystemDesign.Initialization;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace InformationSystemDesign.StorageParts
{
    public partial class Storage
    {
        private readonly InspectionContext _context;

        public Storage(InspectionContext context)
        {
            _context = context;
            _context.AnimalCards.Load();
            _context.OrganizationCards.Load();
            _context.InspectionCards.Load();
            _context.MunicipalCards.Include(municipalCard => municipalCard.LocalityCards).Load();
            _context.MunicipalCards.Load();
            _context.LocalityCards.Load();
        }

        public void SaveUpdates() => _context.SaveChanges();

        public BindingList<LocalityCard> GetLocalitiesCards() => _context.LocalityCards.Local.ToBindingList();
    }
}