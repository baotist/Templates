﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Data.Entities
{
    public partial class Supplier
    {
        public Supplier()
        {
            Items = new List<Item>();
        }

        public int SuppId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}