﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestProject.ZipPay.Domain.BaseEntity
{
    /// <summary>
    /// Base class for all the entity class
    /// Declares common properties
    /// </summary>
    public class Entity : IEntity<int>
    {
        /// <summary>
        /// Primary key column
        /// Attribute based configuration used to make the id column identity
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        /// <summary>
        /// Create date time of record in table
        /// </summary>
        public DateTimeOffset CreateDateTime { get; set; } = DateTimeOffset.Now;

        /// <summary>
        /// Update date time of record in table
        /// </summary>
        public DateTimeOffset? UpdateDateTime { get; set; } = null;

        /// <summary>
        /// Column to maintain the concurrency of record during update
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; }

        /// <summary>
        /// IsActive = true, signifies the record is correct
        /// </summary>
        public bool IsActive { get; set; }
    }
}
