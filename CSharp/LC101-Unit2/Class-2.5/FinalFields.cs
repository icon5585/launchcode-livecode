using System;
namespace Class_2._5
{
    public class FinalFields
    {
        // Final fields!
        // Primitives cannot be changed
        // Objects (classes) can have values within the object changed (by reference), but not the object itself
        public readonly int intValue = 42;
        public readonly double doubleValue;
        public readonly FortyTwo objectValue = new FortyTwo();

        public FinalFields()
        {
        }
    }
}
