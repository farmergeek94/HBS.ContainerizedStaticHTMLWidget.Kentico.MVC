using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PageBuilderContainers;
using Kentico.Forms.Web.Mvc;

namespace HBS.StaticTextContainerizedWidget.Kentico.MVC
{
    public class StaticTextContainerizedWidgetProperties : PageBuilderContainers.PageBuilderWidgetProperties, IWidgetProperties
    {
        public const string IDENTIFIER = "HBS_StaticTextConainerizedWidget";
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "Text")]
        public string Text { get; set; }
    }
}