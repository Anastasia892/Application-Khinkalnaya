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
    
    public partial class ОтветственныйЗаПоставки
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ОтветственныйЗаПоставки()
        {
            this.ОсобыеПоставки = new HashSet<ОсобыеПоставки>();
            this.ПоставкиДляБара = new HashSet<ПоставкиДляБара>();
            this.ПоставкиДляКухни = new HashSet<ПоставкиДляКухни>();
            this.РасходнаяУтварь = new HashSet<РасходнаяУтварь>();
        }
    
        public int ID_работника { get; set; }
        public string Имя_ответственного { get; set; }
        public string Должность { get; set; }
        public string Телефон { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ОсобыеПоставки> ОсобыеПоставки { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ПоставкиДляБара> ПоставкиДляБара { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ПоставкиДляКухни> ПоставкиДляКухни { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<РасходнаяУтварь> РасходнаяУтварь { get; set; }
    }
}
