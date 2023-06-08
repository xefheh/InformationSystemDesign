using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace InformationSystemDesign.Cards
{
    [PrimaryKey(nameof(Number))]
    public class MunicipalCard
    {
        public MunicipalCard(DateTime signDate, 
            DateTime validateDate, string executor, string customer)
        {
            SignDate = signDate;
            ValidateDate = validateDate;
            Executor = executor;
            Customer = customer;
        }

        [DisplayName("Номер")]
        public int Number { get; set; }
        [DisplayName("Дата заключения")]
        public DateTime SignDate { get; set; }
        [DisplayName("Дата действия")]
        public DateTime ValidateDate { get; set; }
        [DisplayName("Исполнитель")]
        public string Executor { get; set; }
        [DisplayName("Заказчик")]
        public string Customer { get; set; }

        [Browsable(false)]
        public virtual ICollection<LocalityCard> LocalityCards { get; set; }

        [Browsable(false)]
        public virtual ICollection<InspectionCard> InspectionCards { get; set; }

        public override string ToString() => Number.ToString();
    }
}
