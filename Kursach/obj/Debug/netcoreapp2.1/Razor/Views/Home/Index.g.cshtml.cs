#pragma checksum "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "617d4922b87b0d2ed5681ea5d9944e6e3d43f45a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/_ViewImports.cshtml"
using Kursach;

#line default
#line hidden
#line 2 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/_ViewImports.cshtml"
using Kursach.Models;

#line default
#line hidden
#line 3 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/_ViewImports.cshtml"
using Kursach.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"617d4922b87b0d2ed5681ea5d9944e6e3d43f45a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d377b205f82e1db98dbbd5931b06db8579f7a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
  
	ViewData["Title"] = "Projects";

#line default
#line hidden
            BeginContext(75, 165, true);
            WriteLiteral("\r\n<nav class=\"navbar navbar-light bg-light\">\r\n\t<span class=\"navbar-brand mb-0 h1\">Количество проектов с вашим участием: <span class=\"badge badge-primary badge-pill\">");
            EndContext();
            BeginContext(241, 13, false);
#line 7 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                                                                                                     Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(254, 706, true);
            WriteLiteral(@"</span></span>
</nav>
<script>
	function PopulateSteps(projId) {
		var activate = document.getElementById(""showbutton-"" + projId);
		var deactivate = document.getElementById(""hidebutton-"" + projId);

		activate.hidden = true;
		deactivate.hidden = false;

		var t = document.getElementById(""stepsdiv"");
		$(""#stepsdiv-"" + projId).fadeIn(""slow"");

	}
	function HideSteps(projId) {
		var activate = document.getElementById(""showbutton-"" + projId);
		var deactivate = document.getElementById(""hidebutton-"" + projId);


		activate.hidden = false;
		deactivate.hidden = true;

		var t = document.getElementById(""stepsdiv"");
		$(""#stepsdiv-"" + projId).fadeOut(""slow"");

	}
</script>

");
            EndContext();
#line 35 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
 foreach (var project in Model)
{
	bool hasSteps = false;

#line default
#line hidden
            BeginContext(1021, 71, true);
            WriteLiteral("\t<ul class=\"list-group\">\r\n\r\n\r\n\t\t<li class=\"list-group-item active\">\r\n\r\n");
            EndContext();
#line 43 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
             foreach (var st in project.Steps)
			{
				if (st.EndDate == DateTime.MinValue)
				{
					hasSteps = true;
					break;
				}
			}

#line default
#line hidden
            BeginContext(1235, 79, true);
            WriteLiteral("\r\n\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"inline\" style=\"float:left\">\r\n\t\t\t\t\t<b>");
            EndContext();
            BeginContext(1315, 19, false);
#line 55 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                  Write(project.ProjectName);

#line default
#line hidden
            EndContext();
            BeginContext(1334, 20, true);
            WriteLiteral("</b>\r\n\t\t\t\t</div>\r\n\r\n");
            EndContext();
#line 58 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                 if (!project.IsDone && project.AuthorId == int.Parse(User.Identity.Name) && !hasSteps && !project.IsPause)
	{
			

#line default
#line hidden
#line 60 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
             using (Html.BeginForm("UpdateProjStatus", "Home", FormMethod.Post))
{


#line default
#line hidden
            BeginContext(1549, 108, true);
            WriteLiteral("\t\t\t<div class=\"inline\" style=\"margin-right: 10px\">\r\n\t\t\t\t<input type=\"hidden\" id=\"projectID\" name=\"projectId\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1657, "", 1680, 1);
#line 64 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 1664, project.Project, 1664, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1680, 93, true);
            WriteLiteral(">\r\n\t\t\t\t<input type=\"submit\" class=\"btn btn-success\" value=\"Завершить проект \" />\r\n\t\t\t</div>\r\n");
            EndContext();
#line 67 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
}

#line default
#line hidden
#line 67 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
 
}

#line default
#line hidden
            BeginContext(1779, 4, true);
            WriteLiteral("\t\t\t\t");
            EndContext();
#line 69 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                 if (!project.IsDone && !project.IsPause)
	{
			

#line default
#line hidden
#line 71 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
             using (Html.BeginForm("AddStep", "Home", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(1897, 108, true);
            WriteLiteral("\t\t\t<div class=\"inline\" style=\"margin-right: 10px\">\r\n\t\t\t\t<input type=\"hidden\" id=\"projectID\" name=\"projectId\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2005, "", 2028, 1);
#line 74 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 2012, project.Project, 2012, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2028, 63, true);
            WriteLiteral(">\r\n\t\t\t\t<input type=\"hidden\" id=\"projectName\" name=\"projectName\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2091, "", 2118, 1);
#line 75 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 2098, project.ProjectName, 2098, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2118, 87, true);
            WriteLiteral(">\r\n\t\t\t\t<input type=\"submit\" class=\"btn btn-info\" value=\"Добавить этап \" />\r\n\t\t\t</div>\r\n");
            EndContext();
#line 78 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
}

#line default
#line hidden
#line 78 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
 
}

#line default
#line hidden
            BeginContext(2211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 81 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                 if (!project.IsDone && project.AuthorId == int.Parse(User.Identity.Name) && !project.IsPause)
	{
			

#line default
#line hidden
#line 83 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
             using (Html.BeginForm("AddUserView", "Home", FormMethod.Post))
{


#line default
#line hidden
            BeginContext(2390, 112, true);
            WriteLiteral("\t\t\t<div class=\"inline\" style=\"margin-right: 10px\">\r\n\t\t\t\t<input type=\"hidden\" id=\"projectName\" name=\"projectName\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2502, "", 2529, 1);
#line 87 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 2509, project.ProjectName, 2509, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2529, 59, true);
            WriteLiteral(">\r\n\t\t\t\t<input type=\"hidden\" id=\"projectID\" name=\"projectId\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2588, "", 2611, 1);
#line 88 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 2595, project.Project, 2595, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2611, 96, true);
            WriteLiteral(">\r\n\t\t\t\t<input type=\"submit\" class=\"btn btn-warning\" value=\"Управление доступом \" />\r\n\t\t\t</div>\r\n");
            EndContext();
#line 91 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
}

#line default
#line hidden
#line 91 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
 
}

#line default
#line hidden
            BeginContext(2713, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 94 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                 if (!project.IsDone && project.AuthorId == int.Parse(User.Identity.Name) && project.IsPause)
	{
			

#line default
#line hidden
#line 96 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
             using (Html.BeginForm("UnfreezeOfProjects", "Home", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(2896, 112, true);
            WriteLiteral("\t\t\t<div class=\"inline\" style=\"margin-right: 10px\">\r\n\t\t\t\t<input type=\"hidden\" id=\"projectName\" name=\"projectName\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 3008, "", 3035, 1);
#line 99 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 3015, project.ProjectName, 3015, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3035, 59, true);
            WriteLiteral(">\r\n\t\t\t\t<input type=\"hidden\" id=\"projectID\" name=\"projectId\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 3094, "", 3117, 1);
#line 100 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 3101, project.Project, 3101, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3117, 94, true);
            WriteLiteral(">\r\n\t\t\t\t<input type=\"submit\" class=\"btn btn-success\" value=\"Возобновить проект\" />\r\n\t\t\t</div>\r\n");
            EndContext();
#line 103 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
}

#line default
#line hidden
#line 103 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
 
}

#line default
#line hidden
            BeginContext(3217, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 106 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                 if (!project.IsDone && project.AuthorId == int.Parse(User.Identity.Name) && !project.IsPause)
	{
			

#line default
#line hidden
#line 108 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
             using (Html.BeginForm("FreezeOfProjects", "Home", FormMethod.Post))
{


#line default
#line hidden
            BeginContext(3401, 112, true);
            WriteLiteral("\t\t\t<div class=\"inline\" style=\"margin-right: 10px\">\r\n\t\t\t\t<input type=\"hidden\" id=\"projectName\" name=\"projectName\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 3513, "", 3540, 1);
#line 112 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 3520, project.ProjectName, 3520, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3540, 59, true);
            WriteLiteral(">\r\n\t\t\t\t<input type=\"hidden\" id=\"projectID\" name=\"projectId\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 3599, "", 3622, 1);
#line 113 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 3606, project.Project, 3606, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3622, 93, true);
            WriteLiteral(">\r\n\t\t\t\t<input type=\"submit\" class=\"btn btn-danger\" value=\"Заморозить проект \" />\r\n\t\t\t</div>\r\n");
            EndContext();
#line 116 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
}

#line default
#line hidden
#line 116 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
 
}

#line default
#line hidden
            BeginContext(3721, 73, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n\r\n\t\t</li>\r\n\t\t<li class=\"list-group-item\"><b>Стоимость</b> - ");
            EndContext();
            BeginContext(3795, 12, false);
#line 122 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                                  Write(project.Cost);

#line default
#line hidden
            EndContext();
            BeginContext(3807, 9, true);
            WriteLiteral(" $</li>\r\n");
            EndContext();
#line 123 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
         if (!project.IsPause)
		{

#line default
#line hidden
            BeginContext(3847, 47, true);
            WriteLiteral("\t\t<li class=\"list-group-item\"><b>Дедлайн</b> - ");
            EndContext();
            BeginContext(3895, 36, false);
#line 125 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                                Write(project.Deadline.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3931, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 126 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
		}

#line default
#line hidden
            BeginContext(3943, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 129 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
         if (project.IsDone)
		{

#line default
#line hidden
            BeginContext(3976, 77, true);
            WriteLiteral("\t\t\t<li class=\"list-group-item list-group-item-success\">Проект завершен</li>\r\n");
            EndContext();
#line 132 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
		}
		else if (project.IsPause)
		{

#line default
#line hidden
            BeginContext(4092, 77, true);
            WriteLiteral("\t\t\t<li class=\"list-group-item list-group-item-danger\">Проект заморожен</li>\r\n");
            EndContext();
#line 136 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
		}
		else
		{

#line default
#line hidden
            BeginContext(4187, 91, true);
            WriteLiteral("\t\t\t<li class=\"list-group-item list-group-item-warning\">Проект находится в разработке</li>\r\n");
            EndContext();
#line 140 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
		}

#line default
#line hidden
            BeginContext(4283, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 142 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
         if (!project.IsPause)
		{

#line default
#line hidden
            BeginContext(4315, 133, true);
            WriteLiteral("\t\t<li class=\"list-group-item\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"inline\" style=\"margin-right:10px ; font-size: 20px; \">\r\n\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4448, "\"", 4489, 3);
            WriteAttributeValue("", 4458, "PopulateSteps(", 4458, 14, true);
#line 147 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 4472, project.Project, 4472, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 4488, ")", 4488, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4490, "\"", 4522, 2);
            WriteAttributeValue("", 4495, "showbutton-", 4495, 11, true);
#line 147 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 4506, project.Project, 4506, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4523, 83, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t<span class=\"glyphicon glyphicon-chevron-down\"></span>\r\n\t\t\t\t\t</a>\r\n\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4606, "\"", 4643, 3);
            WriteAttributeValue("", 4616, "HideSteps(", 4616, 10, true);
#line 150 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 4626, project.Project, 4626, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 4642, ")", 4642, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4644, "\"", 4676, 2);
            WriteAttributeValue("", 4649, "hidebutton-", 4649, 11, true);
#line 150 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 4660, project.Project, 4660, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4677, 174, true);
            WriteLiteral(" hidden>\r\n\t\t\t\t\t\t<span class=\"glyphicon glyphicon-chevron-up\"></span>\r\n\t\t\t\t\t</a>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"inline\" style=\"float:left\">\r\n\t\t\t\t\t<h5> Данный проект содержит <b>");
            EndContext();
            BeginContext(4852, 19, false);
#line 155 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                              Write(project.Steps.Count);

#line default
#line hidden
            EndContext();
            BeginContext(4871, 53, true);
            WriteLiteral("</b> этапа(ов)</h5>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</li>\r\n");
            EndContext();
#line 159 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
		}

#line default
#line hidden
            BeginContext(4929, 16, true);
            WriteLiteral("\t\t<br />\r\n\t\t<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4945, "\"", 4975, 2);
            WriteAttributeValue("", 4950, "stepsdiv-", 4950, 9, true);
#line 161 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 4959, project.Project, 4959, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4976, 10, true);
            WriteLiteral(" hidden>\r\n");
            EndContext();
#line 162 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
             foreach (var step in project.Steps)
			{

#line default
#line hidden
            BeginContext(5033, 120, true);
            WriteLiteral("\t\t\t\t<ul class=\"nested\">\r\n\t\t\t\t\t<li class=\"list-group-item list-group-item-info\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n");
            EndContext();
#line 168 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                 switch (step.Status)
								{
									case 0:

#line default
#line hidden
            BeginContext(5211, 74, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"inline\" style=\"float:left\">\r\n\t\t\t\t\t\t\t\t\t\t<b>Этап: </b> ");
            EndContext();
            BeginContext(5286, 9, false);
#line 172 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                                 Write(step.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5295, 49, true);
            WriteLiteral(" <br><b>Статус: </b> не известен\r\n\t\t\t\t\t\t\t\t\t</div>");
            EndContext();
#line 173 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                          ;
										break;
									case 1:

#line default
#line hidden
            BeginContext(5381, 74, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"inline\" style=\"float:left\">\r\n\t\t\t\t\t\t\t\t\t\t<b>Этап: </b> ");
            EndContext();
            BeginContext(5456, 9, false);
#line 177 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                                 Write(step.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5465, 50, true);
            WriteLiteral(" <br><b>Статус: </b> в разработке\r\n\t\t\t\t\t\t\t\t\t</div>");
            EndContext();
#line 178 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                          ;
										break;
									case 2:

#line default
#line hidden
            BeginContext(5552, 75, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"inline\" style=\"float: left\">\r\n\t\t\t\t\t\t\t\t\t\t<b>Этап: </b> ");
            EndContext();
            BeginContext(5628, 9, false);
#line 182 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                                 Write(step.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5637, 48, true);
            WriteLiteral(" <br><b>Статус: </b> в процессе\r\n\t\t\t\t\t\t\t\t\t</div>");
            EndContext();
#line 183 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                          ;
										break;
									case 3:

#line default
#line hidden
            BeginContext(5722, 74, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"inline\" style=\"float:left\">\r\n\t\t\t\t\t\t\t\t\t\t<b>Этап: </b> ");
            EndContext();
            BeginContext(5797, 9, false);
#line 187 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                                 Write(step.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5806, 49, true);
            WriteLiteral(" <br><b>Статус: </b> в аналитике\r\n\t\t\t\t\t\t\t\t\t</div>");
            EndContext();
#line 188 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                          ;
										break;
									case 4:

#line default
#line hidden
            BeginContext(5892, 75, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"inline\" style=\"float: left\">\r\n\t\t\t\t\t\t\t\t\t\t<b>Этап: </b> ");
            EndContext();
            BeginContext(5968, 9, false);
#line 192 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                                 Write(step.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5977, 52, true);
            WriteLiteral(" <br><b>Статус: </b> в тестировании\r\n\t\t\t\t\t\t\t\t\t</div>");
            EndContext();
#line 193 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                          ;
										break;
									case 5:

#line default
#line hidden
            BeginContext(6066, 75, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"inline\" style=\"float: left\">\r\n\t\t\t\t\t\t\t\t\t\t<b>Этап: </b> ");
            EndContext();
            BeginContext(6142, 9, false);
#line 197 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                                 Write(step.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6151, 44, true);
            WriteLiteral(" <br><b>Статус: </b> закрыт\r\n\t\t\t\t\t\t\t\t\t</div>");
            EndContext();
#line 198 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                          ;
										break;
								}

#line default
#line hidden
            BeginContext(6225, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 202 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
             if (step.EndDate == DateTime.MinValue)

			{
				

#line default
#line hidden
#line 205 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                 using (Html.BeginForm("UpdateStepStatus", "Home", FormMethod.Post))
				{

#line default
#line hidden
            BeginContext(6357, 110, true);
            WriteLiteral("\t\t\t\t\t<div class=\"inline\" style=\" margin-right : 10px\" ;>\r\n\t\t\t\t\t\t<input type=\"hidden\" id=\"stepID\" name=\"stepId\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 6467, "", 6497, 1);
#line 208 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 6474, step.StepOfDevelopment, 6474, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6497, 89, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t<input type=\"submit\" class=\"btn btn-primary\" value=\"Завернить\" />\r\n\t\t\t\t\t</div>\r\n");
            EndContext();
            BeginContext(6588, 190, true);
            WriteLiteral("\t\t\t\t\t<div class=\"inline\" style=\" margin-right : 10px\" ;>\r\n\t\t\t\t\t\t<input class=\"form-control\" id=\"elapsedTime\" name=\"elapsedTime\" type=\"text\" placeholder=\"Затраты времени в ч.\">\r\n\t\t\t\t\t</div>\r\n");
            EndContext();
#line 215 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
				}

#line default
#line hidden
#line 215 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                 
			}

#line default
#line hidden
            BeginContext(6790, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 218 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
             if (project.AuthorId == int.Parse(User.Identity.Name) && (step.EndDate == DateTime.MinValue))
			{
				

#line default
#line hidden
#line 220 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                 using (Html.BeginForm("RemoveStepFromProject", "Home", FormMethod.Post))
				{

#line default
#line hidden
            BeginContext(6981, 109, true);
            WriteLiteral("\t\t\t\t\t\t<div class=\"inline\" style=\"margin-right : 10px\">\r\n\t\t\t\t\t\t\t<input type=\"hidden\" id=\"stepID\" name=\"stepId\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 7090, "", 7120, 1);
#line 223 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 7097, step.StepOfDevelopment, 7097, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7120, 163, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-primary\" value=\"Удалить\"><span class=\"glyphicon glyphicon-trash\" aria-hidden=\"true\"></span></button>\r\n\t\t\t\t\t\t</div>\r\n");
            EndContext();
#line 226 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
				}

#line default
#line hidden
#line 226 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                 
			}

#line default
#line hidden
            BeginContext(7295, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 229 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
         if (step.EndDate == DateTime.MinValue)
		{

			

#line default
#line hidden
#line 232 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
             using (Html.BeginForm("UpdCurStatusOfStep", "Home", FormMethod.Post))
			{

#line default
#line hidden
            BeginContext(7426, 270, true);
            WriteLiteral(@"					<div class=""inline"" style=""margin-right : 10px"">
						<div class=""btn-group"">

							<button type=""button"" id=""stepStatus"" name=""stepStatus"" value=""2"" class=""btn btn-primary disabled"">Статус этапа</button>
							<input type=""hidden"" id=""stepID"" name=""stepId""");
            EndContext();
            BeginWriteAttribute("value", " value=", 7696, "", 7726, 1);
#line 238 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
WriteAttributeValue("", 7703, step.StepOfDevelopment, 7703, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7726, 837, true);
            WriteLiteral(@">
							<button type=""button"" data-toggle=""dropdown"" class=""btn btn-primary dropdown-toggle ""><span class=""caret""></span></button>
							<ul class=""dropdown-menu"">
								<li><button type=""submit"" id=""stepStatus"" name=""stepStatus"" value=""1"" class=""btn btn-link"">В разработке</button></li>
								<li><button type=""submit"" id=""stepStatus"" name=""stepStatus"" value=""2"" class=""btn btn-link"">В процессе</button></li>								<li><button type=""submit"" id=""stepStatus"" name=""stepStatus"" value=""3"" class=""btn btn-link"">В аналитике</button></li>								<li><button type=""submit"" id=""stepStatus"" name=""stepStatus"" value=""4"" class=""btn btn-link"">В тестировании</button></li>								<li><button type=""submit"" id=""stepStatus"" name=""stepStatus"" value=""5"" class=""btn btn-link"">Закрыто</button></li>
							</ul>
						</div> 
					</div>
");
            EndContext();
#line 249 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
				}

#line default
#line hidden
#line 249 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                 
			}

#line default
#line hidden
            BeginContext(8575, 109, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\r\n\r\n\r\n\t\t\t\t\t</li>\r\n\t\t\t\t\r\n\t\t\t<li class=\"list-group-item\"><b>Описание:</b> ");
            EndContext();
            BeginContext(8685, 16, false);
#line 259 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                                    Write(step.Description);

#line default
#line hidden
            EndContext();
            BeginContext(8701, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 260 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
             if (step.EndDate != DateTime.MinValue)
			{

#line default
#line hidden
            BeginContext(8757, 70, true);
            WriteLiteral("\t\t\t\t<li class=\"list-group-item list-group-item-success\">Этап завершен ");
            EndContext();
            BeginContext(8828, 32, false);
#line 262 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                                                             Write(step.EndDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(8860, 21, true);
            WriteLiteral("; Разработка заняла: ");
            EndContext();
            BeginContext(8882, 16, false);
#line 262 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
                                                                                                                                   Write(step.ElapsedTime);

#line default
#line hidden
            EndContext();
            BeginContext(8898, 17, true);
            WriteLiteral(" часа(ов) </li>\r\n");
            EndContext();
#line 263 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"

			}
			else
			{

#line default
#line hidden
            BeginContext(8936, 88, true);
            WriteLiteral("\t\t\t\t<li class=\"list-group-item list-group-item-danger\">Этап в процессе выполнения</li>\r\n");
            EndContext();
#line 268 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
			}

#line default
#line hidden
            BeginContext(9030, 12, true);
            WriteLiteral("\r\n\t\t\t</ul>\r\n");
            EndContext();
            BeginContext(9044, 11, true);
            WriteLiteral("\t\t\t<hr />\r\n");
            EndContext();
#line 273 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"
			}

#line default
#line hidden
            BeginContext(9061, 19, true);
            WriteLiteral("\t\t\t</div>\r\n\t</ul>\r\n");
            EndContext();
#line 276 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Index.cshtml"

}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
