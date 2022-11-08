using Microsoft.AspNetCore.Components.Forms;

namespace BlazorTrainingNov.Pages.Modul5
{
    public class BootstrapFixFieldCssClassProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
            var isinvalid = editContext.GetValidationMessages(fieldIdentifier).Any();
            return isinvalid?"is-invalid":"is-valid";
            // Blazor defautl invalid valid
        }
    }
}
