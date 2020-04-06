using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PageBuilderContainers;
using Kentico.Forms.Web.Mvc;

namespace HBS.StaticHTMLConainerizedWidget.Kentico.MVC
{
    public class StaticHTMLConainerizedWidgetProperties : PageBuilderContainers.PageBuilderWidgetProperties, IWidgetProperties
    {
        public const string IDENTIFIER = "HBS.StaticHTMLConainerizedWidget";
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "Html")]
        public string HTML { get; set; }
    }
}