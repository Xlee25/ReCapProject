﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.DTOs
{
    public class UserForUpdateDto : UserForRegisterDto, IDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string companyName { get; set; }
    }
}
