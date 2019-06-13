namespace DD.CBU.Compute.Api.Contracts.Requests.Server20
{
    using System;

    /// <summary>
    /// Filtering options for the historical server configurations request.
    /// </summary>
    public sealed class HistoricalServerConfigurationListOptions : FilterableRequest
    {
        /// <summary>
        /// The "serverId" field name.
        /// </summary>
        public const string ServerIdField = "serverId";

        /// <summary>
        // The "time" field name.
        /// </summary>
        public const string TimeField = "time";

        /// <summary>
        /// Identifies an individual server.
        /// </summary>
        public Guid? ServerId
        {
            get
            {
                return GetFilter<Guid?>(ServerIdField);
            }
            set
            {
                SetFilter(ServerIdField, value);
            }
        }

        /// <summary>
        /// Gets or sets the TimeEquals filter.
        /// </summary>
        public DateTimeOffset? TimeEquals
        {
            get
            {
                return GetFilter<DateTimeOffset?>(TimeField);
            }
            set
            {
                SetFilter(TimeField, value);
            }
        }

        /// <summary>
        /// Gets or sets the TimeBefore filter.
        /// </summary>
        public DateTimeOffset? TimeBefore
        {
            get
            {
                return GetFilter<DateTimeOffset?>(TimeField, FilterOperator.LessThan);
            }
            set
            {
                SetFilter(TimeField, FilterOperator.LessThan, value);
            }
        }

        /// <summary>
        /// Gets or sets the TimeAfter filter.
        /// </summary>
        public DateTimeOffset? TimeAfter
        {
            get
            {
                return GetFilter<DateTimeOffset?>(TimeField, FilterOperator.GreaterThan);
            }
            set
            {
                SetFilter(TimeField, FilterOperator.GreaterThan, value);
            }
        }

        /// <summary>
        /// Gets or sets the TimeMin Inclusive filter.
        /// </summary>
        public DateTimeOffset? TimeMin
        {
            get
            {
                return GetFilter<DateTimeOffset?>(TimeField, FilterOperator.LessOrEqual);
            }
            set
            {
                SetFilter(TimeField, FilterOperator.LessOrEqual, value);
            }
        }

        /// <summary>
        /// Gets or sets the TimeMax Inclusive filter.
        /// </summary>
        public DateTimeOffset? TimeMax
        {
            get
            {
                return GetFilter<DateTimeOffset?>(TimeField, FilterOperator.GreaterOrEqual);
            }
            set
            {
                SetFilter(TimeField, FilterOperator.GreaterOrEqual, value);
            }
        }
    }
}
