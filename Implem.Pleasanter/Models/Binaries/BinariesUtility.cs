﻿using Implem.DefinitionAccessor;
using Implem.Libraries.Classes;
using Implem.Libraries.DataSources.SqlServer;
using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.Converts;
using Implem.Pleasanter.Libraries.DataSources;
using Implem.Pleasanter.Libraries.DataTypes;
using Implem.Pleasanter.Libraries.Html;
using Implem.Pleasanter.Libraries.HtmlParts;
using Implem.Pleasanter.Libraries.Models;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Responses;
using Implem.Pleasanter.Libraries.Security;
using Implem.Pleasanter.Libraries.Server;
using Implem.Pleasanter.Libraries.Settings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace Implem.Pleasanter.Models
{
    public static class BinariesUtility
    {
        public static string Index(SiteSettings siteSettings, Permissions.Types permissionType)
        {
            var hb = new HtmlBuilder();
            var formData = DataViewFilters.SessionFormData();
            var binaryCollection = BinaryCollection(siteSettings, permissionType, formData);
            var dataViewName = DataViewSelectors.Get(siteSettings.SiteId);
            return hb.Template(
                siteId: siteSettings.SiteId,
                referenceId: "Binaries",
                title: siteSettings.Title + " - " + Displays.List(),
                permissionType: permissionType,
                verType: Versions.VerTypes.Latest,
                methodType: BaseModel.MethodTypes.Index,
                allowAccess: permissionType.CanRead(),
                script: Libraries.Scripts.JavaScripts.DataView(
                    siteSettings: siteSettings,
                    permissionType: permissionType,
                    formData: formData,
                    dataViewName: dataViewName),
                userStyle: siteSettings.GridStyle,
                userScript: siteSettings.GridScript,
                action: () => hb
                    .Form(
                        attributes: new HtmlAttributes()
                            .Id_Css("BinariesForm", "main-form")
                            .Action(Navigations.ItemAction(siteSettings.SiteId)),
                        action: () => hb
                            .DataViewSelector(
                                referenceType: "Binaries",
                                dataViewName: dataViewName)
                            .DataViewFilters(
                                siteSettings: siteSettings,
                                siteId: siteSettings.SiteId)
                            .Aggregations(
                                siteSettings: siteSettings,
                                aggregations: binaryCollection.Aggregations)
                            .Div(id: "DataViewContainer", action: () => hb
                                .DataView(
                                    binaryCollection: binaryCollection,
                                    siteSettings: siteSettings,
                                    permissionType: permissionType,
                                    formData: formData,
                                    dataViewName: dataViewName))
                            .MainCommands(
                                siteId: siteSettings.SiteId,
                                permissionType: permissionType,
                                verType: Versions.VerTypes.Latest,
                                backUrl: Navigations.Index("Admins"),
                                bulkMoveButton: true,
                                bulkDeleteButton: true,
                                importButton: true,
                                exportButton: true)
                            .Div(css: "margin-bottom")
                            .Hidden(controlId: "TableName", value: "Binaries")
                            .Hidden(controlId: "BaseUrl", value: Navigations.BaseUrl()))
                    .Dialog_Move("items", siteSettings.SiteId, bulk: true)
                    .Div(attributes: new HtmlAttributes()
                        .Id_Css("Dialog_ExportSettings", "dialog")
                        .Title(Displays.ExportSettings()))).ToString();
        }

        private static BinaryCollection BinaryCollection(
            SiteSettings siteSettings,
            Permissions.Types permissionType,
            FormData formData, int offset = 0)
        {
            return new BinaryCollection(
                siteSettings: siteSettings,
                permissionType: permissionType,
                column: GridSqlColumnCollection(siteSettings),
                where: DataViewFilters.Get(
                    siteSettings: siteSettings,
                    tableName: "Binaries",
                    formData: formData,
                    where: Rds.BinariesWhere()),
                orderBy: GridSorters.Get(
                    formData, Rds.BinariesOrderBy().UpdatedTime(SqlOrderBy.Types.desc)),
                offset: offset,
                pageSize: siteSettings.GridPageSize.ToInt(),
                countRecord: true,
                aggregationCollection: siteSettings.AggregationCollection);
        }

        public static HtmlBuilder DataView(
            this HtmlBuilder hb,
            BinaryCollection binaryCollection,
            SiteSettings siteSettings,
            Permissions.Types permissionType,
            FormData formData,
            string dataViewName)
        {
            switch (dataViewName)
            {
                default: return hb.Grid(
                    binaryCollection: binaryCollection,
                    siteSettings: siteSettings,
                    permissionType: permissionType,
                    formData: formData);
            }
        }

        public static string DataView(
            SiteSettings siteSettings, Permissions.Types permissionType)
        {
            switch (DataViewSelectors.Get(siteSettings.SiteId))
            {
                default: return Grid(siteSettings: siteSettings, permissionType: permissionType);
            }
        }

        private static HtmlBuilder Grid(
            this HtmlBuilder hb,
            SiteSettings siteSettings,
            Permissions.Types permissionType,
            BinaryCollection binaryCollection,
            FormData formData)
        {
            return hb
                .Table(
                    attributes: new HtmlAttributes()
                        .Id_Css("Grid", "grid")
                        .DataAction("GridRows")
                        .DataMethod("post"),
                    action: () => hb
                        .GridRows(
                            siteSettings: siteSettings,
                            binaryCollection: binaryCollection,
                            formData: formData))
                .Hidden(
                    controlId: "GridOffset",
                    value: siteSettings.GridPageSize == binaryCollection.Count()
                        ? siteSettings.GridPageSize.ToString()
                        : "-1");
        }

        private static string Grid(SiteSettings siteSettings, Permissions.Types permissionType)
        {
            var formData = DataViewFilters.SessionFormData();
            var binaryCollection = BinaryCollection(siteSettings, permissionType, formData);
            return new ResponseCollection()
                .Html("#DataViewContainer", new HtmlBuilder().Grid(
                    siteSettings: siteSettings,
                    binaryCollection: binaryCollection,
                    permissionType: permissionType,
                    formData: formData))
                .Html("#Aggregations", new HtmlBuilder().Aggregations(
                    siteSettings: siteSettings,
                    aggregations: binaryCollection.Aggregations,
                    container: false))
                .WindowScrollTop().ToJson();
        }

        public static string GridRows(
            SiteSettings siteSettings,
            Permissions.Types permissionType,
            ResponseCollection responseCollection = null,
            int offset = 0,
            bool clearCheck = false,
            Message message = null)
        {
            var formData = DataViewFilters.SessionFormData();
            var binaryCollection = BinaryCollection(siteSettings, permissionType, formData, offset);
            return (responseCollection ?? new ResponseCollection())
                .Remove(".grid tr", _using: offset == 0)
                .ClearFormData("GridCheckAll", _using: clearCheck)
                .ClearFormData("GridUnCheckedItems", _using: clearCheck)
                .ClearFormData("GridCheckedItems", _using: clearCheck)
                .Message(message)
                .Append("#Grid", new HtmlBuilder().GridRows(
                    siteSettings: siteSettings,
                    binaryCollection: binaryCollection,
                    formData: formData,
                    addHeader: offset == 0,
                    clearCheck: clearCheck))
                .Html("#Aggregations", new HtmlBuilder().Aggregations(
                    siteSettings: siteSettings,
                    aggregations: binaryCollection.Aggregations,
                    container: false))
                .Val("#GridOffset", siteSettings.NextPageOffset(offset, binaryCollection.Count()))
                .Markup()
                .ToJson();
        }

        private static HtmlBuilder GridRows(
            this HtmlBuilder hb,
            SiteSettings siteSettings,
            BinaryCollection binaryCollection,
            FormData formData,
            bool addHeader = true,
            bool clearCheck = false)
        {
            var checkAll = clearCheck ? false : Forms.Bool("GridCheckAll");
            if (addHeader)
            {
                hb.GridHeader(
                    columnCollection: siteSettings.GridColumnCollection(), 
                    formData: formData,
                    checkAll: checkAll);
            }
            binaryCollection.ForEach(binaryModel => hb
                .Tr(
                    attributes: new HtmlAttributes()
                        .Class("grid-row")
                        .DataId(binaryModel.BinaryId.ToString()),
                    action: () =>
                    {
                        hb.Td(action: () => hb
                            .CheckBox(
                                controlCss: "grid-check",
                                _checked: checkAll,
                                dataId: binaryModel.BinaryId.ToString()));
                        siteSettings.GridColumnCollection()
                            .ForEach(column => hb
                                .TdValue(
                                    column: column,
                                    binaryModel: binaryModel));
                    }));
            return hb;
        }

        private static SqlColumnCollection GridSqlColumnCollection(SiteSettings siteSettings)
        {
            var select = Rds.BinariesColumn()
                .BinaryId()
                .Creator()
                .Updator();
            siteSettings.GridColumnCollection(withTitle: true).ForEach(columnGrid =>
            {
                switch (columnGrid.ColumnName)
                {
                    case "ReferenceId": select.ReferenceId(); break;
                    case "BinaryId": select.BinaryId(); break;
                    case "Ver": select.Ver(); break;
                    case "BinaryType": select.BinaryType(); break;
                    case "Title": select.Title(); break;
                    case "Body": select.Body(); break;
                    case "Bin": select.Bin(); break;
                    case "Thumbnail": select.Thumbnail(); break;
                    case "Icon": select.Icon(); break;
                    case "FileName": select.FileName(); break;
                    case "Extension": select.Extension(); break;
                    case "Size": select.Size(); break;
                    case "BinarySettings": select.BinarySettings(); break;
                    case "Comments": select.Comments(); break;
                    case "Creator": select.Creator(); break;
                    case "Updator": select.Updator(); break;
                    case "CreatedTime": select.CreatedTime(); break;
                    case "UpdatedTime": select.UpdatedTime(); break;
                }
            });
            return select;
        }

        public static HtmlBuilder TdValue(
            this HtmlBuilder hb, Column column, BinaryModel binaryModel)
        {
            switch (column.ColumnName)
            {
                case "Ver": return hb.Td(column: column, value: binaryModel.Ver);
                case "Comments": return hb.Td(column: column, value: binaryModel.Comments);
                case "Creator": return hb.Td(column: column, value: binaryModel.Creator);
                case "Updator": return hb.Td(column: column, value: binaryModel.Updator);
                case "CreatedTime": return hb.Td(column: column, value: binaryModel.CreatedTime);
                case "UpdatedTime": return hb.Td(column: column, value: binaryModel.UpdatedTime);
                default: return hb;
            }
        }

        public static string EditorNew()
        {
            return Editor(new BinaryModel(
                SiteSettingsUtility.BinariesSiteSettings(),
                Permissions.Admins(),
                methodType: BaseModel.MethodTypes.New));
        }

        public static string Editor(long binaryId, bool clearSessions)
        {
            var binaryModel = new BinaryModel(
                SiteSettingsUtility.BinariesSiteSettings(),
                Permissions.Admins(),
                binaryId: binaryId,
                clearSessions: clearSessions,
                methodType: BaseModel.MethodTypes.Edit);
            binaryModel.SwitchTargets = BinariesUtility.GetSwitchTargets(
                SiteSettingsUtility.BinariesSiteSettings());
            return Editor(binaryModel);
        }

        public static string Editor(BinaryModel binaryModel)
        {
            var hb = new HtmlBuilder();
            var permissionType = Permissions.Admins();
            var siteSettings = SiteSettingsUtility.BinariesSiteSettings();
            return hb.Template(
                siteId: 0,
                referenceId: "Binaries",
                title: binaryModel.MethodType == BaseModel.MethodTypes.New
                    ? Displays.Binaries() + " - " + Displays.New()
                    : binaryModel.Title.Value,
                permissionType: permissionType,
                verType: binaryModel.VerType,
                methodType: binaryModel.MethodType,
                allowAccess:
                    permissionType.CanEditTenant() &&
                    binaryModel.AccessStatus != Databases.AccessStatuses.NotFound,
                action: () =>
                {
                    permissionType = Permissions.Types.Manager;
                    hb
                        .Editor(
                            binaryModel: binaryModel,
                            permissionType: permissionType,
                            siteSettings: siteSettings)
                        .Hidden(controlId: "TableName", value: "Binaries")
                        .Hidden(controlId: "Id", value: binaryModel.BinaryId.ToString());
                }).ToString();
        }

        private static HtmlBuilder Editor(
            this HtmlBuilder hb,
            BinaryModel binaryModel,
            Permissions.Types permissionType,
            SiteSettings siteSettings)
        {
            return hb.Div(css: "edit-form", action: () => hb
                .Form(
                    attributes: new HtmlAttributes()
                        .Id_Css("BinaryForm", "main-form")
                        .Action(binaryModel.BinaryId != 0
                            ? Navigations.Action("Binaries", binaryModel.BinaryId)
                            : Navigations.Action("Binaries")),
                    action: () => hb
                        .RecordHeader(
                            id: binaryModel.BinaryId,
                            baseModel: binaryModel,
                            tableName: "Binaries",
                            switchTargets: binaryModel.SwitchTargets?
                                .Select(o => o.ToLong()).ToList())
                        .Div(css: "edit-form-comments", action: () => hb
                            .Comments(
                                comments: binaryModel.Comments,
                                verType: binaryModel.VerType))
                        .Div(css: "edit-form-tabs", action: () => hb
                            .FieldTabs(binaryModel: binaryModel)
                            .FieldSetGeneral(
                                siteSettings: siteSettings,
                                permissionType: permissionType,
                                binaryModel: binaryModel)
                            .FieldSet(
                                attributes: new HtmlAttributes()
                                    .Id("FieldSetHistories")
                                    .DataAction("Histories")
                                    .DataMethod("get"),
                                _using: binaryModel.MethodType != BaseModel.MethodTypes.New)
                            .MainCommands(
                                siteId: 0,
                                permissionType: permissionType,
                                verType: binaryModel.VerType,
                                backUrl: Navigations.Index("Binaries"),
                                referenceType: "Binaries",
                                referenceId: binaryModel.BinaryId,
                                updateButton: true,
                                mailButton: true,
                                deleteButton: true,
                                extensions: () => hb
                                    .MainCommandExtensions(
                                        binaryModel: binaryModel,
                                        siteSettings: siteSettings)))
                        .Hidden(
                            controlId: "MethodType",
                            value: binaryModel.MethodType.ToString().ToLower())
                        .Hidden(
                            controlId: "Binaries_Timestamp",
                            css: "must-transport",
                            value: binaryModel.Timestamp)
                        .Hidden(
                            controlId: "SwitchTargets",
                            css: "must-transport",
                            value: binaryModel.SwitchTargets?.Join()))
                .OutgoingMailsForm("Binaries", binaryModel.BinaryId, binaryModel.Ver)
                .Dialog_Copy("Binaries", binaryModel.BinaryId)
                .Dialog_OutgoingMail()
                .EditorExtensions(binaryModel: binaryModel, siteSettings: siteSettings));
        }

        private static HtmlBuilder FieldTabs(this HtmlBuilder hb, BinaryModel binaryModel)
        {
            return hb.Ul(css: "field-tab", action: () => hb
                .Li(action: () => hb
                    .A(
                        href: "#FieldSetGeneral", 
                        text: Displays.Basic()))
                .Li(
                    _using: binaryModel.MethodType != BaseModel.MethodTypes.New,
                    action: () => hb
                        .A(
                            href: "#FieldSetHistories",
                            text: Displays.Histories())));
        }

        private static HtmlBuilder FieldSetGeneral(
            this HtmlBuilder hb,
            SiteSettings siteSettings,
            Permissions.Types permissionType,
            BinaryModel binaryModel)
        {
            return hb.FieldSet(id: "FieldSetGeneral", action: () =>
            {
                siteSettings.ColumnCollection
                    .Where(o => o.EditorVisible.ToBool())
                    .OrderBy(o => siteSettings.EditorColumnsOrder.IndexOf(o.ColumnName))
                    .ForEach(column =>
                    {
                        switch (column.ColumnName)
                        {
                            case "ReferenceId": hb.Field(siteSettings, column, binaryModel.MethodType, binaryModel.ReferenceId.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                            case "BinaryId": hb.Field(siteSettings, column, binaryModel.MethodType, binaryModel.BinaryId.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                            case "Ver": hb.Field(siteSettings, column, binaryModel.MethodType, binaryModel.Ver.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                            case "BinaryType": hb.Field(siteSettings, column, binaryModel.MethodType, binaryModel.BinaryType.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                            case "Title": hb.Field(siteSettings, column, binaryModel.MethodType, binaryModel.Title.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                            case "Body": hb.Field(siteSettings, column, binaryModel.MethodType, binaryModel.Body.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                            case "FileName": hb.Field(siteSettings, column, binaryModel.MethodType, binaryModel.FileName.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                            case "Extension": hb.Field(siteSettings, column, binaryModel.MethodType, binaryModel.Extension.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                            case "Size": hb.Field(siteSettings, column, binaryModel.MethodType, binaryModel.Size.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                        }
                    });
                hb.VerUpCheckBox(binaryModel);
            });
        }

        private static HtmlBuilder MainCommandExtensions(
            this HtmlBuilder hb,
            BinaryModel binaryModel,
            SiteSettings siteSettings)
        {
            return hb;
        }

        private static HtmlBuilder EditorExtensions(
            this HtmlBuilder hb,
            BinaryModel binaryModel,
            SiteSettings siteSettings)
        {
            return hb;
        }

        public static List<long> GetSwitchTargets(SiteSettings siteSettings)
        {
            var switchTargets = Forms.Data("SwitchTargets").Split(',')
                .Select(o => o.ToLong())
                .Where(o => o != 0)
                .ToList();
            if (switchTargets.Count() == 0)
            {
                var formData = DataViewFilters.SessionFormData();
                switchTargets = Rds.ExecuteTable(
                    transactional: false,
                    statements: Rds.SelectBinaries(
                        column: Rds.BinariesColumn().BinaryId(),
                        where: DataViewFilters.Get(
                            siteSettings: siteSettings,
                            tableName: "Binaries",
                            formData: formData,
                            where: Rds.BinariesWhere()),
                        orderBy: GridSorters.Get(
                            formData, Rds.BinariesOrderBy().UpdatedTime(SqlOrderBy.Types.desc))))
                                .AsEnumerable()
                                .Select(o => o["BinaryId"].ToLong())
                                .ToList();    
            }
            return switchTargets;
        }

        public static ResponseCollection FormResponse(
            this ResponseCollection responseCollection, BinaryModel binaryModel)
        {
            Forms.All().Keys.ForEach(key =>
            {
                switch (key)
                {
                    default: break;
                }
            });
            return responseCollection;
        }
    }
}