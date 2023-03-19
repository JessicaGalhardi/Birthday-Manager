using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Friend.Web.TagHelpers
{
    public class MessageOutput
    {
        public bool IsValid { get; set; }
        public string? Message { get; set; }
    }

    //Setting a name for the helper
    [HtmlTargetElement("formmessage")]
    public class FormManagmentHelper : TagHelper
    {

        public MessageOutput? messageOutput { get; set; }

        //Error treatment for possible null
        public FormManagmentHelper()
        {
            messageOutput = new MessageOutput()
            {
                Message = "",
                IsValid = true
            };
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (messageOutput == null)
            {

                base.Process(context, output);
                return;
            }
            //Set content and using alert bootstrap for the helper
            output.Content.SetHtmlContent("<div class= 'alert alert-success' role= 'alert'>" +
                $"{messageOutput.Message}" + "</div>");

            if (!messageOutput.IsValid)
            {

                //Set content and using alert bootstrap for the helper
                output.Content.SetHtmlContent("<div class= 'alert alert-danger' role= 'alert'>" +
                    $"{messageOutput.Message}" + "</div>");
            }

            output.TagMode = TagMode.StartTagAndEndTag;
            base.Process(context, output);
        }
    }
}
