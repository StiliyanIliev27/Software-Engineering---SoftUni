﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarDealer.DTOs.Import
{
    [XmlType("Customer")]
    public class ImportCustomerDto
    {
        [XmlElement("name")]
        public string Name { get; set; } = null!;

        [XmlElement("birthDate")]
        public string BirthDate { get; set; } = null!;//Parse to Date time when mapping

        [XmlElement("isYoungDriver")]
        public bool IsYoungDriver { get; set; }
    }
}
