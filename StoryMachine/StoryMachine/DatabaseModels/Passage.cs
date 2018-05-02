using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryMachine.DatabaseModels
{
    public class Passage
    {
        internal static string text;
        internal int id;

        public static string Words{ get; internal set; }
        public int Id { get; set; }
        public int StoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        internal static void ShowDialog(object p)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Button(Passage v)
        {
            throw new NotImplementedException();
        }

        internal class Text
        {
            public int id { get; set; }
            public int Id { get; internal set; }
        }
    }
}
