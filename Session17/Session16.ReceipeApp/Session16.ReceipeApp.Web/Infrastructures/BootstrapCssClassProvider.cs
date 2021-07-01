using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session16.ReceipeApp.Web.Infrastructures
{
    public class BootstrapCssClassProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
            var isValid = !editContext.GetValidationMessages(fieldIdentifier).Any();
            var vallidCss = editContext.IsModified(fieldIdentifier) ? "is-valid" : "";
            return isValid ? vallidCss : "is-invalid";

        }
    }
}
