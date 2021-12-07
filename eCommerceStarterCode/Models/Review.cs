﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;




namespace eCommerceStarterCode.Models
{
    public class Review
    {
    }
}

{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }



        [ForeignKey("Categories")]

        public int CategoryId { get; set; }

        public Category Category { get; set; }


    }
}