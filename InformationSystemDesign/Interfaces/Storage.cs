

using System.Drawing.Text;
using Accessibility;
using InformationSystemDesign.Cards;
using Microsoft.EntityFrameworkCore;

namespace InformationSystemDesign.Interfaces
{
    public class Storage
    {
        private readonly DbSet<AnimalCard> _animalCards;
        private readonly DbSet<MunicipalCard> _municipalCards;
        private readonly DbSet<OrganizationCard> _organizationCards;

        public Storage(DbSet<AnimalCard> animalCards,
            DbSet<MunicipalCard> municipalCards,
            DbSet<OrganizationCard> organizationCards)
        {
            _animalCards = animalCards;
            _municipalCards = municipalCards;
            _organizationCards = organizationCards;
        }

        public void AddAnimalCard(AnimalCard animalCard) =>
            _animalCards.Add(animalCard);

        public void AddMunicipalCard(MunicipalCard municipalCard) =>
            _municipalCards.Add(municipalCard);

        public void AddOrganizationCard(OrganizationCard organizationCard) =>
            _organizationCards.Add(organizationCard);
        public void RemoveAnimalCard(AnimalCard animalCard) =>
            _animalCards.Remove(animalCard);

        public void RemoveMunicipalCard(MunicipalCard municipalCard) =>
            _municipalCards.Remove(municipalCard);

        public void RemoveOrganizationCard(OrganizationCard organizationCard) =>
            _organizationCards.Remove(organizationCard);

        public AnimalCard GetAnimalCard(int id) =>
            _animalCards.Find(id);

        public MunicipalCard GetMunicipalCard(int id) =>
            _municipalCards.Find(id);

        public OrganizationCard GetOrganizationCard(int id) =>
            _organizationCards.Find(id);

        public IList<AnimalCard> GetAnimalCards() => _animalCards.ToList();

        public IList<MunicipalCard> GetMunicipalCards() => _municipalCards.ToList();

        public IList<OrganizationCard> GetOrganizationCards() => _organizationCards.ToList();
    }
}