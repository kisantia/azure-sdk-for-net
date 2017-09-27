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

    public partial class Response : Identifiable
    {
        /// <summary>
        /// Initializes a new instance of the Response class.
        /// </summary>
        public Response()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Response class.
        /// </summary>
        /// <param name="contractualRules">A list of rules that you must adhere
        /// to if you display the item.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        public Response(string id = default(string), IList<ContractualRulesContractualRule> contractualRules = default(IList<ContractualRulesContractualRule>), string webSearchUrl = default(string))
            : base(id)
        {
            ContractualRules = contractualRules;
            WebSearchUrl = webSearchUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a list of rules that you must adhere to if you display the
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "contractualRules")]
        public IList<ContractualRulesContractualRule> ContractualRules { get; private set; }

        /// <summary>
        /// Gets the URL To Bing's search result for this item.
        /// </summary>
        [JsonProperty(PropertyName = "webSearchUrl")]
        public string WebSearchUrl { get; private set; }

    }
}
