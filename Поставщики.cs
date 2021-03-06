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
    
    public partial class Поставщики
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Поставщики()
        {
            this.ОсобыеПоставки = new HashSet<ОсобыеПоставки>();
            this.ПоставкиДляБара = new HashSet<ПоставкиДляБара>();
            this.ПоставкиДляКухни = new HashSet<ПоставкиДляКухни>();
            this.РасходнаяУтварь = new HashSet<РасходнаяУтварь>();
        }
    
        public int ID_поставщика { get; set; }
        public string Имя_поставщика { get; set; }
        public int Тип_поставщика { get; set; }
        public string Контактное_лицо { get; set; }
        public string Телефон { get; set; }
        public string Адрес_эл { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ОсобыеПоставки> ОсобыеПоставки { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ПоставкиДляБара> ПоставкиДляБара { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ПоставкиДляКухни> ПоставкиДляКухни { get; set; }
        public virtual ТипПоставщика ТипПоставщика { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<РасходнаяУтварь> РасходнаяУтварь { get; set; }
    }
}
