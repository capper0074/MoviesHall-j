using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesHalløj.MVVM.Model
{
    public class MovieRepo
    {
        private string filePath = @"";

        List<string> Strings = new List<string>();

        public void load()
        {
            string text;

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while((text = sr.ReadLine()) != null)
                    {
                        string[] data = text.Split(",", StringSplitOptions.RemoveEmptyEntries);
                        string name = data[3];
                        Strings.Add(name);
                    }
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e);

            }
        }
        public void GetMovies()
        {
            for (int i = 0; i < Strings.Count; i++)
            {
                Console.WriteLine(Strings[i]);
            }
        }
    }

}
