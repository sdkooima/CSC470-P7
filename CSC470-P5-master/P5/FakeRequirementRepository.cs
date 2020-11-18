using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeRequirementRepository : IRequirementRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_STATEMENT_ERROR = "Statements must have unique values";
        public const string EMPTY_STATEMENT_ERROR = "Statement must have a value";
        public const string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist";
        public const string MISSING_FEATUREID_ERROR = "Must select a feature for this requirement";
        public const string MISSING_PROJECTID_ERROR = "Must select a project for this requirement";

        private static List<Requirement> _requirements = new List<Requirement>();

        public string Add(Requirement requirement)
        {
            return NO_ERROR;
        }
        public List<Requirement> GetAll(int ProjectId)
        {
            return _requirements;
        }
        public string Remove(Requirement requirement)
        {
            return NO_ERROR;
        }
        public string Modify(Requirement requirement)
        {
            return NO_ERROR;
        }
        public Requirement GetRequirementById(int requirementId)
        {
            return _requirements[requirementId];
        }
        public int CountByFeatureId(int featureId)
        {
            return 0;
        }
        public void RemoveByFeatureId(int featureId)
        {

        }
    }
}
