using System.ComponentModel;
using InformationSystemDesign.Cards;

namespace InformationSystemDesign.Interfaces;

public interface ILocalityRegistry
{
    BindingList<LocalityCard> GetLocalities();
}

public interface ILocalityController
{
    BindingList<LocalityCard> GetLocalities();
}