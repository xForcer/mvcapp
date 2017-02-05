﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videos4You.Models;

namespace Videos4You.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public string Title
        {
            get
            {

                if (Customer != null && Customer.Id != 0)
                    return "Edit Customer";

                return "New Customer";
            }
        }
    }
}