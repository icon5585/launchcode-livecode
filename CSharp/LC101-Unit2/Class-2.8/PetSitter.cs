using System;
namespace Class_2._8
{
    public class PetSitter
    {
        // We can use interfaces as properties
        // What this is essentially saying is that the property "Pet" must be a 
        // class that implements IFeedable
        public IFeedable Pet { get; set; }

        public PetSitter(IFeedable pet)
        {
            Pet = pet;
        }

        public void FeedThePet()
        {
            Pet.Eat();
        }
    }

    // Note: You can create multiple classes inside one file...
    public class CatSitter : PetSitter
    {
        public CatSitter(IFeedable pet) : base(pet)
        {
            Pet = pet;
        }
    }
}
