using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PageBuilderContainers;
using Kentico.Forms.Web.Mvc;

namespace HBS.StaticTextConainerizedWidget.Kentico.MVC
{
    public class StaticTextConainerizedWidgetProperties : PageBuilderContainers.PageBuilderWidgetProperties, IWidgetProperties
    {
        public const string IDENTIFIER = "HBS.StaticTextConainerizedWidget";
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "Text")]
        public string Text { get; set; }
    }
}