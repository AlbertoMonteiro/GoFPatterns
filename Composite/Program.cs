using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IComponent pasta = new Pasta(),
                pastaDois = new Pasta(),
                arquivo = new Arquivo(),
                arquivo1 = new Arquivo(),
                arquivo2 = new Arquivo(),
                arquivo3 = new Arquivo(),
                arquivo4 = new Arquivo();
            
            pasta.Add(arquivo);
            pasta.Add(arquivo1);
            pasta.Add(arquivo2);

            pastaDois.Add(arquivo3);
            pastaDois.Add(arquivo4);

            pasta.Add(pastaDois);

            pasta.Display(1);
        }
    }
}
