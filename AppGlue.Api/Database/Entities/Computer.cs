using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppGlue.Api.Database.Entities
{
    public class Computer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public string Notes { get; set; }

        [MaxLength(50)]
        public string Manufacturer { get; set; }

        [MaxLength(50)]
        public string Model { get; set; }

        [MaxLength(100)]
        public string SerialNumber { get; set; }

        [MaxLength(50)]
        public string Processor { get; set; }

        public long? MemoryInKb { get; set; }

        public DateTime? BiosDate { get; set; }

        [MaxLength(50)]
        public string BiosVersion { get; set; }
    }
}
