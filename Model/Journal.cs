//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWork.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journal
    {
        public int id { get; set; }
        public System.DateTime DateTast { get; set; }
        public int IdStudents { get; set; }
        public int IdTest { get; set; }
        public int Mark { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Test Test { get; set; }
    }
}
