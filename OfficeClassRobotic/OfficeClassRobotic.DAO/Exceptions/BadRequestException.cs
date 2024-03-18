﻿using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.Service.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        {

        }

        public BadRequestException(string message, FluentValidation.Results.ValidationResult validationResult) : base(message)
        {
            ValidationErrors = validationResult.ToDictionary();
        }

        public IDictionary<string, string[]> ValidationErrors { get; set; }
    }
}
