using Rhetos.Dsl;
using Rhetos.Dsl.DefaultConcepts;
using System.ComponentModel.Composition;

namespace Bookstore.RhetosExtensions
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("CodeTable")]
    public class CodeTable : IConceptInfo
    {
        [ConceptKey]
        public EntityInfo Entity { get; set; }
    }

    [Export(typeof(IConceptMacro))]
    public class CodeTableMacro : IConceptMacro<CodeTable>
    {
        public IEnumerable<IConceptInfo> CreateNewConcepts(CodeTable conceptInfo, IDslModel existingConcepts)
        {
            var newConcepts = new List<IConceptInfo>();

            //ShortString Code {AutoCode;}
            //ShortString Name {Required;}

            var codeProperty = new ShortStringPropertyInfo
            {
                DataStructure = conceptInfo.Entity,
                Name = "Code"
            };

            newConcepts.Add(codeProperty);

            newConcepts.Add(new AutoCodePropertyInfo 
            {
                Property = codeProperty
            });

            var nameProperty = new ShortStringPropertyInfo
            {
                DataStructure = conceptInfo.Entity,
                Name = "Name"
            };

            newConcepts.Add(nameProperty);

            newConcepts.Add(new RequiredPropertyInfo()
            {
                Property = nameProperty
            });
            
            return newConcepts;
        }
    }
}