﻿Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Optimization
Imports System.Web.UI

Public Module BundleConfig
    ' バンドルの詳細については、http://go.microsoft.com/fwlink/?LinkID=303951 を参照してください。
    Public Sub RegisterBundles(bundles As BundleCollection)
        bundles.Add(New ScriptBundle("~/bundles/WebFormsJs").Include(
            "~/Scripts/WebForms/WebForms.js",
            "~/Scripts/WebForms/WebUIValidation.js",
            "~/Scripts/WebForms/MenuStandards.js",
            "~/Scripts/WebForms/Focus.js", "~/Scripts/WebForms/GridView.js", 
            "~/Scripts/WebForms/DetailsView.js",
            "~/Scripts/WebForms/TreeView.js",
            "~/Scripts/WebForms/WebParts.js"))

        ' これらのファイルには明示的な依存関係があり、ファイルが動作するためには順序が重要です
        bundles.Add(New ScriptBundle("~/bundles/MsAjaxJs").Include(
            "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
            "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
            "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
            "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"))

        ' 開発に使用し、情報源である開発バージョンの Modernizr を使用します。続いて、
        ' 運用の準備が完了したら、http://modernizr.com のビルド ツールを使用し、必要なテストのみを選択します
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
            "~/Scripts/modernizr-*"))

        ScriptManager.ScriptResourceMapping.AddDefinition("respond", New ScriptResourceDefinition() With {
            .Path = "~/Scripts/respond.min.js",
            .DebugPath = "~/Scripts/respond.js"})

    End Sub
End Module
