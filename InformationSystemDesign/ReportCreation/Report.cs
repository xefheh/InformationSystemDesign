namespace InformationSystemDesign.ReportCreation;

public class Report
{
    public List<ReportValue> ReportValues { get; set; }
    public decimal GeneralPrice { get; set; }
    public int GeneralDiseasesCount { get; set; }

    public Report(List<ReportValue> reportValues)
    {
        ReportValues = reportValues;
        CalculateGeneralAttributes();
    }

    private void CalculateGeneralAttributes()
    {
        GeneralPrice = 0;
        GeneralDiseasesCount = 0;
        foreach (var reportValue in ReportValues)
        {
            GeneralPrice += reportValue.Price;
            GeneralDiseasesCount += reportValue.DiseasesCount;
        }
    }
}