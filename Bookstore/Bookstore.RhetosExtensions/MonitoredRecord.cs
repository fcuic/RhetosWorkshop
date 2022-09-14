using Rhetos.Dsl;
using Rhetos.Dsl.DefaultConcepts;
using System.ComponentModel.Composition;

namespace Bookstore.RhetosExtensions
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("MonitoredRecord")]
    public class MonitoredRecord : IConceptInfo
    {
        [ConceptKey]
        public EntityInfo Entity { get; set; }
    }

    [Export(typeof(IConceptMacro))]
    public class MonitoredRecordMacro : IConceptMacro<MonitoredRecord>
    {
        public IEnumerable<IConceptInfo> CreateNewConcepts(MonitoredRecord conceptInfo, IDslModel existingConcepts)
        {
            var newConcepts = new List<IConceptInfo>();

            var createdAtProperty = new DateTimePropertyInfo
            {
                DataStructure = conceptInfo.Entity,
                Name = "CreatedAt"
            };

            newConcepts.Add(createdAtProperty);

            newConcepts.Add(new CreationTimeInfo
            {
                Property = createdAtProperty
            });

            newConcepts.Add(new DenyUserEditPropertyInfo()
            {
                Property = createdAtProperty
            });

            var entityLoggingInfo = new EntityLoggingInfo()
            {
                Entity = conceptInfo.Entity
            };

            newConcepts.Add(entityLoggingInfo);

            newConcepts.Add(new AllPropertiesLoggingInfo
            {
                EntityLogging = entityLoggingInfo
            });

            return newConcepts;
        }
    }
}
