//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Application_Khinkalnaya
{
    using System;
    using System.Collections.Generic;
    
    public partial class ПоставкиДляКухни
    {
        public int ID_поставки { get; set; }
        public int Тип_поставки { get; set; }
        public int Поставщик { get; set; }
        public string Описание { get; set; }
        public System.DateTime Дата { get; set; }
        public int Ответственный { get; set; }
    
        public virtual ОтветственныйЗаПоставки ОтветственныйЗаПоставки { get; set; }
        public virtual Поставщики Поставщики { get; set; }
        public virtual ТипПоставки ТипПоставки { get; set; }
    }
}
