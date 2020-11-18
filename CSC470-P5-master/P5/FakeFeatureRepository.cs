using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeFeatureRepository : IFeatureRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_TITLE_ERROR = "Title must be unique";
        public const string EMPTY_TITLE_ERROR = "Title must have a value";
        public const string NOT_FOUND_ERROR = "Feature not found";
        public const string INVALID_PROJECT_ID_ERROR = "Invalid Project Id for Feature";
        private static List<Feature> _features = new List<Feature>();

        public FakeFeatureRepository()
        {
            _features.Add(new Feature
            {
                Id = 1,
                ProjectId = 1,
                Title = "A Real Feature"
            }) ;
        }
        public string Add(Feature feature)
        {

            return NO_ERROR;
        }

        public List<Feature> GetAll(int ProjectId)
        {
            return _features;
        }

        public string Remove(Feature feature)
        {
            return NO_ERROR;
        }
        public string Modify(Feature feature)
        {
            return NO_ERROR;
        }
        public Feature GetFeatureById(int featureId)
        {
            return _features[featureId];
        }
        public Feature GetFeatureByTitle(string title)
        {
            foreach (Feature feature in _features)
            {
                if (feature.Title == title)
                    return feature;
            }
            return _features[0];
        }

    }
}
