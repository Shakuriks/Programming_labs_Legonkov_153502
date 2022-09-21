using System.Collections;

namespace Lab5progsem3.Domain
{
    [Serializable]
    public class RailwayStation : IEnumerable
    {
        List<Bagage> bagages = new List<Bagage>();

        public void AddBagage(int id, int weight)
        {
            bagages.Add(new Bagage { Id = id, Weight = weight });
        }

        public IEnumerator GetEnumerator() => bagages.GetEnumerator();
    }
}