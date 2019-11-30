<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
    <link rel="apple-touch-icon" sizes="180x180" href="~/Content/favicon/apple-touch-icon.png">
    <link rel="icon" type="image/png" href="~/Content/favicon/favicon-32x32.png" sizes="32x32">
    <link rel="icon" type="image/png" href="~/Content/favicon/favicon-16x16.png" sizes="16x16">
    <link rel="manifest" href="~/Content/favicon/manifest.json">
    <link rel="mask-icon" href="~/Content/favicon/safari-pinned-tab.svg" color="#503b75">
    
    <!-- Google Tag Manager -->
    <script>
        (function (w, d, s, l, i) {
            w[l] = w[l] || [];
            w[l].push({ 'gtm.start': new Date().getTime(), event: 'gtm.js' });
            var f = d.getElementsByTagName(s)[0],
                j = d.createElement(s),
                dl = l != 'dataLayer' ? '&l=' + l : '';
            j.async = true;
            j.src = 'https://www.googletagmanager.com/gtm.js?id=' + i + dl;
            f.parentNode.insertBefore(j, f);
        })(window, document, 'script', 'dataLayer', 'GTM-WT462SJ');
    </script>
    <!-- End Google Tag Manager -->

    <base target="_blank" />
    @Styles.Render("~/Content/SyntaxHighlighter/codeHighlight")
    @Html.C1().Styles()
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    @Html.C1().Scripts().Basic()
</head>
<body>
    <!-- Google Tag Manager (noscript) -->
    <noscript>
        <iframe src="https://www.googletagmanager.com/ns.html?id=GTM-WT462SJ"
                height="0" width="0" style="display:none;visibility:hidden"></iframe>
    </noscript>
    <!-- End Google Tag Manager (noscript) -->

    <div class="hide">
        @Html.Partial("_SiteNav", True)
    </div>
    <header>
        <div class="hamburger-nav-btn narrow-screen"><span class="icon-bars"></span></div>
        <a class="logo-container" href="https://www.grapecity.com/en/webapi" target="_blank">
            <i class="gcicon-product-c1"></i>@Html.Raw(Resources.Resource.Layout_ComponentOne)
        </a>
        <div class="task-bar">
            <span class="semi-bold">@ViewBag.Title</span>
            @Html.Partial("_SiteNav", False)
        </div>
    </header>
    <div class="col-md-12">
        @Html.Partial("_Description")
        <div class="padder">
            <div>
                <ul id="navList" class="nav nav-tabs">
                    <li><a class="semi-bold">@Html.Raw(Resources.Resource.ControlLayout_Sample)</a></li>
                    <li><a class="semi-bold">@Html.Raw(Resources.Resource.ControlLayout_Source)</a></li>
                </ul>
                <div id="panelList" class="tab-content">
                    <div class="tab-pane pane-content active collapse-panel" id="sample">
                        <div class="demo-control">@RenderBody()</div>
                    </div>
                    <div class="tab-pane pane-content collapse-panel" id="source">
                        <div class="demo-source">
                            @Html.Partial("_DemoSource", ControlPages.GetPageSources())
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <footer>
        <a href="http://www.grapecity.com/">
            <i class="gcicon-logo-gc-horiz"></i>
        </a>
        <p>
            © @DateTime.Now.Year @Html.Raw(Resources.Resource.Layout_License1)<br />
            @Html.Raw(Resources.Resource.Layout_License2)Layout_License2)
        </p>
        @Code
            Dim currentUrl = Request.Url
            Dim urlStr = currentUrl.OriginalString.Substring(0, currentUrl.OriginalString.Length - (If(currentUrl.Query Is Nothing, 0, currentUrl.Query.Length)))
            @<a href="http://www.facebook.com/sharer.php?u=@urlStr" target="_blank">
                <img src="~/Content/css/images/icons/32/picons36.png" alt="facebook" />
            </a>
            @<a href="http://twitter.com/share?text=Have you seen this? C1Studio Web API&url=@urlStr" target="_blank">
                <img src="~/Content/css/images/icons/32/picons33.png" alt="Twitter" />
            </a>
        End Code
    </footer>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/bundles/SyntaxHighlighter/codeHighlight")
    <script src="~/Scripts/MultiLevelMenu.js"></script>
    <script src="~/Scripts/app.js"></script>
    @RenderSection("scripts", required:=False)
</body>
</html>