using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask5
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private int Height { get; set; }
        private string Stature { get; set; }
        private string HairColor { get; set; }
        private string EyeColor { get; set; }
        private string Clothing { get; set; }
        private List<string> Inventory { get; set; }

        public EnemyBuilder()
        {
            Inventory = new List<string>();
        }

        public ICharacterBuilder SetHeight(int height)
        {
            Height = height;
            return this;
        }

        public ICharacterBuilder SetStature(string stature)
        {
            Stature = stature;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            Clothing = clothing;
            return this;
        }

        public ICharacterBuilder SetInventory(List<string> inventory)
        {
            Inventory = inventory;
            return this;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Зріст: {Height} cm");
            Console.WriteLine($"Статура: {Stature}");
            Console.WriteLine($"Колір волосся: {HairColor}");
            Console.WriteLine($"Колір очей: {EyeColor}");
            Console.WriteLine($"Одяг: {Clothing}");
            Console.WriteLine("Інвентар:");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
