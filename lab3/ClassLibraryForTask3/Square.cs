using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask3
{
    public class Square : Shape
    {
        public Square(Renderer renderer) : base(renderer) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing Square " + _renderer.Render());
        }
    }
}
