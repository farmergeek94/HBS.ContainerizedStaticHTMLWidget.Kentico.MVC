using Kentico.PageBuilder.Web.Mvc;
using HBS.StaticTextConainerizedWidget.Kentico.MVC;

// Registers the Widget, pointing to the View that is actually compiled and located in the StaticHTMLConainerizedWidget.View project.
[assembly: RegisterWidget(StaticTextConainerizedWidgetProperties.IDENTIFIER, "Static Text", typeof(StaticTextConainerizedWidgetProperties), customViewName: "Widgets/_StaticTextConainerizedWidget", Description = "Containerized widget for entering static text", IconClass = "icon-l-text")]

// FOR TESTING
// You can change the registration to point to a local View (non compiled) in order to debug.  
// This particular view is on my MVC Project, NOT my compiled StaticHTMLConainerizedWidget.View project
//[assembly: RegisterWidget("HBS.StaticHTMLConainerizedWidget", "Sample widget", typeof(StaticHTMLConainerizedWidgetWidgetModel), customViewName: "Widgets/_StaticHTMLConainerizedWidget_Test")]
