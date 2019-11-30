@ModelType IDictionary(Of String, String)
    @If (Model IsNot Nothing) Then
        @<ul id="sourceTab" Class="nav nav-tabs ui-helper-clearfix mob-hide-1" role="tablist">
            @For Each pageSource In Model
                @<li><a>@pageSource.Key</a></li>
            Next
        </ul>
        @<div id="sourcePanel" Class="tab-content">
            @For Each pageSource In Model
                Dim className = "brush:vb;"
                If (pageSource.Key.Contains(".vbhtml")) Then
                    className = "brush:js;html-script:true;"
                End If
                @<div Class="tab-pane pane-content mob-hide-1">
                    <pre Class=@className>@pageSource.Value</pre>
                </div>
            Next
        </div>
    End If