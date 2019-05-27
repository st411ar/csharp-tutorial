using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp6Tutorial
{
    public class Path : IEnumerable<SampleEntity>
    {
        private List<SampleEntity> sampleEntities = new List<SampleEntity>();
        public IEnumerator<SampleEntity> GetEnumerator() => sampleEntities.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => sampleEntities.GetEnumerator();

        public void Add(SampleEntity sampleEntity) => sampleEntities.Add(sampleEntity);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (SampleEntity item in sampleEntities)
            {
                sb.Append($"{item}, ");
            }
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }
    }
}