namespace ClassLibraryForTask5
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetHeight(int height);
        ICharacterBuilder SetStature(string stature);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetClothing(string clothing);
        ICharacterBuilder SetInventory(List<string> inventory);
        void DisplayInfo();
    }
}
