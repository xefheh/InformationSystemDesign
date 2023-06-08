using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;
using System.ComponentModel;

namespace InformationSystemDesign.ReportCreation
{
    public class ReportMaker
    {
        private readonly IController<InspectionCard> _controller;

        public ReportMaker(IController<InspectionCard> controller) => _controller = controller;

        public Report MakeReport(DateTime startTime, DateTime endTime)
        {
            var inspections = _controller.GetCards();
            var neededInspection = inspections.Where(inspection =>
                CheckInterval(inspection.InspectionDate, startTime, endTime));
            var groupByCityAndDiagnosis = neededInspection.GroupBy(inspection => new
            {
                City = inspection.GetAnimalLocale(),
                Disease = inspection.Diagnosis
            });
            return new Report(groupByCityAndDiagnosis.Select(group =>
            {
                var city = group.Key.City;
                var disease = group.Key.Disease;
                var diseaseCount = group.Count();
                var localities = group.SelectMany(inspectionCard =>
                    inspectionCard.GetMunicipalLocalities());
                return new ReportValue(city, disease, GetGeneralPrice(localities, city, diseaseCount), diseaseCount);
            }).ToList());
        }

        private static decimal GetGeneralPrice(IEnumerable<LocalityCard> localities, string city, int count)
        {
            var currentLocalityPrice = localities.First(locality => locality.Name == city).InspectionPrice;
            return currentLocalityPrice * count;
        }

        private static bool CheckInterval(DateTime current, DateTime start, DateTime end) =>
            start <= current && end >= current;
    }
}