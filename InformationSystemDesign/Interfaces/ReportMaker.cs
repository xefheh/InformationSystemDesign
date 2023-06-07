using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformationSystemDesign.Controllers;

namespace InformationSystemDesign.Interfaces
{ 
    class ReportMaker
    {
        private AnimalRegistryController _controller;

        public ReportMaker(AnimalRegistryController controller) => _controller = controller;

        public IEnumerable<ReportValue> MakeReport(DateTime startTime, DateTime endTime)
        {
            var animalCards = _controller.GetCards();
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

        public ReportValue(string city, int inspectionsCount, int helpingCount, int needHelpCount,
            int notHelpingCount)
        {
            City = city;
            InspectionsCount = inspectionsCount;
            HelpingCount = helpingCount;
            NeedHelpCount = needHelpCount;
            NotHelpingCount = needHelpCount - helpingCount;
        }
    }
}
