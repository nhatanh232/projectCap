﻿@ModelType Boolean
@Code
    Dim screenCss = If(Model, "narrow-screen", "wide-screen")
End Code
<ul class="site-nav @screenCss">
    <li>
        <a href="@(Resources.Resource.SiteNav_AboutUrl)" target="_blank">@Html.Raw(Resources.Resource.SiteNav_About)</a>
    </li>
    <li>
        <a href="@(Resources.Resource.SiteNav_SupportUrl)" target="_blank">@Html.Raw(Resources.Resource.SiteNav_Support)</a>
    </li>
    <li>
        <a href="@(Resources.Resource.SiteNav_PricingUrl)" target="_blank">@Html.Raw(Resources.Resource.SiteNav_Pricing)</a>
    </li>
    <li class="bold">
        <a href="@(Resources.Resource.SiteNav_FreeTrialUrl)" target="_blank">@Html.Raw(Resources.Resource.SiteNav_FreeTrial)</a>
    </li>
</ul>
