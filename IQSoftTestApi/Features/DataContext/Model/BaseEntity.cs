using System;

namespace IQSoftTestApi.Features.DataContext.Model
{
    public class BaseEntity
    {
        /// <summary>
        /// Database Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ItemId form excel
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// Created datetime
        /// </summary>
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
    }
}
