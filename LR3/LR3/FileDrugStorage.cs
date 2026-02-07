using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class FileDrugStorage : ILoadDrugs
    {
        public List<Drugs> LoadDataFromCsv()
        {
            List<Drugs> result = new List<Drugs>();
            using (StreamReader reader = new StreamReader("data.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] drugInfo = line.Split(';');
                    Drugs drug = new Drugs(drugInfo[0], drugInfo[1], drugInfo[2], drugInfo[3], drugInfo[4], drugInfo[5]);
                    result.Add(drug);
                }
            }
            return result;
        }
    }
}
