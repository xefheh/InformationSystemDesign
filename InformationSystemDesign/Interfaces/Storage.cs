

using System.ComponentModel;
using System.Data.Entity;
using System.Drawing.Text;
using Accessibility;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Enumerators;
using Microsoft.EntityFrameworkCore;

namespace InformationSystemDesign.Interfaces
{
    public class Storage
    {
        private readonly InspectionContext _context;

        public Storage(InspectionContext context)
        {
            _context = context;
            _context.AnimalCards.Load();
            _context.OrganizationCards.Load();
            _context.MunicipalCards.Load();
            _context.InspectionCards.Load();
        }

        public void AddAnimalCard(AnimalCard animalCard)
        {
            _context.AnimalCards.Add(animalCard);
            _context.SaveChanges();
        }

        public void AddMunicipalCard(MunicipalCard municipalCard)
        {
            _context.MunicipalCards.Add(municipalCard);
            _context.SaveChanges();
        }

        public void AddOrganizationCard(OrganizationCard organizationCard)
        {
            _context.OrganizationCards.Add(organizationCard);
            _context.SaveChanges();
        }

        public void RemoveAnimalCard(AnimalCard animalCard)
        {
            _context.AnimalCards.Remove(animalCard);
            _context.SaveChanges();
        }

        public void RemoveMunicipalCard(MunicipalCard municipalCard)
        {
            _context.MunicipalCards.Remove(municipalCard);
            _context.SaveChanges();
        }

        public void RemoveOrganizationCard(OrganizationCard organizationCard)
        {
            _context.OrganizationCards.Remove(organizationCard);
            _context.SaveChanges();

        }

        public void SaveUpdates()
        {
            _context.SaveChanges();
        }

        public AnimalCard GetAnimalCard(object id) =>
            _context.AnimalCards.Find(id);

        public MunicipalCard GetMunicipalCard(object id) =>
            _context.MunicipalCards.Find(id);

        public OrganizationCard GetOrganizationCard(object id) =>
            _context.OrganizationCards.Find(id);

        public BindingList<AnimalCard> GetAnimalCards() => _context.AnimalCards.Local.ToBindingList();

        public IEnumerable<InspectionCard> GetInspectionCardById(int id) =>
            _context.InspectionCards.Local.Where(x => x.AnimalRegNumber == id);

        public BindingList<AnimalCard> GetAnimalCards(Predicate<AnimalCard>[] filters)
        {
            return _context.AnimalCards.Local.ToBindingList();
        }

        public BindingList<MunicipalCard> GetMunicipalCards() => _context.MunicipalCards.Local.ToBindingList();

        public BindingList<OrganizationCard> GetOrganizationCards() => _context.OrganizationCards.Local.ToBindingList();
    }
}