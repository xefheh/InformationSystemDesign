using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace InformationSystemDesign.Cards
{
    [PrimaryKey(nameof(Number))]
    internal class MunicipalCard
    {
        public MunicipalCard(int number, DateTime signDate, 
            DateTime validateDate, string executor, string customer)
        {
            Number = number;
            SignDate = signDate;
            ValidateDate = validateDate;
            Executor = executor;
            Customer = customer;
        }

        [DisplayName("Номер")]
        public int Number { get; private set; }
        [DisplayName("Дата заключения")]
        public DateTime SignDate { get; private set; }
        [DisplayName("Дата действия")]
        public DateTime ValidateDate { get; private set; }
        [DisplayName("Исполнитель")]
        public string Executor { get; private set; }
        [DisplayName("Заказчик")]
        public string Customer { get; private set; }
    }
}
