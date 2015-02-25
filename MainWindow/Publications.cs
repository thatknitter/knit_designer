using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KnitDesigner
{
    public class Publications
    {
        public int GroupID { get; set; }
        public string Group { get; set; }

        public virtual List<Women> WSizes { get; set; }
        public virtual List<Men> MSizes { get; set; }
        public virtual List<Child> CSizes { get; set; }
        public virtual List<Baby> BSizes { get; set; }
        public virtual List<Toddler> TSizes { get; set; }
        
    }

    public class Women
    {
        public decimal Xsmall { get; set; }
        public decimal Small { get; set; }
        public decimal Medium { get; set; }
        public decimal Large { get; set; }
        public decimal Xlarge { get; set; }
        public decimal XXlarge { get; set; }
        public decimal XXXlarge { get; set; }
        public decimal XXXXlarge { get; set; }
        public decimal XXXXXlarge { get; set; }

        public int GroupID { get; set; }
        public virtual Publications Group { get; set; }
    }

    public class Men
    {
        public decimal Xsmall { get; set; }
        public decimal Small { get; set; }
        public decimal Medium { get; set; }
        public decimal Large { get; set; }
        public decimal Xlarge { get; set; }
        public decimal XXlarge { get; set; }
        public decimal XXXlarge { get; set; }
        public decimal XXXXlarge { get; set; }
        public decimal XXXXXlarge { get; set; }

        public int GroupID { get; set; }
        public virtual Publications Group { get; set; }
    }

    public class Child
    {
        public decimal Xsmall { get; set; }
        public decimal Small { get; set; }
        public decimal Medium { get; set; }
        public decimal Large { get; set; }
        public decimal Xlarge { get; set; }
        public decimal XXlarge { get; set; }

        public int GroupID { get; set; }
        public virtual Publications Group { get; set; }
    }

    public class Baby
    {
        public decimal P { get; set; }
        public decimal NB { get; set; }
        public decimal ThreeM { get; set; }
        public decimal SixM { get; set; }
        public decimal NineM { get; set; }
        public decimal TwelveM { get; set; }
        public decimal EighteenM { get; set; }
        public decimal TwentyfourM { get; set; }

        public int GroupID { get; set; }
        public virtual Publications Group { get; set; }
    }

    public class Toddler
    {
        public decimal TwoT { get; set; }
        public decimal ThreeT { get; set; }
        public decimal FourT { get; set; }
        public decimal FiveT { get; set; }

        public int GroupID { get; set; }
        public virtual Publications Group { get; set; }
    }

    public class PublicationContext : DbContext
    {
        public DbSet<Publications> Groups { get; set; }
        public DbSet<Women> WomenSize { get; set; }
        public DbSet<Men> MenSize { get; set; }
        public DbSet<Child> ChildSize { get; set; }
        public DbSet<Baby> BabySize { get; set; }
        public DbSet<Toddler> ToddlerSize { get; set; }
    }
}
