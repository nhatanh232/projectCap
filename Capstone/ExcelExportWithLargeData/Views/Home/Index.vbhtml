﻿@Code
    ViewData("Title") = "Export Excel with large data"
End Code

<div class="export-panel">
    <label>
        <span>Format: </span>
        @Html.C1().ComboBox().Id("format").IsEditable(False).Bind(New String() {"Xlsx", "Csv"}).SelectedIndex(0).Width(100)
    </label>
    <button class="btn btn-primary" onclick="exportExcel()">@(Resources.Resource.Index_ExportExcel)</button>
</div>
@(Html.C1().FlexGrid().Bind(Sub(b) b.Bind(Url.Action("OrdersData")).InitialItemsCount(100)).Height(450).IsReadOnly(True))
@Section Scripts
    <script>
    function exportExcel() {
        var url = '@Url.Content("~/api/excel")?FileName=data&TemplateFileName=files%5COrdersTemplate.xlsx&dataname=orders';
        var combo = wijmo.Control.getControl('#format');
        url += '&type=' + combo.text;
        window.open(url, '_blank');
    }
    </script>
End Section