using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KnitDesigner
{
    public class Projects
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public virtual List<MainWindowContent> MainContent { get; set; }
        public virtual List<SweaterContent> Sweater { get; set; }
    }

    public class MainWindowContent
    {
        public decimal Gauge { get; set; }
        public string Type { get; set; }
        public string Age { get; set; }
        public int YarnAmtPerBall { get; set; }
        public bool Meters { get; set; }
        public bool Yards { get; set; }
        public int BallsUsed { get; set; }
        public decimal Ease { get; set; }
        public string Publisher { get; set; }

        public int ProjectID { get; set; }
        public virtual Projects ProjectName { get; set; }
    }

    public class SweaterContent
    {
        public string Subtype { get; set; }
        public string ShoulderType { get; set; }
        public string Neckline { get; set; }
        public string SizeDesigned { get; set; }
        public decimal Length { get; set; }
        public decimal Hem { get; set; }
        public decimal Bust { get; set; }
        public decimal Waist { get; set; }
        public decimal ShoulderWidth { get; set; }
        public decimal SleeveLength { get; set; }
        public decimal SleeveWidth { get; set; }

        public int ProjectID { get; set; }
        public virtual Projects ProjectName { get; set; }
    }
}
