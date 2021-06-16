using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session15.ModelBindingAndValidation.Infrastructures
{
    public class CustomNameValidatorAttribute : IModelValidator
    {
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            
            throw new NotImplementedException();
        }
    }
}
