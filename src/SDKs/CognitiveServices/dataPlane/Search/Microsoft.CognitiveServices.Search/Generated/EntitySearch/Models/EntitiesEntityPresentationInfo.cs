// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Search.EntitySearch.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Search;
    using Microsoft.CognitiveServices.Search.EntitySearch;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines additional information about an entity such as type hints.
    /// </summary>
    public partial class EntitiesEntityPresentationInfo
    {
        /// <summary>
        /// Initializes a new instance of the EntitiesEntityPresentationInfo
        /// class.
        /// </summary>
        public EntitiesEntityPresentationInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntitiesEntityPresentationInfo
        /// class.
        /// </summary>
        /// <param name="entityScenario">The supported scenario. Possible
        /// values include: 'DominantEntity', 'DisambiguationItem',
        /// 'ListItem'</param>
        /// <param name="entityTypeHints">A list of hints that indicate the
        /// entity's type. The list could contain a single hint such as Movie
        /// or a list of hints such as Place, LocalBusiness, Restaurant. Each
        /// successive hint in the array narrows the entity's type.</param>
        /// <param name="entityTypeDisplayHint">A display version of the entity
        /// hint. For example, if entityTypeHints is Artist, this field may be
        /// set to American Singer.</param>
        public EntitiesEntityPresentationInfo(EntityScenario entityScenario, IList<EntityType?> entityTypeHints = default(IList<EntityType?>), string entityTypeDisplayHint = default(string))
        {
            EntityScenario = entityScenario;
            EntityTypeHints = entityTypeHints;
            EntityTypeDisplayHint = entityTypeDisplayHint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the supported scenario. Possible values include:
        /// 'DominantEntity', 'DisambiguationItem', 'ListItem'
        /// </summary>
        [JsonProperty(PropertyName = "entityScenario")]
        public EntityScenario EntityScenario { get; set; }

        /// <summary>
        /// Gets a list of hints that indicate the entity's type. The list
        /// could contain a single hint such as Movie or a list of hints such
        /// as Place, LocalBusiness, Restaurant. Each successive hint in the
        /// array narrows the entity's type.
        /// </summary>
        [JsonProperty(PropertyName = "entityTypeHints")]
        public IList<EntityType?> EntityTypeHints { get; private set; }

        /// <summary>
        /// Gets a display version of the entity hint. For example, if
        /// entityTypeHints is Artist, this field may be set to American
        /// Singer.
        /// </summary>
        [JsonProperty(PropertyName = "entityTypeDisplayHint")]
        public string EntityTypeDisplayHint { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
