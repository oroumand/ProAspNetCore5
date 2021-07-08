using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session18.TaghelpersSample.Infrastructures.TagHelpers
{
    public class InputTagHelper : TagHelper
    {
        public ModelExpression AroFor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var @for = AroFor;
        }
    }

    [HtmlTargetElement("a", Attributes = "aro-button-color")]
    [HtmlTargetElement("button", Attributes = "aro-button-color")]
    public class ButtonTagHelper : TagHelper
    {
        public string AroButtonColor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var attr = context.AllAttributes;
            output.Attributes.SetAttribute("class", $"btn btn-{AroButtonColor}");
        }
    }


    public class AlertDangerTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "alert alert-danger");
        }
    }
    [HtmlTargetElement("div")]
    public class DivTagHelper : TagHelper
    {
        public string AroTheme { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            context.Items["Theme"] = AroTheme;
        }
    }
    [HtmlTargetElement("button", ParentTag = "div")]
    public class Button01TagHelper : TagHelper
    {
        public string AroButtonColor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context.Items.ContainsKey("Theme"))
            {
                output.Attributes.SetAttribute("class", $"btn btn-{context.Items["Theme"]}");
            }


        }
    }

    public class AlertTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            if (context.Items.ContainsKey("Theme"))
            {
                output.Attributes.SetAttribute("class", $"alert alert-{context.Items["Theme"]}");
            }

        }
    }

    [HtmlTargetElement("div")]
    public class DivBeforAfterTagHelper : TagHelper
    {
        public string AroBeforTagText { get; set; }
        public string AroAfterTagText { get; set; }
        public string AroBeforContentText { get; set; }
        public string AroAfterContentText { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.PreElement.SetHtmlContent($"<h1>{AroBeforTagText}</h1>");
            output.PreContent.SetHtmlContent($"<h3>{AroBeforContentText}</h1>");
            output.PostContent.SetHtmlContent($"<h3>{AroAfterContentText}</h1>");
            output.PostElement.SetHtmlContent($"<h1>{AroAfterTagText}</h1>");
        }
    }

    public class PreventRenderTagHelper : TagHelper
    {
        public bool AroRender { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if(!AroRender)
            {
                output.SuppressOutput();
            }
        }
    }
}
