﻿using System;

namespace Neuralm.Application.Messages.Requests
{
    /// <summary>
    /// Represents the <see cref="GetOrganismsRequest"/> class.
    /// </summary>
    public class GetOrganismsRequest : Request
    {
        /// <summary>
        /// Gets the training session id.
        /// </summary>
        public Guid TrainingSessionId { get; }

        /// <summary>
        /// Gets and sets the amount.
        /// </summary>
        public int Amount { get; }

        /// <summary>
        /// Initializes an instance of the <see cref="GetOrganismsRequest"/> class.
        /// </summary>
        public GetOrganismsRequest(Guid trainingSessionId, int amount)
        {
            TrainingSessionId = trainingSessionId;
            Amount = amount;
        }
    }
}
