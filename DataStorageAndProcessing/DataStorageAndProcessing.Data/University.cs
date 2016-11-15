using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorageAndProcessing.Data
{
    public class University
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int NationalRank { get; set; }
        public int QualityofEducation { get; set; }
        public int AlumniEmployment { get; set; }
        public int QualityofFaculty { get; set; }
        public int Publications { get; set; }
        public int Influence { get; set; }
        public int Citations { get; set; }
        public int BroadImpact { get; set; }
        public int Patents { get; set; }
        public double Score { get; set; }
        public University(int Number, List<string> list)
        {
            this.Number = Number;
            Name = list[1];
            Location = list[2];
            NationalRank = int.Parse(list[3]);
            QualityofEducation = STRparse(list[4]);
            AlumniEmployment = STRparse(list[5]);
            QualityofFaculty = STRparse(list[6]);
            Publications = STRparse(list[7]);
            Influence = STRparse(list[8]);
            Citations = STRparse(list[9]);
            if (list.Count == 13)
            {
                BroadImpact = int.Parse(list[10]);
                Patents = STRparse(list[11]);
                Score = double.Parse(list[12].Replace('.', ','));
            }
            else
            {
                Patents = STRparse(list[10]);
                Score = double.Parse(list[11].Replace('.', ','));
            }
        }
        int STRparse(string str)
        {
            if (str.EndsWith("+"))
            {
                return int.Parse(str.Remove(str.Length - 1, 1));
            }
            return int.Parse(str);
        }
    }
}
