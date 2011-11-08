using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
   class Program
   {
      static void Main(string[] args) {
         rec record = new rec { id = 1, mydecimal = null };
         List<rec> records = new List<rec> { record };

         FileHelpers.FileHelperEngine<rec> engine = new FileHelpers.FileHelperEngine<rec>();

         Console.WriteLine(engine.WriteString(records));

      }
   }

   [FileHelpers.DelimitedRecord(",")]
   public class rec
   {
      public int id;
      public decimal? mydecimal;

   }
}
