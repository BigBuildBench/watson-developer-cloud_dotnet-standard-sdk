/**
* (C) Copyright IBM Corp. 2022.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using Newtonsoft.Json;
using System;

namespace IBM.Watson.Discovery.v2.Model
{
    /// <summary>
    /// Information about a document classifier model.
    /// </summary>
    public class DocumentClassifierModel
    {
        /// <summary>
        /// The status of the training run.
        /// </summary>
        public class StatusEnumValue
        {
            /// <summary>
            /// Constant TRAINING for training
            /// </summary>
            public const string TRAINING = "training";
            /// <summary>
            /// Constant AVAILABLE for available
            /// </summary>
            public const string AVAILABLE = "available";
            /// <summary>
            /// Constant FAILED for failed
            /// </summary>
            public const string FAILED = "failed";
            
        }

        /// <summary>
        /// The status of the training run.
        /// Constants for possible values can be found using DocumentClassifierModel.StatusEnumValue
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
        /// <summary>
        /// A unique identifier of the document classifier model.
        /// </summary>
        [JsonProperty("model_id", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string ModelId { get; private set; }
        /// <summary>
        /// A human-readable name of the document classifier model.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>
        /// A description of the document classifier model.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>
        /// The date that the document classifier model was created.
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? Created { get; private set; }
        /// <summary>
        /// The date that the document classifier model was last updated.
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? Updated { get; private set; }
        /// <summary>
        /// Name of the CSV file that contains the training data that is used to train the document classifier model.
        /// </summary>
        [JsonProperty("training_data_file", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainingDataFile { get; set; }
        /// <summary>
        /// Name of the CSV file that contains data that is used to test the document classifier model. If no test data
        /// is provided, a subset of the training data is used for testing purposes.
        /// </summary>
        [JsonProperty("test_data_file", NullValueHandling = NullValueHandling.Ignore)]
        public string TestDataFile { get; set; }
        /// <summary>
        /// An object that contains information about a trained document classifier model.
        /// </summary>
        [JsonProperty("evaluation", NullValueHandling = NullValueHandling.Ignore)]
        public ClassifierModelEvaluation Evaluation { get; set; }
        /// <summary>
        /// A unique identifier of the enrichment that is generated by this document classifier model.
        /// </summary>
        [JsonProperty("enrichment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnrichmentId { get; set; }
        /// <summary>
        /// The date that the document classifier model was deployed.
        /// </summary>
        [JsonProperty("deployed_at", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? DeployedAt { get; private set; }
    }

}
