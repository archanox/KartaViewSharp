using KartaViewSharp.V2.Enums;

namespace KartaViewSharp.V2.RequestData
{
    public abstract class QueryFilters
    {
        /// <summary>
        /// Unique identifier of an entity, query for a set of ids is possible, separated by ,. For example: id=545,546,547
        /// </summary>
        public int[]? Id { get; set; }

        /// <summary>
        /// Unique identifier of an entity, query for an interval of ids is possible, separated by -. For example: idInterval=545-547
        /// </summary>
        public Range? IdInterval { get; set; }

        /// <summary>
        /// Retrieve data from the desired page number.
        /// </summary>
        public int? Page { get; set; }

        /// <summary>
        /// Default: 40
        /// Example: itemsPerPage=10
        /// Number of items on a page.
        /// </summary>
        public int ItemsPerPage { get; set; } = 40;

        /// <summary>
        /// Example: orderBy=dateAdded
        /// Sorting by a particular field, see full list below in the response example section.
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// Enum: "asc" "desc"
        /// Sorting direction.
        /// </summary>
        public OrderDirection OrderDirection { get; set; }

        /// <summary>
        /// Default: "metric"
        /// Enum: "metric" "imperial"
        /// The type of the distance measurement.
        /// </summary>
        public Units Units { get; set; }

        /// <summary>
        /// Default: "null"
        /// Example: join=user,photo
        /// Join resources to bring extra details about another resource, available joinable resource: user, photo, photos, attachment, attachments.
        /// </summary>
        public string[]? Join { get; set; }
    }
}