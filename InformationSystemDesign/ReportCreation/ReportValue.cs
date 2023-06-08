using System.ComponentModel;

namespace InformationSystemDesign.ReportCreation;

public class ReportValue
{
    [DisplayName("Город")] public string City { get; set; }

    [DisplayName("Болезнь")] public string Disease { get; set; }

    [DisplayName("Количество выявленных болезней")] public int DiseasesCount { get; set; }

    [DisplayName("Общая стоимость")] public decimal Price { get; set; }

    public ReportValue(string city, string disease, decimal price, int diseasesCount)
    {
        City = city;
        DiseasesCount = diseasesCount;
        Price = price;
        Disease = disease;
    }
}
