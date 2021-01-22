// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The CodeConfiguration. </summary>
    public partial class CodeConfiguration
    {
        /// <summary> Initializes a new instance of CodeConfiguration. </summary>
        /// <param name="command"> The command to execute on startup of the job. eg. [&quot;python&quot;, &quot;train.py&quot;]. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="command"/> is null. </exception>
        public CodeConfiguration(string command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            Command = command;
        }

        /// <summary> Initializes a new instance of CodeConfiguration. </summary>
        /// <param name="codeArtifactId"> The ID of the code asset. </param>
        /// <param name="command"> The command to execute on startup of the job. eg. [&quot;python&quot;, &quot;train.py&quot;]. </param>
        internal CodeConfiguration(string codeArtifactId, string command)
        {
            CodeArtifactId = codeArtifactId;
            Command = command;
        }

        /// <summary> The ID of the code asset. </summary>
        public string CodeArtifactId { get; set; }
        /// <summary> The command to execute on startup of the job. eg. [&quot;python&quot;, &quot;train.py&quot;]. </summary>
        public string Command { get; set; }
    }
}