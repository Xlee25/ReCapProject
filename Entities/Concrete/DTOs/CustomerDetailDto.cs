using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.DTOs
{
    public class CustomerDetailDto : IDto
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int FindexPoint { get; set; }
    }
}
