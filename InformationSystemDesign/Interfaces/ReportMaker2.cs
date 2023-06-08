using InformationSystemDesign.Cards;
using InformationSystemDesign.Controllers;
using System.ComponentModel;

namespace InformationSystemDesign.Interfaces
{
    internal class ReportMaker2
    {
        private readonly AnimalRegistryController _controller;

        public ReportMaker2(AnimalRegistryController controller)
        {
            _controller = controller;
        }

        public Report MakeReport(DateTime startTime, DateTime endTime)
        {
            var animalCards = _controller.GetCards().ToList();
            var inspectionCards =
                animalCards.Select(animalCard => _controller.GetInspectionCardByAnimalId(animalCard.RegNumber).Where(
                    inspection => inspection.InspectionDate >= startTime &&
                                  inspection.InspectionDate <= endTime)).ToList();

            var diseasesPriceAndCount = CalculateDiseasesPriceAndCount(animalCards, inspectionCards);
            var finishPriceForLocale = CalculeteFinishPriceForLocale(diseasesPriceAndCount);
            var finishPrice = CalculeteFinishPrice(finishPriceForLocale);

            var result = new List<ReportValue2>();
            foreach (var localePriceAndCount in diseasesPriceAndCount)
            {
                foreach(var diseasePriceAndCount in localePriceAndCount.Value)
                {
                    result.Add(new ReportValue2
                    (
                        localePriceAndCount.Key,
                        diseasePriceAndCount.Key,
                        diseasePriceAndCount.Value.Item1,
                        diseasePriceAndCount.Value.Item2
                    ));
                }  
            }
            var report = new Report(result, finishPrice);
            return report;
        }

        private Dictionary<string, Dictionary<string, (double, int)>> CalculateDiseasesPriceAndCount(List<AnimalCard> cards,
            List<IEnumerable<InspectionCard>> inspectionCards)
        {
            var dictionary = new Dictionary<string, Dictionary<string, (double, int)>>();
            for (var i = 0; i < cards.Count; i++)
            {
                if (!dictionary.ContainsKey(cards[i].GetLocale())) dictionary.Add(cards[i].GetLocale(), new Dictionary<string, (double, int)>());
                var currentInspectionCards = inspectionCards[i].ToList();
                var diseases = currentInspectionCards.Select(x => x.Diagnosis).ToList();
                for (int j = 0; j < diseases.Count(); j++)
                {
                    if (!dictionary[cards[i].GetLocale()].ContainsKey(diseases[i])) dictionary[cards[i].GetLocale()].Add(diseases[i], (0, 0));
                    var price = currentInspectionCards[j].MunicipalContract.GetPrice(cards[i].GetLocale());
                    var priceAndCount = dictionary[cards[i].GetLocale()][diseases[i]];
                    priceAndCount.Item1 += price;
                    priceAndCount.Item2 += 1;
                }
            }
            return dictionary;
        }

        private Dictionary<string, double> CalculeteFinishPriceForLocale(Dictionary<string, Dictionary<string, (double, int)>> diseasesPriceAndCount)
        {
            var dictionary = new Dictionary<string, double>();
            foreach (var locale in diseasesPriceAndCount.Keys)
            {
                var finishPrice = diseasesPriceAndCount[locale].Select(priceAndCount => priceAndCount.Value.Item1).Sum(price => price);
                dictionary.Add(locale, finishPrice);
            }
            return dictionary;
        }

        private double CalculeteFinishPrice(Dictionary<string, double> finishPrices)
        {
            var finishPrice = 0.0;
            foreach (var localePrice in finishPrices)
                finishPrice += localePrice.Value;
            return finishPrice; 
        }
    }

    public static class MunicipalCardExtensions
    {
        public static double GetPrice(this MunicipalCard card, string locale)
        {
            return (double)card.LocalityCards.First(card => card.Name == locale).InspectionPrice;
        }
    }

    public class ReportValue2
    {
        [DisplayName("Город")]
        public string City { get; set; }

        [DisplayName("Болезнь")]
        public string Disease { get; set; }

        [DisplayName("Количество выявленных болезней")]
        public int DiseasesCount { get; set; }
        [DisplayName("Общая стоимость")]
        public double Price { get; set; }
       
        public ReportValue2(string city, string disease, double price, int diseasesCount)
        {
            City = city;
            DiseasesCount = diseasesCount;
            Price = price;
            Disease = disease;
        }
    }

    public class Report 
    {
        public List<ReportValue2>  ReportValues { get; set; }
        public double FinishPrice { get; set; }

        public Report(List<ReportValue2> reportValues, double finishPrice)
        {
            ReportValues = reportValues;
            FinishPrice = finishPrice;
        }
    }
}
