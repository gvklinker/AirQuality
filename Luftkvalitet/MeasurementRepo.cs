using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luftkvalitet
{
    public class MeasurementRepo
    {
        List<Measurement> meassurements;
        public MeasurementRepo() {
            meassurements = new List<Measurement>();
        }

        public List<Measurement> GetAll()
        {
            List<Measurement> list = new List<Measurement>(meassurements);

            return list;
        }
        public Measurement GetById(int id)
        {
            return meassurements.Find(m => m.Id == id);
        }
        public void Add(Measurement meassurement)
        {
            meassurement.Validate();
            meassurements.Add(meassurement);
        }
    }
}
