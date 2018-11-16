using System;

namespace StockManagementFormUI.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CompanyName { get; set; }
        public DateTime FromDateTimePicker { get; set; }
        public DateTime ToDateTimePicker { get; set; }
    }
}
