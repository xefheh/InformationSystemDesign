﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InformationSystemDesign.Enumerators
{
    public enum AnimalType
    {
        Собака,
        Кошка
    }

    public enum OwnerFeatures
    {
        Одежда,
        Чип,
        Ошейник,
        Шлейка
    }

    public enum Sex
    {
        Мужской,
        Женский
    }

    public enum OwnerType
    {
        ИП,
        ЮрЛицо
    }

    public enum OrganizationType
    {
        ИсполнительныйОрганГосВласти,
        ОрганМестногоСамоуправ,
        Приют,
        ОрганизацияПоОтлову,
        ОрганизацияПоОтловуИПриют,
        ОрганизацияПоТранспортировке,
        ВетеринарнаяКлиникаГос,
        ВетеринарнаяКлиникаМуниц,
        ВетеринарнаяКлиникаЧаст,
        БлаготворительныйФонд,
        ОрганизацияПоПродажеТоваровИПредставлениюУслугДляЖивотных
    }

    public enum UserType
    {
        КураторВетСлужбы,
        КураторПоОтлову,
        КураторПриюта,
        ПодписантВетСлужбы,
        ПодписантПоОтлову,
        ПодписантПриюта,
        КураторОМСУ,
        ПодписантОМСУ,
        ОператорВетСлужбы,
        ОператорОМСУ,
        ВетВрач,
        ОператорПриюта,
        ВетВрачПриюта
    }
}
