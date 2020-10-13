using System;
namespace Class_2._5
{
    public class FieldsVsProperties
    {
        // This is a field
        private string field1;

        // This will be used in property2 below
        private string property2;

        // Setter for the field
        public void SetField1(String field1)
        {
            this.field1 = field1;
        }

        // Getter for the field
        public string GetField1()
        {
            return field1;
        }

        // This is an automatic property, it includes a simple getter and setter for the property Property1
        // Note: There is a field backing this behind the scenes, we just can't see it!
        public string Property1 { get; set; }

        // This is a property with a field backing it via property2 above
        public string Property2
        {
            get {
                return property2;
                }
            set {
                // Note: value is the default for the setter, the "value" that's passed in
                if(value != null && value != "")
                {
                    property2 = value;
                }
            }

        }
    }
}
