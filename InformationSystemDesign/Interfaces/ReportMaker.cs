using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Controllers;

namespace InformationSystemDesign.Interfaces
{ 
    public class ReportMaker
    {
        private readonly AnimalRegistryController _controller;

        public ReportMaker(AnimalRegistryController controller) => _controller = controller;

        public List<ReportValue> MakeReport(DateTime startTime, DateTime endTime)
        {
            var animalCards = _controller.GetCards().ToList();
            var inspectionCards =
                animalCards.Select(animalCard => _controller.GetInspectionCardByAnimalId(animalCard.RegNumber).Where(
                    inspection => inspection.InspectionDate >= startTime && 
                                  inspection.InspectionDate <= endTime)).ToList();
            var count = CalculateInspectionsCount(animalCards, inspectionCards);
            var helpCount = CalculateHelpingCount(animalCards, inspectionCards);
            var needCount = CalculateNeedHelpCount(animalCards, inspectionCards);
            var result = count.Select(pair => new ReportValue(pair.Key,
                count[pair.Key], helpCount[pair.Key], needCount[pair.Key])).ToList();
            return result.ToList();
        }

        public Dictionary<string, int> CalculateInspectionsCount(List<AnimalCard> cards, List<IEnumerable<InspectionCard>> inspectionCards)
        {
            var dictionary = new Dictionary<string, int>();
            for (var i = 0; i < cards.Count; i++)
            {
                if (!dictionary.ContainsKey(cards[i].GetLocale())) dictionary.Add(cards[i].GetLocale(), 0);
                dictionary[cards[i].GetLocale()]+=inspectionCards[i].Count();
            }
            return dictionary;
        }

        public Dictionary<string, int> CalculateHelpingCount(List<AnimalCard> cards,
            List<IEnumerable<InspectionCard>> inspectionCards)
        {
            var dictionary = new Dictionary<string, int>();
            for (var i = 0; i < cards.Count; i++)
            {
                if (!dictionary.ContainsKey(cards[i].GetLocale())) dictionary.Add(cards[i].GetLocale(), 0);
                dictionary[cards[i].GetLocale()] += inspectionCards[i].Count(card => card.IsAssignedHelp);
            }
            return dictionary;
        }
        public Dictionary<string, int> CalculateNeedHelpCount(List<AnimalCard> cards,
            List<IEnumerable<InspectionCard>> inspectionCards)
        {
            var dictionary = new Dictionary<string, int>();
            for (var i = 0; i < cards.Count; i++)
            {
                if (!dictionary.ContainsKey(cards[i].GetLocale())) dictionary.Add(cards[i].GetLocale(), 0);
                dictionary[cards[i].GetLocale()] += inspectionCards[i].Count(card => card.IsNeedHelp);
            }
            return dictionary;
        }

    }

    public class ReportValue
    {
        [DisplayName("Город")]
        public string City { get; set; }
        [DisplayName("Количество осмотров")]
        public int InspectionsCount { get; set; }
        [DisplayName("Количество оказанной помощи")]
        public int HelpingCount { get; set; }
        [DisplayName("Количество необходимой помощи")]
        public int NeedHelpCount { get; set; }
        [DisplayName("Количество неоказанной помощи")]
        public int NotHelpingCount { get; set; }

        public ReportValue(string city, int inspectionsCount, int helpingCount, int needHelpCount)
        {
            City = city;
            InspectionsCount = inspectionsCount;
            HelpingCount = helpingCount;
            NeedHelpCount = needHelpCount;
            NotHelpingCount = needHelpCount - helpingCount;
        }
    }
}
